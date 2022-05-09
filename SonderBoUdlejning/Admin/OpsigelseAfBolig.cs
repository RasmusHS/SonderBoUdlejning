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

namespace SonderBoUdlejning.Admin
{
    public partial class OpsigelseAfBolig : Form
    {
        public OpsigelseAfBolig()
        {
            InitializeComponent();
        }

        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        string sqlS1 = "SELECT*FROM Bolig WHERE udflytDato IS NULL AND pId IS NOT NULL";
        string sqlS2 = "SELECT*FROM Person P, Bolig B WHERE P.pId = (SELECT B.pId WHERE B.udflytDato IS NULL AND B.pId IS NOT NULL)";

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

            //Finder ud af hvor mange PersonID'er som lige nu er beboer og kan opsige en lejlighed.
            SqlConnection conn = new SqlConnection(UserIdentification.conString);
            conn.Open();
            string queryPID = "SELECT COUNT(P.pId) FROM Person P, Bolig B WHERE P.pId = (SELECT B.pId WHERE B.udflytDato IS NULL AND B.pId IS NOT NULL)";
            SqlCommand cmdPID = new SqlCommand(queryPID, conn);
            int numberOfCurrentBeboer = (int)cmdPID.ExecuteScalar();
            conn.Close();

            //Finder ud af Hvilket PersonID de nuværende beboer har
            conn.Open();
            List<int> listOfPersonID = new List<int>();
            string queryPID2 = "SELECT P.pId FROM Person P, Bolig B WHERE P.pId = (SELECT B.pId WHERE B.udflytDato IS NULL AND B.pId IS NOT NULL)";
            SqlCommand cmdPID2 = new SqlCommand(queryPID2, conn);
            SqlDataReader readerPID = cmdPID2.ExecuteReader();
            for (int i = 0; i < numberOfCurrentBeboer; i++)
            {
                while (readerPID.Read())
                {
                    listOfPersonID.Add(readerPID.GetInt32(i));
                }
            }
            conn.Close();

            //Kan bruges til at tjekke om PersonID er guldtigt til at opsige en lejlighed
            listOfPersonID.Contains(7);





            //Finder ud af hvor mange BoligID'er som lige nu som kan opsiges.    
            conn.Open();
            string queryBID = "SELECT COUNT(bId) FROM Bolig WHERE pId IS NOT NULL AND udflytDato IS NULL";
            SqlCommand cmdBID = new SqlCommand(queryBID, conn);
            int numberOfCurrentBolig = (int)cmdBID.ExecuteScalar();
            conn.Close();

            //Finder ud af Hvilket BoligID de nuværende beboer har
            conn.Open();
            List<int> listOfBoligID = new List<int>();
            string queryBID2 = "SELECT bId FROM Bolig WHERE pId IS NOT NULL AND udflytDato IS NULL";
            SqlCommand cmdBID2 = new SqlCommand(queryBID2, conn);
            SqlDataReader readerBID = cmdBID2.ExecuteReader();
            for (int i = 0; i < numberOfCurrentBolig; i++)
            {
                while (readerBID.Read())
                {
                    listOfBoligID.Add(readerBID.GetInt32(i));
                }
            }

            //Kan bruges til at tjekke om Bolig er guldtigt til at opsige en lejlighed
            listOfBoligID.Contains(7);


            //Nu mangler der kun at få indsættet en udflytningsdato på boliger.
            //Self efter man har tjekket om boligen og personen kan opsiges 



            if (yearCheckValid && BoligIDValid && PersonIDValid)
            {
                string year = TBYear.Text;
                int comboBocMonthIndex = Convert.ToInt32(comboBoxMonth.SelectedIndex);
                string sqlDateTimeBuilder = OpsigFunktioner.DateBuilder(comboBocMonthIndex, year);

               


            }
            else 
            {
                MessageBox.Show("Ikke alle felter er udfyldt");
            }
        }
    }
}
