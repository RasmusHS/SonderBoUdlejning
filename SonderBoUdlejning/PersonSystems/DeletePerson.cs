using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning.personCRUD
{
    public class DeletePerson
    {
        //Finder connectionstring til databasen frem fra ConnString klassen
        ConnString connString = ConnString.getConnInstance;

        //Metode til at slette en person fra databasen
        public void pSQLD(string pTlf)
        {
            string sqlS = "DELETE FROM Person WHERE pTlf = @Tlf"; //Definere SQL string
            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen
            SqlCommand cmd = new SqlCommand(sqlS, conn); //Opretter SQL kommandoen
            cmd.Parameters.Clear(); //Rydder parametre

            //Tilføjer parametre til SQL kommandoen
            cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
            cmd.Parameters["@Tlf"].Value = Convert.ToInt32(pTlf);

            //try-catch løkke
            try
            {
                conn.Open(); //Åbner forbindelsen til databasen
                DialogResult dialogResult = MessageBox.Show("Er du sikker på du vil slette dette medlem fra databasen?", "Er du sikker?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery(); //Udfører SQL kommandoen
                    MessageBox.Show($"SUCCESS :\nMedlem med tlf nr. {pTlf} blev slettet fra databasen."); //Vis beskedboks med besked om succes
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
            catch (Exception ex) //Hvis der er fejl i SQL kommandoen
            {
                MessageBox.Show(ex.Message); //Vis beskedboks med fejlbesked
            }
        }
    }
}
