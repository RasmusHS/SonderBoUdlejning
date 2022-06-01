using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SonderBoUdlejning.BookingSystems
{
    internal class SetArrayInfo
    {
        
        public static void FillArrays(string[] rTypeNavnArray, string[] antalReservationerArray, SqlConnection conn)
            {
            
            conn.Open();
            for (int i = 0; i < rTypeNavnArray.Length; i++)
            {
                string query = $"SELECT rTypeNavn, ( SELECT COUNT(resNr) FROM Reservationer WHERE rId = {i} + 1 ) AS AntalReservationer FROM Ressourcer WHERE rId = {i} + 1;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rTypeNavnArray[i] = reader["rTypeNavn"].ToString();
                }
                reader.Close();
            }

            for (int i = 0; i < antalReservationerArray.Length; i++)
            {
                string query = $"SELECT rTypeNavn, ( SELECT COUNT(resNr) FROM Reservationer WHERE rId = {i} + 1 ) AS AntalReservationer FROM Ressourcer WHERE rId = {i} + 1;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    antalReservationerArray[i] = (reader["AntalReservationer"].ToString());
                }
                reader.Close();
            }
            conn.Close();
        }
    }
}
