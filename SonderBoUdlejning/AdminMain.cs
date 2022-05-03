using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SonderBoUdlejning.Admin;

namespace SonderBoUdlejning
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            UserIdentification.UserAccess = 0;

            this.Hide();
            LoginMain loginMain = new LoginMain();
            loginMain.ShowDialog();
            this.Close();
        }

        private void VenteListeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VenteListe venteliste = new VenteListe();
            venteliste.ShowDialog();
            this.Close();
        }


    }
}
