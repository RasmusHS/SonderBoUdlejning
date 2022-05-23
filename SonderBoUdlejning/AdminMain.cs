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
using System.Threading;

namespace SonderBoUdlejning
{
    public partial class AdminMain : Form
    {
        private readonly Thread sloganThread;
        public AdminMain()
        {
            InitializeComponent();
            SloganThread slogan = new SloganThread(labelSlogan);
            sloganThread = new Thread(new ThreadStart(slogan.ShowSlogan));
            sloganThread.Start();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            UserIdentification.UserAccess = 0;

            this.Hide();
            LoginMain loginMain = new LoginMain();
            loginMain.ShowDialog();
            this.Close();
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
            openFormsLoader(new TildelLejemaal()); 
        }
        
        private void VenteListeButton_Click(object sender, EventArgs e)
        {
            openFormsLoader(new VenteListe());
        }
        
        private void btnOpsigelse_Click(object sender, EventArgs e)
        {
            openFormsLoader(new OpsigelseAfLejemaal());
        }

        private void btnBoligCRUD_Click(object sender, EventArgs e)
        {
            openFormsLoader(new LejemaalCRUD());
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            sloganThread.Abort();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            openFormsLoader(new Admin.Booking());
        }

        private void btnAdminBorger_Click(object sender, EventArgs e)
        {
            openFormsLoader(new PersonCRUD());
        }
    }
}
