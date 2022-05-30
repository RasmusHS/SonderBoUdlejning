using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SonderBoUdlejning.BookingSystems
{
    internal class CheckMellemDatoer
    {
        public static int CheckDatesForBookings(string startDato, string slutDato, int rid)
        {
            ConnString connString = ConnString.getConnInstance;
            string query = $"SELECT COUNT(rId) FROM Reservationer WHERE rStartDato BETWEEN '{startDato}' AND '{slutDato}' AND rSlutDato BETWEEN '{startDato}' AND '{slutDato}' AND rId = {rid};";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int bookingBetweenDates = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return bookingBetweenDates;
        }
    }
}
