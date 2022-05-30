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
using SonderBoUdlejning.TildelLejemaalSystems;
using SonderBoUdlejning.VentelisteSystems;
using SonderBoUdlejning.LejemaalSystems;

namespace SonderBoUdlejning.Admin
{
    public partial class TildelLejemaal : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();

        //Standard SQL Query, som henter alle boliger fra databasen, som er tilgængelige
        string sqlS1 = "SELECT lejemaalNr AS 'Lejemål Nr.', adresse AS 'Adresse', postNr AS 'Post Nr.', Lid AS 'Lejemålstype ID', pId AS 'Person ID', indflytDato AS 'Indflytningsdato', udflytDato AS 'Udflytningsdato' FROM Lejemaal WHERE (pId IS NULL AND indflytDato IS NULL AND udflytDato IS NULL)";

        //Standard SQL Query, som henter ventelisten sorteret efter dato
        string sqlS2 = "SELECT pId AS 'Person ID', Lid AS 'Lejemålstype ID', signUpDato AS 'Opskrivelsesdato' FROM Venteliste ORDER BY signUpDato ASC";

        public TildelLejemaal()
        {
            InitializeComponent();
        }

        private void TildelLejemaal_Load(object sender, EventArgs e)
        {
            //Indlæser boliger
            dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1);

            //Indlæser venteliste
            dgvVenteliste.DataSource = tableConn.tableBinder(sqlS2);

            dgvLejemaal.RowHeadersVisible = false;
            dgvLejemaal.BorderStyle = BorderStyle.FixedSingle;
            dgvLejemaal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLejemaal.RowTemplate.Height = 30;
            dgvLejemaal.RowTemplate.DividerHeight = 1;
            dgvLejemaal.GridColor = Color.Black;
            dgvLejemaal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
             
            dgvVenteliste.RowHeadersVisible = false;
            dgvVenteliste.BorderStyle = BorderStyle.FixedSingle;
            dgvVenteliste.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVenteliste.RowTemplate.Height = 30;
            dgvVenteliste.RowTemplate.DividerHeight = 1;
            dgvVenteliste.GridColor = Color.Black;
            dgvVenteliste.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
             
            //Indlæser liste over måneder
            string[] comboListMonth;
            comboListMonth = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Take(12).ToArray();
            comboIndflytMonth.Items.AddRange(comboListMonth);

            //Indlæser liste over de næste 22 år
            comboIndflytYear.Items.Add("");
            for (int year = DateTime.Now.Year; year < DateTime.Now.Year + 50; year++)
            {
                comboIndflytYear.Items.Add(year);
            }

            //Sætter lejemål Nr textboxen i fokus, så man kan skrive med det samme
            tbLid.Focus();
        }

        private void tbLid_TextChanged(object sender, EventArgs e)
        {
            string adresse = ""; //Sætter adresse til at være tom
            string postNr = ""; //Sætter postnummer til at være tom
            string Lid = tbLid.Text; //Tager input fra textboxen
            string pId = ""; //Sætter person ID til at være tom
            string indDato = ""; //Sætter indflytningsdato til at være tom
            string udDato = ""; //Sætter udflytningsdato til at være tom

            //Definerer standard SQL Query
            string sqlTemplate = $"SELECT lejemaalNr AS 'Lejemål Nr.', adresse AS 'Adresse', postNr AS 'Post Nr.', Lid AS 'Lejemålstype ID', pId AS 'Person ID', indflytDato AS 'Indflytningsdato', udflytDato AS 'Udflytningsdato' FROM Lejemaal WHERE 1=1"; 
            
            string lType = "";
            string minKvm = "";
            string maksKvm = "";
            string minLejePris = "";
            string maksLejePris = "";
            bool tilLeje = true;

            bool LidValid = true;

            string signUpDato = "";

            string[] comboListPostNr;

            LejemaalFacade readLejemaal = new LejemaalFacade();
            VentelisteFacade readVenteliste = new VentelisteFacade();

            //While loop der kører hver gang der ændres i textboxen
            while (true)
            {
                //Hvis der ikke er noget i textboxen, så skjules pId panelet og lejemål dataGridViewet genstartes
                if (string.IsNullOrEmpty(Lid))
                {
                    panelPid.Visible = false;
                    dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1);
                    break; //Stopper while loop, hvis der ikke er noget i textboxen
                }

                LidValid = LejemaalInputCheck.LidCheck(Lid);

                //Hvis der er noget i textboxen, så tjekkes lejemål Nr for længde og karaktere
                if ((LidValid == true))
                {
                    panelPid.Visible = true; //Viser pId panelet

                    comboListPostNr = tableConn.comboBoxBinder($"SELECT DISTINCT(postNr) FROM Lejemaal WHERE Lid = {Lid}").ToArray();
                    comboPostNr.Items.AddRange(comboListPostNr);

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

                    readLejemaal.rLejemaal(sqlTemplate, adresse, postNr, Lid, pId, indDato, udDato, lType, minKvm, maksKvm, minLejePris, maksLejePris, tilLeje); //Indlæser lejemål data
                    dgvLejemaal.DataSource = tableConn.tableBinder(readLejemaal.rLejemaalQuery); //Indlæser lejemål data i lejemål dataGridView

                    readVenteliste.rVenteliste(pId, Lid, signUpDato); //Indlæser venteliste
                    dgvVenteliste.DataSource = tableConn.tableBinder(readVenteliste.readVQuery);
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
            string Lid = tbLid.Text; //Tager input fra textboxen
            string pId = tbPId.Text; //Tager input fra textboxen
            string dummyPId = ""; //Sætter dummy person ID til at være tom
            string indDato = ""; //Sætter indflytningsdato til at være tom
            string udDato = ""; //Sætter udflytningsdato til at være tom
            string signUpDato = ""; //Sætter signup dato til at være tom

            //Definerer standard SQL Query
            string sqlTemplate = $"SELECT lejemaalNr AS 'Lejemål Nr.', adresse AS 'Adresse', postNr AS 'Post Nr.', Lid AS 'Lejemålstype ID', pId AS 'Person ID', indflytDato AS 'Indflytningsdato', udflytDato AS 'Udflytningsdato' FROM Lejemaal WHERE 1=1";

            string lType = ""; //Sætter lejemål type til at være tom
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

            LejemaalFacade readLejemaal = new LejemaalFacade();
            VentelisteFacade readPVdgv = new VentelisteFacade();
            PersonFacade pRead = new PersonFacade();

            //Tjekker om der er noget i textboxen
            if (string.IsNullOrEmpty(pId))
            {
                panelMedlemsinfo.Visible = false;
                panelØnskerLejlighed.Visible = false;
                dgvVenteliste.DataSource = tableConn.tableBinder(sqlS2);
                tbMedlemsNavn.Text = "";
                tbMedlemsEmail.Text = "";
                tbMedlemsTlf.Text = "";
                return;
            }
            else
            {
                panelMedlemsinfo.Visible = true;
                panelØnskerLejlighed.Visible = true;
            }

            //Tjekker om lejemål Nr eller person ID er tom
            if ((string.IsNullOrEmpty(Lid)) || (string.IsNullOrEmpty(pId)))
            {
                MessageBox.Show("Indtast venligst både et lejemål Nr og et person ID!");
                return;
            }

            bool LidValid = LejemaalInputCheck.LidCheck(Lid);
            bool pIdValid = PersonInputCheck.PIdCheck(pId);

            //Tjekker lejemål Nr og person ID for længde og ugyldige karaktere
            if ((LidValid == true) && (pIdValid == true))
            {
                //sortere Lejemaal dgv
                readLejemaal.rLejemaal(sqlTemplate, adresse, postNr, Lid, dummyPId, indDato, udDato, lType, minKvm, maksKvm, minLejePris, maksLejePris, tilLeje);
                dgvLejemaal.DataSource = tableConn.tableBinder(readLejemaal.rLejemaalQuery);

                //sortere Venteliste dgv
                readPVdgv.rVenteliste(dummyPId, Lid, signUpDato);
                dgvVenteliste.DataSource = tableConn.tableBinder(readPVdgv.readVQuery);

                
                //Fylder navn tekstboksen
                pRead.rPerson(navnColumn, pId, navn, mail, tlf, medlem, erBeboer, alt);
                tbMedlemsNavn.Text = tableConn.textBoxBinder(pRead.readPQuery);

                if (tableConn.textBoxBinder(pRead.readPQuery) == null)
                {
                    MessageBox.Show("Beboer findes ikke i databasen");
                }
                else
                {
                    //Fylder mail tekstboksen  
                    pRead.rPerson(mailColumn, pId, navn, mail, tlf, medlem, erBeboer, alt);
                    tbMedlemsEmail.Text = tableConn.textBoxBinder(pRead.readPQuery);

                    //Fylder tlf tekstboksen
                    pRead.rPerson(tlfColumn, pId, navn, mail, tlf, medlem, erBeboer, alt);
                    tbMedlemsTlf.Text = tableConn.textBoxBinder(pRead.readPQuery);

                    //Sætter checkboxen i fokus
                    ckbJaTilLejlighed.Focus();
                }
                
            }
            else
            {
                ErrorMessage.errorMessage(); //Viser fejlmeddelelse
            }
        }

        //Event metode som kører når der trykkes på checkboxen
        private void ckbJaTilLejlighed_CheckedChanged(object sender, EventArgs e)
        {
            string Lid = tbLid.Text; //Tager input fra textboxen
            string postNr = "";
            string[] comboListAdresser; //Laver et string array til at holde på alle adresser
            bool LidValid = true;

            //Hvis checkboxen er markeret
            if (ckbJaTilLejlighed.Checked == true)
            {
                //Vis det sidste panel og adresse comboboxen
                panelUdskrivLejekontrakt.Visible = true;
                comboAdresser.Visible = true;

                //Tjekker om lejemål Nr er tom
                if (string.IsNullOrEmpty(Lid))
                {
                    MessageBox.Show("Indtast venligst et lejemål Nr!");
                    return;
                }

                LidValid = LejemaalInputCheck.LidCheck(Lid);

                //Tjekker lejemål Nr for længde og ugyldige karaktere
                if ((LidValid == true))
                {
                    //Sikre lejemål Nr forbliver det samme
                    Lid = tableConn.textBoxBinder($"SELECT Lid FROM Lejemaal WHERE Lid = {Lid}");

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

                    //Fylder comboboxen med alle tilgængelige adresser
                    if (comboPostNr.SelectedItem == null)
                        MessageBox.Show("Vælg venligst et postnummer!");
                    else
                    {
                        comboListAdresser = tableConn.comboBoxBinder($"SELECT adresse FROM Lejemaal WHERE (pId IS NULL OR udflytDato IS NOT NULL) AND Lid = {Lid} AND postNr = {postNr}").ToArray();
                        comboAdresser.Items.AddRange(comboListAdresser);
                    }
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
                comboAdresser.Visible = false;
            }
        }

        private void btnUdskrivLejekontrakt_Click(object sender, EventArgs e)
        {
            string pId = tbPId.Text; //Tager input fra person ID textboxen
            string Lid = tbLid.Text; //Tager input fra lejemål Nr textboxen
            string lejePris = ""; //Pladsholder variabel for lejePris
            string lejerNavn = tbMedlemsNavn.Text; //Tager input fra navn textboxen
            string lejerMail = tbMedlemsEmail.Text; //Tager input fra mail textboxen
            string lejerTlf = tbMedlemsTlf.Text; //Tager input fra tlf textboxen
            bool erBeboer; //Pladsholder variabel for erBeboer
            
            string lejemaalNr = "";

            string postNr = ""; //Pladsholder variabel for postNr
            string by = ""; //Pladsholder variabel for by

            string startDato = ""; //Pladsholder variabel for startDato

            //Hvis månedstalet er mindre en 10, så sættes et 0 foran
            if ((comboIndflytMonth.SelectedIndex + 1) < 10)  
                startDato = $"01-0{comboIndflytMonth.SelectedIndex + 1}-{comboIndflytYear.SelectedItem}";
            else //Collections starter fra index 0, så +1 for at få det rigtige månedstal 
                startDato = $"01-{comboIndflytMonth.SelectedIndex + 1}-{comboIndflytYear.SelectedItem}";
            bool indflytDatoValid = true;//

            string slutDato = null;

            int checkForpId;

            try
            {
                string adresse = comboAdresser.SelectedItem.ToString(); //Tager den valgte adresse fra comboboxen
                
                if ((string.IsNullOrEmpty(Lid)) || (string.IsNullOrEmpty(lejerNavn)) || (string.IsNullOrEmpty(pId)))
                {
                    MessageBox.Show("Indtast venligst både et lejemål Nr og et person ID!");
                    return;
                }

                bool LidValid = LejemaalInputCheck.LidCheck(Lid);
                bool pIdValid = PersonInputCheck.PIdCheck(pId);

                try
                {
                    indflytDatoValid = LejemaalInputCheck.indflytDato(startDato);
                }
                catch
                {
                    indflytDatoValid = false;
                }

                if ((LidValid == true) && (pIdValid == true) && (indflytDatoValid == true))
                {
                    checkForpId = Convert.ToInt32(tableConn.textBoxBinder($"SELECT COUNT(pId) FROM Lejemaal WHERE pId = {pId}"));

                    if (checkForpId > 0)
                    {
                        MessageBox.Show("Der er allerede en beboer med det pId i systemet");
                        return;
                    }
                    else
                    {
                        //Finder postNr ved hjælp af adresse
                        postNr = tableConn.textBoxBinder($"SELECT postNr FROM Lejemaal WHERE adresse = '{adresse}'");

                        //Finder by ved hjælp af postNr
                        by = tableConn.textBoxBinder($"SELECT byNavn FROM PostNr WHERE postNr = '{postNr}'");

                        //Finder lejePris ved hjælp af lejemål Nr
                        lejePris = tableConn.textBoxBinder($"SELECT lejePris FROM LejemaalsInfo WHERE Lid = {Lid}");

                        lejemaalNr = tableConn.textBoxBinder($"SELECT lejemaalNr FROM Lejemaal WHERE adresse = '{adresse}' AND postNr = '{postNr}' AND Lid = {Lid}");

                        //Nedenstående MessageBox bruges til debugging
                        //MessageBox.Show($"{lejerNavn}\n{lejerMail}\n{lejerTlf}\n{adresse}\n{postNr}\n{by}\n{startDato}");

                        //Lejekontrakt printes
                        LejekontraktFacade lejekontrakt = new LejekontraktFacade();
                        lejekontrakt.PrintKontrakt(lejerNavn, lejePris, adresse, postNr, by, startDato, Lid);

                        //Personen opdateres i Person tabellen
                        PersonFacade pUpdate = new PersonFacade();
                        erBeboer = true;
                        pId = tableConn.textBoxBinder($"SELECT pId FROM Person WHERE fNavn = '{lejerNavn}'");
                        pUpdate.uPerson(lejerNavn, lejerMail, lejerTlf, pId, erBeboer);

                        //Lejemaalen opdateres i Lejemaal tabellen
                        LejemaalFacade lejemaalUpdate = new LejemaalFacade();
                        lejemaalUpdate.uLejemaal(lejemaalNr, adresse, postNr, Lid, pId, startDato, slutDato);
                        dgvLejemaal.DataSource = tableConn.tableBinder(sqlS1);

                        //Sletter personen fra ventelisten
                        VentelisteFacade vDelete = new VentelisteFacade();
                        vDelete.RemoveFromList(pId, Lid);
                        dgvVenteliste.DataSource = tableConn.tableBinder(sqlS2);
                    }
                }
                else
                {
                    ErrorMessage.errorMessage(); //Viser fejlmeddelelse
                }
            }
            catch
            {
                MessageBox.Show("Husk at vælge en adresse, måned og år");
            }
        }
    }
}
