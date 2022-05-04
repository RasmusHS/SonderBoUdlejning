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
    public class pRead
    {
        ConnString connString = ConnString.getConnInstance;
        personInputCheck pInputCheck = new personInputCheck();

        public string pSQLR(string fNavn, string pMail, string pTlf, bool medlem, bool erBeboer, bool alt)
        {
            string sqlS = $"SELECT * FROM Person WHERE 1=1";

            SqlConnection conn = new SqlConnection(connString.connStr);

            if (!string.IsNullOrEmpty(fNavn))
                sqlS += $" AND fNavn LIKE '%{fNavn}%'";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(pMail))
                sqlS += $" AND pMail = '{pMail}'";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(pTlf))
                sqlS += $" AND pTlf = '{pTlf}'";
            else
                sqlS += $"";

            if (medlem == true)
                sqlS += $" AND erBeboer = 0";
            else if (erBeboer == true)
                sqlS += $" AND erBeboer = 1";
            else if (alt == true)
                sqlS += $"";
            else
                sqlS += $"";

            try
            {
                conn.Open();
                if (pInputCheck.injectedSQL == 1)
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
