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
        private static string strconn = @"SERVER=mssql13.unoeuro.com; DATABASE=kaspermark_dk_db_skolesql; UID=kaspermark_dk; PASSWORD=69qom3u9PW; Encrypt=False"; //Insert your connection string here
        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        personSQLBuilder personSQL = new personSQLBuilder();
        private static string sqlS = "";
        static SqlConnection conn = new SqlConnection(strconn);
        SqlCommand cmd = new SqlCommand(sqlS, conn);

        //PersonCRUD personCRUD = new PersonCRUD();
        SecretaryMain secretaryMain = new SecretaryMain();
        internal object personCRUDdgv = null;

        //private static string sqlS = "";

        /*private string _navn = "";
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
        public bool Alt { get { return _alt; } set { _alt = value; } }*/



        public void pSQLC(string fNavn, string pMail, string pTlf)
        {
            //fNavn = Navn;
            //pMail = Mail;
            //pTlf = Tlf;
            //string sqlS = "INSERT INTO Person VALUES (@Navn, @Mail, @Tlf)";
            sqlS = "INSERT INTO Person VALUES (@Navn, @Mail, @Tlf)";
            //SqlConnection conn = new SqlConnection(strconn);
            //SqlCommand cmd = new SqlCommand(sqlS, conn);
            cmd.Parameters.Clear();
            
            //SqlCommand cmd = new SqlCommand(sqlS, conn);

            cmd.Parameters.Add("@Navn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Navn"].Value = Convert.ToString(fNavn);
            
            cmd.Parameters.Add("@Mail", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Mail"].Value = Convert.ToString(pMail);

            cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
            cmd.Parameters["@Tlf"].Value = Convert.ToInt32(pTlf);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" +
                                    cmd.Parameters["@Navn"].Value + ", " +
                                    cmd.Parameters["@Mail"].Value + ", " +
                                    cmd.Parameters["@Tlf"].Value +
                                    ")");
                //tableConn.tableBinder("SELECT * FROM Person");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void pSQLR()
        {
            //string sqlS = "SELECT * FROM Person WHERE 1=1";
            sqlS = "SELECT * FROM Person WHERE 1=1";
            //SqlConnection conn = new SqlConnection(strconn);
            //SqlCommand cmd = new SqlCommand(sqlS, conn);
            cmd.Parameters.Clear();
            
            if (!string.IsNullOrEmpty(personSQL.Navn))
            {
                sqlS += " AND fNavn LIKE '%@Navn%'";
                cmd.Parameters.Add("@Navn", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Navn"].Value = Convert.ToString(personSQL.Navn);
            }
            else
                sqlS += "";

            if (!string.IsNullOrEmpty(personSQL.Mail))
            {
                sqlS += " AND pMail = '@Mail'";
                cmd.Parameters.Add("@Mail", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Mail"].Value = Convert.ToString(personSQL.Mail);
            }
            else
                sqlS += "";

            if (!string.IsNullOrEmpty(personSQL.Tlf))
            {
                sqlS += " AND pTlf = @Tlf";
                cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
                cmd.Parameters["@Tlf"].Value = Convert.ToInt32(personSQL.Tlf);
            }
            else
                sqlS += "";

            if (personSQL.Medlem == true)
            {
                sqlS += " AND erBeboer = @erBeboer";
                cmd.Parameters.Add("@erBeboer", System.Data.SqlDbType.Bit);
                cmd.Parameters["@erBeboer"].Value = false;
            }
            else if (personSQL.ErBeboer == true)
            {
                sqlS += " AND erBeboer = @erBeboer";
                cmd.Parameters.Add("@erBeboer", System.Data.SqlDbType.Bit);
                cmd.Parameters["@erBeboer"].Value = true;
            }
            else if (personSQL.Alt == true)
            {
                sqlS += "";
            }

            try
            {
                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();
                MessageBox.Show("Hej");
                //cmd.ExecuteNonQuery();
                SqlDataAdapter sqlDA = new SqlDataAdapter(); //Bridge between data source (the SQL server) and the data table
                sqlDA.SelectCommand.CommandText = cmd.CommandText;
                MessageBox.Show("" + sqlDA.SelectCommand.CommandText);

                //sqlDA.SelectCommand = cmd; //Assigns the SQL command to the data adapter
                MessageBox.Show("Hej2");
                DataTable dt = new DataTable(); //Creates a data table to hold the data
                //sqlDA.Fill(dt); //Fills the data table with data from the data source (the SQL server) using the SQL command
                MessageBox.Show("Hej3");
                //dgvPersonCRUD.DataSource = tableConn.tableBinder(personSQL.SQLBuilder());
                //personCRUD.DgvPersonCRUD.DataSource = bSource; //Assigns the binding source object to the data grid view
                //secretaryMain.Controls.Contains(dgvPersonCRUD);
                sqlDA.Fill(dt);
                //cmd.ExecuteNonQuery();
                //cmd.ExecuteReader();
                //cmd.CommandText = sqlDA;
                MessageBox.Show("Hej4");
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlS + "\nmed værdierne: (" +
                                    cmd.Parameters["@Navn"].Value + ", " +
                                    cmd.Parameters["@Mail"].Value + ", " +
                                    cmd.Parameters["@Tlf"].Value + ", " +
                                    cmd.Parameters["@erBeboer"].Value +
                                    ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void pSQLU(string fNavn, string pMail, string pTlf, string pId)
        {
            //fNavn = Navn;
            //pMail = Mail;
            //pTlf = Tlf;
            //string sqlS = "UPDATE Person SET fNavn = @Navn, pMail = @Mail, pTlf = @Tlf WHERE pId = @pId";
            sqlS = "UPDATE Person SET fNavn = @Navn, pMail = @Mail, pTlf = @Tlf WHERE pId = @pId";
            //SqlConnection conn = new SqlConnection(strconn);            
            //SqlCommand cmd = new SqlCommand(sqlS, conn);
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
                                    cmd.Parameters["@Tlf"].Value +
                                    ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void pSQLD(string pTlf)
        {
            //pTlf = Tlf;
            //string sqlS = "DELETE FROM Person WHERE pTlf = @Tlf";
            sqlS = "DELETE FROM Person WHERE pTlf = @Tlf";
            //SqlConnection conn = new SqlConnection(strconn);
            //SqlCommand cmd = new SqlCommand(sqlS, conn);
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
