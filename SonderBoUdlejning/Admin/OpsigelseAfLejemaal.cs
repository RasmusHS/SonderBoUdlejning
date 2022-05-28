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
using Microsoft.Data.SqlClient;
using System.Globalization;
using SonderBoUdlejning.LejemaalSystems;

namespace SonderBoUdlejning.Admin
{
    public partial class OpsigelseAfLejemaal : Form
    {
        public OpsigelseAfLejemaal()
        {
            InitializeComponent();
        }

        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        
        //Standard Query for lejemål dataGridView
        string sqlS1 = "SELECT lejemaalNr AS 'Lejemål Nr.', adresse AS 'Adresse', postNr AS 'Post Nr.', Lid AS 'Lejemålstype ID', Lejemaal.pId AS 'Person ID', indflytDato AS 'Indflytningsdato', udflytDato AS 'Udflytningsdato'" +
                       "FROM Lejemaal " +
                       "INNER JOIN Person ON Lejemaal.pId=Person.pId " +
                       "WHERE Lejemaal.pId IS NOT NULL AND erBeboer = 1 AND udflytDato IS NULL " +
                       "ORDER BY Lejemaal.pId ASC";

        //Standard Query for person dataGridView
        string sqlS2 = "SELECT Person.pId AS 'Person ID', fNavn AS 'Fulde Navn', pMail AS 'E-mail', pTlf AS 'Tlf. Nr.', erBeboer AS 'Er Beboer?'" +
                       "FROM Person " +
                       "INNER JOIN Lejemaal ON Person.pId=Lejemaal.pId " +
                       "WHERE Lejemaal.pId IS NOT NULL AND erBeboer = 1 AND udflytDato IS NULL " +
                       "ORDER BY Person.pId ASC";

        private void OpsigelseAfLejemaal_Load(object sender, EventArgs e)
        {
            //Indlæser dataGridViews med standard queries
            DGVLejemaal.DataSource = tableConn.tableBinder(sqlS1);
            DGVPerson.DataSource = tableConn.tableBinder(sqlS2);

            DGVLejemaal.RowHeadersVisible = false;
            DGVLejemaal.BorderStyle = BorderStyle.FixedSingle;
            DGVLejemaal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVLejemaal.RowTemplate.Height = 30;
            DGVLejemaal.RowTemplate.DividerHeight = 1;
            DGVLejemaal.GridColor = Color.Black;
            DGVLejemaal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);

            DGVPerson.RowHeadersVisible = false;
            DGVPerson.BorderStyle = BorderStyle.FixedSingle;
            DGVPerson.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVPerson.RowTemplate.Height = 30;
            DGVPerson.RowTemplate.DividerHeight = 1;
            DGVPerson.GridColor = Color.Black;
            DGVPerson.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);

            //Indlæser måned comboboxen med alle månederne
            string[] comboBoxListMonth;
            comboBoxListMonth = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Take(12).ToArray();
            comboBoxMonth.Items.AddRange(comboBoxListMonth);

            //Indlæser år comboboxen med alle år fra 2022 til 2044
            
            for (int year = DateTime.Now.Year; year < DateTime.Now.Year + 50; year++)
            {
                comboBoxYear.Items.Add(year);
            }
        }

        private void btnOpsigelse_Click(object sender, EventArgs e)
        {
            string pId = tbPiD.Text; //Tager inputtet fra person ID textboxen

            string Lid = tbBiD.Text; //Tager inputtet fra lejemål Nr textboxen

            //Bruger inputtene fra person ID og lejemål Nr textboxene til finde adresse, postNr og hvornår personen flyttede ind
            string lejemaalNr = "";
            string adresse = "";
            string postNr = "";
            string indflytDato = "";
            
            bool erBeboer; //Bruges ikke i øjeblikket

            string udflytDato = ""; //Pladsholder for udflytningsdato
            if ((comboBoxMonth.SelectedIndex + 1) < 10)
                udflytDato = $"01-0{comboBoxMonth.SelectedIndex + 1}-{comboBoxYear.SelectedItem}";
            else
                udflytDato = $"01-{comboBoxMonth.SelectedIndex + 1}-{comboBoxYear.SelectedItem}";
            bool udflytDatoValid = true;//
            
            //Messageboxen bruges til debugging
            //MessageBox.Show($"{adresse}\n{postNr}\n{Lid}\n{pId}\n{indflytDato}\n{udflytDato}");

            //Checker om person ID eller lejemål Nr. er tomt
            if ((string.IsNullOrEmpty(pId)) || (string.IsNullOrEmpty(Lid)))
            {
                //Viser fejlbesked hvis person ID eller lejemål Nr er tomt
                MessageBox.Show("Alle felter skal udfyldes");
                return; //Stopper koden
            }

            bool pIdValid = PersonInputCheck.PIdCheck(pId);
            bool LidValid = LejemaalInputCheck.LidCheck(Lid);

            try
            {
                udflytDatoValid = LejemaalInputCheck.udflytDato(udflytDato);
            }
            catch
            {
                udflytDatoValid = false;
            }

            //Checker inputtene for længde og karakterer
            if ((pIdValid == true) && (LidValid == true) && (udflytDatoValid == true))
            {
                lejemaalNr = tableConn.textBoxBinder($"SELECT lejemaalNr FROM Lejemaal WHERE pId = {pId} AND Lid = {Lid}");
                adresse = tableConn.textBoxBinder($"SELECT adresse FROM Lejemaal WHERE pId = {pId} AND Lid = {Lid}");
                postNr = tableConn.textBoxBinder($"SELECT postNr FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");
                indflytDato = LejemaalInputCheck.indDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), indflytDato, 105) FROM Lejemaal WHERE lejemaalNr = {lejemaalNr}");

                LejemaalFacade opsigLejemaal = new LejemaalFacade();
                erBeboer = true; //Er der for at sikre at querien ikke sætter personen til ikke beboer
                opsigLejemaal.uLejemaal(lejemaalNr, adresse, postNr, Lid, pId, indflytDato, udflytDato); //Kalder updateLejemaal metoden til at opsige boligen
                DGVLejemaal.DataSource = tableConn.tableBinder(sqlS1); //refresher lejemål dataGridview
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
