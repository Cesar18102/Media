using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Market
{
    public class Constants
    {
        public static string ConnectionString = "Server=localhost;Database=medias;User Id=root;";

        public static void Init(ref MySqlConnection MSC, ref MySqlDataAdapter MDA, string SelectCommand)
        {
            MSC = new MySqlConnection(Constants.ConnectionString);
            MSC.Open();

            MDA = new MySqlDataAdapter();
            MDA.SelectCommand = new MySqlCommand(SelectCommand, MSC);
        }

        public static int GetMaxID(ref MySqlConnection MSC, string SelectCommand)
        {
            MySqlDataAdapter MDA_SID = new MySqlDataAdapter();
            DataTable DT_SID = new DataTable();

            MDA_SID.SelectCommand = new MySqlCommand(SelectCommand, MSC);
            MDA_SID.Fill(DT_SID);

            return DT_SID.Rows[0]["id"] == DBNull.Value? 0 : Convert.ToInt32(DT_SID.Rows[0]["id"]);
        }

        public static string FormatDateTime(DateTime DT)
        {
            return DT.Year + "-" + DT.Month + "-" + DT.Day;
        }
    }
}
