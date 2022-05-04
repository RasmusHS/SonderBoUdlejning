using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SonderBoUdlejning.SQLBuilders;

namespace SonderBoUdlejning.personCRUD
{
    public class pDelete
    {
        ConnString connString = ConnString.getConnInstance;

        public void pSQLD(string pTlf)
        {
            string sqlS = "DELETE FROM Person WHERE pTlf = @Tlf";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(sqlS, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
            cmd.Parameters["@Tlf"].Value = Convert.ToInt32(pTlf);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" + cmd.Parameters["@Tlf"].Value + ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
