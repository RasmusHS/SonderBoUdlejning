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

namespace SonderBoUdlejning.Secretary
{
    public partial class PersonCRUD : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        string sqlS1 = "SELECT * FROM Person"; //Standard SQL Query, som bruges til at vise Person tabellen i dens dataGridView

        public PersonCRUD()
        {
            InitializeComponent();
        }

        private void PersonCRUD_Load(object sender, EventArgs e)
        {
            //Forbinder dataGridView til tabel
            dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);

            //gemmer input panelet indtil en knap er trykket
            panelContainer.Visible = false;

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
                btnOpdater.Visible = false;
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
                pCreate.CreatePerson(navn, mail, tlf); //Opretter person
                dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1); //Opdaterer dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlbesked
            }
        }

        private void btnPersonR_Click(object sender, EventArgs e)
        {
            string columns = "*"; //Sætter hvilke kolonner der skal vises
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
                pRead.ReadPerson(columns, pId, navn, mail, tlf, medlem, erBeboer, alt);

                //Viser read metodens resultat i Person dataGridView
                dgvPersonCRUD.DataSource = tableConn.tableBinder(pRead.ReadQuery);
            }
            else
            {
                //Person dataGridView er vil se tomt ud hvis fejl eller SQL injection spottes
                dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);
                ErrorMessage.errorMessage(); //Fejlbesked hvis input er ugyldig
            }
            
            
        }

        private void btnPersonU_Click(object sender, EventArgs e)
        {
            string navn = tbNavn.Text; //Tager input fra navn textbox
            string mail = tbMail.Text.ToLower(); //Tager input fra mail textbox og sætter store bogstaver til at være små
            string tlf = tbTlf.Text; //Tager input fra tlf textbox
            string pId = tbPId.Text; //Tager input fra pId textbox
            bool erBeboer = false; //Sætter erBeboer til false

            PersonFacade pUpdate = new PersonFacade();

            //Tjekker om en af felterne er tomme
            if ((string.IsNullOrEmpty(navn)) || (string.IsNullOrEmpty(mail)) || (string.IsNullOrEmpty(tlf)) || (string.IsNullOrEmpty(pId)))
            {
                MessageBox.Show("Du skal udfylde alle felter");
                return;
            }

            bool navnValid = PersonInputCheck.NavnCheck(navn);
            bool mailValid = PersonInputCheck.MailCheck(mail);
            bool tlfValid = PersonInputCheck.TlfCheck(tlf);
            bool pIdValid = PersonInputCheck.PIdCheck(pId);

            //Tjekker inputtene for længde og ugyldige tegn
            if ((navnValid == true) && (mailValid == true) && (tlfValid == true) && (pIdValid == true))
            {
                //Finder hvad personens status er
                erBeboer = Convert.ToBoolean(tableConn.textBoxBinder($"SELECT erBeboer FROM Person WHERE pId = {pId}"));

                //Opdaterer personen
                pUpdate.UpdatePerson(navn, mail, tlf, pId, erBeboer);
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
                pDelete.DeletePerson(tlf); //Sletter personen
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
            panelContainer.Visible = true;
            
            btnPersonC.Visible = true;
            btnPersonR.Visible = false;
            btnPersonU.Visible = false;
            btnPersonD.Visible = false;

            panelRadioBtns.Visible = false;
            
            lblPId.Visible = false;
            tbPId.Visible = false;
            
            lblNavn.Visible = true;
            tbNavn.Visible = true;
            lblMail.Visible = true;
            tbMail.Visible = true;
            lblTlf.Visible = true;
            tbTlf.Visible = true;
        }

        //Knap som viser felter relevant for indlæsning af personer
        private void btnReadShow_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            btnPersonC.Visible = false;
            btnPersonR.Visible = true;
            btnPersonU.Visible = false;
            btnPersonD.Visible = false;

            panelRadioBtns.Visible = true;
            
            lblPId.Visible = false;
            tbPId.Visible = false;

            lblNavn.Visible = true;
            tbNavn.Visible = true;
            lblMail.Visible = true;
            tbMail.Visible = true;
            lblTlf.Visible = true;
            tbTlf.Visible = true;
        }

        //Knap som viser felter relevant for opdatering af en person
        private void btnOpdaterShow_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            btnPersonC.Visible = false;
            btnPersonR.Visible = false;
            btnPersonU.Visible = true;
            btnPersonD.Visible = false;

            panelRadioBtns.Visible = false;

            lblPId.Visible = true;
            tbPId.Visible = true;

            lblNavn.Visible = true;
            tbNavn.Visible = true;
            lblMail.Visible = true;
            tbMail.Visible = true;

            lblTlf.Visible = true;
            tbTlf.Visible = true;
        }

        //Knap som viser felter relevant for sletning af en person
        private void btnSletShow_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;
            
            btnPersonC.Visible = false;
            btnPersonR.Visible = false;
            btnPersonU.Visible = false;
            btnPersonD.Visible = true;
            
            panelRadioBtns.Visible = false;
           
            lblPId.Visible = false;
            tbPId.Visible = false;

            lblNavn.Visible = false;
            tbNavn.Visible = false;
            lblMail.Visible = false;
            tbMail.Visible = false;
            
            lblTlf.Visible = true;
            tbTlf.Visible = true;
        }
    }
}
