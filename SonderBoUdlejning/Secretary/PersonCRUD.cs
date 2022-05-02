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
        personSQLBuilder personSQL = new personSQLBuilder();
        pSQLRunner pRunner = new pSQLRunner();

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
            personSQL.Create = true;
            personSQL.Read = false;
            personSQL.Update = false;
            personSQL.Delete = false;            

            //Input checkes for igennem Regex
            personSQL.Navn = tbNavn.Text;
            personSQL.Mail = tbMail.Text;
            personSQL.Tlf = tbTlf.Text;
            personSQL.Medlem = radioBtnMedlem.Checked;
            personSQL.ErBeboer = radioBtnBeboer.Checked;
            personSQL.Alt = radioBtnAlt.Checked;

            //Input sendes videre for blive parameteriseret og kørt
            MessageBox.Show(personSQL.Navn);
            if ((!string.IsNullOrEmpty(personSQL.Navn)) && (!string.IsNullOrEmpty(personSQL.Mail)) && (!string.IsNullOrEmpty(personSQL.Tlf)))
            {
                pRunner.pSQLC(personSQL.Navn, personSQL.Mail, personSQL.Tlf);
            }
            else
            {
                string displayError = string.Join(Environment.NewLine, personSQL.pErrorList);
                MessageBox.Show("Alle felter skal udfyldes.\nAntal fejl fundet: " + personSQL.pErrorList.Count.ToString() + "\n" + displayError);
            }

            //MessageBox.Show(personSQL.SQLBuilder());

            //dgvPersonCRUD.DataSource = tableConn.CUD(personSQL.SQLBuilder());
        }

        private void btnPersonR_Click(object sender, EventArgs e)
        {
            personSQL.Create = false;
            personSQL.Read = true;
            personSQL.Update = false;
            personSQL.Delete = false;

            //Input checkes for igennem Regex
            personSQL.Navn = tbNavn.Text;
            personSQL.Mail = tbMail.Text;
            personSQL.Tlf = tbTlf.Text;
            personSQL.Medlem = radioBtnMedlem.Checked;
            personSQL.ErBeboer = radioBtnBeboer.Checked;
            personSQL.Alt = radioBtnAlt.Checked;

            //Input sendes videre for blive parameteriseret og kørt
            MessageBox.Show(personSQL.Navn);
            
            pRunner.pSQLR();
            
            //MessageBox.Show(personSQL.SQLBuilder());

            //dgvPersonCRUD.DataSource = tableConn.tableBinder(personSQL.SQLBuilder());
        }

        private void btnPersonU_Click(object sender, EventArgs e)
        {
            personSQL.Create = false;
            personSQL.Read = false;
            personSQL.Update = true;
            personSQL.Delete = false;

            //Input checkes for igennem Regex
            personSQL.Navn = tbNavn.Text;
            personSQL.Mail = tbMail.Text;
            personSQL.Tlf = tbTlf.Text;
            personSQL.PId = tbPId.Text;
            personSQL.Medlem = radioBtnMedlem.Checked;
            personSQL.ErBeboer = radioBtnBeboer.Checked;
            personSQL.Alt = radioBtnAlt.Checked;

            //Input sendes videre for blive parameteriseret og kørt
            MessageBox.Show(personSQL.Navn);
            if ((!string.IsNullOrEmpty(personSQL.Navn)) && (!string.IsNullOrEmpty(personSQL.Mail)) && (!string.IsNullOrEmpty(personSQL.Tlf)) && (!string.IsNullOrEmpty(personSQL.PId)))
            {
                pRunner.pSQLU(personSQL.Navn, personSQL.Mail, personSQL.Tlf, personSQL.PId);
            }
            else
            {
                string displayError = string.Join(Environment.NewLine, personSQL.pErrorList);
                MessageBox.Show("Alle felter skal udfyldes.\nAntal fejl fundet: " + personSQL.pErrorList.Count.ToString() + "\n" + displayError);
            }

            //MessageBox.Show(personSQL.SQLBuilder());

            //dgvPersonCRUD.DataSource = tableConn.tableBinder(personSQL.SQLBuilder());            
        }

        private void btnPersonD_Click(object sender, EventArgs e)
        {
            personSQL.Create = false;
            personSQL.Read = false;
            personSQL.Update = false;
            personSQL.Delete = true;

            personSQL.Navn = tbNavn.Text;
            personSQL.Mail = tbMail.Text;
            personSQL.Tlf = tbTlf.Text;
            personSQL.Medlem = radioBtnMedlem.Checked;
            personSQL.ErBeboer = radioBtnBeboer.Checked;
            personSQL.Alt = radioBtnAlt.Checked;

            //MessageBox.Show(personSQL.SQLBuilder());

            //dgvPersonCRUD.DataSource = tableConn.tableBinder(personSQL.SQLBuilder());
        }
    }
}
