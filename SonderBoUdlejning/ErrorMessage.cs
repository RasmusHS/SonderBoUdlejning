using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonderBoUdlejning
{
    public static class ErrorMessage //Klasse der håndterer fejlbeskeder
    {
        //Liste bruges til at holde fejlbeskeder
        public static List<string> ErrorList = new List<string>();

        public static int injectedSQL { get; set; } //Property som bliver sat til 1 hvis der er injected SQL
        public static void resetInjectedSQL() //Metode der nulstiller injectedSQL
        {
            injectedSQL = 0;
        }

        //Metode der viser fejlbeskederne i en MessageBox
        public static void errorMessage() 
        {
            string displayError = string.Join(Environment.NewLine, ErrorList);
            MessageBox.Show(displayError); //Viser fejlbeskederne i en MessageBox
            ErrorList.Clear(); //Tømmer listen med fejlbeskeder
            resetInjectedSQL(); //Nulstiller injectedSQL
        }
    }
}
