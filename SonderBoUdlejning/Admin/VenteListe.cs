﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SonderBoUdlejning.Admin
{
    public partial class VenteListe : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        public VenteListe()
        {
            InitializeComponent();
        }

        private void VenteListe_Load(object sender, EventArgs e)
        {
            string sqlS1 = "SELECT * FROM Venteliste ORDER BY signUpDato ASC";
            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);

            string sqlS2 = "SELECT * FROM Person";
            DGVPersoner.DataSource = tableConn.tableBinder(sqlS2);

            string sqlS3 = "SELECT * FROM BoligInfo";
            DGVBoliger.DataSource = tableConn.tableBinder(sqlS3);
        }

        private void InsertToList_Click(object sender, EventArgs e)
        {

            string pId = pIdTextbox.Text;
            string bId = bIdTextbox.Text;

            if (string.IsNullOrEmpty(pId) || string.IsNullOrEmpty(bId))
            {
                MessageBox.Show("Indtast venligst både et person ID og et bolig ID!");
            }
            else if (!int.TryParse(pId, out int pIdTemp) || !int.TryParse(bId, out int bIdTemp))
            {
                MessageBox.Show("Indtast venligst kun tal!");
            }
            else if(int.TryParse(pId, out int pIdTemp2) || int.TryParse(bId, out int bIdTemp2) || !string.IsNullOrEmpty(pId) || !string.IsNullOrEmpty(bId))
            {
                try
                {
                    SqlConnection conn = new SqlConnection(UserIdentification.conString);
                conn.Open();

                    //SQL tjekker for om personen allerede har skrevet sig til en bolig. hvis ikke,
                    //så skriver den personen op.
                string query = "IF NOT EXISTS (SELECT * FROM Venteliste WHERE pId = "+pId+" AND bid = "+bId+") BEGIN INSERT INTO Venteliste(pId, bId, signUpDato) VALUES ("+pId+", "+bId+", getdate()) END";

                SqlCommand cmd = new SqlCommand(query, conn);

                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("Denne person er allerede på ventelisten til denne bolig!");
                    }
                    else 
                    {
                        MessageBox.Show("Personen er blevet tilføjet til ventelisten");
                    }

                string sqlS1 = "SELECT * FROM Venteliste ORDER BY signUpDato ASC";
                DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);

                conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Bolig ID eller person ID findes ikke i databasen!");
                }
            }


            
        }

        private void DeleteFromListButton_Click(object sender, EventArgs e)
        {
            string pId = pIdTextbox.Text;
            string bId = bIdTextbox.Text;

            bool pIdValid = false;
            bool bIdValid = false;

            string q = "DELETE FROM Venteliste WHERE pId = 1 AND bId = 1";

            StringBuilder query = new StringBuilder("DELETE FROM Venteliste WHERE ");

            


            if (string.IsNullOrEmpty(pId) && string.IsNullOrEmpty(bId))
            {
                MessageBox.Show("Indtast venligst enten et pId eller et bId!");
                return;
            } 
            
            if (!string.IsNullOrEmpty(pId) && int.TryParse(pId, out int pIdTemp)) 
            {
                pIdValid = true;
                query.Append("pId = "+pId);
            }

            if (!string.IsNullOrEmpty(bId) && int.TryParse(bId, out int bIdTemp))
            {
                bIdValid = true;
                query.Append("bId = " + bId);
            }

            if (pIdValid && bIdValid)
            {
                query.Clear();
                query.Append("DELETE FROM Venteliste WHERE pId = "+pId+" AND bId = "+bId+"");
            }

            try
            {
                SqlConnection conn = new SqlConnection(UserIdentification.conString);
                conn.Open();

                
          
                SqlCommand cmd = new SqlCommand(query.ToString(), conn);

                DialogResult dialogResult = MessageBox.Show("Er du sikker på du vil slette denne entry på ventelisten?", "Er du sikker?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }
                else if (dialogResult == DialogResult.No)
                {
                    conn.Close();
                    return;
                }

                string sqlS1 = "SELECT * FROM Venteliste ORDER BY signUpDato ASC";
                DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);

                conn.Close();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }


    }
}
