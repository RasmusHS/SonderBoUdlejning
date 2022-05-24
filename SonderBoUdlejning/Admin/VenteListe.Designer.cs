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
            this.DGVLejemaal = new System.Windows.Forms.DataGridView();
            this.InsertToList = new System.Windows.Forms.Button();
            this.pIdTextbox = new System.Windows.Forms.TextBox();
            this.LidTextbox = new System.Windows.Forms.TextBox();
            this.labelpId = new System.Windows.Forms.Label();
            this.labelLid = new System.Windows.Forms.Label();
            this.DeleteFromListButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GetPosition = new System.Windows.Forms.Button();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.btnVisVentelisteFor = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnDeleteFromList = new System.Windows.Forms.Button();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVenteListe)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersoner)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLejemaal)).BeginInit();
            this.panelInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(28, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 192);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVVenteListe);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(544, 153);
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
            this.DGVVenteListe.Location = new System.Drawing.Point(1, 1);
            this.DGVVenteListe.Name = "DGVVenteListe";
            this.DGVVenteListe.ReadOnly = true;
            this.DGVVenteListe.Size = new System.Drawing.Size(542, 151);
            this.DGVVenteListe.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVPersoner);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(544, 153);
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
            this.DGVPersoner.Location = new System.Drawing.Point(1, 1);
            this.DGVPersoner.Name = "DGVPersoner";
            this.DGVPersoner.ReadOnly = true;
            this.DGVPersoner.Size = new System.Drawing.Size(542, 151);
            this.DGVPersoner.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVLejemaal);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage3.Size = new System.Drawing.Size(544, 153);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lejemål";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVLejemaal
            // 
            this.DGVLejemaal.AllowUserToAddRows = false;
            this.DGVLejemaal.AllowUserToDeleteRows = false;
            this.DGVLejemaal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVLejemaal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLejemaal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVLejemaal.Location = new System.Drawing.Point(1, 1);
            this.DGVLejemaal.Name = "DGVLejemaal";
            this.DGVLejemaal.ReadOnly = true;
            this.DGVLejemaal.Size = new System.Drawing.Size(542, 151);
            this.DGVLejemaal.TabIndex = 0;
            // 
            // InsertToList
            // 
            this.InsertToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertToList.Location = new System.Drawing.Point(10, 141);
            this.InsertToList.Margin = new System.Windows.Forms.Padding(1);
            this.InsertToList.Name = "InsertToList";
            this.InsertToList.Size = new System.Drawing.Size(118, 54);
            this.InsertToList.TabIndex = 2;
            this.InsertToList.Text = "Tilføj til liste";
            this.toolTip.SetToolTip(this.InsertToList, "Indtast tal i både pId og Lid for at tilføje en person\r\n til en specifik boligs v" +
        "enteliste");
            this.InsertToList.UseVisualStyleBackColor = true;
            this.InsertToList.Click += new System.EventHandler(this.InsertToList_Click);
            // 
            // pIdTextbox
            // 
            this.pIdTextbox.Location = new System.Drawing.Point(10, 39);
            this.pIdTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.pIdTextbox.Name = "pIdTextbox";
            this.pIdTextbox.Size = new System.Drawing.Size(45, 20);
            this.pIdTextbox.TabIndex = 3;
            // 
            // LidTextbox
            // 
            this.LidTextbox.Location = new System.Drawing.Point(10, 94);
            this.LidTextbox.Margin = new System.Windows.Forms.Padding(1);
            this.LidTextbox.Name = "LidTextbox";
            this.LidTextbox.Size = new System.Drawing.Size(45, 20);
            this.LidTextbox.TabIndex = 4;
            // 
            // labelpId
            // 
            this.labelpId.AutoSize = true;
            this.labelpId.Location = new System.Drawing.Point(8, 25);
            this.labelpId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelpId.Name = "labelpId";
            this.labelpId.Size = new System.Drawing.Size(22, 13);
            this.labelpId.TabIndex = 5;
            this.labelpId.Text = "pId";
            // 
            // labelLid
            // 
            this.labelLid.AutoSize = true;
            this.labelLid.Location = new System.Drawing.Point(8, 80);
            this.labelLid.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLid.Name = "labelLid";
            this.labelLid.Size = new System.Drawing.Size(21, 13);
            this.labelLid.TabIndex = 6;
            this.labelLid.Text = "Lid";
            // 
            // DeleteFromListButton
            // 
            this.DeleteFromListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFromListButton.Location = new System.Drawing.Point(157, 141);
            this.DeleteFromListButton.Name = "DeleteFromListButton";
            this.DeleteFromListButton.Size = new System.Drawing.Size(151, 54);
            this.DeleteFromListButton.TabIndex = 7;
            this.DeleteFromListButton.Text = "Slet fra liste";
            this.toolTip.SetToolTip(this.DeleteFromListButton, "Indtast kun pId for at slette den person fra alle ventelister.\r\nIndtast både pId " +
        "og Lid for at slette en person på en specifik lejemål.\r\nIndtast kun Lid for at s" +
        "lette alle på den boligs venteliste.");
            this.DeleteFromListButton.UseVisualStyleBackColor = true;
            this.DeleteFromListButton.Click += new System.EventHandler(this.DeleteFromListButton_Click);
            // 
            // GetPosition
            // 
            this.GetPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPosition.Location = new System.Drawing.Point(333, 141);
            this.GetPosition.Name = "GetPosition";
            this.GetPosition.Size = new System.Drawing.Size(122, 54);
            this.GetPosition.TabIndex = 8;
            this.GetPosition.Text = "Få position";
            this.toolTip.SetToolTip(this.GetPosition, "Få en persons positionen på en specifik lejemål");
            this.GetPosition.UseVisualStyleBackColor = true;
            this.GetPosition.Click += new System.EventHandler(this.GetPosition_Click);
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(333, 94);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(122, 20);
            this.positionTextBox.TabIndex = 9;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPosition.Location = new System.Drawing.Point(330, 78);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(77, 13);
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
            this.panelInputs.Controls.Add(this.labelLid);
            this.panelInputs.Controls.Add(this.positionTextBox);
            this.panelInputs.Controls.Add(this.GetPosition);
            this.panelInputs.Controls.Add(this.LidTextbox);
            this.panelInputs.Location = new System.Drawing.Point(33, 315);
            this.panelInputs.Margin = new System.Windows.Forms.Padding(2);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(547, 222);
            this.panelInputs.TabIndex = 11;
            // 
            // btnVisVentelisteFor
            // 
            this.btnVisVentelisteFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisVentelisteFor.Location = new System.Drawing.Point(157, 75);
            this.btnVisVentelisteFor.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisVentelisteFor.Name = "btnVisVentelisteFor";
            this.btnVisVentelisteFor.Size = new System.Drawing.Size(151, 54);
            this.btnVisVentelisteFor.TabIndex = 11;
            this.btnVisVentelisteFor.Text = "Vis Venteliste";
            this.btnVisVentelisteFor.UseVisualStyleBackColor = true;
            this.btnVisVentelisteFor.Click += new System.EventHandler(this.btnVisVentelisteFor_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToList.Location = new System.Drawing.Point(33, 251);
            this.btnAddToList.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(116, 45);
            this.btnAddToList.TabIndex = 12;
            this.btnAddToList.Text = "Tilføj til liste";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnDeleteFromList
            // 
            this.btnDeleteFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFromList.Location = new System.Drawing.Point(172, 251);
            this.btnDeleteFromList.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteFromList.Name = "btnDeleteFromList";
            this.btnDeleteFromList.Size = new System.Drawing.Size(116, 45);
            this.btnDeleteFromList.TabIndex = 13;
            this.btnDeleteFromList.Text = "Slet fra liste";
            this.btnDeleteFromList.UseVisualStyleBackColor = true;
            this.btnDeleteFromList.Click += new System.EventHandler(this.btnDeleteFromList_Click);
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPosition.Location = new System.Drawing.Point(310, 251);
            this.btnGetPosition.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(114, 45);
            this.btnGetPosition.TabIndex = 14;
            this.btnGetPosition.Text = "Få position";
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.btnGetPosition_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.Location = new System.Drawing.Point(443, 251);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(132, 45);
            this.btnShowList.TabIndex = 15;
            this.btnShowList.Text = "Vis venteliste";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // VenteListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 635);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnGetPosition);
            this.Controls.Add(this.btnDeleteFromList);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelInputs);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "VenteListe";
            this.Text = "VenteListe";
            this.Load += new System.EventHandler(this.VenteListe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVenteListe)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersoner)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLejemaal)).EndInit();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button InsertToList;
        private System.Windows.Forms.TextBox pIdTextbox;
        private System.Windows.Forms.TextBox LidTextbox;
        private System.Windows.Forms.Label labelpId;
        private System.Windows.Forms.Label labelLid;
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
        private System.Windows.Forms.DataGridView DGVVenteListe;
        private System.Windows.Forms.DataGridView DGVPersoner;
        private System.Windows.Forms.DataGridView DGVLejemaal;
    }
}