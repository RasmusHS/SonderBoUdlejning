using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonderBoUdlejning.BookingSystems
{
    internal class CheckResourceIdType
    {
        public static int getResourceIdType(string tbResourceID) 
        {
            if (Convert.ToInt32(tbResourceID) >= 1 && Convert.ToInt32(tbResourceID) <= 10) 
            {
                return 1;
            }
            if (Convert.ToInt32(tbResourceID) >= 11 && Convert.ToInt32(tbResourceID) <= 20)
            {
                return 2;
            }
            if (Convert.ToInt32(tbResourceID) >= 21 && Convert.ToInt32(tbResourceID) <= 30)
            {
                return 3;
            }
            return 4;
        }
    }
}
