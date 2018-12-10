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
    public partial class Purchase : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();

        private List<int> Disc_IDS = new List<int>();
        private List<int> Client_IDS = new List<int>();
        private List<int> Seller_IDS = new List<int>();

        private int SEL_ROW = -1;

        public Purchase()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT P.id AS ID, D.name AS ДИСК, C.name AS КЛИЕНТ, S.name AS ПРОДАВЕЦ " + 
                                             "FROM purchase P, disc D, client C, seller S " + 
                                             "WHERE P.disk_id = D.id AND P.client_id = C.id AND P.seller_id = S.id");
            Update();
            UpdateDrops();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            Constants.DataGridViewRowSelected(DealList, ref SEL_ROW, 0);
        }

        private void DealList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Constants.DataGridViewRowSelected(DealList, ref SEL_ROW, e.RowIndex);
        }

        private void AddDeal_Click(object sender, EventArgs e)
        {
            MySqlCommand C = new MySqlCommand("INSERT INTO purchase VALUES(@id, @disk_id, @client_id, @seller_id)", MSC);

            C.Parameters.Add("@id", 0);
            C.Parameters.Add("@disk_id", Disc_IDS[Disc.SelectedIndex]);
            C.Parameters.Add("@client_id", Client_IDS[Client.SelectedIndex]);
            C.Parameters.Add("@seller_id", Seller_IDS[Seller.SelectedIndex]);

            C.ExecuteNonQuery();

            Update();
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            DealList.DataSource = DT;

            Constants.DataGridViewRowSelected(DealList, ref SEL_ROW, SEL_ROW);
        }

        private void UpdateDrops()
        {
            Disc.Items.Clear();

            Client.Items.Clear();
            Seller.Items.Clear();

            SellerVAL.Items.Clear();
            ClientVAL.Items.Clear();

            MySqlDataAdapter Client_DA = new MySqlDataAdapter();
            Client_DA.SelectCommand = new MySqlCommand("SELECT * FROM client", MSC);

            DataTable Client_DT = new DataTable();
            Client_DA.Fill(Client_DT);

            for (int i = 0; i < Client_DT.Rows.Count; i++)
            {

                Client_IDS.Add(Convert.ToInt32(Client_DT.Rows[i]["id"]));
                Client.Items.Add(Client_DT.Rows[i]["name"].ToString());
                ClientVAL.Items.Add(Client_DT.Rows[i]["name"].ToString());
            }


            MySqlDataAdapter Seller_DA = new MySqlDataAdapter();
            Seller_DA.SelectCommand = new MySqlCommand("SELECT * FROM seller", MSC);

            DataTable Seller_DT = new DataTable();
            Seller_DA.Fill(Seller_DT);

            for (int i = 0; i < Seller_DT.Rows.Count; i++)
            {

                Seller_IDS.Add(Convert.ToInt32(Seller_DT.Rows[i]["id"]));
                Seller.Items.Add(Seller_DT.Rows[i]["name"].ToString());
                SellerVAL.Items.Add(Seller_DT.Rows[i]["name"].ToString());
            }

            MySqlDataAdapter Disc_DA = new MySqlDataAdapter();
            Disc_DA.SelectCommand = new MySqlCommand("SELECT * FROM disc", MSC);

            DataTable Disc_DT = new DataTable();
            Disc_DA.Fill(Disc_DT);

            for (int i = 0; i < Disc_DT.Rows.Count; i++)
            {

                Disc_IDS.Add(Convert.ToInt32(Disc_DT.Rows[i]["id"]));
                Disc.Items.Add(Disc_DT.Rows[i]["name"].ToString());
            }


            if (Disc_IDS.Count == 0 || Client_IDS.Count == 0 || Seller_IDS.Count == 0)
            {

                AddDeal.Enabled = false;

                ClientCB.Checked = false;
                ClientCB.Enabled = false;

                SellerCB.Checked = false;
                SellerCB.Enabled = false;
            }
            else
            {

                AddDeal.Enabled = true;
                ClientCB.Enabled = true;
                SellerCB.Enabled = true;

                Disc.SelectedIndex = 0;
                Client.SelectedIndex = 0;
                Seller.SelectedIndex = 0;
                ClientVAL.SelectedIndex = 0;
                SellerVAL.SelectedIndex = 0;
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            string Condition = "";

            if (ClientCB.Checked && ClientVAL.SelectedIndex != -1)
                Condition += "P.client_id=" + Client_IDS[ClientVAL.SelectedIndex];

            if (SellerCB.Checked && SellerVAL.SelectedIndex != -1)
                Condition += (Condition == ""? "" : " AND ") + "P.seller_id=" + Seller_IDS[SellerVAL.SelectedIndex];

            MDA.SelectCommand = new MySqlCommand("SELECT P.id AS ID, D.name AS ДИСК, C.name AS КЛИЕНТ, S.name AS ПРОДАВЕЦ " + 
                                                 "FROM purchase P, disc D, client C, seller S " + 
                                                 "WHERE P.disk_id = D.id AND P.client_id = C.id AND P.seller_id = S.id" + 
                                                 (Condition == "" ? "" : " AND " + Condition), MSC);

            Update();
        }
    }
}
