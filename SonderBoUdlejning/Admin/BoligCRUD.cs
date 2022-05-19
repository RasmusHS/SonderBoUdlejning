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
        string sqlS1 = "SELECT * FROM Bolig"; //Standard SQL Query, som bruges til at vise Bolig tabellen i dens dataGridView
        string sqlS2 = "SELECT * FROM BoligInfo"; //Standard SQL Query, som bruges til at vise BoligInfo tabellen i dens dataGridView
        public BoligCRUD()
        {
            InitializeComponent();
        }

        private void BoligCRUD_Load(object sender, EventArgs e)
        {
            //Forbinder dataGridViews til tabeller
            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);

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
            string bId = tbBoligID.Text; //Tager inputtet fra boligID textboxen

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
            if ((string.IsNullOrEmpty(adresse)) || (string.IsNullOrEmpty(bId)) || (string.IsNullOrEmpty(postNr)))
            {
                MessageBox.Show("Indtast venligst både en adresse, et bolig ID og vælg et postNr!");
                return;
            }

            bool adresseValid = BoligInputCheck.AdresseCheck(adresse);
            bool postNrValid = BoligInputCheck.PostNrCheck(postNr);
            bool bIdValid = BoligInputCheck.BIdCheck(bId);
            
            //Tjekker inputtene for længde og ugyldige tegn
            if ((adresseValid == true) && (postNrValid == true) && (bIdValid == true))
            {
                //Hvis inputtene passerer begge tjek og er gyldige, så opretter vi en ny bolig
                BoligFacade CreateBolig = new BoligFacade();
                CreateBolig.cBolig(adresse, postNr, bId); //opretter bolig
                dgvBolig.DataSource = tableConn.tableBinder(sqlS1); //Refresher bolig dataGridView
                dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2); //Refresher boligInfo dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlbesked
            }

            
        }

        private void btnReadB_Click(object sender, EventArgs e)
        {
            string sqlTemplate = $"SELECT adresse, postNr, Bolig.bId, bType, antalRum, kvm, lejePris FROM Bolig INNER JOIN BoligInfo ON Bolig.bId=BoligInfo.bId WHERE 1=1";

            //Tager adresse input checker det for tegn og længde
            string adresse = tbAdresse.Text;
            bool adresseValid = BoligInputCheck.AdresseCheck(adresse);

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

            //Tager bId input og tjekker det for ugyldige tegn
            string bId = tbBoligID.Text; //
            bool bIdValid = BoligInputCheck.BIdCheck(bId);

            //Ikke muligt at søge baseret på person ID. Input felt findes ikke i formen
            string pId = ""; //

            //Ikke muligt at søge baseret på indflytningsDato eller udflytningsDato. Input felter findes ikke i formen
            string indDato = ""; //Sætter indflytningsdato til at være tom
            string udDato = ""; //Sætter udflytningsdato til at være tom

            //Hvis bId inputtet ikke er tomt, så bruges bId til at finde dens bType
            string bType = "";

            if (bIdValid == false)
            {
                bType = "";
            }
            else
            {
                bType = tbBoligType.Text = tableConn.textBoxBinder($"SELECT bType FROM BoligInfo WHERE bId = {bId}");
            }

            /*if (!string.IsNullOrEmpty(bId)) 
                bType = tbBoligType.Text = tableConn.textBoxBinder($"SELECT bType FROM BoligInfo WHERE bId = {bId}");*/
            
            //antalRum bruges ikke endnu og har heller ikke noget input felt at tage fra
            string antalRum = "";

            //Tager inputtet fra tbMinKvm tekstboksen og tjekker det for ugyldige tegn
            string minKvm = tbMinKvm.Text; //
            bool minKvmValid = BoligInputCheck.kvmCheck(minKvm);

            //Tager inputtet fra tbMaksKvm tekstboksen og tjekker det for ugyldige tegn
            string maksKvm = tbMaksKvm.Text; //
            bool maksKvmValid = BoligInputCheck.kvmCheck(maksKvm);

            //Tager inputtet fra tbMinPris tekstboksen og tjekker det for ugyldige tegn
            string minLejePris = tbMinPris.Text; //
            bool minLejePrisValid = BoligInputCheck.lejePrisCheck(minLejePris);

            //Tager inputtet fra tbMaksPris tekstboksen og tjekker det for ugyldige tegn
            string maksLejePris = tbMaksPris.Text; //
            bool maksLejePrisValid = BoligInputCheck.lejePrisCheck(maksLejePris);

            bool tilLeje = true;

            //Sætter tabControl fokus til Bolig tabellen
            tabControl1.SelectedTab = BoligPage;

            //Laver et objekt af BoligFacade klassen
            BoligFacade readTilLeje = new BoligFacade();

            //Hvis alle inputtet er gyldige, så kaldes metoden readTilLeje
            if ((adresseValid == true) && (bIdValid == true) && (minKvmValid == true) && (maksKvmValid == true) && (minLejePrisValid == true) && (maksLejePrisValid == true))
            {
                //Kalder en speciel read metode for bolig til leje
                readTilLeje.rBolig(sqlTemplate, adresse, postNr, bId, pId, indDato, udDato, bType, minKvm, maksKvm, minLejePris, maksLejePris, tilLeje);

                //Viser read metodens resultat i Bolig dataGridView
                dgvBolig.DataSource = tableConn.tableBinder(readTilLeje.rBoligQuery); 
            }
            else //Ellers vises en fejlbesked, samt nulstilles dataGridViews
            {
                dgvBolig.DataSource = tableConn.tableBinder(sqlS1); //Refresher bolig dataGridView
                dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2); //Refresher boligInfo dataGridView
                ErrorMessage.errorMessage(); //Vis fejlbesked
            }

        }

        private void btnUpdateB_Click(object sender, EventArgs e)
        {
            string lejemaal = tbLejemaal.Text;
            string adresse = ""; //Tager inputtet fra adresse textboxen
            string bId = ""; //Tager inputtet fra boligID textboxen

            //Tjekker om lejemåls feltet er tomt
            if ((string.IsNullOrEmpty(lejemaal)))
            {
                MessageBox.Show("Indtast venligst et lejemåls nr.!");
                return;
            }

            bool lejemaalValid = BoligInputCheck.LejemaalCheck(lejemaal);

            if ((string.IsNullOrEmpty(tbAdresse.Text)) && (lejemaalValid == true))
                adresse = tableConn.textBoxBinder($"SELECT adresse FROM Bolig WHERE lejemaal = {lejemaal}");
            else
                adresse = tbAdresse.Text;
            
            if ((string.IsNullOrEmpty(tbBoligID.Text)) && (lejemaalValid == true))
                bId = tableConn.textBoxBinder($"SELECT bId FROM Bolig WHERE lejemaal = {lejemaal}");
            else
                bId = tbBoligID.Text;

            //Tjekker om der er der er skrevet noget i et af felterne
            if ((string.IsNullOrEmpty(tbAdresse.Text)) && (string.IsNullOrEmpty(tbBoligID.Text)))
            {
                MessageBox.Show("Indtast venligst enten en adresse eller et bolig ID!");
                return;
            }

            string postNr = "";
            string pId = "";
            string indflytDato = "";
            string udflytDato = "";

            bool adresseValid = BoligInputCheck.AdresseCheck(adresse);
            bool bIdValid = BoligInputCheck.BIdCheck(bId);

            //Tjekker inputtene for længde og ugyldige tegn
            if ((lejemaalValid == true) && (adresseValid == true) && (bIdValid == true))
            {
                //Finder postNr, pId, indflytDato og udflytDato fra Bolig tabellen ved hjælp af adressen
                postNr = tableConn.textBoxBinder($"SELECT postNr FROM Bolig WHERE lejemaal = {lejemaal}");
                pId = tableConn.textBoxBinder($"SELECT pId FROM Bolig WHERE lejemaal = {lejemaal}");
                indflytDato = BoligInputCheck.indDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), indflytDato, 105) FROM Bolig WHERE lejemaal = {lejemaal}");
                udflytDato = BoligInputCheck.udDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), udflytDato, 105) FROM Bolig WHERE lejemaal = {lejemaal}");

                //Opdaterer bolig ID'et i Bolig tabellen
                BoligFacade UpdateBolig = new BoligFacade();
                UpdateBolig.uBolig(lejemaal, adresse, postNr, bId, pId, indflytDato, udflytDato);
                dgvBolig.DataSource = tableConn.tableBinder(sqlS1); //Refresher bolig dataGridView
                dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2); //Refresher boligInfo dataGridView
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlbesked
            }
        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            string lejemaal = tbLejemaal.Text; //Tager inputtet fra Lejemål textboxen

            //Tjekker om adresse feltet er tomt
            if ((string.IsNullOrEmpty(lejemaal)))
            {
                MessageBox.Show("Indtast venligst et lejemåls nr.!");
                return;
            }

            bool lejemaalValid = BoligInputCheck.LejemaalCheck(lejemaal);
            
            //Tjekker inputtene for længde og ugyldige tegn
            if ((lejemaalValid == true))
            {
                //Sletter bolig fra Bolig tabellen
                BoligFacade DeleteBolig = new BoligFacade();
                DeleteBolig.dBolig(lejemaal);
                dgvBolig.DataSource = tableConn.tableBinder(sqlS1); //Refresher bolig dataGridView
                dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2); //Refresher boligInfo dataGridView
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

        //Event metode som aktiveres hver gang bolig ID tekstboxen bliver ændret
        private void tbBoligID_TextChanged(object sender, EventArgs e)
        {
            string bId = tbBoligID.Text; //Sætter bolig ID'et i en string variabel
            bool bIdValid = BoligInputCheck.BIdCheck(bId);

            try
            {
                if (bIdValid == false)
                {
                    ErrorMessage.errorMessage(); //Viser fejlbesked
                    return;
                }
                //Hvis bolig ID'et ikke er tomt, så kaldes metoden textBoxBinder og resultatet vises i bolig type tekstboxen
                if (!string.IsNullOrEmpty(bId))
                    tbBoligType.Text = tableConn.textBoxBinder($"SELECT bType FROM BoligInfo WHERE bId = {bId}");
            }
            catch //hvis bolig ID'et ikke er et tal, så vises en fejlbesked
            {
                MessageBox.Show("Indtast kun tal i bolig ID feltet");
            }
        }

        //Knap som viser felter relevant for at oprette en ny bolig
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

            lblLejemaal.Visible = false;
            lblAdresse.Visible = true; //
            lblPostNr.Visible = true; //
            lblBy.Visible = true; //
            lblBoligID.Visible = true; //
            lblMinKvm.Visible = false;
            lblMaksKvm.Visible = false;
            lblBoligType.Visible = true; //
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

            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);

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
            lblBoligID.Visible = true; //
            lblMinKvm.Visible = true; //
            lblMaksKvm.Visible = true; //
            lblBoligType.Visible = false;
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

        //Knap som viser felter relevant for at opdatere en eksisterende bolig
        private void btnVisBUpdate_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);

            btnCreateB.Visible = false;
            btnReadB.Visible = false;
            btnUpdateB.Visible = true;
            btnDeleteB.Visible = false;

            lblLejemaal.Visible = true;
            lblAdresse.Visible = true; //
            lblPostNr.Visible = false;
            lblBy.Visible = false;
            lblBoligID.Visible = true; //
            lblMinKvm.Visible = false;
            lblMaksKvm.Visible = false;
            lblBoligType.Visible = false;
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

        //Knap som viser felter relevant for at slette en eksisterende bolig
        private void btnVisDBolig_Click(object sender, EventArgs e)
        {
            panelContainer.Visible = true;

            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
            dgvBoligInfo.DataSource = tableConn.tableBinder(sqlS2);
            
            btnCreateB.Visible = false;
            btnReadB.Visible = false;
            btnUpdateB.Visible = false;
            btnDeleteB.Visible = true;
            
            lblLejemaal.Visible = true; //
            lblAdresse.Visible = false;
            lblPostNr.Visible = false;
            lblBy.Visible = false;
            lblBoligID.Visible = false;
            lblMinKvm.Visible = false;
            lblMaksKvm.Visible = false;
            lblBoligType.Visible = false;
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
