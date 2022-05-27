namespace SonderBoUdlejning.Admin
{
    partial class LejemaalCRUD
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
            this.dgvLejemaal = new System.Windows.Forms.DataGridView();
            this.btnVisBCreate = new System.Windows.Forms.Button();
            this.btnVisBRead = new System.Windows.Forms.Button();
            this.btnVisBUpdate = new System.Windows.Forms.Button();
            this.btnVisBDelete = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblLejemaal = new System.Windows.Forms.Label();
            this.tbLejemaal = new System.Windows.Forms.TextBox();
            this.tbMaksPris = new System.Windows.Forms.TextBox();
            this.lblMaksPris = new System.Windows.Forms.Label();
            this.tbMinPris = new System.Windows.Forms.TextBox();
            this.lblMinPris = new System.Windows.Forms.Label();
            this.tbMaksKvm = new System.Windows.Forms.TextBox();
            this.lblMaksKvm = new System.Windows.Forms.Label();
            this.tbLejemaalType = new System.Windows.Forms.TextBox();
            this.lblLejemaalType = new System.Windows.Forms.Label();
            this.tbMinKvm = new System.Windows.Forms.TextBox();
            this.lblMinKvm = new System.Windows.Forms.Label();
            this.tbBy = new System.Windows.Forms.TextBox();
            this.lblBy = new System.Windows.Forms.Label();
            this.tbLejemaalID = new System.Windows.Forms.TextBox();
            this.lblLejemaalNr = new System.Windows.Forms.Label();
            this.lblPostNr = new System.Windows.Forms.Label();
            this.comboBoxPostNr = new System.Windows.Forms.ComboBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.btnDeleteB = new System.Windows.Forms.Button();
            this.btnUpdateB = new System.Windows.Forms.Button();
            this.btnReadB = new System.Windows.Forms.Button();
            this.btnCreateB = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LejemaalPage = new System.Windows.Forms.TabPage();
            this.LejemaalsInfoPage = new System.Windows.Forms.TabPage();
            this.dgvLejemaalsInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLejemaal)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.LejemaalPage.SuspendLayout();
            this.LejemaalsInfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLejemaalsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLejemaal
            // 
            this.dgvLejemaal.AllowUserToAddRows = false;
            this.dgvLejemaal.AllowUserToDeleteRows = false;
            this.dgvLejemaal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLejemaal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLejemaal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLejemaal.Location = new System.Drawing.Point(3, 3);
            this.dgvLejemaal.Name = "dgvLejemaal";
            this.dgvLejemaal.ReadOnly = true;
            this.dgvLejemaal.RowHeadersWidth = 92;
            this.dgvLejemaal.Size = new System.Drawing.Size(662, 268);
            this.dgvLejemaal.TabIndex = 0;
            // 
            // btnVisBCreate
            // 
            this.btnVisBCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisBCreate.Location = new System.Drawing.Point(30, 334);
            this.btnVisBCreate.Name = "btnVisBCreate";
            this.btnVisBCreate.Size = new System.Drawing.Size(133, 65);
            this.btnVisBCreate.TabIndex = 1;
            this.btnVisBCreate.Text = "Opret Lejemål";
            this.btnVisBCreate.UseVisualStyleBackColor = true;
            this.btnVisBCreate.Click += new System.EventHandler(this.btnVisBCreate_Click);
            // 
            // btnVisBRead
            // 
            this.btnVisBRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisBRead.Location = new System.Drawing.Point(201, 334);
            this.btnVisBRead.Name = "btnVisBRead";
            this.btnVisBRead.Size = new System.Drawing.Size(143, 65);
            this.btnVisBRead.TabIndex = 2;
            this.btnVisBRead.Text = "Indlæs Ledige Lejemål";
            this.btnVisBRead.UseVisualStyleBackColor = true;
            this.btnVisBRead.Click += new System.EventHandler(this.btnVisBRead_Click);
            // 
            // btnVisBUpdate
            // 
            this.btnVisBUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisBUpdate.Location = new System.Drawing.Point(393, 334);
            this.btnVisBUpdate.Name = "btnVisBUpdate";
            this.btnVisBUpdate.Size = new System.Drawing.Size(133, 65);
            this.btnVisBUpdate.TabIndex = 3;
            this.btnVisBUpdate.Text = "Opdater Lejemål";
            this.btnVisBUpdate.UseVisualStyleBackColor = true;
            this.btnVisBUpdate.Click += new System.EventHandler(this.btnVisBUpdate_Click);
            // 
            // btnVisBDelete
            // 
            this.btnVisBDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisBDelete.Location = new System.Drawing.Point(573, 334);
            this.btnVisBDelete.Name = "btnVisBDelete";
            this.btnVisBDelete.Size = new System.Drawing.Size(133, 65);
            this.btnVisBDelete.TabIndex = 4;
            this.btnVisBDelete.Text = "Slet Lejemål";
            this.btnVisBDelete.UseVisualStyleBackColor = true;
            this.btnVisBDelete.Click += new System.EventHandler(this.btnVisDLejemaal_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContainer.Controls.Add(this.lblLejemaal);
            this.panelContainer.Controls.Add(this.tbLejemaal);
            this.panelContainer.Controls.Add(this.tbMaksPris);
            this.panelContainer.Controls.Add(this.lblMaksPris);
            this.panelContainer.Controls.Add(this.tbMinPris);
            this.panelContainer.Controls.Add(this.lblMinPris);
            this.panelContainer.Controls.Add(this.tbMaksKvm);
            this.panelContainer.Controls.Add(this.lblMaksKvm);
            this.panelContainer.Controls.Add(this.tbLejemaalType);
            this.panelContainer.Controls.Add(this.lblLejemaalType);
            this.panelContainer.Controls.Add(this.tbMinKvm);
            this.panelContainer.Controls.Add(this.lblMinKvm);
            this.panelContainer.Controls.Add(this.tbBy);
            this.panelContainer.Controls.Add(this.lblBy);
            this.panelContainer.Controls.Add(this.tbLejemaalID);
            this.panelContainer.Controls.Add(this.lblLejemaalNr);
            this.panelContainer.Controls.Add(this.lblPostNr);
            this.panelContainer.Controls.Add(this.comboBoxPostNr);
            this.panelContainer.Controls.Add(this.tbAdresse);
            this.panelContainer.Controls.Add(this.lblAdresse);
            this.panelContainer.Controls.Add(this.btnDeleteB);
            this.panelContainer.Controls.Add(this.btnUpdateB);
            this.panelContainer.Controls.Add(this.btnReadB);
            this.panelContainer.Controls.Add(this.btnCreateB);
            this.panelContainer.Location = new System.Drawing.Point(30, 423);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(676, 328);
            this.panelContainer.TabIndex = 5;
            // 
            // lblLejemaal
            // 
            this.lblLejemaal.AutoSize = true;
            this.lblLejemaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLejemaal.Location = new System.Drawing.Point(19, 18);
            this.lblLejemaal.Name = "lblLejemaal";
            this.lblLejemaal.Size = new System.Drawing.Size(57, 17);
            this.lblLejemaal.TabIndex = 23;
            this.lblLejemaal.Text = "Lejemål";
            // 
            // tbLejemaal
            // 
            this.tbLejemaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLejemaal.Location = new System.Drawing.Point(22, 38);
            this.tbLejemaal.Name = "tbLejemaal";
            this.tbLejemaal.Size = new System.Drawing.Size(100, 23);
            this.tbLejemaal.TabIndex = 22;
            // 
            // tbMaksPris
            // 
            this.tbMaksPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaksPris.Location = new System.Drawing.Point(145, 268);
            this.tbMaksPris.Name = "tbMaksPris";
            this.tbMaksPris.Size = new System.Drawing.Size(100, 23);
            this.tbMaksPris.TabIndex = 21;
            // 
            // lblMaksPris
            // 
            this.lblMaksPris.AutoSize = true;
            this.lblMaksPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaksPris.Location = new System.Drawing.Point(142, 248);
            this.lblMaksPris.Name = "lblMaksPris";
            this.lblMaksPris.Size = new System.Drawing.Size(102, 17);
            this.lblMaksPris.TabIndex = 20;
            this.lblMaksPris.Text = "Maksimum Pris";
            // 
            // tbMinPris
            // 
            this.tbMinPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinPris.Location = new System.Drawing.Point(22, 268);
            this.tbMinPris.Name = "tbMinPris";
            this.tbMinPris.Size = new System.Drawing.Size(100, 23);
            this.tbMinPris.TabIndex = 19;
            // 
            // lblMinPris
            // 
            this.lblMinPris.AutoSize = true;
            this.lblMinPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPris.Location = new System.Drawing.Point(19, 248);
            this.lblMinPris.Name = "lblMinPris";
            this.lblMinPris.Size = new System.Drawing.Size(91, 17);
            this.lblMinPris.TabIndex = 18;
            this.lblMinPris.Text = "Minimum Pris";
            // 
            // tbMaksKvm
            // 
            this.tbMaksKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaksKvm.Location = new System.Drawing.Point(145, 192);
            this.tbMaksKvm.Name = "tbMaksKvm";
            this.tbMaksKvm.Size = new System.Drawing.Size(100, 23);
            this.tbMaksKvm.TabIndex = 17;
            // 
            // lblMaksKvm
            // 
            this.lblMaksKvm.AutoSize = true;
            this.lblMaksKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaksKvm.Location = new System.Drawing.Point(142, 172);
            this.lblMaksKvm.Name = "lblMaksKvm";
            this.lblMaksKvm.Size = new System.Drawing.Size(105, 17);
            this.lblMaksKvm.TabIndex = 16;
            this.lblMaksKvm.Text = "Maksimum Kvm";
            // 
            // tbLejemaalType
            // 
            this.tbLejemaalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLejemaalType.Location = new System.Drawing.Point(145, 116);
            this.tbLejemaalType.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbLejemaalType.Name = "tbLejemaalType";
            this.tbLejemaalType.ReadOnly = true;
            this.tbLejemaalType.Size = new System.Drawing.Size(100, 23);
            this.tbLejemaalType.TabIndex = 15;
            // 
            // lblLejemaalType
            // 
            this.lblLejemaalType.AutoSize = true;
            this.lblLejemaalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLejemaalType.Location = new System.Drawing.Point(142, 96);
            this.lblLejemaalType.Name = "lblLejemaalType";
            this.lblLejemaalType.Size = new System.Drawing.Size(93, 17);
            this.lblLejemaalType.TabIndex = 14;
            this.lblLejemaalType.Text = "Lejemål Type";
            // 
            // tbMinKvm
            // 
            this.tbMinKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinKvm.Location = new System.Drawing.Point(22, 192);
            this.tbMinKvm.Name = "tbMinKvm";
            this.tbMinKvm.Size = new System.Drawing.Size(100, 23);
            this.tbMinKvm.TabIndex = 13;
            // 
            // lblMinKvm
            // 
            this.lblMinKvm.AutoSize = true;
            this.lblMinKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinKvm.Location = new System.Drawing.Point(19, 172);
            this.lblMinKvm.Name = "lblMinKvm";
            this.lblMinKvm.Size = new System.Drawing.Size(94, 17);
            this.lblMinKvm.TabIndex = 12;
            this.lblMinKvm.Text = "Minimum Kvm";
            // 
            // tbBy
            // 
            this.tbBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBy.Location = new System.Drawing.Point(413, 38);
            this.tbBy.Name = "tbBy";
            this.tbBy.ReadOnly = true;
            this.tbBy.Size = new System.Drawing.Size(100, 23);
            this.tbBy.TabIndex = 11;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBy.Location = new System.Drawing.Point(410, 18);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(24, 17);
            this.lblBy.TabIndex = 10;
            this.lblBy.Text = "By";
            // 
            // tbLejemaalID
            // 
            this.tbLejemaalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLejemaalID.Location = new System.Drawing.Point(22, 114);
            this.tbLejemaalID.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbLejemaalID.Name = "tbLejemaalID";
            this.tbLejemaalID.Size = new System.Drawing.Size(100, 23);
            this.tbLejemaalID.TabIndex = 9;
            this.tbLejemaalID.TextChanged += new System.EventHandler(this.tbLejemaalID_TextChanged);
            // 
            // lblLejemaalNr
            // 
            this.lblLejemaalNr.AutoSize = true;
            this.lblLejemaalNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLejemaalNr.Location = new System.Drawing.Point(19, 96);
            this.lblLejemaalNr.Name = "lblLejemaalNr";
            this.lblLejemaalNr.Size = new System.Drawing.Size(76, 17);
            this.lblLejemaalNr.TabIndex = 8;
            this.lblLejemaalNr.Text = "Lejemål Nr";
            // 
            // lblPostNr
            // 
            this.lblPostNr.AutoSize = true;
            this.lblPostNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostNr.Location = new System.Drawing.Point(265, 18);
            this.lblPostNr.Name = "lblPostNr";
            this.lblPostNr.Size = new System.Drawing.Size(59, 17);
            this.lblPostNr.TabIndex = 7;
            this.lblPostNr.Text = "Post Nr.";
            // 
            // comboBoxPostNr
            // 
            this.comboBoxPostNr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPostNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPostNr.FormattingEnabled = true;
            this.comboBoxPostNr.Location = new System.Drawing.Point(268, 37);
            this.comboBoxPostNr.Name = "comboBoxPostNr";
            this.comboBoxPostNr.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPostNr.TabIndex = 6;
            this.comboBoxPostNr.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostNr_SelectedIndexChanged);
            // 
            // tbAdresse
            // 
            this.tbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse.Location = new System.Drawing.Point(145, 38);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(100, 23);
            this.tbAdresse.TabIndex = 5;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(142, 18);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(60, 17);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse";
            // 
            // btnDeleteB
            // 
            this.btnDeleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteB.Location = new System.Drawing.Point(534, 251);
            this.btnDeleteB.Name = "btnDeleteB";
            this.btnDeleteB.Size = new System.Drawing.Size(124, 61);
            this.btnDeleteB.TabIndex = 3;
            this.btnDeleteB.Text = "Slet";
            this.btnDeleteB.UseVisualStyleBackColor = true;
            this.btnDeleteB.Click += new System.EventHandler(this.btnDeleteB_Click);
            // 
            // btnUpdateB
            // 
            this.btnUpdateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateB.Location = new System.Drawing.Point(534, 172);
            this.btnUpdateB.Name = "btnUpdateB";
            this.btnUpdateB.Size = new System.Drawing.Size(124, 61);
            this.btnUpdateB.TabIndex = 2;
            this.btnUpdateB.Text = "Opdater Lejemål";
            this.btnUpdateB.UseVisualStyleBackColor = true;
            this.btnUpdateB.Click += new System.EventHandler(this.btnUpdateB_Click);
            // 
            // btnReadB
            // 
            this.btnReadB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadB.Location = new System.Drawing.Point(534, 96);
            this.btnReadB.Name = "btnReadB";
            this.btnReadB.Size = new System.Drawing.Size(124, 61);
            this.btnReadB.TabIndex = 1;
            this.btnReadB.Text = "Indlæs";
            this.btnReadB.UseVisualStyleBackColor = true;
            this.btnReadB.Click += new System.EventHandler(this.btnReadB_Click);
            // 
            // btnCreateB
            // 
            this.btnCreateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateB.Location = new System.Drawing.Point(534, 18);
            this.btnCreateB.Name = "btnCreateB";
            this.btnCreateB.Size = new System.Drawing.Size(124, 61);
            this.btnCreateB.TabIndex = 0;
            this.btnCreateB.Text = "Opret";
            this.btnCreateB.UseVisualStyleBackColor = true;
            this.btnCreateB.Click += new System.EventHandler(this.btnCreateB_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.LejemaalPage);
            this.tabControl1.Controls.Add(this.LejemaalsInfoPage);
            this.tabControl1.Location = new System.Drawing.Point(30, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 300);
            this.tabControl1.TabIndex = 6;
            // 
            // LejemaalPage
            // 
            this.LejemaalPage.Controls.Add(this.dgvLejemaal);
            this.LejemaalPage.Location = new System.Drawing.Point(4, 22);
            this.LejemaalPage.Name = "LejemaalPage";
            this.LejemaalPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.LejemaalPage.Size = new System.Drawing.Size(668, 274);
            this.LejemaalPage.TabIndex = 0;
            this.LejemaalPage.Text = "Lejemål";
            this.LejemaalPage.UseVisualStyleBackColor = true;
            // 
            // LejemaalsInfoPage
            // 
            this.LejemaalsInfoPage.Controls.Add(this.dgvLejemaalsInfo);
            this.LejemaalsInfoPage.Location = new System.Drawing.Point(4, 22);
            this.LejemaalsInfoPage.Name = "LejemaalsInfoPage";
            this.LejemaalsInfoPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.LejemaalsInfoPage.Size = new System.Drawing.Size(668, 274);
            this.LejemaalsInfoPage.TabIndex = 1;
            this.LejemaalsInfoPage.Text = "LejemålsInfo";
            this.LejemaalsInfoPage.UseVisualStyleBackColor = true;
            // 
            // dgvLejemaalsInfo
            // 
            this.dgvLejemaalsInfo.AllowUserToAddRows = false;
            this.dgvLejemaalsInfo.AllowUserToDeleteRows = false;
            this.dgvLejemaalsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLejemaalsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLejemaalsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLejemaalsInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvLejemaalsInfo.Name = "dgvLejemaalsInfo";
            this.dgvLejemaalsInfo.ReadOnly = true;
            this.dgvLejemaalsInfo.RowHeadersWidth = 92;
            this.dgvLejemaalsInfo.Size = new System.Drawing.Size(662, 268);
            this.dgvLejemaalsInfo.TabIndex = 0;
            // 
            // LejemaalCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 780);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnVisBDelete);
            this.Controls.Add(this.btnVisBUpdate);
            this.Controls.Add(this.btnVisBRead);
            this.Controls.Add(this.btnVisBCreate);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "LejemaalCRUD";
            this.Text = "LejemaalCRUD";
            this.Load += new System.EventHandler(this.LejemaalCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLejemaal)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.LejemaalPage.ResumeLayout(false);
            this.LejemaalsInfoPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLejemaalsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLejemaal;
        private System.Windows.Forms.Button btnVisBCreate;
        private System.Windows.Forms.Button btnVisBRead;
        private System.Windows.Forms.Button btnVisBUpdate;
        private System.Windows.Forms.Button btnVisBDelete;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnCreateB;
        private System.Windows.Forms.Button btnReadB;
        private System.Windows.Forms.Button btnUpdateB;
        private System.Windows.Forms.Button btnDeleteB;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblPostNr;
        private System.Windows.Forms.ComboBox comboBoxPostNr;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbLejemaalID;
        private System.Windows.Forms.Label lblLejemaalNr;
        private System.Windows.Forms.TextBox tbBy;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LejemaalPage;
        private System.Windows.Forms.TabPage LejemaalsInfoPage;
        private System.Windows.Forms.DataGridView dgvLejemaalsInfo;
        private System.Windows.Forms.TextBox tbLejemaalType;
        private System.Windows.Forms.Label lblLejemaalType;
        private System.Windows.Forms.TextBox tbMinKvm;
        private System.Windows.Forms.Label lblMinKvm;
        private System.Windows.Forms.TextBox tbMaksKvm;
        private System.Windows.Forms.Label lblMaksKvm;
        private System.Windows.Forms.TextBox tbMaksPris;
        private System.Windows.Forms.Label lblMaksPris;
        private System.Windows.Forms.TextBox tbMinPris;
        private System.Windows.Forms.Label lblMinPris;
        private System.Windows.Forms.Label lblLejemaal;
        private System.Windows.Forms.TextBox tbLejemaal;
    }
}