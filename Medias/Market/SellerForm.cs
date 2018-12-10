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
    public partial class SellerForm : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();

        private int SEL_ROW = -1;

        public SellerForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT * FROM seller");
            Update();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            Constants.DataGridViewRowSelected(SellerList, ref SEL_ROW, 0);
        }

        private void SellerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Constants.DataGridViewRowSelected(SellerList, ref SEL_ROW, e.RowIndex);
        }

        private void AddSeller_Click(object sender, EventArgs e)
        {
            int MPID = Constants.GetMaxID(ref MSC, "SELECT MAX(id) AS id FROM seller") + 1;

            MySqlCommand C = new MySqlCommand("INSERT INTO seller VALUES(@id, @fullname)", MSC);

            C.Parameters.Add("@id", MPID);
            C.Parameters.Add("@fullname", SellerSurname.Text + " " + SellerName.Text + " " + SellerFathername.Text);

            C.ExecuteNonQuery();

            Update();

            MessageBox.Show("Продавец успешно добавлен!");
        }

        private void RemoveSeller_Click(object sender, EventArgs e)
        {
            if (!IDS.Contains(Convert.ToInt32(DelID.Value)))
            {
                MessageBox.Show("Продавца с указанным ID не существует!");
                return;
            }

            MySqlCommand C = new MySqlCommand("DELETE FROM seller WHERE id=@id", MSC);
            C.Parameters.Add("@id", Convert.ToInt32(DelID.Value));
            C.ExecuteNonQuery();

            Update();

            MessageBox.Show("Продавец успешно удален!");
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            SellerList.DataSource = DT;

            Constants.DataGridViewRowSelected(SellerList, ref SEL_ROW, SEL_ROW);

            for (int i = 0; i < SellerList.RowCount; i++)
                IDS.Add(Convert.ToInt32(SellerList.Rows[i].Cells["id"].Value));

            if (IDS.Count == 0)
                RemoveSeller.Enabled = false;
            else
            {
                RemoveSeller.Enabled = true;
                DelID.Minimum = IDS.Min();
                DelID.Maximum = IDS.Max();
            }
        }
    }
}
