using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SonderBoUdlejning.BookingSystems
{
    internal class Create
    {
        public static void CreateDir() 
        {
            string username = Environment.UserName;
            string dir = $@"C:\Users\{username}\Documents\SønderBoUdlejning\Statistik";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }
}
