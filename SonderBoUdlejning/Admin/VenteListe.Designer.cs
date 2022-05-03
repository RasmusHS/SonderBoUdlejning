namespace SonderBoUdlejning.Admin
{
    partial class VenteListe
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVVenteListe = new System.Windows.Forms.DataGridView();
            this.DGVPersoner = new System.Windows.Forms.DataGridView();
            this.DGVBoliger = new System.Windows.Forms.DataGridView();
            this.InsertToList = new System.Windows.Forms.Button();
            this.pIdTextbox = new System.Windows.Forms.TextBox();
            this.bIdTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVenteListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersoner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBoliger)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(66, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1287, 428);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVVenteListe);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1267, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venteliste";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVPersoner);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1267, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVBoliger);
            this.tabPage3.Location = new System.Drawing.Point(10, 47);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1267, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Boliger";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVVenteListe
            // 
            this.DGVVenteListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVenteListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVVenteListe.Location = new System.Drawing.Point(3, 3);
            this.DGVVenteListe.Name = "DGVVenteListe";
            this.DGVVenteListe.RowHeadersWidth = 92;
            this.DGVVenteListe.RowTemplate.Height = 37;
            this.DGVVenteListe.Size = new System.Drawing.Size(1261, 365);
            this.DGVVenteListe.TabIndex = 0;
            // 
            // DGVPersoner
            // 
            this.DGVPersoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersoner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPersoner.Location = new System.Drawing.Point(3, 3);
            this.DGVPersoner.Name = "DGVPersoner";
            this.DGVPersoner.RowHeadersWidth = 92;
            this.DGVPersoner.RowTemplate.Height = 37;
            this.DGVPersoner.Size = new System.Drawing.Size(1261, 365);
            this.DGVPersoner.TabIndex = 0;
            // 
            // DGVBoliger
            // 
            this.DGVBoliger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBoliger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBoliger.Location = new System.Drawing.Point(3, 3);
            this.DGVBoliger.Name = "DGVBoliger";
            this.DGVBoliger.RowHeadersWidth = 92;
            this.DGVBoliger.RowTemplate.Height = 37;
            this.DGVBoliger.Size = new System.Drawing.Size(1261, 365);
            this.DGVBoliger.TabIndex = 0;
            // 
            // InsertToList
            // 
            this.InsertToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertToList.Location = new System.Drawing.Point(66, 838);
            this.InsertToList.Name = "InsertToList";
            this.InsertToList.Size = new System.Drawing.Size(275, 136);
            this.InsertToList.TabIndex = 2;
            this.InsertToList.Text = "Tilføj til liste";
            this.InsertToList.UseVisualStyleBackColor = true;
            this.InsertToList.Click += new System.EventHandler(this.InsertToList_Click);
            // 
            // pIdTextbox
            // 
            this.pIdTextbox.Location = new System.Drawing.Point(79, 607);
            this.pIdTextbox.Name = "pIdTextbox";
            this.pIdTextbox.Size = new System.Drawing.Size(100, 35);
            this.pIdTextbox.TabIndex = 3;
            // 
            // bIdTextbox
            // 
            this.bIdTextbox.Location = new System.Drawing.Point(79, 703);
            this.bIdTextbox.Name = "bIdTextbox";
            this.bIdTextbox.Size = new System.Drawing.Size(100, 35);
            this.bIdTextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "pId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 668);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "bId";
            // 
            // VenteListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 986);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bIdTextbox);
            this.Controls.Add(this.pIdTextbox);
            this.Controls.Add(this.InsertToList);
            this.Controls.Add(this.tabControl1);
            this.Name = "VenteListe";
            this.Text = "VenteListe";
            this.Load += new System.EventHandler(this.VenteListe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVenteListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersoner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBoliger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVVenteListe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVPersoner;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVBoliger;
        private System.Windows.Forms.Button InsertToList;
        private System.Windows.Forms.TextBox pIdTextbox;
        private System.Windows.Forms.TextBox bIdTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}