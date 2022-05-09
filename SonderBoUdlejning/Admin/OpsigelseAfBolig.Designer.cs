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
            this.DGVBolig = new System.Windows.Forms.DataGridView();
            this.DGVPerson = new System.Windows.Forms.DataGridView();
            this.tbBiD = new System.Windows.Forms.TextBox();
            this.tbPiD = new System.Windows.Forms.TextBox();
            this.labelPiD = new System.Windows.Forms.Label();
            this.labelBiD = new System.Windows.Forms.Label();
            this.CBOpsig = new System.Windows.Forms.CheckBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.TBYear = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpsigelse = new System.Windows.Forms.Button();
            this.labelÅrstalOpsig = new System.Windows.Forms.Label();
            this.labelMånedOpsig = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBolig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerson)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVBolig
            // 
            this.DGVBolig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBolig.Location = new System.Drawing.Point(12, 13);
            this.DGVBolig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVBolig.Name = "DGVBolig";
            this.DGVBolig.RowHeadersWidth = 92;
            this.DGVBolig.RowTemplate.Height = 37;
            this.DGVBolig.Size = new System.Drawing.Size(649, 401);
            this.DGVBolig.TabIndex = 0;
            // 
            // DGVPerson
            // 
            this.DGVPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPerson.Location = new System.Drawing.Point(744, 13);
            this.DGVPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVPerson.Name = "DGVPerson";
            this.DGVPerson.RowHeadersWidth = 92;
            this.DGVPerson.RowTemplate.Height = 37;
            this.DGVPerson.Size = new System.Drawing.Size(649, 401);
            this.DGVPerson.TabIndex = 1;
            // 
            // tbBiD
            // 
            this.tbBiD.Location = new System.Drawing.Point(37, 83);
            this.tbBiD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBiD.Name = "tbBiD";
            this.tbBiD.Size = new System.Drawing.Size(100, 35);
            this.tbBiD.TabIndex = 2;
            // 
            // tbPiD
            // 
            this.tbPiD.Location = new System.Drawing.Point(324, 83);
            this.tbPiD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPiD.Name = "tbPiD";
            this.tbPiD.Size = new System.Drawing.Size(100, 35);
            this.tbPiD.TabIndex = 3;
            // 
            // labelPiD
            // 
            this.labelPiD.AutoSize = true;
            this.labelPiD.Location = new System.Drawing.Point(35, 27);
            this.labelPiD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPiD.Name = "labelPiD";
            this.labelPiD.Size = new System.Drawing.Size(125, 29);
            this.labelPiD.TabIndex = 4;
            this.labelPiD.Text = "Person ID:";
            // 
            // labelBiD
            // 
            this.labelBiD.AutoSize = true;
            this.labelBiD.Location = new System.Drawing.Point(331, 44);
            this.labelBiD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBiD.Name = "labelBiD";
            this.labelBiD.Size = new System.Drawing.Size(110, 29);
            this.labelBiD.TabIndex = 5;
            this.labelBiD.Text = "Bolig ID: ";
            // 
            // CBOpsig
            // 
            this.CBOpsig.AutoSize = true;
            this.CBOpsig.Location = new System.Drawing.Point(37, 208);
            this.CBOpsig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBOpsig.Name = "CBOpsig";
            this.CBOpsig.Size = new System.Drawing.Size(325, 33);
            this.CBOpsig.TabIndex = 6;
            this.CBOpsig.Text = "Ønsker at opsige lejemål?";
            this.CBOpsig.UseVisualStyleBackColor = true;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(37, 328);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(260, 37);
            this.comboBoxMonth.TabIndex = 7;
            // 
            // TBYear
            // 
            this.TBYear.Location = new System.Drawing.Point(446, 328);
            this.TBYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBYear.Name = "TBYear";
            this.TBYear.Size = new System.Drawing.Size(100, 35);
            this.TBYear.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnOpsigelse);
            this.panel1.Controls.Add(this.labelÅrstalOpsig);
            this.panel1.Controls.Add(this.labelMånedOpsig);
            this.panel1.Controls.Add(this.TBYear);
            this.panel1.Controls.Add(this.comboBoxMonth);
            this.panel1.Controls.Add(this.CBOpsig);
            this.panel1.Controls.Add(this.labelBiD);
            this.panel1.Controls.Add(this.labelPiD);
            this.panel1.Controls.Add(this.tbPiD);
            this.panel1.Controls.Add(this.tbBiD);
            this.panel1.Location = new System.Drawing.Point(12, 455);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 542);
            this.panel1.TabIndex = 9;
            // 
            // btnOpsigelse
            // 
            this.btnOpsigelse.Location = new System.Drawing.Point(756, 290);
            this.btnOpsigelse.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOpsigelse.Name = "btnOpsigelse";
            this.btnOpsigelse.Size = new System.Drawing.Size(298, 102);
            this.btnOpsigelse.TabIndex = 11;
            this.btnOpsigelse.Text = "Opsigelse af Lejemål";
            this.btnOpsigelse.UseVisualStyleBackColor = true;
            this.btnOpsigelse.Click += new System.EventHandler(this.btnOpsigelse_Click);
            // 
            // labelÅrstalOpsig
            // 
            this.labelÅrstalOpsig.AutoSize = true;
            this.labelÅrstalOpsig.Location = new System.Drawing.Point(441, 277);
            this.labelÅrstalOpsig.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelÅrstalOpsig.Name = "labelÅrstalOpsig";
            this.labelÅrstalOpsig.Size = new System.Drawing.Size(73, 29);
            this.labelÅrstalOpsig.TabIndex = 10;
            this.labelÅrstalOpsig.Text = "Årstal";
            // 
            // labelMånedOpsig
            // 
            this.labelMånedOpsig.AutoSize = true;
            this.labelMånedOpsig.Location = new System.Drawing.Point(32, 277);
            this.labelMånedOpsig.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMånedOpsig.Name = "labelMånedOpsig";
            this.labelMånedOpsig.Size = new System.Drawing.Size(87, 29);
            this.labelMånedOpsig.TabIndex = 9;
            this.labelMånedOpsig.Text = "Måned";
            // 
            // OpsigelseAfBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1097);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVPerson);
            this.Controls.Add(this.DGVBolig);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OpsigelseAfBolig";
            this.Text = "OpsigelseAfBolig";
            this.Load += new System.EventHandler(this.OpsigelseAfBolig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBolig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerson)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVBolig;
        private System.Windows.Forms.DataGridView DGVPerson;
        private System.Windows.Forms.TextBox tbBiD;
        private System.Windows.Forms.TextBox tbPiD;
        private System.Windows.Forms.Label labelPiD;
        private System.Windows.Forms.Label labelBiD;
        private System.Windows.Forms.CheckBox CBOpsig;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.TextBox TBYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpsigelse;
        private System.Windows.Forms.Label labelÅrstalOpsig;
        private System.Windows.Forms.Label labelMånedOpsig;
    }
}