using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonderBoUdlejning
{
    internal static class ErrorMessage
    {
        //ErrorMessage.ErrorList.Add
        public static List<string> ErrorList = new List<string>();

        public static int injectedSQL { get; set; }
        public static void resetInjectedSQL()
        {
            injectedSQL = 0;
        }

        public static string errorMessage()
        {
            string displayError = string.Join(Environment.NewLine, ErrorList);
            return displayError;
        }
    }
}
