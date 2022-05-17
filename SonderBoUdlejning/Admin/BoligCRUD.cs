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
            string postNr = comboBoxPostNr.SelectedItem.ToString(); //Tager inputtet fra postNr comboboxen
            string bId = tbBoligID.Text; //Tager inputtet fra boligID textboxen

            //Tjekker om en af felterne er tomme
            if ((string.IsNullOrEmpty(adresse)) || (string.IsNullOrEmpty(bId)))
            {
                MessageBox.Show("Indtast venligst både en adresse og et bolig ID!");
                return;
            }

            //Tjekker inputtene for længde og ugyldige tegn
            if ((BoligInputCheck.AdresseCheck(adresse) == true) && (BoligInputCheck.BIdCheck(bId) == true))
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
            //Tager adresse input checker det for tegn og længde
            string adresse = tbAdresse.Text;
            bool adresseValid = BoligInputCheck.AdresseCheck(adresse);

            //Tager det valgte postNr fra comboboxen og tildeler det en string variable
            string postNr = comboBoxPostNr.SelectedItem.ToString();

            //Tager bId input og tjekker det for ugyldige tegn
            string bId = tbBoligID.Text; //
            bool bIdValid = BoligInputCheck.BIdCheck(bId);

            //Hvis bId inputtet ikke er tomt, så bruges bId til at finde dens bType
            string bType = "";
            if (!string.IsNullOrEmpty(bId))
                bType = tbBoligType.Text = tableConn.textBoxBinder($"SELECT bType FROM BoligInfo WHERE bId = {bId}");
            
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

            //Sætter tabControl fokus til Bolig tabellen
            tabControl1.SelectedTab = BoligPage;

            //Laver et objekt af BoligFacade klassen
            BoligFacade readTilLeje = new BoligFacade();

            //Hvis alle inputtet er gyldige, så kaldes metoden readTilLeje
            if ((adresseValid == true) && (bIdValid == true) && (minKvmValid == true) && (maksKvmValid == true) && (minLejePrisValid == true) && (maksLejePrisValid == true))
            {
                //Kalder en speciel read metode for bolig til leje
                readTilLeje.rBoligTilLeje(adresse, postNr, bId, bType, minKvm, maksKvm, minLejePris, maksLejePris);

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
            string adresse = tbAdresse.Text; //Tager inputtet fra adresse textboxen
            string bId = tbBoligID.Text; //Tager inputtet fra boligID textboxen

            //Tjekker om en af felterne er tomme
            if ((string.IsNullOrEmpty(adresse)) || (string.IsNullOrEmpty(bId)))
            {
                MessageBox.Show("Indtast venligst både en adresse og et bolig ID!");
                return;
            }

            string postNr = "";
            string pId = "";
            string indflytDato = "";
            string udflytDato = "";

            //Tjekker inputtene for længde og ugyldige tegn
            if ((BoligInputCheck.AdresseCheck(adresse) == true) && (BoligInputCheck.BIdCheck(bId) == true))
            {
                //Finder postNr, pId, indflytDato og udflytDato fra Bolig tabellen ved hjælp af adressen
                postNr = tableConn.textBoxBinder($"SELECT postNr FROM Bolig WHERE adresse = '{adresse}'");
                pId = tableConn.textBoxBinder($"SELECT pId FROM Bolig WHERE adresse = '{adresse}'");
                indflytDato = BoligInputCheck.indDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), indflytDato, 105) FROM Bolig WHERE adresse = '{adresse}'");
                udflytDato = BoligInputCheck.udDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), udflytDato, 105) FROM Bolig WHERE adresse = '{adresse}'");

                //Opdaterer bolig ID'et i Bolig tabellen
                BoligFacade UpdateBolig = new BoligFacade();
                UpdateBolig.uBolig(adresse, postNr, bId, pId, indflytDato, udflytDato);
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
            //ADVARSEL: Hvis man ikke skriver hele adressen og kun skriver dele af den, så slettes alle boliger som har den tekstdel et sted i sin adresse
            //For eks. så hedder alle adresser "Fakevej" efterfulgt af et tal og hvis man skrev "Fake" og trykkede slet, så ville Bolig tabellen blive tømt
            //Hvorfor sker det? Fordi SQL Querien ser såden her ud: sqlS += $" AND adresse LIKE '%{adresse}%'"; Dog vil denne del kun blive tilføjet til Querien hvis
            //adresse inputtet er hverken tom eller null, men der vil være noget i denne delete funktion.

            string adresse = tbAdresse.Text; //Tager inputtet fra adresse textboxen

            //Tjekker om adresse feltet er tomt
            if ((string.IsNullOrEmpty(adresse)))
            {
                MessageBox.Show("Indtast venligst både en adresse og et bolig ID!");
                return;
            }

            //Tjekker inputtene for længde og ugyldige tegn
            if ((BoligInputCheck.AdresseCheck(adresse) == true))
            {
                //Sletter bolig fra Bolig tabellen
                BoligFacade DeleteBolig = new BoligFacade();
                DeleteBolig.dBolig(adresse);
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
            try
            {
                //Hvis bolig ID'et ikke er tomt, så kaldes metoden textBoxBinder og resultatet vises i bolig type tekstboxen
                if (!string.IsNullOrEmpty(tbBoligID.Text))
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

            lblAdresse.Visible = true;
            lblPostNr.Visible = false;
            lblBy.Visible = false;
            lblBoligID.Visible = false;

            tbAdresse.Visible = true;
            comboBoxPostNr.Visible = false;
            tbBy.Visible = false;
            tbBoligID.Visible = false;
        }

        
    }
}
