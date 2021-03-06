namespace SonderBoUdlejning.Admin
{
    partial class PersonCRUD
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
        //pSQLRunner pSQL = new pSQLRunner();
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPersonCRUD = new System.Windows.Forms.DataGridView();
            this.tbNavn = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbTlf = new System.Windows.Forms.TextBox();
            this.radioBtnMedlem = new System.Windows.Forms.RadioButton();
            this.radioBtnBeboer = new System.Windows.Forms.RadioButton();
            this.btnPersonC = new System.Windows.Forms.Button();
            this.btnPersonR = new System.Windows.Forms.Button();
            this.btnPersonU = new System.Windows.Forms.Button();
            this.btnPersonD = new System.Windows.Forms.Button();
            this.radioBtnAlt = new System.Windows.Forms.RadioButton();
            this.lblNavn = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTlf = new System.Windows.Forms.Label();
            this.tbPId = new System.Windows.Forms.TextBox();
            this.lblPId = new System.Windows.Forms.Label();
            this.panelIndhold = new System.Windows.Forms.Panel();
            this.panelRadioBtns = new System.Windows.Forms.Panel();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpret = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnOpdater = new System.Windows.Forms.Button();
            this.btnSlet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonCRUD)).BeginInit();
            this.panelIndhold.SuspendLayout();
            this.panelRadioBtns.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonCRUD
            // 
            this.dgvPersonCRUD.AllowUserToAddRows = false;
            this.dgvPersonCRUD.AllowUserToDeleteRows = false;
            this.dgvPersonCRUD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonCRUD.Location = new System.Drawing.Point(6, 6);
            this.dgvPersonCRUD.Name = "dgvPersonCRUD";
            this.dgvPersonCRUD.ReadOnly = true;
            this.dgvPersonCRUD.RowHeadersWidth = 92;
            this.dgvPersonCRUD.Size = new System.Drawing.Size(785, 251);
            this.dgvPersonCRUD.TabIndex = 0;
            // 
            // tbNavn
            // 
            this.tbNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNavn.Location = new System.Drawing.Point(7, 103);
            this.tbNavn.Name = "tbNavn";
            this.tbNavn.Size = new System.Drawing.Size(171, 29);
            this.tbNavn.TabIndex = 1;
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(7, 178);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(171, 29);
            this.tbMail.TabIndex = 2;
            // 
            // tbTlf
            // 
            this.tbTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTlf.Location = new System.Drawing.Point(7, 251);
            this.tbTlf.Name = "tbTlf";
            this.tbTlf.Size = new System.Drawing.Size(171, 29);
            this.tbTlf.TabIndex = 3;
            // 
            // radioBtnMedlem
            // 
            this.radioBtnMedlem.AutoSize = true;
            this.radioBtnMedlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMedlem.Location = new System.Drawing.Point(0, 14);
            this.radioBtnMedlem.Name = "radioBtnMedlem";
            this.radioBtnMedlem.Size = new System.Drawing.Size(130, 28);
            this.radioBtnMedlem.TabIndex = 4;
            this.radioBtnMedlem.TabStop = true;
            this.radioBtnMedlem.Text = "Medlemmer";
            this.radioBtnMedlem.UseVisualStyleBackColor = true;
            // 
            // radioBtnBeboer
            // 
            this.radioBtnBeboer.AutoSize = true;
            this.radioBtnBeboer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnBeboer.Location = new System.Drawing.Point(136, 14);
            this.radioBtnBeboer.Name = "radioBtnBeboer";
            this.radioBtnBeboer.Size = new System.Drawing.Size(101, 28);
            this.radioBtnBeboer.TabIndex = 5;
            this.radioBtnBeboer.TabStop = true;
            this.radioBtnBeboer.Text = "Beboere";
            this.radioBtnBeboer.UseVisualStyleBackColor = true;
            // 
            // btnPersonC
            // 
            this.btnPersonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonC.Location = new System.Drawing.Point(327, 72);
            this.btnPersonC.Name = "btnPersonC";
            this.btnPersonC.Size = new System.Drawing.Size(130, 49);
            this.btnPersonC.TabIndex = 6;
            this.btnPersonC.Text = "Opret Medlem";
            this.btnPersonC.UseVisualStyleBackColor = true;
            this.btnPersonC.Click += new System.EventHandler(this.btnPersonC_Click);
            // 
            // btnPersonR
            // 
            this.btnPersonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonR.Location = new System.Drawing.Point(327, 127);
            this.btnPersonR.Name = "btnPersonR";
            this.btnPersonR.Size = new System.Drawing.Size(130, 49);
            this.btnPersonR.TabIndex = 7;
            this.btnPersonR.Text = "Aflæs Medlemmer";
            this.btnPersonR.UseVisualStyleBackColor = true;
            this.btnPersonR.Click += new System.EventHandler(this.btnPersonR_Click);
            // 
            // btnPersonU
            // 
            this.btnPersonU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonU.Location = new System.Drawing.Point(327, 182);
            this.btnPersonU.Name = "btnPersonU";
            this.btnPersonU.Size = new System.Drawing.Size(130, 49);
            this.btnPersonU.TabIndex = 8;
            this.btnPersonU.Text = "Opdater Medlem";
            this.btnPersonU.UseVisualStyleBackColor = true;
            this.btnPersonU.Click += new System.EventHandler(this.btnPersonU_Click);
            // 
            // btnPersonD
            // 
            this.btnPersonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonD.Location = new System.Drawing.Point(327, 237);
            this.btnPersonD.Name = "btnPersonD";
            this.btnPersonD.Size = new System.Drawing.Size(130, 49);
            this.btnPersonD.TabIndex = 9;
            this.btnPersonD.Text = "Slet Medlemmer";
            this.btnPersonD.UseVisualStyleBackColor = true;
            this.btnPersonD.Click += new System.EventHandler(this.btnPersonD_Click);
            // 
            // radioBtnAlt
            // 
            this.radioBtnAlt.AutoSize = true;
            this.radioBtnAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAlt.Location = new System.Drawing.Point(243, 14);
            this.radioBtnAlt.Name = "radioBtnAlt";
            this.radioBtnAlt.Size = new System.Drawing.Size(109, 28);
            this.radioBtnAlt.TabIndex = 10;
            this.radioBtnAlt.TabStop = true;
            this.radioBtnAlt.Text = "Al aktivitet";
            this.radioBtnAlt.UseVisualStyleBackColor = true;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavn.Location = new System.Drawing.Point(3, 80);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(49, 20);
            this.lblNavn.TabIndex = 11;
            this.lblNavn.Text = "Navn:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(3, 155);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 20);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mail:";
            // 
            // lblTlf
            // 
            this.lblTlf.AutoSize = true;
            this.lblTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTlf.Location = new System.Drawing.Point(3, 228);
            this.lblTlf.Name = "lblTlf";
            this.lblTlf.Size = new System.Drawing.Size(124, 20);
            this.lblTlf.TabIndex = 13;
            this.lblTlf.Text = "Telefonnummer:";
            // 
            // tbPId
            // 
            this.tbPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPId.Location = new System.Drawing.Point(7, 28);
            this.tbPId.Name = "tbPId";
            this.tbPId.Size = new System.Drawing.Size(171, 29);
            this.tbPId.TabIndex = 14;
            this.tbPId.TextChanged += new System.EventHandler(this.tbPId_TextChanged);
            // 
            // lblPId
            // 
            this.lblPId.AutoSize = true;
            this.lblPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPId.Location = new System.Drawing.Point(3, 5);
            this.lblPId.Name = "lblPId";
            this.lblPId.Size = new System.Drawing.Size(84, 20);
            this.lblPId.TabIndex = 15;
            this.lblPId.Text = "Person ID:";
            // 
            // panelIndhold
            // 
            this.panelIndhold.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelIndhold.Controls.Add(this.btnPersonC);
            this.panelIndhold.Controls.Add(this.btnPersonR);
            this.panelIndhold.Controls.Add(this.panelRadioBtns);
            this.panelIndhold.Controls.Add(this.btnPersonD);
            this.panelIndhold.Controls.Add(this.btnPersonU);
            this.panelIndhold.Controls.Add(this.panelBtns);
            this.panelIndhold.Controls.Add(this.panel1);
            this.panelIndhold.Location = new System.Drawing.Point(134, 385);
            this.panelIndhold.Name = "panelIndhold";
            this.panelIndhold.Size = new System.Drawing.Size(589, 306);
            this.panelIndhold.TabIndex = 21;
            // 
            // panelRadioBtns
            // 
            this.panelRadioBtns.Controls.Add(this.radioBtnAlt);
            this.panelRadioBtns.Controls.Add(this.radioBtnBeboer);
            this.panelRadioBtns.Controls.Add(this.radioBtnMedlem);
            this.panelRadioBtns.Location = new System.Drawing.Point(220, 6);
            this.panelRadioBtns.Name = "panelRadioBtns";
            this.panelRadioBtns.Size = new System.Drawing.Size(352, 57);
            this.panelRadioBtns.TabIndex = 16;
            // 
            // panelBtns
            // 
            this.panelBtns.Location = new System.Drawing.Point(327, 72);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(130, 214);
            this.panelBtns.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPId);
            this.panel1.Controls.Add(this.tbNavn);
            this.panel1.Controls.Add(this.lblNavn);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.lblTlf);
            this.panel1.Controls.Add(this.tbPId);
            this.panel1.Controls.Add(this.tbTlf);
            this.panel1.Controls.Add(this.tbMail);
            this.panel1.Location = new System.Drawing.Point(20, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 280);
            this.panel1.TabIndex = 16;
            // 
            // btnOpret
            // 
            this.btnOpret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpret.Location = new System.Drawing.Point(33, 296);
            this.btnOpret.Name = "btnOpret";
            this.btnOpret.Size = new System.Drawing.Size(135, 66);
            this.btnOpret.TabIndex = 17;
            this.btnOpret.Text = "Opret";
            this.btnOpret.UseVisualStyleBackColor = true;
            this.btnOpret.Click += new System.EventHandler(this.btnOpretShow_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(242, 296);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(135, 66);
            this.btnRead.TabIndex = 18;
            this.btnRead.Text = "Aflæs";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnReadShow_Click);
            // 
            // btnOpdater
            // 
            this.btnOpdater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpdater.Location = new System.Drawing.Point(464, 296);
            this.btnOpdater.Name = "btnOpdater";
            this.btnOpdater.Size = new System.Drawing.Size(135, 66);
            this.btnOpdater.TabIndex = 19;
            this.btnOpdater.Text = "Opdater";
            this.btnOpdater.UseVisualStyleBackColor = true;
            this.btnOpdater.Click += new System.EventHandler(this.btnOpdaterShow_Click);
            // 
            // btnSlet
            // 
            this.btnSlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlet.Location = new System.Drawing.Point(683, 296);
            this.btnSlet.Name = "btnSlet";
            this.btnSlet.Size = new System.Drawing.Size(135, 66);
            this.btnSlet.TabIndex = 20;
            this.btnSlet.Text = "Slet";
            this.btnSlet.UseVisualStyleBackColor = true;
            this.btnSlet.Click += new System.EventHandler(this.btnSletShow_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPersonCRUD);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(27, 12);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(797, 263);
            this.panel2.TabIndex = 21;
            // 
            // PersonCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelIndhold);
            this.Controls.Add(this.btnSlet);
            this.Controls.Add(this.btnOpdater);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnOpret);
            this.Name = "PersonCRUD";
            this.Text = "PersonCRUD";
            this.Load += new System.EventHandler(this.PersonCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonCRUD)).EndInit();
            this.panelIndhold.ResumeLayout(false);
            this.panelRadioBtns.ResumeLayout(false);
            this.panelRadioBtns.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.DataGridView dgvPersonCRUD;
        internal System.Windows.Forms.DataGridView DgvPersonCRUD { get { return dgvPersonCRUD; } set { dgvPersonCRUD = value; } }
        private System.Windows.Forms.TextBox tbNavn;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbTlf;
        private System.Windows.Forms.RadioButton radioBtnMedlem;
        private System.Windows.Forms.RadioButton radioBtnBeboer;
        private System.Windows.Forms.Button btnPersonC;
        private System.Windows.Forms.Button btnPersonR;
        private System.Windows.Forms.Button btnPersonU;
        private System.Windows.Forms.Button btnPersonD;
        private System.Windows.Forms.RadioButton radioBtnAlt;
        private System.Windows.Forms.Label lblNavn;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTlf;
        private System.Windows.Forms.TextBox tbPId;
        private System.Windows.Forms.Label lblPId;
        private System.Windows.Forms.Button btnOpret;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnOpdater;
        private System.Windows.Forms.Button btnSlet;
        private System.Windows.Forms.Panel panelRadioBtns;
        private System.Windows.Forms.Panel panelIndhold;
        private System.Windows.Forms.Panel panelBtns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}