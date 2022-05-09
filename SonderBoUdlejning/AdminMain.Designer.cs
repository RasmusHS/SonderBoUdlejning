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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAdminFormsLoader = new System.Windows.Forms.Panel();
            this.btnOpsigelse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(749, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 170);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN!";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(2016, 27);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(282, 132);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Log ud!";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // VenteListeButton
            // 
            this.VenteListeButton.Location = new System.Drawing.Point(65, 261);
            this.VenteListeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VenteListeButton.Name = "VenteListeButton";
            this.VenteListeButton.Size = new System.Drawing.Size(348, 167);
            this.VenteListeButton.TabIndex = 0;
            this.VenteListeButton.Text = "Venteliste";
            this.VenteListeButton.UseVisualStyleBackColor = true;
            this.VenteListeButton.Click += new System.EventHandler(this.VenteListeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnOpsigelse);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.VenteListeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 1620);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 223);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.logOutButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(467, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2326, 223);
            this.panel3.TabIndex = 3;
            // 
            // panelAdminFormsLoader
            // 
            this.panelAdminFormsLoader.BackColor = System.Drawing.Color.White;
            this.panelAdminFormsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminFormsLoader.Location = new System.Drawing.Point(467, 223);
            this.panelAdminFormsLoader.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panelAdminFormsLoader.Name = "panelAdminFormsLoader";
            this.panelAdminFormsLoader.Size = new System.Drawing.Size(2326, 1397);
            this.panelAdminFormsLoader.TabIndex = 4;
            // 
            // btnOpsigelse
            // 
            this.btnOpsigelse.Location = new System.Drawing.Point(65, 666);
            this.btnOpsigelse.Name = "btnOpsigelse";
            this.btnOpsigelse.Size = new System.Drawing.Size(337, 110);
            this.btnOpsigelse.TabIndex = 1;
            this.btnOpsigelse.Text = "Opsig Bolig!";
            this.btnOpsigelse.UseVisualStyleBackColor = true;
            this.btnOpsigelse.Click += new System.EventHandler(this.btnOpsigelse_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2793, 1620);
            this.Controls.Add(this.panelAdminFormsLoader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnOpsigelse;
    }
}