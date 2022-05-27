namespace SonderBoUdlejning
{
    partial class AdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdmin = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.VenteListeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnOpsigelse = new System.Windows.Forms.Button();
            this.btnTildelingLejemaalAdmin = new System.Windows.Forms.Button();
            this.btnLejemaalCRUD = new System.Windows.Forms.Button();
            this.btnAdminBorger = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSlogan = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAdminFormsLoader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(603, 15);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(280, 95);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin";
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Red;
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(1176, 0);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(161, 123);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Log ud!";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // VenteListeButton
            // 
            this.VenteListeButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.VenteListeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VenteListeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VenteListeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenteListeButton.Location = new System.Drawing.Point(0, 271);
            this.VenteListeButton.Margin = new System.Windows.Forms.Padding(1);
            this.VenteListeButton.Name = "VenteListeButton";
            this.VenteListeButton.Size = new System.Drawing.Size(267, 74);
            this.VenteListeButton.TabIndex = 0;
            this.VenteListeButton.Text = "Venteliste";
            this.VenteListeButton.UseVisualStyleBackColor = false;
            this.VenteListeButton.Click += new System.EventHandler(this.VenteListeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnOpsigelse);
            this.panel1.Controls.Add(this.btnTildelingLejemaalAdmin);
            this.panel1.Controls.Add(this.VenteListeButton);
            this.panel1.Controls.Add(this.btnLejemaalCRUD);
            this.panel1.Controls.Add(this.btnAdminBorger);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 894);
            this.panel1.TabIndex = 2;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(0, 493);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(267, 74);
            this.btnBooking.TabIndex = 4;
            this.btnBooking.Text = "Reservationer";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnOpsigelse
            // 
            this.btnOpsigelse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOpsigelse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpsigelse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpsigelse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpsigelse.Location = new System.Drawing.Point(0, 419);
            this.btnOpsigelse.Margin = new System.Windows.Forms.Padding(1);
            this.btnOpsigelse.Name = "btnOpsigelse";
            this.btnOpsigelse.Size = new System.Drawing.Size(267, 74);
            this.btnOpsigelse.TabIndex = 2;
            this.btnOpsigelse.Text = "Opsigelse af Lejemål";
            this.btnOpsigelse.UseVisualStyleBackColor = false;
            this.btnOpsigelse.Click += new System.EventHandler(this.btnOpsigelse_Click);
            // 
            // btnTildelingLejemaalAdmin
            // 
            this.btnTildelingLejemaalAdmin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTildelingLejemaalAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTildelingLejemaalAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTildelingLejemaalAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTildelingLejemaalAdmin.Location = new System.Drawing.Point(0, 345);
            this.btnTildelingLejemaalAdmin.Margin = new System.Windows.Forms.Padding(1);
            this.btnTildelingLejemaalAdmin.Name = "btnTildelingLejemaalAdmin";
            this.btnTildelingLejemaalAdmin.Size = new System.Drawing.Size(267, 74);
            this.btnTildelingLejemaalAdmin.TabIndex = 1;
            this.btnTildelingLejemaalAdmin.Text = "Tildeling af Lejemål";
            this.btnTildelingLejemaalAdmin.UseVisualStyleBackColor = false;
            this.btnTildelingLejemaalAdmin.Click += new System.EventHandler(this.btnTildelingLejemaalAdmin_Click);
            // 
            // btnLejemaalCRUD
            // 
            this.btnLejemaalCRUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLejemaalCRUD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLejemaalCRUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLejemaalCRUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLejemaalCRUD.Location = new System.Drawing.Point(0, 197);
            this.btnLejemaalCRUD.Margin = new System.Windows.Forms.Padding(1);
            this.btnLejemaalCRUD.Name = "btnLejemaalCRUD";
            this.btnLejemaalCRUD.Size = new System.Drawing.Size(267, 74);
            this.btnLejemaalCRUD.TabIndex = 3;
            this.btnLejemaalCRUD.Text = "Admin. Lejemål";
            this.btnLejemaalCRUD.UseVisualStyleBackColor = false;
            this.btnLejemaalCRUD.Click += new System.EventHandler(this.btnLejemaalCRUD_Click);
            // 
            // btnAdminBorger
            // 
            this.btnAdminBorger.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdminBorger.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminBorger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminBorger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminBorger.Location = new System.Drawing.Point(0, 123);
            this.btnAdminBorger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminBorger.Name = "btnAdminBorger";
            this.btnAdminBorger.Size = new System.Drawing.Size(267, 74);
            this.btnAdminBorger.TabIndex = 5;
            this.btnAdminBorger.Text = "Admin. Borgere";
            this.btnAdminBorger.UseVisualStyleBackColor = false;
            this.btnAdminBorger.Click += new System.EventHandler(this.btnAdminBorger_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 123);
            this.panel2.TabIndex = 0;
            // 
            // labelSlogan
            // 
            this.labelSlogan.AutoSize = true;
            this.labelSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlogan.Location = new System.Drawing.Point(1, 47);
            this.labelSlogan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSlogan.Name = "labelSlogan";
            this.labelSlogan.Size = new System.Drawing.Size(377, 31);
            this.labelSlogan.TabIndex = 0;
            this.labelSlogan.Text = "Bo godt – bo hos SønderBo (1)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.labelSlogan);
            this.panel3.Controls.Add(this.lblAdmin);
            this.panel3.Controls.Add(this.logOutButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(267, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1337, 123);
            this.panel3.TabIndex = 3;
            // 
            // panelAdminFormsLoader
            // 
            this.panelAdminFormsLoader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAdminFormsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminFormsLoader.Location = new System.Drawing.Point(267, 123);
            this.panelAdminFormsLoader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAdminFormsLoader.Name = "panelAdminFormsLoader";
            this.panelAdminFormsLoader.Size = new System.Drawing.Size(1337, 771);
            this.panelAdminFormsLoader.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SonderBoUdlejning.Properties.Resources.Soenderbo_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 894);
            this.Controls.Add(this.panelAdminFormsLoader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMain_FormClosing);
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button VenteListeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAdminFormsLoader;
        private System.Windows.Forms.Button btnTildelingLejemaalAdmin;
        private System.Windows.Forms.Button btnOpsigelse;
        private System.Windows.Forms.Button btnLejemaalCRUD;
        private System.Windows.Forms.Label labelSlogan;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnAdminBorger;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}