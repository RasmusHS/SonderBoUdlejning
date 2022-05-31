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
    internal class UpdateLejemaal
    {
        //Finder connectionstring til databasen frem fra ConnString klassen
        ConnString connString = ConnString.getConnInstance;

        //Metode der opdaterer en lejemål
        public void updateLejemaal(string lejemaalNr, string adresse, string postNr, string Lid, string pId, string indDato, string udDato)
        {
            //Definere SQL Query med parametrenavne
            string sqlS = "UPDATE Lejemaal SET adresse = @adresse, postNr = @postNr, Lid = @Lid, pId = @pId, indflytDato = @indflytDato, udflytDato = @udflytDato WHERE lejemaalNr = @lejemaalNr";
            SqlConnection conn = new SqlConnection(connString.connStr); //Opretter forbindelse til databasen
            SqlCommand cmd = new SqlCommand(sqlS, conn); //Opretter SQL kommandoen
            cmd.Parameters.Clear(); //Rydder parametre fra kommandoen

            //Tilføjer parametre til kommandoen
            cmd.Parameters.Add("@lejemaalNr", System.Data.SqlDbType.Int);
            cmd.Parameters["@lejemaalNr"].Value = Convert.ToString(lejemaalNr);
            
            cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@adresse"].Value = Convert.ToString(adresse);

            cmd.Parameters.Add("@postNr", System.Data.SqlDbType.Int);
            cmd.Parameters["@postNr"].Value = Convert.ToInt32(postNr);

            cmd.Parameters.Add("@Lid", System.Data.SqlDbType.Int);
            cmd.Parameters["@Lid"].Value = Convert.ToInt32(Lid);

            
            cmd.Parameters.Add("@pId", System.Data.SqlDbType.Int); 
            if (string.IsNullOrEmpty(pId)) //Hvis der ikke er valgt en ejer
                cmd.Parameters["@pId"].Value = DBNull.Value; //Sætter værdien til DBNull
            else
                cmd.Parameters["@pId"].Value = Convert.ToInt32(pId); //Sætter værdien til pId

            cmd.Parameters.Add("@indflytDato", System.Data.SqlDbType.Date);
            if (string.IsNullOrEmpty(indDato)) //Hvis der ikke er en indflytningsdato
                cmd.Parameters["@indflytDato"].Value = DBNull.Value; //Sætter værdien til DBNull
            else
                cmd.Parameters["@indflytDato"].Value = Convert.ToDateTime(indDato); //Sætter værdien til indDato

            cmd.Parameters.Add("@udflytDato", System.Data.SqlDbType.Date);
            if (string.IsNullOrEmpty(udDato)) //Hvis der ikke er en udflytningsdato
                cmd.Parameters["@udflytDato"].Value = DBNull.Value; //Sætter værdien til DBNull
            else
                cmd.Parameters["@udflytDato"].Value = Convert.ToDateTime(udDato); //Sætter værdien til udDato

            //try-catch løkke
            try
            {
                conn.Open(); //Åbner forbindelsen til databasen
                cmd.ExecuteNonQuery(); //Forsøger at udføre kommandoen
                conn.Close(); //Lukker forbindelsen til databasen

                //Vis beskedboks med besked om succes
                ErrorMessage.ErrorList.Add($"\nOpdaterede lejemål nr. {lejemaalNr}.");
            }
            catch (Exception ex) //Hvis der er fejl
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
