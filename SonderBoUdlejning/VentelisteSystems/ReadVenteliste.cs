using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SonderBoUdlejning.InputCheck;

namespace SonderBoUdlejning.VentelisteSystems
{
    internal class ReadVenteliste
    {
        ConnString connString = ConnString.getConnInstance;

        public string rVente(string pId, string bId, string signUpDato)
        {
            string sqlS = $"SELECT * FROM Venteliste WHERE 1=1";

            SqlConnection conn = new SqlConnection(connString.connStr);

            if (!string.IsNullOrEmpty(pId))
                sqlS += $" AND pId = {pId}";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(bId))
                sqlS += $" AND bId = {bId}";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(signUpDato))
                sqlS += $" AND signUpDato >= '{signUpDato}'";
            else
                sqlS += $"";

            sqlS += $" ORDER BY signUpDato ASC";

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
