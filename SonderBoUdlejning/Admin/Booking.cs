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
using System.Text.RegularExpressions;

namespace SonderBoUdlejning.Admin
{
    public partial class Booking : Form
    {
        ConnString connString = ConnString.getConnInstance;
        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        string sqlS1 = "SELECT resNr, rTypeNavn, pId, Ressourcer.rId, rType, rStartDato, rSlutDato FROM Ressourcer INNER JOIN Reservationer ON Ressourcer.rId = Reservationer.rId";
        string sqlS2 = "SELECT * FROM Ressourcer WHERE rId NOT IN(SELECT rId FROM Reservationer WHERE GETDATE() BETWEEN rStartDato AND rSlutDato)";

        List<string> listBeboer = new List<string>();
        List<int> listBeboerID = new List<int>();

        List<string> listResource = new List<string>();
        List<int> listResourceID = new List<int>();

        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {


            DGVReservationer.DataSource = tableConn.tableBinder(sqlS1);
            DGVRessourcer.DataSource = tableConn.tableBinder(sqlS2);

            string date = DateTime.Today.ToString("yyyy-MM-dd");
            TBStartDato.Text = date;

            BookingSystems.OnLoadFunctions.GetPeronList(listBeboerID, listBeboer);
            BookingSystems.OnLoadFunctions.GetResourceList(listResourceID, listResource, date);


            foreach (string item in listResource)
            {
                CBResource.Items.Add(item);
            }

            foreach (string item in listBeboer) 
            {
                CBMembers.Items.Add(item);
                cbMembersRes.Items.Add(item);
                cbDeleteResFromBeboer.Items.Add(item);

            }
        }

        private void CBMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] arrayBeboerID = listBeboerID.ToArray(); 
            PanelPersonInfo.Visible = true;
            int personID = arrayBeboerID[CBMembers.SelectedIndex];
            TBPID.Text = personID.ToString();

            string queryTlf = $"SELECT pTlf FROM Person WHERE pId = {personID}";
            string queryMail = $"SELECT pMail FROM Person WHERE pId = {personID}";

            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(queryTlf, conn);
            conn.Open();
            TBTLF.Text = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();

            SqlCommand cmd2 = new SqlCommand(queryMail, conn);
            conn.Open();
            TBMail.Text = Convert.ToString(cmd2.ExecuteScalar());
            conn.Close();

            if (PanelResource.Visible == true)
            {
                btnConfirmBooking.Visible = true;
            }
        }
        

        private void CBResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Denne text box skal slettes. det er bare for at se om den ID er korrekt
            int[] arrayResourceID = listResourceID.ToArray();
            int resourceID = arrayResourceID[CBResource.SelectedIndex];
            TBResourceID.Text = resourceID.ToString();
            PanelResource.Visible = true;

            if (PanelPersonInfo.Visible == true) 
            {
                btnConfirmBooking.Visible = true;
            }
        }

        private void BtnCheckDato_Click(object sender, EventArgs e)
        {
            //Tjekker om den dato man vil leje fra, allerede er i en anden udlejning. 
            //Indput validate dato. er der en funktion i winforms hvor man kan vælge på en kalender og få dato i string format?   
            dtpStart.CustomFormat = "yyyy-MM-dd";
            string sqlS2 = "SELECT*FROM Ressourcer WHERE rId NOT IN(SELECT rId FROM Reservationer WHERE '" + dtpStart.Text + "' BETWEEN rStartDato AND rSlutDato)";
                DGVRessourcer.DataSource = tableConn.tableBinder(sqlS2);

                listResource.Clear();
                listResourceID.Clear();
                CBResource.Items.Clear();
                BookingSystems.OnLoadFunctions.GetResourceList(listResourceID, listResource, dtpStart.Text);
                foreach (string item in listResource)
                {
                    CBResource.Items.Add(item);
                }

                TBResourceID.Text = "";
                TBStartDato.Text = dtpStart.Text;
            dtpStart.CustomFormat = "dd-MM-yyyy";
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
           dtpSlut.CustomFormat = "yyyy-MM-dd";
            DateTime dateToday = Convert.ToDateTime(TBStartDato.Text);
            DateTime dateSlutDato = Convert.ToDateTime(dtpSlut.Text);
                
                if (dateSlutDato >= dateToday)
                {
                    int antalBookings = BookingSystems.CheckSlutDato.CheckSlutDate(dtpSlut.Text, TBResourceID.Text);
                    int antalBookingsBetweenDates = BookingSystems.CheckMellemDatoer.CheckDatesForBookings(TBStartDato.Text, dtpSlut.Text, Convert.ToInt32(TBResourceID.Text));


                    if (antalBookings == 0 && antalBookingsBetweenDates == 0)
                    {

                    //Tjek om kunde allerede har en reservation af den resource type, dere r SQL i tableplus der finder ud af det!
                    //if (0) {udfør booking}
                    //else {"kunde har allerede en booking på denne resource type"}
                    string query = "INSERT INTO Reservationer VALUES("+Convert.ToInt32(TBResourceID.Text)+", "+Convert.ToInt32(TBPID.Text)+",'"+TBStartDato.Text+"','"+ dtpSlut.Text+"')";
                        SqlConnection conn = new SqlConnection(connString.connStr);
                        SqlCommand cmd = new SqlCommand(query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Reservation operttet!");
                        DGVReservationer.DataSource = tableConn.tableBinder(sqlS1);
                    }
                    else 
                    {
                        MessageBox.Show("Ressource kan ikke bookes til denne dato, da den allerede er optaget.");
                    }

                }
                else 
                {
                    MessageBox.Show("Slut dato kan ikke være før start dato");
                }
            dtpSlut.CustomFormat = "dd-MM-yyyy";
        }

        private void btnAntalRes_Click(object sender, EventArgs e)
        {
            string query = "SELECT Person.pId AS PersonID, fNavn AS FuldeNavn, COUNT(resNr) AS AntalReservationer FROM Reservationer LEFT JOIN Person ON Reservationer.pId = Person.pId GROUP BY Person.pId, fNavn;";
            DGVReservationer.DataSource = tableConn.tableBinder(query);
        }

        private void cbMembersRes_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void btnSePersonRes_Click(object sender, EventArgs e)
        {
            try{
                int[] arrayBeboerID = listBeboerID.ToArray();
                int personID = arrayBeboerID[cbMembersRes.SelectedIndex];

                string query = $"SELECT fNavn, resNr, rTypeNavn, rStartDato, rSlutDato FROM Reservationer INNER JOIN Person ON Reservationer.pId = Person.pId INNER JOIN Ressourcer ON Reservationer.rId = Ressourcer.rId WHERE Person.pId = {personID};";
                DGVReservationer.DataSource = tableConn.tableBinder(query);
            }
            catch
            {
                MessageBox.Show("Du skal vælge person for at deres reservationer");
            }
        }

        List<int> beboerResID = new List<int>();
        private void cbDeleteResFromBeboer_SelectedIndexChanged(object sender, EventArgs e)
        {
            beboerResID.Clear();
            tbresResNr.Text = "";
            cbDeleteBeboerResource.Items.Clear();
            cbDeleteBeboerResource.Visible = true;
            label13.Visible = true;
            string query = $"SELECT COUNT(rTypeNavn) FROM Ressourcer INNER JOIN Reservationer ON Ressourcer.rId = Reservationer.rId WHERE pId = {cbDeleteResFromBeboer.SelectedIndex} + 1;";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int antalReservationerPRBeboer = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            string query2 = $"SELECT rTypeNavn FROM Ressourcer INNER JOIN Reservationer ON Ressourcer.rId = Reservationer.rId WHERE pId = {cbDeleteResFromBeboer.SelectedIndex} + 1 ORDER BY rTypeNavn;";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            conn.Open();
            SqlDataReader reader = cmd2.ExecuteReader();
            for (int i = 0; i < antalReservationerPRBeboer; i++)
            {
                while (reader.Read())
                {
                    cbDeleteBeboerResource.Items.Add(reader.GetString(i));
                }
            }
            conn.Close();


            
            string query3 = $"SELECT resNr FROM Ressourcer INNER JOIN Reservationer ON Ressourcer.rId = Reservationer.rId WHERE pId = {cbDeleteResFromBeboer.SelectedIndex} + 1 ORDER BY rTypeNavn;";
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            conn.Open();
            SqlDataReader reader2 = cmd3.ExecuteReader();
            for (int i = 0; i < antalReservationerPRBeboer; i++)
            {
                while (reader2.Read())
                {
                    beboerResID.Add(reader2.GetInt32(i));
                }
            }
            conn.Close();
        }

        private void btnDeleteRes_Click(object sender, EventArgs e)
        {
            int[] listBeboerIDArray = listBeboerID.ToArray();
            if (string.IsNullOrEmpty(tbresResNr.Text))
            {
                MessageBox.Show("Vælg venligst en beboer og en af deres reservationer");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Er du sikker på du vil slette denne reservation?", "Sikker?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int resNr = Convert.ToInt32(tbresResNr.Text);
                    string query = $"DELETE FROM Reservationer WHERE resNr = {resNr};";
                    SqlConnection conn = new SqlConnection(connString.connStr);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    int antalReservationerPRBeboer = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
 
                }
            }
        }

        private void cbDeleteBeboerResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] beboerResIDArray = beboerResID.ToArray();
            tbresResNr.Text = Convert.ToString(beboerResIDArray[cbDeleteBeboerResource.SelectedIndex]);
        }
    }
}
