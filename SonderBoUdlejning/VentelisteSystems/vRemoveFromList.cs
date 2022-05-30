using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning.VentelisteSystems
{
    public class vRemoveFromList
    {
        //Finder connectionstring til databasen frem fra ConnString klassen
        ConnString connString = ConnString.getConnInstance;

        //Metode der fjerner en person fra en venteliste
        public void vRemoveFrList(string pId, string Lid, bool prompt)
        {
            string sqlS = "DELETE FROM Venteliste WHERE pId = @pId AND Lid = @Lid"; //Standard SQL Query
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

                if (prompt == true)
                {
                    //Dobbelt tjekker om man ønsker at fjerne personen fra en venteliste
                    DialogResult dialogResult = MessageBox.Show("Er du sikker på du vil slette denne entry på ventelisten?", "Er du sikker?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) //Hvis ja
                    {
                        cmd.ExecuteNonQuery(); //Udfører kommandoen
                        //MessageBox.Show($"SUCCESS :\nPerson med ID {pId} blev fjernet fra ventelisten for lejemål med type ID {Lid}."); //Vis beskedboks med besked om succes
                        ErrorMessage.ErrorList.Add($"\nSUCCESS :\nPerson med ID {pId} blev fjernet fra ventelisten for lejemål med type ID {Lid}."); //Genbruger ErrorMessage klassen til at vise respons til brugeren
                    }
                    else if (dialogResult == DialogResult.No) //Hvis nej
                    {
                        cmd.Cancel(); //Aflys kommandoen
                        conn.Close(); //Lukker forbindelsen til databasen
                        ErrorMessage.ErrorList.Add("\nIntet blev slettet"); //Genbruger ErrorMessage klassen til at vise respons til brugeren
                        return; //Afslutter metoden
                    }
                }
                else
                {
                    cmd.ExecuteNonQuery(); //Udfører kommandoen
                    ErrorMessage.ErrorList.Add($"\nSUCCESS :\nPerson med ID {pId} blev fjernet fra ventelisten for lejemål med type ID {Lid}."); //Genbruger ErrorMessage klassen til at vise respons til brugeren
                }
                conn.Close(); //Lukker forbindelsen til databasen
            }
            catch (Exception ex) //Hvis der er en fejl
            {
                MessageBox.Show(ex.Message); //Vis beskedboks med fejlbesked
            }
        }
    }
}
