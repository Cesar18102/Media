using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Market
{
    public partial class ParseForm : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;
        
        private int GEN_ID = -1;
        private int AUTH_ID = -1;

        public ParseForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT COALESCE(MAX(id), 0) + 1 AS mid FROM genre");
            DT = new DataTable();
            MDA.Fill(DT);
            GEN_ID = Convert.ToInt32(DT.Rows[0]["mid"]);

            DataTable ADT = new DataTable();
            MDA.SelectCommand = new MySqlCommand("SELECT COALESCE(MAX(id), 0) + 1 AS mid FROM author", MSC);
            MDA.Fill(ADT);
            AUTH_ID = Convert.ToInt32(ADT.Rows[0]["mid"]);
        }

        Regex Titles = new Regex("<header class=\"title\"><a href=\"https://www.yakaboo.ua/music.html\">РњСѓР·С‹РєР°</a></header>\\s*<ul class=\"sub-menu__list\">(\\s*<li><a href=\".{0,150}\">.{0,150}</a></li>\\s*)*", RegexOptions.Singleline);
        Regex Title = new Regex("<li><a href=\".{0,150}\">.{0,150}</a></li>", RegexOptions.Singleline);
        Regex DiskName = new Regex("<div class=\"full-name\">\\s*.{0,300}\\s*</div>", RegexOptions.Singleline);
        Regex DiskPrice = new Regex("<span class=\"price\">.{0,20}<span class=\"currency\">.{0,20}</span>\\s*</span>", RegexOptions.Singleline);
        Regex OK = new Regex("[A-Za-zА-Яа-я0-9\\s\\-\\.\\?,()]+", RegexOptions.Singleline);

        Encoding WIN1251 = Encoding.GetEncoding("windows-1251");
        Encoding UNICODE = Encoding.Unicode;

        List<string> GENRES_LINKS = new List<string>();
        List<string> GENRES = new List<string>();
        List<int> GENRE_IDS = new List<int>();

        string Buffer = "";

        private void ParseForm_Load(object sender, EventArgs e)
        {
            Update.Start();

            Task.Factory.StartNew(Parse);
        }

        private void Parse()
        {
            WebClient WC = new WebClient();
            string MainPage = WC.DownloadString("https://www.yakaboo.ua/music.html");

            string TITLES = Titles.Match(MainPage).ToString();
            foreach (Match M in Title.Matches(TITLES))
            {

                string LI = M.ToString().Replace("<li>", "").Replace("</li>", "");

                int BrIndex = LI.IndexOf(">");
                int HttpIndex = LI.IndexOf("http");

                string HREF = LI.Substring(HttpIndex, BrIndex - 1 - HttpIndex);
                string TEXT = ToWIN1251(LI.Substring(BrIndex + 1, LI.LastIndexOf("<") - BrIndex - 1));

                GENRES_LINKS.Add(HREF);
                GENRES.Add(TEXT);
                GENRE_IDS.Add(GEN_ID);

                MySqlCommand C = new MySqlCommand("INSERT INTO genre (id, name) " +
                                                  "SELECT * FROM (SELECT @id, @name) AS tmp " +
                                                  "WHERE NOT EXISTS (" +
                                                        "SELECT name FROM genre WHERE name = @name" +
                                                  ") LIMIT 1;", MSC);

                C.Parameters.Add("@id", GEN_ID++);
                C.Parameters.Add("@name", TEXT);

                C.ExecuteNonQuery();


                Buffer += DateTime.Now.ToString() + ": ЖАНР " + TEXT + " ДОБАВЛЕН" + Environment.NewLine;

                for (int i = 1; ; i++)
                {
                    string DISKS = WC.DownloadString(HREF + "?p=" + i);

                    MatchCollection DN = DiskName.Matches(DISKS);
                    MatchCollection DP = DiskPrice.Matches(DISKS);

                    if (DN.Count == 0)
                        break;

                    for (int j = 0; j < DN.Count; j++)
                    {
                        try
                        {
                            string[] DISK_INFO = DN[j].ToString().Replace("<div class=\"full-name\">", "").Replace("</div>", "").Replace("\n", "").Trim().Split(':', '-');
                            string Author = DISK_INFO[0];
                            string Name = DISK_INFO[1].Substring(1);

                            string DISK_PRICE = new Regex("<span class=\"currency\">.{0,20}</span>\\s*</span>").Replace(DP[j].ToString().Replace("<span class=\"price\">", "").Replace("\n", ""), "").Trim();

                            if (OK.IsMatch(Author) && OK.IsMatch(Name))
                            {
                                MySqlCommand CAUTH = new MySqlCommand("INSERT INTO author (id, name) " +
                                                                      "SELECT * FROM (SELECT @id, @name) AS tmp " +
                                                                      "WHERE NOT EXISTS (" +
                                                                            "SELECT name FROM author WHERE name = @name" +
                                                                      ") LIMIT 1;", MSC);

                                CAUTH.Parameters.Add("@id", AUTH_ID++);
                                CAUTH.Parameters.Add("@name", Author);

                                CAUTH.ExecuteNonQuery();

                                MySqlCommand CDISK = new MySqlCommand("INSERT INTO disc (id, name, price, author_id, genre_id) " +
                                                                      "SELECT * FROM (SELECT 0, @name, @price, (SELECT id FROM author WHERE name = @aname), (SELECT id FROM genre WHERE name = @gname)) AS tmp " +
                                                                      "WHERE NOT EXISTS (" +
                                                                            "SELECT name FROM disc WHERE name = @name" +
                                                                      ") LIMIT 1;", MSC);

                                CDISK.Parameters.Add("@name", Name);
                                CDISK.Parameters.Add("@price", DISK_PRICE.Substring(0, DISK_PRICE.Length - 1));
                                CDISK.Parameters.Add("@aname", Author);
                                CDISK.Parameters.Add("@gname", TEXT);

                                CDISK.ExecuteNonQuery();

                                Buffer += DateTime.Now.ToString() + ": ДИСК " + Name + " АВТОРА " + Author + " ЗА " + DISK_PRICE + " ДОБАВЛЕН" + Environment.NewLine;
                            }
                        }
                        catch (Exception ex) { };
                    }
                }

                Buffer += DateTime.Now.ToString() + ": ДОБАВЛЕНИЕ ДИСКОВ ЖАНРА " + TEXT + " ОКОНЧЕНО" + Environment.NewLine;
            }
        }

        private string ToWIN1251(string str)
        {
            byte[] UTF8_BYTES = WIN1251.GetBytes(str);
            UTF8_BYTES = Encoding.Convert(Encoding.UTF8, WIN1251, UTF8_BYTES);
            return WIN1251.GetString(UTF8_BYTES);
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            Log.Text += Buffer;
            Buffer = "";
        }
    }
}
