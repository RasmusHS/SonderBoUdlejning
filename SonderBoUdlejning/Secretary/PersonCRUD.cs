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

            personSQL.Navn = tbNavn.Text;
            personSQL.Mail = tbMail.Text;
            personSQL.Tlf = tbTlf.Text;
            personSQL.Medlem = radioBtnMedlem.Checked;
            personSQL.ErBeboer = radioBtnBeboer.Checked;
            personSQL.Alt = radioBtnAlt.Checked;

            MessageBox.Show(personSQL.SQLBuilder());

            dgvPersonCRUD.DataSource = tableConn.CUD(personSQL.SQLBuilder());
        }

        private void btnPersonR_Click(object sender, EventArgs e)
        {
            personSQL.Create = false;
            personSQL.Read = true;
            personSQL.Update = false;
            personSQL.Delete = false;

            personSQL.Navn = tbNavn.Text;
            personSQL.Mail = tbMail.Text;
            personSQL.Tlf = tbTlf.Text;
            personSQL.Medlem = radioBtnMedlem.Checked;
            personSQL.ErBeboer = radioBtnBeboer.Checked;
            personSQL.Alt = radioBtnAlt.Checked;

            //MessageBox.Show(personSQL.SQLBuilder());

            dgvPersonCRUD.DataSource = tableConn.tableBinder(personSQL.SQLBuilder());
        }

        private void btnPersonU_Click(object sender, EventArgs e)
        {
            personSQL.Create = false;
            personSQL.Read = false;
            personSQL.Update = true;
            personSQL.Delete = false;

            personSQL.Navn = tbNavn.Text;
            personSQL.Mail = tbMail.Text;
            personSQL.Tlf = tbTlf.Text;
            personSQL.Medlem = radioBtnMedlem.Checked;
            personSQL.ErBeboer = radioBtnBeboer.Checked;
            personSQL.Alt = radioBtnAlt.Checked;
            personSQL.PId = tbPId.Text;

            MessageBox.Show(personSQL.SQLBuilder());

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

            MessageBox.Show(personSQL.SQLBuilder());

            //dgvPersonCRUD.DataSource = tableConn.tableBinder(personSQL.SQLBuilder());
        }
    }
}
