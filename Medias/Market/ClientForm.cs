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
    public partial class ClientForm : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();

        public ClientForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT * FROM client");
            Update();
        }

        private void HireWorker_Click(object sender, EventArgs e)
        {
            MySqlCommand C = new MySqlCommand("INSERT INTO client VALUES(@id, @fullname, @mail, @phone)", MSC);

            C.Parameters.Add("@id", 0);
            C.Parameters.Add("@fullname", ClientSurname.Text + " " + ClientName.Text + " " + ClientFathername.Text);
            C.Parameters.Add("@mail", ClientMail.Text);
            C.Parameters.Add("@phone", ClientPhone.Text);

            C.ExecuteNonQuery();

            Update();

            MessageBox.Show("Клиент успешно добавлен!");
        }

        private void FireWorker_Click(object sender, EventArgs e)
        {
            if (!IDS.Contains(Convert.ToInt32(DelID.Value)))
            {
                MessageBox.Show("Клиента с указанным ID не существует!");
                return;
            }

            MySqlCommand C = new MySqlCommand("DELETE FROM client WHERE id=@id", MSC);

            C.Parameters.Add("@id", Convert.ToInt32(DelID.Value));

            C.ExecuteNonQuery();
            Update();

            MessageBox.Show("Клиент успешно удален!");
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            ClientList.DataSource = DT;

            for (int i = 0; i < ClientList.RowCount; i++)
                IDS.Add(Convert.ToInt32(ClientList.Rows[i].Cells["id"].Value));

            if (IDS.Count == 0)
                FireWorker.Enabled = false;
            else
            {
                FireWorker.Enabled = true;
                DelID.Minimum = IDS.Min();
                DelID.Maximum = IDS.Max();
            }
        }
    }
}
