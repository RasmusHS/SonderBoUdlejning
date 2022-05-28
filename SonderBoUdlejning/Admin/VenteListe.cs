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

        //Standard SQL Query, som henter ventelisten sorteret efter dato
        string sqlS1 = "SELECT pId AS 'Person ID', Lid AS 'Lejemålstype ID', signUpDato AS 'Opskrivelsesdato' FROM Venteliste ORDER BY signUpDato ASC";

        //Standard SQL Query, som henter Person tabellen
        string sqlS2 = "SELECT pId AS 'Person ID', fNavn AS 'Fulde Navn', pMail AS 'E-mail', pTlf AS 'Tlf. Nr.', erBeboer AS 'Er Beboer?' FROM Person";

        //Standard SQL Query, som henter LejemaalsInfo tabellen
        string sqlS3 = "SELECT Lid AS 'Lejemålstype ID', lType AS 'Lejemålstype Navn', antalRum AS 'Antal værelser', kvm AS 'Kvm', lejePris AS 'Månedlig Leje' FROM LejemaalsInfo";
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
            DGVLejemaal.DataSource = tableConn.tableBinder(sqlS3);
            
            DGVVenteListe.RowHeadersVisible = false;
            DGVVenteListe.BorderStyle = BorderStyle.FixedSingle;
            DGVVenteListe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVVenteListe.RowTemplate.Height = 30;
            DGVVenteListe.RowTemplate.DividerHeight = 1;
            DGVVenteListe.GridColor = Color.Black;
            DGVVenteListe.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
            
            DGVPersoner.RowHeadersVisible = false;
            DGVPersoner.BorderStyle = BorderStyle.FixedSingle;
            DGVPersoner.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVPersoner.RowTemplate.Height = 30;
            DGVPersoner.RowTemplate.DividerHeight = 1;
            DGVPersoner.GridColor = Color.Black;
            DGVPersoner.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
            
            DGVLejemaal.RowHeadersVisible = false;
            DGVLejemaal.BorderStyle = BorderStyle.FixedSingle;
            DGVLejemaal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVLejemaal.RowTemplate.Height = 30;
            DGVLejemaal.RowTemplate.DividerHeight = 1;
            DGVLejemaal.GridColor = Color.Black;
            DGVLejemaal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
             
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
            string Lid = LidTextbox.Text; //Tager input fra lejemål Nr textboxen

            vFacade vAddToList = new vFacade();

            //Tjekker om person ID eller lejemål Nr er tomme
            if ((string.IsNullOrEmpty(pId)) || (string.IsNullOrEmpty(Lid)))
            {
                MessageBox.Show("Indtast venligst både et person ID og et lejemål Nr!");
                return;
            }

            bool pIdValid = PersonInputCheck.PIdCheck(pId);
            bool LidValid = LejemaalInputCheck.LidCheck(Lid);

            //Tjekker om person ID og lejemål Nr er gyldige
            if ((pIdValid == true) && (LidValid == true))
            {
                vAddToList.AddToList(pId, Lid); //Tilføjer person til venteliste for en lejemål
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
            string Lid = LidTextbox.Text; //Tager input fra lejemål Nr textboxen

            vFacade vDeleteFromList = new vFacade();

            //Tjekker om person ID eller lejemål Nr er tomme
            if ((string.IsNullOrEmpty(pId)) || (string.IsNullOrEmpty(Lid)))
            {
                MessageBox.Show("Indtast venligst et person ID og et lejemål Nr.!");
                return;
            }

            bool pIdValid = PersonInputCheck.PIdCheck(pId);
            bool LidValid = LejemaalInputCheck.LidCheck(Lid);

            //Tjekker om person ID og lejemål Nr er gyldige
            if ((pIdValid == true) && (LidValid == true))
            {
                vDeleteFromList.RemoveFromList(pId, Lid); //Sletter en person fra en venteliste
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
            string Lid = LidTextbox.Text; //Tager input fra lejemål Nr textboxen

            vFacade vGetListPos = new vFacade();

            //Tjekker om person ID eller lejemål Nr er tomme
            if ((string.IsNullOrEmpty(pId)) || (string.IsNullOrEmpty(Lid)))
            {
                MessageBox.Show("Indtast venligst både et person ID og et lejemål Nr!");
                return;
                
            }

            bool pIdValid = PersonInputCheck.PIdCheck(pId);
            bool LidValid = LejemaalInputCheck.LidCheck(Lid);

            //Tjekker om person ID og lejemål Nr er gyldige
            if ((pIdValid == true) && (LidValid == true))
            {
                vGetListPos.GetListPosition(pId, Lid); //Finder en persons position på en venteliste
                positionTextBox.Text = vGetListPos.Position; //Viser resultatet i position textboxen
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }

        private void btnVisVentelisteFor_Click(object sender, EventArgs e)
        {
            string Lid = LidTextbox.Text; //Tager input fra lejemål Nr textboxen

            //SQL Query, som henter ventelisten for en bestemt lejemål
            string sqlS1 = $"SELECT * FROM Venteliste WHERE Lid = {Lid} ORDER BY signUpDato ASC";

            //Tjekker om lejemål Nr er tom
            if (string.IsNullOrEmpty(Lid))
            {
                MessageBox.Show("Indtast venligst et lejemål Nr!");
                return;
                
            }

            bool LidValid = LejemaalInputCheck.LidCheck(Lid);

            //Tjekker om lejemål Nr er gyldig
            if (LidValid == true)
            {
                DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1); //Viser venteliste for en bestemt lejemål
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }

        //Knap som viser felter relevant for at tilføje en person til en venteliste
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            panelInputs.Visible = true;
            panelInputs.Size = new Size(331, 192);

            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);

            //labels
            labelpId.Visible = true;
            labelpId.Location = new Point(6, 11); //Base labelpId location

            labelLid.Visible = true;
            labelLid.Location = new Point(6, 74); //Base labelLid location

            labelPosition.Visible = false;

            //textboxes
            pIdTextbox.Visible = true;
            pIdTextbox.Location = new Point(10, 32); //Base pIdTextbox location
            pIdTextbox.Text = "";

            LidTextbox.Visible = true;
            LidTextbox.Location = new Point(10, 94); //Base LidTextbox location
            LidTextbox.Text = "";

            positionTextBox.Visible = false;

            //knapper
            InsertToList.Visible = true;
            InsertToList.Location = new Point(0, 0); //Base btnVisVentelisteFor location
            DeleteFromListButton.Visible = false;
            btnVisVentelisteFor.Visible = false;
            GetPosition.Visible = false;
        }

        //Knap som viser felter relevant for at fjerne en person fra en venteliste
        private void btnDeleteFromList_Click(object sender, EventArgs e)
        {
            panelInputs.Visible = true;
            panelInputs.Size = new Size(331, 192);

            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);
            
            //labels
            labelpId.Visible = true;
            labelpId.Location = new Point(6, 11); //Base labelpId location

            labelLid.Visible = true;
            labelLid.Location = new Point(6, 74); //Base labelLid location

            labelPosition.Visible = false;

            //textboxes
            pIdTextbox.Visible = true;
            pIdTextbox.Location = new Point(10, 32); //Base pIdTextbox location
            pIdTextbox.Text = "";

            LidTextbox.Visible = true;
            LidTextbox.Location = new Point(10, 94); //Base LidTextbox location
            LidTextbox.Text = "";

            positionTextBox.Visible = false;

            //knapper
            InsertToList.Visible = false;

            DeleteFromListButton.Visible = true;
            DeleteFromListButton.Location = new Point(0, 0); //Base btnVisVentelisteFor location

            btnVisVentelisteFor.Visible = false;
            GetPosition.Visible = false;
        }

        //Knap som viser felter relevant for at finde en persons position på en venteliste
        private void btnGetPosition_Click(object sender, EventArgs e)
        {
            panelInputs.Visible = true;
            panelInputs.Size = new Size(331, 192);

            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);
            
            //labels
            labelpId.Visible = true;
            labelpId.Location = new Point(6, 11); //Base labelpId location

            labelLid.Visible = true;
            labelLid.Location = new Point(6, 74); //Base labelLid location

            labelPosition.Visible = true;
            labelPosition.Location = new Point(-4, 0);

            //textboxes
            pIdTextbox.Visible = true;
            pIdTextbox.Location = new Point(10, 32); //Base pIdTextbox location
            pIdTextbox.Text = "";

            LidTextbox.Visible = true;
            LidTextbox.Location = new Point(10, 94); //Base LidTextbox location
            LidTextbox.Text = "";

            positionTextBox.Visible = true;
            positionTextBox.Location = new Point(0, 21);
            positionTextBox.Text = "";

            //knapper
            InsertToList.Visible = false;
            DeleteFromListButton.Visible = false;
            btnVisVentelisteFor.Visible = false;

            GetPosition.Visible = true;
            GetPosition.Location = new Point(0, 57);
        }

        //Knap som viser felter relevant for at se en venteliste
        private void btnShowList_Click(object sender, EventArgs e)
        {
            panelInputs.Visible = true;
            panelInputs.Size = new Size(331, 192);

            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);
            
            //labels
            labelpId.Visible = false;

            labelLid.Visible = true;
            labelLid.Location = new Point(6, 11); //Base labelpId location

            labelPosition.Visible = false;

            //textboxes
            pIdTextbox.Visible = false;

            LidTextbox.Visible = true;
            LidTextbox.Location = new Point(10, 32); //Base pIdTextbox location
            LidTextbox.Text = "";

            positionTextBox.Visible = false;

            //knapper
            InsertToList.Visible = false;
            DeleteFromListButton.Visible = false;

            btnVisVentelisteFor.Visible = true;
            btnVisVentelisteFor.Location = new Point(0, 0); //Base btnVisVentelisteFor location

            GetPosition.Visible = false;
        }
    }
}
