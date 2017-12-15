namespace OIS.Views
{
    partial class RPT002_WorkPlaceAirQualityEntry
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
            this.gbHeader = new OIS.BaseViews.rGroupBox();
            this.txtProjectAddr = new OIS.BaseViews.rTextBox();
            this.txtCustomerAddr = new OIS.BaseViews.rTextBox();
            this.chkShowProjectAddr = new System.Windows.Forms.CheckBox();
            this.btnUser = new OIS.BaseViews.rButton();
            this.btnDetail = new OIS.BaseViews.rButton();
            this.pnlAgent = new System.Windows.Forms.Panel();
            this.rdoAgent2 = new System.Windows.Forms.RadioButton();
            this.rdoAgent1 = new System.Windows.Forms.RadioButton();
            this.rdoAWA = new System.Windows.Forms.RadioButton();
            this.rdoWA = new System.Windows.Forms.RadioButton();
            this.txtAgentName = new OIS.BaseViews.rTextBox();
            this.lblJobNo = new OIS.BaseViews.rLabel();
            this.txtJobNo = new OIS.BaseViews.rTextBox();
            this.lblReportDate = new OIS.BaseViews.rLabel();
            this.dtReportDate = new OIS.BaseViews.rDateTextBox();
            this.chkShowLv2Cont = new System.Windows.Forms.CheckBox();
            this.chkShowLv3Cont = new System.Windows.Forms.CheckBox();
            this.chkShowLv3EachPage = new System.Windows.Forms.CheckBox();
            this.dtAnalyticalDateTo = new OIS.BaseViews.rDateTextBox();
            this.lblAnalyticalDateTo = new OIS.BaseViews.rLabel();
            this.txtRegistration = new OIS.BaseViews.rSearchTextBox();
            this.lblRegistration = new OIS.BaseViews.rLabel();
            this.txtLabSupervisor = new OIS.BaseViews.rSearchTextBox();
            this.lblLabSupervisor = new OIS.BaseViews.rLabel();
            this.lblAnalyticalDate = new OIS.BaseViews.rLabel();
            this.dtAnalyticalDate = new OIS.BaseViews.rDateTextBox();
            this.txtProject = new OIS.BaseViews.rSearchTextBox();
            this.txtCustomer = new OIS.BaseViews.rSearchTextBox();
            this.lblAnalysisNo = new OIS.BaseViews.rLabel();
            this.txtAnalysisNo = new OIS.BaseViews.rTextBox();
            this.lblReceivedDate = new OIS.BaseViews.rLabel();
            this.dtReceivedDate = new OIS.BaseViews.rDateTextBox();
            this.lblProject = new OIS.BaseViews.rLabel();
            this.lblCustomer = new OIS.BaseViews.rLabel();
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.gbHistory = new OIS.BaseViews.rGroupBox();
            this.txtDelId = new OIS.BaseViews.rTextBox();
            this.lblDelId = new OIS.BaseViews.rLabel();
            this.txtDelMachine = new OIS.BaseViews.rTextBox();
            this.lblDelMachine = new OIS.BaseViews.rLabel();
            this.dtDel = new OIS.BaseViews.rDateTextBox();
            this.lblDelDate = new OIS.BaseViews.rLabel();
            this.txtUpdId = new OIS.BaseViews.rTextBox();
            this.lblUpdId = new OIS.BaseViews.rLabel();
            this.txtUpdMachine = new OIS.BaseViews.rTextBox();
            this.lblUpdMachine = new OIS.BaseViews.rLabel();
            this.dtUpd = new OIS.BaseViews.rDateTextBox();
            this.lblUpdDate = new OIS.BaseViews.rLabel();
            this.txtCrtId = new OIS.BaseViews.rTextBox();
            this.lblCrtId = new OIS.BaseViews.rLabel();
            this.txtCrtMachine = new OIS.BaseViews.rTextBox();
            this.lblCrtMachine = new OIS.BaseViews.rLabel();
            this.dtCrt = new OIS.BaseViews.rDateTextBox();
            this.lblCrtDate = new OIS.BaseViews.rLabel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            this.gbHeader.SuspendLayout();
            this.pnlAgent.SuspendLayout();
            this.gbHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.AutoSize = true;
            this.pnlMain.Controls.Add(this.gbHistory);
            this.pnlMain.Controls.Add(this.lblHeader);
            this.pnlMain.Controls.Add(this.gbHeader);
            this.pnlMain.Size = new System.Drawing.Size(1064, 638);
            // 
            // bdSource
            // 
            this.bdSource.DataSource = typeof(OIS.RPT.DTO.RPT002_WorkPlaceAirDTO);
            // 
            // gbHeader
            // 
            this.gbHeader.AutoSize = true;
            this.gbHeader.Controls.Add(this.txtProjectAddr);
            this.gbHeader.Controls.Add(this.txtCustomerAddr);
            this.gbHeader.Controls.Add(this.chkShowProjectAddr);
            this.gbHeader.Controls.Add(this.btnUser);
            this.gbHeader.Controls.Add(this.btnDetail);
            this.gbHeader.Controls.Add(this.pnlAgent);
            this.gbHeader.Controls.Add(this.rdoAWA);
            this.gbHeader.Controls.Add(this.rdoWA);
            this.gbHeader.Controls.Add(this.txtAgentName);
            this.gbHeader.Controls.Add(this.lblJobNo);
            this.gbHeader.Controls.Add(this.txtJobNo);
            this.gbHeader.Controls.Add(this.lblReportDate);
            this.gbHeader.Controls.Add(this.dtReportDate);
            this.gbHeader.Controls.Add(this.chkShowLv2Cont);
            this.gbHeader.Controls.Add(this.chkShowLv3Cont);
            this.gbHeader.Controls.Add(this.chkShowLv3EachPage);
            this.gbHeader.Controls.Add(this.dtAnalyticalDateTo);
            this.gbHeader.Controls.Add(this.lblAnalyticalDateTo);
            this.gbHeader.Controls.Add(this.txtRegistration);
            this.gbHeader.Controls.Add(this.lblRegistration);
            this.gbHeader.Controls.Add(this.txtLabSupervisor);
            this.gbHeader.Controls.Add(this.lblLabSupervisor);
            this.gbHeader.Controls.Add(this.lblAnalyticalDate);
            this.gbHeader.Controls.Add(this.dtAnalyticalDate);
            this.gbHeader.Controls.Add(this.txtProject);
            this.gbHeader.Controls.Add(this.txtCustomer);
            this.gbHeader.Controls.Add(this.lblAnalysisNo);
            this.gbHeader.Controls.Add(this.txtAnalysisNo);
            this.gbHeader.Controls.Add(this.lblReceivedDate);
            this.gbHeader.Controls.Add(this.dtReceivedDate);
            this.gbHeader.Controls.Add(this.lblProject);
            this.gbHeader.Controls.Add(this.lblCustomer);
            this.gbHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbHeader.Location = new System.Drawing.Point(11, 35);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(1048, 475);
            this.gbHeader.TabIndex = 0;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "ข้อมูลหลัก";
            // 
            // txtProjectAddr
            // 
            this.txtProjectAddr.CausesValidation = false;
            this.txtProjectAddr.IsRequired = false;
            this.txtProjectAddr.Location = new System.Drawing.Point(159, 155);
            this.txtProjectAddr.MinLength = 0;
            this.txtProjectAddr.Multiline = true;
            this.txtProjectAddr.Name = "txtProjectAddr";
            this.txtProjectAddr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProjectAddr.Size = new System.Drawing.Size(647, 40);
            this.txtProjectAddr.TabIndex = 8;
            this.txtProjectAddr.TextValue = null;
            // 
            // txtCustomerAddr
            // 
            this.txtCustomerAddr.CausesValidation = false;
            this.txtCustomerAddr.IsRequired = false;
            this.txtCustomerAddr.Location = new System.Drawing.Point(159, 80);
            this.txtCustomerAddr.MinLength = 0;
            this.txtCustomerAddr.Multiline = true;
            this.txtCustomerAddr.Name = "txtCustomerAddr";
            this.txtCustomerAddr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustomerAddr.Size = new System.Drawing.Size(647, 40);
            this.txtCustomerAddr.TabIndex = 6;
            this.txtCustomerAddr.TextValue = null;
            // 
            // chkShowProjectAddr
            // 
            this.chkShowProjectAddr.AutoSize = true;
            this.chkShowProjectAddr.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdSource, "SHOW_PROJECT_ADDR", true));
            this.chkShowProjectAddr.Location = new System.Drawing.Point(159, 366);
            this.chkShowProjectAddr.Name = "chkShowProjectAddr";
            this.chkShowProjectAddr.Size = new System.Drawing.Size(132, 20);
            this.chkShowProjectAddr.TabIndex = 21;
            this.chkShowProjectAddr.Text = "แสดง Project Addr";
            this.chkShowProjectAddr.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(315, 413);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(150, 40);
            this.btnUser.TabIndex = 23;
            this.btnUser.Text = "รายการ Sampling By";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(159, 413);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(150, 40);
            this.btnDetail.TabIndex = 22;
            this.btnDetail.Text = "รายการตรวจวัด";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // pnlAgent
            // 
            this.pnlAgent.Controls.Add(this.rdoAgent2);
            this.pnlAgent.Controls.Add(this.rdoAgent1);
            this.pnlAgent.Location = new System.Drawing.Point(426, 230);
            this.pnlAgent.Name = "pnlAgent";
            this.pnlAgent.Size = new System.Drawing.Size(174, 29);
            this.pnlAgent.TabIndex = 64;
            // 
            // rdoAgent2
            // 
            this.rdoAgent2.AutoSize = true;
            this.rdoAgent2.Location = new System.Drawing.Point(76, 3);
            this.rdoAgent2.Name = "rdoAgent2";
            this.rdoAgent2.Size = new System.Drawing.Size(94, 20);
            this.rdoAgent2.TabIndex = 14;
            this.rdoAgent2.Text = "ผู้กระทำแทน";
            this.rdoAgent2.UseVisualStyleBackColor = true;
            // 
            // rdoAgent1
            // 
            this.rdoAgent1.AutoSize = true;
            this.rdoAgent1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdSource, "AGENT_FLAG", true));
            this.rdoAgent1.Location = new System.Drawing.Point(3, 3);
            this.rdoAgent1.Name = "rdoAgent1";
            this.rdoAgent1.Size = new System.Drawing.Size(67, 20);
            this.rdoAgent1.TabIndex = 13;
            this.rdoAgent1.Text = "นายจ้าง";
            this.rdoAgent1.UseVisualStyleBackColor = true;
            // 
            // rdoAWA
            // 
            this.rdoAWA.AutoSize = true;
            this.rdoAWA.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdSource, "IS_AWA", true));
            this.rdoAWA.Location = new System.Drawing.Point(211, 25);
            this.rdoAWA.Name = "rdoAWA";
            this.rdoAWA.Size = new System.Drawing.Size(54, 20);
            this.rdoAWA.TabIndex = 2;
            this.rdoAWA.Text = "AWA";
            this.rdoAWA.UseVisualStyleBackColor = true;
            // 
            // rdoWA
            // 
            this.rdoWA.AutoSize = true;
            this.rdoWA.Checked = true;
            this.rdoWA.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdSource, "IS_WA", true));
            this.rdoWA.Location = new System.Drawing.Point(159, 25);
            this.rdoWA.Name = "rdoWA";
            this.rdoWA.Size = new System.Drawing.Size(46, 20);
            this.rdoWA.TabIndex = 1;
            this.rdoWA.TabStop = true;
            this.rdoWA.Text = "WA";
            this.rdoWA.UseVisualStyleBackColor = true;
            // 
            // txtAgentName
            // 
            this.txtAgentName.CausesValidation = false;
            this.txtAgentName.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bdSource, "AGENT_NAME", true));
            this.txtAgentName.IsRequired = false;
            this.txtAgentName.Location = new System.Drawing.Point(606, 230);
            this.txtAgentName.MinLength = 0;
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(200, 23);
            this.txtAgentName.TabIndex = 15;
            this.txtAgentName.TextValue = null;
            // 
            // lblJobNo
            // 
            this.lblJobNo.AutoSize = true;
            this.lblJobNo.Location = new System.Drawing.Point(541, 27);
            this.lblJobNo.Name = "lblJobNo";
            this.lblJobNo.Size = new System.Drawing.Size(59, 16);
            this.lblJobNo.TabIndex = 61;
            this.lblJobNo.Text = "Job No. :";
            this.lblJobNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtJobNo
            // 
            this.txtJobNo.CausesValidation = false;
            this.txtJobNo.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bdSource, "JOB_NO", true));
            this.txtJobNo.IsRequired = false;
            this.txtJobNo.Location = new System.Drawing.Point(606, 24);
            this.txtJobNo.MinLength = 0;
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.Size = new System.Drawing.Size(200, 23);
            this.txtJobNo.TabIndex = 4;
            this.txtJobNo.TextValue = null;
            // 
            // lblReportDate
            // 
            this.lblReportDate.AutoSize = true;
            this.lblReportDate.Location = new System.Drawing.Point(515, 204);
            this.lblReportDate.Name = "lblReportDate";
            this.lblReportDate.Size = new System.Drawing.Size(85, 16);
            this.lblReportDate.TabIndex = 59;
            this.lblReportDate.Text = "Report Date :";
            this.lblReportDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtReportDate
            // 
            this.dtReportDate.CausesValidation = false;
            this.dtReportDate.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bdSource, "REPORT_DATE", true));
            this.dtReportDate.Date = null;
            this.dtReportDate.DateValue = null;
            this.dtReportDate.IsRequired = true;
            this.dtReportDate.Location = new System.Drawing.Point(606, 201);
            this.dtReportDate.MaxLength = 10;
            this.dtReportDate.MinLength = 0;
            this.dtReportDate.Name = "dtReportDate";
            this.dtReportDate.ShowTime = false;
            this.dtReportDate.Size = new System.Drawing.Size(198, 23);
            this.dtReportDate.TabIndex = 0;
            this.dtReportDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtReportDate.TextValue = null;
            // 
            // chkShowLv2Cont
            // 
            this.chkShowLv2Cont.AutoSize = true;
            this.chkShowLv2Cont.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdSource, "SHOW_LV2_CONT", true));
            this.chkShowLv2Cont.Location = new System.Drawing.Point(159, 340);
            this.chkShowLv2Cont.Name = "chkShowLv2Cont";
            this.chkShowLv2Cont.Size = new System.Drawing.Size(219, 20);
            this.chkShowLv2Cont.TabIndex = 20;
            this.chkShowLv2Cont.Text = "แสดง (Cont.) ของ Sub of Location";
            this.chkShowLv2Cont.UseVisualStyleBackColor = true;
            // 
            // chkShowLv3Cont
            // 
            this.chkShowLv3Cont.AutoSize = true;
            this.chkShowLv3Cont.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdSource, "SHOW_LV3_CONT", true));
            this.chkShowLv3Cont.Location = new System.Drawing.Point(159, 314);
            this.chkShowLv3Cont.Name = "chkShowLv3Cont";
            this.chkShowLv3Cont.Size = new System.Drawing.Size(225, 20);
            this.chkShowLv3Cont.TabIndex = 19;
            this.chkShowLv3Cont.Text = "แสดง (Cont.) ของ Type of Location";
            this.chkShowLv3Cont.UseVisualStyleBackColor = true;
            // 
            // chkShowLv3EachPage
            // 
            this.chkShowLv3EachPage.AutoSize = true;
            this.chkShowLv3EachPage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdSource, "SHOW_LV3_EACH_PAGE", true));
            this.chkShowLv3EachPage.Location = new System.Drawing.Point(159, 288);
            this.chkShowLv3EachPage.Name = "chkShowLv3EachPage";
            this.chkShowLv3EachPage.Size = new System.Drawing.Size(198, 20);
            this.chkShowLv3EachPage.TabIndex = 18;
            this.chkShowLv3EachPage.Text = "แสดง Type of Location ทุกหน้า";
            this.chkShowLv3EachPage.UseVisualStyleBackColor = true;
            // 
            // dtAnalyticalDateTo
            // 
            this.dtAnalyticalDateTo.CausesValidation = false;
            this.dtAnalyticalDateTo.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bdSource, "ANALYTICAL_DATE_TO", true));
            this.dtAnalyticalDateTo.Date = null;
            this.dtAnalyticalDateTo.DateValue = null;
            this.dtAnalyticalDateTo.IsRequired = true;
            this.dtAnalyticalDateTo.Location = new System.Drawing.Point(284, 230);
            this.dtAnalyticalDateTo.MaxLength = 10;
            this.dtAnalyticalDateTo.MinLength = 0;
            this.dtAnalyticalDateTo.Name = "dtAnalyticalDateTo";
            this.dtAnalyticalDateTo.ShowTime = false;
            this.dtAnalyticalDateTo.Size = new System.Drawing.Size(100, 23);
            this.dtAnalyticalDateTo.TabIndex = 12;
            this.dtAnalyticalDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtAnalyticalDateTo.TextValue = null;
            // 
            // lblAnalyticalDateTo
            // 
            this.lblAnalyticalDateTo.AutoSize = true;
            this.lblAnalyticalDateTo.Location = new System.Drawing.Point(265, 233);
            this.lblAnalyticalDateTo.Name = "lblAnalyticalDateTo";
            this.lblAnalyticalDateTo.Size = new System.Drawing.Size(13, 16);
            this.lblAnalyticalDateTo.TabIndex = 57;
            this.lblAnalyticalDateTo.Text = "-";
            this.lblAnalyticalDateTo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRegistration
            // 
            this.txtRegistration.BackColor = System.Drawing.SystemColors.Info;
            this.txtRegistration.CausesValidation = false;
            this.txtRegistration.DataBindings.Add(new System.Windows.Forms.Binding("StringValue", this.bdSource, "REGISTRATION_ID", true));
            this.txtRegistration.IntValue = null;
            this.txtRegistration.IsRequired = true;
            this.txtRegistration.Location = new System.Drawing.Point(159, 259);
            this.txtRegistration.MinLength = 0;
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.OptionalTextBox = null;
            this.txtRegistration.SearchType = OIS.BaseViews.eSearchType.User;
            this.txtRegistration.Size = new System.Drawing.Size(200, 23);
            this.txtRegistration.StringValue = null;
            this.txtRegistration.TabIndex = 16;
            this.txtRegistration.TextValue = null;
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Location = new System.Drawing.Point(95, 262);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(58, 16);
            this.lblRegistration.TabIndex = 55;
            this.lblRegistration.Text = "Analyst :";
            this.lblRegistration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLabSupervisor
            // 
            this.txtLabSupervisor.BackColor = System.Drawing.SystemColors.Info;
            this.txtLabSupervisor.CausesValidation = false;
            this.txtLabSupervisor.DataBindings.Add(new System.Windows.Forms.Binding("StringValue", this.bdSource, "LAB_SUPERVISOR_ID", true));
            this.txtLabSupervisor.IntValue = null;
            this.txtLabSupervisor.IsRequired = true;
            this.txtLabSupervisor.Location = new System.Drawing.Point(606, 259);
            this.txtLabSupervisor.MinLength = 0;
            this.txtLabSupervisor.Name = "txtLabSupervisor";
            this.txtLabSupervisor.OptionalTextBox = null;
            this.txtLabSupervisor.SearchType = OIS.BaseViews.eSearchType.User;
            this.txtLabSupervisor.Size = new System.Drawing.Size(200, 23);
            this.txtLabSupervisor.StringValue = null;
            this.txtLabSupervisor.TabIndex = 17;
            this.txtLabSupervisor.TextValue = null;
            // 
            // lblLabSupervisor
            // 
            this.lblLabSupervisor.AutoSize = true;
            this.lblLabSupervisor.Location = new System.Drawing.Point(498, 262);
            this.lblLabSupervisor.Name = "lblLabSupervisor";
            this.lblLabSupervisor.Size = new System.Drawing.Size(102, 16);
            this.lblLabSupervisor.TabIndex = 51;
            this.lblLabSupervisor.Text = "Lab Supervisor :";
            this.lblLabSupervisor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAnalyticalDate
            // 
            this.lblAnalyticalDate.AutoSize = true;
            this.lblAnalyticalDate.Location = new System.Drawing.Point(56, 233);
            this.lblAnalyticalDate.Name = "lblAnalyticalDate";
            this.lblAnalyticalDate.Size = new System.Drawing.Size(97, 16);
            this.lblAnalyticalDate.TabIndex = 47;
            this.lblAnalyticalDate.Text = "Analytical Date:";
            this.lblAnalyticalDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtAnalyticalDate
            // 
            this.dtAnalyticalDate.CausesValidation = false;
            this.dtAnalyticalDate.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bdSource, "ANALYTICAL_DATE_FROM", true));
            this.dtAnalyticalDate.Date = null;
            this.dtAnalyticalDate.DateValue = null;
            this.dtAnalyticalDate.IsRequired = true;
            this.dtAnalyticalDate.Location = new System.Drawing.Point(159, 230);
            this.dtAnalyticalDate.MaxLength = 10;
            this.dtAnalyticalDate.MinLength = 0;
            this.dtAnalyticalDate.Name = "dtAnalyticalDate";
            this.dtAnalyticalDate.ShowTime = false;
            this.dtAnalyticalDate.Size = new System.Drawing.Size(100, 23);
            this.dtAnalyticalDate.TabIndex = 11;
            this.dtAnalyticalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtAnalyticalDate.TextValue = null;
            // 
            // txtProject
            // 
            this.txtProject.BackColor = System.Drawing.SystemColors.Info;
            this.txtProject.CausesValidation = false;
            this.txtProject.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.bdSource, "CUSTOMER_PROJECT_ID", true));
            this.txtProject.IntValue = null;
            this.txtProject.IsRequired = false;
            this.txtProject.Location = new System.Drawing.Point(159, 126);
            this.txtProject.MinLength = 0;
            this.txtProject.Name = "txtProject";
            this.txtProject.OptionalTextBox = this.txtProjectAddr;
            this.txtProject.SearchType = OIS.BaseViews.eSearchType.Project;
            this.txtProject.Size = new System.Drawing.Size(374, 23);
            this.txtProject.StringValue = null;
            this.txtProject.TabIndex = 7;
            this.txtProject.TextValue = null;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomer.CausesValidation = false;
            this.txtCustomer.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.bdSource, "CUSTOMER_ID", true));
            this.txtCustomer.IntValue = null;
            this.txtCustomer.IsRequired = true;
            this.txtCustomer.Location = new System.Drawing.Point(159, 51);
            this.txtCustomer.MinLength = 0;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.OptionalTextBox = this.txtCustomerAddr;
            this.txtCustomer.SearchType = OIS.BaseViews.eSearchType.Customer;
            this.txtCustomer.Size = new System.Drawing.Size(374, 23);
            this.txtCustomer.StringValue = null;
            this.txtCustomer.TabIndex = 5;
            this.txtCustomer.TextValue = null;
            // 
            // lblAnalysisNo
            // 
            this.lblAnalysisNo.AutoSize = true;
            this.lblAnalysisNo.Location = new System.Drawing.Point(67, 25);
            this.lblAnalysisNo.Name = "lblAnalysisNo";
            this.lblAnalysisNo.Size = new System.Drawing.Size(86, 16);
            this.lblAnalysisNo.TabIndex = 32;
            this.lblAnalysisNo.Text = "Analysis No. :";
            this.lblAnalysisNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAnalysisNo
            // 
            this.txtAnalysisNo.CausesValidation = false;
            this.txtAnalysisNo.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bdSource, "ANALYSYS_NO", true));
            this.txtAnalysisNo.IsRequired = true;
            this.txtAnalysisNo.Location = new System.Drawing.Point(271, 22);
            this.txtAnalysisNo.MinLength = 0;
            this.txtAnalysisNo.Name = "txtAnalysisNo";
            this.txtAnalysisNo.Size = new System.Drawing.Size(86, 23);
            this.txtAnalysisNo.TabIndex = 3;
            this.txtAnalysisNo.TextValue = null;
            // 
            // lblReceivedDate
            // 
            this.lblReceivedDate.AutoSize = true;
            this.lblReceivedDate.Location = new System.Drawing.Point(55, 204);
            this.lblReceivedDate.Name = "lblReceivedDate";
            this.lblReceivedDate.Size = new System.Drawing.Size(98, 16);
            this.lblReceivedDate.TabIndex = 27;
            this.lblReceivedDate.Text = "Received Date :";
            this.lblReceivedDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtReceivedDate
            // 
            this.dtReceivedDate.CausesValidation = false;
            this.dtReceivedDate.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bdSource, "RECEIVED_DATE", true));
            this.dtReceivedDate.Date = null;
            this.dtReceivedDate.DateValue = null;
            this.dtReceivedDate.IsRequired = true;
            this.dtReceivedDate.Location = new System.Drawing.Point(159, 201);
            this.dtReceivedDate.MaxLength = 10;
            this.dtReceivedDate.MinLength = 0;
            this.dtReceivedDate.Name = "dtReceivedDate";
            this.dtReceivedDate.ShowTime = false;
            this.dtReceivedDate.Size = new System.Drawing.Size(198, 23);
            this.dtReceivedDate.TabIndex = 9;
            this.dtReceivedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtReceivedDate.TextValue = null;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(96, 129);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(57, 16);
            this.lblProject.TabIndex = 23;
            this.lblProject.Text = "Project :";
            this.lblProject.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(80, 54);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(72, 16);
            this.lblCustomer.TabIndex = 22;
            this.lblCustomer.Text = "Customer :";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(3, -1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(398, 33);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "ข้อมูล Work Place Air Quality";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbHistory
            // 
            this.gbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbHistory.Controls.Add(this.txtDelId);
            this.gbHistory.Controls.Add(this.lblDelId);
            this.gbHistory.Controls.Add(this.txtDelMachine);
            this.gbHistory.Controls.Add(this.lblDelMachine);
            this.gbHistory.Controls.Add(this.dtDel);
            this.gbHistory.Controls.Add(this.lblDelDate);
            this.gbHistory.Controls.Add(this.txtUpdId);
            this.gbHistory.Controls.Add(this.lblUpdId);
            this.gbHistory.Controls.Add(this.txtUpdMachine);
            this.gbHistory.Controls.Add(this.lblUpdMachine);
            this.gbHistory.Controls.Add(this.dtUpd);
            this.gbHistory.Controls.Add(this.lblUpdDate);
            this.gbHistory.Controls.Add(this.txtCrtId);
            this.gbHistory.Controls.Add(this.lblCrtId);
            this.gbHistory.Controls.Add(this.txtCrtMachine);
            this.gbHistory.Controls.Add(this.lblCrtMachine);
            this.gbHistory.Controls.Add(this.dtCrt);
            this.gbHistory.Controls.Add(this.lblCrtDate);
            this.gbHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbHistory.Location = new System.Drawing.Point(11, 511);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(1048, 120);
            this.gbHistory.TabIndex = 16;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "ประวัติการบันทึก";
            // 
            // txtDelId
            // 
            this.txtDelId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "DEL_NAME", true));
            this.txtDelId.Enabled = false;
            this.txtDelId.IsRequired = false;
            this.txtDelId.Location = new System.Drawing.Point(131, 80);
            this.txtDelId.MinLength = 0;
            this.txtDelId.Name = "txtDelId";
            this.txtDelId.Size = new System.Drawing.Size(150, 23);
            this.txtDelId.TabIndex = 43;
            this.txtDelId.TextValue = null;
            // 
            // lblDelId
            // 
            this.lblDelId.AutoSize = true;
            this.lblDelId.Location = new System.Drawing.Point(64, 83);
            this.lblDelId.Name = "lblDelId";
            this.lblDelId.Size = new System.Drawing.Size(61, 16);
            this.lblDelId.TabIndex = 44;
            this.lblDelId.Text = "ผู้ยกเลิก :";
            this.lblDelId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDelMachine
            // 
            this.txtDelMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "DEL_MACHINE", true));
            this.txtDelMachine.Enabled = false;
            this.txtDelMachine.IsRequired = false;
            this.txtDelMachine.Location = new System.Drawing.Point(679, 80);
            this.txtDelMachine.MinLength = 0;
            this.txtDelMachine.Name = "txtDelMachine";
            this.txtDelMachine.Size = new System.Drawing.Size(150, 23);
            this.txtDelMachine.TabIndex = 41;
            this.txtDelMachine.TextValue = null;
            // 
            // lblDelMachine
            // 
            this.lblDelMachine.AutoSize = true;
            this.lblDelMachine.Location = new System.Drawing.Point(579, 83);
            this.lblDelMachine.Name = "lblDelMachine";
            this.lblDelMachine.Size = new System.Drawing.Size(94, 16);
            this.lblDelMachine.TabIndex = 42;
            this.lblDelMachine.Text = "เครื่องที่ยกเลิก :";
            this.lblDelMachine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtDel
            // 
            this.dtDel.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bdSource, "DEL_DATE", true));
            this.dtDel.Date = null;
            this.dtDel.DateValue = null;
            this.dtDel.Enabled = false;
            this.dtDel.IsRequired = false;
            this.dtDel.Location = new System.Drawing.Point(406, 80);
            this.dtDel.MaxLength = 10;
            this.dtDel.MinLength = 0;
            this.dtDel.Name = "dtDel";
            this.dtDel.ShowTime = true;
            this.dtDel.Size = new System.Drawing.Size(150, 23);
            this.dtDel.TabIndex = 39;
            this.dtDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtDel.TextValue = null;
            // 
            // lblDelDate
            // 
            this.lblDelDate.AutoSize = true;
            this.lblDelDate.Location = new System.Drawing.Point(324, 83);
            this.lblDelDate.Name = "lblDelDate";
            this.lblDelDate.Size = new System.Drawing.Size(76, 16);
            this.lblDelDate.TabIndex = 40;
            this.lblDelDate.Text = "วันที่ยกเลิก :";
            this.lblDelDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUpdId
            // 
            this.txtUpdId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "UPD_NAME", true));
            this.txtUpdId.Enabled = false;
            this.txtUpdId.IsRequired = false;
            this.txtUpdId.Location = new System.Drawing.Point(131, 51);
            this.txtUpdId.MinLength = 0;
            this.txtUpdId.Name = "txtUpdId";
            this.txtUpdId.Size = new System.Drawing.Size(150, 23);
            this.txtUpdId.TabIndex = 37;
            this.txtUpdId.TextValue = null;
            // 
            // lblUpdId
            // 
            this.lblUpdId.AutoSize = true;
            this.lblUpdId.Location = new System.Drawing.Point(69, 54);
            this.lblUpdId.Name = "lblUpdId";
            this.lblUpdId.Size = new System.Drawing.Size(56, 16);
            this.lblUpdId.TabIndex = 38;
            this.lblUpdId.Text = "ผู้แก้ไข :";
            this.lblUpdId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUpdMachine
            // 
            this.txtUpdMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "UPD_MACHINE", true));
            this.txtUpdMachine.Enabled = false;
            this.txtUpdMachine.IsRequired = false;
            this.txtUpdMachine.Location = new System.Drawing.Point(679, 51);
            this.txtUpdMachine.MinLength = 0;
            this.txtUpdMachine.Name = "txtUpdMachine";
            this.txtUpdMachine.Size = new System.Drawing.Size(150, 23);
            this.txtUpdMachine.TabIndex = 35;
            this.txtUpdMachine.TextValue = null;
            // 
            // lblUpdMachine
            // 
            this.lblUpdMachine.AutoSize = true;
            this.lblUpdMachine.Location = new System.Drawing.Point(584, 54);
            this.lblUpdMachine.Name = "lblUpdMachine";
            this.lblUpdMachine.Size = new System.Drawing.Size(89, 16);
            this.lblUpdMachine.TabIndex = 36;
            this.lblUpdMachine.Text = "เครื่องที่แก้ไข :";
            this.lblUpdMachine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtUpd
            // 
            this.dtUpd.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bdSource, "UPD_DATE", true));
            this.dtUpd.Date = null;
            this.dtUpd.DateValue = null;
            this.dtUpd.Enabled = false;
            this.dtUpd.IsRequired = false;
            this.dtUpd.Location = new System.Drawing.Point(406, 51);
            this.dtUpd.MaxLength = 10;
            this.dtUpd.MinLength = 0;
            this.dtUpd.Name = "dtUpd";
            this.dtUpd.ShowTime = true;
            this.dtUpd.Size = new System.Drawing.Size(150, 23);
            this.dtUpd.TabIndex = 33;
            this.dtUpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtUpd.TextValue = null;
            // 
            // lblUpdDate
            // 
            this.lblUpdDate.AutoSize = true;
            this.lblUpdDate.Location = new System.Drawing.Point(329, 54);
            this.lblUpdDate.Name = "lblUpdDate";
            this.lblUpdDate.Size = new System.Drawing.Size(71, 16);
            this.lblUpdDate.TabIndex = 34;
            this.lblUpdDate.Text = "วันที่แก้ไข :";
            this.lblUpdDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCrtId
            // 
            this.txtCrtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "CRT_NAME", true));
            this.txtCrtId.Enabled = false;
            this.txtCrtId.IsRequired = false;
            this.txtCrtId.Location = new System.Drawing.Point(131, 22);
            this.txtCrtId.MinLength = 0;
            this.txtCrtId.Name = "txtCrtId";
            this.txtCrtId.Size = new System.Drawing.Size(150, 23);
            this.txtCrtId.TabIndex = 31;
            this.txtCrtId.TextValue = null;
            // 
            // lblCrtId
            // 
            this.lblCrtId.AutoSize = true;
            this.lblCrtId.Location = new System.Drawing.Point(74, 25);
            this.lblCrtId.Name = "lblCrtId";
            this.lblCrtId.Size = new System.Drawing.Size(51, 16);
            this.lblCrtId.TabIndex = 32;
            this.lblCrtId.Text = "ผู้สร้าง :";
            this.lblCrtId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCrtMachine
            // 
            this.txtCrtMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "CRT_MACHINE", true));
            this.txtCrtMachine.Enabled = false;
            this.txtCrtMachine.IsRequired = false;
            this.txtCrtMachine.Location = new System.Drawing.Point(679, 22);
            this.txtCrtMachine.MinLength = 0;
            this.txtCrtMachine.Name = "txtCrtMachine";
            this.txtCrtMachine.Size = new System.Drawing.Size(150, 23);
            this.txtCrtMachine.TabIndex = 29;
            this.txtCrtMachine.TextValue = null;
            // 
            // lblCrtMachine
            // 
            this.lblCrtMachine.AutoSize = true;
            this.lblCrtMachine.Location = new System.Drawing.Point(589, 25);
            this.lblCrtMachine.Name = "lblCrtMachine";
            this.lblCrtMachine.Size = new System.Drawing.Size(84, 16);
            this.lblCrtMachine.TabIndex = 30;
            this.lblCrtMachine.Text = "เครื่องที่สร้าง :";
            this.lblCrtMachine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtCrt
            // 
            this.dtCrt.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bdSource, "CRT_DATE", true));
            this.dtCrt.Date = null;
            this.dtCrt.DateValue = null;
            this.dtCrt.Enabled = false;
            this.dtCrt.IsRequired = false;
            this.dtCrt.Location = new System.Drawing.Point(406, 22);
            this.dtCrt.MaxLength = 10;
            this.dtCrt.MinLength = 0;
            this.dtCrt.Name = "dtCrt";
            this.dtCrt.ShowTime = true;
            this.dtCrt.Size = new System.Drawing.Size(150, 23);
            this.dtCrt.TabIndex = 27;
            this.dtCrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtCrt.TextValue = null;
            // 
            // lblCrtDate
            // 
            this.lblCrtDate.AutoSize = true;
            this.lblCrtDate.Location = new System.Drawing.Point(334, 25);
            this.lblCrtDate.Name = "lblCrtDate";
            this.lblCrtDate.Size = new System.Drawing.Size(66, 16);
            this.lblCrtDate.TabIndex = 28;
            this.lblCrtDate.Text = "วันที่สร้าง :";
            this.lblCrtDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RPT002_WorkPlaceAirQualityEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 692);
            this.MinimumSize = new System.Drawing.Size(600, 607);
            this.Name = "RPT002_WorkPlaceAirQualityEntry";
            this.Text = "RPT002: ข้อมูล Work Place Air Quality";
            this.OnSave += new System.EventHandler(this.RPT002_WorkPlaceAirQualityEntry_OnSave);
            this.OnDDPrint_Preview += new System.EventHandler(this.RPT002_WorkPlaceAirQualityEntry_OnDDPrint_Preview);
            this.OnDDPrint_Print += new System.EventHandler(this.RPT002_WorkPlaceAirQualityEntry_OnDDPrint_Print);
            this.OnDDPrint_PDF += new System.EventHandler(this.RPT002_WorkPlaceAirQualityEntry_OnDDPrint_PDF);
            this.OnDDPrint_Word += new System.EventHandler(this.RPT002_WorkPlaceAirQualityEntry_OnDDPrint_Word);
            this.OnDDPrint_Excel += new System.EventHandler(this.RPT002_WorkPlaceAirQualityEntry_OnDDPrint_Excel);
            this.OnDDPrint2_Excel += new System.EventHandler(this.RPT002_WorkPlaceAirQualityEntry_OnDDPrint2_Excel);
            this.OnCancel += new System.EventHandler(this.RPT002_WorkPlaceAirQualityEntry_OnCancel);
            this.OnRecovery += new System.EventHandler(this.RPT002_WorkPlaceAirQualityEntry_OnRecovery);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RPT002_WorkPlaceAirQualityEntry_FormClosing);
            this.Load += new System.EventHandler(this.RPT002_WorkPlaceAirQualityEntry_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.pnlAgent.ResumeLayout(false);
            this.pnlAgent.PerformLayout();
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BaseViews.rGroupBox gbHeader;
        private BaseViews.rLabel lblAnalysisNo;
        private BaseViews.rTextBox txtAnalysisNo;
        private BaseViews.rLabel lblReceivedDate;
        private BaseViews.rDateTextBox dtReceivedDate;
        private BaseViews.rLabel lblProject;
        private BaseViews.rLabel lblCustomer;
        private BaseViews.rLabel lblHeader;
        private BaseViews.rGroupBox gbHistory;
        private BaseViews.rTextBox txtDelId;
        private BaseViews.rLabel lblDelId;
        private BaseViews.rTextBox txtDelMachine;
        private BaseViews.rLabel lblDelMachine;
        private BaseViews.rDateTextBox dtDel;
        private BaseViews.rLabel lblDelDate;
        private BaseViews.rTextBox txtUpdId;
        private BaseViews.rLabel lblUpdId;
        private BaseViews.rTextBox txtUpdMachine;
        private BaseViews.rLabel lblUpdMachine;
        private BaseViews.rDateTextBox dtUpd;
        private BaseViews.rLabel lblUpdDate;
        private BaseViews.rTextBox txtCrtId;
        private BaseViews.rLabel lblCrtId;
        private BaseViews.rTextBox txtCrtMachine;
        private BaseViews.rLabel lblCrtMachine;
        private BaseViews.rDateTextBox dtCrt;
        private BaseViews.rLabel lblCrtDate;
        private BaseViews.rSearchTextBox txtCustomer;
        private BaseViews.rSearchTextBox txtProject;
        private BaseViews.rLabel lblAnalyticalDate;
        private BaseViews.rDateTextBox dtAnalyticalDate;
        private BaseViews.rSearchTextBox txtLabSupervisor;
        private BaseViews.rLabel lblLabSupervisor;
        private BaseViews.rSearchTextBox txtRegistration;
        private BaseViews.rLabel lblRegistration;
        private BaseViews.rDateTextBox dtAnalyticalDateTo;
        private BaseViews.rLabel lblAnalyticalDateTo;
        private System.Windows.Forms.CheckBox chkShowLv2Cont;
        private System.Windows.Forms.CheckBox chkShowLv3Cont;
        private System.Windows.Forms.CheckBox chkShowLv3EachPage;
        private BaseViews.rLabel lblReportDate;
        private BaseViews.rDateTextBox dtReportDate;
        private BaseViews.rLabel lblJobNo;
        private BaseViews.rTextBox txtJobNo;
        private System.Windows.Forms.RadioButton rdoAgent2;
        private System.Windows.Forms.RadioButton rdoAgent1;
        private BaseViews.rTextBox txtAgentName;
        private System.Windows.Forms.RadioButton rdoAWA;
        private System.Windows.Forms.RadioButton rdoWA;
        private System.Windows.Forms.Panel pnlAgent;
        private BaseViews.rButton btnUser;
        private BaseViews.rButton btnDetail;
        private System.Windows.Forms.CheckBox chkShowProjectAddr;
        private BaseViews.rTextBox txtProjectAddr;
        private BaseViews.rTextBox txtCustomerAddr;
    }
}