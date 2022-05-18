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
        public void vRemoveFrList(string pId, string bId)
        {
            string sqlS = "DELETE FROM Venteliste WHERE pId = @pId AND bId = @bId"; //Standard SQL Query
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
                
                //Dobbelt tjekker om man ønsker at fjerne personen fra en venteliste
                DialogResult dialogResult = MessageBox.Show("Er du sikker på du vil slette denne entry på ventelisten?", "Er du sikker?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) //Hvis ja
                {
                    cmd.ExecuteNonQuery(); //Udfører kommandoen
                    MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" + //Vis beskedboks med besked om succes
                                    cmd.Parameters["@pId"].Value + ", " +
                                    cmd.Parameters["@bId"].Value +
                                    ")");
                }
                else if (dialogResult == DialogResult.No) //Hvis nej
                {
                    cmd.Cancel(); //Aflys kommandoen
                    conn.Close(); //Lukker forbindelsen til databasen
                    MessageBox.Show("Intet blev slettet"); //Vis beskedboks med besked om at intet blev slettet
                    return; //Afslutter metoden
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
