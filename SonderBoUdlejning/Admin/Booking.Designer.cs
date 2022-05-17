namespace SonderBoUdlejning.Admin
{
    partial class Booking
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
            this.DGVRessourcer = new System.Windows.Forms.DataGridView();
            this.DGVReservationer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBMembers = new System.Windows.Forms.ComboBox();
            this.TBPID = new System.Windows.Forms.TextBox();
            this.TBMail = new System.Windows.Forms.TextBox();
            this.TBTLF = new System.Windows.Forms.TextBox();
            this.PersonID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelPersonInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBResource = new System.Windows.Forms.ComboBox();
            this.TBSlutDato = new System.Windows.Forms.TextBox();
            this.TBStartDato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCheckDato = new System.Windows.Forms.Button();
            this.TBDato = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBResourceID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PanelResource = new System.Windows.Forms.Panel();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRessourcer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservationer)).BeginInit();
            this.PanelPersonInfo.SuspendLayout();
            this.PanelResource.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVRessourcer
            // 
            this.DGVRessourcer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRessourcer.Location = new System.Drawing.Point(93, 587);
            this.DGVRessourcer.Margin = new System.Windows.Forms.Padding(7);
            this.DGVRessourcer.Name = "DGVRessourcer";
            this.DGVRessourcer.RowHeadersWidth = 92;
            this.DGVRessourcer.Size = new System.Drawing.Size(854, 393);
            this.DGVRessourcer.TabIndex = 0;
            // 
            // DGVReservationer
            // 
            this.DGVReservationer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReservationer.Location = new System.Drawing.Point(93, 80);
            this.DGVReservationer.Margin = new System.Windows.Forms.Padding(7);
            this.DGVReservationer.Name = "DGVReservationer";
            this.DGVReservationer.RowHeadersWidth = 92;
            this.DGVReservationer.Size = new System.Drawing.Size(1738, 390);
            this.DGVReservationer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 535);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ledige ressourcer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reservationer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CBMembers
            // 
            this.CBMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMembers.FormattingEnabled = true;
            this.CBMembers.Location = new System.Drawing.Point(961, 622);
            this.CBMembers.Margin = new System.Windows.Forms.Padding(7);
            this.CBMembers.Name = "CBMembers";
            this.CBMembers.Size = new System.Drawing.Size(277, 37);
            this.CBMembers.TabIndex = 4;
            this.CBMembers.SelectedIndexChanged += new System.EventHandler(this.CBMembers_SelectedIndexChanged);
            // 
            // TBPID
            // 
            this.TBPID.Location = new System.Drawing.Point(19, 49);
            this.TBPID.Margin = new System.Windows.Forms.Padding(7);
            this.TBPID.Name = "TBPID";
            this.TBPID.ReadOnly = true;
            this.TBPID.Size = new System.Drawing.Size(121, 35);
            this.TBPID.TabIndex = 5;
            // 
            // TBMail
            // 
            this.TBMail.Location = new System.Drawing.Point(19, 145);
            this.TBMail.Margin = new System.Windows.Forms.Padding(7);
            this.TBMail.Name = "TBMail";
            this.TBMail.ReadOnly = true;
            this.TBMail.Size = new System.Drawing.Size(275, 35);
            this.TBMail.TabIndex = 6;
            // 
            // TBTLF
            // 
            this.TBTLF.Location = new System.Drawing.Point(19, 252);
            this.TBTLF.Margin = new System.Windows.Forms.Padding(7);
            this.TBTLF.Name = "TBTLF";
            this.TBTLF.ReadOnly = true;
            this.TBTLF.Size = new System.Drawing.Size(188, 35);
            this.TBTLF.TabIndex = 7;
            // 
            // PersonID
            // 
            this.PersonID.AutoSize = true;
            this.PersonID.Location = new System.Drawing.Point(12, 13);
            this.PersonID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.PersonID.Name = "PersonID";
            this.PersonID.Size = new System.Drawing.Size(125, 29);
            this.PersonID.TabIndex = 8;
            this.PersonID.Text = "Person ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefonnummer: ";
            // 
            // PanelPersonInfo
            // 
            this.PanelPersonInfo.Controls.Add(this.label5);
            this.PanelPersonInfo.Controls.Add(this.label4);
            this.PanelPersonInfo.Controls.Add(this.PersonID);
            this.PanelPersonInfo.Controls.Add(this.TBTLF);
            this.PanelPersonInfo.Controls.Add(this.TBMail);
            this.PanelPersonInfo.Controls.Add(this.TBPID);
            this.PanelPersonInfo.Location = new System.Drawing.Point(961, 683);
            this.PanelPersonInfo.Margin = new System.Windows.Forms.Padding(7);
            this.PanelPersonInfo.Name = "PanelPersonInfo";
            this.PanelPersonInfo.Size = new System.Drawing.Size(306, 335);
            this.PanelPersonInfo.TabIndex = 11;
            this.PanelPersonInfo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(961, 587);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vælg beboer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1363, 587);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vælg ressource";
            // 
            // CBResource
            // 
            this.CBResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBResource.FormattingEnabled = true;
            this.CBResource.Location = new System.Drawing.Point(1370, 622);
            this.CBResource.Margin = new System.Windows.Forms.Padding(7);
            this.CBResource.Name = "CBResource";
            this.CBResource.Size = new System.Drawing.Size(277, 37);
            this.CBResource.TabIndex = 14;
            this.CBResource.SelectedIndexChanged += new System.EventHandler(this.CBResource_SelectedIndexChanged);
            // 
            // TBSlutDato
            // 
            this.TBSlutDato.Location = new System.Drawing.Point(12, 141);
            this.TBSlutDato.Margin = new System.Windows.Forms.Padding(7);
            this.TBSlutDato.Name = "TBSlutDato";
            this.TBSlutDato.Size = new System.Drawing.Size(228, 35);
            this.TBSlutDato.TabIndex = 15;
            // 
            // TBStartDato
            // 
            this.TBStartDato.Location = new System.Drawing.Point(12, 45);
            this.TBStartDato.Margin = new System.Windows.Forms.Padding(7);
            this.TBStartDato.Name = "TBStartDato";
            this.TBStartDato.ReadOnly = true;
            this.TBStartDato.Size = new System.Drawing.Size(228, 35);
            this.TBStartDato.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Start dato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Slut dato";
            // 
            // BtnCheckDato
            // 
            this.BtnCheckDato.Location = new System.Drawing.Point(327, 1081);
            this.BtnCheckDato.Margin = new System.Windows.Forms.Padding(7);
            this.BtnCheckDato.Name = "BtnCheckDato";
            this.BtnCheckDato.Size = new System.Drawing.Size(175, 51);
            this.BtnCheckDato.TabIndex = 21;
            this.BtnCheckDato.Text = "Checki!";
            this.BtnCheckDato.UseVisualStyleBackColor = true;
            this.BtnCheckDato.Click += new System.EventHandler(this.BtnCheckDato_Click);
            // 
            // TBDato
            // 
            this.TBDato.Location = new System.Drawing.Point(91, 1097);
            this.TBDato.Margin = new System.Windows.Forms.Padding(7);
            this.TBDato.Name = "TBDato";
            this.TBDato.Size = new System.Drawing.Size(228, 35);
            this.TBDato.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 1031);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(416, 29);
            this.label10.TabIndex = 23;
            this.label10.Text = "Indtast dato hvor kunde ønsker at leje:";
            // 
            // TBResourceID
            // 
            this.TBResourceID.Location = new System.Drawing.Point(12, 250);
            this.TBResourceID.Margin = new System.Windows.Forms.Padding(7);
            this.TBResourceID.Name = "TBResourceID";
            this.TBResourceID.ReadOnly = true;
            this.TBResourceID.Size = new System.Drawing.Size(228, 35);
            this.TBResourceID.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Resource ID";
            // 
            // PanelResource
            // 
            this.PanelResource.Controls.Add(this.label9);
            this.PanelResource.Controls.Add(this.TBResourceID);
            this.PanelResource.Controls.Add(this.label8);
            this.PanelResource.Controls.Add(this.label7);
            this.PanelResource.Controls.Add(this.TBStartDato);
            this.PanelResource.Controls.Add(this.TBSlutDato);
            this.PanelResource.Location = new System.Drawing.Point(1358, 685);
            this.PanelResource.Margin = new System.Windows.Forms.Padding(7);
            this.PanelResource.Name = "PanelResource";
            this.PanelResource.Size = new System.Drawing.Size(292, 330);
            this.PanelResource.TabIndex = 26;
            this.PanelResource.Visible = false;
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(945, 1031);
            this.btnConfirmBooking.Margin = new System.Windows.Forms.Padding(7);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(705, 80);
            this.btnConfirmBooking.TabIndex = 27;
            this.btnConfirmBooking.Text = "Bekræft Reservation";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Visible = false;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2756, 1461);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.PanelResource);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBDato);
            this.Controls.Add(this.BtnCheckDato);
            this.Controls.Add(this.CBResource);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelPersonInfo);
            this.Controls.Add(this.CBMembers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVReservationer);
            this.Controls.Add(this.DGVRessourcer);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRessourcer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservationer)).EndInit();
            this.PanelPersonInfo.ResumeLayout(false);
            this.PanelPersonInfo.PerformLayout();
            this.PanelResource.ResumeLayout(false);
            this.PanelResource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRessourcer;
        private System.Windows.Forms.DataGridView DGVReservationer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPID;
        private System.Windows.Forms.TextBox TBMail;
        private System.Windows.Forms.TextBox TBTLF;
        private System.Windows.Forms.Label PersonID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelPersonInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBResource;
        private System.Windows.Forms.TextBox TBSlutDato;
        private System.Windows.Forms.TextBox TBStartDato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCheckDato;
        private System.Windows.Forms.TextBox TBDato;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox CBMembers;
        private System.Windows.Forms.TextBox TBResourceID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PanelResource;
        private System.Windows.Forms.Button btnConfirmBooking;
    }
}