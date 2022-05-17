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
    public static class BoligInputCheck //Klasse der tjekker brugerinput som skal interagere bolig tabellen
    {
        //Definere Regex
        private static Regex retal = new Regex(@"(^[0-9 ]*$)");
        private static Regex dato = new Regex(@"(^[0-9]{2}-[0-9]{2}-[0-9]{4}$)");
        //private static Regex dato = new Regex(@"(^[0-9]{4}-[0-9]{2}-[0-9]{2}$)");
        private static Regex bogstaver = new Regex(@"(^[a-zA-ZæøåÆØÅ ]*$)");
        private static Regex adresseReg = new Regex(@"(^[a-zA-ZæøåÆØÅ0-9 ]*$)");
        private static Regex SQLInject = new Regex(@"(;|--|'|#|=|"")");

        //Ikke alle metoder er kommenteret, da metoderne er meget ens

        //Metode der tjekker om adresse input er gyldig
        public static bool AdresseCheck(string adresse)
        {
            if (SQLInject.IsMatch(adresse)) //Tjekker efter SQL injection
            {
                ErrorMessage.ErrorList.Add("Adresse indeholder ugyldige tegn"); //Tilføjer fejlbesked til errorlist
                ErrorMessage.injectedSQL = 1; //Sætter injectedSQL til 1
                return false; //Returnerer false
            }
            else
            {
                if (!string.IsNullOrEmpty(adresse)) //Tjekker om adresse er tom
                {
                    if ((!adresseReg.IsMatch(adresse)) || (adresse.Length > 50)) //Tjekker om adresse indeholder ugyldige tegn og at adressen ikke er længere end 50 tegn
                    {
                        ErrorMessage.ErrorList.Add("Adresse må ikke indeholde ugyldige tegne eller være længere end 50 tegn"); //Tilføjer fejlbesked til errorlist
                        return false; //Returnerer false
                    }
                    else //Hvis adresse er gyldig
                    {
                        return true; //Returnerer true
                    }
                }
                else //Hvis adresse er tom
                {
                    return true; //Returnerer true
                }
            }
        }

        //Metode der tjekker om postnr input er gyldig
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

        //Metode der tjekker om bolig ID input er gyldig
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
                if (!string.IsNullOrEmpty(bId))
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
                else
                {
                    return true;
                }
            }
        }

        //Metode der tjekker om indflytningsDato input er gyldig
        public static string indDato; //String field så udflytningsDato kan sammenlignes med indflytningsDato
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

        //Metode der tjekker om udflytningsDato input er gyldig
        public static string udDato; //String field som holder fast på en udflytningsDato for en form
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
                    else if ((Convert.ToDateTime(udDato) < Convert.ToDateTime(indDato))) //Hvis udflytningsDato input er før indflytningsDato input
                    {
                        //Denne del bruges primært til opsigelse af boliger
                        ErrorMessage.ErrorList.Add("Udflytningsdato skal være efter indflytningsdato"); //Tilføjer fejlbesked til errorlist
                        return false; //Returnerer false
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

        //Metode der tjekker om bolig type input er gyldig. Bruges ikke i øjeblikket
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

        //Metode der tjekker antalRum input er gyldig. Bruges ikke i øjeblikket
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

        //Metode der tjekker om kvm input er gyldig
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

        //Metode der tjekker om lejePris input er gyldig
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
