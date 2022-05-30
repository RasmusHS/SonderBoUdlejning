using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SonderBoUdlejning
{
    internal static class UserIdentification //Klasse som bruges til at identificere hvem der er logget på
    {
        //MSSQL server oplysninger
        public static string serverHost = "mssql13.unoeuro.com";
        public static string databaseName = "kaspermark_dk_db_skolesql";
        public static string DBUsername = "kaspermark_dk";
        public static string DBPass = "69qom3u9PW";
        public static string conString = "SERVER=" + serverHost + ";" + "DATABASE=" + databaseName + ";" + "UID=" + DBUsername + ";" + "PASSWORD=" + DBPass + "; Encrypt=False";

        public static int UserAccess { get; set; }
        
    }
}
