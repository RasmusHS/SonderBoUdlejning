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
        //string sqlS1 = "SELECT * FROM Bolig WHERE udflytDato IS NULL AND pId IS NOT NULL";
        string sqlS1 = "SELECT adresse, postNr, bId, Bolig.pId, indflytDato, udflytDato " +
                       "FROM Bolig " +
                       "INNER JOIN Person ON Bolig.pId=Person.pId " +
                       "WHERE Bolig.pId IS NOT NULL AND erBeboer = 1 AND udflytDato IS NULL " +
                       "ORDER BY pId ASC";
        //string sqlS2 = "SELECT * FROM Person P, Bolig B WHERE P.pId = (SELECT B.pId WHERE B.udflytDato IS NULL AND B.pId IS NOT NULL)";
        string sqlS2 = "SELECT Person.pId, fNavn, pMail, pTlf, erBeboer " +
                       "FROM Person " +
                       "INNER JOIN Bolig ON Person.pId=Bolig.pId " +
                       "WHERE Bolig.pId IS NOT NULL AND erBeboer = 1 AND udflytDato IS NULL " +
                       "ORDER BY pId ASC";

        private void OpsigelseAfBolig_Load(object sender, EventArgs e)
        {
            DGVBolig.DataSource = tableConn.tableBinder(sqlS1);
            DGVPerson.DataSource = tableConn.tableBinder(sqlS2);
            
            comboBoxMonth.DataSource = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Take(12).ToList();
            comboBoxYear.DataSource = Enumerable.Range(DateTime.Now.Year, DateTime.Now.Year - 2000 + 1).ToList();
            comboBoxYear.SelectedItem = DateTime.Now.Year;
        }

        private void btnOpsigelse_Click(object sender, EventArgs e)
        {
            string pId = tbPiD.Text;
            string bId = tbBiD.Text;
            string adresse = tableConn.textBoxBinder($"SELECT adresse FROM Bolig WHERE pId = {pId} AND bId = {bId}");
            string postNr = tableConn.textBoxBinder($"SELECT postNr FROM Bolig WHERE adresse = '{adresse}'");
            string indflytDato = BoligInputCheck.indDato = tableConn.textBoxBinder($"SELECT CONVERT(VARCHAR(10), indflytDato, 105) FROM Bolig WHERE adresse = '{adresse}'");
            bool erBeboer;
            string udflytDato = "";
            if ((comboBoxMonth.SelectedIndex + 1) < 10)
                udflytDato = $"01-0{comboBoxMonth.SelectedIndex + 1}-{comboBoxYear.SelectedItem}";
            else
                udflytDato = $"01-{comboBoxMonth.SelectedIndex + 1}-{comboBoxYear.SelectedItem}";
            //MessageBox.Show($"{adresse}\n{postNr}\n{bId}\n{pId}\n{indflytDato}\n{udflytDato}");

            if ((!string.IsNullOrEmpty(pId)) && (!string.IsNullOrEmpty(bId)))
            {
                if ((PersonInputCheck.PIdCheck(pId) == true) && (BoligInputCheck.BIdCheck(bId) == true) && (BoligInputCheck.indflytDato(indflytDato) == true) && (BoligInputCheck.udflytDato(udflytDato) == true))
                {
                    BoligFacade opsigBolig = new BoligFacade();
                    erBeboer = true;
                    opsigBolig.uBolig(adresse, postNr, bId, pId, indflytDato, udflytDato);
                    DGVBolig.DataSource = tableConn.tableBinder(sqlS1);
                    DGVPerson.DataSource = tableConn.tableBinder(sqlS2);
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
                MessageBox.Show("Alle felter skal udfyldes");
            }
        }
    }
}
