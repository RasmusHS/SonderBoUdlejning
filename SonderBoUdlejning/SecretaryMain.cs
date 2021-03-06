using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SonderBoUdlejning.Admin;

namespace SonderBoUdlejning
{
    public partial class SecretaryMain : Form
    {
        private readonly Thread sloganThread;
        public SecretaryMain()
        {
            InitializeComponent();
            SloganThread slogan = new SloganThread(labelSlogan);
            sloganThread = new Thread(new ThreadStart(slogan.ShowSlogan));
            sloganThread.Start();
        }

        public void SecretaryMain_Load(object sender, EventArgs e)
        {

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
            panelSecFormsLoader.Controls.Add(loadedForm); //Tilføjer den til Control Panelet i Panelet
            panelSecFormsLoader.Tag = loadedForm; // Vi forbinder Formen til Formloader Panelet
            loadedForm.BringToFront(); // Bringes til front så den ikke kommer i konflikt med logo
            loadedForm.Show(); // Formens vises.
        }

        public void SecretaryMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            sloganThread.Abort();
        }

        private void btnOpretBorger_Click(object sender, EventArgs e)
        {
            openFormsLoader(new PersonCRUD());
        }
        
        private void btnTildelLejemaal_Click(object sender, EventArgs e)
        {
            openFormsLoader(new TildelLejemaal());
        }

        private void btnOpsigLejemaal_Click(object sender, EventArgs e)
        {
            openFormsLoader(new OpsigelseAfLejemaal());
        }

        private void btnLejemaalCRUD_Click(object sender, EventArgs e)
        {
            openFormsLoader(new LejemaalCRUD());
        }

        private void btnReservationer_Click(object sender, EventArgs e)
        {
            openFormsLoader(new Booking());
        }

        private void btnVenteliste_Click(object sender, EventArgs e)
        {
            openFormsLoader(new VenteListe());
        }
    }
}
