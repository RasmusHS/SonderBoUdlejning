﻿namespace SonderBoUdlejning
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
            this.label1 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.VenteListeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLejemaalCRUD = new System.Windows.Forms.Button();
            this.btnOpsigelse = new System.Windows.Forms.Button();
            this.btnTildelingLejemaalAdmin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSlogan = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAdminFormsLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN!";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(864, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(121, 59);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Log ud!";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // VenteListeButton
            // 
            this.VenteListeButton.Location = new System.Drawing.Point(28, 117);
            this.VenteListeButton.Margin = new System.Windows.Forms.Padding(1);
            this.VenteListeButton.Name = "VenteListeButton";
            this.VenteListeButton.Size = new System.Drawing.Size(149, 75);
            this.VenteListeButton.TabIndex = 0;
            this.VenteListeButton.Text = "Venteliste";
            this.VenteListeButton.UseVisualStyleBackColor = true;
            this.VenteListeButton.Click += new System.EventHandler(this.VenteListeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnLejemaalCRUD);
            this.panel1.Controls.Add(this.btnOpsigelse);
            this.panel1.Controls.Add(this.btnTildelingLejemaalAdmin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.VenteListeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 726);
            this.panel1.TabIndex = 2;
            // 
            // btnLejemaalCRUD
            // 
            this.btnLejemaalCRUD.Location = new System.Drawing.Point(28, 466);
            this.btnLejemaalCRUD.Name = "btnLejemaalCRUD";
            this.btnLejemaalCRUD.Size = new System.Drawing.Size(149, 77);
            this.btnLejemaalCRUD.TabIndex = 3;
            this.btnLejemaalCRUD.Text = "Admin. Lejemål";
            this.btnLejemaalCRUD.UseVisualStyleBackColor = true;
            this.btnLejemaalCRUD.Click += new System.EventHandler(this.btnBoligCRUD_Click);
            // 
            // btnOpsigelse
            // 
            this.btnOpsigelse.Location = new System.Drawing.Point(28, 352);
            this.btnOpsigelse.Name = "btnOpsigelse";
            this.btnOpsigelse.Size = new System.Drawing.Size(149, 77);
            this.btnOpsigelse.TabIndex = 2;
            this.btnOpsigelse.Text = "Opsigelse af Lejemål";
            this.btnOpsigelse.UseVisualStyleBackColor = true;
            this.btnOpsigelse.Click += new System.EventHandler(this.btnOpsigelse_Click);
            // 
            // btnTildelingLejemaalAdmin
            // 
            this.btnTildelingLejemaalAdmin.Location = new System.Drawing.Point(28, 234);
            this.btnTildelingLejemaalAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTildelingLejemaalAdmin.Name = "btnTildelingLejemaalAdmin";
            this.btnTildelingLejemaalAdmin.Size = new System.Drawing.Size(149, 77);
            this.btnTildelingLejemaalAdmin.TabIndex = 1;
            this.btnTildelingLejemaalAdmin.Text = "Tildeling af Lejemål";
            this.btnTildelingLejemaalAdmin.UseVisualStyleBackColor = true;
            this.btnTildelingLejemaalAdmin.Click += new System.EventHandler(this.btnTildelingBoligAdmin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.labelSlogan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // labelSlogan
            // 
            this.labelSlogan.AutoSize = true;
            this.labelSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlogan.Location = new System.Drawing.Point(45, 58);
            this.labelSlogan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSlogan.Name = "labelSlogan";
            this.labelSlogan.Size = new System.Drawing.Size(84, 24);
            this.labelSlogan.TabIndex = 0;
            this.labelSlogan.Text = "Slogan 1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.logOutButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 100);
            this.panel3.TabIndex = 3;
            // 
            // panelAdminFormsLoader
            // 
            this.panelAdminFormsLoader.BackColor = System.Drawing.Color.White;
            this.panelAdminFormsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminFormsLoader.Location = new System.Drawing.Point(200, 100);
            this.panelAdminFormsLoader.Name = "panelAdminFormsLoader";
            this.panelAdminFormsLoader.Size = new System.Drawing.Size(997, 626);
            this.panelAdminFormsLoader.TabIndex = 4;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 726);
            this.Controls.Add(this.panelAdminFormsLoader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMain_FormClosing);
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}