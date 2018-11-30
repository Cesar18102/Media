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
    public partial class AuthorForm : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();

        public AuthorForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT * FROM author");
            Update();
        }

        private void AddProvider_Click(object sender, EventArgs e)
        {
            int MPID = Constants.GetMaxID(ref MSC, "SELECT MAX(id) AS id FROM author") + 1;

            MySqlCommand C = new MySqlCommand("INSERT INTO author VALUES(@id, @fullname)", MSC);

            C.Parameters.Add("@id", MPID);
            C.Parameters.Add("@fullname", AuthorSurname.Text + " " + AuthorName.Text + " " + AuthorFathername.Text);

            C.ExecuteNonQuery();

            Update();

            MessageBox.Show("Автор успешно добавлен!");
        }

        private void RemoveProvider_Click(object sender, EventArgs e)
        {
            if(!IDS.Contains(Convert.ToInt32(DelID.Value)))
            {
                MessageBox.Show("Автора с указанным ID не существует!");
                return;
            }

            MySqlCommand C = new MySqlCommand("DELETE FROM author WHERE id=@id", MSC);
            C.Parameters.Add("@id", Convert.ToInt32(DelID.Value));
            C.ExecuteNonQuery();

            Update();

            MessageBox.Show("Автор успешно удален!");
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            AuthorList.DataSource = DT;

            for (int i = 0; i < AuthorList.RowCount; i++)
                IDS.Add(Convert.ToInt32(AuthorList.Rows[i].Cells["id"].Value));

            if (IDS.Count == 0)
                RemoveAuthor.Enabled = false;
            else
            {
                RemoveAuthor.Enabled = true;
                DelID.Minimum = IDS.Min();
                DelID.Maximum = IDS.Max();
            }
        }
    }
}
