namespace SonderBoUdlejning.Admin
{
    partial class TildelBolig
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
            this.dgvBolig = new System.Windows.Forms.DataGridView();
            this.dgvVenteliste = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblØnskerLejlighed = new System.Windows.Forms.Label();
            this.btnFindMedlemsInfo = new System.Windows.Forms.Button();
            this.tbMedlemsEmail = new System.Windows.Forms.TextBox();
            this.lblMedlemsEmail = new System.Windows.Forms.Label();
            this.lblMedlemsTLF = new System.Windows.Forms.Label();
            this.tbMedlemsTLF = new System.Windows.Forms.TextBox();
            this.tbMedlemsNavn = new System.Windows.Forms.TextBox();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblBID = new System.Windows.Forms.Label();
            this.tbPID = new System.Windows.Forms.TextBox();
            this.tbBID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMedlemsNavn = new System.Windows.Forms.Label();
            this.ckbJaTilLejlighed = new System.Windows.Forms.CheckBox();
            this.btnUdskrivLejekontrakt = new System.Windows.Forms.Button();
            this.combIndflytMåned = new System.Windows.Forms.ComboBox();
            this.tbIndflytÅrstal = new System.Windows.Forms.TextBox();
            this.lblIndflytMåned = new System.Windows.Forms.Label();
            this.lblIndflytÅrstal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ckbOpsigLejemål = new System.Windows.Forms.CheckBox();
            this.lblOpsigLejlighed = new System.Windows.Forms.Label();
            this.lblUdflytÅrstal = new System.Windows.Forms.Label();
            this.lblUdflytMåned = new System.Windows.Forms.Label();
            this.tbUdflytÅrstal = new System.Windows.Forms.TextBox();
            this.combUdflytMåned = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenteliste)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBolig
            // 
            this.dgvBolig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBolig.Location = new System.Drawing.Point(59, 67);
            this.dgvBolig.Name = "dgvBolig";
            this.dgvBolig.RowHeadersWidth = 51;
            this.dgvBolig.RowTemplate.Height = 24;
            this.dgvBolig.Size = new System.Drawing.Size(516, 203);
            this.dgvBolig.TabIndex = 0;
            // 
            // dgvVenteliste
            // 
            this.dgvVenteliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenteliste.Location = new System.Drawing.Point(635, 67);
            this.dgvVenteliste.Name = "dgvVenteliste";
            this.dgvVenteliste.RowHeadersWidth = 51;
            this.dgvVenteliste.RowTemplate.Height = 24;
            this.dgvVenteliste.Size = new System.Drawing.Size(439, 203);
            this.dgvVenteliste.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bolig tabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Venteliste";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnFindMedlemsInfo);
            this.panel1.Controls.Add(this.tbMedlemsEmail);
            this.panel1.Controls.Add(this.tbMedlemsTLF);
            this.panel1.Controls.Add(this.tbMedlemsNavn);
            this.panel1.Controls.Add(this.lblPID);
            this.panel1.Controls.Add(this.lblBID);
            this.panel1.Controls.Add(this.tbPID);
            this.panel1.Controls.Add(this.tbBID);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(59, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 329);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.lblIndflytÅrstal);
            this.panel3.Controls.Add(this.lblIndflytMåned);
            this.panel3.Controls.Add(this.tbIndflytÅrstal);
            this.panel3.Controls.Add(this.combIndflytMåned);
            this.panel3.Controls.Add(this.btnUdskrivLejekontrakt);
            this.panel3.Controls.Add(this.ckbJaTilLejlighed);
            this.panel3.Controls.Add(this.lblØnskerLejlighed);
            this.panel3.Location = new System.Drawing.Point(576, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 265);
            this.panel3.TabIndex = 15;
            // 
            // lblØnskerLejlighed
            // 
            this.lblØnskerLejlighed.AutoSize = true;
            this.lblØnskerLejlighed.Location = new System.Drawing.Point(53, 16);
            this.lblØnskerLejlighed.Name = "lblØnskerLejlighed";
            this.lblØnskerLejlighed.Size = new System.Drawing.Size(204, 16);
            this.lblØnskerLejlighed.TabIndex = 16;
            this.lblØnskerLejlighed.Text = "Ønsker Medlemmet Lejligheden?";
            // 
            // btnFindMedlemsInfo
            // 
            this.btnFindMedlemsInfo.Location = new System.Drawing.Point(355, 32);
            this.btnFindMedlemsInfo.Name = "btnFindMedlemsInfo";
            this.btnFindMedlemsInfo.Size = new System.Drawing.Size(127, 55);
            this.btnFindMedlemsInfo.TabIndex = 13;
            this.btnFindMedlemsInfo.Text = "FIND INFO";
            this.btnFindMedlemsInfo.UseVisualStyleBackColor = true;
            // 
            // tbMedlemsEmail
            // 
            this.tbMedlemsEmail.Location = new System.Drawing.Point(225, 226);
            this.tbMedlemsEmail.Name = "tbMedlemsEmail";
            this.tbMedlemsEmail.Size = new System.Drawing.Size(100, 22);
            this.tbMedlemsEmail.TabIndex = 12;
            // 
            // lblMedlemsEmail
            // 
            this.lblMedlemsEmail.AutoSize = true;
            this.lblMedlemsEmail.Location = new System.Drawing.Point(29, 181);
            this.lblMedlemsEmail.Name = "lblMedlemsEmail";
            this.lblMedlemsEmail.Size = new System.Drawing.Size(100, 16);
            this.lblMedlemsEmail.TabIndex = 11;
            this.lblMedlemsEmail.Text = "Medlems Email";
            // 
            // lblMedlemsTLF
            // 
            this.lblMedlemsTLF.AutoSize = true;
            this.lblMedlemsTLF.Location = new System.Drawing.Point(29, 95);
            this.lblMedlemsTLF.Name = "lblMedlemsTLF";
            this.lblMedlemsTLF.Size = new System.Drawing.Size(90, 16);
            this.lblMedlemsTLF.TabIndex = 9;
            this.lblMedlemsTLF.Text = "Medlems TLF";
            // 
            // tbMedlemsTLF
            // 
            this.tbMedlemsTLF.Location = new System.Drawing.Point(225, 142);
            this.tbMedlemsTLF.Name = "tbMedlemsTLF";
            this.tbMedlemsTLF.Size = new System.Drawing.Size(100, 22);
            this.tbMedlemsTLF.TabIndex = 8;
            // 
            // tbMedlemsNavn
            // 
            this.tbMedlemsNavn.Location = new System.Drawing.Point(225, 64);
            this.tbMedlemsNavn.Name = "tbMedlemsNavn";
            this.tbMedlemsNavn.Size = new System.Drawing.Size(100, 22);
            this.tbMedlemsNavn.TabIndex = 7;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPID.Location = new System.Drawing.Point(35, 111);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(68, 16);
            this.lblPID.TabIndex = 6;
            this.lblPID.Text = "Indtast pId";
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Location = new System.Drawing.Point(35, 31);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(68, 16);
            this.lblBID.TabIndex = 5;
            this.lblBID.Text = "Indtast bId";
            // 
            // tbPID
            // 
            this.tbPID.Location = new System.Drawing.Point(38, 142);
            this.tbPID.Name = "tbPID";
            this.tbPID.Size = new System.Drawing.Size(100, 22);
            this.tbPID.TabIndex = 1;
            // 
            // tbBID
            // 
            this.tbBID.Location = new System.Drawing.Point(38, 65);
            this.tbBID.Name = "tbBID";
            this.tbBID.Size = new System.Drawing.Size(100, 22);
            this.tbBID.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lblMedlemsNavn);
            this.panel2.Controls.Add(this.lblMedlemsTLF);
            this.panel2.Controls.Add(this.lblMedlemsEmail);
            this.panel2.Location = new System.Drawing.Point(193, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 265);
            this.panel2.TabIndex = 14;
            // 
            // lblMedlemsNavn
            // 
            this.lblMedlemsNavn.AutoSize = true;
            this.lblMedlemsNavn.Location = new System.Drawing.Point(29, 16);
            this.lblMedlemsNavn.Name = "lblMedlemsNavn";
            this.lblMedlemsNavn.Size = new System.Drawing.Size(95, 16);
            this.lblMedlemsNavn.TabIndex = 10;
            this.lblMedlemsNavn.Text = "Medlems navn";
            // 
            // ckbJaTilLejlighed
            // 
            this.ckbJaTilLejlighed.AutoSize = true;
            this.ckbJaTilLejlighed.Location = new System.Drawing.Point(56, 50);
            this.ckbJaTilLejlighed.Name = "ckbJaTilLejlighed";
            this.ckbJaTilLejlighed.Size = new System.Drawing.Size(234, 20);
            this.ckbJaTilLejlighed.TabIndex = 17;
            this.ckbJaTilLejlighed.Text = "Ja Medlemmet ønsker lejligheden.";
            this.ckbJaTilLejlighed.UseVisualStyleBackColor = true;
            // 
            // btnUdskrivLejekontrakt
            // 
            this.btnUdskrivLejekontrakt.Location = new System.Drawing.Point(56, 179);
            this.btnUdskrivLejekontrakt.Name = "btnUdskrivLejekontrakt";
            this.btnUdskrivLejekontrakt.Size = new System.Drawing.Size(326, 53);
            this.btnUdskrivLejekontrakt.TabIndex = 18;
            this.btnUdskrivLejekontrakt.Text = "Udskriv Lejekontrakt";
            this.btnUdskrivLejekontrakt.UseVisualStyleBackColor = true;
            // 
            // combIndflytMåned
            // 
            this.combIndflytMåned.FormattingEnabled = true;
            this.combIndflytMåned.Location = new System.Drawing.Point(60, 116);
            this.combIndflytMåned.Name = "combIndflytMåned";
            this.combIndflytMåned.Size = new System.Drawing.Size(121, 24);
            this.combIndflytMåned.TabIndex = 19;
            // 
            // tbIndflytÅrstal
            // 
            this.tbIndflytÅrstal.Location = new System.Drawing.Point(218, 116);
            this.tbIndflytÅrstal.Name = "tbIndflytÅrstal";
            this.tbIndflytÅrstal.Size = new System.Drawing.Size(100, 22);
            this.tbIndflytÅrstal.TabIndex = 20;
            // 
            // lblIndflytMåned
            // 
            this.lblIndflytMåned.AutoSize = true;
            this.lblIndflytMåned.Location = new System.Drawing.Point(57, 97);
            this.lblIndflytMåned.Name = "lblIndflytMåned";
            this.lblIndflytMåned.Size = new System.Drawing.Size(49, 16);
            this.lblIndflytMåned.TabIndex = 16;
            this.lblIndflytMåned.Text = "Måned";
            // 
            // lblIndflytÅrstal
            // 
            this.lblIndflytÅrstal.AutoSize = true;
            this.lblIndflytÅrstal.Location = new System.Drawing.Point(215, 97);
            this.lblIndflytÅrstal.Name = "lblIndflytÅrstal";
            this.lblIndflytÅrstal.Size = new System.Drawing.Size(41, 16);
            this.lblIndflytÅrstal.TabIndex = 21;
            this.lblIndflytÅrstal.Text = "Årstal";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.lblUdflytÅrstal);
            this.panel4.Controls.Add(this.lblOpsigLejlighed);
            this.panel4.Controls.Add(this.lblUdflytMåned);
            this.panel4.Controls.Add(this.ckbOpsigLejemål);
            this.panel4.Controls.Add(this.tbUdflytÅrstal);
            this.panel4.Controls.Add(this.combUdflytMåned);
            this.panel4.Location = new System.Drawing.Point(59, 656);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1015, 188);
            this.panel4.TabIndex = 5;
            // 
            // ckbOpsigLejemål
            // 
            this.ckbOpsigLejemål.AutoSize = true;
            this.ckbOpsigLejemål.Location = new System.Drawing.Point(112, 99);
            this.ckbOpsigLejemål.Name = "ckbOpsigLejemål";
            this.ckbOpsigLejemål.Size = new System.Drawing.Size(266, 20);
            this.ckbOpsigLejemål.TabIndex = 22;
            this.ckbOpsigLejemål.Text = "Medlemmet ønsker at opsige sit lejemål";
            this.ckbOpsigLejemål.UseVisualStyleBackColor = true;
            // 
            // lblOpsigLejlighed
            // 
            this.lblOpsigLejlighed.AutoSize = true;
            this.lblOpsigLejlighed.Location = new System.Drawing.Point(461, 14);
            this.lblOpsigLejlighed.Name = "lblOpsigLejlighed";
            this.lblOpsigLejlighed.Size = new System.Drawing.Size(141, 16);
            this.lblOpsigLejlighed.TabIndex = 22;
            this.lblOpsigLejlighed.Text = "Opsigelse af Lejlighed";
            // 
            // lblUdflytÅrstal
            // 
            this.lblUdflytÅrstal.AutoSize = true;
            this.lblUdflytÅrstal.Location = new System.Drawing.Point(629, 72);
            this.lblUdflytÅrstal.Name = "lblUdflytÅrstal";
            this.lblUdflytÅrstal.Size = new System.Drawing.Size(41, 16);
            this.lblUdflytÅrstal.TabIndex = 25;
            this.lblUdflytÅrstal.Text = "Årstal";
            // 
            // lblUdflytMåned
            // 
            this.lblUdflytMåned.AutoSize = true;
            this.lblUdflytMåned.Location = new System.Drawing.Point(453, 76);
            this.lblUdflytMåned.Name = "lblUdflytMåned";
            this.lblUdflytMåned.Size = new System.Drawing.Size(49, 16);
            this.lblUdflytMåned.TabIndex = 22;
            this.lblUdflytMåned.Text = "Måned";
            // 
            // tbUdflytÅrstal
            // 
            this.tbUdflytÅrstal.Location = new System.Drawing.Point(632, 97);
            this.tbUdflytÅrstal.Name = "tbUdflytÅrstal";
            this.tbUdflytÅrstal.Size = new System.Drawing.Size(100, 22);
            this.tbUdflytÅrstal.TabIndex = 24;
            // 
            // combUdflytMåned
            // 
            this.combUdflytMåned.FormattingEnabled = true;
            this.combUdflytMåned.Location = new System.Drawing.Point(456, 95);
            this.combUdflytMåned.Name = "combUdflytMåned";
            this.combUdflytMåned.Size = new System.Drawing.Size(121, 24);
            this.combUdflytMåned.TabIndex = 23;
            // 
            // TildelBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 863);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVenteliste);
            this.Controls.Add(this.dgvBolig);
            this.Controls.Add(this.panel1);
            this.Name = "TildelBolig";
            this.Text = "TildelBolig";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenteliste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBolig;
        private System.Windows.Forms.DataGridView dgvVenteliste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMedlemsNavn;
        private System.Windows.Forms.Label lblMedlemsTLF;
        private System.Windows.Forms.TextBox tbMedlemsTLF;
        private System.Windows.Forms.TextBox tbMedlemsNavn;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.TextBox tbPID;
        private System.Windows.Forms.TextBox tbBID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblØnskerLejlighed;
        private System.Windows.Forms.Button btnFindMedlemsInfo;
        private System.Windows.Forms.TextBox tbMedlemsEmail;
        private System.Windows.Forms.Label lblMedlemsEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIndflytÅrstal;
        private System.Windows.Forms.Label lblIndflytMåned;
        private System.Windows.Forms.TextBox tbIndflytÅrstal;
        private System.Windows.Forms.ComboBox combIndflytMåned;
        private System.Windows.Forms.Button btnUdskrivLejekontrakt;
        private System.Windows.Forms.CheckBox ckbJaTilLejlighed;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUdflytÅrstal;
        private System.Windows.Forms.Label lblOpsigLejlighed;
        private System.Windows.Forms.Label lblUdflytMåned;
        private System.Windows.Forms.CheckBox ckbOpsigLejemål;
        private System.Windows.Forms.TextBox tbUdflytÅrstal;
        private System.Windows.Forms.ComboBox combUdflytMåned;
    }
}