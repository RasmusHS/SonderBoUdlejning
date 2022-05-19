using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SonderBoUdlejning.InputCheck;

namespace SonderBoUdlejning.VentelisteSystems
{
    public class vGetPos
    {
        //Finder connectionstring til databasen frem fra ConnString klassen
        ConnString connString = ConnString.getConnInstance;

        //Metode der finder en person position på en venteliste
        public string vGetPosition(string pId, string Lid)
        {
            string position; //Variabel der indeholder positionen på ventelisten
            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen
            conn.Open(); //Åbner forbindelsen

            //SQL-query der finder positionen på ventelisten
            string sqlS = $"SELECT ROW_NUMBER() OVER(ORDER BY signUpDato ASC) AS row_num, signUpDato, Lid, pId FROM Venteliste WHERE Lid = {Lid}";
            SqlCommand cmd = new SqlCommand(sqlS, conn); //Opretter SQL-kommandoen

            SqlDataReader reader = cmd.ExecuteReader(); //Læser resultatet af SQL-kommandoen
            List<int> getNumbersList = new List<int>(); //Liste der indeholder alle numre på ventelisten
            while (reader.Read()) //Tilføjer SQL-kommandoens resultat til en liste med et while loop
            {
                getNumbersList.Add(Convert.ToInt32(reader.GetValue(3)));
            }
            conn.Close(); //Lukker forbindelsen

            int[] positionenArray = getNumbersList.ToArray(); //Konverterer listen til et array

            position = Convert.ToString(Array.IndexOf(positionenArray, Convert.ToInt32(pId)) + 1); //Finder personens position på ventelisten

            if (ErrorMessage.injectedSQL == 1) //Tjekker for SQL injection
            {
                position = null; //Sætter position til null hvis injection er fundet
                //conn.Close(); 
            }
            else
            {
                //conn.Close();
                return position; //Returnerer positionen
            }
            return position; //Returnerer null

        }
    }
}
