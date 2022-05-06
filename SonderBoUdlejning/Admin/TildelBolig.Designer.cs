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
            this.panelBaggrund = new System.Windows.Forms.Panel();
            this.panelØnskerLejlighed = new System.Windows.Forms.Panel();
            this.lblIndflytÅrstal = new System.Windows.Forms.Label();
            this.lblIndflytMåned = new System.Windows.Forms.Label();
            this.tbIndflytÅrstal = new System.Windows.Forms.TextBox();
            this.combIndflytMåned = new System.Windows.Forms.ComboBox();
            this.btnUdskrivLejekontrakt = new System.Windows.Forms.Button();
            this.ckbJaTilLejlighed = new System.Windows.Forms.CheckBox();
            this.lblØnskerLejlighed = new System.Windows.Forms.Label();
            this.tbMedlemsEmail = new System.Windows.Forms.TextBox();
            this.tbMedlemsTLF = new System.Windows.Forms.TextBox();
            this.tbMedlemsNavn = new System.Windows.Forms.TextBox();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblBID = new System.Windows.Forms.Label();
            this.tbPID = new System.Windows.Forms.TextBox();
            this.tbBID = new System.Windows.Forms.TextBox();
            this.panelPid = new System.Windows.Forms.Panel();
            this.lblMedlemsNavn = new System.Windows.Forms.Label();
            this.btnFindMedlemsInfo = new System.Windows.Forms.Button();
            this.lblMedlemsTLF = new System.Windows.Forms.Label();
            this.lblMedlemsEmail = new System.Windows.Forms.Label();
            this.panelBid = new System.Windows.Forms.Panel();
            this.panelMedlemsinfo = new System.Windows.Forms.Panel();
            this.panelUdskrivLejekontrakt = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenteliste)).BeginInit();
            this.panelBaggrund.SuspendLayout();
            this.panelØnskerLejlighed.SuspendLayout();
            this.panelPid.SuspendLayout();
            this.panelBid.SuspendLayout();
            this.panelMedlemsinfo.SuspendLayout();
            this.panelUdskrivLejekontrakt.SuspendLayout();
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
            // panelBaggrund
            // 
            this.panelBaggrund.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBaggrund.Controls.Add(this.panelØnskerLejlighed);
            this.panelBaggrund.Controls.Add(this.tbBID);
            this.panelBaggrund.Controls.Add(this.panelPid);
            this.panelBaggrund.Controls.Add(this.panelBid);
            this.panelBaggrund.Location = new System.Drawing.Point(59, 303);
            this.panelBaggrund.Name = "panelBaggrund";
            this.panelBaggrund.Size = new System.Drawing.Size(1015, 398);
            this.panelBaggrund.TabIndex = 4;
            // 
            // panelØnskerLejlighed
            // 
            this.panelØnskerLejlighed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelØnskerLejlighed.Controls.Add(this.panelUdskrivLejekontrakt);
            this.panelØnskerLejlighed.Controls.Add(this.ckbJaTilLejlighed);
            this.panelØnskerLejlighed.Controls.Add(this.lblØnskerLejlighed);
            this.panelØnskerLejlighed.Location = new System.Drawing.Point(26, 200);
            this.panelØnskerLejlighed.Name = "panelØnskerLejlighed";
            this.panelØnskerLejlighed.Size = new System.Drawing.Size(968, 156);
            this.panelØnskerLejlighed.TabIndex = 15;
            this.panelØnskerLejlighed.Visible = false;
            // 
            // lblIndflytÅrstal
            // 
            this.lblIndflytÅrstal.AutoSize = true;
            this.lblIndflytÅrstal.Location = new System.Drawing.Point(169, 32);
            this.lblIndflytÅrstal.Name = "lblIndflytÅrstal";
            this.lblIndflytÅrstal.Size = new System.Drawing.Size(41, 16);
            this.lblIndflytÅrstal.TabIndex = 21;
            this.lblIndflytÅrstal.Text = "Årstal";
            // 
            // lblIndflytMåned
            // 
            this.lblIndflytMåned.AutoSize = true;
            this.lblIndflytMåned.Location = new System.Drawing.Point(11, 32);
            this.lblIndflytMåned.Name = "lblIndflytMåned";
            this.lblIndflytMåned.Size = new System.Drawing.Size(49, 16);
            this.lblIndflytMåned.TabIndex = 16;
            this.lblIndflytMåned.Text = "Måned";
            // 
            // tbIndflytÅrstal
            // 
            this.tbIndflytÅrstal.Location = new System.Drawing.Point(172, 51);
            this.tbIndflytÅrstal.Name = "tbIndflytÅrstal";
            this.tbIndflytÅrstal.Size = new System.Drawing.Size(100, 22);
            this.tbIndflytÅrstal.TabIndex = 20;
            // 
            // combIndflytMåned
            // 
            this.combIndflytMåned.FormattingEnabled = true;
            this.combIndflytMåned.Location = new System.Drawing.Point(14, 51);
            this.combIndflytMåned.Name = "combIndflytMåned";
            this.combIndflytMåned.Size = new System.Drawing.Size(121, 24);
            this.combIndflytMåned.TabIndex = 19;
            // 
            // btnUdskrivLejekontrakt
            // 
            this.btnUdskrivLejekontrakt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUdskrivLejekontrakt.Location = new System.Drawing.Point(298, 20);
            this.btnUdskrivLejekontrakt.Name = "btnUdskrivLejekontrakt";
            this.btnUdskrivLejekontrakt.Size = new System.Drawing.Size(326, 53);
            this.btnUdskrivLejekontrakt.TabIndex = 18;
            this.btnUdskrivLejekontrakt.Text = "Udskriv Lejekontrakt";
            this.btnUdskrivLejekontrakt.UseVisualStyleBackColor = false;
            this.btnUdskrivLejekontrakt.Click += new System.EventHandler(this.btnUdskrivLejekontrakt_Click);
            // 
            // ckbJaTilLejlighed
            // 
            this.ckbJaTilLejlighed.AutoSize = true;
            this.ckbJaTilLejlighed.Location = new System.Drawing.Point(56, 72);
            this.ckbJaTilLejlighed.Name = "ckbJaTilLejlighed";
            this.ckbJaTilLejlighed.Size = new System.Drawing.Size(234, 20);
            this.ckbJaTilLejlighed.TabIndex = 17;
            this.ckbJaTilLejlighed.Text = "Ja Medlemmet ønsker lejligheden.";
            this.ckbJaTilLejlighed.UseVisualStyleBackColor = true;
            this.ckbJaTilLejlighed.CheckedChanged += new System.EventHandler(this.ckbJaTilLejlighed_CheckedChanged);
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
            // tbMedlemsEmail
            // 
            this.tbMedlemsEmail.Location = new System.Drawing.Point(271, 56);
            this.tbMedlemsEmail.Name = "tbMedlemsEmail";
            this.tbMedlemsEmail.Size = new System.Drawing.Size(100, 22);
            this.tbMedlemsEmail.TabIndex = 12;
            // 
            // tbMedlemsTLF
            // 
            this.tbMedlemsTLF.Location = new System.Drawing.Point(146, 56);
            this.tbMedlemsTLF.Name = "tbMedlemsTLF";
            this.tbMedlemsTLF.Size = new System.Drawing.Size(100, 22);
            this.tbMedlemsTLF.TabIndex = 8;
            // 
            // tbMedlemsNavn
            // 
            this.tbMedlemsNavn.Location = new System.Drawing.Point(10, 56);
            this.tbMedlemsNavn.Name = "tbMedlemsNavn";
            this.tbMedlemsNavn.Size = new System.Drawing.Size(100, 22);
            this.tbMedlemsNavn.TabIndex = 7;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPID.Location = new System.Drawing.Point(54, 50);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(68, 16);
            this.lblPID.TabIndex = 6;
            this.lblPID.Text = "Indtast pId";
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Location = new System.Drawing.Point(28, 46);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(68, 16);
            this.lblBID.TabIndex = 5;
            this.lblBID.Text = "Indtast bId";
            // 
            // tbPID
            // 
            this.tbPID.Location = new System.Drawing.Point(57, 79);
            this.tbPID.Name = "tbPID";
            this.tbPID.Size = new System.Drawing.Size(100, 22);
            this.tbPID.TabIndex = 1;
            // 
            // tbBID
            // 
            this.tbBID.Location = new System.Drawing.Point(57, 95);
            this.tbBID.Name = "tbBID";
            this.tbBID.Size = new System.Drawing.Size(100, 22);
            this.tbBID.TabIndex = 0;
            this.tbBID.TextChanged += new System.EventHandler(this.tbBID_TextChanged);
            // 
            // panelPid
            // 
            this.panelPid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPid.Controls.Add(this.panelMedlemsinfo);
            this.panelPid.Controls.Add(this.lblPID);
            this.panelPid.Controls.Add(this.tbPID);
            this.panelPid.Controls.Add(this.btnFindMedlemsInfo);
            this.panelPid.Location = new System.Drawing.Point(264, 16);
            this.panelPid.Name = "panelPid";
            this.panelPid.Size = new System.Drawing.Size(730, 158);
            this.panelPid.TabIndex = 14;
            this.panelPid.Visible = false;
            // 
            // lblMedlemsNavn
            // 
            this.lblMedlemsNavn.AutoSize = true;
            this.lblMedlemsNavn.Location = new System.Drawing.Point(7, 27);
            this.lblMedlemsNavn.Name = "lblMedlemsNavn";
            this.lblMedlemsNavn.Size = new System.Drawing.Size(95, 16);
            this.lblMedlemsNavn.TabIndex = 10;
            this.lblMedlemsNavn.Text = "Medlems navn";
            // 
            // btnFindMedlemsInfo
            // 
            this.btnFindMedlemsInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFindMedlemsInfo.Location = new System.Drawing.Point(192, 49);
            this.btnFindMedlemsInfo.Name = "btnFindMedlemsInfo";
            this.btnFindMedlemsInfo.Size = new System.Drawing.Size(127, 55);
            this.btnFindMedlemsInfo.TabIndex = 13;
            this.btnFindMedlemsInfo.Text = "FIND INFO";
            this.btnFindMedlemsInfo.UseVisualStyleBackColor = false;
            this.btnFindMedlemsInfo.Click += new System.EventHandler(this.btnFindMedlemsInfo_Click);
            // 
            // lblMedlemsTLF
            // 
            this.lblMedlemsTLF.AutoSize = true;
            this.lblMedlemsTLF.Location = new System.Drawing.Point(143, 27);
            this.lblMedlemsTLF.Name = "lblMedlemsTLF";
            this.lblMedlemsTLF.Size = new System.Drawing.Size(90, 16);
            this.lblMedlemsTLF.TabIndex = 9;
            this.lblMedlemsTLF.Text = "Medlems TLF";
            // 
            // lblMedlemsEmail
            // 
            this.lblMedlemsEmail.AutoSize = true;
            this.lblMedlemsEmail.Location = new System.Drawing.Point(268, 27);
            this.lblMedlemsEmail.Name = "lblMedlemsEmail";
            this.lblMedlemsEmail.Size = new System.Drawing.Size(100, 16);
            this.lblMedlemsEmail.TabIndex = 11;
            this.lblMedlemsEmail.Text = "Medlems Email";
            // 
            // panelBid
            // 
            this.panelBid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBid.Controls.Add(this.lblBID);
            this.panelBid.Location = new System.Drawing.Point(26, 20);
            this.panelBid.Name = "panelBid";
            this.panelBid.Size = new System.Drawing.Size(204, 154);
            this.panelBid.TabIndex = 16;
            // 
            // panelMedlemsinfo
            // 
            this.panelMedlemsinfo.Controls.Add(this.lblMedlemsNavn);
            this.panelMedlemsinfo.Controls.Add(this.tbMedlemsNavn);
            this.panelMedlemsinfo.Controls.Add(this.tbMedlemsTLF);
            this.panelMedlemsinfo.Controls.Add(this.tbMedlemsEmail);
            this.panelMedlemsinfo.Controls.Add(this.lblMedlemsTLF);
            this.panelMedlemsinfo.Controls.Add(this.lblMedlemsEmail);
            this.panelMedlemsinfo.Location = new System.Drawing.Point(337, 22);
            this.panelMedlemsinfo.Name = "panelMedlemsinfo";
            this.panelMedlemsinfo.Size = new System.Drawing.Size(381, 117);
            this.panelMedlemsinfo.TabIndex = 14;
            this.panelMedlemsinfo.Visible = false;
            // 
            // panelUdskrivLejekontrakt
            // 
            this.panelUdskrivLejekontrakt.Controls.Add(this.lblIndflytÅrstal);
            this.panelUdskrivLejekontrakt.Controls.Add(this.lblIndflytMåned);
            this.panelUdskrivLejekontrakt.Controls.Add(this.tbIndflytÅrstal);
            this.panelUdskrivLejekontrakt.Controls.Add(this.combIndflytMåned);
            this.panelUdskrivLejekontrakt.Controls.Add(this.btnUdskrivLejekontrakt);
            this.panelUdskrivLejekontrakt.Location = new System.Drawing.Point(322, 31);
            this.panelUdskrivLejekontrakt.Name = "panelUdskrivLejekontrakt";
            this.panelUdskrivLejekontrakt.Size = new System.Drawing.Size(633, 101);
            this.panelUdskrivLejekontrakt.TabIndex = 22;
            this.panelUdskrivLejekontrakt.Visible = false;
            // 
            // TildelBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 728);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVenteliste);
            this.Controls.Add(this.dgvBolig);
            this.Controls.Add(this.panelBaggrund);
            this.Name = "TildelBolig";
            this.Text = "TildelBolig";
            this.Load += new System.EventHandler(this.TildelBolig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenteliste)).EndInit();
            this.panelBaggrund.ResumeLayout(false);
            this.panelBaggrund.PerformLayout();
            this.panelØnskerLejlighed.ResumeLayout(false);
            this.panelØnskerLejlighed.PerformLayout();
            this.panelPid.ResumeLayout(false);
            this.panelPid.PerformLayout();
            this.panelBid.ResumeLayout(false);
            this.panelBid.PerformLayout();
            this.panelMedlemsinfo.ResumeLayout(false);
            this.panelMedlemsinfo.PerformLayout();
            this.panelUdskrivLejekontrakt.ResumeLayout(false);
            this.panelUdskrivLejekontrakt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBolig;
        private System.Windows.Forms.DataGridView dgvVenteliste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBaggrund;
        private System.Windows.Forms.Label lblMedlemsNavn;
        private System.Windows.Forms.Label lblMedlemsTLF;
        private System.Windows.Forms.TextBox tbMedlemsTLF;
        private System.Windows.Forms.TextBox tbMedlemsNavn;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.TextBox tbPID;
        private System.Windows.Forms.TextBox tbBID;
        private System.Windows.Forms.Panel panelØnskerLejlighed;
        private System.Windows.Forms.Label lblØnskerLejlighed;
        private System.Windows.Forms.Button btnFindMedlemsInfo;
        private System.Windows.Forms.TextBox tbMedlemsEmail;
        private System.Windows.Forms.Label lblMedlemsEmail;
        private System.Windows.Forms.Panel panelPid;
        private System.Windows.Forms.Label lblIndflytÅrstal;
        private System.Windows.Forms.Label lblIndflytMåned;
        private System.Windows.Forms.TextBox tbIndflytÅrstal;
        private System.Windows.Forms.ComboBox combIndflytMåned;
        private System.Windows.Forms.Button btnUdskrivLejekontrakt;
        private System.Windows.Forms.CheckBox ckbJaTilLejlighed;
        private System.Windows.Forms.Panel panelBid;
        private System.Windows.Forms.Panel panelMedlemsinfo;
        private System.Windows.Forms.Panel panelUdskrivLejekontrakt;
    }
}