namespace SonderBoUdlejning.Admin
{
    partial class OpsigelseAfBolig
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
            this.tbBiD = new System.Windows.Forms.TextBox();
            this.tbPiD = new System.Windows.Forms.TextBox();
            this.labelPiD = new System.Windows.Forms.Label();
            this.labelBiD = new System.Windows.Forms.Label();
            this.CBOpsig = new System.Windows.Forms.CheckBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.btnOpsigelse = new System.Windows.Forms.Button();
            this.labelÅrstalOpsig = new System.Windows.Forms.Label();
            this.labelMånedOpsig = new System.Windows.Forms.Label();
            this.DGVBolig = new System.Windows.Forms.DataGridView();
            this.DGVPerson = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBolig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBiD
            // 
            this.tbBiD.Location = new System.Drawing.Point(137, 37);
            this.tbBiD.Margin = new System.Windows.Forms.Padding(2);
            this.tbBiD.Name = "tbBiD";
            this.tbBiD.Size = new System.Drawing.Size(74, 20);
            this.tbBiD.TabIndex = 2;
            // 
            // tbPiD
            // 
            this.tbPiD.Location = new System.Drawing.Point(16, 37);
            this.tbPiD.Margin = new System.Windows.Forms.Padding(2);
            this.tbPiD.Name = "tbPiD";
            this.tbPiD.Size = new System.Drawing.Size(74, 20);
            this.tbPiD.TabIndex = 3;
            // 
            // labelPiD
            // 
            this.labelPiD.AutoSize = true;
            this.labelPiD.Location = new System.Drawing.Point(13, 22);
            this.labelPiD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPiD.Name = "labelPiD";
            this.labelPiD.Size = new System.Drawing.Size(57, 13);
            this.labelPiD.TabIndex = 4;
            this.labelPiD.Text = "Person ID:";
            // 
            // labelBiD
            // 
            this.labelBiD.AutoSize = true;
            this.labelBiD.Location = new System.Drawing.Point(134, 22);
            this.labelBiD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBiD.Name = "labelBiD";
            this.labelBiD.Size = new System.Drawing.Size(50, 13);
            this.labelBiD.TabIndex = 5;
            this.labelBiD.Text = "Bolig ID: ";
            // 
            // CBOpsig
            // 
            this.CBOpsig.AutoSize = true;
            this.CBOpsig.Location = new System.Drawing.Point(16, 93);
            this.CBOpsig.Margin = new System.Windows.Forms.Padding(2);
            this.CBOpsig.Name = "CBOpsig";
            this.CBOpsig.Size = new System.Drawing.Size(147, 17);
            this.CBOpsig.TabIndex = 6;
            this.CBOpsig.Text = "Ønsker at opsige lejemål?";
            this.CBOpsig.UseVisualStyleBackColor = true;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(16, 147);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(114, 21);
            this.comboBoxMonth.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.comboBoxYear);
            this.panel1.Controls.Add(this.btnOpsigelse);
            this.panel1.Controls.Add(this.labelÅrstalOpsig);
            this.panel1.Controls.Add(this.labelMånedOpsig);
            this.panel1.Controls.Add(this.comboBoxMonth);
            this.panel1.Controls.Add(this.CBOpsig);
            this.panel1.Controls.Add(this.labelBiD);
            this.panel1.Controls.Add(this.labelPiD);
            this.panel1.Controls.Add(this.tbPiD);
            this.panel1.Controls.Add(this.tbBiD);
            this.panel1.Location = new System.Drawing.Point(315, 209);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 206);
            this.panel1.TabIndex = 9;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(157, 147);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 12;
            // 
            // btnOpsigelse
            // 
            this.btnOpsigelse.Location = new System.Drawing.Point(324, 130);
            this.btnOpsigelse.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpsigelse.Name = "btnOpsigelse";
            this.btnOpsigelse.Size = new System.Drawing.Size(128, 46);
            this.btnOpsigelse.TabIndex = 11;
            this.btnOpsigelse.Text = "Opsigelse af Lejemål";
            this.btnOpsigelse.UseVisualStyleBackColor = true;
            this.btnOpsigelse.Click += new System.EventHandler(this.btnOpsigelse_Click);
            // 
            // labelÅrstalOpsig
            // 
            this.labelÅrstalOpsig.AutoSize = true;
            this.labelÅrstalOpsig.Location = new System.Drawing.Point(154, 132);
            this.labelÅrstalOpsig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelÅrstalOpsig.Name = "labelÅrstalOpsig";
            this.labelÅrstalOpsig.Size = new System.Drawing.Size(33, 13);
            this.labelÅrstalOpsig.TabIndex = 10;
            this.labelÅrstalOpsig.Text = "Årstal";
            // 
            // labelMånedOpsig
            // 
            this.labelMånedOpsig.AutoSize = true;
            this.labelMånedOpsig.Location = new System.Drawing.Point(13, 132);
            this.labelMånedOpsig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMånedOpsig.Name = "labelMånedOpsig";
            this.labelMånedOpsig.Size = new System.Drawing.Size(40, 13);
            this.labelMånedOpsig.TabIndex = 9;
            this.labelMånedOpsig.Text = "Måned";
            // 
            // DGVBolig
            // 
            this.DGVBolig.AllowUserToAddRows = false;
            this.DGVBolig.AllowUserToDeleteRows = false;
            this.DGVBolig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBolig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBolig.Location = new System.Drawing.Point(12, 6);
            this.DGVBolig.Name = "DGVBolig";
            this.DGVBolig.ReadOnly = true;
            this.DGVBolig.Size = new System.Drawing.Size(553, 180);
            this.DGVBolig.TabIndex = 10;
            // 
            // DGVPerson
            // 
            this.DGVPerson.AllowUserToAddRows = false;
            this.DGVPerson.AllowUserToDeleteRows = false;
            this.DGVPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPerson.Location = new System.Drawing.Point(595, 6);
            this.DGVPerson.Name = "DGVPerson";
            this.DGVPerson.ReadOnly = true;
            this.DGVPerson.Size = new System.Drawing.Size(553, 180);
            this.DGVPerson.TabIndex = 11;
            // 
            // OpsigelseAfBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 549);
            this.Controls.Add(this.DGVPerson);
            this.Controls.Add(this.DGVBolig);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OpsigelseAfBolig";
            this.Text = "OpsigelseAfBolig";
            this.Load += new System.EventHandler(this.OpsigelseAfBolig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBolig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbBiD;
        private System.Windows.Forms.TextBox tbPiD;
        private System.Windows.Forms.Label labelPiD;
        private System.Windows.Forms.Label labelBiD;
        private System.Windows.Forms.CheckBox CBOpsig;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpsigelse;
        private System.Windows.Forms.Label labelÅrstalOpsig;
        private System.Windows.Forms.Label labelMånedOpsig;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.DataGridView DGVBolig;
        private System.Windows.Forms.DataGridView DGVPerson;
    }
}