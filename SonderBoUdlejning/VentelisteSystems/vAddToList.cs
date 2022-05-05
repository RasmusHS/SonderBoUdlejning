using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning.VentelisteSystems
{
    public class vAddToList
    {
        ConnString connString = ConnString.getConnInstance;

        public void vAddTo(string pId, string bId)
        {
            string sqlS = "IF NOT EXISTS (SELECT * FROM Venteliste WHERE pId = @pId AND bid = @bId) BEGIN INSERT INTO Venteliste(pId, bId, signUpDato) VALUES (@pId, @bId, getdate()) END";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(sqlS, conn);

            cmd.Parameters.Add("@pId", System.Data.SqlDbType.Int);
            cmd.Parameters["@pId"].Value = Convert.ToInt32(pId);

            cmd.Parameters.Add("@bId", System.Data.SqlDbType.Int);
            cmd.Parameters["@bId"].Value = Convert.ToInt32(bId);

            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("Denne person er allerede på ventelisten til denne bolig!");
                }
                else
                {
                    //cmd.ExecuteNonQuery();
                    MessageBox.Show("Personen er blevet tilføjet til ventelisten");
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Bolig ID eller person ID findes ikke i databasen!");
            }
        }
    }
}
