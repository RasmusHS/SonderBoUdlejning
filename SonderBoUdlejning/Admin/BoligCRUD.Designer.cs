namespace SonderBoUdlejning.Admin
{
    partial class BoligCRUD
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
            this.btnVisBCreate = new System.Windows.Forms.Button();
            this.btnVisBRead = new System.Windows.Forms.Button();
            this.btnVisBUpdate = new System.Windows.Forms.Button();
            this.btnVisBDelete = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tbBoligID = new System.Windows.Forms.TextBox();
            this.lblBoligID = new System.Windows.Forms.Label();
            this.lblPostNr = new System.Windows.Forms.Label();
            this.comboBoxPostNr = new System.Windows.Forms.ComboBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.btnDeleteB = new System.Windows.Forms.Button();
            this.btnUpdateB = new System.Windows.Forms.Button();
            this.btnReadB = new System.Windows.Forms.Button();
            this.btnCreateB = new System.Windows.Forms.Button();
            this.tbBy = new System.Windows.Forms.TextBox();
            this.lblBy = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BoligPage = new System.Windows.Forms.TabPage();
            this.BoligInfoPage = new System.Windows.Forms.TabPage();
            this.dgvBoligInfo = new System.Windows.Forms.DataGridView();
            this.tbMinKvm = new System.Windows.Forms.TextBox();
            this.lblMinKvm = new System.Windows.Forms.Label();
            this.tbBoligType = new System.Windows.Forms.TextBox();
            this.lblBoligType = new System.Windows.Forms.Label();
            this.tbMaksKvm = new System.Windows.Forms.TextBox();
            this.lblMaksKvm = new System.Windows.Forms.Label();
            this.tbMaksPris = new System.Windows.Forms.TextBox();
            this.lblMaksPris = new System.Windows.Forms.Label();
            this.tbMinPris = new System.Windows.Forms.TextBox();
            this.lblMinPris = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolig)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.BoligPage.SuspendLayout();
            this.BoligInfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoligInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBolig
            // 
            this.dgvBolig.AllowUserToAddRows = false;
            this.dgvBolig.AllowUserToDeleteRows = false;
            this.dgvBolig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBolig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBolig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBolig.Location = new System.Drawing.Point(3, 3);
            this.dgvBolig.Name = "dgvBolig";
            this.dgvBolig.ReadOnly = true;
            this.dgvBolig.Size = new System.Drawing.Size(662, 268);
            this.dgvBolig.TabIndex = 0;
            // 
            // btnVisBCreate
            // 
            this.btnVisBCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisBCreate.Location = new System.Drawing.Point(30, 334);
            this.btnVisBCreate.Name = "btnVisBCreate";
            this.btnVisBCreate.Size = new System.Drawing.Size(133, 65);
            this.btnVisBCreate.TabIndex = 1;
            this.btnVisBCreate.Text = "Opret Bolig";
            this.btnVisBCreate.UseVisualStyleBackColor = true;
            this.btnVisBCreate.Click += new System.EventHandler(this.btnVisBCreate_Click);
            // 
            // btnVisBRead
            // 
            this.btnVisBRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisBRead.Location = new System.Drawing.Point(206, 334);
            this.btnVisBRead.Name = "btnVisBRead";
            this.btnVisBRead.Size = new System.Drawing.Size(133, 65);
            this.btnVisBRead.TabIndex = 2;
            this.btnVisBRead.Text = "Indlæs Boliger";
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
            this.btnVisBUpdate.Text = "Opdater Bolig";
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
            this.btnVisBDelete.Text = "Slet Bolig";
            this.btnVisBDelete.UseVisualStyleBackColor = true;
            this.btnVisBDelete.Click += new System.EventHandler(this.btnVisDBolig_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContainer.Controls.Add(this.tbMaksPris);
            this.panelContainer.Controls.Add(this.lblMaksPris);
            this.panelContainer.Controls.Add(this.tbMinPris);
            this.panelContainer.Controls.Add(this.lblMinPris);
            this.panelContainer.Controls.Add(this.tbMaksKvm);
            this.panelContainer.Controls.Add(this.lblMaksKvm);
            this.panelContainer.Controls.Add(this.tbBoligType);
            this.panelContainer.Controls.Add(this.lblBoligType);
            this.panelContainer.Controls.Add(this.tbMinKvm);
            this.panelContainer.Controls.Add(this.lblMinKvm);
            this.panelContainer.Controls.Add(this.tbBy);
            this.panelContainer.Controls.Add(this.lblBy);
            this.panelContainer.Controls.Add(this.tbBoligID);
            this.panelContainer.Controls.Add(this.lblBoligID);
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
            // tbBoligID
            // 
            this.tbBoligID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoligID.Location = new System.Drawing.Point(412, 38);
            this.tbBoligID.Name = "tbBoligID";
            this.tbBoligID.Size = new System.Drawing.Size(100, 23);
            this.tbBoligID.TabIndex = 9;
            this.tbBoligID.TextChanged += new System.EventHandler(this.tbBoligID_TextChanged);
            // 
            // lblBoligID
            // 
            this.lblBoligID.AutoSize = true;
            this.lblBoligID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoligID.Location = new System.Drawing.Point(409, 18);
            this.lblBoligID.Name = "lblBoligID";
            this.lblBoligID.Size = new System.Drawing.Size(56, 17);
            this.lblBoligID.TabIndex = 8;
            this.lblBoligID.Text = "Bolig ID";
            // 
            // lblPostNr
            // 
            this.lblPostNr.AutoSize = true;
            this.lblPostNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostNr.Location = new System.Drawing.Point(142, 18);
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
            this.comboBoxPostNr.Location = new System.Drawing.Point(145, 37);
            this.comboBoxPostNr.Name = "comboBoxPostNr";
            this.comboBoxPostNr.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPostNr.TabIndex = 6;
            this.comboBoxPostNr.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostNr_SelectedIndexChanged);
            // 
            // tbAdresse
            // 
            this.tbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse.Location = new System.Drawing.Point(22, 38);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(100, 23);
            this.tbAdresse.TabIndex = 5;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(19, 18);
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
            this.btnUpdateB.Text = "Opdater bId";
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
            // tbBy
            // 
            this.tbBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBy.Location = new System.Drawing.Point(290, 38);
            this.tbBy.Name = "tbBy";
            this.tbBy.ReadOnly = true;
            this.tbBy.Size = new System.Drawing.Size(100, 23);
            this.tbBy.TabIndex = 11;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBy.Location = new System.Drawing.Point(287, 18);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(24, 17);
            this.lblBy.TabIndex = 10;
            this.lblBy.Text = "By";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BoligPage);
            this.tabControl1.Controls.Add(this.BoligInfoPage);
            this.tabControl1.Location = new System.Drawing.Point(30, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 300);
            this.tabControl1.TabIndex = 6;
            // 
            // BoligPage
            // 
            this.BoligPage.Controls.Add(this.dgvBolig);
            this.BoligPage.Location = new System.Drawing.Point(4, 22);
            this.BoligPage.Name = "BoligPage";
            this.BoligPage.Padding = new System.Windows.Forms.Padding(3);
            this.BoligPage.Size = new System.Drawing.Size(668, 274);
            this.BoligPage.TabIndex = 0;
            this.BoligPage.Text = "Boliger";
            this.BoligPage.UseVisualStyleBackColor = true;
            // 
            // BoligInfoPage
            // 
            this.BoligInfoPage.Controls.Add(this.dgvBoligInfo);
            this.BoligInfoPage.Location = new System.Drawing.Point(4, 22);
            this.BoligInfoPage.Name = "BoligInfoPage";
            this.BoligInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.BoligInfoPage.Size = new System.Drawing.Size(668, 274);
            this.BoligInfoPage.TabIndex = 1;
            this.BoligInfoPage.Text = "BoligInfo";
            this.BoligInfoPage.UseVisualStyleBackColor = true;
            // 
            // dgvBoligInfo
            // 
            this.dgvBoligInfo.AllowUserToAddRows = false;
            this.dgvBoligInfo.AllowUserToDeleteRows = false;
            this.dgvBoligInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoligInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoligInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBoligInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvBoligInfo.Name = "dgvBoligInfo";
            this.dgvBoligInfo.ReadOnly = true;
            this.dgvBoligInfo.Size = new System.Drawing.Size(662, 268);
            this.dgvBoligInfo.TabIndex = 0;
            // 
            // tbMinKvm
            // 
            this.tbMinKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinKvm.Location = new System.Drawing.Point(22, 116);
            this.tbMinKvm.Name = "tbMinKvm";
            this.tbMinKvm.Size = new System.Drawing.Size(100, 23);
            this.tbMinKvm.TabIndex = 13;
            // 
            // lblMinKvm
            // 
            this.lblMinKvm.AutoSize = true;
            this.lblMinKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinKvm.Location = new System.Drawing.Point(19, 96);
            this.lblMinKvm.Name = "lblMinKvm";
            this.lblMinKvm.Size = new System.Drawing.Size(94, 17);
            this.lblMinKvm.TabIndex = 12;
            this.lblMinKvm.Text = "Minimum Kvm";
            // 
            // tbBoligType
            // 
            this.tbBoligType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoligType.Location = new System.Drawing.Point(412, 116);
            this.tbBoligType.Name = "tbBoligType";
            this.tbBoligType.ReadOnly = true;
            this.tbBoligType.Size = new System.Drawing.Size(100, 23);
            this.tbBoligType.TabIndex = 15;
            // 
            // lblBoligType
            // 
            this.lblBoligType.AutoSize = true;
            this.lblBoligType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoligType.Location = new System.Drawing.Point(409, 96);
            this.lblBoligType.Name = "lblBoligType";
            this.lblBoligType.Size = new System.Drawing.Size(75, 17);
            this.lblBoligType.TabIndex = 14;
            this.lblBoligType.Text = "Bolig Type";
            // 
            // tbMaksKvm
            // 
            this.tbMaksKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaksKvm.Location = new System.Drawing.Point(145, 116);
            this.tbMaksKvm.Name = "tbMaksKvm";
            this.tbMaksKvm.Size = new System.Drawing.Size(100, 23);
            this.tbMaksKvm.TabIndex = 17;
            // 
            // lblMaksKvm
            // 
            this.lblMaksKvm.AutoSize = true;
            this.lblMaksKvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaksKvm.Location = new System.Drawing.Point(142, 96);
            this.lblMaksKvm.Name = "lblMaksKvm";
            this.lblMaksKvm.Size = new System.Drawing.Size(105, 17);
            this.lblMaksKvm.TabIndex = 16;
            this.lblMaksKvm.Text = "Maksimum Kvm";
            // 
            // tbMaksPris
            // 
            this.tbMaksPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaksPris.Location = new System.Drawing.Point(145, 192);
            this.tbMaksPris.Name = "tbMaksPris";
            this.tbMaksPris.Size = new System.Drawing.Size(100, 23);
            this.tbMaksPris.TabIndex = 21;
            // 
            // lblMaksPris
            // 
            this.lblMaksPris.AutoSize = true;
            this.lblMaksPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaksPris.Location = new System.Drawing.Point(142, 172);
            this.lblMaksPris.Name = "lblMaksPris";
            this.lblMaksPris.Size = new System.Drawing.Size(102, 17);
            this.lblMaksPris.TabIndex = 20;
            this.lblMaksPris.Text = "Maksimum Pris";
            // 
            // tbMinPris
            // 
            this.tbMinPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinPris.Location = new System.Drawing.Point(22, 192);
            this.tbMinPris.Name = "tbMinPris";
            this.tbMinPris.Size = new System.Drawing.Size(100, 23);
            this.tbMinPris.TabIndex = 19;
            // 
            // lblMinPris
            // 
            this.lblMinPris.AutoSize = true;
            this.lblMinPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPris.Location = new System.Drawing.Point(19, 172);
            this.lblMinPris.Name = "lblMinPris";
            this.lblMinPris.Size = new System.Drawing.Size(91, 17);
            this.lblMinPris.TabIndex = 18;
            this.lblMinPris.Text = "Minimum Pris";
            // 
            // BoligCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 787);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnVisBDelete);
            this.Controls.Add(this.btnVisBUpdate);
            this.Controls.Add(this.btnVisBRead);
            this.Controls.Add(this.btnVisBCreate);
            this.Name = "BoligCRUD";
            this.Text = "BoligCRUD";
            this.Load += new System.EventHandler(this.BoligCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolig)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.BoligPage.ResumeLayout(false);
            this.BoligInfoPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoligInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBolig;
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
        private System.Windows.Forms.TextBox tbBoligID;
        private System.Windows.Forms.Label lblBoligID;
        private System.Windows.Forms.TextBox tbBy;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BoligPage;
        private System.Windows.Forms.TabPage BoligInfoPage;
        private System.Windows.Forms.DataGridView dgvBoligInfo;
        private System.Windows.Forms.TextBox tbBoligType;
        private System.Windows.Forms.Label lblBoligType;
        private System.Windows.Forms.TextBox tbMinKvm;
        private System.Windows.Forms.Label lblMinKvm;
        private System.Windows.Forms.TextBox tbMaksKvm;
        private System.Windows.Forms.Label lblMaksKvm;
        private System.Windows.Forms.TextBox tbMaksPris;
        private System.Windows.Forms.Label lblMaksPris;
        private System.Windows.Forms.TextBox tbMinPris;
        private System.Windows.Forms.Label lblMinPris;
    }
}