﻿namespace SonderBoUdlejning.Admin
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
            this.labelpId = new System.Windows.Forms.Label();
            this.labelbId = new System.Windows.Forms.Label();
            this.DeleteFromListButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GetPosition = new System.Windows.Forms.Button();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnDeleteFromList = new System.Windows.Forms.Button();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnVisVentelisteFor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVenteListe)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersoner)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBoliger)).BeginInit();
            this.panelInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(56, 79);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1104, 369);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVVenteListe);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(1088, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venteliste";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVVenteListe
            // 
            this.DGVVenteListe.AllowUserToAddRows = false;
            this.DGVVenteListe.AllowUserToDeleteRows = false;
            this.DGVVenteListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVVenteListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVenteListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVVenteListe.Location = new System.Drawing.Point(2, 2);
            this.DGVVenteListe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVVenteListe.Name = "DGVVenteListe";
            this.DGVVenteListe.ReadOnly = true;
            this.DGVVenteListe.RowHeadersWidth = 92;
            this.DGVVenteListe.RowTemplate.Height = 37;
            this.DGVVenteListe.Size = new System.Drawing.Size(1084, 318);
            this.DGVVenteListe.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVPersoner);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1088, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVPersoner
            // 
            this.DGVPersoner.AllowUserToAddRows = false;
            this.DGVPersoner.AllowUserToDeleteRows = false;
            this.DGVPersoner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPersoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersoner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPersoner.Location = new System.Drawing.Point(2, 2);
            this.DGVPersoner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVPersoner.Name = "DGVPersoner";
            this.DGVPersoner.ReadOnly = true;
            this.DGVPersoner.RowHeadersWidth = 92;
            this.DGVPersoner.RowTemplate.Height = 37;
            this.DGVPersoner.Size = new System.Drawing.Size(1084, 318);
            this.DGVPersoner.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVBoliger);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(1088, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Boliger";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVBoliger
            // 
            this.DGVBoliger.AllowUserToAddRows = false;
            this.DGVBoliger.AllowUserToDeleteRows = false;
            this.DGVBoliger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBoliger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBoliger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBoliger.Location = new System.Drawing.Point(2, 2);
            this.DGVBoliger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVBoliger.Name = "DGVBoliger";
            this.DGVBoliger.ReadOnly = true;
            this.DGVBoliger.RowHeadersWidth = 92;
            this.DGVBoliger.RowTemplate.Height = 37;
            this.DGVBoliger.Size = new System.Drawing.Size(1084, 318);
            this.DGVBoliger.TabIndex = 0;
            // 
            // InsertToList
            // 
            this.InsertToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertToList.Location = new System.Drawing.Point(20, 271);
            this.InsertToList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InsertToList.Name = "InsertToList";
            this.InsertToList.Size = new System.Drawing.Size(236, 104);
            this.InsertToList.TabIndex = 2;
            this.InsertToList.Text = "Tilføj til liste";
            this.toolTip.SetToolTip(this.InsertToList, "Indtast tal i både pId og bId for at tilføje en person\r\n til en specifik boligs v" +
        "enteliste");
            this.InsertToList.UseVisualStyleBackColor = true;
            this.InsertToList.Click += new System.EventHandler(this.InsertToList_Click);
            // 
            // pIdTextbox
            // 
            this.pIdTextbox.Location = new System.Drawing.Point(20, 75);
            this.pIdTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pIdTextbox.Name = "pIdTextbox";
            this.pIdTextbox.Size = new System.Drawing.Size(86, 31);
            this.pIdTextbox.TabIndex = 3;
            // 
            // bIdTextbox
            // 
            this.bIdTextbox.Location = new System.Drawing.Point(20, 181);
            this.bIdTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bIdTextbox.Name = "bIdTextbox";
            this.bIdTextbox.Size = new System.Drawing.Size(86, 31);
            this.bIdTextbox.TabIndex = 4;
            // 
            // labelpId
            // 
            this.labelpId.AutoSize = true;
            this.labelpId.Location = new System.Drawing.Point(15, 48);
            this.labelpId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelpId.Name = "labelpId";
            this.labelpId.Size = new System.Drawing.Size(41, 25);
            this.labelpId.TabIndex = 5;
            this.labelpId.Text = "pId";
            // 
            // labelbId
            // 
            this.labelbId.AutoSize = true;
            this.labelbId.Location = new System.Drawing.Point(15, 154);
            this.labelbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelbId.Name = "labelbId";
            this.labelbId.Size = new System.Drawing.Size(41, 25);
            this.labelbId.TabIndex = 6;
            this.labelbId.Text = "bId";
            // 
            // DeleteFromListButton
            // 
            this.DeleteFromListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFromListButton.Location = new System.Drawing.Point(314, 271);
            this.DeleteFromListButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeleteFromListButton.Name = "DeleteFromListButton";
            this.DeleteFromListButton.Size = new System.Drawing.Size(302, 104);
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
            this.GetPosition.Location = new System.Drawing.Point(666, 271);
            this.GetPosition.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GetPosition.Name = "GetPosition";
            this.GetPosition.Size = new System.Drawing.Size(244, 104);
            this.GetPosition.TabIndex = 8;
            this.GetPosition.Text = "Få position";
            this.toolTip.SetToolTip(this.GetPosition, "Få en persons positionen på en specifik bolig");
            this.GetPosition.UseVisualStyleBackColor = true;
            this.GetPosition.Click += new System.EventHandler(this.GetPosition_Click);
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(666, 181);
            this.positionTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(240, 31);
            this.positionTextBox.TabIndex = 9;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPosition.Location = new System.Drawing.Point(660, 150);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(156, 25);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "Din position er:";
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelInputs.Controls.Add(this.btnVisVentelisteFor);
            this.panelInputs.Controls.Add(this.DeleteFromListButton);
            this.panelInputs.Controls.Add(this.InsertToList);
            this.panelInputs.Controls.Add(this.pIdTextbox);
            this.panelInputs.Controls.Add(this.labelpId);
            this.panelInputs.Controls.Add(this.labelPosition);
            this.panelInputs.Controls.Add(this.labelbId);
            this.panelInputs.Controls.Add(this.positionTextBox);
            this.panelInputs.Controls.Add(this.GetPosition);
            this.panelInputs.Controls.Add(this.bIdTextbox);
            this.panelInputs.Location = new System.Drawing.Point(66, 606);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(1094, 427);
            this.panelInputs.TabIndex = 11;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToList.Location = new System.Drawing.Point(66, 482);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(232, 86);
            this.btnAddToList.TabIndex = 12;
            this.btnAddToList.Text = "Tilføj til liste";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnDeleteFromList
            // 
            this.btnDeleteFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFromList.Location = new System.Drawing.Point(343, 482);
            this.btnDeleteFromList.Name = "btnDeleteFromList";
            this.btnDeleteFromList.Size = new System.Drawing.Size(233, 86);
            this.btnDeleteFromList.TabIndex = 13;
            this.btnDeleteFromList.Text = "Slet fra liste";
            this.btnDeleteFromList.UseVisualStyleBackColor = true;
            this.btnDeleteFromList.Click += new System.EventHandler(this.btnDeleteFromList_Click);
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPosition.Location = new System.Drawing.Point(620, 482);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(228, 86);
            this.btnGetPosition.TabIndex = 14;
            this.btnGetPosition.Text = "Få position";
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.btnGetPosition_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.Location = new System.Drawing.Point(886, 482);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(264, 86);
            this.btnShowList.TabIndex = 15;
            this.btnShowList.Text = "Vis venteliste";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnVisVentelisteFor
            // 
            this.btnVisVentelisteFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisVentelisteFor.Location = new System.Drawing.Point(314, 144);
            this.btnVisVentelisteFor.Name = "btnVisVentelisteFor";
            this.btnVisVentelisteFor.Size = new System.Drawing.Size(302, 104);
            this.btnVisVentelisteFor.TabIndex = 11;
            this.btnVisVentelisteFor.Text = "Vis Venteliste";
            this.btnVisVentelisteFor.UseVisualStyleBackColor = true;
            this.btnVisVentelisteFor.Click += new System.EventHandler(this.btnVisVentelisteFor_Click);
            // 
            // VenteListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 1221);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnGetPosition);
            this.Controls.Add(this.btnDeleteFromList);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelInputs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label labelpId;
        private System.Windows.Forms.Label labelbId;
        private System.Windows.Forms.Button DeleteFromListButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button GetPosition;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnDeleteFromList;
        private System.Windows.Forms.Button btnGetPosition;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnVisVentelisteFor;
    }
}