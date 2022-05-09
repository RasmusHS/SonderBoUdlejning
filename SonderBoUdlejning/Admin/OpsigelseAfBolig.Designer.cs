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
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBolig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVBolig
            // 
            this.DGVBolig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBolig.Location = new System.Drawing.Point(12, 12);
            this.DGVBolig.Name = "DGVBolig";
            this.DGVBolig.RowHeadersWidth = 92;
            this.DGVBolig.RowTemplate.Height = 37;
            this.DGVBolig.Size = new System.Drawing.Size(650, 400);
            this.DGVBolig.TabIndex = 0;
            // 
            // DGVPerson
            // 
            this.DGVPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPerson.Location = new System.Drawing.Point(743, 12);
            this.DGVPerson.Name = "DGVPerson";
            this.DGVPerson.RowHeadersWidth = 92;
            this.DGVPerson.RowTemplate.Height = 37;
            this.DGVPerson.Size = new System.Drawing.Size(650, 400);
            this.DGVPerson.TabIndex = 1;
            // 
            // tbBiD
            // 
            this.tbBiD.Location = new System.Drawing.Point(69, 539);
            this.tbBiD.Name = "tbBiD";
            this.tbBiD.Size = new System.Drawing.Size(100, 35);
            this.tbBiD.TabIndex = 2;
            // 
            // tbPiD
            // 
            this.tbPiD.Location = new System.Drawing.Point(355, 538);
            this.tbPiD.Name = "tbPiD";
            this.tbPiD.Size = new System.Drawing.Size(100, 35);
            this.tbPiD.TabIndex = 3;
            // 
            // labelPiD
            // 
            this.labelPiD.AutoSize = true;
            this.labelPiD.Location = new System.Drawing.Point(66, 482);
            this.labelPiD.Name = "labelPiD";
            this.labelPiD.Size = new System.Drawing.Size(125, 29);
            this.labelPiD.TabIndex = 4;
            this.labelPiD.Text = "Person ID:";
            // 
            // labelBiD
            // 
            this.labelBiD.AutoSize = true;
            this.labelBiD.Location = new System.Drawing.Point(362, 499);
            this.labelBiD.Name = "labelBiD";
            this.labelBiD.Size = new System.Drawing.Size(110, 29);
            this.labelBiD.TabIndex = 5;
            this.labelBiD.Text = "Bolig ID: ";
            // 
            // CBOpsig
            // 
            this.CBOpsig.AutoSize = true;
            this.CBOpsig.Location = new System.Drawing.Point(71, 636);
            this.CBOpsig.Name = "CBOpsig";
            this.CBOpsig.Size = new System.Drawing.Size(325, 33);
            this.CBOpsig.TabIndex = 6;
            this.CBOpsig.Text = "Ønsker at opsige lejemål?";
            this.CBOpsig.UseVisualStyleBackColor = true;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(59, 776);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(260, 37);
            this.comboBoxMonth.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 755);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 8;
            // 
            // OpsigelseAfBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 882);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.CBOpsig);
            this.Controls.Add(this.labelBiD);
            this.Controls.Add(this.labelPiD);
            this.Controls.Add(this.tbPiD);
            this.Controls.Add(this.tbBiD);
            this.Controls.Add(this.DGVPerson);
            this.Controls.Add(this.DGVBolig);
            this.Name = "OpsigelseAfBolig";
            this.Text = "OpsigelseAfBolig";
            this.Load += new System.EventHandler(this.OpsigelseAfBolig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBolig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
    }
}