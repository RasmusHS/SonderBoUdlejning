using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SonderBoUdlejning.InputCheck;

namespace SonderBoUdlejning
{
    //Currently not in use, mya delete later
    internal class RefreshDGV
    {
        ConnString connString = ConnString.getConnInstance;

        public string RefreshFormDGV(string tableName)
        {
            string sqlS = $"SELECT * FROM {tableName}";
            
            SqlConnection conn = new SqlConnection(connString.connStr);
            //SqlCommand cmd = new SqlCommand(sqlS, conn);

            try
            {
                conn.Open();
                if ((ErrorMessage.injectedSQL == 1))
                {
                    sqlS = "";
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    return sqlS;
                }

                return sqlS;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ex.ToString();
            }
        }
    }
}
