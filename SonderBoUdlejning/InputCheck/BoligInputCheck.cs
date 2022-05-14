using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SonderBoUdlejning.InputCheck
{
    public static class BoligInputCheck
    {
        private static Regex retal = new Regex(@"(^[0-9 ]*$)");
        private static Regex dato = new Regex(@"(^[0-9]{2}-[0-9]{2}-[0-9]{4}$)");
        //private static Regex dato = new Regex(@"(^[0-9]{4}-[0-9]{2}-[0-9]{2}$)");
        private static Regex bogstaver = new Regex(@"(^[a-zA-ZæøåÆØÅ ]*$)");
        private static Regex SQLInject = new Regex(@"(;|--|'|#|=|"")");

        public static bool AdresseCheck(string adresse)
        {
            if (SQLInject.IsMatch(adresse))
            {
                ErrorMessage.ErrorList.Add("Adresse indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if ((adresse.Length > 50))
                {
                    ErrorMessage.ErrorList.Add("Adresse må ikke være længere end 50 tegn");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool PostNrCheck(string postNr)
        {
            if (SQLInject.IsMatch(postNr))
            {
                ErrorMessage.ErrorList.Add("PostNr indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if (!string.IsNullOrEmpty(postNr))
                {
                    if ((!retal.IsMatch(postNr)) || (postNr.Length != 4))
                    {
                        ErrorMessage.ErrorList.Add("PostNr må kun indeholde tal og skal være 4 cifre");
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


        public static bool BIdCheck(string bId)
        {
            if (SQLInject.IsMatch(bId))
            {
                ErrorMessage.ErrorList.Add("Bolig ID indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!retal.IsMatch(bId)))
                {
                    ErrorMessage.ErrorList.Add("Bolig ID må kun indeholde tal");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static string indDato;
        public static bool indflytDato(string indDato)
        {
            if (SQLInject.IsMatch(indDato))
            {
                ErrorMessage.ErrorList.Add("Indflytningsdato indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if (!string.IsNullOrEmpty(indDato))
                {
                    if ((indDato.Length != 10) || (!dato.IsMatch(indDato)))
                    {
                        ErrorMessage.ErrorList.Add("Indflytningsdato skal være på formatet dd-mm-åååå, skal være 10 tegn langt og må ikke indeholde bogstaver");
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

        public static string udDato;
        public static bool udflytDato(string udDato)
        {
            if (SQLInject.IsMatch(udDato))
            {
                ErrorMessage.ErrorList.Add("Udflytningsdato indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if (!string.IsNullOrEmpty(udDato))
                {
                    if ((udDato.Length != 10) || (!dato.IsMatch(udDato)))
                    {
                        ErrorMessage.ErrorList.Add("Udflytningsdato skal være på formatet dd-mm-åååå, skal være 10 tegn langt og må ikke indeholde bogstaver");
                        return false;
                    }
                    else if ((Convert.ToDateTime(udDato) < Convert.ToDateTime(indDato)))
                    {
                        ErrorMessage.ErrorList.Add("Udflytningsdato skal være efter indflytningsdato");
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

        public static bool bTypeCheck(string bType)
        {
            if (SQLInject.IsMatch(bType))
            {
                ErrorMessage.ErrorList.Add("bType indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!bogstaver.IsMatch(bType)))
                {
                    ErrorMessage.ErrorList.Add("bType må kun indeholde bogstaver");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool antalRumCheck(string antalRum)
        {
            if (SQLInject.IsMatch(antalRum))
            {
                ErrorMessage.ErrorList.Add("antalRum indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!retal.IsMatch(antalRum)))
                {
                    ErrorMessage.ErrorList.Add("antalRum må kun indeholde tal");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool kvmCheck(string kvm)
        {
            if (SQLInject.IsMatch(kvm))
            {
                ErrorMessage.ErrorList.Add("kvm indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!retal.IsMatch(kvm)))
                {
                    ErrorMessage.ErrorList.Add("kvm må kun indeholde tal");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool lejePrisCheck(string lejePris)
        {
            if (SQLInject.IsMatch(lejePris))
            {
                ErrorMessage.ErrorList.Add("lejePris indeholder ugyldige tegn");
                ErrorMessage.injectedSQL = 1;
                return false;
            }
            else
            {
                if ((!retal.IsMatch(lejePris)))
                {
                    ErrorMessage.ErrorList.Add("lejePris må kun indeholde tal");
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
