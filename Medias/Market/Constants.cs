using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Market
{
    public class Constants
    {
        public static Color SEL_COL = Color.LightGray;
        public static Color NOR_COL = Color.White;

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

        public static void DataGridViewRowSelected(DataGridView DGV, ref int OLD_ROW, int NEW_ROW)
        {
            ColorDataGridRow(DGV, OLD_ROW, NOR_COL);
            ColorDataGridRow(DGV, NEW_ROW, SEL_COL);

            OLD_ROW = NEW_ROW;
        }

        public static void ColorDataGridRow(DataGridView DGV, int ROW_ID, Color C)
        {
            if (ROW_ID >= 0 && ROW_ID < DGV.Rows.Count)
                for (int i = 0; i < DGV.ColumnCount; i++)
                    DGV.Rows[ROW_ID].Cells[i].Style.BackColor = C;
        }
    }
}
