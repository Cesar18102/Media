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
    public partial class Summary : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        public Summary()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            Constants.Init(ref MSC, ref MDA, "SELECT SUM(D.price) AS got FROM purchase P, disc D WHERE P.disk_id = D.id");

            DT = new DataTable();
            MDA.Fill(DT);

            double got = Convert.ToDouble(DT.Rows[0]["got"] == DBNull.Value ? 0 : DT.Rows[0]["got"]);

            Profit.Text = got.ToString();
        }

    }
}
