using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning.personCRUD
{
    public class UpdatePerson
    {
        ConnString connString = ConnString.getConnInstance;
        
        public void pSQLU(string fNavn, string pMail, string pTlf, string pId, bool erBeboer)
        {
            string sqlS = "UPDATE Person SET fNavn = @Navn, pMail = @Mail, pTlf = @Tlf, erBeboer = @erBeboer WHERE pId = @pId";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(sqlS, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@Navn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Navn"].Value = Convert.ToString(fNavn);

            cmd.Parameters.Add("@Mail", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Mail"].Value = Convert.ToString(pMail);

            cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
            cmd.Parameters["@Tlf"].Value = Convert.ToInt32(pTlf);

            cmd.Parameters.Add("@pId", System.Data.SqlDbType.Int);
            cmd.Parameters["@pId"].Value = Convert.ToInt32(pId);

            cmd.Parameters.Add("@erBeboer", System.Data.SqlDbType.Bit);
            cmd.Parameters["@erBeboer"].Value = Convert.ToBoolean(erBeboer);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" +
                                    cmd.Parameters["@Navn"].Value + ", " +
                                    cmd.Parameters["@Mail"].Value + ", " +
                                    cmd.Parameters["@Tlf"].Value + ", " +
                                    cmd.Parameters["@pId"].Value + ", " +
                                    cmd.Parameters["@erBeboer"].Value +
                                    ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
