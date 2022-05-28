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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelReservationer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblOversigt = new System.Windows.Forms.Label();
            this.btnSePersonRes = new System.Windows.Forms.Button();
            this.cbMembersRes = new System.Windows.Forms.ComboBox();
            this.btnAntalRes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStatestikTilDagsDato = new System.Windows.Forms.Label();
            this.dtpStatistik = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetDateReservationer = new System.Windows.Forms.Button();
            this.btnGetReservations = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVReservationer = new System.Windows.Forms.DataGridView();
            this.panelResourcer = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBekræftRes = new System.Windows.Forms.Label();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.CBMembers = new System.Windows.Forms.ComboBox();
            this.PanelResource = new System.Windows.Forms.Panel();
            this.dtpSlut = new System.Windows.Forms.DateTimePicker();
            this.BtnCheckLedigeRessourcer = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.CBResource = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBResourceID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelPersonInfo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PersonID = new System.Windows.Forms.Label();
            this.TBTLF = new System.Windows.Forms.TextBox();
            this.TBMail = new System.Windows.Forms.TextBox();
            this.TBPID = new System.Windows.Forms.TextBox();
            this.labelsletning = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbresResNr = new System.Windows.Forms.TextBox();
            this.cbDeleteBeboerResource = new System.Windows.Forms.ComboBox();
            this.cbDeleteResFromBeboer = new System.Windows.Forms.ComboBox();
            this.btnDeleteRes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVRessourcer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageReservationer = new System.Windows.Forms.TabPage();
            this.tabPageRessourcer = new System.Windows.Forms.TabPage();
            this.toolTipBooking = new System.Windows.Forms.ToolTip(this.components);
            this.panelReservationer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservationer)).BeginInit();
            this.panelResourcer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.PanelResource.SuspendLayout();
            this.PanelPersonInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRessourcer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageReservationer.SuspendLayout();
            this.tabPageRessourcer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReservationer
            // 
            this.panelReservationer.Controls.Add(this.panel4);
            this.panelReservationer.Controls.Add(this.panel3);
            this.panelReservationer.Controls.Add(this.label2);
            this.panelReservationer.Controls.Add(this.DGVReservationer);
            this.panelReservationer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReservationer.Location = new System.Drawing.Point(3, 3);
            this.panelReservationer.Name = "panelReservationer";
            this.panelReservationer.Size = new System.Drawing.Size(1415, 622);
            this.panelReservationer.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.lblOversigt);
            this.panel4.Controls.Add(this.btnSePersonRes);
            this.panel4.Controls.Add(this.cbMembersRes);
            this.panel4.Controls.Add(this.btnAntalRes);
            this.panel4.Location = new System.Drawing.Point(19, 378);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 228);
            this.panel4.TabIndex = 15;
            // 
            // lblOversigt
            // 
            this.lblOversigt.AutoSize = true;
            this.lblOversigt.Location = new System.Drawing.Point(12, 6);
            this.lblOversigt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOversigt.Name = "lblOversigt";
            this.lblOversigt.Size = new System.Drawing.Size(197, 20);
            this.lblOversigt.TabIndex = 13;
            this.lblOversigt.Text = "Oversigt over reservationer";
            // 
            // btnSePersonRes
            // 
            this.btnSePersonRes.Location = new System.Drawing.Point(11, 152);
            this.btnSePersonRes.Name = "btnSePersonRes";
            this.btnSePersonRes.Size = new System.Drawing.Size(215, 58);
            this.btnSePersonRes.TabIndex = 6;
            this.btnSePersonRes.Text = "Se personens reservationer";
            this.btnSePersonRes.UseVisualStyleBackColor = true;
            this.btnSePersonRes.Click += new System.EventHandler(this.btnSePersonRes_Click);
            // 
            // cbMembersRes
            // 
            this.cbMembersRes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMembersRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembersRes.FormattingEnabled = true;
            this.cbMembersRes.Location = new System.Drawing.Point(11, 119);
            this.cbMembersRes.Name = "cbMembersRes";
            this.cbMembersRes.Size = new System.Drawing.Size(216, 28);
            this.cbMembersRes.TabIndex = 5;
            // 
            // btnAntalRes
            // 
            this.btnAntalRes.Location = new System.Drawing.Point(12, 29);
            this.btnAntalRes.Name = "btnAntalRes";
            this.btnAntalRes.Size = new System.Drawing.Size(214, 59);
            this.btnAntalRes.TabIndex = 4;
            this.btnAntalRes.Text = "Antal Reservationer lige nu";
            this.btnAntalRes.UseVisualStyleBackColor = true;
            this.btnAntalRes.Click += new System.EventHandler(this.btnAntalRes_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.lblStatestikTilDagsDato);
            this.panel3.Controls.Add(this.dtpStatistik);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnGetDateReservationer);
            this.panel3.Controls.Add(this.btnGetReservations);
            this.panel3.Location = new System.Drawing.Point(293, 378);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 228);
            this.panel3.TabIndex = 14;
            // 
            // lblStatestikTilDagsDato
            // 
            this.lblStatestikTilDagsDato.AutoSize = true;
            this.lblStatestikTilDagsDato.Location = new System.Drawing.Point(6, 6);
            this.lblStatestikTilDagsDato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatestikTilDagsDato.Name = "lblStatestikTilDagsDato";
            this.lblStatestikTilDagsDato.Size = new System.Drawing.Size(127, 20);
            this.lblStatestikTilDagsDato.TabIndex = 12;
            this.lblStatestikTilDagsDato.Text = "Statestik udtræk";
            // 
            // dtpStatistik
            // 
            this.dtpStatistik.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpStatistik.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStatistik.Location = new System.Drawing.Point(10, 29);
            this.dtpStatistik.Name = "dtpStatistik";
            this.dtpStatistik.Size = new System.Drawing.Size(183, 26);
            this.dtpStatistik.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Udtræk statistik på dato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGetDateReservationer_Click);
            // 
            // btnGetDateReservationer
            // 
            this.btnGetDateReservationer.Location = new System.Drawing.Point(10, 67);
            this.btnGetDateReservationer.Name = "btnGetDateReservationer";
            this.btnGetDateReservationer.Size = new System.Drawing.Size(156, 57);
            this.btnGetDateReservationer.TabIndex = 10;
            this.btnGetDateReservationer.Text = "Udtræk statistik på dato";
            this.btnGetDateReservationer.UseVisualStyleBackColor = true;
            this.btnGetDateReservationer.Click += new System.EventHandler(this.btnGetDateReservationer_Click);
            // 
            // btnGetReservations
            // 
            this.btnGetReservations.Location = new System.Drawing.Point(10, 139);
            this.btnGetReservations.Name = "btnGetReservations";
            this.btnGetReservations.Size = new System.Drawing.Size(183, 72);
            this.btnGetReservations.TabIndex = 9;
            this.btnGetReservations.Text = "Udtræk statistik på alle reservationer";
            this.btnGetReservations.UseVisualStyleBackColor = true;
            this.btnGetReservations.Click += new System.EventHandler(this.btnGetReservations_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reservationer";
            // 
            // DGVReservationer
            // 
            this.DGVReservationer.AllowUserToAddRows = false;
            this.DGVReservationer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DGVReservationer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVReservationer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVReservationer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVReservationer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReservationer.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGVReservationer.Location = new System.Drawing.Point(19, 26);
            this.DGVReservationer.Name = "DGVReservationer";
            this.DGVReservationer.ReadOnly = true;
            this.DGVReservationer.RowHeadersWidth = 92;
            this.DGVReservationer.RowTemplate.DividerHeight = 1;
            this.DGVReservationer.RowTemplate.Height = 30;
            this.DGVReservationer.RowTemplate.ReadOnly = true;
            this.DGVReservationer.Size = new System.Drawing.Size(1380, 310);
            this.DGVReservationer.TabIndex = 7;
            // 
            // panelResourcer
            // 
            this.panelResourcer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelResourcer.Controls.Add(this.panel5);
            this.panelResourcer.Controls.Add(this.labelsletning);
            this.panelResourcer.Controls.Add(this.panel2);
            this.panelResourcer.Controls.Add(this.panel1);
            this.panelResourcer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResourcer.Location = new System.Drawing.Point(3, 3);
            this.panelResourcer.Name = "panelResourcer";
            this.panelResourcer.Size = new System.Drawing.Size(1415, 622);
            this.panelResourcer.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.lblBekræftRes);
            this.panel5.Controls.Add(this.btnConfirmBooking);
            this.panel5.Controls.Add(this.CBMembers);
            this.panel5.Controls.Add(this.PanelResource);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.PanelPersonInfo);
            this.panel5.Location = new System.Drawing.Point(8, 16);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(539, 474);
            this.panel5.TabIndex = 40;
            // 
            // lblBekræftRes
            // 
            this.lblBekræftRes.AutoSize = true;
            this.lblBekræftRes.Location = new System.Drawing.Point(161, 8);
            this.lblBekræftRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBekræftRes.Name = "lblBekræftRes";
            this.lblBekræftRes.Size = new System.Drawing.Size(138, 20);
            this.lblBekræftRes.TabIndex = 28;
            this.lblBekræftRes.Text = "Opret Reservation";
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(112, 408);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(296, 28);
            this.btnConfirmBooking.TabIndex = 27;
            this.btnConfirmBooking.Text = "Bekræft Reservation";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Visible = false;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // CBMembers
            // 
            this.CBMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMembers.FormattingEnabled = true;
            this.CBMembers.Location = new System.Drawing.Point(21, 69);
            this.CBMembers.Name = "CBMembers";
            this.CBMembers.Size = new System.Drawing.Size(149, 28);
            this.CBMembers.TabIndex = 4;
            this.CBMembers.SelectedIndexChanged += new System.EventHandler(this.CBMembers_SelectedIndexChanged);
            // 
            // PanelResource
            // 
            this.PanelResource.Controls.Add(this.dtpSlut);
            this.PanelResource.Controls.Add(this.BtnCheckLedigeRessourcer);
            this.PanelResource.Controls.Add(this.dtpStart);
            this.PanelResource.Controls.Add(this.label9);
            this.PanelResource.Controls.Add(this.CBResource);
            this.PanelResource.Controls.Add(this.label6);
            this.PanelResource.Controls.Add(this.TBResourceID);
            this.PanelResource.Controls.Add(this.label8);
            this.PanelResource.Controls.Add(this.label7);
            this.PanelResource.Location = new System.Drawing.Point(267, 37);
            this.PanelResource.Name = "PanelResource";
            this.PanelResource.Size = new System.Drawing.Size(251, 348);
            this.PanelResource.TabIndex = 26;
            // 
            // dtpSlut
            // 
            this.dtpSlut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSlut.Location = new System.Drawing.Point(7, 112);
            this.dtpSlut.Name = "dtpSlut";
            this.dtpSlut.Size = new System.Drawing.Size(114, 26);
            this.dtpSlut.TabIndex = 26;
            this.toolTipBooking.SetToolTip(this.dtpSlut, "Vælg ønsket slut dato for booking");
            // 
            // BtnCheckLedigeRessourcer
            // 
            this.BtnCheckLedigeRessourcer.Location = new System.Drawing.Point(7, 187);
            this.BtnCheckLedigeRessourcer.Name = "BtnCheckLedigeRessourcer";
            this.BtnCheckLedigeRessourcer.Size = new System.Drawing.Size(216, 35);
            this.BtnCheckLedigeRessourcer.TabIndex = 21;
            this.BtnCheckLedigeRessourcer.Text = "Check Ledige Ressourcer";
            this.BtnCheckLedigeRessourcer.UseVisualStyleBackColor = true;
            this.BtnCheckLedigeRessourcer.Click += new System.EventHandler(this.BtnCheckLedigeRessourcer_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(7, 32);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(116, 26);
            this.dtpStart.TabIndex = 28;
            this.toolTipBooking.SetToolTip(this.dtpStart, "Vælg ønsket start dato for booking");
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Resource ID";
            // 
            // CBResource
            // 
            this.CBResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBResource.FormattingEnabled = true;
            this.CBResource.Location = new System.Drawing.Point(7, 258);
            this.CBResource.Name = "CBResource";
            this.CBResource.Size = new System.Drawing.Size(149, 28);
            this.CBResource.TabIndex = 14;
            this.CBResource.SelectedIndexChanged += new System.EventHandler(this.CBResource_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vælg ressource";
            // 
            // TBResourceID
            // 
            this.TBResourceID.Location = new System.Drawing.Point(7, 314);
            this.TBResourceID.Name = "TBResourceID";
            this.TBResourceID.ReadOnly = true;
            this.TBResourceID.Size = new System.Drawing.Size(100, 26);
            this.TBResourceID.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vælg slut dato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vælg start dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vælg beboer";
            // 
            // PanelPersonInfo
            // 
            this.PanelPersonInfo.Controls.Add(this.label5);
            this.PanelPersonInfo.Controls.Add(this.label4);
            this.PanelPersonInfo.Controls.Add(this.PersonID);
            this.PanelPersonInfo.Controls.Add(this.TBTLF);
            this.PanelPersonInfo.Controls.Add(this.TBMail);
            this.PanelPersonInfo.Controls.Add(this.TBPID);
            this.PanelPersonInfo.Location = new System.Drawing.Point(14, 105);
            this.PanelPersonInfo.Name = "PanelPersonInfo";
            this.PanelPersonInfo.Size = new System.Drawing.Size(237, 280);
            this.PanelPersonInfo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefonnummer: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mail:";
            // 
            // PersonID
            // 
            this.PersonID.AutoSize = true;
            this.PersonID.Location = new System.Drawing.Point(4, 22);
            this.PersonID.Name = "PersonID";
            this.PersonID.Size = new System.Drawing.Size(84, 20);
            this.PersonID.TabIndex = 8;
            this.PersonID.Text = "Person ID:";
            // 
            // TBTLF
            // 
            this.TBTLF.Location = new System.Drawing.Point(8, 199);
            this.TBTLF.Name = "TBTLF";
            this.TBTLF.ReadOnly = true;
            this.TBTLF.Size = new System.Drawing.Size(142, 26);
            this.TBTLF.TabIndex = 7;
            // 
            // TBMail
            // 
            this.TBMail.Location = new System.Drawing.Point(7, 123);
            this.TBMail.Name = "TBMail";
            this.TBMail.ReadOnly = true;
            this.TBMail.Size = new System.Drawing.Size(203, 26);
            this.TBMail.TabIndex = 6;
            // 
            // TBPID
            // 
            this.TBPID.Location = new System.Drawing.Point(8, 46);
            this.TBPID.Name = "TBPID";
            this.TBPID.ReadOnly = true;
            this.TBPID.Size = new System.Drawing.Size(142, 26);
            this.TBPID.TabIndex = 5;
            // 
            // labelsletning
            // 
            this.labelsletning.AutoSize = true;
            this.labelsletning.Location = new System.Drawing.Point(82, 505);
            this.labelsletning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelsletning.Name = "labelsletning";
            this.labelsletning.Size = new System.Drawing.Size(167, 20);
            this.labelsletning.TabIndex = 39;
            this.labelsletning.Text = "Sletning af reservation";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbresResNr);
            this.panel2.Controls.Add(this.cbDeleteBeboerResource);
            this.panel2.Controls.Add(this.cbDeleteResFromBeboer);
            this.panel2.Controls.Add(this.btnDeleteRes);
            this.panel2.Location = new System.Drawing.Point(86, 528);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 73);
            this.panel2.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Vælg beboers reservation";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Vælg Beboer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Reservations nummer:";
            // 
            // tbresResNr
            // 
            this.tbresResNr.Location = new System.Drawing.Point(426, 28);
            this.tbresResNr.Name = "tbresResNr";
            this.tbresResNr.ReadOnly = true;
            this.tbresResNr.Size = new System.Drawing.Size(100, 26);
            this.tbresResNr.TabIndex = 33;
            // 
            // cbDeleteBeboerResource
            // 
            this.cbDeleteBeboerResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeleteBeboerResource.FormattingEnabled = true;
            this.cbDeleteBeboerResource.Location = new System.Drawing.Point(221, 28);
            this.cbDeleteBeboerResource.Name = "cbDeleteBeboerResource";
            this.cbDeleteBeboerResource.Size = new System.Drawing.Size(177, 28);
            this.cbDeleteBeboerResource.TabIndex = 32;
            this.cbDeleteBeboerResource.Visible = false;
            this.cbDeleteBeboerResource.SelectedIndexChanged += new System.EventHandler(this.cbDeleteBeboerResource_SelectedIndexChanged);
            // 
            // cbDeleteResFromBeboer
            // 
            this.cbDeleteResFromBeboer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeleteResFromBeboer.FormattingEnabled = true;
            this.cbDeleteResFromBeboer.Location = new System.Drawing.Point(20, 29);
            this.cbDeleteResFromBeboer.Name = "cbDeleteResFromBeboer";
            this.cbDeleteResFromBeboer.Size = new System.Drawing.Size(177, 28);
            this.cbDeleteResFromBeboer.TabIndex = 31;
            this.cbDeleteResFromBeboer.SelectedIndexChanged += new System.EventHandler(this.cbDeleteResFromBeboer_SelectedIndexChanged);
            // 
            // btnDeleteRes
            // 
            this.btnDeleteRes.Location = new System.Drawing.Point(594, 18);
            this.btnDeleteRes.Name = "btnDeleteRes";
            this.btnDeleteRes.Size = new System.Drawing.Size(147, 35);
            this.btnDeleteRes.TabIndex = 30;
            this.btnDeleteRes.Text = "Slet reservation";
            this.btnDeleteRes.UseVisualStyleBackColor = true;
            this.btnDeleteRes.Click += new System.EventHandler(this.btnDeleteRes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.DGVRessourcer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(573, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 474);
            this.panel1.TabIndex = 37;
            // 
            // DGVRessourcer
            // 
            this.DGVRessourcer.AllowUserToAddRows = false;
            this.DGVRessourcer.AllowUserToDeleteRows = false;
            this.DGVRessourcer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRessourcer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRessourcer.Location = new System.Drawing.Point(14, 26);
            this.DGVRessourcer.Name = "DGVRessourcer";
            this.DGVRessourcer.ReadOnly = true;
            this.DGVRessourcer.RowHeadersVisible = false;
            this.DGVRessourcer.RowHeadersWidth = 92;
            this.DGVRessourcer.RowTemplate.Height = 30;
            this.DGVRessourcer.Size = new System.Drawing.Size(489, 434);
            this.DGVRessourcer.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ledige ressourcer";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageReservationer);
            this.tabControl1.Controls.Add(this.tabPageRessourcer);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1429, 667);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPageReservationer
            // 
            this.tabPageReservationer.Controls.Add(this.panelReservationer);
            this.tabPageReservationer.Location = new System.Drawing.Point(4, 35);
            this.tabPageReservationer.Name = "tabPageReservationer";
            this.tabPageReservationer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReservationer.Size = new System.Drawing.Size(1421, 628);
            this.tabPageReservationer.TabIndex = 0;
            this.tabPageReservationer.Text = "Reservationer";
            this.tabPageReservationer.UseVisualStyleBackColor = true;
            // 
            // tabPageRessourcer
            // 
            this.tabPageRessourcer.Controls.Add(this.panelResourcer);
            this.tabPageRessourcer.Location = new System.Drawing.Point(4, 35);
            this.tabPageRessourcer.Name = "tabPageRessourcer";
            this.tabPageRessourcer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRessourcer.Size = new System.Drawing.Size(1421, 628);
            this.tabPageRessourcer.TabIndex = 1;
            this.tabPageRessourcer.Text = "Ressourcer";
            this.tabPageRessourcer.UseVisualStyleBackColor = true;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 703);
            this.Controls.Add(this.tabControl1);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.panelReservationer.ResumeLayout(false);
            this.panelReservationer.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservationer)).EndInit();
            this.panelResourcer.ResumeLayout(false);
            this.panelResourcer.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.PanelResource.ResumeLayout(false);
            this.PanelResource.PerformLayout();
            this.PanelPersonInfo.ResumeLayout(false);
            this.PanelPersonInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRessourcer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageReservationer.ResumeLayout(false);
            this.tabPageRessourcer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelReservationer;
        private System.Windows.Forms.Panel panelResourcer;
        private System.Windows.Forms.Button btnAntalRes;
        private System.Windows.Forms.ComboBox cbMembersRes;
        private System.Windows.Forms.Button btnSePersonRes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageReservationer;
        private System.Windows.Forms.TabPage tabPageRessourcer;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelsletning;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblOversigt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStatestikTilDagsDato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBekræftRes;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.ComboBox CBResource;
        public System.Windows.Forms.ComboBox CBMembers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PanelResource;
        private System.Windows.Forms.DateTimePicker dtpSlut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBResourceID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelPersonInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PersonID;
        private System.Windows.Forms.TextBox TBTLF;
        private System.Windows.Forms.TextBox TBMail;
        private System.Windows.Forms.TextBox TBPID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVRessourcer;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button BtnCheckLedigeRessourcer;
        private System.Windows.Forms.Label label1;
    }
}