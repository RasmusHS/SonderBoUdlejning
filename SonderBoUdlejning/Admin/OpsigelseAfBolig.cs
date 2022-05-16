using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SonderBoUdlejning.InputCheck;
using SonderBoUdlejning.Opsigelse;
using Microsoft.Data.SqlClient;
using System.Globalization;
using SonderBoUdlejning.BoligSystems;

namespace SonderBoUdlejning.Admin
{
    public partial class OpsigelseAfBolig : Form
    {
        public OpsigelseAfBolig()
        {
            InitializeComponent();
        }

        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        
        //Standard Query for bolig dataGridView
        string sqlS1 = "SELECT adresse, postNr, bId, Bolig.pId, indflytDato, udflytDato " +
                       "FROM Bolig " +
                       "INNER JOIN Person ON Bolig.pId=Person.pId " +
                       "WHERE Bolig.pId IS NOT NULL AND erBeboer = 1 AND udflytDato IS NULL " +
                       "ORDER BY pId ASC";

        //Standard Query for person dataGridView
        string sqlS2 = "SELECT Person.pId, fNavn, pMail, pTlf, erBeboer " +
                       "FROM Person " +
                       "INNER JOIN Bolig ON Person.pId=Bolig.pId " +
                       "WHERE Bolig.pId IS NOT NULL AND erBeboer = 1 AND udflytDato IS NULL " +
                       "ORDER BY pId ASC";

        private void OpsigelseAfBolig_Load(object sender, EventArgs e)
        {
            //Indlæser dataGridViews med standard queries
            DGVBolig.DataSource = tableConn.tableBinder(sqlS1);
            DGVPerson.DataSource = tableConn.tableBinder(sqlS2);

            //Indlæser måned comboboxen med alle månederne
            string[] comboBoxListMonth;
            comboBoxListMonth = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Take(12).ToArray();
            comboBoxMonth.Items.AddRange(comboBoxListMonth);

            //Indlæser år comboboxen med alle år fra 2022 til 2044
            comboBoxYear.DataSource = Enumerable.Range(DateTime.Now.Year, DateTime.Now.Year - 2000 + 1).ToList();
            comboBoxYear.SelectedItem = DateTime.Now.Year;
        }

        private void btnOpsigelse_Click(object sender, EventArgs e)
        {
            string pId = tbPiD.Text; //Tager inputtet fra person ID textboxen
            string bId = tbBiD.Text; //Tager inputtet fra bolig ID textboxen
            
            //Bruger inputtene fra person ID og bolig ID textboxene til finde adresse, postNr og hvornår personen flyttede ind
            string adresse = tableConn.textBoxBinder($"SELECT adresse FROM Bolig WHERE pId = {pId} AND bId = {bId}");
            string postNr = tableConn.textBoxBinder($"SELECT postNr FROM Bolig WHERE adresse = '{adresse}'");
            string indflytDato = BoligInputCheck.indDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), indflytDato, 105) FROM Bolig WHERE adresse = '{adresse}'");
            
            bool erBeboer; //Bruges ikke i øjeblikket

            string udflytDato = ""; //Pladsholder for udflytningsdato
            if ((comboBoxMonth.SelectedIndex + 1) < 10)
                udflytDato = $"01-0{comboBoxMonth.SelectedIndex + 1}-{comboBoxYear.SelectedItem}";
            else
                udflytDato = $"01-{comboBoxMonth.SelectedIndex + 1}-{comboBoxYear.SelectedItem}";

            //Messageboxen bruges til debugging
            //MessageBox.Show($"{adresse}\n{postNr}\n{bId}\n{pId}\n{indflytDato}\n{udflytDato}");

            //Checker om person ID eller bolig ID er tomt
            if ((string.IsNullOrEmpty(pId)) || (string.IsNullOrEmpty(bId)))
            {
                //Viser fejlbesked hvis person ID eller bolig ID er tomt
                MessageBox.Show("Alle felter skal udfyldes");
                return; //Stopper koden
            }
            
            //Checker inputtene for længde og karakterer
            if ((PersonInputCheck.PIdCheck(pId) == true) && (BoligInputCheck.BIdCheck(bId) == true) && (BoligInputCheck.indflytDato(indflytDato) == true) && (BoligInputCheck.udflytDato(udflytDato) == true))
            {
                BoligFacade opsigBolig = new BoligFacade();
                erBeboer = true; //Er der for at sikre at querien ikke sætter personen til ikke beboer
                opsigBolig.uBolig(adresse, postNr, bId, pId, indflytDato, udflytDato); //Kalder updateBolig metoden til at opsige boligen
                DGVBolig.DataSource = tableConn.tableBinder(sqlS1); //refresher bolig dataGridview
                DGVPerson.DataSource = tableConn.tableBinder(sqlS2); //refresher person dataGridview
            }
            else
            {
                //Viser fejlbesked hvis et af inputtene ikke er korrekt
                ErrorMessage.errorMessage();
            }
        }
    }
}
