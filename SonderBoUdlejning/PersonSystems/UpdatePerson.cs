using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning.personCRUD
{
    public class UpdatePerson
    {
        //Finder connectionstring til databasen frem fra ConnString klassen
        ConnString connString = ConnString.getConnInstance;

        //Metode der opdaterer en person i databasen
        public void uPerson(string fNavn, string pMail, string pTlf, string pId, bool erBeboer)
        {
            string sqlS = "UPDATE Person SET fNavn = @Navn, pMail = @Mail, pTlf = @Tlf, erBeboer = @erBeboer WHERE pId = @pId"; //Definere SQL string
            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen
            SqlCommand cmd = new SqlCommand(sqlS, conn); //Opretter SQL kommandoen
            cmd.Parameters.Clear(); //Rydder parametre fra SQL kommandoen

            //Tilføjer parametre til SQL kommandoen
            cmd.Parameters.Add("@Navn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Navn"].Value = Convert.ToString(fNavn);

            cmd.Parameters.Add("@Mail", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Mail"].Value = Convert.ToString(pMail);

            cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
            cmd.Parameters["@Tlf"].Value = Convert.ToInt32(pTlf);

            cmd.Parameters.Add("@pId", System.Data.SqlDbType.Int);
            cmd.Parameters["@pId"].Value = Convert.ToInt32(pId);

            cmd.Parameters.Add("@erBeboer", System.Data.SqlDbType.Bit);
            cmd.Parameters["@erBeboer"].Value = Convert.ToBoolean(erBeboer);

            //try-catch løkke
            try
            {
                conn.Open(); //Åbner forbindelsen til databasen
                cmd.ExecuteNonQuery(); //Udfører SQL kommandoen
                conn.Close(); //Lukker forbindelsen til databasen
                ErrorMessage.ErrorList.Add($"\nSUCCESS :\nMedlem med person ID {pId} opdateret til værdierne:\n(" + //Vis beskedboks med besked om succes
                                    cmd.Parameters["@Navn"].Value + ", " +
                                    cmd.Parameters["@Mail"].Value + ", " +
                                    cmd.Parameters["@Tlf"].Value + ", " +
                                    cmd.Parameters["@erBeboer"].Value +
                                    ")");
            }
            catch (Exception ex) //Hvis der er fejl i SQL kommandoen
            {
                MessageBox.Show(ex.Message); //Vis beskedboks med fejlbesked
            }
        }
    }
}
