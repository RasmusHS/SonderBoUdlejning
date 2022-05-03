using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SonderBoUdlejning.SQLBuilders;

namespace SonderBoUdlejning.Secretary
{
    public partial class PersonCRUD : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();

        public PersonCRUD()
        {
            InitializeComponent();
        }

        private void PersonCRUD_Load(object sender, EventArgs e)
        {
            string sqlS1 = "SELECT * FROM Person";
            dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);
        }

        private void btnPersonC_Click(object sender, EventArgs e)
        {
            pSQLRunner pRunner = new pSQLRunner();
            
            pRunner.Create = true;
            pRunner.Read = false;
            pRunner.Update = false;
            pRunner.Delete = false;

            //Input checkes for igennem Regex
            pRunner.PId = tbPId.Text;
            pRunner.Navn = tbNavn.Text;
            pRunner.Mail = tbMail.Text;
            pRunner.Tlf = tbTlf.Text;
            pRunner.Medlem = radioBtnMedlem.Checked;
            pRunner.ErBeboer = radioBtnBeboer.Checked;
            pRunner.Alt = radioBtnAlt.Checked;

            //Input sendes videre for blive parameteriseret og kørt
            if ((!string.IsNullOrEmpty(pRunner.Navn)) && (!string.IsNullOrEmpty(pRunner.Mail)) && (!string.IsNullOrEmpty(pRunner.Tlf)))
            {
                pRunner.pSQLC(pRunner.Navn, pRunner.Mail, pRunner.Tlf);
                string sqlS1 = "SELECT * FROM Person";
                dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);
            }
            else
            {
                string displayError = string.Join(Environment.NewLine, pRunner.errorMessage());
                MessageBox.Show("Alle felter skal udfyldes.\nAntal fejl fundet:  /*+ pRunner.pErrorList.Count.ToString() +*/ \n" + displayError);
            }
        }

        private void btnPersonR_Click(object sender, EventArgs e)
        {
            pSQLRunner pRunner = new pSQLRunner();

            pRunner.Create = false;
            pRunner.Read = true;
            pRunner.Update = false;
            pRunner.Delete = false;

            //Input checkes for igennem Regex
            pRunner.Navn = tbNavn.Text;
            pRunner.Mail = tbMail.Text;
            pRunner.Tlf = tbTlf.Text;
            pRunner.Medlem = radioBtnMedlem.Checked;
            pRunner.ErBeboer = radioBtnBeboer.Checked;
            pRunner.Alt = radioBtnAlt.Checked;

            //Input sendes videre for blive parameteriseret og kørt
            dgvPersonCRUD.DataSource = tableConn.tableBinder(pRunner.pSQLR(pRunner.Navn, pRunner.Mail, pRunner.Tlf, pRunner.Medlem, pRunner.ErBeboer, pRunner.Alt));
        }

        private void btnPersonU_Click(object sender, EventArgs e)
        {
            pSQLRunner pRunner = new pSQLRunner();
            
            pRunner.Create = false;
            pRunner.Read = false;
            pRunner.Update = true;
            pRunner.Delete = false;

            //Input checkes for igennem Regex
            pRunner.Navn = tbNavn.Text;
            pRunner.Mail = tbMail.Text;
            pRunner.Tlf = tbTlf.Text;
            pRunner.PId = tbPId.Text;
            pRunner.Medlem = radioBtnMedlem.Checked;
            pRunner.ErBeboer = radioBtnBeboer.Checked;
            pRunner.Alt = radioBtnAlt.Checked;

            //Input sendes videre for blive parameteriseret og kørt
            if ((!string.IsNullOrEmpty(pRunner.Navn)) && (!string.IsNullOrEmpty(pRunner.Mail)) && (!string.IsNullOrEmpty(pRunner.Tlf)) && (!string.IsNullOrEmpty(pRunner.PId)))
            {
                pRunner.pSQLU(pRunner.Navn, pRunner.Mail, pRunner.Tlf, pRunner.PId);
                string sqlS1 = "SELECT * FROM Person";
                dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);
            }
            else
            {
                string displayError = string.Join(Environment.NewLine, pRunner.errorMessage());
                MessageBox.Show("Alle felter skal udfyldes.\nAntal fejl fundet:  /*+ pRunner.pErrorList.Count.ToString() +*/ \n" + displayError);
            }            
        }

        private void btnPersonD_Click(object sender, EventArgs e)
        {
            pSQLRunner pRunner = new pSQLRunner();
            
            pRunner.Create = false;
            pRunner.Read = false;
            pRunner.Update = false;
            pRunner.Delete = true;

            //Input checkes for igennem Regex
            pRunner.Navn = tbNavn.Text;
            pRunner.Mail = tbMail.Text;
            pRunner.Tlf = tbTlf.Text;
            pRunner.Medlem = radioBtnMedlem.Checked;
            pRunner.ErBeboer = radioBtnBeboer.Checked;
            pRunner.Alt = radioBtnAlt.Checked;

            //Input sendes videre for blive parameteriseret og kørt
            if ((!string.IsNullOrEmpty(pRunner.Tlf)))
            {
                pRunner.pSQLD(pRunner.Tlf);
                string sqlS1 = "SELECT * FROM Person";
                dgvPersonCRUD.DataSource = tableConn.tableBinder(sqlS1);
            }
            else
            {
                string displayError = string.Join(Environment.NewLine, pRunner.errorMessage());
                MessageBox.Show("Alle felter skal udfyldes.\nAntal fejl fundet:  /*+ pRunner.pErrorList.Count.ToString() +*/ \n" + displayError);
            }
        }
    }
}
