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
            this.label1 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.VenteListeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBoligCRUD = new System.Windows.Forms.Button();
            this.btnOpsigelse = new System.Windows.Forms.Button();
            this.btnTildelingBoligAdmin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAdminFormsLoader = new System.Windows.Forms.Panel();
            this.labelSlogan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN!";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(1152, 15);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(161, 73);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Log ud!";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // VenteListeButton
            // 
            this.VenteListeButton.Location = new System.Drawing.Point(37, 144);
            this.VenteListeButton.Margin = new System.Windows.Forms.Padding(1);
            this.VenteListeButton.Name = "VenteListeButton";
            this.VenteListeButton.Size = new System.Drawing.Size(199, 92);
            this.VenteListeButton.TabIndex = 0;
            this.VenteListeButton.Text = "Venteliste";
            this.VenteListeButton.UseVisualStyleBackColor = true;
            this.VenteListeButton.Click += new System.EventHandler(this.VenteListeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnBoligCRUD);
            this.panel1.Controls.Add(this.btnOpsigelse);
            this.panel1.Controls.Add(this.btnTildelingBoligAdmin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.VenteListeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 894);
            this.panel1.TabIndex = 2;
            // 
            // btnBoligCRUD
            // 
            this.btnBoligCRUD.Location = new System.Drawing.Point(37, 574);
            this.btnBoligCRUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBoligCRUD.Name = "btnBoligCRUD";
            this.btnBoligCRUD.Size = new System.Drawing.Size(199, 95);
            this.btnBoligCRUD.TabIndex = 3;
            this.btnBoligCRUD.Text = "Admin. Boliger";
            this.btnBoligCRUD.UseVisualStyleBackColor = true;
            this.btnBoligCRUD.Click += new System.EventHandler(this.btnBoligCRUD_Click);
            // 
            // btnOpsigelse
            // 
            this.btnOpsigelse.Location = new System.Drawing.Point(37, 433);
            this.btnOpsigelse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpsigelse.Name = "btnOpsigelse";
            this.btnOpsigelse.Size = new System.Drawing.Size(199, 95);
            this.btnOpsigelse.TabIndex = 2;
            this.btnOpsigelse.Text = "Opsigelse af Bolig";
            this.btnOpsigelse.UseVisualStyleBackColor = true;
            this.btnOpsigelse.Click += new System.EventHandler(this.btnOpsigelse_Click);
            // 
            // btnTildelingBoligAdmin
            // 
            this.btnTildelingBoligAdmin.Location = new System.Drawing.Point(37, 288);
            this.btnTildelingBoligAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTildelingBoligAdmin.Name = "btnTildelingBoligAdmin";
            this.btnTildelingBoligAdmin.Size = new System.Drawing.Size(199, 95);
            this.btnTildelingBoligAdmin.TabIndex = 1;
            this.btnTildelingBoligAdmin.Text = "Tildeling af Bolig";
            this.btnTildelingBoligAdmin.UseVisualStyleBackColor = true;
            this.btnTildelingBoligAdmin.Click += new System.EventHandler(this.btnTildelingBoligAdmin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.labelSlogan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 123);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.logOutButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(267, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1329, 123);
            this.panel3.TabIndex = 3;
            // 
            // panelAdminFormsLoader
            // 
            this.panelAdminFormsLoader.BackColor = System.Drawing.Color.White;
            this.panelAdminFormsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminFormsLoader.Location = new System.Drawing.Point(267, 123);
            this.panelAdminFormsLoader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAdminFormsLoader.Name = "panelAdminFormsLoader";
            this.panelAdminFormsLoader.Size = new System.Drawing.Size(1329, 771);
            this.panelAdminFormsLoader.TabIndex = 4;
            // 
            // labelSlogan
            // 
            this.labelSlogan.AutoSize = true;
            this.labelSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlogan.Location = new System.Drawing.Point(60, 71);
            this.labelSlogan.Name = "labelSlogan";
            this.labelSlogan.Size = new System.Drawing.Size(108, 29);
            this.labelSlogan.TabIndex = 0;
            this.labelSlogan.Text = "Slogan 1";
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 894);
            this.Controls.Add(this.panelAdminFormsLoader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btnTildelingBoligAdmin;
        private System.Windows.Forms.Button btnOpsigelse;
        private System.Windows.Forms.Button btnBoligCRUD;
        private System.Windows.Forms.Label labelSlogan;
    }
}