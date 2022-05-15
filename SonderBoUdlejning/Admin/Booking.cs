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

        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            DGVReservationer.DataSource = tableConn.tableBinder(sqlS1);
            DGVRessourcer.DataSource = tableConn.tableBinder(sqlS2);


            string query = "SELECT COUNT(fNavn) FROM Person WHERE erBeboer = 1";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int antalBeboer = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            string query2 = "SELECT pId FROM Person WHERE erBeboer = 1";
            SqlCommand cmd2 = new SqlCommand(query2, conn);

            conn.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            for (int i = 0; i < antalBeboer; i++)
            {
                while (reader2.Read())
                {
                    listBeboerID.Add(reader2.GetInt32(i));
                }
            }
            conn.Close();

            string query3 = "SELECT fNavn FROM Person WHERE erBeboer = 1";
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            
            conn.Open();
            SqlDataReader reader3 = cmd3.ExecuteReader();
            for (int i = 0; i < antalBeboer; i++) 
            {
                while (reader3.Read()) 
                {
                    listBeboer.Add(reader3.GetString(i));
                }
            }
            conn.Close();


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
        }
        private void BtnCheckDato_Click(object sender, EventArgs e)
        {
            //Indput validate dato. er der en funktion i winforms hvor man kan vælge på en kalender og få dato i string format?
            string sqlS2 = "SELECT*FROM Ressourcer WHERE rId NOT IN(SELECT rId FROM Reservationer WHERE '"+TBDato.Text+"' BETWEEN rStartDato AND rSlutDato)";
            DGVRessourcer.DataSource = tableConn.tableBinder(sqlS2);
        }
    }
}
