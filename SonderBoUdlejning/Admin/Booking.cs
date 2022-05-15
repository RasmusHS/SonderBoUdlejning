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
        string sqlS2 = "SELECT*FROM Ressourcer WHERE rId NOT IN(SELECT rId FROM Reservationer)";    

        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            DGVReservationer.DataSource = tableConn.tableBinder(sqlS1);
            DGVRessourcer.DataSource = tableConn.tableBinder(sqlS2);

            List<string> listBeboer = new List<string>();

            string query = "SELECT COUNT(fNavn) FROM Person WHERE erBeboer = 1";
            SqlConnection conn = new SqlConnection(connString.connStr);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int antalBeboer = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            string query2 = "SELECT fNavn FROM Person WHERE erBeboer = 1";
            SqlConnection conn2 = new SqlConnection(connString.connStr);
            SqlCommand cmd2 = new SqlCommand(query2, conn2);
            
            conn2.Open();
            SqlDataReader reader = cmd2.ExecuteReader();
            for (int i = 0; i < antalBeboer; i++) 
            {
                while (reader.Read()) 
                {
                    listBeboer.Add(reader.GetString(i));
                }
            }
            conn2.Close();


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
            PanelPersonInfo.Visible = true;
        }
    }
}
