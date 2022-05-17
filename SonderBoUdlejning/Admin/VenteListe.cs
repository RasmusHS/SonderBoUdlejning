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
using SonderBoUdlejning.InputCheck;
using SonderBoUdlejning.VentelisteSystems;

namespace SonderBoUdlejning.Admin
{
    public partial class VenteListe : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();

        //Standard SQL Query, som henter ventelisten sorteret efter dato
        string sqlS1 = "SELECT * FROM Venteliste ORDER BY signUpDato ASC";

        //Standard SQL Query, som henter Person tabellen
        string sqlS2 = "SELECT * FROM Person";

        //Standard SQL Query, som henter BoligInfo tabellen
        string sqlS3 = "SELECT * FROM BoligInfo";
        public VenteListe()
        {
            InitializeComponent();
        }

        private void VenteListe_Load(object sender, EventArgs e)
        {
            //Indlæser venteliste dataGridView
            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);

            //Indlæser person dataGridView
            DGVPersoner.DataSource = tableConn.tableBinder(sqlS2);

            //Indlæser boligInfo dataGridView
            DGVBoliger.DataSource = tableConn.tableBinder(sqlS3);

            //Skjuler input panel
            panelInputs.Visible = false;

            //Tjekker hvilken slags bruger er logget ind
            if (UserIdentification.UserAccess == 1) //admin
            {
                //Admin har adgang til det hele
                btnAddToList.Visible = true;
                btnDeleteFromList.Visible = true;
                btnGetPosition.Visible = true;
                btnShowList.Visible = true;
            }
            else if (UserIdentification.UserAccess == 2) //secretary
            {
                //Sekretæren har ikke adgang til at slette fra en venteliste
                btnAddToList.Visible = true;
                btnDeleteFromList.Visible = false;
                btnGetPosition.Visible = true;
                btnShowList.Visible = true;
            }
        }

        private void InsertToList_Click(object sender, EventArgs e)
        {
            string pId = pIdTextbox.Text; //Tager input fra person ID textboxen
            string bId = bIdTextbox.Text; //Tager input fra bolig ID textboxen

            vFacade vAddToList = new vFacade();

            //Tjekker om person ID eller bolig ID er tomme
            if ((string.IsNullOrEmpty(pId)) || (string.IsNullOrEmpty(bId)))
            {
                MessageBox.Show("Indtast venligst både et person ID og et bolig ID!");
                return;
            }

            //Tjekker om person ID og bolig ID er gyldige
            if ((PersonInputCheck.PIdCheck(pId) == true) && (BoligInputCheck.BIdCheck(bId) == true))
            {
                vAddToList.AddToList(pId, bId); //Tilføjer person til venteliste for en bolig
                DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1); //Opdaterer venteliste dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }

        private void DeleteFromListButton_Click(object sender, EventArgs e)
        {
            string pId = pIdTextbox.Text; //Tager input fra person ID textboxen
            string bId = bIdTextbox.Text; //Tager input fra bolig ID textboxen

            vFacade vDeleteFromList = new vFacade();

            //Tjekker om person ID eller bolig ID er tomme
            if ((string.IsNullOrEmpty(pId)) || (string.IsNullOrEmpty(bId)))
            {
                MessageBox.Show("Indtast venligst et pId og et bId!");
                return;
            }

            //Tjekker om person ID og bolig ID er gyldige
            if ((PersonInputCheck.PIdCheck(pId) == true) && (BoligInputCheck.BIdCheck(bId) == true))
            {
                vDeleteFromList.RemoveFromList(pId, bId); //Sletter en person fra en venteliste
                DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1); //Opdaterer venteliste dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }

        private void GetPosition_Click(object sender, EventArgs e)
        {

            string pId = pIdTextbox.Text; //Tager input fra person ID textboxen
            string bId = bIdTextbox.Text; //Tager input fra bolig ID textboxen

            vFacade vGetListPos = new vFacade();

            //Tjekker om person ID eller bolig ID er tomme
            if ((string.IsNullOrEmpty(pId)) || (string.IsNullOrEmpty(bId)))
            {
                MessageBox.Show("Indtast venligst både et person ID og et bolig ID!");
                return;
                
            }

            //Tjekker om person ID og bolig ID er gyldige
            if ((PersonInputCheck.PIdCheck(pId) == true) && (BoligInputCheck.BIdCheck(bId) == true))
            {
                vGetListPos.GetListPosition(pId, bId); //Finder en persons position på en venteliste
                positionTextBox.Text = vGetListPos.Position; //Viser resultatet i position textboxen
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }

        private void btnVisVentelisteFor_Click(object sender, EventArgs e)
        {
            string bId = bIdTextbox.Text; //Tager input fra bolig ID textboxen

            //SQL Query, som henter ventelisten for en bestemt bolig
            string sqlS1 = $"SELECT * FROM Venteliste WHERE bId = {bId} ORDER BY signUpDato ASC";

            //Tjekker om bolig ID er tom
            if (string.IsNullOrEmpty(bId))
            {
                MessageBox.Show("Indtast venligst et bolig ID!");
                return;
                
            }

            //Tjekker om bolig ID er gyldig
            if (BoligInputCheck.BIdCheck(bId) == true)
            {
                DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1); //Viser venteliste for en bestemt bolig
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }
        
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            panelInputs.Visible = true;

            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);

            //labels
            labelpId.Visible = true;
            labelbId.Visible = true;
            labelPosition.Visible = false;

            //textboxes
            pIdTextbox.Visible = true;
            bIdTextbox.Visible = true;
            positionTextBox.Visible = false;

            //knapper
            InsertToList.Visible = true;
            DeleteFromListButton.Visible = false;
            btnVisVentelisteFor.Visible = false;
            GetPosition.Visible = false;
        }

        private void btnDeleteFromList_Click(object sender, EventArgs e)
        {
            panelInputs.Visible = true;

            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);
            
            //labels
            labelpId.Visible = true;
            labelbId.Visible = true;
            labelPosition.Visible = false;

            //textboxes
            pIdTextbox.Visible = true;
            bIdTextbox.Visible = true;
            positionTextBox.Visible = false;

            //knapper
            InsertToList.Visible = false;
            DeleteFromListButton.Visible = true;
            btnVisVentelisteFor.Visible = false;
            GetPosition.Visible = false;
        }

        private void btnGetPosition_Click(object sender, EventArgs e)
        {
            panelInputs.Visible = true;

            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);
            
            //labels
            labelpId.Visible = true;
            labelbId.Visible = true;
            labelPosition.Visible = true;

            //textboxes
            pIdTextbox.Visible = true;
            bIdTextbox.Visible = true;
            positionTextBox.Visible = true;

            //knapper
            InsertToList.Visible = false;
            DeleteFromListButton.Visible = false;
            btnVisVentelisteFor.Visible = false;
            GetPosition.Visible = true;
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            panelInputs.Visible = true;

            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);
            
            //labels
            labelpId.Visible = false;
            labelbId.Visible = true;
            labelPosition.Visible = false;

            //textboxes
            pIdTextbox.Visible = false;
            bIdTextbox.Visible = true;
            positionTextBox.Visible = false;

            //knapper
            InsertToList.Visible = false;
            DeleteFromListButton.Visible = false;
            btnVisVentelisteFor.Visible = true;
            GetPosition.Visible = false;
        }

        
    }
}
