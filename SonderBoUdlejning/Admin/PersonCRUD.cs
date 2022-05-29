using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SonderBoUdlejning.InputCheck;
using SonderBoUdlejning.personCRUD;

namespace SonderBoUdlejning.Admin
{
    public partial class PersonCRUD : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();

        //Standard SQL Query, som bruges til at vise Person tabellen i dens dataGridView
        string sqlS1 = "SELECT pId AS 'Person ID', fNavn AS 'Fulde Navn', pMail AS 'E-mail', pTlf AS 'Tlf. Nr.', erBeboer AS 'Er Beboer?' FROM Person"; 

        public PersonCRUD()
        {
            InitializeComponent();
        }

        private void PersonCRUD_Load(object sender, EventArgs e)
        {
            //Forbinder dataGridView til tabel
            dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);

            dgvPersonCRUD.RowHeadersVisible = false;
            dgvPersonCRUD.BorderStyle = BorderStyle.FixedSingle;
            dgvPersonCRUD.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPersonCRUD.RowTemplate.Height = 30;
            dgvPersonCRUD.RowTemplate.DividerHeight = 1;
            dgvPersonCRUD.GridColor = Color.Black;
            dgvPersonCRUD.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);

            //gemmer input panelet indtil en knap er trykket
            //panelContainer.Visible = false;
            panelIndhold.Visible = false;

            //Tjekker hvilken slags bruger er logget ind
            if (UserIdentification.UserAccess == 1) //admin
            {
                //Admin har adgang til det hele
                btnOpret.Visible = true;
                btnOpdater.Visible = true;
                btnRead.Visible = true;
                btnSlet.Visible = true;
            }
            else if (UserIdentification.UserAccess == 2) //secretary
            {
                //Sekretæren har kun adgang til at læse
                btnOpret.Visible = true;
                btnRead.Visible = true;
                btnOpdater.Visible = true;
                btnSlet.Visible = false;
            }
        }

        private void btnPersonC_Click(object sender, EventArgs e)
        {
            string navn = tbNavn.Text; //Tager input fra navn textbox
            string mail = tbMail.Text.ToLower(); //Tager input fra mail textbox og sætter store bogstaver til at være små
            string tlf = tbTlf.Text; //Tager input fra tlf textbox

            PersonFacade pCreate = new PersonFacade();

            //Tjekker om en af felterne er tomme
            if ((string.IsNullOrEmpty(navn)) || (string.IsNullOrEmpty(mail)) || (string.IsNullOrEmpty(tlf)))
            {
                MessageBox.Show("Du skal udfylde alle felter");
                return;
            }

            bool navnValid = PersonInputCheck.NavnCheck(navn);
            bool mailValid = PersonInputCheck.MailCheck(mail);
            bool tlfValid = PersonInputCheck.TlfCheck(tlf);

            //Tjekker inputtene for længde og ugyldige tegn
            if ((navnValid == true) && (mailValid == true) && (tlfValid == true))
            {
                pCreate.cPerson(navn, mail, tlf); //Opretter person
                dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1); //Opdaterer dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlbesked
            }
        }

        private void btnPersonR_Click(object sender, EventArgs e)
        {
            string columns = "pId AS 'Person ID', fNavn AS 'Fulde Navn', pMail AS 'E-mail', pTlf AS 'Tlf. Nr.', erBeboer AS 'Er Beboer?'"; //Sætter hvilke kolonner der skal vises
            string pId = ""; //Sætter pId til tomt
            string navn = tbNavn.Text; //Tager input fra navn textbox
            string mail = tbMail.Text.ToLower(); //Tager input fra mail textbox og sætter store bogstaver til at være små
            string tlf = tbTlf.Text; //Tager input fra tlf textbox
            bool medlem = radioBtnMedlem.Checked; //Tjekker om medlem er checked
            bool erBeboer = radioBtnBeboer.Checked; //Tjekker om erBeboer er checked
            bool alt = radioBtnAlt.Checked; //Tjekker om alt er checked

            bool navnValid = true;
            bool mailValid = true;
            bool tlfValid = true;

            try
            {
                navnValid = PersonInputCheck.NavnCheck(navn);
                mailValid = PersonInputCheck.MailCheck(mail);
                tlfValid = PersonInputCheck.TlfCheck(tlf);
            }
            catch
            {
                navnValid = false;
                mailValid = false;
                tlfValid = false;
            }
            
            PersonFacade pRead = new PersonFacade();

            //Tjekker inputtene for længde og ugyldige tegn
            if ((navnValid == true) && (mailValid == true) && (tlfValid == true))
            {
                //Hvis inputtene passerer alle tjek og er gyldige, så opretter vi en ny lejemål
                //Fortæller en facade at den skal kalde en read metode
                pRead.rPerson(columns, pId, navn, mail, tlf, medlem, erBeboer, alt);

                //Viser read metodens resultat i Person dataGridView
                dgvPersonCRUD.DataSource = tableConn.tableBinder(pRead.readPQuery);
            }
            else
            {
                //Person dataGridView er vil se tomt ud hvis fejl eller SQL injection spottes
                dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);
                ErrorMessage.errorMessage(); //Fejlbesked hvis input er ugyldig
            }
            
            
        }

        private void tbPId_TextChanged(object sender, EventArgs e)
        {
            string sqlSUpdateHvem = "";
            string pId = tbPId.Text;
            bool pIdValid = true;

            if (string.IsNullOrEmpty(tbPId.Text))
            {
                btnPersonU.Visible = false;

                lblNavn.Visible = false;
                tbNavn.Visible = false;

                lblMail.Visible = false;
                tbMail.Visible = false;

                lblTlf.Visible = false;
                tbTlf.Visible = false;

                dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);
            }
            else
            {
                btnPersonU.Visible = true;

                lblNavn.Visible = true;
                tbNavn.Visible = true;

                lblMail.Visible = true;
                tbMail.Visible = true;

                lblTlf.Visible = true;
                tbTlf.Visible = true;

                pIdValid = PersonInputCheck.PIdCheck(pId);
                if (pIdValid == false)
                {
                    ErrorMessage.errorMessage(); //Fejlbesked hvis input er ugyldig
                    return;
                }

                sqlSUpdateHvem = $"SELECT pId AS 'Person ID', fNavn AS 'Fulde Navn', pMail AS 'E-mail', pTlf AS 'Tlf. Nr.', erBeboer AS 'Er Beboer?' FROM Person WHERE pId = {pId}";
                dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlSUpdateHvem);
            }
        }

        private void btnPersonU_Click(object sender, EventArgs e)
        {
            string navn = ""; //Tager input fra navn textbox
            string mail = ""; //Tager input fra mail textbox og sætter store bogstaver til at være små
            string tlf = ""; //Tager input fra tlf textbox
            string pId = tbPId.Text; //Tager input fra pId textbox
            bool erBeboer = false; //Sætter erBeboer til false

            PersonFacade pUpdate = new PersonFacade();

            //Tjekker om en af felterne er tomme
            if ((string.IsNullOrEmpty(pId)))
            {
                MessageBox.Show("Du skal udfylde person ID feltet");
                return;
            }

            bool navnValid = true;
            bool mailValid = true;
            bool tlfValid = true;
            bool pIdValid = PersonInputCheck.PIdCheck(pId);

            if (pIdValid == false)
            {
                ErrorMessage.errorMessage(); //Fejlbesked hvis input er ugyldig
                return;
            }

            //Tjekker om der skrevet noget i navn textbox
            if ((string.IsNullOrEmpty(tbNavn.Text)) && (pIdValid == true))
            {
                //Finder hvad der er allerede er i db hvis der ikke er indtastet noget i navn textbox
                navn = tableConn.textBoxBinder($"SELECT fNavn FROM Person WHERE pId = {pId}");
                navnValid = true;
            }
            else //Ellers tager vi det indtastede navn og tjekker det
            {
                navn = tbNavn.Text;
                navnValid = PersonInputCheck.NavnCheck(navn);
            }

            //Tjekker om der skrevet noget i mail textbox
            if ((string.IsNullOrEmpty(tbMail.Text.ToLower())) && (pIdValid == true))
            {
                //Finder hvad der er allerede er i db hvis der ikke er indtastet noget i mail textbox
                mail = tableConn.textBoxBinder($"SELECT pMail FROM Person WHERE pId = {pId}");
                mailValid = true;
            }
            else //Ellers tager vi det indtastede mail og tjekker det
            {
                mail = tbMail.Text.ToLower();
                mailValid = PersonInputCheck.MailCheck(mail);
            }

            //Tjekker om der skrevet noget i tlf textbox
            if ((string.IsNullOrEmpty(tbTlf.Text)) && (pIdValid == true))
            {
                //Finder hvad der er allerede er i db hvis der ikke er indtastet noget i tlf textbox
                tlf = tableConn.textBoxBinder($"SELECT pTlf FROM Person WHERE pId = {pId}");
                tlfValid = true;
            }
            else //Ellers tager vi det indtastede tlf nr. og tjekker det
            {
                tlf = tbTlf.Text;
                tlfValid = PersonInputCheck.TlfCheck(tlf);
            }

            //Tjekker inputtene for længde og ugyldige tegn
            if ((navnValid == true) && (mailValid == true) && (tlfValid == true) && (pIdValid == true))
            {
                //Finder hvad personens status er
                erBeboer = Convert.ToBoolean(tableConn.textBoxBinder($"SELECT erBeboer FROM Person WHERE pId = {pId}"));

                //Opdaterer personen
                pUpdate.uPerson(navn, mail, tlf, pId, erBeboer);
                dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1); //Opdaterer dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Vis fejlbesked
            }

        }

        private void btnPersonD_Click(object sender, EventArgs e)
        {
            string tlf = tbTlf.Text;
            
            PersonFacade pDelete = new PersonFacade();

            //Tjekker om tlf er tom
            if ((string.IsNullOrEmpty(tlf)))
            {
                MessageBox.Show("Du skal udfylde tlf feltet");
                return;
            }

            bool tlfValid = PersonInputCheck.TlfCheck(tlf);

            //Tjekker inputtet for længde og ugyldige tegn
            if ((tlfValid == true))
            {
                pDelete.dPerson(tlf); //Sletter personen
                dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1); //Opdaterer dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Vis fejlbesked
            }

        }

        //Knap som viser felter relevant for oprettelse af en ny person
        private void btnOpretShow_Click(object sender, EventArgs e)
        {
            dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);

            //panelContainer.Visible = true;
            panelIndhold.Visible = true;
            
            btnPersonC.Visible = true;
            btnPersonC.Location = new Point(327, 72);

            btnPersonR.Visible = false;
            btnPersonU.Visible = false;
            btnPersonD.Visible = false;

            panelRadioBtns.Visible = false;
            radioBtnMedlem.Checked = false;
            radioBtnBeboer.Checked = false;
            radioBtnAlt.Checked = false;

            lblPId.Visible = false;
            tbPId.Visible = false;
            tbPId.Text = "";
            
            lblNavn.Visible = true;
            lblNavn.Location = new Point(3, 5); //Base lblPId location

            tbNavn.Visible = true;
            tbNavn.Location = new Point(7, 28); //Base tbPId location
            tbNavn.Text = "";

            lblMail.Visible = true;
            lblMail.Location = new Point(3, 80); //Base lblNavn location

            tbMail.Visible = true;
            tbMail.Location = new Point(7, 103); //Base tbNavn location
            tbMail.Text = "";

            lblTlf.Visible = true;
            lblTlf.Location = new Point(3, 155); //Base lblMail location

            tbTlf.Visible = true;
            tbTlf.Location = new Point(7, 178); //Base tbTlf location
            tbTlf.Text = "";
        }

        //Knap som viser felter relevant for indlæsning af personer
        private void btnReadShow_Click(object sender, EventArgs e)
        {
            dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);

            //panelContainer.Visible = true;
            panelIndhold.Visible = true;

            btnPersonC.Visible = false;

            btnPersonR.Visible = true;
            btnPersonR.Location = new Point(327, 72);

            btnPersonU.Visible = false;
            btnPersonD.Visible = false;

            panelRadioBtns.Visible = true;
            radioBtnMedlem.Checked = false;
            radioBtnBeboer.Checked = false;
            radioBtnAlt.Checked = false;

            lblPId.Visible = false;
            tbPId.Visible = false;
            tbPId.Text = "";

            lblNavn.Visible = true;
            lblNavn.Location = new Point(3, 5); //Base lblPId location

            tbNavn.Visible = true;
            tbNavn.Location = new Point(7, 28); //Base tbPId location
            tbNavn.Text = "";

            lblMail.Visible = true;
            lblMail.Location = new Point(3, 80); //Base lblNavn location

            tbMail.Visible = true;
            tbMail.Location = new Point(7, 103); //Base tbNavn location
            tbMail.Text = "";

            lblTlf.Visible = true;
            lblTlf.Location = new Point(3, 155); //Base lblMail location

            tbTlf.Visible = true;
            tbTlf.Location = new Point(7, 178); //Base tbMail location
            tbTlf.Text = "";
        }

        //Knap som viser felter relevant for opdatering af en person
        private void btnOpdaterShow_Click(object sender, EventArgs e)
        {
            dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);

            //panelContainer.Visible = true;
            panelIndhold.Visible = true;

            btnPersonC.Visible = false;
            btnPersonR.Visible = false;

            btnPersonU.Visible = true;
            btnPersonU.Location = new Point(327, 72);

            btnPersonD.Visible = false;

            panelRadioBtns.Visible = false;
            radioBtnMedlem.Checked = false;
            radioBtnBeboer.Checked = false;
            radioBtnAlt.Checked = false;

            lblPId.Visible = true;
            lblPId.Location = new Point(3, 5); //Base lblPId location

            tbPId.Visible = true;
            tbPId.Location = new Point(7, 28); //Base tbPId location
            tbPId.Text = "";

            lblNavn.Visible = false;
            lblNavn.Location = new Point(3, 80); //Base lblNavn location

            tbNavn.Visible = false;
            tbNavn.Location = new Point(7, 103); //Base tbNavn location
            tbNavn.Text = "";

            lblMail.Visible = false;
            lblMail.Location = new Point(3, 155); //Base lblMail location

            tbMail.Visible = false;
            tbMail.Location = new Point(7, 178); //Base tbMail location
            tbMail.Text = "";

            lblTlf.Visible = false;
            lblTlf.Location = new Point(3, 228); //Base lblTlf location

            tbTlf.Visible = false;
            tbTlf.Location = new Point(7, 251); //Base tbTlf location
            tbTlf.Text = "";
        }

        //Knap som viser felter relevant for sletning af en person
        private void btnSletShow_Click(object sender, EventArgs e)
        {
            dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);

            //panelContainer.Visible = true;
            panelIndhold.Visible = true;

            btnPersonC.Visible = false;
            btnPersonR.Visible = false;
            btnPersonU.Visible = false;

            btnPersonD.Visible = true;
            btnPersonD.Location = new Point(327, 72);

            panelRadioBtns.Visible = false;
            radioBtnMedlem.Checked = false;
            radioBtnBeboer.Checked = false;
            radioBtnAlt.Checked = false;

            lblPId.Visible = false;
            tbPId.Visible = false;

            lblNavn.Visible = false;
            tbNavn.Visible = false;

            lblMail.Visible = false;
            tbMail.Visible = false;
            
            lblTlf.Visible = true;
            lblTlf.Location = new Point(3, 5); //Base lblTlf location

            tbTlf.Visible = true;
            tbTlf.Location = new Point(7, 28); //Base tbTlf location
            tbTlf.Text = "";
        }
    }
}
