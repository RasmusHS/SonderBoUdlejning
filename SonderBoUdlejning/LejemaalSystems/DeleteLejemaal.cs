using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SonderBoUdlejning.InputCheck;

namespace SonderBoUdlejning.LejemaalSystems
{
    internal class DeleteLejemaal
    {
        //Finder connectionstring til databasen frem fra ConnString klassen        
        ConnString connString = ConnString.getConnInstance;

        //Metode der sletter en lejemål fra databasen
        public void deleteLejemaal(string lejemaalNr)
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
                
                DialogResult dialogResult = MessageBox.Show($"Er du sikker på du vil slette lejemål nr. {lejemaalNr} fra lejemål tabellen?", "Er du sikker?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        //Besked om at lejemålet er slettet
                        ErrorMessage.ErrorList.Add("\nLejemålet blev ikke slettet, da den ikke eksisterede i forvejen");
                    }
                    else
                    {
                        ErrorMessage.ErrorList.Add($"\nLejemål nr. {lejemaalNr} blev slettet.");
                    }
                }
                else if (dialogResult == DialogResult.No) //Hvis nej
                {
                    cmd.Cancel(); //Aflys kommandoen
                    conn.Close(); //Lukker forbindelsen til databasen

                    //Vis beskedboks med besked om at intet blev slettet
                    ErrorMessage.ErrorList.Add("\nIntet blev slettet."); 
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
