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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVVenteListe = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVPersoner = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVBoliger = new System.Windows.Forms.DataGridView();
            this.InsertToList = new System.Windows.Forms.Button();
            this.pIdTextbox = new System.Windows.Forms.TextBox();
            this.bIdTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteFromListButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GetPosition = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVenteListe)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersoner)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBoliger)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(28, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 192);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVVenteListe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage1.Size = new System.Drawing.Size(544, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venteliste";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVVenteListe
            // 
            this.DGVVenteListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVenteListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVVenteListe.Location = new System.Drawing.Point(1, 1);
            this.DGVVenteListe.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DGVVenteListe.Name = "DGVVenteListe";
            this.DGVVenteListe.RowHeadersWidth = 92;
            this.DGVVenteListe.RowTemplate.Height = 37;
            this.DGVVenteListe.Size = new System.Drawing.Size(542, 164);
            this.DGVVenteListe.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVPersoner);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage2.Size = new System.Drawing.Size(544, 166);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVPersoner
            // 
            this.DGVPersoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersoner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPersoner.Location = new System.Drawing.Point(1, 1);
            this.DGVPersoner.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DGVPersoner.Name = "DGVPersoner";
            this.DGVPersoner.RowHeadersWidth = 92;
            this.DGVPersoner.RowTemplate.Height = 37;
            this.DGVPersoner.Size = new System.Drawing.Size(542, 164);
            this.DGVPersoner.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVBoliger);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPage3.Size = new System.Drawing.Size(544, 166);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Boliger";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVBoliger
            // 
            this.DGVBoliger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBoliger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBoliger.Location = new System.Drawing.Point(1, 1);
            this.DGVBoliger.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DGVBoliger.Name = "DGVBoliger";
            this.DGVBoliger.RowHeadersWidth = 92;
            this.DGVBoliger.RowTemplate.Height = 37;
            this.DGVBoliger.Size = new System.Drawing.Size(542, 164);
            this.DGVBoliger.TabIndex = 0;
            // 
            // InsertToList
            // 
            this.InsertToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertToList.Location = new System.Drawing.Point(28, 355);
            this.InsertToList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.InsertToList.Name = "InsertToList";
            this.InsertToList.Size = new System.Drawing.Size(118, 61);
            this.InsertToList.TabIndex = 2;
            this.InsertToList.Text = "Tilføj til liste";
            this.toolTip.SetToolTip(this.InsertToList, "Indtast tal i både pId og bId for at tilføje en person\r\n til en specifik boligs v" +
        "enteliste");
            this.InsertToList.UseVisualStyleBackColor = true;
            this.InsertToList.Click += new System.EventHandler(this.InsertToList_Click);
            // 
            // pIdTextbox
            // 
            this.pIdTextbox.Location = new System.Drawing.Point(34, 272);
            this.pIdTextbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pIdTextbox.Name = "pIdTextbox";
            this.pIdTextbox.Size = new System.Drawing.Size(45, 20);
            this.pIdTextbox.TabIndex = 3;
            // 
            // bIdTextbox
            // 
            this.bIdTextbox.Location = new System.Drawing.Point(34, 315);
            this.bIdTextbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.bIdTextbox.Name = "bIdTextbox";
            this.bIdTextbox.Size = new System.Drawing.Size(45, 20);
            this.bIdTextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "pId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "bId";
            // 
            // DeleteFromListButton
            // 
            this.DeleteFromListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFromListButton.Location = new System.Drawing.Point(167, 361);
            this.DeleteFromListButton.Name = "DeleteFromListButton";
            this.DeleteFromListButton.Size = new System.Drawing.Size(151, 54);
            this.DeleteFromListButton.TabIndex = 7;
            this.DeleteFromListButton.Text = "Slet fra liste";
            this.toolTip.SetToolTip(this.DeleteFromListButton, "Indtast kun pId for at slette den person fra alle ventelister.\r\nIndtast både pId " +
        "og bId for at slette en person på en specifik bolig.\r\nIndtast kun bId for at sle" +
        "tte alle på den boligs venteliste.");
            this.DeleteFromListButton.UseVisualStyleBackColor = true;
            this.DeleteFromListButton.Click += new System.EventHandler(this.DeleteFromListButton_Click);
            // 
            // GetPosition
            // 
            this.GetPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPosition.Location = new System.Drawing.Point(351, 361);
            this.GetPosition.Name = "GetPosition";
            this.GetPosition.Size = new System.Drawing.Size(122, 54);
            this.GetPosition.TabIndex = 8;
            this.GetPosition.Text = "Få position";
            this.toolTip.SetToolTip(this.GetPosition, "Få en persons positionen på en specifik bolig");
            this.GetPosition.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Din position er:";
            // 
            // VenteListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GetPosition);
            this.Controls.Add(this.DeleteFromListButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bIdTextbox);
            this.Controls.Add(this.pIdTextbox);
            this.Controls.Add(this.InsertToList);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "VenteListe";
            this.Text = "VenteListe";
            this.Load += new System.EventHandler(this.VenteListe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVenteListe)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersoner)).EndInit();
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.Button DeleteFromListButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button GetPosition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}