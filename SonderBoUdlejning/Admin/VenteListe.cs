using System;
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

            /*
             Tjekker om textfelterne er tomme
             derefter tjekker de om det er et tal der bliver skrevet
             Til sidst tjekker den for alt og executer en sql til databasen
            */
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
                catch 
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

            //Kommentar fra Rasmus: indsætning-, aflæsnings- og sletningsmetoden af personer
            //fra ventelisten burde have hver deres class.
            //Overvej at implementere en facade.

            StringBuilder query = new StringBuilder("DELETE FROM Venteliste WHERE ");

            

            //Hvis begge fetler er tomme, så stopper resten af koden
            if (string.IsNullOrEmpty(pId) && string.IsNullOrEmpty(bId))
            {
                MessageBox.Show("Indtast venligst enten et pId eller et bId!");
                return;
            } 
            
            //Hvis pId er indtastet og bId ikke er
            if (!string.IsNullOrEmpty(pId) && int.TryParse(pId, out int pIdTemp)) 
            {
                pIdValid = true;
                query.Append("pId = "+pId);
            }

            //Hvis bId er indtastet og pId ikke er
            if (!string.IsNullOrEmpty(bId) && int.TryParse(bId, out int bIdTemp))
            {
                bIdValid = true;
                query.Append("bId = " + bId);
            }

            //Hvis både pId og bId er indtastet, så create en helt ny sql sætning
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

                //Prompt user med en warningbox inden der bliver slettet
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

        private void GetPosition_Click(object sender, EventArgs e)
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
            else if (int.TryParse(pId, out int pIdTemp2) || int.TryParse(bId, out int bIdTemp2) || !string.IsNullOrEmpty(pId) || !string.IsNullOrEmpty(bId))
            {
                SqlConnection conn = new SqlConnection(UserIdentification.conString);
                conn.Open();

                string query = "SELECT ROW_NUMBER() OVER(ORDER BY signUpDato) AS row_num, signUpDato, bId, pId FROM Venteliste WHERE bId = " + bIdTextbox.Text + "";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                List<int> getNumbersList = new List<int>();
                while (reader.Read())
                {
                    getNumbersList.Add(Convert.ToInt32(reader.GetValue(3)));
                }
                conn.Close();

                int[] positionenArray = getNumbersList.ToArray();

                positionTextBox.Text = Convert.ToString(Array.IndexOf(positionenArray, Convert.ToInt32(pIdTextbox.Text)) + 1);

            }
        }
    }
}
