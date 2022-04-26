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
        public LoginMain()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(UserIdentification.conString);
            conn.Open();
            string query = "SELECT accessLevel FROM users WHERE password = '" + passwordTextBox.Text + "' AND username = '" + usernameTextBox.Text + "';";

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
