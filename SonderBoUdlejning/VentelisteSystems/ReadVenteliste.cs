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
        //Finder connectionstring til databasen frem fra ConnString klassen
        ConnString connString = ConnString.getConnInstance;

        //Metode der returner en SQL Query, der finder ventelisten for en lejemål type
        public string rVente(string pId, string Lid, string signUpDato)
        {
            string sqlS = $"SELECT pId AS 'Person ID', Lid AS 'Lejemålstype ID', signUpDato AS 'Opskrivelsesdato' FROM Venteliste WHERE 1=1"; //Standard SQL Query

            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen

            //Hvis der er specificeret et person ID, så tilføjes dette til SQL Query
            if (!string.IsNullOrEmpty(pId))
                sqlS += $" AND pId = {pId}";
            else
                sqlS += $"";

            //Hvis der er specificeret et lejemål Nr, så tilføjes dette til SQL Query
            if (!string.IsNullOrEmpty(Lid))
                sqlS += $" AND Lid = {Lid}";
            else
                sqlS += $"";

            //Hvis der er specificeret en signup dato, så tilføjes dette til SQL Query
            if (!string.IsNullOrEmpty(signUpDato))
                sqlS += $" AND signUpDato >= '{signUpDato}'";
            else
                sqlS += $"";

            //Til sidst tilføjes der en order by, så der bliver sorteret efter signup dato
            sqlS += $" ORDER BY signUpDato ASC";

            //try-catch løkke
            try
            {
                if ((ErrorMessage.injectedSQL == 1)) //Tjekker for SQL injection
                {
                    sqlS = ""; //Sætter sqlS til tom streng, hvis injection er fundet
                }
                else
                {
                    return sqlS; //Returnerer den færdige SQL Query
                }

                return sqlS; //Returnerer den tomme SQL Query
            }
            catch (Exception ex) //Hvis der er en fejl
            {
                MessageBox.Show(ex.Message); //Viser fejlen
                return ex.ToString(); //Returnerer fejlen
            }
        }
    }
}
