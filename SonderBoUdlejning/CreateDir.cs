using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SonderBoUdlejning
{
    internal class CreateDir
    {
        public static void CreateDirectory() 
        {
            string username = Environment.UserName;
            string dir1 = $@"C:\Users\{username}\Documents\SønderBoUdlejning\Statistik";
            string dir2 = $@"C:\Users\{username}\Documents\SønderBoUdlejning\Kontrakter\Aktive_Lejekontrakter";
            // If directory does not exist, create it
            if (!Directory.Exists(dir1))
            {
                Directory.CreateDirectory(dir1);
            }

            if (!Directory.Exists(dir2))
            {
                Directory.CreateDirectory(dir2);
            }
        }
    }
}
