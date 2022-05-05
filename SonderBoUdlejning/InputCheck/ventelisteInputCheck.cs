using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SonderBoUdlejning.InputCheck
{
    public static class ventelisteInputCheck
    {
        public static List<string> vErrorList = new List<string>();
        private static Regex retal = new Regex(@"(^[0-9]*$)");
        private static Regex bogstaver = new Regex(@"(^[a-zA-ZæøåÆØÅ ]*$)");
        private static Regex SQLInject = new Regex(@"(;|--|'|#|=|"")");

        public static int injectedSQL { get; private set; }
        public static void resetInjectedSQL()
        {
            injectedSQL = 0;
        }

        public static string errorMessage()
        {
            string displayError = string.Join(Environment.NewLine, vErrorList);
            return displayError;
        }        

        public static bool PIdCheck(string pId)
        {
            if (SQLInject.IsMatch(pId))
            {
                vErrorList.Add("Person ID indeholder ugyldige tegn");
                injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!retal.IsMatch(pId)))
                {
                    vErrorList.Add("Person ID må kun indeholde tal");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool BIdCheck(string bId)
        {
            if (SQLInject.IsMatch(bId))
            {
                vErrorList.Add("Bolig ID indeholder ugyldige tegn");
                injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!retal.IsMatch(bId)))
                {
                    vErrorList.Add("Bolig ID må kun indeholde tal");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
