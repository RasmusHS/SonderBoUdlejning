namespace SonderBoUdlejning
{
    partial class SecretaryMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReservationer = new System.Windows.Forms.Button();
            this.btnLejemaalCRUD = new System.Windows.Forms.Button();
            this.btnOpsigLejemaal = new System.Windows.Forms.Button();
            this.btnTildelLejemaal = new System.Windows.Forms.Button();
            this.btnOpretBorger = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSlogan = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSecFormsLoader = new System.Windows.Forms.Panel();
            this.btnVenteliste = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sekratær!";
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Red;
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(898, 0);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(99, 100);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Log ud";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.btnReservationer);
            this.panel1.Controls.Add(this.btnLejemaalCRUD);
            this.panel1.Controls.Add(this.btnOpsigLejemaal);
            this.panel1.Controls.Add(this.btnTildelLejemaal);
            this.panel1.Controls.Add(this.btnVenteliste);
            this.panel1.Controls.Add(this.btnOpretBorger);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 726);
            this.panel1.TabIndex = 2;
            // 
            // btnReservationer
            // 
            this.btnReservationer.BackColor = System.Drawing.Color.LightGreen;
            this.btnReservationer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservationer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationer.Location = new System.Drawing.Point(0, 400);
            this.btnReservationer.Name = "btnReservationer";
            this.btnReservationer.Size = new System.Drawing.Size(200, 60);
            this.btnReservationer.TabIndex = 5;
            this.btnReservationer.Text = "Reservationer";
            this.btnReservationer.UseVisualStyleBackColor = false;
            this.btnReservationer.Click += new System.EventHandler(this.btnReservationer_Click);
            // 
            // btnLejemaalCRUD
            // 
            this.btnLejemaalCRUD.BackColor = System.Drawing.Color.LightGreen;
            this.btnLejemaalCRUD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLejemaalCRUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLejemaalCRUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLejemaalCRUD.Location = new System.Drawing.Point(0, 340);
            this.btnLejemaalCRUD.Name = "btnLejemaalCRUD";
            this.btnLejemaalCRUD.Size = new System.Drawing.Size(200, 60);
            this.btnLejemaalCRUD.TabIndex = 4;
            this.btnLejemaalCRUD.Text = "Søg Lejemål";
            this.btnLejemaalCRUD.UseVisualStyleBackColor = false;
            this.btnLejemaalCRUD.Click += new System.EventHandler(this.btnLejemaalCRUD_Click);
            // 
            // btnOpsigLejemaal
            // 
            this.btnOpsigLejemaal.BackColor = System.Drawing.Color.LightGreen;
            this.btnOpsigLejemaal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpsigLejemaal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpsigLejemaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpsigLejemaal.Location = new System.Drawing.Point(0, 280);
            this.btnOpsigLejemaal.Name = "btnOpsigLejemaal";
            this.btnOpsigLejemaal.Size = new System.Drawing.Size(200, 60);
            this.btnOpsigLejemaal.TabIndex = 3;
            this.btnOpsigLejemaal.Text = "Opsig Lejemål";
            this.btnOpsigLejemaal.UseVisualStyleBackColor = false;
            this.btnOpsigLejemaal.Click += new System.EventHandler(this.btnOpsigLejemaal_Click);
            // 
            // btnTildelLejemaal
            // 
            this.btnTildelLejemaal.BackColor = System.Drawing.Color.LightGreen;
            this.btnTildelLejemaal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTildelLejemaal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTildelLejemaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTildelLejemaal.Location = new System.Drawing.Point(0, 220);
            this.btnTildelLejemaal.Name = "btnTildelLejemaal";
            this.btnTildelLejemaal.Size = new System.Drawing.Size(200, 60);
            this.btnTildelLejemaal.TabIndex = 2;
            this.btnTildelLejemaal.Text = "Tildel Lejemål";
            this.btnTildelLejemaal.UseVisualStyleBackColor = false;
            this.btnTildelLejemaal.Click += new System.EventHandler(this.btnTildelLejemaal_Click);
            // 
            // btnOpretBorger
            // 
            this.btnOpretBorger.BackColor = System.Drawing.Color.LightGreen;
            this.btnOpretBorger.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpretBorger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpretBorger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpretBorger.Location = new System.Drawing.Point(0, 100);
            this.btnOpretBorger.Name = "btnOpretBorger";
            this.btnOpretBorger.Size = new System.Drawing.Size(200, 60);
            this.btnOpretBorger.TabIndex = 1;
            this.btnOpretBorger.Text = "Opret Borger";
            this.btnOpretBorger.UseVisualStyleBackColor = false;
            this.btnOpretBorger.Click += new System.EventHandler(this.btnOpretBorger_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // labelSlogan
            // 
            this.labelSlogan.AutoSize = true;
            this.labelSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlogan.Location = new System.Drawing.Point(2, 74);
            this.labelSlogan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSlogan.Name = "labelSlogan";
            this.labelSlogan.Size = new System.Drawing.Size(305, 26);
            this.labelSlogan.TabIndex = 5;
            this.labelSlogan.Text = "Bo godt – bo hos SønderBo (1)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Controls.Add(this.labelSlogan);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.logOutButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 100);
            this.panel3.TabIndex = 3;
            // 
            // panelSecFormsLoader
            // 
            this.panelSecFormsLoader.BackColor = System.Drawing.Color.White;
            this.panelSecFormsLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSecFormsLoader.Location = new System.Drawing.Point(200, 100);
            this.panelSecFormsLoader.Name = "panelSecFormsLoader";
            this.panelSecFormsLoader.Size = new System.Drawing.Size(997, 626);
            this.panelSecFormsLoader.TabIndex = 4;
            // 
            // btnVenteliste
            // 
            this.btnVenteliste.BackColor = System.Drawing.Color.LightGreen;
            this.btnVenteliste.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenteliste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenteliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenteliste.Location = new System.Drawing.Point(0, 160);
            this.btnVenteliste.Name = "btnVenteliste";
            this.btnVenteliste.Size = new System.Drawing.Size(200, 60);
            this.btnVenteliste.TabIndex = 6;
            this.btnVenteliste.Text = "Venteliste";
            this.btnVenteliste.UseVisualStyleBackColor = false;
            this.btnVenteliste.Click += new System.EventHandler(this.btnVenteliste_Click);
            // 
            // SecretaryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 726);
            this.Controls.Add(this.panelSecFormsLoader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "SecretaryMain";
            this.Text = "SecretaryMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecretaryMain_FormClosing);
            this.Load += new System.EventHandler(this.SecretaryMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelSecFormsLoader;
        internal System.Windows.Forms.Panel PanelSecFormsLoader { get { return panelSecFormsLoader; } set { panelSecFormsLoader = value; } }
        private System.Windows.Forms.Button btnOpretBorger;
        private System.Windows.Forms.Label labelSlogan;
        private System.Windows.Forms.Button btnTildelLejemaal;
        private System.Windows.Forms.Button btnReservationer;
        private System.Windows.Forms.Button btnLejemaalCRUD;
        private System.Windows.Forms.Button btnOpsigLejemaal;
        private System.Windows.Forms.Button btnVenteliste;
    }
}