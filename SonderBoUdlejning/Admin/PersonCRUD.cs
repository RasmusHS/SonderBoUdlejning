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
                    MessageBox.Show(ErrorMessage.errorMessage());
                    ErrorMessage.ErrorList.Clear();
                    ErrorMessage.resetInjectedSQL();
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
                ErrorMessage.ErrorList.Clear();
                ErrorMessage.resetInjectedSQL();
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
                    MessageBox.Show("" + erBeboer);
                    pUpdate.UpdatePerson(navn, mail, tlf, pId, erBeboer);
                    dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);
                }
                else
                {
                    MessageBox.Show(ErrorMessage.errorMessage());
                    ErrorMessage.ErrorList.Clear();
                    ErrorMessage.resetInjectedSQL();
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
                    MessageBox.Show(ErrorMessage.errorMessage());
                    ErrorMessage.ErrorList.Clear();
                    ErrorMessage.resetInjectedSQL();
                }
            }

        }
    }
}
