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
            this.btnOpretBorger = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSecFormsLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sekratær!";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(886, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(99, 52);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Log ud";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnOpretBorger);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 726);
            this.panel1.TabIndex = 2;
            // 
            // btnOpretBorger
            // 
            this.btnOpretBorger.Location = new System.Drawing.Point(29, 131);
            this.btnOpretBorger.Name = "btnOpretBorger";
            this.btnOpretBorger.Size = new System.Drawing.Size(130, 60);
            this.btnOpretBorger.TabIndex = 1;
            this.btnOpretBorger.Text = "Opret Borger";
            this.btnOpretBorger.UseVisualStyleBackColor = true;
            this.btnOpretBorger.Click += new System.EventHandler(this.btnOpretBorger_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
    }
}