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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
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
            this.TBStartDato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCheckDato = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TBResourceID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PanelResource = new System.Windows.Forms.Panel();
            this.dtpSlut = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.panelReservationer = new System.Windows.Forms.Panel();
            this.dtpStatistik = new System.Windows.Forms.DateTimePicker();
            this.btnGetDateReservationer = new System.Windows.Forms.Button();
            this.btnGetReservations = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVReservationer = new System.Windows.Forms.DataGridView();
            this.btnSePersonRes = new System.Windows.Forms.Button();
            this.cbMembersRes = new System.Windows.Forms.ComboBox();
            this.btnAntalRes = new System.Windows.Forms.Button();
            this.panelResourcer = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbresResNr = new System.Windows.Forms.TextBox();
            this.cbDeleteBeboerResource = new System.Windows.Forms.ComboBox();
            this.cbDeleteResFromBeboer = new System.Windows.Forms.ComboBox();
            this.btnDeleteRes = new System.Windows.Forms.Button();
            this.DGVRessourcer = new System.Windows.Forms.DataGridView();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageReservationer = new System.Windows.Forms.TabPage();
            this.tabPageRessourcer = new System.Windows.Forms.TabPage();
            this.toolTipBooking = new System.Windows.Forms.ToolTip(this.components);
            this.PanelPersonInfo.SuspendLayout();
            this.PanelResource.SuspendLayout();
            this.panelReservationer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservationer)).BeginInit();
            this.panelResourcer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRessourcer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageReservationer.SuspendLayout();
            this.tabPageRessourcer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ledige ressourcer";
            // 
            // CBMembers
            // 
            this.CBMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMembers.FormattingEnabled = true;
            this.CBMembers.Location = new System.Drawing.Point(870, 62);
            this.CBMembers.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.CBMembers.Name = "CBMembers";
            this.CBMembers.Size = new System.Drawing.Size(342, 48);
            this.CBMembers.TabIndex = 4;
            this.CBMembers.SelectedIndexChanged += new System.EventHandler(this.CBMembers_SelectedIndexChanged);
            // 
            // TBPID
            // 
            this.TBPID.Location = new System.Drawing.Point(9, 83);
            this.TBPID.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.TBPID.Name = "TBPID";
            this.TBPID.ReadOnly = true;
            this.TBPID.Size = new System.Drawing.Size(121, 48);
            this.TBPID.TabIndex = 5;
            // 
            // TBMail
            // 
            this.TBMail.Location = new System.Drawing.Point(7, 232);
            this.TBMail.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.TBMail.Name = "TBMail";
            this.TBMail.ReadOnly = true;
            this.TBMail.Size = new System.Drawing.Size(275, 48);
            this.TBMail.TabIndex = 6;
            // 
            // TBTLF
            // 
            this.TBTLF.Location = new System.Drawing.Point(9, 408);
            this.TBTLF.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.TBTLF.Name = "TBTLF";
            this.TBTLF.ReadOnly = true;
            this.TBTLF.Size = new System.Drawing.Size(188, 48);
            this.TBTLF.TabIndex = 7;
            // 
            // PersonID
            // 
            this.PersonID.AutoSize = true;
            this.PersonID.Location = new System.Drawing.Point(0, 31);
            this.PersonID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.PersonID.Name = "PersonID";
            this.PersonID.Size = new System.Drawing.Size(186, 40);
            this.PersonID.TabIndex = 8;
            this.PersonID.Text = "Person ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 40);
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
            this.PanelPersonInfo.Location = new System.Drawing.Point(870, 123);
            this.PanelPersonInfo.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.PanelPersonInfo.Name = "PanelPersonInfo";
            this.PanelPersonInfo.Size = new System.Drawing.Size(306, 473);
            this.PanelPersonInfo.TabIndex = 11;
            this.PanelPersonInfo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vælg beboer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1267, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 40);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vælg ressource";
            // 
            // CBResource
            // 
            this.CBResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBResource.FormattingEnabled = true;
            this.CBResource.Location = new System.Drawing.Point(1267, 62);
            this.CBResource.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.CBResource.Name = "CBResource";
            this.CBResource.Size = new System.Drawing.Size(354, 48);
            this.CBResource.TabIndex = 14;
            this.CBResource.SelectedIndexChanged += new System.EventHandler(this.CBResource_SelectedIndexChanged);
            // 
            // TBStartDato
            // 
            this.TBStartDato.Location = new System.Drawing.Point(7, 80);
            this.TBStartDato.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.TBStartDato.Name = "TBStartDato";
            this.TBStartDato.ReadOnly = true;
            this.TBStartDato.Size = new System.Drawing.Size(270, 48);
            this.TBStartDato.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 40);
            this.label7.TabIndex = 17;
            this.label7.Text = "Start dato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 40);
            this.label8.TabIndex = 18;
            this.label8.Text = "Slut dato";
            // 
            // BtnCheckDato
            // 
            this.BtnCheckDato.Location = new System.Drawing.Point(315, 567);
            this.BtnCheckDato.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.BtnCheckDato.Name = "BtnCheckDato";
            this.BtnCheckDato.Size = new System.Drawing.Size(175, 65);
            this.BtnCheckDato.TabIndex = 21;
            this.BtnCheckDato.Text = "Check";
            this.BtnCheckDato.UseVisualStyleBackColor = true;
            this.BtnCheckDato.Click += new System.EventHandler(this.BtnCheckDato_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 506);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(626, 40);
            this.label10.TabIndex = 23;
            this.label10.Text = "Indtast dato hvor kunde ønsker at leje:";
            // 
            // TBResourceID
            // 
            this.TBResourceID.Location = new System.Drawing.Point(7, 406);
            this.TBResourceID.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.TBResourceID.Name = "TBResourceID";
            this.TBResourceID.ReadOnly = true;
            this.TBResourceID.Size = new System.Drawing.Size(228, 48);
            this.TBResourceID.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-2, 355);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 40);
            this.label9.TabIndex = 25;
            this.label9.Text = "Resource ID";
            // 
            // PanelResource
            // 
            this.PanelResource.Controls.Add(this.dtpSlut);
            this.PanelResource.Controls.Add(this.label9);
            this.PanelResource.Controls.Add(this.TBResourceID);
            this.PanelResource.Controls.Add(this.label8);
            this.PanelResource.Controls.Add(this.label7);
            this.PanelResource.Controls.Add(this.TBStartDato);
            this.PanelResource.Location = new System.Drawing.Point(1267, 125);
            this.PanelResource.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.PanelResource.Name = "PanelResource";
            this.PanelResource.Size = new System.Drawing.Size(294, 471);
            this.PanelResource.TabIndex = 26;
            this.PanelResource.Visible = false;
            // 
            // dtpSlut
            // 
            this.dtpSlut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSlut.Location = new System.Drawing.Point(7, 225);
            this.dtpSlut.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtpSlut.Name = "dtpSlut";
            this.dtpSlut.Size = new System.Drawing.Size(237, 48);
            this.dtpSlut.TabIndex = 26;
            this.toolTipBooking.SetToolTip(this.dtpSlut, "Vælg ønsket slut dato for booking");
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(870, 620);
            this.btnConfirmBooking.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(691, 80);
            this.btnConfirmBooking.TabIndex = 27;
            this.btnConfirmBooking.Text = "Bekræft Reservation";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Visible = false;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // panelReservationer
            // 
            this.panelReservationer.Controls.Add(this.dtpStatistik);
            this.panelReservationer.Controls.Add(this.btnGetDateReservationer);
            this.panelReservationer.Controls.Add(this.btnGetReservations);
            this.panelReservationer.Controls.Add(this.label2);
            this.panelReservationer.Controls.Add(this.DGVReservationer);
            this.panelReservationer.Controls.Add(this.btnSePersonRes);
            this.panelReservationer.Controls.Add(this.cbMembersRes);
            this.panelReservationer.Controls.Add(this.btnAntalRes);
            this.panelReservationer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReservationer.Location = new System.Drawing.Point(7, 7);
            this.panelReservationer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panelReservationer.Name = "panelReservationer";
            this.panelReservationer.Size = new System.Drawing.Size(2446, 927);
            this.panelReservationer.TabIndex = 28;
            // 
            // dtpStatistik
            // 
            this.dtpStatistik.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStatistik.Location = new System.Drawing.Point(681, 676);
            this.dtpStatistik.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtpStatistik.Name = "dtpStatistik";
            this.dtpStatistik.Size = new System.Drawing.Size(359, 48);
            this.dtpStatistik.TabIndex = 11;
            // 
            // btnGetDateReservationer
            // 
            this.btnGetDateReservationer.Location = new System.Drawing.Point(681, 747);
            this.btnGetDateReservationer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnGetDateReservationer.Name = "btnGetDateReservationer";
            this.btnGetDateReservationer.Size = new System.Drawing.Size(364, 116);
            this.btnGetDateReservationer.TabIndex = 10;
            this.btnGetDateReservationer.Text = "Udtræk statistik på dato";
            this.btnGetDateReservationer.UseVisualStyleBackColor = true;
            this.btnGetDateReservationer.Click += new System.EventHandler(this.btnGetDateReservationer_Click);
            // 
            // btnGetReservations
            // 
            this.btnGetReservations.Location = new System.Drawing.Point(42, 747);
            this.btnGetReservations.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnGetReservations.Name = "btnGetReservations";
            this.btnGetReservations.Size = new System.Drawing.Size(294, 116);
            this.btnGetReservations.TabIndex = 9;
            this.btnGetReservations.Text = "Udtræk alle reservationer";
            this.btnGetReservations.UseVisualStyleBackColor = true;
            this.btnGetReservations.Click += new System.EventHandler(this.btnGetReservations_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reservationer";
            // 
            // DGVReservationer
            // 
            this.DGVReservationer.AllowUserToAddRows = false;
            this.DGVReservationer.AllowUserToDeleteRows = false;
            this.DGVReservationer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVReservationer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReservationer.Location = new System.Drawing.Point(44, 58);
            this.DGVReservationer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.DGVReservationer.Name = "DGVReservationer";
            this.DGVReservationer.ReadOnly = true;
            this.DGVReservationer.RowHeadersWidth = 92;
            this.DGVReservationer.Size = new System.Drawing.Size(1545, 415);
            this.DGVReservationer.TabIndex = 7;
            // 
            // btnSePersonRes
            // 
            this.btnSePersonRes.Location = new System.Drawing.Point(1244, 587);
            this.btnSePersonRes.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSePersonRes.Name = "btnSePersonRes";
            this.btnSePersonRes.Size = new System.Drawing.Size(345, 105);
            this.btnSePersonRes.TabIndex = 6;
            this.btnSePersonRes.Text = "Se personens res";
            this.btnSePersonRes.UseVisualStyleBackColor = true;
            this.btnSePersonRes.Click += new System.EventHandler(this.btnSePersonRes_Click);
            // 
            // cbMembersRes
            // 
            this.cbMembersRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembersRes.FormattingEnabled = true;
            this.cbMembersRes.Location = new System.Drawing.Point(1244, 506);
            this.cbMembersRes.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cbMembersRes.Name = "cbMembersRes";
            this.cbMembersRes.Size = new System.Drawing.Size(340, 48);
            this.cbMembersRes.TabIndex = 5;
            this.cbMembersRes.SelectedIndexChanged += new System.EventHandler(this.cbMembersRes_SelectedIndexChanged);
            // 
            // btnAntalRes
            // 
            this.btnAntalRes.Location = new System.Drawing.Point(54, 506);
            this.btnAntalRes.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnAntalRes.Name = "btnAntalRes";
            this.btnAntalRes.Size = new System.Drawing.Size(448, 132);
            this.btnAntalRes.TabIndex = 4;
            this.btnAntalRes.Text = "Antal Reservationer";
            this.btnAntalRes.UseVisualStyleBackColor = true;
            this.btnAntalRes.Click += new System.EventHandler(this.btnAntalRes_Click);
            // 
            // panelResourcer
            // 
            this.panelResourcer.Controls.Add(this.label13);
            this.panelResourcer.Controls.Add(this.label12);
            this.panelResourcer.Controls.Add(this.label11);
            this.panelResourcer.Controls.Add(this.tbresResNr);
            this.panelResourcer.Controls.Add(this.cbDeleteBeboerResource);
            this.panelResourcer.Controls.Add(this.cbDeleteResFromBeboer);
            this.panelResourcer.Controls.Add(this.btnDeleteRes);
            this.panelResourcer.Controls.Add(this.DGVRessourcer);
            this.panelResourcer.Controls.Add(this.dtpStart);
            this.panelResourcer.Controls.Add(this.btnConfirmBooking);
            this.panelResourcer.Controls.Add(this.PanelResource);
            this.panelResourcer.Controls.Add(this.label10);
            this.panelResourcer.Controls.Add(this.BtnCheckDato);
            this.panelResourcer.Controls.Add(this.CBResource);
            this.panelResourcer.Controls.Add(this.label6);
            this.panelResourcer.Controls.Add(this.label3);
            this.panelResourcer.Controls.Add(this.PanelPersonInfo);
            this.panelResourcer.Controls.Add(this.CBMembers);
            this.panelResourcer.Controls.Add(this.label1);
            this.panelResourcer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResourcer.Location = new System.Drawing.Point(7, 7);
            this.panelResourcer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panelResourcer.Name = "panelResourcer";
            this.panelResourcer.Size = new System.Drawing.Size(2446, 927);
            this.panelResourcer.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1995, 638);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(429, 40);
            this.label13.TabIndex = 36;
            this.label13.Text = "Vælg beboers reservation";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2018, 480);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 40);
            this.label12.TabIndex = 35;
            this.label12.Text = "Vælg Beboer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1344, 841);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(379, 40);
            this.label11.TabIndex = 34;
            this.label11.Text = "Reservations nummer:";
            // 
            // tbresResNr
            // 
            this.tbresResNr.Location = new System.Drawing.Point(1750, 834);
            this.tbresResNr.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbresResNr.Name = "tbresResNr";
            this.tbresResNr.ReadOnly = true;
            this.tbresResNr.Size = new System.Drawing.Size(228, 48);
            this.tbresResNr.TabIndex = 33;
            // 
            // cbDeleteBeboerResource
            // 
            this.cbDeleteBeboerResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeleteBeboerResource.FormattingEnabled = true;
            this.cbDeleteBeboerResource.Location = new System.Drawing.Point(2028, 689);
            this.cbDeleteBeboerResource.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cbDeleteBeboerResource.Name = "cbDeleteBeboerResource";
            this.cbDeleteBeboerResource.Size = new System.Drawing.Size(408, 48);
            this.cbDeleteBeboerResource.TabIndex = 32;
            this.cbDeleteBeboerResource.Visible = false;
            this.cbDeleteBeboerResource.SelectedIndexChanged += new System.EventHandler(this.cbDeleteBeboerResource_SelectedIndexChanged);
            // 
            // cbDeleteResFromBeboer
            // 
            this.cbDeleteResFromBeboer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeleteResFromBeboer.FormattingEnabled = true;
            this.cbDeleteResFromBeboer.Location = new System.Drawing.Point(2028, 533);
            this.cbDeleteResFromBeboer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.cbDeleteResFromBeboer.Name = "cbDeleteResFromBeboer";
            this.cbDeleteResFromBeboer.Size = new System.Drawing.Size(408, 48);
            this.cbDeleteResFromBeboer.TabIndex = 31;
            this.cbDeleteResFromBeboer.SelectedIndexChanged += new System.EventHandler(this.cbDeleteResFromBeboer_SelectedIndexChanged);
            // 
            // btnDeleteRes
            // 
            this.btnDeleteRes.Location = new System.Drawing.Point(2028, 825);
            this.btnDeleteRes.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnDeleteRes.Name = "btnDeleteRes";
            this.btnDeleteRes.Size = new System.Drawing.Size(413, 78);
            this.btnDeleteRes.TabIndex = 30;
            this.btnDeleteRes.Text = "Slet reservation";
            this.btnDeleteRes.UseVisualStyleBackColor = true;
            this.btnDeleteRes.Click += new System.EventHandler(this.btnDeleteRes_Click);
            // 
            // DGVRessourcer
            // 
            this.DGVRessourcer.AllowUserToAddRows = false;
            this.DGVRessourcer.AllowUserToDeleteRows = false;
            this.DGVRessourcer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVRessourcer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRessourcer.Location = new System.Drawing.Point(37, 62);
            this.DGVRessourcer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.DGVRessourcer.Name = "DGVRessourcer";
            this.DGVRessourcer.ReadOnly = true;
            this.DGVRessourcer.RowHeadersWidth = 92;
            this.DGVRessourcer.Size = new System.Drawing.Size(775, 408);
            this.DGVRessourcer.TabIndex = 29;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(35, 573);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(237, 48);
            this.dtpStart.TabIndex = 28;
            this.toolTipBooking.SetToolTip(this.dtpStart, "Vælg ønsket start dato for booking");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageReservationer);
            this.tabControl1.Controls.Add(this.tabPageRessourcer);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(28, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2480, 1011);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPageReservationer
            // 
            this.tabPageReservationer.Controls.Add(this.panelReservationer);
            this.tabPageReservationer.Location = new System.Drawing.Point(10, 60);
            this.tabPageReservationer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPageReservationer.Name = "tabPageReservationer";
            this.tabPageReservationer.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPageReservationer.Size = new System.Drawing.Size(2460, 941);
            this.tabPageReservationer.TabIndex = 0;
            this.tabPageReservationer.Text = "Reservationer";
            this.tabPageReservationer.UseVisualStyleBackColor = true;
            // 
            // tabPageRessourcer
            // 
            this.tabPageRessourcer.Controls.Add(this.panelResourcer);
            this.tabPageRessourcer.Location = new System.Drawing.Point(10, 60);
            this.tabPageRessourcer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPageRessourcer.Name = "tabPageRessourcer";
            this.tabPageRessourcer.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPageRessourcer.Size = new System.Drawing.Size(2460, 941);
            this.tabPageRessourcer.TabIndex = 1;
            this.tabPageRessourcer.Text = "Ressourcer";
            this.tabPageRessourcer.UseVisualStyleBackColor = true;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3004, 1953);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.PanelPersonInfo.ResumeLayout(false);
            this.PanelPersonInfo.PerformLayout();
            this.PanelResource.ResumeLayout(false);
            this.PanelResource.PerformLayout();
            this.panelReservationer.ResumeLayout(false);
            this.panelReservationer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservationer)).EndInit();
            this.panelResourcer.ResumeLayout(false);
            this.panelResourcer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRessourcer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageReservationer.ResumeLayout(false);
            this.tabPageRessourcer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox TBStartDato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCheckDato;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox CBMembers;
        private System.Windows.Forms.TextBox TBResourceID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PanelResource;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Panel panelReservationer;
        private System.Windows.Forms.Panel panelResourcer;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpSlut;
        private System.Windows.Forms.Button btnAntalRes;
        private System.Windows.Forms.ComboBox cbMembersRes;
        private System.Windows.Forms.Button btnSePersonRes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageReservationer;
        private System.Windows.Forms.TabPage tabPageRessourcer;
        private System.Windows.Forms.DataGridView DGVRessourcer;
        private System.Windows.Forms.DataGridView DGVReservationer;
        private System.Windows.Forms.ComboBox cbDeleteBeboerResource;
        private System.Windows.Forms.Button btnDeleteRes;
        private System.Windows.Forms.TextBox tbresResNr;
        private System.Windows.Forms.ComboBox cbDeleteResFromBeboer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetReservations;
        private System.Windows.Forms.DateTimePicker dtpStatistik;
        private System.Windows.Forms.Button btnGetDateReservationer;
        private System.Windows.Forms.ToolTip toolTipBooking;
    }
}