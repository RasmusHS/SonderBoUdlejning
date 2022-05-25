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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelRadioBtns = new System.Windows.Forms.Panel();
            this.panelIndhold = new System.Windows.Forms.Panel();
            this.btnOpret = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnOpdater = new System.Windows.Forms.Button();
            this.btnSlet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonCRUD)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.panelRadioBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonCRUD
            // 
            this.dgvPersonCRUD.AllowUserToAddRows = false;
            this.dgvPersonCRUD.AllowUserToDeleteRows = false;
            this.dgvPersonCRUD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonCRUD.Location = new System.Drawing.Point(63, 58);
            this.dgvPersonCRUD.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dgvPersonCRUD.Name = "dgvPersonCRUD";
            this.dgvPersonCRUD.ReadOnly = true;
            this.dgvPersonCRUD.RowHeadersWidth = 92;
            this.dgvPersonCRUD.Size = new System.Drawing.Size(1374, 466);
            this.dgvPersonCRUD.TabIndex = 0;
            // 
            // tbNavn
            // 
            this.tbNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNavn.Location = new System.Drawing.Point(61, 196);
            this.tbNavn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbNavn.Name = "tbNavn";
            this.tbNavn.Size = new System.Drawing.Size(394, 55);
            this.tbNavn.TabIndex = 1;
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(61, 350);
            this.tbMail.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(394, 55);
            this.tbMail.TabIndex = 2;
            // 
            // tbTlf
            // 
            this.tbTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTlf.Location = new System.Drawing.Point(61, 493);
            this.tbTlf.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbTlf.Name = "tbTlf";
            this.tbTlf.Size = new System.Drawing.Size(394, 55);
            this.tbTlf.TabIndex = 3;
            // 
            // radioBtnMedlem
            // 
            this.radioBtnMedlem.AutoSize = true;
            this.radioBtnMedlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMedlem.Location = new System.Drawing.Point(0, 31);
            this.radioBtnMedlem.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.radioBtnMedlem.Name = "radioBtnMedlem";
            this.radioBtnMedlem.Size = new System.Drawing.Size(272, 52);
            this.radioBtnMedlem.TabIndex = 4;
            this.radioBtnMedlem.TabStop = true;
            this.radioBtnMedlem.Text = "Medlemmer";
            this.radioBtnMedlem.UseVisualStyleBackColor = true;
            // 
            // radioBtnBeboer
            // 
            this.radioBtnBeboer.AutoSize = true;
            this.radioBtnBeboer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnBeboer.Location = new System.Drawing.Point(317, 31);
            this.radioBtnBeboer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.radioBtnBeboer.Name = "radioBtnBeboer";
            this.radioBtnBeboer.Size = new System.Drawing.Size(208, 52);
            this.radioBtnBeboer.TabIndex = 5;
            this.radioBtnBeboer.TabStop = true;
            this.radioBtnBeboer.Text = "Beboere";
            this.radioBtnBeboer.UseVisualStyleBackColor = true;
            // 
            // btnPersonC
            // 
            this.btnPersonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonC.Location = new System.Drawing.Point(576, 283);
            this.btnPersonC.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnPersonC.Name = "btnPersonC";
            this.btnPersonC.Size = new System.Drawing.Size(303, 109);
            this.btnPersonC.TabIndex = 6;
            this.btnPersonC.Text = "Opret Medlem";
            this.btnPersonC.UseVisualStyleBackColor = true;
            this.btnPersonC.Click += new System.EventHandler(this.btnPersonC_Click);
            // 
            // btnPersonR
            // 
            this.btnPersonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonR.Location = new System.Drawing.Point(940, 283);
            this.btnPersonR.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnPersonR.Name = "btnPersonR";
            this.btnPersonR.Size = new System.Drawing.Size(303, 109);
            this.btnPersonR.TabIndex = 7;
            this.btnPersonR.Text = "Aflæs Medlemmer";
            this.btnPersonR.UseVisualStyleBackColor = true;
            this.btnPersonR.Click += new System.EventHandler(this.btnPersonR_Click);
            // 
            // btnPersonU
            // 
            this.btnPersonU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonU.Location = new System.Drawing.Point(576, 448);
            this.btnPersonU.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnPersonU.Name = "btnPersonU";
            this.btnPersonU.Size = new System.Drawing.Size(303, 109);
            this.btnPersonU.TabIndex = 8;
            this.btnPersonU.Text = "Opdater Medlem";
            this.btnPersonU.UseVisualStyleBackColor = true;
            this.btnPersonU.Click += new System.EventHandler(this.btnPersonU_Click);
            // 
            // btnPersonD
            // 
            this.btnPersonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonD.Location = new System.Drawing.Point(940, 448);
            this.btnPersonD.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnPersonD.Name = "btnPersonD";
            this.btnPersonD.Size = new System.Drawing.Size(303, 109);
            this.btnPersonD.TabIndex = 9;
            this.btnPersonD.Text = "Slet Medlemmer";
            this.btnPersonD.UseVisualStyleBackColor = true;
            this.btnPersonD.Click += new System.EventHandler(this.btnPersonD_Click);
            // 
            // radioBtnAlt
            // 
            this.radioBtnAlt.AutoSize = true;
            this.radioBtnAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAlt.Location = new System.Drawing.Point(567, 31);
            this.radioBtnAlt.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.radioBtnAlt.Name = "radioBtnAlt";
            this.radioBtnAlt.Size = new System.Drawing.Size(244, 52);
            this.radioBtnAlt.TabIndex = 10;
            this.radioBtnAlt.TabStop = true;
            this.radioBtnAlt.Text = "Al aktivitet";
            this.radioBtnAlt.UseVisualStyleBackColor = true;
            // 
            // lblNavn
            // 
            this.lblNavn.AutoSize = true;
            this.lblNavn.Location = new System.Drawing.Point(54, 161);
            this.lblNavn.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(74, 29);
            this.lblNavn.TabIndex = 11;
            this.lblNavn.Text = "Navn:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(54, 315);
            this.lblMail.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(64, 29);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mail:";
            // 
            // lblTlf
            // 
            this.lblTlf.AutoSize = true;
            this.lblTlf.Location = new System.Drawing.Point(54, 457);
            this.lblTlf.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTlf.Name = "lblTlf";
            this.lblTlf.Size = new System.Drawing.Size(190, 29);
            this.lblTlf.TabIndex = 13;
            this.lblTlf.Text = "Telefonnummer:";
            // 
            // tbPId
            // 
            this.tbPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPId.Location = new System.Drawing.Point(61, 60);
            this.tbPId.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbPId.Name = "tbPId";
            this.tbPId.Size = new System.Drawing.Size(394, 55);
            this.tbPId.TabIndex = 14;
            // 
            // lblPId
            // 
            this.lblPId.AutoSize = true;
            this.lblPId.Location = new System.Drawing.Point(54, 25);
            this.lblPId.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPId.Name = "lblPId";
            this.lblPId.Size = new System.Drawing.Size(125, 29);
            this.lblPId.TabIndex = 15;
            this.lblPId.Text = "Person ID:";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContainer.Controls.Add(this.panelRadioBtns);
            this.panelContainer.Controls.Add(this.lblPId);
            this.panelContainer.Controls.Add(this.btnPersonD);
            this.panelContainer.Controls.Add(this.tbPId);
            this.panelContainer.Controls.Add(this.btnPersonU);
            this.panelContainer.Controls.Add(this.btnPersonC);
            this.panelContainer.Controls.Add(this.btnPersonR);
            this.panelContainer.Controls.Add(this.tbNavn);
            this.panelContainer.Controls.Add(this.lblTlf);
            this.panelContainer.Controls.Add(this.tbMail);
            this.panelContainer.Controls.Add(this.lblMail);
            this.panelContainer.Controls.Add(this.tbTlf);
            this.panelContainer.Controls.Add(this.lblNavn);
            this.panelContainer.Controls.Add(this.panelIndhold);
            this.panelContainer.Location = new System.Drawing.Point(63, 792);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1374, 607);
            this.panelContainer.TabIndex = 16;
            // 
            // panelRadioBtns
            // 
            this.panelRadioBtns.Controls.Add(this.radioBtnAlt);
            this.panelRadioBtns.Controls.Add(this.radioBtnBeboer);
            this.panelRadioBtns.Controls.Add(this.radioBtnMedlem);
            this.panelRadioBtns.Location = new System.Drawing.Point(504, 25);
            this.panelRadioBtns.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panelRadioBtns.Name = "panelRadioBtns";
            this.panelRadioBtns.Size = new System.Drawing.Size(821, 100);
            this.panelRadioBtns.TabIndex = 16;
            // 
            // panelIndhold
            // 
            this.panelIndhold.Location = new System.Drawing.Point(0, 0);
            this.panelIndhold.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panelIndhold.Name = "panelIndhold";
            this.panelIndhold.Size = new System.Drawing.Size(1374, 607);
            this.panelIndhold.TabIndex = 21;
            // 
            // btnOpret
            // 
            this.btnOpret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpret.Location = new System.Drawing.Point(63, 589);
            this.btnOpret.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnOpret.Name = "btnOpret";
            this.btnOpret.Size = new System.Drawing.Size(315, 147);
            this.btnOpret.TabIndex = 17;
            this.btnOpret.Text = "Opret";
            this.btnOpret.UseVisualStyleBackColor = true;
            this.btnOpret.Click += new System.EventHandler(this.btnOpretShow_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(392, 589);
            this.btnRead.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(315, 147);
            this.btnRead.TabIndex = 18;
            this.btnRead.Text = "Aflæs";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnReadShow_Click);
            // 
            // btnOpdater
            // 
            this.btnOpdater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpdater.Location = new System.Drawing.Point(793, 589);
            this.btnOpdater.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnOpdater.Name = "btnOpdater";
            this.btnOpdater.Size = new System.Drawing.Size(315, 147);
            this.btnOpdater.TabIndex = 19;
            this.btnOpdater.Text = "Opdater";
            this.btnOpdater.UseVisualStyleBackColor = true;
            this.btnOpdater.Click += new System.EventHandler(this.btnOpdaterShow_Click);
            // 
            // btnSlet
            // 
            this.btnSlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlet.Location = new System.Drawing.Point(1122, 589);
            this.btnSlet.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSlet.Name = "btnSlet";
            this.btnSlet.Size = new System.Drawing.Size(315, 147);
            this.btnSlet.TabIndex = 20;
            this.btnSlet.Text = "Slet";
            this.btnSlet.UseVisualStyleBackColor = true;
            this.btnSlet.Click += new System.EventHandler(this.btnSletShow_Click);
            // 
            // PersonCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2032, 1425);
            this.Controls.Add(this.btnSlet);
            this.Controls.Add(this.btnOpdater);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnOpret);
            this.Controls.Add(this.dgvPersonCRUD);
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "PersonCRUD";
            this.Text = "PersonCRUD";
            this.Load += new System.EventHandler(this.PersonCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonCRUD)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelRadioBtns.ResumeLayout(false);
            this.panelRadioBtns.PerformLayout();
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
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnOpret;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnOpdater;
        private System.Windows.Forms.Button btnSlet;
        private System.Windows.Forms.Panel panelRadioBtns;
        private System.Windows.Forms.Panel panelIndhold;
    }
}