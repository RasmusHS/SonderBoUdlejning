using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SonderBoUdlejning.Admin
{
    public partial class Booking : Form
    {
        ConnString connString = ConnString.getConnInstance;
        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        string sqlS1 = "SELECT resNr, rTypeNavn, pId, Ressourcer.rId, rType, rStartDato, rSlutDato FROM Ressourcer INNER JOIN Reservationer ON Ressourcer.rId = Reservationer.rId";
        string sqlS2 = "SELECT*FROM Ressourcer WHERE rId NOT IN(SELECT rId FROM Reservationer WHERE GETDATE() BETWEEN rStartDato AND rSlutDato)";

        List<string> listBeboer = new List<string>();
        List<int> listBeboerID = new List<int>();

        List<string> listResource = new List<string>();
        List<int> listResourceID = new List<int>();

        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            DGVReservationer.DataSource = tableConn.tableBinder(sqlS1);
            DGVRessourcer.DataSource = tableConn.tableBinder(sqlS2);

            string date = DateTime.Today.ToString("yyyy-MM-dd");

            Bokking.OnLoadFuckions.GetPeronList(listBeboerID, listBeboer);
            Bokking.OnLoadFuckions.GetResourceList(listResourceID, listResource, date);


            foreach (string item in listResource)
            {
                CBResource.Items.Add(item);
            }

            foreach (string item in listBeboer) 
            {
                CBMembers.Items.Add(item);
            }
        }

        

        //Tag inspiration fra vAddToList linje 17

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CBMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] arrayBeboerID = listBeboerID.ToArray(); 
            PanelPersonInfo.Visible = true;
            int personID = arrayBeboerID[CBMembers.SelectedIndex];
            TBPID.Text = personID.ToString();

            string queryTlf = $"SELECT pTlf FROM Person WHERE pId = {personID}";
            string queryMail = $"SELECT pMail FROM Person WHERE pId = {personID}";

            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(queryTlf, conn);
            conn.Open();
            TBTLF.Text = Convert.ToString(cmd.ExecuteScalar());
            conn.Close();

            SqlCommand cmd2 = new SqlCommand(queryMail, conn);
            conn.Open();
            TBMail.Text = Convert.ToString(cmd2.ExecuteScalar());
            conn.Close();

            if (PanelResource.Visible == true)
            {
                btnConfirmBooking.Visible = true;
            }
        }
        

        private void CBResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Denne text box skal slettes. det er bare for at se om den ID er korrekt
            int[] arrayResourceID = listResourceID.ToArray();
            int resourceID = arrayResourceID[CBResource.SelectedIndex];
            TBResourceID.Text = resourceID.ToString();
            PanelResource.Visible = true;

            if (PanelPersonInfo.Visible == true) 
            {
                btnConfirmBooking.Visible = true;
            }
        }

        private void BtnCheckDato_Click(object sender, EventArgs e)
        {
            //Tjekker om den dato man vil leje fra, allerede er i en anden udlejning. 
            //Indput validate dato. er der en funktion i winforms hvor man kan vælge på en kalender og få dato i string format? 
            Regex regex = new Regex(@"^\d{4}\-(0[1-9]|1[012])\-(0[1-9]|[12][0-9]|3[01])$"); //Input kan kun være YYYY-MM-DD
            if (regex.IsMatch(TBDato.Text))
            {
                string sqlS2 = "SELECT*FROM Ressourcer WHERE rId NOT IN(SELECT rId FROM Reservationer WHERE '" + TBDato.Text + "' BETWEEN rStartDato AND rSlutDato)";
                DGVRessourcer.DataSource = tableConn.tableBinder(sqlS2);

                listResource.Clear();
                CBResource.Items.Clear();
                Bokking.OnLoadFuckions.GetResourceList(listResourceID, listResource, TBDato.Text);
                foreach (string item in listResource)
                {
                    CBResource.Items.Add(item);
                }

                TBResourceID.Text = "";
                TBStartDato.Text = "";
                TBSlutDato.Text = "";
                TBDato.Text = "";
            }
            else
            {
                MessageBox.Show("indtast dato i formatet yyyy-mm-dd");
            }
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d{4}\-(0[1-9]|1[012])\-(0[1-9]|[12][0-9]|3[01])$");
            if (regex.IsMatch(TBDato.Text) && regex.IsMatch(TBDato.Text)) 
            {
                /*Check om datoen kan skriver ind i startdato er i dag eller senere.
                  
                 hvis man har tjekket en anden dato til venstre, så skal startdato,
                ikke kunne være før den dato man har tjekket.
                
                slutdato skal også tjekkes om den den er inde i en anden reservation
                Denne sætning kan bruges. Hvis den returnere 0, så kan den godt reserveres til og med den dato, ellers kan den ikke.
               SELECT COUNT(rId) FROM Ressourcer WHERE rId IN(SELECT rId FROM Reservationer WHERE *indsæt slutdato* BETWEEN rStartDato AND rSlutDato)
                 */
            }
        }
    }
}
