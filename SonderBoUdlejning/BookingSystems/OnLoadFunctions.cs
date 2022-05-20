using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SonderBoUdlejning.BookingSystems
{
    internal class OnLoadFunctions
    {
        
        public static void GetPeronList(List<int> beboerID, List<string> beboer)
        {
            ConnString connString = ConnString.getConnInstance;
            SQLExecutionHandler tableConn = new SQLExecutionHandler();
            string query = "SELECT COUNT(fNavn) FROM Person WHERE erBeboer = 1";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int antalBeboer = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            string query2 = "SELECT pId FROM Person WHERE erBeboer = 1";
            SqlCommand cmd2 = new SqlCommand(query2, conn);

            conn.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            for (int i = 0; i < antalBeboer; i++)
            {
                while (reader2.Read())
                {
                    beboerID.Add(reader2.GetInt32(i));
                }
            }
            conn.Close();

            string query3 = "SELECT fNavn FROM Person WHERE erBeboer = 1";
            SqlCommand cmd3 = new SqlCommand(query3, conn);

            conn.Open();
            SqlDataReader reader3 = cmd3.ExecuteReader();
            for (int i = 0; i < antalBeboer; i++)
            {
                while (reader3.Read())
                {
                    beboer.Add(reader3.GetString(i));
                }
            }
            conn.Close();
        }

        public static void GetResourceList(List<int> listResourceID, List<string> listResource, string date) 
        {
            ConnString connString = ConnString.getConnInstance;
            SQLExecutionHandler tableConn = new SQLExecutionHandler();
            string query = "SELECT COUNT(rTypeNavn) FROM Ressourcer WHERE rId NOT IN(SELECT rId FROM Reservationer WHERE '"+date+"' BETWEEN rStartDato AND rSlutDato)";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int antalResources = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            string query2 = "SELECT rTypeNavn FROM Ressourcer WHERE rId NOT IN(SELECT rId FROM Reservationer WHERE '" + date + "' BETWEEN rStartDato AND rSlutDato)";
            SqlCommand cmd2 = new SqlCommand(query2, conn);

            conn.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            for (int i = 0; i < antalResources; i++)
            {
                while (reader2.Read())
                {
                    listResource.Add(reader2.GetString(i));
                }
            }
            conn.Close();

            string query3 = "SELECT rId FROM Ressourcer WHERE rId NOT IN(SELECT rId FROM Reservationer WHERE '" + date + "' BETWEEN rStartDato AND rSlutDato)";
            SqlCommand cmd3 = new SqlCommand(query3, conn);

            conn.Open();
            SqlDataReader reader3 = cmd3.ExecuteReader();
            for (int i = 0; i < antalResources; i++)
            {
                while (reader3.Read())
                {
                    listResourceID.Add(reader3.GetInt32(i));
                }
            }
            conn.Close();
        }
    }
}
