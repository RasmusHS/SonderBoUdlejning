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
            dgvVenteListe.DataSource = tableConn.tableBinder(sqlS1);

            //Indlæser person dataGridView
            dgvPersoner.DataSource = tableConn.tableBinder(sqlS2);

            //Indlæser boligInfo dataGridView
            dgvLejemaal.DataSource = tableConn.tableBinder(sqlS3);
            
            dgvVenteListe.RowHeadersVisible = false;
            dgvVenteListe.BorderStyle = BorderStyle.FixedSingle;
            dgvVenteListe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVenteListe.RowTemplate.Height = 30;
            dgvVenteListe.RowTemplate.DividerHeight = 1;
            dgvVenteListe.GridColor = Color.Black;
            dgvVenteListe.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
            
            dgvPersoner.RowHeadersVisible = false;
            dgvPersoner.BorderStyle = BorderStyle.FixedSingle;
            dgvPersoner.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPersoner.RowTemplate.Height = 30;
            dgvPersoner.RowTemplate.DividerHeight = 1;
            dgvPersoner.GridColor = Color.Black;
            dgvPersoner.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
            
            dgvLejemaal.RowHeadersVisible = false;
            dgvLejemaal.BorderStyle = BorderStyle.FixedSingle;
            dgvLejemaal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLejemaal.RowTemplate.Height = 30;
            dgvLejemaal.RowTemplate.DividerHeight = 1;
            dgvLejemaal.GridColor = Color.Black;
            dgvLejemaal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
             
            //Skjuler input panel
            panelInputs.Visible = false;

            //Tjekker hvilken slags bruger er logget ind
            if (UserIdentification.UserAccess == 1) //admin
            {
                //Admin har adgang til det hele
                btnVisAddToList.Visible = true;
                btnVisDeleteFromList.Visible = true;
                btnGetPosition.Visible = true;
                btnVisShowList.Visible = true;
            }
            else if (UserIdentification.UserAccess == 2) //secretary
            {
                //Sekretæren har ikke adgang til at slette fra en venteliste
                btnVisAddToList.Visible = true;
                btnVisDeleteFromList.Visible = false;
                btnGetPosition.Visible = true;
                btnVisShowList.Visible = true;
            }
        }

        private void InsertToList_Click(object sender, EventArgs e)
        {
            string pId = tbPId.Text; //Tager input fra person ID textboxen
            string Lid = tbLid.Text; //Tager input fra lejemål Nr textboxen

            VentelisteFacade vAddToList = new VentelisteFacade();

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
                dgvVenteListe.DataSource = tableConn.tableBinder(sqlS1); //Opdaterer venteliste dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }

        private void DeleteFromListButton_Click(object sender, EventArgs e)
        {
            string pId = tbPId.Text; //Tager input fra person ID textboxen
            string Lid = tbLid.Text; //Tager input fra lejemål Nr textboxen

            VentelisteFacade vDeleteFromList = new VentelisteFacade();

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
                dgvVenteListe.DataSource = tableConn.tableBinder(sqlS1); //Opdaterer venteliste dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }

        private void btnGetPosition_Click(object sender, EventArgs e)
        {
            string pId = tbPId.Text; //Tager input fra person ID textboxen
            string Lid = tbLid.Text; //Tager input fra lejemål Nr textboxen

            VentelisteFacade vGetListPos = new VentelisteFacade();

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
                tbPosition.Text = vGetListPos.Position; //Viser resultatet i position textboxen
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }

        private void btnVisVentelisteFor_Click(object sender, EventArgs e)
        {
            string Lid = tbLid.Text; //Tager input fra lejemål Nr textboxen

            //SQL Query, som henter ventelisten for en bestemt lejemål
            string sqlS1 = $"SELECT pId AS 'Person ID', Lid AS 'Lejemålstype ID', signUpDato AS 'Opskrivelsesdato' FROM Venteliste WHERE Lid = {Lid} ORDER BY signUpDato ASC";

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
                dgvVenteListe.DataSource = tableConn.tableBinder(sqlS1); //Viser venteliste for en bestemt lejemål
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

            dgvVenteListe.DataSource = tableConn.tableBinder(sqlS1);

            //labels
            lblPId.Visible = true;
            lblPId.Location = new Point(6, 11); //Base labelpId location

            lblLid.Visible = true;
            lblLid.Location = new Point(6, 74); //Base labelLid location

            lblPosition.Visible = false;

            //textboxes
            tbPId.Visible = true;
            tbPId.Location = new Point(10, 32); //Base pIdTextbox location
            tbPId.Text = "";

            tbLid.Visible = true;
            tbLid.Location = new Point(10, 94); //Base LidTextbox location
            tbLid.Text = "";

            tbPosition.Visible = false;

            //knapper
            btnInsertToList.Visible = true;
            btnInsertToList.Location = new Point(0, 0); //Base btnVisVentelisteFor location
            btnDeleteFromListButton.Visible = false;
            btnShowList.Visible = false;
            btnGetPosition.Visible = false;
        }

        //Knap som viser felter relevant for at fjerne en person fra en venteliste
        private void btnDeleteFromList_Click(object sender, EventArgs e)
        {
            panelInputs.Visible = true;
            panelInputs.Size = new Size(331, 192);

            dgvVenteListe.DataSource = tableConn.tableBinder(sqlS1);
            
            //labels
            lblPId.Visible = true;
            lblPId.Location = new Point(6, 11); //Base labelpId location

            lblLid.Visible = true;
            lblLid.Location = new Point(6, 74); //Base labelLid location

            lblPosition.Visible = false;

            //textboxes
            tbPId.Visible = true;
            tbPId.Location = new Point(10, 32); //Base pIdTextbox location
            tbPId.Text = "";

            tbLid.Visible = true;
            tbLid.Location = new Point(10, 94); //Base LidTextbox location
            tbLid.Text = "";

            tbPosition.Visible = false;

            //knapper
            btnInsertToList.Visible = false;

            btnDeleteFromListButton.Visible = true;
            btnDeleteFromListButton.Location = new Point(0, 0); //Base btnVisVentelisteFor location

            btnShowList.Visible = false;
            btnGetPosition.Visible = false;
        }

        //Knap som viser felter relevant for at finde en persons position på en venteliste
        private void btnGetPos_Click(object sender, EventArgs e)
        {
            panelInputs.Visible = true;
            panelInputs.Size = new Size(331, 192);

            dgvVenteListe.DataSource = tableConn.tableBinder(sqlS1);
            
            //labels
            lblPId.Visible = true;
            lblPId.Location = new Point(6, 11); //Base labelpId location

            lblLid.Visible = true;
            lblLid.Location = new Point(6, 74); //Base labelLid location

            lblPosition.Visible = true;
            lblPosition.Location = new Point(-4, 0);

            //textboxes
            tbPId.Visible = true;
            tbPId.Location = new Point(10, 32); //Base pIdTextbox location
            tbPId.Text = "";

            tbLid.Visible = true;
            tbLid.Location = new Point(10, 94); //Base LidTextbox location
            tbLid.Text = "";

            tbPosition.Visible = true;
            tbPosition.Location = new Point(0, 21);
            tbPosition.Text = "";

            //knapper
            btnInsertToList.Visible = false;
            btnDeleteFromListButton.Visible = false;
            btnShowList.Visible = false;

            btnGetPosition.Visible = true;
            btnGetPosition.Location = new Point(0, 57);
        }

        //Knap som viser felter relevant for at se en venteliste
        private void btnShowList_Click(object sender, EventArgs e)
        {
            panelInputs.Visible = true;
            panelInputs.Size = new Size(331, 192);

            dgvVenteListe.DataSource = tableConn.tableBinder(sqlS1);
            
            //labels
            lblPId.Visible = false;

            lblLid.Visible = true;
            lblLid.Location = new Point(6, 11); //Base labelpId location

            lblPosition.Visible = false;

            //textboxes
            tbPId.Visible = false;

            tbLid.Visible = true;
            tbLid.Location = new Point(10, 32); //Base pIdTextbox location
            tbLid.Text = "";

            tbPosition.Visible = false;

            //knapper
            btnInsertToList.Visible = false;
            btnDeleteFromListButton.Visible = false;

            btnShowList.Visible = true;
            btnShowList.Location = new Point(0, 0); //Base btnVisVentelisteFor location

            btnGetPosition.Visible = false;
        }

        
    }
}
