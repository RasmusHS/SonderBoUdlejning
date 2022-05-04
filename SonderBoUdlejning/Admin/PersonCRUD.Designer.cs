namespace SonderBoUdlejning.Secretary
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
        pSQLRunner pSQL = new pSQLRunner();
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pSQL.personCRUDdgv = this.dgvPersonCRUD;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonCRUD
            // 
            this.dgvPersonCRUD.AllowUserToAddRows = false;
            this.dgvPersonCRUD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonCRUD.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonCRUD.Name = "dgvPersonCRUD";
            this.dgvPersonCRUD.ReadOnly = true;
            this.dgvPersonCRUD.Size = new System.Drawing.Size(589, 209);
            this.dgvPersonCRUD.TabIndex = 0;
            // 
            // tbNavn
            // 
            this.tbNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNavn.Location = new System.Drawing.Point(12, 251);
            this.tbNavn.Name = "tbNavn";
            this.tbNavn.Size = new System.Drawing.Size(171, 29);
            this.tbNavn.TabIndex = 1;
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(12, 320);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(171, 29);
            this.tbMail.TabIndex = 2;
            // 
            // tbTlf
            // 
            this.tbTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTlf.Location = new System.Drawing.Point(12, 384);
            this.tbTlf.Name = "tbTlf";
            this.tbTlf.Size = new System.Drawing.Size(171, 29);
            this.tbTlf.TabIndex = 3;
            // 
            // radioBtnMedlem
            // 
            this.radioBtnMedlem.AutoSize = true;
            this.radioBtnMedlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMedlem.Location = new System.Drawing.Point(249, 251);
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
            this.radioBtnBeboer.Location = new System.Drawing.Point(385, 251);
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
            this.btnPersonC.Location = new System.Drawing.Point(281, 312);
            this.btnPersonC.Name = "btnPersonC";
            this.btnPersonC.Size = new System.Drawing.Size(130, 49);
            this.btnPersonC.TabIndex = 6;
            this.btnPersonC.Text = "Create";
            this.btnPersonC.UseVisualStyleBackColor = true;
            this.btnPersonC.Click += new System.EventHandler(this.btnPersonC_Click);
            // 
            // btnPersonR
            // 
            this.btnPersonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonR.Location = new System.Drawing.Point(458, 312);
            this.btnPersonR.Name = "btnPersonR";
            this.btnPersonR.Size = new System.Drawing.Size(130, 49);
            this.btnPersonR.TabIndex = 7;
            this.btnPersonR.Text = "Read";
            this.btnPersonR.UseVisualStyleBackColor = true;
            this.btnPersonR.Click += new System.EventHandler(this.btnPersonR_Click);
            // 
            // btnPersonU
            // 
            this.btnPersonU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonU.Location = new System.Drawing.Point(281, 367);
            this.btnPersonU.Name = "btnPersonU";
            this.btnPersonU.Size = new System.Drawing.Size(130, 49);
            this.btnPersonU.TabIndex = 8;
            this.btnPersonU.Text = "Update";
            this.btnPersonU.UseVisualStyleBackColor = true;
            this.btnPersonU.Click += new System.EventHandler(this.btnPersonU_Click);
            // 
            // btnPersonD
            // 
            this.btnPersonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonD.Location = new System.Drawing.Point(458, 367);
            this.btnPersonD.Name = "btnPersonD";
            this.btnPersonD.Size = new System.Drawing.Size(130, 49);
            this.btnPersonD.TabIndex = 9;
            this.btnPersonD.Text = "Delete";
            this.btnPersonD.UseVisualStyleBackColor = true;
            this.btnPersonD.Click += new System.EventHandler(this.btnPersonD_Click);
            // 
            // radioBtnAlt
            // 
            this.radioBtnAlt.AutoSize = true;
            this.radioBtnAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAlt.Location = new System.Drawing.Point(492, 251);
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
            this.lblNavn.Location = new System.Drawing.Point(9, 235);
            this.lblNavn.Name = "lblNavn";
            this.lblNavn.Size = new System.Drawing.Size(33, 13);
            this.lblNavn.TabIndex = 11;
            this.lblNavn.Text = "Navn";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(9, 304);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mail";
            // 
            // lblTlf
            // 
            this.lblTlf.AutoSize = true;
            this.lblTlf.Location = new System.Drawing.Point(9, 368);
            this.lblTlf.Name = "lblTlf";
            this.lblTlf.Size = new System.Drawing.Size(19, 13);
            this.lblTlf.TabIndex = 13;
            this.lblTlf.Text = "Tlf";
            // 
            // tbPId
            // 
            this.tbPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPId.Location = new System.Drawing.Point(281, 440);
            this.tbPId.Name = "tbPId";
            this.tbPId.Size = new System.Drawing.Size(130, 29);
            this.tbPId.TabIndex = 14;
            // 
            // lblPId
            // 
            this.lblPId.AutoSize = true;
            this.lblPId.Location = new System.Drawing.Point(278, 424);
            this.lblPId.Name = "lblPId";
            this.lblPId.Size = new System.Drawing.Size(22, 13);
            this.lblPId.TabIndex = 15;
            this.lblPId.Text = "pId";
            // 
            // PersonCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.lblPId);
            this.Controls.Add(this.tbPId);
            this.Controls.Add(this.lblTlf);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblNavn);
            this.Controls.Add(this.radioBtnAlt);
            this.Controls.Add(this.btnPersonD);
            this.Controls.Add(this.btnPersonU);
            this.Controls.Add(this.btnPersonR);
            this.Controls.Add(this.btnPersonC);
            this.Controls.Add(this.radioBtnBeboer);
            this.Controls.Add(this.radioBtnMedlem);
            this.Controls.Add(this.tbTlf);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbNavn);
            this.Controls.Add(this.dgvPersonCRUD);
            this.Name = "PersonCRUD";
            this.Text = "PersonCRUD";
            this.Load += new System.EventHandler(this.PersonCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonCRUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}