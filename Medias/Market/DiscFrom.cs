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

namespace Market
{
    public partial class DiscFrom : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();
        private List<int> Author_IDS = new List<int>();
        private List<int> Genre_IDS = new List<int>();

        private int SEL_ROW = -1;
        
        public DiscFrom()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT D.id AS ID, D.name AS НАЗВАНИЕ, D.price AS ЦЕНА, A.name AS АВТОР, G.name AS ЖАНР " + 
                                             "FROM disc D, Author A, Genre G " + 
                                             "WHERE D.author_id = A.id AND D.genre_id = G.id");
            Update();
            UpdateDGV();
        }

        private void DiscFrom_Load(object sender, EventArgs e)
        {
            Constants.DataGridViewRowSelected(DiscList, ref SEL_ROW, 0);
        }

        private void DiscList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Constants.DataGridViewRowSelected(DiscList, ref SEL_ROW, e.RowIndex);
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            int MPID = Constants.GetMaxID(ref MSC, "SELECT MAX(id) AS id FROM disc") + 1;

            MySqlCommand C = new MySqlCommand("INSERT INTO disc VALUES(@id, @name, @price, @author_id, @genre_id)", MSC);

            C.Parameters.Add("@id", MPID);
            C.Parameters.Add("@name", DiscName.Text);
            C.Parameters.Add("@price", Convert.ToDouble(DiscPrice.Value));
            C.Parameters.Add("@author_id", Author_IDS[DiscAuthor.SelectedIndex]);
            C.Parameters.Add("@genre_id", Genre_IDS[DiscGenre.SelectedIndex]);

            C.ExecuteNonQuery();

            UpdateDGV();

            MessageBox.Show("Диск успешно добавлен!");
        }

        private void RemoveProduct_Click(object sender, EventArgs e)
        {
            if (!IDS.Contains(Convert.ToInt32(DelId.Value)))
            {
                MessageBox.Show("Диска с указанным ID не существует!");
                return;
            }

            MySqlCommand C = new MySqlCommand("DELETE FROM disc WHERE id=@id", MSC);

            C.Parameters.Add("@id", Convert.ToInt32(DelId.Value));

            C.ExecuteNonQuery();

            UpdateDGV();

            MessageBox.Show("Диск успешно удален!");
        }

        private void UpdateDGV()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            DiscList.DataSource = DT;

            Constants.DataGridViewRowSelected(DiscList, ref SEL_ROW, SEL_ROW);

            for (int i = 0; i < DiscList.RowCount; i++)
                IDS.Add(Convert.ToInt32(DiscList.Rows[i].Cells["id"].Value));

            if (IDS.Count == 0)
                RemoveDisc.Enabled = false;
            else
            {
                RemoveDisc.Enabled = true;
                DelId.Minimum = IDS.Min();
                DelId.Maximum = IDS.Max();
            }
        }

        private void Update()
        {
            MySqlDataAdapter Author_DA = new MySqlDataAdapter();
            Author_DA.SelectCommand = new MySqlCommand("SELECT * FROM author", MSC);

            DataTable Author_DT = new DataTable();
            Author_DA.Fill(Author_DT);

            for (int i = 0; i < Author_DT.Rows.Count; i++) {

                Author_IDS.Add(Convert.ToInt32(Author_DT.Rows[i]["id"]));
                DiscAuthor.Items.Add(Author_DT.Rows[i]["name"].ToString());
            }


            MySqlDataAdapter Genre_DA = new MySqlDataAdapter();
            Genre_DA.SelectCommand = new MySqlCommand("SELECT * FROM genre", MSC);

            DataTable Genre_DT = new DataTable();
            Genre_DA.Fill(Genre_DT);

            for (int i = 0; i < Genre_DT.Rows.Count; i++) {

                Genre_IDS.Add(Convert.ToInt32(Genre_DT.Rows[i]["id"]));
                DiscGenre.Items.Add(Genre_DT.Rows[i]["name"].ToString());
            }


            if (Author_IDS.Count == 0 || Genre_IDS.Count == 0)
                AddDisc.Enabled = false;
            else
            {
                AddDisc.Enabled = true;
                DiscAuthor.SelectedIndex = 0;
                DiscGenre.SelectedIndex = 0;
            }
        }

        private void SearchName_TextChanged(object sender, EventArgs e)
        {
            MDA.SelectCommand = new MySqlCommand("SELECT D.id AS ID, D.name AS НАЗВАНИЕ, D.price AS ЦЕНА, A.name AS АВТОР, G.name AS ЖАНР " +
                                                "FROM disc D, Author A, Genre G " +
                                                "WHERE D.author_id = A.id AND D.genre_id = G.id AND INSTR(D.name, '" + SearchName.Text + "') = 1", MSC);

            UpdateDGV();
        }
    }
}