using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SonderBoUdlejning.BoligSystems;
using SonderBoUdlejning.InputCheck;

namespace SonderBoUdlejning.Admin
{
    public partial class BoligCRUD : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        string sqlS1 = "SELECT * FROM Bolig";
        string sqlS2 = "SELECT * FROM BoligInfo";
        public BoligCRUD()
        {
            InitializeComponent();
        }

        private void BoligCRUD_Load(object sender, EventArgs e)
        {
            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);

            comboBoxPostNr.Items.Add("");

            panelContainer.Visible = false;

            if (UserIdentification.UserAccess == 1) //admin
            {
                btnVisBCreate.Visible = true;
                btnVisBRead.Visible = true;
                btnVisBUpdate.Visible = true;
                btnVisBDelete.Visible = true;
            }
            else if (UserIdentification.UserAccess == 2) //secretary
            {
                btnVisBCreate.Visible = false;
                btnVisBRead.Visible = true;
                btnVisBUpdate.Visible = false;
                btnVisBDelete.Visible = false;
            }
        }

        private void btnCreateB_Click(object sender, EventArgs e)
        {
            string adresse = tbAdresse.Text;
            string postNr = comboBoxPostNr.SelectedItem.ToString();
            string bId = tbBoligID.Text;

            if ((string.IsNullOrEmpty(adresse)) || (string.IsNullOrEmpty(bId)))
            {
                MessageBox.Show("Indtast venligst både en adresse og et bolig ID!");
                return;
            }
            if((BoligInputCheck.AdresseCheck(adresse) == false) || (BoligInputCheck.BIdCheck(bId) == false))
            {
                ErrorMessage.errorMessage();
                return;
            }

            BoligFacade CreateBolig = new BoligFacade();
            CreateBolig.cBolig(adresse, postNr, bId);
            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);
        }

        private void btnReadB_Click(object sender, EventArgs e)
        {
            string adresse = tbAdresse.Text; //
            bool adresseValid = BoligInputCheck.AdresseCheck(adresse);
            if (ErrorMessage.injectedSQL == 1)
            {
                ErrorMessage.errorMessage();
                return;
            }

            string postNr = comboBoxPostNr.SelectedItem.ToString(); //
            
            string bId = tbBoligID.Text; //
            bool bIdValid = BoligInputCheck.BIdCheck(bId);
            if (ErrorMessage.injectedSQL == 1)
            {
                ErrorMessage.errorMessage();
                return;
            }

            string bType = "";
            if (!string.IsNullOrEmpty(bId))
                bType = tbBoligType.Text = tableConn.textBoxBinder($"SELECT bType FROM BoligInfo WHERE bId = {bId}");
            string antalRum = "";
            
            string minKvm = tbMinKvm.Text; //
            bool minKvmValid = BoligInputCheck.kvmCheck(minKvm);
            if (ErrorMessage.injectedSQL == 1)
            {
                ErrorMessage.errorMessage();
                return;
            }

            string maksKvm = tbMaksKvm.Text; //
            bool maksKvmValid = BoligInputCheck.kvmCheck(maksKvm);
            if (ErrorMessage.injectedSQL == 1)
            {
                ErrorMessage.errorMessage();
                return;
            }

            string minLejePris = tbMinPris.Text; //
            bool minLejePrisValid = BoligInputCheck.lejePrisCheck(minLejePris);
            if (ErrorMessage.injectedSQL == 1)
            {
                ErrorMessage.errorMessage();
                return;
            }

            string maksLejePris = tbMaksPris.Text; //
            bool maksLejePrisValid = BoligInputCheck.lejePrisCheck(maksLejePris);
            if (ErrorMessage.injectedSQL == 1)
            {
                ErrorMessage.errorMessage();
                return;
            }

            //string readBoligTemplate = $"SELECT adresse, postNr, Bolig.bId, bType, antalRum, kvm, lejePris FROM Bolig INNER JOIN BoligInfo ON Bolig.bId=BoligInfo.bId WHERE 1=1 AND pId IS NULL AND indflytDato IS NULL";
            tabControl1.SelectedTab = BoligPage;

            BoligFacade readTilLeje = new BoligFacade();

            if ((adresseValid == true) && (bIdValid == true) && (minKvmValid == true) && (maksKvmValid == true) && (minLejePrisValid == true) && (maksLejePrisValid == true))
            {
                readTilLeje.rBoligTilLeje(adresse, postNr, bId, bType, minKvm, maksKvm, minLejePris, maksLejePris);
                dgvBolig.DataSource = tableConn.tableBinder(readTilLeje.rBoligQuery);
            }
            else
            {
                dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
                dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);
                ErrorMessage.errorMessage();
            }

        }

        private void btnUpdateB_Click(object sender, EventArgs e)
        {
            string adresse = tbAdresse.Text;
            string bId = tbBoligID.Text;

            if ((string.IsNullOrEmpty(adresse)) || (string.IsNullOrEmpty(bId)))
            {
                MessageBox.Show("Indtast venligst både en adresse og et bolig ID!");
                return;
            }
            if ((BoligInputCheck.AdresseCheck(adresse) == false) || (BoligInputCheck.BIdCheck(bId) == false))
            {
                ErrorMessage.errorMessage();
                return;
            }

            string postNr = tableConn.textBoxBinder($"SELECT postNr FROM Bolig WHERE adresse = '{adresse}'");
            string pId = tableConn.textBoxBinder($"SELECT pId FROM Bolig WHERE adresse = '{adresse}'");
            string indflytDato = BoligInputCheck.indDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), indflytDato, 105) FROM Bolig WHERE adresse = '{adresse}'");
            string udflytDato = BoligInputCheck.udDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), udflytDato, 105) FROM Bolig WHERE adresse = '{adresse}'");

            BoligFacade UpdateBolig = new BoligFacade();
            UpdateBolig.uBolig(adresse, postNr, bId, pId, indflytDato, udflytDato);
            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);
        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            string adresse = tbAdresse.Text;

            if ((string.IsNullOrEmpty(adresse)))
            {
                MessageBox.Show("Indtast venligst både en adresse og et bolig ID!");
                return;
            }
            if ((BoligInputCheck.AdresseCheck(adresse) == false))
            {
                ErrorMessage.errorMessage();
                return;
            }

            BoligFacade DeleteBolig = new BoligFacade();
            DeleteBolig.dBolig(adresse);
            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);
        }

        private void btnVisBCreate_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);

            string[] comboBoxList;
            comboBoxList = tableConn.comboBoxBinder($"SELECT postNr FROM PostNr").ToArray();
            comboBoxPostNr.Items.AddRange(comboBoxList);

            btnCreateB.Visible = true;
            btnReadB.Visible = false;
            btnUpdateB.Visible = false;
            btnDeleteB.Visible = false;

            lblAdresse.Visible = true;
            lblPostNr.Visible = true;
            lblBy.Visible = true;
            lblBoligID.Visible = true;
            lblMinKvm.Visible = false;
            lblMaksKvm.Visible = false;
            lblBoligType.Visible = true;
            lblMinPris.Visible = false;
            lblMaksPris.Visible = false;

            tbAdresse.Visible = true;
            comboBoxPostNr.Visible = true;
            tbBy.Visible = true;
            tbBoligID.Visible = true;
            tbMinKvm.Visible = false;
            tbMaksKvm.Visible = false;
            tbBoligType.Visible = true;
            tbMinPris.Visible = false;
            tbMaksPris.Visible= false;
        }

        private void btnVisBRead_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);

            string[] comboBoxList;
            comboBoxList = tableConn.comboBoxBinder($"SELECT postNr FROM PostNr").ToArray();
            comboBoxPostNr.Items.AddRange(comboBoxList);

            btnCreateB.Visible = false;
            btnReadB.Visible = true;
            btnUpdateB.Visible = false;
            btnDeleteB.Visible = false;

            lblAdresse.Visible = true;
            lblPostNr.Visible = true;
            lblBy.Visible = false;
            lblBoligID.Visible = true;
            lblMinKvm.Visible = true;
            lblMaksKvm.Visible = true;
            lblBoligType.Visible = false;
            lblMinPris.Visible = true;
            lblMaksPris.Visible = true;

            tbAdresse.Visible = true;
            comboBoxPostNr.Visible = true;
            tbBy.Visible = false;
            tbBoligID.Visible = true;
            tbMinKvm.Visible = true;
            tbMaksKvm.Visible = true;
            tbBoligType.Visible = false;
            tbMinPris.Visible = true;
            tbMaksPris.Visible = true;
        }

        private void btnVisBUpdate_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);

            btnCreateB.Visible = false;
            btnReadB.Visible = false;
            btnUpdateB.Visible = true;
            btnDeleteB.Visible = false;

            lblAdresse.Visible = true;
            lblPostNr.Visible = false;
            lblBy.Visible = false;
            lblBoligID.Visible = true;
            lblMinKvm.Visible = false;
            lblMaksKvm.Visible = false;
            lblBoligType.Visible = false;
            lblMinPris.Visible = false;
            lblMaksPris.Visible = false;

            tbAdresse.Visible = true;
            comboBoxPostNr.Visible = false;
            tbBy.Visible = false;
            tbBoligID.Visible = true;
            tbMinKvm.Visible = false;
            tbMaksKvm.Visible = false;
            tbBoligType.Visible = false;
            tbMinPris.Visible = false;
            tbMaksPris.Visible = false;
        }

        private void btnVisDBolig_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);
            
            btnCreateB.Visible = false;
            btnReadB.Visible = false;
            btnUpdateB.Visible = false;
            btnDeleteB.Visible = true;

            lblAdresse.Visible = true;
            lblPostNr.Visible = false;
            lblBy.Visible = false;
            lblBoligID.Visible = false;

            tbAdresse.Visible = true;
            comboBoxPostNr.Visible = false;
            tbBy.Visible = false;
            tbBoligID.Visible = false;
        }

        private void comboBoxPostNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string postNr = comboBoxPostNr.SelectedItem.ToString();
            
            if (!string.IsNullOrEmpty(postNr))
                tbBy.Text = tableConn.textBoxBinder($"SELECT byNavn FROM PostNr WHERE postNr = {postNr}");

        }

        private void tbBoligID_TextChanged(object sender, EventArgs e)
        {
            string bId = tbBoligID.Text;
            try
            { 
                if (!string.IsNullOrEmpty(tbBoligID.Text))
                    tbBoligType.Text = tableConn.textBoxBinder($"SELECT bType FROM BoligInfo WHERE bId = {bId}");
            }
            catch
            {
                MessageBox.Show("Indtast kun tal i bolig ID feltet");
            }
        }
    }
}
