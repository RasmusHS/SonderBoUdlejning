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
    internal class CreateBolig
    {
        //Finder connectionstring til databasen frem fra ConnString klassen
        ConnString connString = ConnString.getConnInstance;

        //Metode der opretter en lejemål
        public void opretBolig(string adresse, string postNr, string Lid)
        {
            string sqlS = "INSERT INTO Lejemaal VALUES (@adresse, @postNr, @Lid, NULL, NULL, NULL)"; //Definere SQL Query med parametrenavne
            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen
            SqlCommand cmd = new SqlCommand(sqlS, conn); //Opretter SQL kommandoen
            cmd.Parameters.Clear(); //Rydder parametre fra kommandoen

            //Tilføjer parametre til kommandoen
            cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@adresse"].Value = Convert.ToString(adresse);

            cmd.Parameters.Add("@postNr", System.Data.SqlDbType.Int);
            cmd.Parameters["@postNr"].Value = Convert.ToInt32(postNr);
            
            cmd.Parameters.Add("@Lid", System.Data.SqlDbType.Int);
            cmd.Parameters["@Lid"].Value = Convert.ToInt32(Lid);

            //try-catch løkke
            try
            {
                conn.Open(); //Åbner forbindelsen til databasen
                cmd.ExecuteNonQuery(); //Udfører kommandoen
                conn.Close(); //Lukker forbindelsen til databasen
                MessageBox.Show("SUCCESS :\nOprettede ny lejemål med værdierne:\n(" + //Vis beskedboks med besked om succes
                                    cmd.Parameters["@adresse"].Value + ", " +
                                    cmd.Parameters["@postNr"].Value + ", " +
                                    cmd.Parameters["@Lid"].Value +
                                    ")");
            }
            catch (Exception ex) //Hvis der er fejl
            {
                MessageBox.Show(ex.Message); //Vis beskedboks med fejlbesked
            }
        }
    }
}
