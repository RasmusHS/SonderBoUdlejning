using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using SonderBoUdlejning.SQLBuilders;

namespace SonderBoUdlejning //Change this to match your projects namespace
{
    public class SQLExecutionHandler
    {
        private string strconn = @"SERVER=mssql13.unoeuro.com; DATABASE=kaspermark_dk_db_skolesql; UID=kaspermark_dk; PASSWORD=69qom3u9PW; Encrypt=False"; //Insert your connection string here
        personSQLBuilder personSQL = personSQLBuilder.getPInstance();

        public object tableBinder(string sqlStatement)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strconn); //Encapsulates conn string in an object
                conn.Open(); //opens connection to database

                string sqlS = sqlStatement; //SQL statement sent from the form
                SqlCommand cmd = new SqlCommand(sqlS, conn); //Encapsulates SQL statement in an object

                SqlDataAdapter sqlDA = new SqlDataAdapter(); //Bridge between data source (the SQL server) and the data table
                sqlDA.SelectCommand = cmd; //Assigns the SQL command to the data adapter

                DataTable dt = new DataTable(); //Creates a data table to hold the data
                sqlDA.Fill(dt); //Fills the data table with data from the data source (the SQL server) using the SQL command

                BindingSource bSource = new BindingSource(); //Creates a binding source object to hold the data table
                bSource.DataSource = dt; //Assigns the data table to the binding source object
                conn.Close(); //Closes the connection to the database
                sqlDA.Update(dt); //Updates the data grid view if INSERT, UPDATE or DELETE statements were made
                return bSource; //returns the binding source object back to the form that called the method
            }
            catch (Exception ex)
            {
                personSQL.errorMessage();
                personSQL.pErrorList.Clear();
                personSQL.injectedSQL = 0;
                return null;
            }
        }

        //Sample template
        /*
         SQLExecutionHandler tableConn = new SQLExecutionHandler();
        
         private void Form1_Load(object sender, EventArgs e)
         {   
             string sqlS1 = "SELECT * FROM Bolig";
             dataGridView1.DataSource = tableConn.tableBinder(sqlS1);

             string sqlS2 = "SELECT * FROM Kunde";
             dataGridView2.DataSource = tableConn.tableBinder(sqlS2);
         }
         */        
    }
}
