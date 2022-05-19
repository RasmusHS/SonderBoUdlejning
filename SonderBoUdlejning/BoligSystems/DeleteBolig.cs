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

        //Metode der sletter en lejemål fra databasen
        public void deleteBolig(string lejemaalNr)
        {
            string sqlS = "IF EXISTS (SELECT lejemaalNr FROM Lejemaal WHERE lejemaalNr = @lejemaalNr) BEGIN DELETE FROM Lejemaal WHERE lejemaalNr = @lejemaalNr END"; //Definere DELETE Querien
            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen
            SqlCommand cmd = new SqlCommand(sqlS, conn); //Opretter SQL kommandoen
            cmd.Parameters.Clear(); //Rydder parametre

            //Tilføjer parametre til kommandoen
            cmd.Parameters.Add("@lejemaalNr", System.Data.SqlDbType.Int);
            cmd.Parameters["@lejemaalNr"].Value = Convert.ToInt32(lejemaalNr);

            //try-catch løkke
            try
            {
                conn.Open(); //Åbner forbindelsen
                
                DialogResult dialogResult = MessageBox.Show($"Er du sikker på du vil slette lejemål {lejemaalNr} fra lejemål tabellen?", "Er du sikker?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("Lejemålet blev ikke slettet, da den ikke eksisterede i forvejen"); //Besked om at boligen er slettet
                    }
                    else
                    {
                        MessageBox.Show($"Lejemål {lejemaalNr} blev slettet");
                        //MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" + cmd.Parameters["@lejemaalNr"].Value + ")"); //Vis besked om at kommandoen er udført
                    }
                }
                else if (dialogResult == DialogResult.No) //Hvis nej
                {
                    cmd.Cancel(); //Aflys kommandoen
                    conn.Close(); //Lukker forbindelsen til databasen
                    MessageBox.Show("Intet blev slettet"); //Vis beskedboks med besked om at intet blev slettet
                    return; //Afslutter metoden
                }
                conn.Close(); //Lukker forbindelsen
            }
            catch (Exception ex) //Hvis der er fejl i kommandoen
            {
                MessageBox.Show(ex.Message); //Vis fejlbesked
            }
        }
    }
}
