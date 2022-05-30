namespace SonderBoUdlejning.Admin
{
    partial class OpsigelseAfLejemaal
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
            this.tbLid = new System.Windows.Forms.TextBox();
            this.tbPId = new System.Windows.Forms.TextBox();
            this.lblPId = new System.Windows.Forms.Label();
            this.lblLejemaalNr = new System.Windows.Forms.Label();
            this.CBOpsig = new System.Windows.Forms.CheckBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.btnOpsigelse = new System.Windows.Forms.Button();
            this.labelÅrstalOpsig = new System.Windows.Forms.Label();
            this.labelMånedOpsig = new System.Windows.Forms.Label();
            this.dgvLejemaal = new System.Windows.Forms.DataGridView();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.lblLejemaalTabel = new System.Windows.Forms.Label();
            this.lblPersonTabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLejemaal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLid
            // 
            this.tbLid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLid.Location = new System.Drawing.Point(176, 37);
            this.tbLid.Margin = new System.Windows.Forms.Padding(2);
            this.tbLid.Name = "tbLid";
            this.tbLid.Size = new System.Drawing.Size(134, 26);
            this.tbLid.TabIndex = 2;
            // 
            // tbPId
            // 
            this.tbPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPId.Location = new System.Drawing.Point(16, 37);
            this.tbPId.Margin = new System.Windows.Forms.Padding(2);
            this.tbPId.Name = "tbPId";
            this.tbPId.Size = new System.Drawing.Size(133, 26);
            this.tbPId.TabIndex = 3;
            // 
            // lblPId
            // 
            this.lblPId.AutoSize = true;
            this.lblPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPId.Location = new System.Drawing.Point(12, 15);
            this.lblPId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPId.Name = "lblPId";
            this.lblPId.Size = new System.Drawing.Size(137, 20);
            this.lblPId.TabIndex = 4;
            this.lblPId.Text = "Indtast person ID:";
            // 
            // lblLejemaalNr
            // 
            this.lblLejemaalNr.AutoSize = true;
            this.lblLejemaalNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLejemaalNr.Location = new System.Drawing.Point(172, 15);
            this.lblLejemaalNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLejemaalNr.Name = "lblLejemaalNr";
            this.lblLejemaalNr.Size = new System.Drawing.Size(142, 20);
            this.lblLejemaalNr.TabIndex = 5;
            this.lblLejemaalNr.Text = "Indtast lejemål nr.: ";
            // 
            // CBOpsig
            // 
            this.CBOpsig.AutoSize = true;
            this.CBOpsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOpsig.Location = new System.Drawing.Point(15, 106);
            this.CBOpsig.Margin = new System.Windows.Forms.Padding(2);
            this.CBOpsig.Name = "CBOpsig";
            this.CBOpsig.Size = new System.Drawing.Size(210, 24);
            this.CBOpsig.TabIndex = 6;
            this.CBOpsig.Text = "Ønsker at opsige lejemål?";
            this.CBOpsig.UseVisualStyleBackColor = true;
            // 
            // comboMonth
            // 
            this.comboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Location = new System.Drawing.Point(15, 166);
            this.comboMonth.Margin = new System.Windows.Forms.Padding(2);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(114, 28);
            this.comboMonth.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.comboYear);
            this.panel1.Controls.Add(this.btnOpsigelse);
            this.panel1.Controls.Add(this.labelÅrstalOpsig);
            this.panel1.Controls.Add(this.labelMånedOpsig);
            this.panel1.Controls.Add(this.comboMonth);
            this.panel1.Controls.Add(this.CBOpsig);
            this.panel1.Controls.Add(this.lblLejemaalNr);
            this.panel1.Controls.Add(this.lblPId);
            this.panel1.Controls.Add(this.tbPId);
            this.panel1.Controls.Add(this.tbLid);
            this.panel1.Location = new System.Drawing.Point(22, 474);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 218);
            this.panel1.TabIndex = 9;
            // 
            // comboYear
            // 
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(157, 166);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(121, 28);
            this.comboYear.TabIndex = 12;
            // 
            // btnOpsigelse
            // 
            this.btnOpsigelse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpsigelse.Location = new System.Drawing.Point(316, 156);
            this.btnOpsigelse.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpsigelse.Name = "btnOpsigelse";
            this.btnOpsigelse.Size = new System.Drawing.Size(167, 46);
            this.btnOpsigelse.TabIndex = 11;
            this.btnOpsigelse.Text = "Opsigelse af Lejemål";
            this.btnOpsigelse.UseVisualStyleBackColor = true;
            this.btnOpsigelse.Click += new System.EventHandler(this.btnOpsigelse_Click);
            // 
            // labelÅrstalOpsig
            // 
            this.labelÅrstalOpsig.AutoSize = true;
            this.labelÅrstalOpsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelÅrstalOpsig.Location = new System.Drawing.Point(153, 144);
            this.labelÅrstalOpsig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelÅrstalOpsig.Name = "labelÅrstalOpsig";
            this.labelÅrstalOpsig.Size = new System.Drawing.Size(50, 20);
            this.labelÅrstalOpsig.TabIndex = 10;
            this.labelÅrstalOpsig.Text = "Årstal";
            // 
            // labelMånedOpsig
            // 
            this.labelMånedOpsig.AutoSize = true;
            this.labelMånedOpsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMånedOpsig.Location = new System.Drawing.Point(12, 144);
            this.labelMånedOpsig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMånedOpsig.Name = "labelMånedOpsig";
            this.labelMånedOpsig.Size = new System.Drawing.Size(58, 20);
            this.labelMånedOpsig.TabIndex = 9;
            this.labelMånedOpsig.Text = "Måned";
            // 
            // dgvLejemaal
            // 
            this.dgvLejemaal.AllowUserToAddRows = false;
            this.dgvLejemaal.AllowUserToDeleteRows = false;
            this.dgvLejemaal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLejemaal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLejemaal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLejemaal.Location = new System.Drawing.Point(6, 6);
            this.dgvLejemaal.Name = "dgvLejemaal";
            this.dgvLejemaal.ReadOnly = true;
            this.dgvLejemaal.Size = new System.Drawing.Size(896, 391);
            this.dgvLejemaal.TabIndex = 10;
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerson.Location = new System.Drawing.Point(6, 6);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(728, 391);
            this.dgvPerson.TabIndex = 11;
            // 
            // lblLejemaalTabel
            // 
            this.lblLejemaalTabel.AutoSize = true;
            this.lblLejemaalTabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLejemaalTabel.Location = new System.Drawing.Point(18, 9);
            this.lblLejemaalTabel.Name = "lblLejemaalTabel";
            this.lblLejemaalTabel.Size = new System.Drawing.Size(306, 24);
            this.lblLejemaalTabel.TabIndex = 12;
            this.lblLejemaalTabel.Text = "Oversigt over lejemål med beboere";
            // 
            // lblPersonTabel
            // 
            this.lblPersonTabel.AutoSize = true;
            this.lblPersonTabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonTabel.Location = new System.Drawing.Point(956, 9);
            this.lblPersonTabel.Name = "lblPersonTabel";
            this.lblPersonTabel.Size = new System.Drawing.Size(368, 24);
            this.lblPersonTabel.TabIndex = 13;
            this.lblPersonTabel.Text = "Oversigt over medlemmer som er beboere";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLejemaal);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(16, 36);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(908, 403);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPerson);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(954, 36);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(740, 403);
            this.panel3.TabIndex = 15;
            // 
            // OpsigelseAfLejemaal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 703);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPersonTabel);
            this.Controls.Add(this.lblLejemaalTabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OpsigelseAfLejemaal";
            this.Text = "OpsigelseAfLejemaal";
            this.Load += new System.EventHandler(this.OpsigelseAfLejemaal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLejemaal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbLid;
        private System.Windows.Forms.TextBox tbPId;
        private System.Windows.Forms.Label lblPId;
        private System.Windows.Forms.Label lblLejemaalNr;
        private System.Windows.Forms.CheckBox CBOpsig;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpsigelse;
        private System.Windows.Forms.Label labelÅrstalOpsig;
        private System.Windows.Forms.Label labelMånedOpsig;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.DataGridView dgvLejemaal;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Label lblLejemaalTabel;
        private System.Windows.Forms.Label lblPersonTabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}