using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SonderBoUdlejning.LejemaalSystems;
using SonderBoUdlejning.InputCheck;

namespace SonderBoUdlejning.Admin
{
    public partial class LejemaalCRUD : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();

        //Standard SQL Query, som bruges til at vise Lejemaal tabellen i dens dataGridView
        string sqlS1 = "SELECT lejemaalNr AS 'Lejemål Nr.', adresse AS 'Adresse', postNr AS 'Post Nr.', Lid AS 'Lejemålstype ID', pId AS 'Person ID', indflytDato AS 'Indflytningsdato', udflytDato AS 'Udflytningsdato' FROM Lejemaal";

        //Standard SQL Query, som bruges til at vise LejemaalsInfo tabellen i dens dataGridView
        string sqlS2 = "SELECT Lid AS 'Lejemålstype ID', lType AS 'Lejemålstype Navn', antalRum AS 'Antal Værelser', kvm AS 'Kvm', lejePris AS 'Månedlig Leje' FROM LejemaalsInfo"; 
        
        public LejemaalCRUD()
        {
            InitializeComponent();
        }

        private void LejemaalCRUD_Load(object sender, EventArgs e)
        {
            //Forbinder dataGridViews til tabeller
            dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1);
            dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2);

            dgvLejemaal.RowHeadersVisible = false;
            dgvLejemaal.BorderStyle = BorderStyle.FixedSingle;
            dgvLejemaal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLejemaal.RowTemplate.Height = 30;
            dgvLejemaal.RowTemplate.DividerHeight = 1;
            dgvLejemaal.GridColor = Color.Black;
            dgvLejemaal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);

            dgvLejemaalsInfo.RowHeadersVisible = false;
            dgvLejemaalsInfo.BorderStyle = BorderStyle.FixedSingle;
            dgvLejemaalsInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLejemaalsInfo.RowTemplate.Height = 30;
            dgvLejemaalsInfo.RowTemplate.DividerHeight = 1;
            dgvLejemaalsInfo.GridColor = Color.Black;
            dgvLejemaalsInfo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
             
            //tilføjer et tomt felt til postNr comboboxen
            comboPostNr.Items.Add("");

            //gemmer input panelet indtil en knap er trykket
            panelContainer.Visible = false;

            //Checker hvilken slags bruger er logget ind
            if (UserIdentification.UserAccess == 1) //admin
            {
                //Admin har adgang til det hele
                btnVisBCreate.Visible = true;
                btnVisBRead.Visible = true;
                btnVisBUpdate.Visible = true;
                btnVisBDelete.Visible = true;
            }
            else if (UserIdentification.UserAccess == 2) //secretary
            {
                //Sekretæren har kun adgang til at læse
                btnVisBCreate.Visible = false;
                btnVisBRead.Visible = true;
                btnVisBUpdate.Visible = false;
                btnVisBDelete.Visible = false;
            }
        }

        private void btnCreateB_Click(object sender, EventArgs e)
        {
            string adresse = tbAdresse.Text; //Tager inputtet fra adresse textboxen
            string postNr = "";
            //string postNr = comboBoxPostNr.SelectedItem.ToString(); //Tager inputtet fra postNr comboboxen
            string Lid = tbLejemaalsTypeID.Text; //Tager inputtet fra boligID textboxen

            try
            {
                if ((comboPostNr.SelectedItem == null))
                    postNr = "";
                else
                    postNr = comboPostNr.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Vælg venligst et postnummer!");
            }

            //Tjekker om en af felterne er tomme
            if ((string.IsNullOrEmpty(adresse)) || (string.IsNullOrEmpty(Lid)) || (string.IsNullOrEmpty(postNr)))
            {
                MessageBox.Show("Indtast venligst både en adresse, et lejemål Nr og vælg et postNr!");
                return;
            }

            bool adresseValid = LejemaalInputCheck.AdresseCheck(adresse);
            bool postNrValid = LejemaalInputCheck.PostNrCheck(postNr);
            bool LidValid = LejemaalInputCheck.LidCheck(Lid);
            
            //Tjekker inputtene for længde og ugyldige tegn
            if ((adresseValid == true) && (postNrValid == true) && (LidValid == true))
            {
                //Hvis inputtene passerer begge tjek og er gyldige, så opretter vi en ny lejemål
                LejemaalFacade CreateLejemaal = new LejemaalFacade();
                CreateLejemaal.cLejemaal(adresse, postNr, Lid); //opretter lejemål
                dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1); //Refresher lejemål dataGridView
                dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2); //Refresher boligInfo dataGridView
                ErrorMessage.errorMessage(); //Viser success besked
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlbesked
            }

            
        }

        private void btnReadB_Click(object sender, EventArgs e)
        {
            string sqlTemplate = $"SELECT lejemaalNr AS 'Lejemål Nr.', adresse AS 'Adresse', postNr AS 'Post Nr.', Lejemaal.Lid AS 'Lejemålstype ID', lType AS 'Lejemålstype Navn', antalRum AS 'Antal Værelser', kvm AS 'Kvm', lejePris AS 'Månedlig Leje' FROM Lejemaal INNER JOIN LejemaalsInfo ON Lejemaal.Lid=LejemaalsInfo.Lid WHERE 1=1";

            //Tager adresse input checker det for tegn og længde
            string adresse = tbAdresse.Text;
            bool adresseValid = LejemaalInputCheck.AdresseCheck(adresse);

            //Tager det valgte postNr fra comboboxen og tildeler det en string variable
            string postNr = "";
            try
            {
                if ((comboPostNr.SelectedItem == null))
                    postNr = "";
                else
                    postNr = comboPostNr.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Vælg venligst et postnummer!");
            }

            //Tager Lid input og tjekker det for ugyldige tegn
            string Lid = tbLejemaalsTypeID.Text; //
            bool LidValid = LejemaalInputCheck.LidCheck(Lid);

            //Ikke muligt at søge baseret på person ID. Input felt findes ikke i formen
            string pId = ""; //

            //Ikke muligt at søge baseret på indflytningsDato eller udflytningsDato. Input felter findes ikke i formen
            string indDato = ""; //Sætter indflytningsdato til at være tom
            string udDato = ""; //Sætter udflytningsdato til at være tom

            //Hvis Lid inputtet ikke er tomt, så bruges Lid til at finde dens lType
            string lType = "";

            if ((LidValid == false) || (string.IsNullOrEmpty(tbLejemaalsTypeID.Text)))
            {
                lType = "";
            }
            else
            {
                lType = tbLejemaalType.Text = tableConn.textBoxBinder($"SELECT lType FROM LejemaalsInfo WHERE Lid = {Lid}");
            }

            /*if (!string.IsNullOrEmpty(Lid)) 
                lType = tbLejemaalType.Text = tableConn.textBoxBinder($"SELECT lType FROM LejemaalsInfo WHERE Lid = {Lid}");*/
            
            //antalRum bruges ikke endnu og har heller ikke noget input felt at tage fra
            string antalRum = "";

            //Tager inputtet fra tbMinKvm tekstboksen og tjekker det for ugyldige tegn
            string minKvm = tbMinKvm.Text; //
            bool minKvmValid = LejemaalInputCheck.kvmCheck(minKvm);

            //Tager inputtet fra tbMaksKvm tekstboksen og tjekker det for ugyldige tegn
            string maksKvm = tbMaksKvm.Text; //
            bool maksKvmValid = LejemaalInputCheck.kvmCheck(maksKvm);

            //Tager inputtet fra tbMinPris tekstboksen og tjekker det for ugyldige tegn
            string minLejePris = tbMinPris.Text; //
            bool minLejePrisValid = LejemaalInputCheck.lejePrisCheck(minLejePris);

            //Tager inputtet fra tbMaksPris tekstboksen og tjekker det for ugyldige tegn
            string maksLejePris = tbMaksPris.Text; //
            bool maksLejePrisValid = LejemaalInputCheck.lejePrisCheck(maksLejePris);

            bool tilLeje = true;

            //Sætter tabControl fokus til Lejemaal tabellen
            tabControl1.SelectedTab = LejemaalPage;

            //Laver et objekt af LejemaalFacade klassen
            LejemaalFacade readTilLeje = new LejemaalFacade();

            //Hvis alle inputtet er gyldige, så kaldes metoden readTilLeje
            if ((adresseValid == true) && (LidValid == true) && (minKvmValid == true) && (maksKvmValid == true) && (minLejePrisValid == true) && (maksLejePrisValid == true))
            {
                //Kalder en speciel read metode for lejemål til leje
                readTilLeje.rLejemaal(sqlTemplate, adresse, postNr, Lid, pId, indDato, udDato, lType, minKvm, maksKvm, minLejePris, maksLejePris, tilLeje);

                //Viser read metodens resultat i Lejemaal dataGridView
                dgvLejemaal.DataSource = tableConn.tableBinder(readTilLeje.rLejemaalQuery); 
            }
            else //Ellers vises en fejlbesked, samt nulstilles dataGridViews
            {
                dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1); //Refresher lejemål dataGridView
                dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2); //Refresher boligInfo dataGridView
                ErrorMessage.errorMessage(); //Vis fejlbesked
            }

        }

        private void btnUpdateB_Click(object sender, EventArgs e)
        {
            string lejemaalNr = tbLejemaalNr.Text;
            string adresse = ""; //Tager inputtet fra adresse textboxen
            string Lid = ""; //Tager inputtet fra boligID textboxen

            //Tjekker om lejemåls feltet er tomt
            if ((string.IsNullOrEmpty(lejemaalNr)))
            {
                MessageBox.Show("Indtast venligst et lejemåls nr.!");
                return;
            }

            bool lejemaalValid = LejemaalInputCheck.LejemaalCheck(lejemaalNr);

            if ((string.IsNullOrEmpty(tbAdresse.Text)) && (lejemaalValid == true))
                adresse = tableConn.textBoxBinder($"SELECT adresse FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");
            else
                adresse = tbAdresse.Text;
            
            if ((string.IsNullOrEmpty(tbLejemaalsTypeID.Text)) && (lejemaalValid == true))
                Lid = tableConn.textBoxBinder($"SELECT Lid FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");
            else
                Lid = tbLejemaalsTypeID.Text;

            //Tjekker om der er der er skrevet noget i et af felterne
            if ((string.IsNullOrEmpty(tbAdresse.Text)) && (string.IsNullOrEmpty(tbLejemaalsTypeID.Text)))
            {
                MessageBox.Show("Indtast venligst enten en adresse eller et lejemål Nr!");
                return;
            }

            string postNr = "";
            string pId = "";
            string indflytDato = "";
            string udflytDato = "";

            bool adresseValid = LejemaalInputCheck.AdresseCheck(adresse);
            bool LidValid = LejemaalInputCheck.LidCheck(Lid);

            //Tjekker inputtene for længde og ugyldige tegn
            if ((lejemaalValid == true) && (adresseValid == true) && (LidValid == true))
            {
                //Finder postNr, pId, indflytDato og udflytDato fra Lejemaal tabellen ved hjælp af adressen
                postNr = tableConn.textBoxBinder($"SELECT postNr FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");
                pId = tableConn.textBoxBinder($"SELECT pId FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");
                indflytDato = LejemaalInputCheck.indDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), indflytDato, 105) FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");
                udflytDato = LejemaalInputCheck.udDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), udflytDato, 105) FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");

                //Opdaterer lejemål Nr'et i Lejemaal tabellen
                LejemaalFacade UpdateLejemaal = new LejemaalFacade();
                UpdateLejemaal.uLejemaal(lejemaalNr, adresse, postNr, Lid, pId, indflytDato, udflytDato);
                dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1); //Refresher lejemål dataGridView
                dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2); //Refresher boligInfo dataGridView
                ErrorMessage.errorMessage(); //Viser success besked                
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlbesked
            }
        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            string lejemaalNr = tbLejemaalNr.Text; //Tager inputtet fra Lejemål textboxen

            //Tjekker om adresse feltet er tomt
            if ((string.IsNullOrEmpty(lejemaalNr)))
            {
                MessageBox.Show("Indtast venligst et lejemåls nr.!");
                return;
            }

            bool lejemaalValid = LejemaalInputCheck.LejemaalCheck(lejemaalNr);
            
            //Tjekker inputtene for længde og ugyldige tegn
            if ((lejemaalValid == true))
            {
                //Sletter lejemål fra Lejemaal tabellen
                LejemaalFacade DeleteLejemaal = new LejemaalFacade();
                DeleteLejemaal.dLejemaal(lejemaalNr);
                dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1); //Refresher lejemål dataGridView
                dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2); //Refresher boligInfo dataGridView
                ErrorMessage.errorMessage(); //Viser success besked
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlbesked
            }

        }

        //Event metode som aktiveres hver gang noget vælges i postNr comboboxen
        private void comboPostNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sætter det valgte postNr i en string variabel
            string postNr = comboPostNr.SelectedItem.ToString();

            //Hvis postNr ikke er tomt, så kaldes metoden textBoxBinder og resultatet vises i By tekstboxen
            if (!string.IsNullOrEmpty(postNr))
                tbBy.Text = tableConn.textBoxBinder($"SELECT byNavn FROM PostNr WHERE postNr = {postNr}");
        }

        //Event metode som aktiveres hver gang lejemål Nr tekstboxen bliver ændret
        private void tbLejemaalID_TextChanged(object sender, EventArgs e)
        {
            string Lid = tbLejemaalsTypeID.Text; //Sætter lejemål Nr'et i en string variabel
            bool LidValid = LejemaalInputCheck.LidCheck(Lid);

            try
            {
                if (LidValid == false)
                {
                    ErrorMessage.errorMessage(); //Viser fejlbesked
                    return;
                }
                //Hvis lejemål Nr'et ikke er tomt, så kaldes metoden textBoxBinder og resultatet vises i lejemål type tekstboxen
                if (!string.IsNullOrEmpty(Lid))
                    tbLejemaalType.Text = tableConn.textBoxBinder($"SELECT lType FROM LejemaalsInfo WHERE Lid = {Lid}");
            }
            catch //hvis lejemål Nr'et ikke er et tal, så vises en fejlbesked
            {
                MessageBox.Show("Indtast kun tal i lejemål Nr feltet");
            }
        }

        //Knap som viser felter relevant for at oprette en ny lejemål
        private void btnVisLCreate_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1);
            dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2);

            string[] comboBoxList;
            comboBoxList = tableConn.comboBoxBinder($"SELECT postNr FROM PostNr").ToArray();
            comboPostNr.Items.AddRange(comboBoxList);

            //Knapper
            btnCreateL.Visible = true;
            btnCreateL.Location = new Point(0, 0);

            btnReadL.Visible = false;
            btnUpdateL.Visible = false;
            btnDeleteL.Visible = false;

            //Labels
            lblLejemaalNr.Visible = false;

            lblAdresse.Visible = true; //
            lblAdresse.Location = new Point(18, 15);

            lblPostNr.Visible = true; //
            lblPostNr.Location = new Point(159, 15);

            lblBy.Visible = true; //
            lblBy.Location = new Point(302, 15);

            lblLejemaalsTypeID.Visible = true; //
            lblLejemaalsTypeID.Location = new Point(441, 15);

            lblLejemaalType.Visible = true; //
            lblLejemaalType.Location = new Point(580, 15);

            lblMinKvm.Visible = false;
            lblMaksKvm.Visible = false;
            lblMinPris.Visible = false;
            lblMaksPris.Visible = false;

            //Textboxes & comboboxes
            tbLejemaalNr.Visible = false;

            tbAdresse.Visible = true; //
            tbAdresse.Location = new Point(22, 38);
            tbAdresse.Text = "";

            comboPostNr.Visible = true; //
            comboPostNr.Location = new Point(163, 38);

            tbBy.Visible = true; //
            tbBy.Location = new Point(306, 38);
            tbBy.Text = "";

            tbLejemaalsTypeID.Visible = true; //
            tbLejemaalsTypeID.Location = new Point(444, 38);
            tbLejemaalsTypeID.Text = "";

            tbLejemaalType.Visible = true; //
            tbLejemaalType.Location = new Point(584, 38);
            tbLejemaalType.Text = "";

            tbMinKvm.Visible = false;
            tbMaksKvm.Visible = false;
            tbMinPris.Visible = false;
            tbMaksPris.Visible= false;
        }

        //Knap som viser felter relevant for at indlæse en eksisterende boliger
        private void btnVisLRead_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            string sqlTemplate = $"SELECT lejemaalNr AS 'Lejemål Nr.', adresse AS 'Adresse', postNr AS 'Post Nr.', Lejemaal.Lid AS 'Lejemålstype ID', lType AS 'Lejemålstype Navn', antalRum AS 'Antal Værelser', kvm AS 'Kvm', lejePris AS 'Månedlig Leje' FROM Lejemaal INNER JOIN LejemaalsInfo ON Lejemaal.Lid=LejemaalsInfo.Lid WHERE 1=1 AND (pId IS NULL AND indflytDato IS NULL AND udflytDato IS NULL)";

            dgvLejemaal.DataSource = tableConn.tableBinder(sqlTemplate);
            dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2);

            string[] comboListPostNr;
            comboListPostNr = tableConn.comboBoxBinder($"SELECT postNr FROM PostNr").ToArray();
            comboPostNr.Items.AddRange(comboListPostNr);

            //Knapper
            btnCreateL.Visible = false;

            btnReadL.Visible = true;
            btnReadL.Location = new Point(0, 0);

            btnUpdateL.Visible = false;
            btnDeleteL.Visible = false;

            //Labels
            lblLejemaalNr.Visible = false;

            lblAdresse.Visible = true; //
            lblAdresse.Location = new Point(18, 15);

            lblPostNr.Visible = true; //
            lblPostNr.Location = new Point(159, 15);

            lblBy.Visible = false;

            lblLejemaalsTypeID.Visible = true; //
            lblLejemaalsTypeID.Location = new Point(302, 15);

            lblLejemaalType.Visible = false;

            lblMinKvm.Visible = true; //
            lblMinKvm.Location = new Point(18, 96);

            lblMaksKvm.Visible = true; //
            lblMaksKvm.Location = new Point(159, 96);

            lblMinPris.Visible = true; //
            lblMinPris.Location = new Point(441, 96);

            lblMaksPris.Visible = true; //
            lblMaksPris.Location = new Point(570, 96);


            //Textboxes & comboboxes
            tbLejemaalNr.Visible = false;

            tbAdresse.Visible = true; //
            tbAdresse.Location = new Point(22, 38);
            tbAdresse.Text = "";

            comboPostNr.Visible = true; //
            comboPostNr.Location = new Point(163, 38);

            tbBy.Visible = false;

            tbLejemaalsTypeID.Visible = true; //
            tbLejemaalsTypeID.Location = new Point(306, 38);
            tbLejemaalsTypeID.Text = "";

            tbLejemaalType.Visible = false;

            tbMinKvm.Visible = true; //
            tbMinKvm.Location = new Point(22, 119);
            tbMinKvm.Text = "";

            tbMaksKvm.Visible = true; //
            tbMaksKvm.Location = new Point(163, 119);
            tbMaksKvm.Text = "";

            tbMinPris.Visible = true; //
            tbMinPris.Location = new Point(444, 119);
            tbMinPris.Text = "";

            tbMaksPris.Visible = true; //
            tbMaksPris.Location = new Point(574, 119);
            tbMaksPris.Text = "";
        }

        //Knap som viser felter relevant for at opdatere en eksisterende lejemål
        private void btnVisLUpdate_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1);
            dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2);

            //Knapper
            btnCreateL.Visible = false;
            btnReadL.Visible = false;

            btnUpdateL.Visible = true;
            btnUpdateL.Location = new Point(0, 0);

            btnDeleteL.Visible = false;

            //Labels
            lblLejemaalNr.Visible = true;
            lblLejemaalNr.Location = new Point(18, 15);

            lblAdresse.Visible = true; //
            lblAdresse.Location = new Point(159, 15);

            lblPostNr.Visible = false;
            lblBy.Visible = false;

            lblLejemaalsTypeID.Visible = true; //
            lblLejemaalsTypeID.Location = new Point(302, 15);

            lblLejemaalType.Visible = false;
            lblMinKvm.Visible = false;
            lblMaksKvm.Visible = false;
            lblMinPris.Visible = false;
            lblMaksPris.Visible = false;

            //Textboxes & comboboxes
            tbLejemaalNr.Visible = true;
            tbLejemaalNr.Location = new Point(22, 38);
            tbLejemaalNr.Text = "";

            tbAdresse.Visible = true; //
            tbAdresse.Location = new Point(163, 38);
            tbAdresse.Text = "";

            comboPostNr.Visible = false;
            tbBy.Visible = false;

            tbLejemaalsTypeID.Visible = true; //
            tbLejemaalsTypeID.Location = new Point(306, 38);
            tbLejemaalsTypeID.Text = "";

            tbLejemaalType.Visible = false;
            tbMinKvm.Visible = false;
            tbMaksKvm.Visible = false;
            tbMinPris.Visible = false;
            tbMaksPris.Visible = false;
        }

        //Knap som viser felter relevant for at slette en eksisterende lejemål
        private void btnVisLDelete_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1);
            dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2);

            //Knapper
            btnCreateL.Visible = false;
            btnReadL.Visible = false;
            btnUpdateL.Visible = false;

            btnDeleteL.Visible = true;
            btnDeleteL.Location = new Point(0, 0);

            //Labels
            lblLejemaalNr.Visible = true; //
            lblLejemaalNr.Location = new Point(18, 15);

            lblAdresse.Visible = false;
            lblPostNr.Visible = false;
            lblBy.Visible = false;
            lblLejemaalsTypeID.Visible = false;
            lblLejemaalType.Visible = false;
            lblMinKvm.Visible = false;
            lblMaksKvm.Visible = false;
            lblMinPris.Visible = false;
            lblMaksPris.Visible = false;

            //Textboxes & comboboxes
            tbLejemaalNr.Visible = true; //
            tbLejemaalNr.Location = new Point(22, 38);
            tbLejemaalNr.Text = "";

            tbAdresse.Visible = false;
            comboPostNr.Visible = false;
            tbBy.Visible = false;
            tbLejemaalsTypeID.Visible = false;
            tbLejemaalType.Visible = false;
            tbMinKvm.Visible = false;
            tbMaksKvm.Visible = false;
            tbMinPris.Visible = false;
            tbMaksPris.Visible = false;
        }
    }
}
