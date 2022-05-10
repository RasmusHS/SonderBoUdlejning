using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning
{
    public class CreatePerson
    {
        ConnString connString = ConnString.getConnInstance;

        public void pSQLC(string fNavn, string pMail, string pTlf)
        {
            string sqlS = "INSERT INTO Person VALUES (@Navn, @Mail, @Tlf, @ErBeboer)";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(sqlS, conn);

            cmd.Parameters.Clear();

            cmd.Parameters.Add("@Navn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Navn"].Value = Convert.ToString(fNavn);

            cmd.Parameters.Add("@Mail", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Mail"].Value = Convert.ToString(pMail);

            cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
            cmd.Parameters["@Tlf"].Value = Convert.ToInt32(pTlf);

            cmd.Parameters.Add("@ErBeboer", System.Data.SqlDbType.Bit);
            cmd.Parameters["@ErBeboer"].Value = Convert.ToBoolean(false);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" +
                                    cmd.Parameters["@Navn"].Value + ", " +
                                    cmd.Parameters["@Mail"].Value + ", " +
                                    cmd.Parameters["@Tlf"].Value + ", " +
                                    cmd.Parameters["@ErBeboer"].Value +
                                    ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
