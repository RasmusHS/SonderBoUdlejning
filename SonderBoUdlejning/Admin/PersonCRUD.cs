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
        string sqlS1 = "SELECT * FROM Person";

        public PersonCRUD()
        {
            InitializeComponent();
        }

        private void PersonCRUD_Load(object sender, EventArgs e)
        {
            dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);

            panelContainer.Visible = false;

            if (UserIdentification.UserAccess == 1) //admin
            {
                btnOpret.Visible = true;
                btnOpdater.Visible = true;
                btnRead.Visible = true;
                btnSlet.Visible = true;
            }
            else if (UserIdentification.UserAccess == 2) //secretary
            {
                btnOpret.Visible = true;
                btnRead.Visible = true;
                btnOpdater.Visible = false;
                btnSlet.Visible = false;
            }
        }

        private void btnPersonC_Click(object sender, EventArgs e)
        {
            string navn = tbNavn.Text;
            string mail = tbMail.Text;
            string tlf = tbTlf.Text;

            PersonFacade pCreate = new PersonFacade();

            if ((!string.IsNullOrEmpty(navn)) && (!string.IsNullOrEmpty(mail)) && (!string.IsNullOrEmpty(tlf)))
            {
                if ((PersonInputCheck.NavnCheck(navn) == true) && (PersonInputCheck.MailCheck(mail) == true) && (PersonInputCheck.TlfCheck(tlf) == true))
                {
                    pCreate.CreatePerson(navn, mail, tlf);
                    dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);
                }
                else
                {
                    ErrorMessage.errorMessage();
                }
            } 
        }

        private void btnPersonR_Click(object sender, EventArgs e)
        {
            string columns = "*";
            string pId = "";
            string navn = tbNavn.Text;
            string mail = tbMail.Text;
            string tlf = tbTlf.Text;
            bool medlem = radioBtnMedlem.Checked;
            bool erBeboer = radioBtnBeboer.Checked;
            bool alt = radioBtnAlt.Checked;

            PersonFacade pRead = new PersonFacade();

            if ((PersonInputCheck.NavnCheck(navn) == true) && (PersonInputCheck.MailCheck(mail) == true) && (PersonInputCheck.TlfCheck(tlf) == true))
            {
                pRead.ReadPerson(columns, pId, navn, mail, tlf, medlem, erBeboer, alt);
                dgvPersonCRUD.DataSource = tableConn.tableBinder(pRead.ReadQuery);
            }
            else
            {
                pRead.ReadPerson(columns, pId, navn, mail, tlf, medlem, erBeboer, alt);
                dgvPersonCRUD.DataSource = tableConn.tableBinder(pRead.ReadQuery);
                ErrorMessage.errorMessage();
            }
            
            
        }

        private void btnPersonU_Click(object sender, EventArgs e)
        {
            string navn = tbNavn.Text;
            string mail = tbMail.Text.ToLower();
            string tlf = tbTlf.Text;
            string pId = tbPId.Text;
            bool erBeboer = false;

            PersonFacade pUpdate = new PersonFacade();

            if ((!string.IsNullOrEmpty(navn)) && (!string.IsNullOrEmpty(mail)) && (!string.IsNullOrEmpty(tlf)) && (!string.IsNullOrEmpty(pId)))
            {
                if ((PersonInputCheck.NavnCheck(navn) == true) && (PersonInputCheck.MailCheck(mail) == true) && (PersonInputCheck.TlfCheck(tlf) == true) && (PersonInputCheck.PIdCheck(pId) == true))
                {
                    erBeboer = Convert.ToBoolean(tableConn.textBoxBinder($"SELECT erBeboer FROM Person WHERE pId = {pId}"));
                    //MessageBox.Show("" + erBeboer);
                    pUpdate.UpdatePerson(navn, mail, tlf, pId, erBeboer);
                    dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);
                }
                else
                {
                    ErrorMessage.errorMessage();
                }
            }

        }

        private void btnPersonD_Click(object sender, EventArgs e)
        {
            string tlf = tbTlf.Text;
            
            PersonFacade pDelete = new PersonFacade();

            if ((!string.IsNullOrEmpty(tlf)))
            {
                if ((PersonInputCheck.TlfCheck(tlf) == true))
                {
                    pDelete.DeletePerson(tlf);
                    dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);
                }
                else
                {
                    ErrorMessage.errorMessage();
                }
            }

        }

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
