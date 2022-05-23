using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SonderBoUdlejning.BookingSystems
{
    internal class CheckSlutDato
    {
       
        public static int CheckSlutDate(string slutdato, string resourceID) 
        {
            ConnString connString = ConnString.getConnInstance;
            string query = "SELECT COUNT(rId) FROM Ressourcer WHERE rId IN(SELECT rId FROM Reservationer WHERE '" + slutdato + "' BETWEEN rStartDato AND rSlutDato) AND rId = " + Convert.ToInt32(resourceID) + "";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int antalBookings = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return antalBookings;
        }
    }
}
