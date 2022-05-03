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
    public partial class VenteListe : Form
    {
        SQLExecutionHandler tableConn = new SQLExecutionHandler();
        public VenteListe()
        {
            InitializeComponent();
        }

        private void VenteListe_Load(object sender, EventArgs e)
        {
            string sqlS1 = "SELECT * FROM Venteliste ORDER BY signUpDato ASC";
            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);

            string sqlS2 = "SELECT * FROM Person";
            DGVPersoner.DataSource = tableConn.tableBinder(sqlS2);

            string sqlS3 = "SELECT * FROM BoligInfo";
            DGVBoliger.DataSource = tableConn.tableBinder(sqlS3);
        }

        private void InsertToList_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(UserIdentification.conString);
            conn.Open();

            string query = "INSERT INTO Venteliste(pId, bId, signUpDato) VALUES("+pIdTextbox.Text+", "+bIdTextbox.Text+", getdate())";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            string sqlS1 = "SELECT * FROM Venteliste ORDER BY signUpDato ASC";
            DGVVenteListe.DataSource = tableConn.tableBinder(sqlS1);
 
            conn.Close();
        }
    }
}
