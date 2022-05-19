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
        //Finder connectionstring til databasen frem fra ConnString klassen
        ConnString connString = ConnString.getConnInstance;

        //Metode der indlæser boliger fra databasen ud fra de givne parametre
        public string readBolig(string sqlTemplate, string adresse, string postNr, string Lid, string pId, string indDato, string udDato, string lType, string minKvm, string maxKvm, string minLejePris, string maxLejePris, bool tilLeje)
        {
            string sqlS = $"{sqlTemplate}"; //Skabelon for SQL-sætning

            //Tjekker om adresse er udfyldt
            if (!string.IsNullOrEmpty(adresse))
                sqlS += $" AND adresse LIKE '%{adresse}%'";
            else
                sqlS += $"";

            //Tjekker om postnummer er udfyldt
            if (!string.IsNullOrEmpty(postNr))
                sqlS += $" AND postNr = {postNr}";
            else
                sqlS += $"";

            //Tjekker om lejemål ID er udfyldt
            if (!string.IsNullOrEmpty(Lid))
                sqlS += $" AND Lejemaal.Lid = {Lid}";
            else
                sqlS += $"";

            //Tjekker om person ID er udfyldt
            if (!string.IsNullOrEmpty(pId))
                sqlS += $" AND pId = {pId}";
            else
                sqlS += $"";

            //Tjekker om indflytDato og/eller udflytDato er udfyldt
            if ((!string.IsNullOrEmpty(indDato)) && (!string.IsNullOrEmpty(udDato)))
                sqlS += $" AND indflytDato >= '{indDato}' AND udflytDato <= '{udDato}'";
            else if ((!string.IsNullOrEmpty(indDato)) && (string.IsNullOrEmpty(udDato)))
                sqlS += $" AND indflytDato >= '{indDato}'";
            else if ((string.IsNullOrEmpty(indDato)) && (!string.IsNullOrEmpty(udDato)))
                sqlS += $" AND udflytDato <= '{udDato}'";
            else
                sqlS += $"";

            //Tjekker om boligtype er udfyldt
            if (!string.IsNullOrEmpty(lType))
                sqlS += $" AND lType = '{lType}'";
            else
                sqlS += $"";

            //Tjekker om antal rum er udfyldt (bruges ikke)
            /*if (!string.IsNullOrEmpty(antalRum))
                sqlS += $" AND antalRum = {antalRum}";
            else
                sqlS += $"";*/

            //Tjekker om minimum og/eller maximum kvm er udfyldt
            if ((!string.IsNullOrEmpty(minKvm)) && (string.IsNullOrEmpty(maxKvm)))
                sqlS += $" AND kvm >= {minKvm}";
            else if ((string.IsNullOrEmpty(minKvm)) && (!string.IsNullOrEmpty(maxKvm)))
                sqlS += $" AND kvm <= {maxKvm}";
            else if ((!string.IsNullOrEmpty(minKvm)) && (!string.IsNullOrEmpty(maxKvm)))
                sqlS += $" AND (kvm BETWEEN {minKvm} AND {maxKvm})";
            else
                sqlS += $"";

            //Tjekker om minimum og/eller maximum leje pris er udfyldt
            if ((!string.IsNullOrEmpty(minLejePris)) && (string.IsNullOrEmpty(maxLejePris)))
                sqlS += $" AND lejePris >= {minLejePris}";
            else if ((string.IsNullOrEmpty(minLejePris)) && (!string.IsNullOrEmpty(maxLejePris)))
                sqlS += $" AND lejePris <= {maxLejePris}";
            else if ((!string.IsNullOrEmpty(minLejePris)) && (!string.IsNullOrEmpty(maxLejePris)))
                sqlS += $" AND (lejePris BETWEEN {minLejePris} AND {maxLejePris})";
            else
                sqlS += $"";

            //Tjekker om kun boliger, som er til leje skal indlæses
            if (tilLeje == true)
                sqlS += $" AND (pId IS NULL AND indflytDato IS NULL AND udflytDato IS NULL)";
            else
                sqlS += $"";
            
            //try-catch
            try
            {
                if ((ErrorMessage.injectedSQL == 1)) //Tjekker om der er injected SQL
                {
                    sqlS = ""; //Skyller hele SQL Querien ud
                    return sqlS; //Returnere den tomme SQL Query til facaden
                }
                else
                {
                    return sqlS; //Returnere den færdige SQL Query til facaden
                }
            }
            catch (Exception ex) //Viser fejlmeddelelse
            {
                MessageBox.Show(ex.Message);
                return ex.ToString();
            }
        }
    }
}
