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
        public List<string> pErrorList = new List<string>();
        private Regex retal = new Regex(@"(^[0-9]*$)");
        private Regex bogstaver = new Regex(@"(^[a-zA-ZæøåÆØÅ ]*$)");
        //private Regex SQLInject = new Regex(@"(;|--|'|#|=|"")");
        //private bool injectedSQL = false;

        private string _navn = "";
        public string Navn
        {
            get { return _navn; }
            set
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

        private string _mail = "";
        public string Mail
        {
            get { return _mail; }
            set
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

        private string _tlf = "";
        public string Tlf
        {
            get { return _tlf; }
            set
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

        private string _pId = "";
        public string PId
        {
            get { return _pId; }
            set
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

        /*public string SQLBuilder()
        {
            string displayError = string.Join(Environment.NewLine, pErrorList);
            MessageBox.Show(pErrorList.Count.ToString());
            MessageBox.Show(displayError);

            string pSQLQuery = "SELECT * FROM Person WHERE 1=1";

            if (Create == true)
                pSQLQuery = $"INSERT INTO Person VALUES (fNavn='{_navn}', pMail='{_mail}', pTlf={_tlf})";
            else if (Read == true)
                pSQLQuery = $"SELECT * FROM Person WHERE 1=1";
            else if (Update == true)
                pSQLQuery = $"UPDATE Person SET fNavn = '{_navn}', pMail = '{_mail}', pTlf = {_tlf} WHERE pId = {_pId}";
            else if (Delete == true)
                pSQLQuery = $"DELETE FROM Person WHERE Tlf = {_tlf}";

            if (Read == true)
            {
                if (!string.IsNullOrEmpty(_navn))
                    pSQLQuery += $" AND fNavn LIKE '%{_navn}%'";
                else
                    pSQLQuery += $"";

                if (!string.IsNullOrEmpty(_mail))
                    pSQLQuery += $" AND pMail = '{_mail}'";
                else
                    pSQLQuery += $"";

                if (!string.IsNullOrEmpty(_tlf))
                    pSQLQuery += $" AND pTlf = '{_tlf}'";
                else
                    pSQLQuery += $"";

                if (_medlem == true)
                    pSQLQuery += $" AND erBeboer = 0";
                else if (_erBeboer == true)
                    pSQLQuery += $" AND erBeboer = 1";
                else if (_alt == true)
                    pSQLQuery += $"";
            }

            if (injectedSQL == true)
                pSQLQuery = "";

            pErrorList.Clear();

            MessageBox.Show(pSQLQuery);

            return pSQLQuery;

        }*/
    }
}
