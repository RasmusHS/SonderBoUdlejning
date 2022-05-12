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
using SonderBoUdlejning.InputCheck;
using SonderBoUdlejning.VentelisteSystems;

namespace SonderBoUdlejning.Admin
{
    public partial class VenteListe : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        string sqlS1 = "SELECT * FROM Venteliste ORDER BY signUpDato ASC";
        string sqlS2 = "SELECT * FROM Person";
        string sqlS3 = "SELECT * FROM BoligInfo";
        public VenteListe()
        {
            InitializeComponent();
        }

        private void VenteListe_Load(object sender, EventArgs e)
        {
            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);

            DGVPersoner.DataSource = tableConn.tableBinder(sqlS2);

            DGVBoliger.DataSource = tableConn.tableBinder(sqlS3);

            panelInputs.Visible = false;

            if (UserIdentification.UserAccess == 1) //admin
            {
                btnAddToList.Visible = true;
                btnDeleteFromList.Visible = true;
                btnGetPosition.Visible = true;
                btnShowList.Visible = true;
            }
            else if (UserIdentification.UserAccess == 2) //secretary
            {
                btnAddToList.Visible = true;
                btnDeleteFromList.Visible = false;
                btnGetPosition.Visible = true;
                btnShowList.Visible = true;
            }
        }

        private void InsertToList_Click(object sender, EventArgs e)
        {

            string pId = pIdTextbox.Text;
            string bId = bIdTextbox.Text;

            vFacade vAddToList = new vFacade();

            if ((!string.IsNullOrEmpty(pId)) && (!string.IsNullOrEmpty(bId)))
            {
                if ((PersonInputCheck.PIdCheck(pId) == true) && (BoligInputCheck.BIdCheck(bId) == true))
                {
                    vAddToList.AddToList(pId, bId);
                    DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);
                }
                else
                {
                    MessageBox.Show(ErrorMessage.errorMessage());
                    ErrorMessage.ErrorList.Clear();
                    ErrorMessage.resetInjectedSQL();
                }
            }
            else
            {
                MessageBox.Show("Indtast venligst både et person ID og et bolig ID!");
            }
        }

        private void DeleteFromListButton_Click(object sender, EventArgs e)
        {
            string pId = pIdTextbox.Text;
            string bId = bIdTextbox.Text;
            
            vFacade vDeleteFromList = new vFacade();

            if ((!string.IsNullOrEmpty(pId)) && (!string.IsNullOrEmpty(bId)))
            {
                if ((PersonInputCheck.PIdCheck(pId) == true) && (BoligInputCheck.BIdCheck(bId) == true))
                {
                    vDeleteFromList.RemoveFromList(pId, bId);
                    DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);
                }
                else
                {
                    MessageBox.Show(ErrorMessage.errorMessage());
                    ErrorMessage.ErrorList.Clear();
                    ErrorMessage.resetInjectedSQL();
                }
            }
            else
            {
                MessageBox.Show("Indtast venligst et pId og et bId!");
            }
        }

        private void GetPosition_Click(object sender, EventArgs e)
        {

            string pId = pIdTextbox.Text;
            string bId = bIdTextbox.Text;

            vFacade vGetListPos = new vFacade();

            if ((!string.IsNullOrEmpty(pId)) && (!string.IsNullOrEmpty(bId)))
            {
                if ((PersonInputCheck.PIdCheck(pId) == true) && (BoligInputCheck.BIdCheck(bId) == true))
                {
                    vGetListPos.GetListPosition(pId, bId);
                    positionTextBox.Text = vGetListPos.Position;
                }
                else
                {
                    MessageBox.Show(ErrorMessage.errorMessage());
                    ErrorMessage.ErrorList.Clear();
                    ErrorMessage.resetInjectedSQL();
                }
            }
            else
            {
                MessageBox.Show("Indtast venligst både et person ID og et bolig ID!");
            }
        }

        private void btnVisVentelisteFor_Click(object sender, EventArgs e)
        {
            string bId = bIdTextbox.Text;
            string sqlS1 = $"SELECT * FROM Venteliste WHERE bId = {bId} ORDER BY signUpDato ASC";

            if (!string.IsNullOrEmpty(bId))
            {
                if (BoligInputCheck.BIdCheck(bId) == true)
                {
                    DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);
                }
                else
                {
                    MessageBox.Show(ErrorMessage.errorMessage());
                    ErrorMessage.ErrorList.Clear();
                    ErrorMessage.resetInjectedSQL();
                }
            }
            else
            {
                MessageBox.Show("Indtast venligst et bId!");
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
