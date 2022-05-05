using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SonderBoUdlejning.SQLBuilders
{
    public static class personInputCheck
    {
        public static List<string> pErrorList = new List<string>();
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
            string displayError = string.Join(Environment.NewLine, pErrorList);
            return displayError;
        }

        public static bool NavnCheck(string navn)
        {
            if (SQLInject.IsMatch(navn))
            {
                pErrorList.Add("Navn indeholder ugyldige tegn");
                injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!bogstaver.IsMatch(navn)) || (navn.Length > 50))
                {
                    pErrorList.Add("Navn må kun indeholde bogstaver og må ikke være længere end 50 tegn");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool MailCheck(string mail)
        {
            if (SQLInject.IsMatch(mail))
            {
                pErrorList.Add("Mail indeholder ugyldige tegn");
                injectedSQL = 1;
                return false;
            }
            else
            {
                if (mail.Length > 50)
                {
                    pErrorList.Add("Mail må ikke være længere end 50 tegn");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool TlfCheck(string tlf)
        {
            if (SQLInject.IsMatch(tlf))
            {
                pErrorList.Add("Telefonnummer indeholder ugyldige tegn");
                injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!retal.IsMatch(tlf)) || (tlf.Length > 8))
                {
                    pErrorList.Add("Telefonnummer må kun indeholde tal og må ikke være længere end 8 tegn");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool PIdCheck(string pId)
        {
            if (SQLInject.IsMatch(pId))
            {
                pErrorList.Add("Person ID indeholder ugyldige tegn");
                injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!retal.IsMatch(pId)))
                {
                    pErrorList.Add("Person ID må kun indeholde tal");
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
