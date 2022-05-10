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
            this.combAdresser = new System.Windows.Forms.ComboBox();
            this.panelUdskrivLejekontrakt = new System.Windows.Forms.Panel();
            this.combIndflytÅr = new System.Windows.Forms.ComboBox();
            this.lblIndflytÅrstal = new System.Windows.Forms.Label();
            this.lblIndflytMåned = new System.Windows.Forms.Label();
            this.combIndflytMåned = new System.Windows.Forms.ComboBox();
            this.btnUdskrivLejekontrakt = new System.Windows.Forms.Button();
            this.ckbJaTilLejlighed = new System.Windows.Forms.CheckBox();
            this.lblØnskerLejlighed = new System.Windows.Forms.Label();
            this.tbBID = new System.Windows.Forms.TextBox();
            this.panelPid = new System.Windows.Forms.Panel();
            this.panelMedlemsinfo = new System.Windows.Forms.Panel();
            this.lblMedlemsNavn = new System.Windows.Forms.Label();
            this.tbMedlemsNavn = new System.Windows.Forms.TextBox();
            this.tbMedlemsTLF = new System.Windows.Forms.TextBox();
            this.tbMedlemsEmail = new System.Windows.Forms.TextBox();
            this.lblMedlemsTLF = new System.Windows.Forms.Label();
            this.lblMedlemsEmail = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.tbPID = new System.Windows.Forms.TextBox();
            this.btnFindMedlemsInfo = new System.Windows.Forms.Button();
            this.panelBid = new System.Windows.Forms.Panel();
            this.lblBID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenteliste)).BeginInit();
            this.panelBaggrund.SuspendLayout();
            this.panelØnskerLejlighed.SuspendLayout();
            this.panelUdskrivLejekontrakt.SuspendLayout();
            this.panelPid.SuspendLayout();
            this.panelMedlemsinfo.SuspendLayout();
            this.panelBid.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBolig
            // 
            this.dgvBolig.AllowUserToAddRows = false;
            this.dgvBolig.AllowUserToDeleteRows = false;
            this.dgvBolig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBolig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBolig.Location = new System.Drawing.Point(44, 54);
            this.dgvBolig.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBolig.Name = "dgvBolig";
            this.dgvBolig.ReadOnly = true;
            this.dgvBolig.RowHeadersWidth = 51;
            this.dgvBolig.RowTemplate.Height = 24;
            this.dgvBolig.Size = new System.Drawing.Size(387, 165);
            this.dgvBolig.TabIndex = 0;
            // 
            // dgvVenteliste
            // 
            this.dgvVenteliste.AllowUserToAddRows = false;
            this.dgvVenteliste.AllowUserToDeleteRows = false;
            this.dgvVenteliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenteliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenteliste.Location = new System.Drawing.Point(476, 54);
            this.dgvVenteliste.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVenteliste.Name = "dgvVenteliste";
            this.dgvVenteliste.ReadOnly = true;
            this.dgvVenteliste.RowHeadersWidth = 51;
            this.dgvVenteliste.RowTemplate.Height = 24;
            this.dgvVenteliste.Size = new System.Drawing.Size(329, 165);
            this.dgvVenteliste.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bolig tabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
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
            this.panelBaggrund.Location = new System.Drawing.Point(44, 246);
            this.panelBaggrund.Margin = new System.Windows.Forms.Padding(2);
            this.panelBaggrund.Name = "panelBaggrund";
            this.panelBaggrund.Size = new System.Drawing.Size(761, 323);
            this.panelBaggrund.TabIndex = 4;
            // 
            // panelØnskerLejlighed
            // 
            this.panelØnskerLejlighed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelØnskerLejlighed.Controls.Add(this.combAdresser);
            this.panelØnskerLejlighed.Controls.Add(this.panelUdskrivLejekontrakt);
            this.panelØnskerLejlighed.Controls.Add(this.ckbJaTilLejlighed);
            this.panelØnskerLejlighed.Controls.Add(this.lblØnskerLejlighed);
            this.panelØnskerLejlighed.Location = new System.Drawing.Point(20, 162);
            this.panelØnskerLejlighed.Margin = new System.Windows.Forms.Padding(2);
            this.panelØnskerLejlighed.Name = "panelØnskerLejlighed";
            this.panelØnskerLejlighed.Size = new System.Drawing.Size(726, 127);
            this.panelØnskerLejlighed.TabIndex = 15;
            this.panelØnskerLejlighed.Visible = false;
            // 
            // combAdresser
            // 
            this.combAdresser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combAdresser.FormattingEnabled = true;
            this.combAdresser.Location = new System.Drawing.Point(42, 86);
            this.combAdresser.Name = "combAdresser";
            this.combAdresser.Size = new System.Drawing.Size(185, 21);
            this.combAdresser.TabIndex = 23;
            // 
            // panelUdskrivLejekontrakt
            // 
            this.panelUdskrivLejekontrakt.Controls.Add(this.combIndflytÅr);
            this.panelUdskrivLejekontrakt.Controls.Add(this.lblIndflytÅrstal);
            this.panelUdskrivLejekontrakt.Controls.Add(this.lblIndflytMåned);
            this.panelUdskrivLejekontrakt.Controls.Add(this.combIndflytMåned);
            this.panelUdskrivLejekontrakt.Controls.Add(this.btnUdskrivLejekontrakt);
            this.panelUdskrivLejekontrakt.Location = new System.Drawing.Point(242, 25);
            this.panelUdskrivLejekontrakt.Margin = new System.Windows.Forms.Padding(2);
            this.panelUdskrivLejekontrakt.Name = "panelUdskrivLejekontrakt";
            this.panelUdskrivLejekontrakt.Size = new System.Drawing.Size(475, 82);
            this.panelUdskrivLejekontrakt.TabIndex = 22;
            this.panelUdskrivLejekontrakt.Visible = false;
            // 
            // combIndflytÅr
            // 
            this.combIndflytÅr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combIndflytÅr.FormattingEnabled = true;
            this.combIndflytÅr.Location = new System.Drawing.Point(107, 41);
            this.combIndflytÅr.Name = "combIndflytÅr";
            this.combIndflytÅr.Size = new System.Drawing.Size(91, 21);
            this.combIndflytÅr.TabIndex = 22;
            // 
            // lblIndflytÅrstal
            // 
            this.lblIndflytÅrstal.AutoSize = true;
            this.lblIndflytÅrstal.Location = new System.Drawing.Point(104, 25);
            this.lblIndflytÅrstal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndflytÅrstal.Name = "lblIndflytÅrstal";
            this.lblIndflytÅrstal.Size = new System.Drawing.Size(33, 13);
            this.lblIndflytÅrstal.TabIndex = 21;
            this.lblIndflytÅrstal.Text = "Årstal";
            // 
            // lblIndflytMåned
            // 
            this.lblIndflytMåned.AutoSize = true;
            this.lblIndflytMåned.Location = new System.Drawing.Point(8, 26);
            this.lblIndflytMåned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndflytMåned.Name = "lblIndflytMåned";
            this.lblIndflytMåned.Size = new System.Drawing.Size(40, 13);
            this.lblIndflytMåned.TabIndex = 16;
            this.lblIndflytMåned.Text = "Måned";
            // 
            // combIndflytMåned
            // 
            this.combIndflytMåned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combIndflytMåned.FormattingEnabled = true;
            this.combIndflytMåned.Location = new System.Drawing.Point(10, 41);
            this.combIndflytMåned.Margin = new System.Windows.Forms.Padding(2);
            this.combIndflytMåned.Name = "combIndflytMåned";
            this.combIndflytMåned.Size = new System.Drawing.Size(92, 21);
            this.combIndflytMåned.TabIndex = 19;
            // 
            // btnUdskrivLejekontrakt
            // 
            this.btnUdskrivLejekontrakt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUdskrivLejekontrakt.Location = new System.Drawing.Point(224, 16);
            this.btnUdskrivLejekontrakt.Margin = new System.Windows.Forms.Padding(2);
            this.btnUdskrivLejekontrakt.Name = "btnUdskrivLejekontrakt";
            this.btnUdskrivLejekontrakt.Size = new System.Drawing.Size(244, 43);
            this.btnUdskrivLejekontrakt.TabIndex = 18;
            this.btnUdskrivLejekontrakt.Text = "Udskriv Lejekontrakt";
            this.btnUdskrivLejekontrakt.UseVisualStyleBackColor = false;
            this.btnUdskrivLejekontrakt.Click += new System.EventHandler(this.btnUdskrivLejekontrakt_Click);
            // 
            // ckbJaTilLejlighed
            // 
            this.ckbJaTilLejlighed.AutoSize = true;
            this.ckbJaTilLejlighed.Location = new System.Drawing.Point(42, 58);
            this.ckbJaTilLejlighed.Margin = new System.Windows.Forms.Padding(2);
            this.ckbJaTilLejlighed.Name = "ckbJaTilLejlighed";
            this.ckbJaTilLejlighed.Size = new System.Drawing.Size(185, 17);
            this.ckbJaTilLejlighed.TabIndex = 17;
            this.ckbJaTilLejlighed.Text = "Ja Medlemmet ønsker lejligheden.";
            this.ckbJaTilLejlighed.UseVisualStyleBackColor = true;
            this.ckbJaTilLejlighed.CheckedChanged += new System.EventHandler(this.ckbJaTilLejlighed_CheckedChanged);
            // 
            // lblØnskerLejlighed
            // 
            this.lblØnskerLejlighed.AutoSize = true;
            this.lblØnskerLejlighed.Location = new System.Drawing.Point(40, 13);
            this.lblØnskerLejlighed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblØnskerLejlighed.Name = "lblØnskerLejlighed";
            this.lblØnskerLejlighed.Size = new System.Drawing.Size(161, 13);
            this.lblØnskerLejlighed.TabIndex = 16;
            this.lblØnskerLejlighed.Text = "Ønsker Medlemmet Lejligheden?";
            // 
            // tbBID
            // 
            this.tbBID.Location = new System.Drawing.Point(43, 77);
            this.tbBID.Margin = new System.Windows.Forms.Padding(2);
            this.tbBID.Name = "tbBID";
            this.tbBID.Size = new System.Drawing.Size(76, 20);
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
            this.panelPid.Location = new System.Drawing.Point(198, 13);
            this.panelPid.Margin = new System.Windows.Forms.Padding(2);
            this.panelPid.Name = "panelPid";
            this.panelPid.Size = new System.Drawing.Size(548, 128);
            this.panelPid.TabIndex = 14;
            this.panelPid.Visible = false;
            // 
            // panelMedlemsinfo
            // 
            this.panelMedlemsinfo.Controls.Add(this.lblMedlemsNavn);
            this.panelMedlemsinfo.Controls.Add(this.tbMedlemsNavn);
            this.panelMedlemsinfo.Controls.Add(this.tbMedlemsTLF);
            this.panelMedlemsinfo.Controls.Add(this.tbMedlemsEmail);
            this.panelMedlemsinfo.Controls.Add(this.lblMedlemsTLF);
            this.panelMedlemsinfo.Controls.Add(this.lblMedlemsEmail);
            this.panelMedlemsinfo.Location = new System.Drawing.Point(253, 18);
            this.panelMedlemsinfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelMedlemsinfo.Name = "panelMedlemsinfo";
            this.panelMedlemsinfo.Size = new System.Drawing.Size(286, 95);
            this.panelMedlemsinfo.TabIndex = 14;
            this.panelMedlemsinfo.Visible = false;
            // 
            // lblMedlemsNavn
            // 
            this.lblMedlemsNavn.AutoSize = true;
            this.lblMedlemsNavn.Location = new System.Drawing.Point(5, 22);
            this.lblMedlemsNavn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedlemsNavn.Name = "lblMedlemsNavn";
            this.lblMedlemsNavn.Size = new System.Drawing.Size(76, 13);
            this.lblMedlemsNavn.TabIndex = 10;
            this.lblMedlemsNavn.Text = "Medlems navn";
            // 
            // tbMedlemsNavn
            // 
            this.tbMedlemsNavn.Location = new System.Drawing.Point(8, 46);
            this.tbMedlemsNavn.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedlemsNavn.Name = "tbMedlemsNavn";
            this.tbMedlemsNavn.ReadOnly = true;
            this.tbMedlemsNavn.Size = new System.Drawing.Size(76, 20);
            this.tbMedlemsNavn.TabIndex = 7;
            // 
            // tbMedlemsTLF
            // 
            this.tbMedlemsTLF.Location = new System.Drawing.Point(110, 46);
            this.tbMedlemsTLF.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedlemsTLF.Name = "tbMedlemsTLF";
            this.tbMedlemsTLF.ReadOnly = true;
            this.tbMedlemsTLF.Size = new System.Drawing.Size(76, 20);
            this.tbMedlemsTLF.TabIndex = 8;
            // 
            // tbMedlemsEmail
            // 
            this.tbMedlemsEmail.Location = new System.Drawing.Point(203, 46);
            this.tbMedlemsEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedlemsEmail.Name = "tbMedlemsEmail";
            this.tbMedlemsEmail.ReadOnly = true;
            this.tbMedlemsEmail.Size = new System.Drawing.Size(76, 20);
            this.tbMedlemsEmail.TabIndex = 12;
            // 
            // lblMedlemsTLF
            // 
            this.lblMedlemsTLF.AutoSize = true;
            this.lblMedlemsTLF.Location = new System.Drawing.Point(107, 22);
            this.lblMedlemsTLF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedlemsTLF.Name = "lblMedlemsTLF";
            this.lblMedlemsTLF.Size = new System.Drawing.Size(71, 13);
            this.lblMedlemsTLF.TabIndex = 9;
            this.lblMedlemsTLF.Text = "Medlems TLF";
            // 
            // lblMedlemsEmail
            // 
            this.lblMedlemsEmail.AutoSize = true;
            this.lblMedlemsEmail.Location = new System.Drawing.Point(201, 22);
            this.lblMedlemsEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedlemsEmail.Name = "lblMedlemsEmail";
            this.lblMedlemsEmail.Size = new System.Drawing.Size(77, 13);
            this.lblMedlemsEmail.TabIndex = 11;
            this.lblMedlemsEmail.Text = "Medlems Email";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPID.Location = new System.Drawing.Point(40, 41);
            this.lblPID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(57, 13);
            this.lblPID.TabIndex = 6;
            this.lblPID.Text = "Indtast pId";
            // 
            // tbPID
            // 
            this.tbPID.Location = new System.Drawing.Point(43, 64);
            this.tbPID.Margin = new System.Windows.Forms.Padding(2);
            this.tbPID.Name = "tbPID";
            this.tbPID.Size = new System.Drawing.Size(76, 20);
            this.tbPID.TabIndex = 1;
            // 
            // btnFindMedlemsInfo
            // 
            this.btnFindMedlemsInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFindMedlemsInfo.Location = new System.Drawing.Point(144, 40);
            this.btnFindMedlemsInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindMedlemsInfo.Name = "btnFindMedlemsInfo";
            this.btnFindMedlemsInfo.Size = new System.Drawing.Size(95, 45);
            this.btnFindMedlemsInfo.TabIndex = 13;
            this.btnFindMedlemsInfo.Text = "FIND INFO";
            this.btnFindMedlemsInfo.UseVisualStyleBackColor = false;
            this.btnFindMedlemsInfo.Click += new System.EventHandler(this.btnFindMedlemsInfo_Click);
            // 
            // panelBid
            // 
            this.panelBid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBid.Controls.Add(this.lblBID);
            this.panelBid.Location = new System.Drawing.Point(20, 16);
            this.panelBid.Margin = new System.Windows.Forms.Padding(2);
            this.panelBid.Name = "panelBid";
            this.panelBid.Size = new System.Drawing.Size(153, 125);
            this.panelBid.TabIndex = 16;
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Location = new System.Drawing.Point(21, 37);
            this.lblBID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(57, 13);
            this.lblBID.TabIndex = 5;
            this.lblBID.Text = "Indtast bId";
            // 
            // TildelBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVenteliste);
            this.Controls.Add(this.dgvBolig);
            this.Controls.Add(this.panelBaggrund);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TildelBolig";
            this.Text = "TildelBolig";
            this.Load += new System.EventHandler(this.TildelBolig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenteliste)).EndInit();
            this.panelBaggrund.ResumeLayout(false);
            this.panelBaggrund.PerformLayout();
            this.panelØnskerLejlighed.ResumeLayout(false);
            this.panelØnskerLejlighed.PerformLayout();
            this.panelUdskrivLejekontrakt.ResumeLayout(false);
            this.panelUdskrivLejekontrakt.PerformLayout();
            this.panelPid.ResumeLayout(false);
            this.panelPid.PerformLayout();
            this.panelMedlemsinfo.ResumeLayout(false);
            this.panelMedlemsinfo.PerformLayout();
            this.panelBid.ResumeLayout(false);
            this.panelBid.PerformLayout();
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
        private System.Windows.Forms.ComboBox combIndflytMåned;
        private System.Windows.Forms.Button btnUdskrivLejekontrakt;
        private System.Windows.Forms.CheckBox ckbJaTilLejlighed;
        private System.Windows.Forms.Panel panelBid;
        private System.Windows.Forms.Panel panelMedlemsinfo;
        private System.Windows.Forms.Panel panelUdskrivLejekontrakt;
        private System.Windows.Forms.ComboBox combIndflytÅr;
        private System.Windows.Forms.ComboBox combAdresser;
    }
}