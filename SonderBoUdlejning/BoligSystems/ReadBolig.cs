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
    internal class ReadBolig
    {
        ConnString connString = ConnString.getConnInstance;

        public string readBolig(string adresse, string postNr, string bId, string pId, string indDato, string udDato)
        {
            string sqlS = $"SELECT * FROM Bolig WHERE 1=1";

            SqlConnection conn = new SqlConnection(connString.connStr);
            
            if (!string.IsNullOrEmpty(adresse))
                sqlS += $" AND adresse LIKE '%{adresse}%'";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(postNr))
                sqlS += $" AND postNr = {postNr}";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(bId))
                sqlS += $" AND bId = {bId}";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(pId))
                sqlS += $" AND pId = {pId}";
            else
                sqlS += $"";

            if ((!string.IsNullOrEmpty(indDato)) && (!string.IsNullOrEmpty(udDato)))
                sqlS += $" AND adresse BETWEEN '{indDato}' AND '{udDato}'";
            else if ((!string.IsNullOrEmpty(indDato)) && (string.IsNullOrEmpty(udDato)))
                sqlS += $" AND indflytDato >= '{indDato}'";
            else if ((string.IsNullOrEmpty(indDato)) && (!string.IsNullOrEmpty(udDato)))
                sqlS += $" AND udflytDato <= '{udDato}'";
            else
                sqlS += $"";

            sqlS += $" AND (pId IS NULL AND indflytDato IS NULL AND udflytDato IS NULL)";

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

        public string readBoligTilLeje(string adresse, string postNr, string bId, string bType, string minKvm, string maxKvm, string minLejePris, string maxLejePris)
        {
            string sqlS = $"SELECT adresse, postNr, Bolig.bId, bType, antalRum, kvm, lejePris FROM Bolig INNER JOIN BoligInfo ON Bolig.bId=BoligInfo.bId WHERE 1=1 AND pId IS NULL AND indflytDato IS NULL"; ;

            SqlConnection conn = new SqlConnection(connString.connStr);

            if (!string.IsNullOrEmpty(adresse))
                sqlS += $" AND adresse LIKE '%{adresse}%'";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(postNr))
                sqlS += $" AND postNr = {postNr}";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(bId))
                sqlS += $" AND Bolig.bId = {bId}";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(bType))
                sqlS += $" AND bType = '{bType}'";
            else
                sqlS += $"";

            /*if (!string.IsNullOrEmpty(antalRum))
                sqlS += $" AND antalRum = {antalRum}";
            else
                sqlS += $"";*/

            if ((!string.IsNullOrEmpty(minKvm)) && (string.IsNullOrEmpty(maxKvm)))
                sqlS += $" AND kvm >= {minKvm}";
            else if ((string.IsNullOrEmpty(minKvm)) && (!string.IsNullOrEmpty(maxKvm)))
                sqlS += $" AND kvm <= {maxKvm}";
            else if ((!string.IsNullOrEmpty(minKvm)) && (!string.IsNullOrEmpty(maxKvm)))
                sqlS += $" AND (kvm BETWEEN {minKvm} AND {maxKvm})";
            else
                sqlS += $"";

            if ((!string.IsNullOrEmpty(minLejePris)) && (string.IsNullOrEmpty(maxLejePris)))
                sqlS += $" AND lejePris >= {minLejePris}";
            else if ((string.IsNullOrEmpty(minLejePris)) && (!string.IsNullOrEmpty(maxLejePris)))
                sqlS += $" AND lejePris <= {maxLejePris}";
            else if ((!string.IsNullOrEmpty(minLejePris)) && (!string.IsNullOrEmpty(maxLejePris)))
                sqlS += $" AND (lejePris BETWEEN {minLejePris} AND {maxLejePris})";
            else
                sqlS += $"";

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
