using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;

namespace SonderBoUdlejning.InputCheck
{
    public static class PersonInputCheck //Klasse der tjekker brugerinput som skal interagere person tabellen
    {
        //Definere Regex
        private static Regex retal = new Regex(@"(^[0-9]*$)");
        private static Regex bogstaver = new Regex(@"(^[a-zA-ZæøåÆØÅ ]*$)");
        private static Regex email = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
        private static Regex SQLInject = new Regex(@"(;|--|'|#|=|"")");

        //Metode der tjekker om person ID input er gyldig
        public static bool PIdCheck(string pId)
        {
            if (SQLInject.IsMatch(pId))
            {
                ErrorMessage.ErrorList.Add("Person ID indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!retal.IsMatch(pId)))
                {
                    ErrorMessage.ErrorList.Add("Person ID må kun indeholde tal");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        //Metode der tjekker om navn input er gyldig
        public static bool NavnCheck(string navn)
        {
            if (SQLInject.IsMatch(navn))
            {
                ErrorMessage.ErrorList.Add("Navn indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!bogstaver.IsMatch(navn)) || (navn.Length > 50))
                {
                    ErrorMessage.ErrorList.Add("Navn må kun indeholde bogstaver og må ikke være længere end 50 tegn");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        //Metode der tjekker om mail input er gyldig
        public static bool MailCheck(string mail)
        {
            if (SQLInject.IsMatch(mail))
            {
                ErrorMessage.ErrorList.Add("Mail indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if (!string.IsNullOrEmpty(mail))
                {
                    if ((mail.Length > 50) || (!email.IsMatch(mail)))
                    {
                        ErrorMessage.ErrorList.Add("Mail må ikke være længere end 50 tegn og skal være en gyldig email uden æ, ø eller å");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
        }

        //Metode der tjekker om telefon input er gyldig
        public static bool TlfCheck(string tlf)
        {
            if (SQLInject.IsMatch(tlf))
            {
                ErrorMessage.ErrorList.Add("Telefonnummer indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if (!string.IsNullOrEmpty(tlf))
                {
                    if ((!retal.IsMatch(tlf)) || (tlf.Length != 8))
                    {
                        ErrorMessage.ErrorList.Add("Telefonnummer må kun indeholde tal og skal være 8 cifre");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
