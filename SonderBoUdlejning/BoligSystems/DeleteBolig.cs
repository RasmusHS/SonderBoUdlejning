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
    internal class DeleteBolig
    {
        //Finder connectionstring til databasen frem fra ConnString klassen        
        ConnString connString = ConnString.getConnInstance;

        //Metode der sletter en bolig fra databasen
        public void deleteBolig(string adresse)
        {
            string sqlS = "DELETE FROM Bolig WHERE adresse = @adresse"; //Definere DELETE Querien
            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen
            SqlCommand cmd = new SqlCommand(sqlS, conn); //Opretter SQL kommandoen
            cmd.Parameters.Clear(); //Rydder parametre

            //Tilføjer parametre til kommandoen
            cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@adresse"].Value = Convert.ToString(adresse);

            //try-catch løkke
            try
            {
                conn.Open(); //Åbner forbindelsen
                cmd.ExecuteNonQuery(); //Udfører kommandoen
                conn.Close(); //Lukker forbindelsen
                MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" + cmd.Parameters["@adresse"].Value + ")"); //Vis besked om at kommandoen er udført
            }
            catch (Exception ex) //Hvis der er fejl i kommandoen
            {
                MessageBox.Show(ex.Message); //Vis fejlbesked
            }
        }
    }
}
