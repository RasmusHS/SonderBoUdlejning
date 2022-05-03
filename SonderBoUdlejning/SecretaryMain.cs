﻿using SonderBoUdlejning.Secretary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonderBoUdlejning
{
    public partial class SecretaryMain : Form
    {
        public SecretaryMain()
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            openFormsLoader(new PersonCRUD());
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
    }
}
