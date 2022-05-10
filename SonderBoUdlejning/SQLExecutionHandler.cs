﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SonderBoUdlejning //Change this to match your projects namespace
{
    public class SQLExecutionHandler
    {
        ConnString connString = ConnString.getConnInstance;

        public object tableBinder(string sqlStatement)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString.connStr); //Encapsulates conn string in an object
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
            catch
            {
                MessageBox.Show(ErrorMessage.errorMessage());
                ErrorMessage.ErrorList.Clear();
                ErrorMessage.resetInjectedSQL();
                return null;
            }
        }

        //Sample template for connecting dataGridView to a table from the db
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

        public List<string> comboBoxBinder(string sqlStatement)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString.connStr); //Encapsulates conn string in an object
                conn.Open(); //opens connection to database

                string sqlS = sqlStatement; //SQL statement sent from the form
                SqlCommand cmd = new SqlCommand(sqlS, conn); //Encapsulates SQL statement in an object

                List<string> comboBoxList = new List<string>(); //Creates a list to hold the data
                using (SqlDataReader reader = cmd.ExecuteReader()) //Executes the SQL command and returns a data reader object
                {
                    while (reader.Read()) //Reads the data from the data reader object
                    {
                        comboBoxList.Add(reader[0].ToString()); //Adds the data to the list
                    }
                }
                conn.Close(); //Closes the connection to the database
                return comboBoxList; //returns the list back to the form that called the method
            }
            catch
            {
                MessageBox.Show(ErrorMessage.errorMessage());
                ErrorMessage.ErrorList.Clear();
                ErrorMessage.resetInjectedSQL();
                return null;
            }
        }

        public string textBoxBinder(string sqlStatement)
        {
            string textBoxContent = "";
            try
            {
                SqlConnection conn = new SqlConnection(connString.connStr); //Encapsulates conn string in an object
                conn.Open(); //opens connection to database

                string sqlS = sqlStatement; //SQL statement sent from the form
                SqlCommand cmd = new SqlCommand(sqlS, conn); //Encapsulates SQL statement in an object

                textBoxContent = cmd.ExecuteScalar().ToString(); //Executes the SQL statement and returns the first column of the first row of the result set

                conn.Close(); //Closes the connection to the database
                return textBoxContent;
            }
            catch
            {
                MessageBox.Show(ErrorMessage.errorMessage());
                ErrorMessage.ErrorList.Clear();
                ErrorMessage.resetInjectedSQL();
                textBoxContent = "";
                return textBoxContent;
            }
        }
    }
}
