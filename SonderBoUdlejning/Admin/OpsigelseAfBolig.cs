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

namespace SonderBoUdlejning.Admin
{
    public partial class OpsigelseAfBolig : Form
    {
        public OpsigelseAfBolig()
        {
            InitializeComponent();
        }

        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        string sqlS1 = "SELECT * FROM Bolig";
        string sqlS2 = "SELECT * FROM Person";

        private void OpsigelseAfBolig_Load(object sender, EventArgs e)
        {
            DGVBolig.DataSource = tableConn.tableBinder(sqlS1);
            DGVPerson.DataSource = tableConn.tableBinder(sqlS2);
            comboBoxMonth.Items.Add("Januar");
            comboBoxMonth.Items.Add("Februar");
            comboBoxMonth.Items.Add("Marts");
            comboBoxMonth.Items.Add("April");
            comboBoxMonth.Items.Add("Maj");
            comboBoxMonth.Items.Add("Juni");
            comboBoxMonth.Items.Add("Juli");
            comboBoxMonth.Items.Add("August");
            comboBoxMonth.Items.Add("September");
            comboBoxMonth.Items.Add("Oktober");
            comboBoxMonth.Items.Add("November");
            comboBoxMonth.Items.Add("December");
        }

        private void btnOpsigelse_Click(object sender, EventArgs e)
        {
            bool PersonIDValid = ventelisteInputCheck.PIdCheck(tbPiD.Text);
            bool BoligIDValid = ventelisteInputCheck.BIdCheck(tbBiD.Text);
            bool yearCheckValid = ventelisteInputCheck.YearCheck(TBYear.Text);

            int comboBocMonthIndex = Convert.ToInt32(comboBoxMonth.SelectedIndex);

            if (yearCheckValid) 
            {
                string year = TBYear.Text;
                string monthBuilder = OpsigFunktioner.DateBuilder(comboBocMonthIndex, year);
            }


            
        }
    }
}
