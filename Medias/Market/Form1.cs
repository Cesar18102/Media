using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Word;
using System.IO;

namespace Market
{
    public partial class Form1 : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private Word.Application Application;
        private Word.Document Document;
        private Word.Range R;
        private Word.Table T;
        private Word.Paragraph P;
        private Object missingObj = System.Reflection.Missing.Value;
        private Object trueObj = true;
        private Object falseObj = false;

        public delegate string ValueAt<Q>(Q SP, int i);

        public Form1()
        {
            InitializeComponent();
        }

        private void Worker_Click(object sender, EventArgs e)
        {
            ClientForm WF = new ClientForm();
            WF.ShowDialog();
        }

        private void Post_Click(object sender, EventArgs e)
        {
            GenreForm PTF = new GenreForm();
            PTF.ShowDialog();
        }

        private void Provider_Click(object sender, EventArgs e)
        {
            AuthorForm PVF = new AuthorForm();
            PVF.ShowDialog();
        }

        private void Seller_Click(object sender, EventArgs e)
        {
            SellerForm SF = new SellerForm();
            SF.ShowDialog();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            DiscFrom PDF = new DiscFrom();
            PDF.ShowDialog();
        }

        private void Deal_Click(object sender, EventArgs e)
        {
            Purchase DF = new Purchase();
            DF.ShowDialog();
        }

        private void Summary_Click(object sender, EventArgs e)
        {
            Summary S = new Summary();
            S.ShowDialog();
        }

        private void SypplyReport_Click(object sender, EventArgs e)
        {
            Constants.Init(ref MSC, ref MDA, "SELECT D.name, D.price, (SELECT A.name FROM author A WHERE D.author_id = A.id) as author," +
                                             "(SELECT G.name FROM genre G WHERE D.genre_id = G.id) AS genre FROM disc D");
            DataTable DT = new DataTable();
            MDA.Fill(DT);
            List<Disk> DSK = new List<Disk>();

            for (int i = 0; i < DT.Rows.Count; i++)
                DSK.Add(new Disk(DT.Rows[i]["name"].ToString(), Convert.ToDouble(DT.Rows[i]["price"]), DT.Rows[i]["author"].ToString(), DT.Rows[i]["genre"].ToString()));

            PrintWord<Disk>(new List<string>() { "Название диска", "Цена", "Автор", "Жанр" },
                            (D, i) => {

                                Disk DS = D as Disk;
                                switch (i) {

                                    case 0: return D.name; break;
                                    case 1: return D.price.ToString(); break;
                                    case 2: return D.author; break;
                                    case 3: return D.genre; break;
                                    default: return ""; break;
                                }
                            }, DSK, "Отчет по дискам");
        }

        private void DealReport_Click(object sender, EventArgs e)
        {
            Constants.Init(ref MSC, ref MDA, "SELECT (SELECT D.name FROM disc D WHERE D.id = P.disk_id) AS disc, " +
                                                    "(SELECT C.name FROM client C WHERE C.id = P.client_id) AS client, " + 
                                                    "(SELECT S.name FROM seller S WHERE S.id = P.seller_id) AS seller FROM purchase P");
            DataTable DT = new DataTable();
            MDA.Fill(DT);
            List<Supply> SPL = new List<Supply>();

            for (int i = 0; i < DT.Rows.Count; i++)
                SPL.Add(new Supply(DT.Rows[i]["disc"].ToString(), DT.Rows[i]["client"].ToString(), DT.Rows[i]["seller"].ToString()));


            PrintWord<Supply>(new List<string>() { "Название диска", "Клиент", "Продавец" },
                            (S, i) =>
                            {

                                Supply SP = S as Supply;
                                switch (i)
                                {

                                    case 0: return SP.disc; break;
                                    case 1: return SP.client; break;
                                    case 2: return SP.seller; break;
                                    default: return ""; break;
                                }
                            }, SPL, "Отчет по покупкам");
        }

        private void GenreStats_Click(object sender, EventArgs e)
        {
            Constants.Init(ref MSC, ref MDA, "SELECT D.name AS disk, A.name AS author, G.name AS genre, COUNT(P.id) AS count " +
                                                    "FROM disc D, author A, genre G, purchase P " +
                                                    "WHERE D.author_id = A.id AND D.genre_id = G.id AND P.disk_id = D.id " + 
                                                    "GROUP BY D.id");
            DataTable DT = new DataTable();
            MDA.Fill(DT);
            List<SELLS> SL = new List<SELLS>();

            for (int i = 0; i < DT.Rows.Count; i++)
                SL.Add(new SELLS(new Disk(DT.Rows[i]["disk"].ToString(), 0, 
                                          DT.Rows[i]["author"].ToString(), 
                                          DT.Rows[i]["genre"].ToString()), 
                                 Convert.ToInt32(DT.Rows[i]["count"])));


            PrintWord<SELLS>(new List<string>() { "Название диска", "Автор", "Жанр", "Количество проданных" },
                            (S, i) => {

                                SELLS SLS = S as SELLS;
                                switch (i) {

                                    case 0: return SLS.D.name; break;
                                    case 1: return SLS.D.author; break;
                                    case 2: return SLS.D.genre; break;
                                    case 3: return SLS.Count.ToString(); break;
                                    default: return ""; break;
                                }
                            }, SL, "Статистика продаж");
        }

        private void PrintWord<Q>(List<string> headers, ValueAt<Q> V, List<Q> Values, string head)
        {

            this.UseWaitCursor = true;
            FileStream FS = File.Create(Environment.CurrentDirectory + "/Print.doc");
            FS.Close();

            Application = new Word.Application();
            Object PrintPath = Environment.CurrentDirectory + "/Print.doc";

            Document = Application.Documents.Add(ref PrintPath, ref missingObj, ref missingObj, ref missingObj);
            Document.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            R = Document.Sections[1].Range;

            T = Document.Tables.Add(R, Values.Count + 3, headers.Count, missingObj, missingObj);
            T.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            T.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            T.Rows[1].Cells.Merge();
            T.Rows[1].Cells[1].Width = 698;
            T.Rows[1].Cells[1].Range.Text = head;
            T.Rows[1].Cells[1].Range.Font.Size = 18;
            T.Rows[1].Cells[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            T.Rows[1].Cells[1].Range.Borders.Enable = 0;

            for (int i = 1; i <= headers.Count; i++)
            {

                T.Rows[2].Cells[i].Width = 700 / headers.Count;
                T.Rows[2].Cells[i].Range.Text = headers[i - 1];

                T.Rows[2].Cells[i].Range.Font.Size = 14;
                T.Rows[2].Cells[i].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            }

            for (int i = 0; i < Values.Count; i++)
                for (int j = 0; j < headers.Count; j++)
                {
                    T.Rows[i + 3].Cells[j + 1].Width = 700 / headers.Count;
                    T.Rows[i + 3].Cells[j + 1].Range.Text = V(Values[i], j);
                }

            T.Rows[Values.Count + 3].Cells.Merge();
            T.Rows[Values.Count + 3].Cells[1].Range.Text = DateTime.Now.ToShortDateString();
            T.Rows[Values.Count + 3].Cells[1].Range.Font.Size = 14;
            T.Rows[Values.Count + 3].Cells[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            T.Rows[Values.Count + 3].Cells[1].Range.Borders.Enable = 0;

            try
            {
                Document.Save();
                Document.Close(missingObj, missingObj, missingObj);
            }
            catch { MessageBox.Show("Отчет не создан!", "Ошибка"); }

            this.UseWaitCursor = false;
        }

        private void Parse_Click(object sender, EventArgs e)
        {
            ParseForm PF = new ParseForm();
            PF.ShowDialog();
        }
    }
}
