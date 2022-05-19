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
    public partial class LejemaalCRUD : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        string sqlS1 = "SELECT * FROM Lejemaal"; //Standard SQL Query, som bruges til at vise Lejemaal tabellen i dens dataGridView
        string sqlS2 = "SELECT * FROM LejemaalsInfo"; //Standard SQL Query, som bruges til at vise LejemaalsInfo tabellen i dens dataGridView
        public LejemaalCRUD()
        {
            InitializeComponent();
        }

        private void BoligCRUD_Load(object sender, EventArgs e)
        {
            //Forbinder dataGridViews til tabeller
            dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1);
            dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2);

            //tilføjer et tomt felt til postNr comboboxen
            comboBoxPostNr.Items.Add("");

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
            string Lid = tbBoligID.Text; //Tager inputtet fra boligID textboxen

            try
            {
                if ((comboBoxPostNr.SelectedItem == null))
                    postNr = "";
                else
                    postNr = comboBoxPostNr.SelectedItem.ToString();
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
            bool bIdValid = LejemaalInputCheck.LidCheck(Lid);
            
            //Tjekker inputtene for længde og ugyldige tegn
            if ((adresseValid == true) && (postNrValid == true) && (bIdValid == true))
            {
                //Hvis inputtene passerer begge tjek og er gyldige, så opretter vi en ny lejemål
                LejemaalFacade CreateBolig = new LejemaalFacade();
                CreateBolig.cBolig(adresse, postNr, Lid); //opretter lejemål
                dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1); //Refresher lejemål dataGridView
                dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2); //Refresher boligInfo dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlbesked
            }

            
        }

        private void btnReadB_Click(object sender, EventArgs e)
        {
            string sqlTemplate = $"SELECT lejemaalNr, adresse, postNr, Lejemaal.Lid, lType, antalRum, kvm, lejePris FROM Lejemaal INNER JOIN LejemaalsInfo ON Lejemaal.Lid=LejemaalsInfo.Lid WHERE 1=1";

            //Tager adresse input checker det for tegn og længde
            string adresse = tbAdresse.Text;
            bool adresseValid = LejemaalInputCheck.AdresseCheck(adresse);

            //Tager det valgte postNr fra comboboxen og tildeler det en string variable
            string postNr = "";
            try
            {
                if ((comboBoxPostNr.SelectedItem == null))
                    postNr = "";
                else
                    postNr = comboBoxPostNr.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Vælg venligst et postnummer!");
            }

            //Tager Lid input og tjekker det for ugyldige tegn
            string Lid = tbBoligID.Text; //
            bool LidValid = LejemaalInputCheck.LidCheck(Lid);

            //Ikke muligt at søge baseret på person ID. Input felt findes ikke i formen
            string pId = ""; //

            //Ikke muligt at søge baseret på indflytningsDato eller udflytningsDato. Input felter findes ikke i formen
            string indDato = ""; //Sætter indflytningsdato til at være tom
            string udDato = ""; //Sætter udflytningsdato til at være tom

            //Hvis Lid inputtet ikke er tomt, så bruges Lid til at finde dens lType
            string lType = "";

            if ((LidValid == false) || (string.IsNullOrEmpty(tbBoligID.Text)))
            {
                lType = "";
            }
            else
            {
                lType = tbBoligType.Text = tableConn.textBoxBinder($"SELECT lType FROM LejemaalsInfo WHERE Lid = {Lid}");
            }

            /*if (!string.IsNullOrEmpty(Lid)) 
                lType = tbBoligType.Text = tableConn.textBoxBinder($"SELECT lType FROM LejemaalsInfo WHERE Lid = {Lid}");*/
            
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

            //Laver et objekt af BoligFacade klassen
            LejemaalFacade readTilLeje = new LejemaalFacade();

            //Hvis alle inputtet er gyldige, så kaldes metoden readTilLeje
            if ((adresseValid == true) && (LidValid == true) && (minKvmValid == true) && (maksKvmValid == true) && (minLejePrisValid == true) && (maksLejePrisValid == true))
            {
                //Kalder en speciel read metode for lejemål til leje
                readTilLeje.rBolig(sqlTemplate, adresse, postNr, Lid, pId, indDato, udDato, lType, minKvm, maksKvm, minLejePris, maksLejePris, tilLeje);

                //Viser read metodens resultat i Lejemaal dataGridView
                dgvLejemaal.DataSource = tableConn.tableBinder(readTilLeje.rBoligQuery); 
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
            string lejemaalNr = tbLejemaal.Text;
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
            
            if ((string.IsNullOrEmpty(tbBoligID.Text)) && (lejemaalValid == true))
                Lid = tableConn.textBoxBinder($"SELECT Lid FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");
            else
                Lid = tbBoligID.Text;

            //Tjekker om der er der er skrevet noget i et af felterne
            if ((string.IsNullOrEmpty(tbAdresse.Text)) && (string.IsNullOrEmpty(tbBoligID.Text)))
            {
                MessageBox.Show("Indtast venligst enten en adresse eller et lejemål Nr!");
                return;
            }

            string postNr = "";
            string pId = "";
            string indflytDato = "";
            string udflytDato = "";

            bool adresseValid = LejemaalInputCheck.AdresseCheck(adresse);
            bool bIdValid = LejemaalInputCheck.LidCheck(Lid);

            //Tjekker inputtene for længde og ugyldige tegn
            if ((lejemaalValid == true) && (adresseValid == true) && (bIdValid == true))
            {
                //Finder postNr, pId, indflytDato og udflytDato fra Lejemaal tabellen ved hjælp af adressen
                postNr = tableConn.textBoxBinder($"SELECT postNr FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");
                pId = tableConn.textBoxBinder($"SELECT pId FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");
                indflytDato = LejemaalInputCheck.indDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), indflytDato, 105) FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");
                udflytDato = LejemaalInputCheck.udDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), udflytDato, 105) FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");

                //Opdaterer lejemål Nr'et i Lejemaal tabellen
                LejemaalFacade UpdateBolig = new LejemaalFacade();
                UpdateBolig.uBolig(lejemaalNr, adresse, postNr, Lid, pId, indflytDato, udflytDato);
                dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1); //Refresher lejemål dataGridView
                dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2); //Refresher boligInfo dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlbesked
            }
        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            string lejemaalNr = tbLejemaal.Text; //Tager inputtet fra Lejemål textboxen

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
                LejemaalFacade DeleteBolig = new LejemaalFacade();
                DeleteBolig.dBolig(lejemaalNr);
                dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1); //Refresher lejemål dataGridView
                dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2); //Refresher boligInfo dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlbesked
            }

        }

        //Event metode som aktiveres hver gang noget vælges i postNr comboboxen
        private void comboBoxPostNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sætter det valgte postNr i en string variabel
            string postNr = comboBoxPostNr.SelectedItem.ToString();

            //Hvis postNr ikke er tomt, så kaldes metoden textBoxBinder og resultatet vises i By tekstboxen
            if (!string.IsNullOrEmpty(postNr))
                tbBy.Text = tableConn.textBoxBinder($"SELECT byNavn FROM PostNr WHERE postNr = {postNr}");
        }

        //Event metode som aktiveres hver gang lejemål Nr tekstboxen bliver ændret
        private void tbBoligID_TextChanged(object sender, EventArgs e)
        {
            string Lid = tbBoligID.Text; //Sætter lejemål Nr'et i en string variabel
            bool bIdValid = LejemaalInputCheck.LidCheck(Lid);

            try
            {
                if (bIdValid == false)
                {
                    ErrorMessage.errorMessage(); //Viser fejlbesked
                    return;
                }
                //Hvis lejemål Nr'et ikke er tomt, så kaldes metoden textBoxBinder og resultatet vises i lejemål type tekstboxen
                if (!string.IsNullOrEmpty(Lid))
                    tbBoligType.Text = tableConn.textBoxBinder($"SELECT lType FROM LejemaalsInfo WHERE Lid = {Lid}");
            }
            catch //hvis lejemål Nr'et ikke er et tal, så vises en fejlbesked
            {
                MessageBox.Show("Indtast kun tal i lejemål Nr feltet");
            }
        }

        //Knap som viser felter relevant for at oprette en ny lejemål
        private void btnVisBCreate_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1);
            dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2);

            string[] comboBoxList;
            comboBoxList = tableConn.comboBoxBinder($"SELECT postNr FROM PostNr").ToArray();
            comboBoxPostNr.Items.AddRange(comboBoxList);

            btnCreateB.Visible = true;
            btnReadB.Visible = false;
            btnUpdateB.Visible = false;
            btnDeleteB.Visible = false;

            lblLejemaal.Visible = false;
            lblAdresse.Visible = true; //
            lblPostNr.Visible = true; //
            lblBy.Visible = true; //
            lblLejemaalNr.Visible = true; //
            lblMinKvm.Visible = false;
            lblMaksKvm.Visible = false;
            lblLejemaalType.Visible = true; //
            lblMinPris.Visible = false;
            lblMaksPris.Visible = false;

            tbLejemaal.Visible = false;
            tbAdresse.Visible = true; //
            comboBoxPostNr.Visible = true; //
            tbBy.Visible = true; //
            tbBoligID.Visible = true; //
            tbMinKvm.Visible = false;
            tbMaksKvm.Visible = false;
            tbBoligType.Visible = true; //
            tbMinPris.Visible = false;
            tbMaksPris.Visible= false;
        }

        //Knap som viser felter relevant for at indlæse en eksisterende boliger
        private void btnVisBRead_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            string sqlTemplate = $"SELECT lejemaalNr, adresse, postNr, Lejemaal.Lid, lType, antalRum, kvm, lejePris FROM Lejemaal INNER JOIN LejemaalsInfo ON Lejemaal.Lid=LejemaalsInfo.Lid WHERE 1=1 AND (pId IS NULL AND indflytDato IS NULL AND udflytDato IS NULL)";

            dgvLejemaal.DataSource = tableConn.tableBinder(sqlTemplate);
            dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2);

            string[] comboBoxList;
            comboBoxList = tableConn.comboBoxBinder($"SELECT postNr FROM PostNr").ToArray();
            comboBoxPostNr.Items.AddRange(comboBoxList);

            btnCreateB.Visible = false;
            btnReadB.Visible = true;
            btnUpdateB.Visible = false;
            btnDeleteB.Visible = false;

            lblLejemaal.Visible = false;
            lblAdresse.Visible = true; //
            lblPostNr.Visible = true; //
            lblBy.Visible = false;
            lblLejemaalNr.Visible = true; //
            lblMinKvm.Visible = true; //
            lblMaksKvm.Visible = true; //
            lblLejemaalType.Visible = false;
            lblMinPris.Visible = true; //
            lblMaksPris.Visible = true; //

            tbLejemaal.Visible = false;
            tbAdresse.Visible = true; //
            comboBoxPostNr.Visible = true; //
            tbBy.Visible = false;
            tbBoligID.Visible = true; //
            tbMinKvm.Visible = true; //
            tbMaksKvm.Visible = true; //
            tbBoligType.Visible = false; //
            tbMinPris.Visible = true; //
            tbMaksPris.Visible = true; //
        }

        //Knap som viser felter relevant for at opdatere en eksisterende lejemål
        private void btnVisBUpdate_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1);
            dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2);

            btnCreateB.Visible = false;
            btnReadB.Visible = false;
            btnUpdateB.Visible = true;
            btnDeleteB.Visible = false;

            lblLejemaal.Visible = true;
            lblAdresse.Visible = true; //
            lblPostNr.Visible = false;
            lblBy.Visible = false;
            lblLejemaalNr.Visible = true; //
            lblMinKvm.Visible = false;
            lblMaksKvm.Visible = false;
            lblLejemaalType.Visible = false;
            lblMinPris.Visible = false;
            lblMaksPris.Visible = false;

            tbLejemaal.Visible = true;
            tbAdresse.Visible = true; //
            comboBoxPostNr.Visible = false;
            tbBy.Visible = false;
            tbBoligID.Visible = true; //
            tbMinKvm.Visible = false;
            tbMaksKvm.Visible = false;
            tbBoligType.Visible = false;
            tbMinPris.Visible = false;
            tbMaksPris.Visible = false;
        }

        //Knap som viser felter relevant for at slette en eksisterende lejemål
        private void btnVisDBolig_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1);
            dgvLejemaalsInfo.DataSource = tableConn.tableBinder(sqlS2);
            
            btnCreateB.Visible = false;
            btnReadB.Visible = false;
            btnUpdateB.Visible = false;
            btnDeleteB.Visible = true;
            
            lblLejemaal.Visible = true; //
            lblAdresse.Visible = false;
            lblPostNr.Visible = false;
            lblBy.Visible = false;
            lblLejemaalNr.Visible = false;
            lblMinKvm.Visible = false;
            lblMaksKvm.Visible = false;
            lblLejemaalType.Visible = false;
            lblMinPris.Visible = false;
            lblMaksPris.Visible = false;

            tbLejemaal.Visible = true; //
            tbAdresse.Visible = false;
            comboBoxPostNr.Visible = false;
            tbBy.Visible = false;
            tbBoligID.Visible = false;
            tbMinKvm.Visible = false;
            tbMaksKvm.Visible = false;
            tbBoligType.Visible = false;
            tbMinPris.Visible = false;
            tbMaksPris.Visible = false;
        }
    }
}
