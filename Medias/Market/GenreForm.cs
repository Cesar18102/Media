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
    public partial class GenreForm : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();

        private int SEL_ROW = -1;

        public GenreForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT * FROM genre");
            Update();
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            Constants.DataGridViewRowSelected(GenreList, ref SEL_ROW, 0);
        }

        private void GenreList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Constants.DataGridViewRowSelected(GenreList, ref SEL_ROW, e.RowIndex);
        }

        private void AddPost_Click(object sender, EventArgs e)
        {
            int MPID = Constants.GetMaxID(ref MSC, "SELECT MAX(id) AS id FROM genre") + 1;
            MySqlCommand C = new MySqlCommand("INSERT INTO genre VALUES(@id, @name)", MSC);

            C.Parameters.Add("@id", MPID);
            C.Parameters.Add("@name", GenreName.Text);

            C.ExecuteNonQuery();

            Update();

            MessageBox.Show("Жанр успешно добавлен!");
        }

        private void RemovePost_Click(object sender, EventArgs e)
        {
            if (!IDS.Contains(Convert.ToInt32(DelID.Value)))
            {
                MessageBox.Show("Жанара с указанным ID не существует!");
                return;
            }

            MySqlCommand C = new MySqlCommand("DELETE FROM genre WHERE id=@id", MSC);
            C.Parameters.Add("@id", Convert.ToInt32(DelID.Value));
            C.ExecuteNonQuery();

            Update();
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            GenreList.DataSource = DT;

            Constants.DataGridViewRowSelected(GenreList, ref SEL_ROW, SEL_ROW);

            for (int i = 0; i < GenreList.RowCount; i++)
                IDS.Add(Convert.ToInt32(GenreList.Rows[i].Cells["id"].Value));

            if (IDS.Count == 0)
                RemoveGenre.Enabled = false;
            else
            {
                RemoveGenre.Enabled = true;
                DelID.Minimum = IDS.Min();
                DelID.Maximum = IDS.Max();
            }
        }
    }
}
