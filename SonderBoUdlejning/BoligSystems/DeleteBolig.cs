using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SonderBoUdlejning.InputCheck;

namespace SonderBoUdlejning.BoligSystems
{
    internal class DeleteBolig
    {
        ConnString connString = ConnString.getConnInstance;

        public void deleteBolig(string adresse)
        {
            string sqlS = "DELETE FROM Bolig WHERE adresse = @adresse";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(sqlS, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@adresse"].Value = Convert.ToString(adresse);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" + cmd.Parameters["@adresse"].Value + ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
