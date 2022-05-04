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
    public sealed class personInputCheck
    {
        public List<string> pErrorList = new List<string>();
        private Regex retal = new Regex(@"(^[0-9]*$)");
        private Regex bogstaver = new Regex(@"(^[a-zA-ZæøåÆØÅ ]*$)");
        private Regex SQLInject = new Regex(@"(;|--|'|#|=|"")");
        
        public int injectedSQL { get; private set; }
        public void resetInjectedSQL()
        {
            injectedSQL = 0;
        }

        public bool NavnCheck(string navn)
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

        public bool MailCheck(string mail)
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

        public bool TlfCheck(string tlf)
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

        public bool PIdCheck(string pId)
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

        public string errorMessage()
        {
            string displayError = string.Join(Environment.NewLine, pErrorList);
            return displayError;
        }
    }
}
