using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SonderBoUdlejning.InputCheck;
using SonderBoUdlejning.personCRUD;
using SonderBoUdlejning.TildelBoligSystems;
using SonderBoUdlejning.VentelisteSystems;
using SonderBoUdlejning.BoligSystems;

namespace SonderBoUdlejning.Admin
{
    public partial class TildelBolig : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();

        //Standard SQL Query, som henter alle boliger fra databasen, som er tilgængelige
        string sqlS1 = "SELECT * FROM Bolig WHERE (pId IS NULL AND indflytDato IS NULL AND udflytDato IS NULL)";

        //Standard SQL Query, som henter ventelisten sorteret efter dato
        string sqlS2 = "SELECT * FROM Venteliste ORDER BY signUpDato ASC";

        public TildelBolig()
        {
            InitializeComponent();
        }

        private void TildelBolig_Load(object sender, EventArgs e)
        {
            //Indlæser boliger
            dgvBolig.DataSource = tableConn.tableBinder(sqlS1);

            //Indlæser venteliste
            dgvVenteliste.DataSource = tableConn.tableBinder(sqlS2);

            //Indlæser liste over måneder
            string[] comboBoxListMonth;
            comboBoxListMonth = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Take(12).ToArray();
            combIndflytMåned.Items.AddRange(comboBoxListMonth);

            //Indlæser liste over de næste 22 år
            combIndflytÅr.DataSource = Enumerable.Range(DateTime.Now.Year, DateTime.Now.Year - 2000 + 1).ToList();
            combIndflytÅr.SelectedItem = DateTime.Now.Year;

            //Sætter bolig ID textboxen i fokus, så man kan skrive med det samme
            tbBID.Focus();
        }

        private void tbBID_TextChanged(object sender, EventArgs e)
        {
            string adresse = ""; //Sætter adresse til at være tom
            string postNr = ""; //Sætter postnummer til at være tom
            string bId = tbBID.Text; //Tager input fra textboxen
            string pId = ""; //Sætter person ID til at være tom
            string indDato = ""; //Sætter indflytningsdato til at være tom
            string udDato = ""; //Sætter udflytningsdato til at være tom
            string sqlTemplate = $"SELECT * FROM Bolig WHERE 1=1"; //Definere standard SQL Query
            string bType = "";
            string minKvm = "";
            string maksKvm = "";
            string minLejePris = "";
            string maksLejePris = "";
            bool tilLeje = true;

            BoligFacade readBolig = new BoligFacade();

            //While loop der kører hver gang der ændres i textboxen
            while (true)
            {
                //Hvis der ikke er noget i textboxen, så skjules pId panelet og bolig dataGridViewet genstartes
                if (string.IsNullOrEmpty(bId))
                {
                    panelPid.Visible = false;
                    dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
                    break; //Stopper while loop, hvis der ikke er noget i textboxen
                }
                
                //Hvis der er noget i textboxen, så tjekkes bolig ID for længde og karaktere
                if ((BoligInputCheck.BIdCheck(bId) == true))
                {
                    panelPid.Visible = true; //Viser pId panelet
                    readBolig.tempRBolig(sqlTemplate, adresse, postNr, bId, pId, indDato, udDato, bType, minKvm, maksKvm, minLejePris, maksLejePris, tilLeje); //Indlæser bolig data
                    dgvBolig.DataSource = tableConn.tableBinder(readBolig.rBoligQuery); //Indlæser bolig data i bolig dataGridView
                }
                else
                {
                    ErrorMessage.errorMessage(); //Viser fejlmeddelelse
                }
                break; //Stopper while loop
            }
            
        }

        private void btnFindMedlemsInfo_Click(object sender, EventArgs e)
        {
            string adresse = ""; //Sætter adresse til at være tom
            string postNr = ""; //Sætter postnummer til at være tom
            string bId = tbBID.Text; //Tager input fra textboxen
            string pId = tbPID.Text; //Tager input fra textboxen
            string dummyPId = ""; //Sætter dummy person ID til at være tom
            string indDato = ""; //Sætter indflytningsdato til at være tom
            string udDato = ""; //Sætter udflytningsdato til at være tom
            string signUpDato = ""; //Sætter signup dato til at være tom
            string sqlTemplate = $"SELECT * FROM Bolig WHERE 1=1"; //Definere standard SQL Query
            string bType = ""; //Sætter bolig type til at være tom
            string minKvm = ""; //Sætter minimum kvadratmeter til at være tom
            string maksKvm = ""; //Sætter maksimum kvadratmeter til at være tom
            string minLejePris = ""; //Sætter minimum lejepris til at være tom
            string maksLejePris = ""; //Sætter maksimum lejepris til at være tom
            bool tilLeje = true; //Sætter til leje til at være true

            //Sætter variabler til at holde på kolonne navne
            string navnColumn = "fNavn"; 
            string mailColumn = "pMail";
            string tlfColumn = "pTlf";

            string navn = ""; //Sætter navn til at være tom
            string mail = ""; //Sætter mail til at være tom
            string tlf = ""; //Sætter tlf til at være tom
            bool medlem = false; //Sætter medlem til at være false
            bool erBeboer = false; //Sætter erBeboer til at være false
            bool alt = false; //Sætter alt til at være false

            BoligFacade readBolig = new BoligFacade();
            vFacade readPVdgv = new vFacade();
            PersonFacade pRead = new PersonFacade();

            //Tjekker om der er noget i textboxen
            if (string.IsNullOrEmpty(pId))
            {
                panelMedlemsinfo.Visible = false;
                panelØnskerLejlighed.Visible = false;
                dgvVenteliste.DataSource = tableConn.tableBinder(sqlS2);
                tbMedlemsNavn.Text = "";
                tbMedlemsEmail.Text = "";
                tbMedlemsTLF.Text = "";
                return;
            }
            else
            {
                panelMedlemsinfo.Visible = true;
                panelØnskerLejlighed.Visible = true;
            }

            //Tjekker om bolig ID eller person ID er tom
            if ((string.IsNullOrEmpty(bId)) || (string.IsNullOrEmpty(pId)))
            {
                MessageBox.Show("Indtast venligst både et bolig ID og et person ID!");
                return;
            }

            //Tjekker bolig ID og person ID for længde og ugyldige karaktere
            if ((BoligInputCheck.BIdCheck(bId) == true) && (PersonInputCheck.PIdCheck(pId) == true))
            {
                //sortere Bolig dgv
                readBolig.tempRBolig(sqlTemplate, adresse, postNr, bId, dummyPId, indDato, udDato, bType, minKvm, maksKvm, minLejePris, maksLejePris, tilLeje);
                dgvBolig.DataSource = tableConn.tableBinder(readBolig.rBoligQuery);

                //sortere Venteliste dgv
                readPVdgv.ReadVenteListe(dummyPId, bId, signUpDato);
                dgvVenteliste.DataSource = tableConn.tableBinder(readPVdgv.ReadVente);

                //Fylder navn tekstboksen
                pRead.ReadPerson(navnColumn, pId, navn, mail, tlf, medlem, erBeboer, alt);
                tbMedlemsNavn.Text = tableConn.textBoxBinder(pRead.ReadQuery);

                //Fylder mail tekstboksen  
                pRead.ReadPerson(mailColumn, pId, navn, mail, tlf, medlem, erBeboer, alt);
                tbMedlemsEmail.Text = tableConn.textBoxBinder(pRead.ReadQuery);

                //Fylder tlf tekstboksen
                pRead.ReadPerson(tlfColumn, pId, navn, mail, tlf, medlem, erBeboer, alt);
                tbMedlemsTLF.Text = tableConn.textBoxBinder(pRead.ReadQuery);

                //Sætter checkboxen i fokus
                ckbJaTilLejlighed.Focus();
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }

        //Event metode som kører når der trykkes på checkboxen
        private void ckbJaTilLejlighed_CheckedChanged(object sender, EventArgs e)
        {
            string bId = tbBID.Text; //Tager input fra textboxen
            string[] comboBoxListAdresser; //Laver et string array til at holde på alle adresser

            //Hvis checkboxen er markeret
            if (ckbJaTilLejlighed.Checked == true)
            {
                //Vis det sidste panel og adresse comboboxen
                panelUdskrivLejekontrakt.Visible = true;
                combAdresser.Visible = true;

                //Tjekker om bolig ID er tom
                if (string.IsNullOrEmpty(bId))
                {
                    MessageBox.Show("Indtast venligst et bolig ID!");
                    return;
                }

                //Tjekker bolig ID for længde og ugyldige karaktere
                if ((BoligInputCheck.BIdCheck(bId) == true))
                {
                    //Sikre bolig ID forbliver det samme
                    bId = tableConn.textBoxBinder($"SELECT bId FROM Bolig WHERE bId = {bId}");

                    //Fylder comboboxen med alle tilgængelige adresser
                    comboBoxListAdresser = tableConn.comboBoxBinder($"SELECT adresse FROM Bolig WHERE (pId IS NULL OR udflytDato IS NOT NULL) AND bId = {bId}").ToArray();
                    combAdresser.Items.AddRange(comboBoxListAdresser);
                }
                else
                {
                    ErrorMessage.errorMessage(); //Viser fejlmeddelelse
                }
            }

            //Hvis checkboxen ikke er markeret
            else if (ckbJaTilLejlighed.Checked == false)
            {
                panelUdskrivLejekontrakt.Visible = false;
                combAdresser.Visible = false;
            }
        }

        private void btnUdskrivLejekontrakt_Click(object sender, EventArgs e)
        {
            string pId = tbPID.Text; //Tager input fra person ID textboxen
            string bId = tbBID.Text; //Tager input fra bolig ID textboxen
            string lejePris = ""; //Pladsholder variabel for lejePris
            string lejerNavn = tbMedlemsNavn.Text; //Tager input fra navn textboxen
            string lejerMail = tbMedlemsEmail.Text; //Tager input fra mail textboxen
            string lejerTlf = tbMedlemsTLF.Text; //Tager input fra tlf textboxen
            bool erBeboer; //Pladsholder variabel for erBeboer
            string adresse = combAdresser.SelectedItem.ToString(); //Tager den valgte adresse fra comboboxen

            string postNr = ""; //Pladsholder variabel for postNr
            string by = ""; //Pladsholder variabel for by

            string startDato = ""; //Pladsholder variabel for startDato

            //Hvis månedstalet er mindre en 10, så sættes et 0 foran
            if ((combIndflytMåned.SelectedIndex + 1) < 10)  
                startDato = $"01-0{combIndflytMåned.SelectedIndex + 1}-{combIndflytÅr.SelectedItem}";
            else //Collections starter fra index 0, så +1 for at få det rigtige månedstal 
                startDato = $"01-{combIndflytMåned.SelectedIndex + 1}-{combIndflytÅr.SelectedItem}";

            string slutDato = null;

            int checkForpId;

            if ((string.IsNullOrEmpty(bId)) || (string.IsNullOrEmpty(lejerNavn)) || (string.IsNullOrEmpty(pId)))
            {
                MessageBox.Show("Indtast venligst både et bolig ID og et person ID!");
                return;
            }
            if ((BoligInputCheck.BIdCheck(bId) == true) && (PersonInputCheck.PIdCheck(pId) == true))
            {
                checkForpId = Convert.ToInt32(tableConn.textBoxBinder($"SELECT COUNT(pId) FROM Bolig WHERE pId = {pId}"));

                if (checkForpId > 0)
                {
                    MessageBox.Show("Der er allerede en beboer med det pId i systemet");
                    return;
                }
                else
                {
                    //Finder postNr ved hjælp af adresse
                    postNr = tableConn.textBoxBinder($"SELECT postNr FROM Bolig WHERE adresse = '{adresse}'");
                    
                    //Finder by ved hjælp af postNr
                    by = tableConn.textBoxBinder($"SELECT byNavn FROM PostNr WHERE postNr = '{postNr}'");

                    //Finder lejePris ved hjælp af bolig ID
                    lejePris = tableConn.textBoxBinder($"SELECT lejePris FROM BoligInfo WHERE bId = {bId}");

                    //Nedenstående MessageBox bruges til debugging
                    //MessageBox.Show($"{lejerNavn}\n{lejerMail}\n{lejerTlf}\n{adresse}\n{postNr}\n{by}\n{startDato}");
                    
                    //Lejekontrakt printes
                    LejekontraktFacade lejekontrakt = new LejekontraktFacade();
                    lejekontrakt.PrintKontrakt(lejerNavn, lejePris, adresse, postNr, by, startDato, bId);

                    //Personen opdateres i Person tabellen
                    PersonFacade pUpdate = new PersonFacade();
                    erBeboer = true;
                    pId = tableConn.textBoxBinder($"SELECT pId FROM Person WHERE fNavn = '{lejerNavn}'");
                    pUpdate.UpdatePerson(lejerNavn, lejerMail, lejerTlf, pId, erBeboer);

                    //Boligen opdateres i Bolig tabellen
                    BoligFacade boligUpdate = new BoligFacade();
                    boligUpdate.uBolig(adresse, postNr, bId, pId, startDato, slutDato);
                    dgvBolig.DataSource = tableConn.tableBinder(sqlS1);

                    //Sletter personen fra ventelisten
                    vFacade vDelete = new vFacade();
                    vDelete.RemoveFromList(pId, bId);
                    dgvVenteliste.DataSource = tableConn.tableBinder(sqlS2);
                }
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }
    }
}
