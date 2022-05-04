using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using SonderBoUdlejning.SQLBuilders;
using SonderBoUdlejning.Secretary;

namespace SonderBoUdlejning
{
    public class pSQLRunner 
    {
        //private static string strconn = @"SERVER=mssql13.unoeuro.com; DATABASE=kaspermark_dk_db_skolesql; UID=kaspermark_dk; PASSWORD=69qom3u9PW; Encrypt=False"; //Insert your connection string here
        ConnString connString = ConnString.getConnInstance;
        personInputCheck personSQL = personInputCheck.getPInstance();        
        public List<string> paramList = new List<string>();
        internal object personCRUDdgv = null;

        private string _pId = "";
        public string PId { get { return _pId; } set { _pId = value; } }
        
        private string _navn = "";
        public string Navn { get { return _navn; } set { _navn = value; } }

        private string _mail = "";
        public string Mail { get { return _mail; } set { _mail = value; } }

        private string _tlf = "";
        public string Tlf { get { return _tlf; } set { _tlf = value; } }

        private bool _medlem = false;
        public bool Medlem { get { return _medlem; } set { _medlem = value; } }

        private bool _erBeboer = false;
        public bool ErBeboer { get { return _erBeboer; } set { _erBeboer = value; } }

        private bool _alt = false;
        public bool Alt { get { return _alt; } set { _alt = value; } }

        private bool _create = false;
        public bool Create { get { return _create; } set { _create = value; } }

        private bool _read = false;
        public bool Read { get { return _read; } set { _read = value; } }

        private bool _update = false;
        public bool Update { get { return _update; } set { _update = value; } }

        private bool _delete = false;
        public bool Delete { get { return _delete; } set { _delete = value; } }

        public string errorMessage()
        {
            string displayError = string.Join(Environment.NewLine, personSQL.pErrorList);
            MessageBox.Show(displayError);
            return displayError;
        }

        public void pSQLC(string fNavn, string pMail, string pTlf)
        {
            //string didag = DateTime.Now.ToString("yyyy’-‘MM’-‘dd’ ’HH’:’mm’:’ss");

            string sqlS = "INSERT INTO Person VALUES (@Navn, @Mail, @Tlf, @ErBeboer)";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(sqlS, conn);
            
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@Navn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Navn"].Value = Convert.ToString(fNavn);
            
            cmd.Parameters.Add("@Mail", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Mail"].Value = Convert.ToString(pMail);

            cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
            cmd.Parameters["@Tlf"].Value = Convert.ToInt32(pTlf);

            cmd.Parameters.Add("@ErBeboer", System.Data.SqlDbType.Bit);
            cmd.Parameters["@ErBeboer"].Value = Convert.ToBoolean(false);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" +
                                    cmd.Parameters["@Navn"].Value + ", " +
                                    cmd.Parameters["@Mail"].Value + ", " +
                                    cmd.Parameters["@Tlf"].Value + ", " +
                                    cmd.Parameters["@ErBeboer"].Value +
                                    ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string pSQLR(string fNavn, string pMail, string pTlf, bool medlem, bool erBeboer, bool alt)
        {
            this.Navn = personSQL.Navn = fNavn;
            this.Mail = personSQL.Mail = pMail;
            this.Tlf = personSQL.Tlf = pTlf;
            this.Medlem = personSQL.Medlem = medlem;
            this.ErBeboer = personSQL.ErBeboer = erBeboer;
            this.Alt = personSQL.Alt = alt;

            string sqlS = $"SELECT * FROM Person WHERE 1=1";

            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(sqlS, conn);
            
            SqlDataAdapter sqlDA = new SqlDataAdapter(cmd); //Bridge between data source (the SQL server) and the data table
            DataTable dt = new DataTable(); //Creates a data table to hold the data

            if (!string.IsNullOrEmpty(fNavn))
                sqlS += $" AND fNavn LIKE '%{fNavn}%'";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(pMail))
                sqlS += $" AND pMail = '{pMail}'";
            else
                sqlS += $"";

            if (!string.IsNullOrEmpty(pTlf))
                sqlS += $" AND pTlf = '{pTlf}'";
            else
                sqlS += $"";

            if (medlem == true)
                sqlS += $" AND erBeboer = 0";
            else if (erBeboer == true)
                sqlS += $" AND erBeboer = 1";
            else if (alt == true)
                sqlS += $"";
            else
                sqlS += $"";

            try
            {
                conn.Open();
                if (personSQL.injectedSQL == 1)
                {
                    sqlS = "";
                    conn.Close();
                }
                else
                {
                    sqlDA.Fill(dt);
                    personCRUDdgv = dt;
                    conn.Close();
                    return sqlS;
                }

                return sqlS;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ex.ToString();
            }
        }

        public void pSQLU(string fNavn, string pMail, string pTlf, string pId)
        {
            string sqlS = "UPDATE Person SET fNavn = @Navn, pMail = @Mail, pTlf = @Tlf, erBeboer = 0 WHERE pId = @pId";
            SqlConnection conn = new SqlConnection(connString.connStr);            
            SqlCommand cmd = new SqlCommand(sqlS, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@Navn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Navn"].Value = Convert.ToString(fNavn);

            cmd.Parameters.Add("@Mail", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Mail"].Value = Convert.ToString(pMail);

            cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
            cmd.Parameters["@Tlf"].Value = Convert.ToInt32(pTlf);

            cmd.Parameters.Add("@pId", System.Data.SqlDbType.Int);
            cmd.Parameters["@pId"].Value = Convert.ToInt32(pId);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" +
                                    cmd.Parameters["@Navn"].Value + ", " +
                                    cmd.Parameters["@Mail"].Value + ", " +
                                    cmd.Parameters["@Tlf"].Value + ", " +
                                    cmd.Parameters["@pId"].Value +
                                    ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void pSQLD(string pTlf)
        {
            string sqlS = "DELETE FROM Person WHERE pTlf = @Tlf";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(sqlS, conn);
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
            cmd.Parameters["@Tlf"].Value = Convert.ToInt32(pTlf);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" + cmd.Parameters["@Tlf"].Value + ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
