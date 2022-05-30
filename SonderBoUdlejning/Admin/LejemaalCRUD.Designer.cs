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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateL = new System.Windows.Forms.Button();
            this.btnDeleteL = new System.Windows.Forms.Button();
            this.btnUpdateL = new System.Windows.Forms.Button();
            this.btnReadL = new System.Windows.Forms.Button();
            this.lblLejemaalNr = new System.Windows.Forms.Label();
            this.tbLejemaalNr = new System.Windows.Forms.TextBox();
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
            this.tbLejemaalsTypeID = new System.Windows.Forms.TextBox();
            this.lblLejemaalsTypeID = new System.Windows.Forms.Label();
            this.lblPostNr = new System.Windows.Forms.Label();
            this.comboPostNr = new System.Windows.Forms.ComboBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LejemaalPage = new System.Windows.Forms.TabPage();
            this.LejemaalsInfoPage = new System.Windows.Forms.TabPage();
            this.dgvLejemaalsInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLejemaal)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.dgvLejemaal.Size = new System.Drawing.Size(1004, 348);
            this.dgvLejemaal.TabIndex = 0;
            // 
            // btnVisBCreate
            // 
            this.btnVisBCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisBCreate.Location = new System.Drawing.Point(37, 429);
            this.btnVisBCreate.Name = "btnVisBCreate";
            this.btnVisBCreate.Size = new System.Drawing.Size(155, 65);
            this.btnVisBCreate.TabIndex = 1;
            this.btnVisBCreate.Text = "Opret Lejemål";
            this.btnVisBCreate.UseVisualStyleBackColor = true;
            this.btnVisBCreate.Click += new System.EventHandler(this.btnVisLCreate_Click);
            // 
            // btnVisBRead
            // 
            this.btnVisBRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisBRead.Location = new System.Drawing.Point(265, 429);
            this.btnVisBRead.Name = "btnVisBRead";
            this.btnVisBRead.Size = new System.Drawing.Size(209, 65);
            this.btnVisBRead.TabIndex = 2;
            this.btnVisBRead.Text = "Indlæs Ledige Lejemål";
            this.btnVisBRead.UseVisualStyleBackColor = true;
            this.btnVisBRead.Click += new System.EventHandler(this.btnVisLRead_Click);
            // 
            // btnVisBUpdate
            // 
            this.btnVisBUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisBUpdate.Location = new System.Drawing.Point(613, 429);
            this.btnVisBUpdate.Name = "btnVisBUpdate";
            this.btnVisBUpdate.Size = new System.Drawing.Size(183, 65);
            this.btnVisBUpdate.TabIndex = 3;
            this.btnVisBUpdate.Text = "Opdater Lejemål";
            this.btnVisBUpdate.UseVisualStyleBackColor = true;
            this.btnVisBUpdate.Click += new System.EventHandler(this.btnVisLUpdate_Click);
            // 
            // btnVisBDelete
            // 
            this.btnVisBDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisBDelete.Location = new System.Drawing.Point(881, 429);
            this.btnVisBDelete.Name = "btnVisBDelete";
            this.btnVisBDelete.Size = new System.Drawing.Size(160, 65);
            this.btnVisBDelete.TabIndex = 4;
            this.btnVisBDelete.Text = "Slet Lejemål";
            this.btnVisBDelete.UseVisualStyleBackColor = true;
            this.btnVisBDelete.Click += new System.EventHandler(this.btnVisLDelete_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.lblLejemaalNr);
            this.panelContainer.Controls.Add(this.tbLejemaalNr);
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
            this.panelContainer.Controls.Add(this.tbLejemaalsTypeID);
            this.panelContainer.Controls.Add(this.lblLejemaalsTypeID);
            this.panelContainer.Controls.Add(this.lblPostNr);
            this.panelContainer.Controls.Add(this.comboPostNr);
            this.panelContainer.Controls.Add(this.tbAdresse);
            this.panelContainer.Controls.Add(this.lblAdresse);
            this.panelContainer.Location = new System.Drawing.Point(37, 523);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1004, 168);
            this.panelContainer.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateL);
            this.panel1.Controls.Add(this.btnDeleteL);
            this.panel1.Controls.Add(this.btnUpdateL);
            this.panel1.Controls.Add(this.btnReadL);
            this.panel1.Location = new System.Drawing.Point(845, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 229);
            this.panel1.TabIndex = 24;
            // 
            // btnCreateB
            // 
            this.btnCreateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateL.Location = new System.Drawing.Point(0, 0);
            this.btnCreateL.Name = "btnCreateB";
            this.btnCreateL.Size = new System.Drawing.Size(156, 45);
            this.btnCreateL.TabIndex = 0;
            this.btnCreateL.Text = "Opret";
            this.btnCreateL.UseVisualStyleBackColor = true;
            this.btnCreateL.Click += new System.EventHandler(this.btnCreateB_Click);
            // 
            // btnDeleteB
            // 
            this.btnDeleteL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteL.Location = new System.Drawing.Point(0, 184);
            this.btnDeleteL.Name = "btnDeleteB";
            this.btnDeleteL.Size = new System.Drawing.Size(156, 45);
            this.btnDeleteL.TabIndex = 3;
            this.btnDeleteL.Text = "Slet";
            this.btnDeleteL.UseVisualStyleBackColor = true;
            this.btnDeleteL.Click += new System.EventHandler(this.btnDeleteB_Click);
            // 
            // btnUpdateB
            // 
            this.btnUpdateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateL.Location = new System.Drawing.Point(0, 123);
            this.btnUpdateL.Name = "btnUpdateB";
            this.btnUpdateL.Size = new System.Drawing.Size(156, 45);
            this.btnUpdateL.TabIndex = 2;
            this.btnUpdateL.Text = "Opdater Lejemål";
            this.btnUpdateL.UseVisualStyleBackColor = true;
            this.btnUpdateL.Click += new System.EventHandler(this.btnUpdateB_Click);
            // 
            // btnReadB
            // 
            this.btnReadL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadL.Location = new System.Drawing.Point(0, 62);
            this.btnReadL.Name = "btnReadB";
            this.btnReadL.Size = new System.Drawing.Size(156, 45);
            this.btnReadL.TabIndex = 1;
            this.btnReadL.Text = "Indlæs";
            this.btnReadL.UseVisualStyleBackColor = true;
            this.btnReadL.Click += new System.EventHandler(this.btnReadB_Click);
            // 
            // lblLejemaalNr
            // 
            this.lblLejemaalNr.AutoSize = true;
            this.lblLejemaalNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLejemaalNr.Location = new System.Drawing.Point(18, 15);
            this.lblLejemaalNr.Name = "lblLejemaalNr";
            this.lblLejemaalNr.Size = new System.Drawing.Size(88, 20);
            this.lblLejemaalNr.TabIndex = 23;
            this.lblLejemaalNr.Text = "Lejemål Nr.";
            // 
            // tbLejemaalNr
            // 
            this.tbLejemaalNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLejemaalNr.Location = new System.Drawing.Point(22, 38);
            this.tbLejemaalNr.Name = "tbLejemaalNr";
            this.tbLejemaalNr.Size = new System.Drawing.Size(115, 26);
            this.tbLejemaalNr.TabIndex = 22;
            // 
            // tbMaksPris
            // 
            this.tbMaksPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaksPris.Location = new System.Drawing.Point(574, 119);
            this.tbMaksPris.Name = "tbMaksPris";
            this.tbMaksPris.Size = new System.Drawing.Size(119, 26);
            this.tbMaksPris.TabIndex = 21;
            // 
            // lblMaksPris
            // 
            this.lblMaksPris.AutoSize = true;
            this.lblMaksPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaksPris.Location = new System.Drawing.Point(570, 96);
            this.lblMaksPris.Name = "lblMaksPris";
            this.lblMaksPris.Size = new System.Drawing.Size(115, 20);
            this.lblMaksPris.TabIndex = 20;
            this.lblMaksPris.Text = "Maksimum Pris";
            // 
            // tbMinPris
            // 
            this.tbMinPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinPris.Location = new System.Drawing.Point(444, 119);
            this.tbMinPris.Name = "tbMinPris";
            this.tbMinPris.Size = new System.Drawing.Size(100, 26);
            this.tbMinPris.TabIndex = 19;
            // 
            // lblMinPris
            // 
            this.lblMinPris.AutoSize = true;
            this.lblMinPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPris.Location = new System.Drawing.Point(441, 96);
            this.lblMinPris.Name = "lblMinPris";
            this.lblMinPris.Size = new System.Drawing.Size(102, 20);
            this.lblMinPris.TabIndex = 18;
            this.lblMinPris.Text = "Minimum Pris";
            // 
            // tbMaksKvm
            // 
            this.tbMaksKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaksKvm.Location = new System.Drawing.Point(163, 119);
            this.tbMaksKvm.Name = "tbMaksKvm";
            this.tbMaksKvm.Size = new System.Drawing.Size(115, 26);
            this.tbMaksKvm.TabIndex = 17;
            // 
            // lblMaksKvm
            // 
            this.lblMaksKvm.AutoSize = true;
            this.lblMaksKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaksKvm.Location = new System.Drawing.Point(159, 96);
            this.lblMaksKvm.Name = "lblMaksKvm";
            this.lblMaksKvm.Size = new System.Drawing.Size(119, 20);
            this.lblMaksKvm.TabIndex = 16;
            this.lblMaksKvm.Text = "Maksimum Kvm";
            // 
            // tbLejemaalType
            // 
            this.tbLejemaalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLejemaalType.Location = new System.Drawing.Point(718, 38);
            this.tbLejemaalType.Margin = new System.Windows.Forms.Padding(1);
            this.tbLejemaalType.Name = "tbLejemaalType";
            this.tbLejemaalType.ReadOnly = true;
            this.tbLejemaalType.Size = new System.Drawing.Size(115, 26);
            this.tbLejemaalType.TabIndex = 15;
            // 
            // lblLejemaalType
            // 
            this.lblLejemaalType.AutoSize = true;
            this.lblLejemaalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLejemaalType.Location = new System.Drawing.Point(714, 15);
            this.lblLejemaalType.Name = "lblLejemaalType";
            this.lblLejemaalType.Size = new System.Drawing.Size(102, 20);
            this.lblLejemaalType.TabIndex = 14;
            this.lblLejemaalType.Text = "Lejemål Type";
            // 
            // tbMinKvm
            // 
            this.tbMinKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinKvm.Location = new System.Drawing.Point(22, 119);
            this.tbMinKvm.Name = "tbMinKvm";
            this.tbMinKvm.Size = new System.Drawing.Size(115, 26);
            this.tbMinKvm.TabIndex = 13;
            // 
            // lblMinKvm
            // 
            this.lblMinKvm.AutoSize = true;
            this.lblMinKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinKvm.Location = new System.Drawing.Point(18, 96);
            this.lblMinKvm.Name = "lblMinKvm";
            this.lblMinKvm.Size = new System.Drawing.Size(106, 20);
            this.lblMinKvm.TabIndex = 12;
            this.lblMinKvm.Text = "Minimum Kvm";
            // 
            // tbBy
            // 
            this.tbBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBy.Location = new System.Drawing.Point(444, 38);
            this.tbBy.Name = "tbBy";
            this.tbBy.ReadOnly = true;
            this.tbBy.Size = new System.Drawing.Size(115, 26);
            this.tbBy.TabIndex = 11;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBy.Location = new System.Drawing.Point(441, 15);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(27, 20);
            this.lblBy.TabIndex = 10;
            this.lblBy.Text = "By";
            // 
            // tbLejemaalsTypeID
            // 
            this.tbLejemaalsTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLejemaalsTypeID.Location = new System.Drawing.Point(574, 38);
            this.tbLejemaalsTypeID.Margin = new System.Windows.Forms.Padding(1);
            this.tbLejemaalsTypeID.Name = "tbLejemaalsTypeID";
            this.tbLejemaalsTypeID.Size = new System.Drawing.Size(119, 26);
            this.tbLejemaalsTypeID.TabIndex = 9;
            this.tbLejemaalsTypeID.TextChanged += new System.EventHandler(this.tbLejemaalID_TextChanged);
            // 
            // lblLejemaalsTypeID
            // 
            this.lblLejemaalsTypeID.AutoSize = true;
            this.lblLejemaalsTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLejemaalsTypeID.Location = new System.Drawing.Point(570, 15);
            this.lblLejemaalsTypeID.Name = "lblLejemaalsTypeID";
            this.lblLejemaalsTypeID.Size = new System.Drawing.Size(123, 20);
            this.lblLejemaalsTypeID.TabIndex = 8;
            this.lblLejemaalsTypeID.Text = "Lejemålstype ID";
            // 
            // lblPostNr
            // 
            this.lblPostNr.AutoSize = true;
            this.lblPostNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostNr.Location = new System.Drawing.Point(302, 15);
            this.lblPostNr.Name = "lblPostNr";
            this.lblPostNr.Size = new System.Drawing.Size(65, 20);
            this.lblPostNr.TabIndex = 7;
            this.lblPostNr.Text = "Post Nr.";
            // 
            // comboBoxPostNr
            // 
            this.comboPostNr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPostNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPostNr.FormattingEnabled = true;
            this.comboPostNr.Location = new System.Drawing.Point(306, 38);
            this.comboPostNr.Name = "comboBoxPostNr";
            this.comboPostNr.Size = new System.Drawing.Size(115, 28);
            this.comboPostNr.TabIndex = 6;
            this.comboPostNr.SelectedIndexChanged += new System.EventHandler(this.comboPostNr_SelectedIndexChanged);
            // 
            // tbAdresse
            // 
            this.tbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse.Location = new System.Drawing.Point(163, 38);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(115, 26);
            this.tbAdresse.TabIndex = 5;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(159, 15);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(68, 20);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.LejemaalPage);
            this.tabControl1.Controls.Add(this.LejemaalsInfoPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(30, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 393);
            this.tabControl1.TabIndex = 6;
            // 
            // LejemaalPage
            // 
            this.LejemaalPage.Controls.Add(this.dgvLejemaal);
            this.LejemaalPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LejemaalPage.Location = new System.Drawing.Point(4, 35);
            this.LejemaalPage.Name = "LejemaalPage";
            this.LejemaalPage.Padding = new System.Windows.Forms.Padding(3);
            this.LejemaalPage.Size = new System.Drawing.Size(1010, 354);
            this.LejemaalPage.TabIndex = 0;
            this.LejemaalPage.Text = "Lejemål";
            this.LejemaalPage.UseVisualStyleBackColor = true;
            // 
            // LejemaalsInfoPage
            // 
            this.LejemaalsInfoPage.Controls.Add(this.dgvLejemaalsInfo);
            this.LejemaalsInfoPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LejemaalsInfoPage.Location = new System.Drawing.Point(4, 35);
            this.LejemaalsInfoPage.Name = "LejemaalsInfoPage";
            this.LejemaalsInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.LejemaalsInfoPage.Size = new System.Drawing.Size(1010, 261);
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
            this.dgvLejemaalsInfo.Size = new System.Drawing.Size(1004, 255);
            this.dgvLejemaalsInfo.TabIndex = 0;
            // 
            // LejemaalCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 703);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnVisBDelete);
            this.Controls.Add(this.btnVisBUpdate);
            this.Controls.Add(this.btnVisBRead);
            this.Controls.Add(this.btnVisBCreate);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "LejemaalCRUD";
            this.Text = "LejemaalCRUD";
            this.Load += new System.EventHandler(this.LejemaalCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLejemaal)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnCreateL;
        private System.Windows.Forms.Button btnReadL;
        private System.Windows.Forms.Button btnUpdateL;
        private System.Windows.Forms.Button btnDeleteL;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblPostNr;
        private System.Windows.Forms.ComboBox comboPostNr;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbLejemaalsTypeID;
        private System.Windows.Forms.Label lblLejemaalsTypeID;
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
        private System.Windows.Forms.Label lblLejemaalNr;
        private System.Windows.Forms.TextBox tbLejemaalNr;
        private System.Windows.Forms.Panel panel1;
    }
}