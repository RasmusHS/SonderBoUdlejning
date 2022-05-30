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
        //Finder connectionstring til databasen frem fra ConnString klassen
        ConnString connString = ConnString.getConnInstance;

        //Metode der tilføjer en person til en venteliste
        public void vAddTo(string pId, string Lid)
        {
            //Standard SQL Query (Kasper ved mere om den her)
            string sqlS = "IF NOT EXISTS (SELECT * FROM Venteliste WHERE pId = @pId AND Lid = @Lid) BEGIN INSERT INTO Venteliste(pId, Lid, signUpDato) VALUES (@pId, @Lid, getdate()) END";
            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen
            SqlCommand cmd = new SqlCommand(sqlS, conn); //Opretter SQL kommandoen
            cmd.Parameters.Clear(); //Rydder parametre fra kommandoen

            //Tilføjer parametre til kommandoen
            cmd.Parameters.Add("@pId", System.Data.SqlDbType.Int);
            cmd.Parameters["@pId"].Value = Convert.ToInt32(pId);

            cmd.Parameters.Add("@Lid", System.Data.SqlDbType.Int);
            cmd.Parameters["@Lid"].Value = Convert.ToInt32(Lid);

            //try-catch løkke
            try
            {
                conn.Open(); //Åbner forbindelsen til databasen
                if (cmd.ExecuteNonQuery() == -1) //Tjekker om personen allerede er på ventelisten til en bestemt lejemål type
                {
                    //MessageBox.Show("Denne person er allerede på ventelisten til denne lejemål!");
                    ErrorMessage.ErrorList.Add("\nDenne person er allerede på ventelisten til denne lejemål!");
                }
                else
                {
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Personen er blevet tilføjet til ventelisten");
                    ErrorMessage.ErrorList.Add("\nPersonen er blevet tilføjet til ventelisten");
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Lejemål Nr eller person ID findes ikke i databasen!");
            }
        }
    }
}
