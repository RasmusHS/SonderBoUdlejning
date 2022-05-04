using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonderBoUdlejning
{
    public sealed class ConnString
    {
        public readonly string connStr = @"SERVER=mssql13.unoeuro.com; DATABASE=kaspermark_dk_db_skolesql; UID=kaspermark_dk; PASSWORD=69qom3u9PW; Encrypt=False";

        //eager initialization
        private static readonly ConnString connInstance = new ConnString();        

        private static object locker = new object();

        private ConnString()
        {

        }

        public static ConnString getConnInstance
        {
            get
            {
                return connInstance;
            }
        }
    }
}
