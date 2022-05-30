using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SonderBoUdlejning
{
    public class CreatePerson
    {
        //Finder connectionstring til databasen frem fra ConnString klassen
        ConnString connString = ConnString.getConnInstance;

        //Metode der opretter en ny person i databasen
        public void createPerson(string fNavn, string pMail, string pTlf)
        {
            string sqlS = "INSERT INTO Person VALUES (@Navn, @Mail, @Tlf, @ErBeboer)"; //Definere SQL string
            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen
            SqlCommand cmd = new SqlCommand(sqlS, conn); //Opretter SQL kommandoen
            cmd.Parameters.Clear(); //Rydder parametre fra SQL kommandoen

            //Tilføjer parametre til kommandoen
            cmd.Parameters.Add("@Navn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Navn"].Value = Convert.ToString(fNavn);

            cmd.Parameters.Add("@Mail", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Mail"].Value = Convert.ToString(pMail);

            cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
            cmd.Parameters["@Tlf"].Value = Convert.ToInt32(pTlf);

            cmd.Parameters.Add("@ErBeboer", System.Data.SqlDbType.Bit);
            cmd.Parameters["@ErBeboer"].Value = Convert.ToBoolean(false);

            //try-catch løkke
            try
            {
                conn.Open(); //Åbner forbindelsen til databasen
                cmd.ExecuteNonQuery(); //Udfører SQL kommandoen
                conn.Close(); //Lukker forbindelsen til databasen
                MessageBox.Show("SUCCESS :\nNyt medlem oprettet med værdierne:\n(" + //Vis beskedboks med besked om succes
                                    cmd.Parameters["@Navn"].Value + ", " +
                                    cmd.Parameters["@Mail"].Value + ", " +
                                    cmd.Parameters["@Tlf"].Value + ", " +
                                    cmd.Parameters["@ErBeboer"].Value +
                                    ")");
            }
            catch (Exception ex) //Hvis der er fejl
            {
                MessageBox.Show(ex.Message); //Vis beskedboks med fejlbesked
            }
        }
    }
}
