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
        public void vAddTo(string pId, string bId)
        {
            //Standard SQL Query (Kasper ved mere om den her)
            string sqlS = "IF NOT EXISTS (SELECT * FROM Venteliste WHERE pId = @pId AND bid = @bId) BEGIN INSERT INTO Venteliste(pId, bId, signUpDato) VALUES (@pId, @bId, getdate()) END";
            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen
            SqlCommand cmd = new SqlCommand(sqlS, conn); //Opretter SQL kommandoen
            cmd.Parameters.Clear(); //Rydder parametre fra kommandoen

            //Tilføjer parametre til kommandoen
            cmd.Parameters.Add("@pId", System.Data.SqlDbType.Int);
            cmd.Parameters["@pId"].Value = Convert.ToInt32(pId);

            cmd.Parameters.Add("@bId", System.Data.SqlDbType.Int);
            cmd.Parameters["@bId"].Value = Convert.ToInt32(bId);

            //try-catch løkke
            try
            {
                conn.Open(); //Åbner forbindelsen til databasen
                if (cmd.ExecuteNonQuery() == -1) //Tjekker om personen allerede er på ventelisten til en bestemt bolig type
                {
                    MessageBox.Show("Denne person er allerede på ventelisten til denne bolig!");
                }
                else
                {
                    //cmd.ExecuteNonQuery();
                    MessageBox.Show("Personen er blevet tilføjet til ventelisten");
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Bolig ID eller person ID findes ikke i databasen!");
            }
        }
    }
}
