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
        string sqlS1 = "SELECT * FROM Bolig WHERE (pId IS NULL AND indflytDato IS NULL AND udflytDato IS NULL)";
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
            combIndflytMåned.DataSource = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Take(12).ToList();

            //Indlæser liste over de næste 22 år
            combIndflytÅr.DataSource = Enumerable.Range(DateTime.Now.Year, DateTime.Now.Year - 2000 + 1).ToList();
            combIndflytÅr.SelectedItem = DateTime.Now.Year;

            tbBID.Focus();
        }

        private void tbBID_TextChanged(object sender, EventArgs e)
        {
            string adresse = "";
            string postNr = "";
            string bId = tbBID.Text;
            string pId = "";
            string indDato = "";
            string udDato = "";

            BoligFacade readBolig = new BoligFacade();

            while (true)
            {
                if (!string.IsNullOrEmpty(bId))
                {
                    panelPid.Visible = true;
                    if ((BoligInputCheck.BIdCheck(bId) == true))
                    {
                        readBolig.rBolig(adresse, postNr, bId, pId, indDato, udDato);
                        dgvBolig.DataSource = tableConn.tableBinder(readBolig.rBoligQuery);
                    }
                    else
                    {
                        MessageBox.Show(ErrorMessage.errorMessage());
                        ErrorMessage.ErrorList.Clear();
                        ErrorMessage.resetInjectedSQL();
                    }
                    break;
                }
                else if (string.IsNullOrEmpty(bId))
                {
                    panelPid.Visible = false;
                    dgvBolig.DataSource = tableConn.tableBinder(sqlS1);
                    break;
                }
            }
            
        }

        private void btnFindMedlemsInfo_Click(object sender, EventArgs e)
        {
            string adresse = "";
            string postNr = "";
            string bId = tbBID.Text;
            string pId = tbPID.Text;
            string dummyPId = "";
            string indDato = "";
            string udDato = "";
            string signUpDato = "";

            string navnColumn = "fNavn";
            string mailColumn = "pMail";
            string tlfColumn = "pTlf";
            
            string navn = "";
            string mail = "";
            string tlf = "";
            bool medlem = false;
            bool erBeboer = false;
            bool alt = false;

            BoligFacade readBolig = new BoligFacade();
            vFacade readPVdgv = new vFacade();
            PersonFacade pRead = new PersonFacade();

            if (!string.IsNullOrEmpty(pId))
            {
                panelMedlemsinfo.Visible = true;
                panelØnskerLejlighed.Visible = true;
                if ((!string.IsNullOrEmpty(bId)) && (!string.IsNullOrEmpty(pId)))
                {
                    if ((BoligInputCheck.BIdCheck(bId) == true) && (PersonInputCheck.PIdCheck(pId) == true))
                    {
                        //sortere Bolig dgv
                        readBolig.rBolig(adresse, postNr, bId, dummyPId, indDato, udDato);
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

                        ckbJaTilLejlighed.Focus();
                    }
                    else
                    {
                        MessageBox.Show(ErrorMessage.errorMessage());
                        ErrorMessage.ErrorList.Clear();
                        ErrorMessage.resetInjectedSQL();
                    }
                }
                else
                {
                    MessageBox.Show("Indtast venligst både et bolig ID og et person ID!");
                }

            }
            else if (string.IsNullOrEmpty(pId))
            {
                panelMedlemsinfo.Visible = false;
                panelØnskerLejlighed.Visible = false;
                dgvVenteliste.DataSource = tableConn.tableBinder(sqlS2);
                tbMedlemsNavn.Text = "";
                tbMedlemsEmail.Text = "";
                tbMedlemsTLF.Text = "";
            }
        }

        private void ckbJaTilLejlighed_CheckedChanged(object sender, EventArgs e)
        {
            string bId = tbBID.Text;
            
            if (ckbJaTilLejlighed.Checked == true)
            {
                panelUdskrivLejekontrakt.Visible = true;
                combAdresser.Visible = true;
                if (!string.IsNullOrEmpty(bId))
                {
                    if ((BoligInputCheck.BIdCheck(bId) == true))
                    {
                        bId = tableConn.textBoxBinder($"SELECT bId FROM Bolig WHERE bId = {bId}");
                        combAdresser.DataSource = tableConn.comboBoxBinder($"SELECT adresse FROM Bolig WHERE (pId IS NULL OR udflytDato IS NOT NULL) AND bId = {bId}");
                    }
                    else
                    {
                        MessageBox.Show(ErrorMessage.errorMessage());
                        ErrorMessage.ErrorList.Clear();
                        ErrorMessage.resetInjectedSQL();
                    }
                }
            }
            else if (ckbJaTilLejlighed.Checked == false)
            {
                panelUdskrivLejekontrakt.Visible = false;
                combAdresser.Visible = false;
            }
        }

        private void btnUdskrivLejekontrakt_Click(object sender, EventArgs e)
        {
            string pId = tbPID.Text;
            string bId = tbBID.Text;
            string lejePris = "";
            string lejerNavn = tbMedlemsNavn.Text;
            string lejerMail = tbMedlemsEmail.Text;
            string lejerTlf = tbMedlemsTLF.Text;
            bool erBeboer; 
            string adresse = combAdresser.SelectedItem.ToString();
            string postNr = tableConn.textBoxBinder($"SELECT postNr FROM Bolig WHERE adresse = '{adresse}'");
            string by = tableConn.textBoxBinder($"SELECT byNavn FROM PostNr WHERE postNr = '{postNr}'");
            string startDato = "";
            if ((combIndflytMåned.SelectedIndex + 1) < 10)
                startDato = $"01-0{combIndflytMåned.SelectedIndex + 1}-{combIndflytÅr.SelectedItem}";
            else 
                startDato = $"01-{combIndflytMåned.SelectedIndex + 1}-{combIndflytÅr.SelectedItem}";
            string slutDato = null;
            //MessageBox.Show($"{lejerNavn}\n{lejerMail}\n{lejerTlf}\n{adresse}\n{postNr}\n{by}\n{startDato}");

            if ((!string.IsNullOrEmpty(bId)) && (!string.IsNullOrEmpty(lejerNavn)) && (!string.IsNullOrEmpty(pId)))
            {
                if ((BoligInputCheck.BIdCheck(bId) == true) && (PersonInputCheck.PIdCheck(pId) == true))
                {
                    lejePris = tableConn.textBoxBinder($"SELECT lejePris FROM BoligInfo WHERE bId = {bId}");
                    LejekontraktFacade lejekontrakt = new LejekontraktFacade();
                    lejekontrakt.PrintKontrakt(lejerNavn, lejePris, adresse, postNr, by, startDato);

                    PersonFacade pUpdate = new PersonFacade();
                    erBeboer = true;
                    pId = tableConn.textBoxBinder($"SELECT pId FROM Person WHERE fNavn = '{lejerNavn}'");
                    pUpdate.UpdatePerson(lejerNavn, lejerMail, lejerTlf, pId, erBeboer);

                    BoligFacade boligUpdate = new BoligFacade();
                    boligUpdate.uBolig(adresse, postNr, bId, pId, startDato, slutDato);
                    dgvBolig.DataSource = tableConn.tableBinder(sqlS1);

                    vFacade vDelete = new vFacade();
                    vDelete.RemoveFromList(pId, bId);
                    dgvVenteliste.DataSource = tableConn.tableBinder(sqlS2);
                }
                else
                {
                    MessageBox.Show(ErrorMessage.errorMessage());
                    ErrorMessage.ErrorList.Clear();
                    ErrorMessage.resetInjectedSQL();
                }
            }
        }
    }
}
