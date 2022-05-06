using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning.VentelisteSystems
{
    public class vRemoveFromList
    {
        ConnString connString = ConnString.getConnInstance;
        
        public void vRemoveFrList(string pId, string bId)
        {
            string sqlS = "DELETE FROM Venteliste WHERE pId = @pId AND bId = @bId";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(sqlS, conn);

            cmd.Parameters.Add("@pId", System.Data.SqlDbType.Int);
            cmd.Parameters["@pId"].Value = Convert.ToInt32(pId);

            cmd.Parameters.Add("@bId", System.Data.SqlDbType.Int);
            cmd.Parameters["@bId"].Value = Convert.ToInt32(bId);

            try
            {
                conn.Open();
                DialogResult dialogResult = MessageBox.Show("Er du sikker på du vil slette denne entry på ventelisten?", "Er du sikker?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" +
                                    cmd.Parameters["@pId"].Value + ", " +
                                    cmd.Parameters["@bId"].Value +
                                    ")");
                }
                else if (dialogResult == DialogResult.No)
                {
                    cmd.Cancel();
                    conn.Close();
                    MessageBox.Show("Intet blev slettet");
                    return;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
