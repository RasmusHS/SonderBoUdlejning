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
            this.dgvVenteListe = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPersoner = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvLejemaal = new System.Windows.Forms.DataGridView();
            this.btnInsertToList = new System.Windows.Forms.Button();
            this.tbPId = new System.Windows.Forms.TextBox();
            this.tbLid = new System.Windows.Forms.TextBox();
            this.lblPId = new System.Windows.Forms.Label();
            this.lblLid = new System.Windows.Forms.Label();
            this.btnDeleteFromListButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnVisGetPosition = new System.Windows.Forms.Button();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnVisAddToList = new System.Windows.Forms.Button();
            this.btnVisDeleteFromList = new System.Windows.Forms.Button();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.btnVisShowList = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenteListe)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoner)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLejemaal)).BeginInit();
            this.panelInputs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(28, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 300);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvVenteListe);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(1010, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venteliste";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVVenteListe
            // 
            this.dgvVenteListe.AllowUserToAddRows = false;
            this.dgvVenteListe.AllowUserToDeleteRows = false;
            this.dgvVenteListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenteListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenteListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVenteListe.Location = new System.Drawing.Point(1, 1);
            this.dgvVenteListe.Name = "DGVVenteListe";
            this.dgvVenteListe.ReadOnly = true;
            this.dgvVenteListe.RowHeadersWidth = 92;
            this.dgvVenteListe.Size = new System.Drawing.Size(1008, 259);
            this.dgvVenteListe.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPersoner);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(1010, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVPersoner
            // 
            this.dgvPersoner.AllowUserToAddRows = false;
            this.dgvPersoner.AllowUserToDeleteRows = false;
            this.dgvPersoner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersoner.Location = new System.Drawing.Point(1, 1);
            this.dgvPersoner.Name = "DGVPersoner";
            this.dgvPersoner.ReadOnly = true;
            this.dgvPersoner.RowHeadersWidth = 92;
            this.dgvPersoner.Size = new System.Drawing.Size(1008, 259);
            this.dgvPersoner.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvLejemaal);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage3.Size = new System.Drawing.Size(1010, 261);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lejemål";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVLejemaal
            // 
            this.dgvLejemaal.AllowUserToAddRows = false;
            this.dgvLejemaal.AllowUserToDeleteRows = false;
            this.dgvLejemaal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLejemaal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLejemaal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLejemaal.Location = new System.Drawing.Point(1, 1);
            this.dgvLejemaal.Name = "DGVLejemaal";
            this.dgvLejemaal.ReadOnly = true;
            this.dgvLejemaal.RowHeadersWidth = 92;
            this.dgvLejemaal.Size = new System.Drawing.Size(1008, 259);
            this.dgvLejemaal.TabIndex = 0;
            // 
            // InsertToList
            // 
            this.btnInsertToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertToList.Location = new System.Drawing.Point(0, 79);
            this.btnInsertToList.Margin = new System.Windows.Forms.Padding(1);
            this.btnInsertToList.Name = "InsertToList";
            this.btnInsertToList.Size = new System.Drawing.Size(152, 54);
            this.btnInsertToList.TabIndex = 2;
            this.btnInsertToList.Text = "Tilføj til liste";
            this.toolTip.SetToolTip(this.btnInsertToList, "Indtast tal i både pId og Lid for at tilføje en person\r\n til en specifik boligs v" +
        "enteliste");
            this.btnInsertToList.UseVisualStyleBackColor = true;
            this.btnInsertToList.Click += new System.EventHandler(this.InsertToList_Click);
            // 
            // pIdTextbox
            // 
            this.tbPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPId.Location = new System.Drawing.Point(10, 32);
            this.tbPId.Margin = new System.Windows.Forms.Padding(1);
            this.tbPId.Name = "pIdTextbox";
            this.tbPId.Size = new System.Drawing.Size(129, 26);
            this.tbPId.TabIndex = 3;
            // 
            // LidTextbox
            // 
            this.tbLid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLid.Location = new System.Drawing.Point(10, 94);
            this.tbLid.Margin = new System.Windows.Forms.Padding(0);
            this.tbLid.Name = "LidTextbox";
            this.tbLid.Size = new System.Drawing.Size(129, 26);
            this.tbLid.TabIndex = 4;
            // 
            // labelpId
            // 
            this.lblPId.AutoSize = true;
            this.lblPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPId.Location = new System.Drawing.Point(6, 11);
            this.lblPId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPId.Name = "labelpId";
            this.lblPId.Size = new System.Drawing.Size(133, 20);
            this.lblPId.TabIndex = 5;
            this.lblPId.Text = "Indtast person ID";
            // 
            // labelLid
            // 
            this.lblLid.AutoSize = true;
            this.lblLid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLid.Location = new System.Drawing.Point(6, 74);
            this.lblLid.Margin = new System.Windows.Forms.Padding(0);
            this.lblLid.Name = "labelLid";
            this.lblLid.Size = new System.Drawing.Size(134, 20);
            this.lblLid.TabIndex = 6;
            this.lblLid.Text = "Indtast lejemål nr.";
            // 
            // DeleteFromListButton
            // 
            this.btnDeleteFromListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFromListButton.Location = new System.Drawing.Point(0, 147);
            this.btnDeleteFromListButton.Name = "DeleteFromListButton";
            this.btnDeleteFromListButton.Size = new System.Drawing.Size(152, 54);
            this.btnDeleteFromListButton.TabIndex = 7;
            this.btnDeleteFromListButton.Text = "Slet fra liste";
            this.toolTip.SetToolTip(this.btnDeleteFromListButton, "Indtast kun pId for at slette den person fra alle ventelister.\r\nIndtast både pId " +
        "og Lid for at slette en person på en specifik lejemål.\r\nIndtast kun Lid for at s" +
        "lette alle på den boligs venteliste.");
            this.btnDeleteFromListButton.UseVisualStyleBackColor = true;
            this.btnDeleteFromListButton.Click += new System.EventHandler(this.DeleteFromListButton_Click);
            // 
            // GetPosition
            // 
            this.btnVisGetPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisGetPosition.Location = new System.Drawing.Point(0, 287);
            this.btnVisGetPosition.Name = "GetPosition";
            this.btnVisGetPosition.Size = new System.Drawing.Size(152, 54);
            this.btnVisGetPosition.TabIndex = 8;
            this.btnVisGetPosition.Text = "Få position";
            this.toolTip.SetToolTip(this.btnGetPosition, "Få en persons positionen på en specifik lejemål");
            this.btnVisGetPosition.UseVisualStyleBackColor = true;
            this.btnVisGetPosition.Click += new System.EventHandler(this.GetPosition_Click);
            // 
            // positionTextBox
            // 
            this.tbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(0, 255);
            this.tbPosition.Name = "positionTextBox";
            this.tbPosition.Size = new System.Drawing.Size(152, 26);
            this.tbPosition.TabIndex = 9;
            // 
            // labelPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(-4, 232);
            this.lblPosition.Name = "labelPosition";
            this.lblPosition.Size = new System.Drawing.Size(114, 20);
            this.lblPosition.TabIndex = 10;
            this.lblPosition.Text = "Din position er:";
            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelInputs.Controls.Add(this.panel1);
            this.panelInputs.Controls.Add(this.tbPId);
            this.panelInputs.Controls.Add(this.lblPId);
            this.panelInputs.Controls.Add(this.lblLid);
            this.panelInputs.Controls.Add(this.tbLid);
            this.panelInputs.Location = new System.Drawing.Point(220, 338);
            this.panelInputs.Margin = new System.Windows.Forms.Padding(1);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(331, 355);
            this.panelInputs.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowList);
            this.panel1.Controls.Add(this.btnInsertToList);
            this.panel1.Controls.Add(this.btnDeleteFromListButton);
            this.panel1.Controls.Add(this.lblPosition);
            this.panel1.Controls.Add(this.btnGetPosition);
            this.panel1.Controls.Add(this.tbPosition);
            this.panel1.Location = new System.Drawing.Point(163, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 341);
            this.panel1.TabIndex = 12;
            // 
            // btnVisVentelisteFor
            // 
            this.btnShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.Location = new System.Drawing.Point(0, 0);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowList.Name = "btnVisVentelisteFor";
            this.btnShowList.Size = new System.Drawing.Size(152, 54);
            this.btnShowList.TabIndex = 11;
            this.btnShowList.Text = "Vis Venteliste";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnVisVentelisteFor_Click);
            // 
            // btnAddToList
            // 
            this.btnVisAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisAddToList.Location = new System.Drawing.Point(33, 387);
            this.btnVisAddToList.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisAddToList.Name = "btnAddToList";
            this.btnVisAddToList.Size = new System.Drawing.Size(132, 45);
            this.btnVisAddToList.TabIndex = 12;
            this.btnVisAddToList.Text = "Tilføj til liste";
            this.btnVisAddToList.UseVisualStyleBackColor = true;
            this.btnVisAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnDeleteFromList
            // 
            this.btnVisDeleteFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisDeleteFromList.Location = new System.Drawing.Point(33, 436);
            this.btnVisDeleteFromList.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisDeleteFromList.Name = "btnDeleteFromList";
            this.btnVisDeleteFromList.Size = new System.Drawing.Size(132, 45);
            this.btnVisDeleteFromList.TabIndex = 13;
            this.btnVisDeleteFromList.Text = "Slet fra liste";
            this.btnVisDeleteFromList.UseVisualStyleBackColor = true;
            this.btnVisDeleteFromList.Click += new System.EventHandler(this.btnDeleteFromList_Click);
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPosition.Location = new System.Drawing.Point(33, 485);
            this.btnGetPosition.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(132, 45);
            this.btnGetPosition.TabIndex = 14;
            this.btnGetPosition.Text = "Få position";
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.btnGetPos_Click);
            // 
            // btnShowList
            // 
            this.btnVisShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisShowList.Location = new System.Drawing.Point(33, 338);
            this.btnVisShowList.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisShowList.Name = "btnShowList";
            this.btnVisShowList.Size = new System.Drawing.Size(132, 45);
            this.btnVisShowList.TabIndex = 15;
            this.btnVisShowList.Text = "Vis venteliste";
            this.btnVisShowList.UseVisualStyleBackColor = true;
            this.btnVisShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // VenteListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 703);
            this.Controls.Add(this.btnVisShowList);
            this.Controls.Add(this.btnGetPosition);
            this.Controls.Add(this.btnVisDeleteFromList);
            this.Controls.Add(this.btnVisAddToList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelInputs);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "VenteListe";
            this.Text = "VenteListe";
            this.Load += new System.EventHandler(this.VenteListe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenteListe)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoner)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLejemaal)).EndInit();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnInsertToList;
        private System.Windows.Forms.TextBox tbPId;
        private System.Windows.Forms.TextBox tbLid;
        private System.Windows.Forms.Label lblPId;
        private System.Windows.Forms.Label lblLid;
        private System.Windows.Forms.Button btnDeleteFromListButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnGetPosition;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Button btnVisAddToList;
        private System.Windows.Forms.Button btnVisDeleteFromList;
        private System.Windows.Forms.Button btnVisGetPosition;
        private System.Windows.Forms.Button btnVisShowList;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.DataGridView dgvVenteListe;
        private System.Windows.Forms.DataGridView dgvPersoner;
        private System.Windows.Forms.DataGridView dgvLejemaal;
        private System.Windows.Forms.Panel panel1;
    }
}