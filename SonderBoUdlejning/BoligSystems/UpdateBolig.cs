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
    internal class UpdateBolig
    {
        ConnString connString = ConnString.getConnInstance;
        
        public void updateBolig(string adresse, string postNr, string bId, string pId, string indDato, string udDato)
        {
            string sqlS = "UPDATE Bolig SET postNr = @postNr, bId = @bId, pId = @pId, indflytDato = @indflytDato, udflytDato = @udflytDato WHERE adresse = @adresse";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(sqlS, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@adresse"].Value = Convert.ToString(adresse);

            cmd.Parameters.Add("@postNr", System.Data.SqlDbType.Int);
            cmd.Parameters["@postNr"].Value = Convert.ToInt32(postNr);

            cmd.Parameters.Add("@bId", System.Data.SqlDbType.Int);
            cmd.Parameters["@bId"].Value = Convert.ToInt32(bId);

            cmd.Parameters.Add("@pId", System.Data.SqlDbType.Int);
            if (string.IsNullOrEmpty(pId))
                cmd.Parameters["@pId"].Value = DBNull.Value;
            else
                cmd.Parameters["@pId"].Value = Convert.ToInt32(pId);

            cmd.Parameters.Add("@indflytDato", System.Data.SqlDbType.Date);
            if (string.IsNullOrEmpty(indDato))
                cmd.Parameters["@indflytDato"].Value = DBNull.Value;
            else
                cmd.Parameters["@indflytDato"].Value = Convert.ToDateTime(indDato);

            cmd.Parameters.Add("@udflytDato", System.Data.SqlDbType.Date);
            if (string.IsNullOrEmpty(udDato))
                cmd.Parameters["@udflytDato"].Value = DBNull.Value;
            else
                cmd.Parameters["@udflytDato"].Value = Convert.ToDateTime(udDato); 

            try
            {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" +
                                cmd.Parameters["@postNr"].Value + ", " +
                                cmd.Parameters["@bId"].Value + ", " +
                                cmd.Parameters["@pId"].Value + ", " +
                                cmd.Parameters["@indflytDato"].Value + ", " +
                                cmd.Parameters["@udflytDato"].Value + ", " +
                                cmd.Parameters["@adresse"].Value +
                                ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
