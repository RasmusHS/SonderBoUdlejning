using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonderBoUdlejning
{
    //Singleton bruges til at sikre at der kun er én instans af connectionstring.
    public sealed class ConnString //Sealed forhindre andre klasser fra at arve fra denne klasse
    {
        //Sætter databasens connectionstring til at være readonly
        public readonly string connStr = @"SERVER=mssql13.unoeuro.com; DATABASE=kaspermark_dk_db_skolesql; UID=kaspermark_dk; PASSWORD=69qom3u9PW; Encrypt=False";

        //eager initialization. Initialisere connectionstring når programmet starter.
        private static readonly ConnString connInstance = new ConnString();        

        //private static object locker = new object();

        private ConnString() //Privat constructor sørger for at man skal bruge getConnInstance for at få connectionstring og forhindre kreationen af nye instanser
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
