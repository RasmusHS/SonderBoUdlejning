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
            openFormsLoader(new VenteListe());
        }

        private Form activeForm = null;
        private void openFormsLoader(Form loadedForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = loadedForm;
            loadedForm.TopLevel = false; // Lav Forms om til en Control
            loadedForm.FormBorderStyle = FormBorderStyle.None; // Ingen kant på forms, når den loades ind
            loadedForm.Dock = DockStyle.Fill; // Docker fuldt ud i FormLoader
            panelAdminFormsLoader.Controls.Add(loadedForm); //Tilføjer den til Control Panelet i Panelet
            panelAdminFormsLoader.Tag = loadedForm; // Vi forbinder Formen til Formloader Panelet
            loadedForm.BringToFront(); // Bringes til front så den ikke kommer i konflikt med logo
            loadedForm.Show(); // Formens vises.

        }

        private void btnTildelingBoligAdmin_Click(object sender, EventArgs e)
        {
            openFormsLoader(new TildelBolig()); 
        }
    }
}
