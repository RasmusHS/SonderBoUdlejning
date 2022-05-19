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

namespace SonderBoUdlejning
{
    public partial class LoginMain : Form
    {
        ConnString connString = ConnString.getConnInstance;
        public LoginMain()
        {
            InitializeComponent();
        }
        private void LoginMain_Load(object sender, EventArgs e)
        {
            string sqlS1 = "SELECT udflytDato FROM Lejemaal INNER JOIN Person ON Lejemaal.pId=Person.pId WHERE Lejemaal.pId IS NOT NULL AND erBeboer = 1 AND udflytDato IS NOT NULL AND udflytDato < GETDATE()";
            string sqlS2 = "SELECT Person.pId FROM Person INNER JOIN Lejemaal ON Person.pId=Lejemaal.pId WHERE Lejemaal.pId IS NOT NULL AND erBeboer = 1 AND udflytDato IS NOT NULL AND udflytDato < GETDATE()";

            SqlConnection conn1 = new SqlConnection(connString.connStr);
            SqlConnection conn2 = new SqlConnection(connString.connStr);
            SqlCommand cmd1 = new SqlCommand(sqlS1, conn1);
            SqlCommand cmd2 = new SqlCommand(sqlS2, conn2);
            conn1.Open();
            conn2.Open();
            SqlDataReader reader1 = cmd1.ExecuteReader();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader1.Read() && reader2.Read())
            {
                SqlConnection conn3 = new SqlConnection(connString.connStr);
                SqlCommand cmd3 = new SqlCommand("SELECT adresse FROM Lejemaal WHERE pId = " + reader2.GetInt32(0), conn3);
                conn3.Open();
                SqlDataReader reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    SqlConnection conn4 = new SqlConnection(connString.connStr);
                    SqlConnection conn5 = new SqlConnection(connString.connStr);
                    conn4.Open();
                    conn5.Open();
                    string sqlUpdatePerson = $"UPDATE Person SET erBeboer = 0 WHERE pId = {reader2.GetInt32(0)}";
                    string sqlUpdateBolig = $"UPDATE Lejemaal SET pId = NULL, indflytDato = NULL, udflytDato = NULL WHERE adresse = '{reader3.GetString(0)}'";
                    SqlCommand cmd4 = new SqlCommand(sqlUpdatePerson, conn4);
                    SqlCommand cmd5 = new SqlCommand(sqlUpdateBolig, conn5);
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();
                    conn4.Close();
                    conn5.Close();
                }
                conn3.Close();
            }
            conn1.Close();
            conn2.Close();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(UserIdentification.conString);
            conn.Open();
            string query = "SELECT accessLevel FROM LoginInfo WHERE loginPass = '" + passwordTextBox.Text + "' AND brugerNavn = '" + usernameTextBox.Text + "';";

            //Get data from server
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                MessageBox.Show("Du skal skrive et brugernavn");
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Du skal skrive et kodeord");
            }

            if (string.IsNullOrEmpty(usernameTextBox.Text) == false && string.IsNullOrEmpty(passwordTextBox.Text) == false)
            {
                while (reader.Read())
                {
                    UserIdentification.UserAccess = reader.GetInt32(0);
                }

                if (UserIdentification.UserAccess == 1)
                {
                    this.Hide();
                    AdminMain adminMain = new AdminMain();
                    adminMain.ShowDialog();
                    this.Close();
                }

                if (UserIdentification.UserAccess == 2)
                {
                    this.Hide();
                    SecretaryMain secretaryMain = new SecretaryMain();
                    secretaryMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login informationer ikke fundet i databasen. Prøv igen!");
                }
            }
            conn.Close();
        }
    }
}
