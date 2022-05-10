using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SonderBoUdlejning
{
    internal static class UserIdentification
    {
        //MSSQL server oplysninger
        public static string serverHost = "mssql13.unoeuro.com";
        public static string databaseName = "kaspermark_dk_db_skolesql";
        public static string DBUsername = "kaspermark_dk";
        public static string DBPass = "69qom3u9PW";
        public static string conString = "SERVER=" + serverHost + ";" + "DATABASE=" + databaseName + ";" + "UID=" + DBUsername + ";" + "PASSWORD=" + DBPass + "; Encrypt=False";
        //"SERVER=mssql13.unoeuro.com; DATABASE=kaspermark_dk_db_skolesql; UID=kaspermark_dk; PASSWORD=69qom3u9PW; Encrypt=False";

        public static int UserAccess { get; set; }
        
    }
}
