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
    public class personSQLBuilder
    {
        static personSQLBuilder pInstance;

        private static object locker = new object();

        private personSQLBuilder()
        {

        }

        public static personSQLBuilder getPInstance()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (pInstance == null)
            {
                lock (locker)
                {
                    if (pInstance == null)
                    {
                        pInstance = new personSQLBuilder();
                    }
                }
            }
            return pInstance;
        }

        public List<string> pErrorList = new List<string>();
        private Regex retal = new Regex(@"(^[0-9]*$)");
        private Regex bogstaver = new Regex(@"(^[a-zA-ZæøåÆØÅ ]*$)");
        private Regex SQLInject = new Regex(@"(;|--|'|#|=|"")");
        public int injectedSQL;

        private string _navn = "";
        public string Navn
        {
            get { return _navn; }
            set
            {
                if (SQLInject.IsMatch(value))
                {
                    injectedSQL = 1;
                    pErrorList.Add("SQL injection er ikke tilladt");
                    _navn = value;

                }
                else
                {
                    if ((!bogstaver.IsMatch(value)) || (value.Length > 50))
                    {
                        pErrorList.Add("Navn må kun indeholde bogstaver og må ikke være længere end 50 tegn");
                        value = "";
                        _navn = value;
                    }
                    else
                    {
                        _navn = value;
                    }
                }
                
            }
        }

        private string _mail = "";
        public string Mail
        {
            get { return _mail; }
            set
            {
                if (SQLInject.IsMatch(value))
                {
                    injectedSQL = 1;
                    pErrorList.Add("SQL injection er ikke tilladt");
                    _mail = value;
                }
                else
                {
                    if (value.Length > 50)
                    {
                        pErrorList.Add("Mail skal være mindre end 50 tegn");
                        value = "";
                        _mail = value;
                    }
                    else
                    {
                        _mail = value;
                    }
                }

            }
        }

        private string _tlf = "";
        public string Tlf
        {
            get { return _tlf; }
            set
            {
                if (SQLInject.IsMatch(value))
                {
                    injectedSQL = 1;
                    pErrorList.Add("SQL injection er ikke tilladt");
                    _tlf = value;
                }
                else
                {
                    if ((!retal.IsMatch(value)) || (value.Length > 8))
                    {
                        pErrorList.Add("Telefon må kun indeholde tal og skal være 8 cifre eller mindre");
                        value = "";
                        _tlf = value;
                    }
                    else
                    {
                        _tlf = value;
                    }
                }

            }
        }

        private string _pId = "";
        public string PId
        {
            get { return _pId; }
            set
            {
                if (SQLInject.IsMatch(value))
                {
                    injectedSQL = 1;
                    pErrorList.Add("SQL injection er ikke tilladt");
                    _pId = value;
                }
                else
                {
                    if (!retal.IsMatch(value))
                    {
                        pErrorList.Add("Person ID skal kun indeholde tal");
                        value = "";
                        _pId = value;
                    }
                    else
                    {
                        _pId = value;
                    }
                }
            }
        }


        private bool _medlem = false;
        public bool Medlem
        {
            get { return _medlem; }
            set { _medlem = value; }
        }

        private bool _erBeboer = false;
        public bool ErBeboer
        {
            get { return _erBeboer; }
            set { _erBeboer = value; }
        }

        private bool _alt = false;
        public bool Alt
        {
            get { return _alt; }
            set { _alt = value; }
        }

        private bool _create = false;
        public bool Create
        {
            get { return _create; }
            set { _create = value; }
        }

        private bool _read = false;
        public bool Read
        {
            get { return _read; }
            set { _read = value; }
        }

        private bool _update = false;
        public bool Update
        {
            get { return _update; }
            set { _update = value; }
        }

        private bool _delete = false;
        public bool Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }

        public void errorMessage()
        {
            string displayError = string.Join(Environment.NewLine, pErrorList);
            MessageBox.Show(displayError);
        }
    }
}
