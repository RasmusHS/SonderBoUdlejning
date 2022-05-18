using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning.personCRUD
{
    public class ReadPerson
    {
        //Finder connectionstring til databasen frem fra ConnString klassen
        ConnString connString = ConnString.getConnInstance;

        //Metode der indlæser personer fra person tabellen ud fra givne parametre
        public string pSQLR(string columns, string pId, string fNavn, string pMail, string pTlf, bool medlem, bool erBeboer, bool alt)
        {
            //Hvis der ikke er specificeret nogen kolonner, så indlæses alle kolonner
            if (string.IsNullOrEmpty(columns))
                columns = "*";

            //Standard SQL Query
            string sqlS = $"SELECT {columns} FROM Person WHERE 1=1";

            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen

            //Hvis der er specificeret et person ID, så tilføjes dette til SQL Query
            if (!string.IsNullOrEmpty(pId))
                sqlS += $" AND pId = {pId}";
            else
                sqlS += $"";

            //Hvis der er specificeret et navn, så tilføjes dette til SQL Query
            if (!string.IsNullOrEmpty(fNavn))
                sqlS += $" AND fNavn LIKE '%{fNavn}%'";
            else
                sqlS += $"";

            //Hvis der er specificeret en mail, så tilføjes dette til SQL Query
            if (!string.IsNullOrEmpty(pMail))
                sqlS += $" AND pMail = '{pMail}'";
            else
                sqlS += $"";

            //Hvis der er specificeret et telefonnummer, så tilføjes dette til SQL Query
            if (!string.IsNullOrEmpty(pTlf))
                sqlS += $" AND pTlf = '{pTlf}'";
            else
                sqlS += $"";

            //Hvis der er specificeret om personen er medlem eller beboer, så tilføjes dette til SQL Query
            if (medlem == true)
                sqlS += $" AND erBeboer = 0";
            else if (erBeboer == true)
                sqlS += $" AND erBeboer = 1";
            else if (alt == true)
                sqlS += $"";
            else
                sqlS += $"";

            //try-catch løkke
            try
            {
                if (ErrorMessage.injectedSQL == 1) //Tjekker for SQL injection
                {
                    sqlS = ""; //Skyller SQL Querien ud
                }
                else
                {
                    return sqlS; //Returnerer den færdige SQL Query
                }

                return sqlS; //Returnerer den tomme SQL Query
            }
            catch (Exception ex) //Hvis der er fejl i SQL Querien
            {
                MessageBox.Show(ex.Message); //Viser fejlen
                return ex.ToString(); //Returnerer fejlen
            }
        }
    }
}
