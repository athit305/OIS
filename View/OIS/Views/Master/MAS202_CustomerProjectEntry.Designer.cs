namespace OIS.Views
{
    partial class MAS202_CustomerProjectEntry
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
            this.bs = new System.Windows.Forms.BindingSource(this.components);
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
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.gbMain = new OIS.BaseViews.rGroupBox();
            this.txtCustomer = new OIS.BaseViews.rSearchTextBox();
            this.lblDefaultLanguage = new OIS.BaseViews.rLabel();
            this.lblCustomer = new OIS.BaseViews.rLabel();
            this.txtSeq = new OIS.BaseViews.rNumericTextBox();
            this.lblSeq = new OIS.BaseViews.rLabel();
            this.txtBuildingEn = new OIS.BaseViews.rTextBox();
            this.lblBuildingEn = new OIS.BaseViews.rLabel();
            this.lblBuildingTh = new OIS.BaseViews.rLabel();
            this.txtBuildingTh = new OIS.BaseViews.rTextBox();
            this.txtPostCode = new OIS.BaseViews.rTextBox();
            this.lblPostCode = new OIS.BaseViews.rLabel();
            this.txtDictrictEn = new OIS.BaseViews.rTextBox();
            this.txtSubDictrictEn = new OIS.BaseViews.rTextBox();
            this.txtRoadEn = new OIS.BaseViews.rTextBox();
            this.txtLaneEn = new OIS.BaseViews.rTextBox();
            this.txtAlleyEn = new OIS.BaseViews.rTextBox();
            this.txtMoo = new OIS.BaseViews.rTextBox();
            this.txtNameEn = new OIS.BaseViews.rTextBox();
            this.cboProvince = new OIS.BaseViews.rComboBox();
            this.lblProvince = new OIS.BaseViews.rLabel();
            this.lblDictrictEn = new OIS.BaseViews.rLabel();
            this.lblDictrictTh = new OIS.BaseViews.rLabel();
            this.txtDictrictTh = new OIS.BaseViews.rTextBox();
            this.lblSubDictrictEn = new OIS.BaseViews.rLabel();
            this.lblSubDictrictTh = new OIS.BaseViews.rLabel();
            this.txtSubDictrictTh = new OIS.BaseViews.rTextBox();
            this.lblRoadEn = new OIS.BaseViews.rLabel();
            this.lblRoadTh = new OIS.BaseViews.rLabel();
            this.txtRoadTh = new OIS.BaseViews.rTextBox();
            this.lblLaneEn = new OIS.BaseViews.rLabel();
            this.lblLaneTh = new OIS.BaseViews.rLabel();
            this.txtLaneTh = new OIS.BaseViews.rTextBox();
            this.lblAlleyEn = new OIS.BaseViews.rLabel();
            this.lblAlleyTh = new OIS.BaseViews.rLabel();
            this.txtAlleyTh = new OIS.BaseViews.rTextBox();
            this.rLabel1 = new OIS.BaseViews.rLabel();
            this.rLabel2 = new OIS.BaseViews.rLabel();
            this.txtAddrNo = new OIS.BaseViews.rTextBox();
            this.lblNameEn = new OIS.BaseViews.rLabel();
            this.lblNameTh = new OIS.BaseViews.rLabel();
            this.txtNameTh = new OIS.BaseViews.rTextBox();
            this.cboLanguage = new OIS.BaseViews.rComboBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.gbHistory.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbHistory);
            this.pnlMain.Controls.Add(this.lblHeader);
            this.pnlMain.Controls.Add(this.gbMain);
            this.pnlMain.Size = new System.Drawing.Size(1164, 638);
            // 
            // bs
            // 
            this.bs.DataSource = typeof(OIS.MAS.DTO.sp_MAS202_GetCustomerProject_Result);
            // 
            // gbHistory
            // 
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
            this.gbHistory.Location = new System.Drawing.Point(11, 393);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(846, 118);
            this.gbHistory.TabIndex = 19;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "ประวัติการบันทึก";
            // 
            // txtDelId
            // 
            this.txtDelId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "DEL_NAME", true));
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
            this.txtDelMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "DEL_MACHINE", true));
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
            this.dtDel.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bs, "DEL_DATE", true));
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
            this.txtUpdId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "UPD_NAME", true));
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
            this.txtUpdMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "UPD_MACHINE", true));
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
            this.dtUpd.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bs, "UPD_DATE", true));
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
            this.txtCrtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "CRT_NAME", true));
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
            this.txtCrtMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "CRT_MACHINE", true));
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
            this.dtCrt.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bs, "CRT_DATE", true));
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
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(312, 33);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "ข้อมูลโครงการของลูกค้า";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.cboLanguage);
            this.gbMain.Controls.Add(this.txtCustomer);
            this.gbMain.Controls.Add(this.lblDefaultLanguage);
            this.gbMain.Controls.Add(this.lblCustomer);
            this.gbMain.Controls.Add(this.txtSeq);
            this.gbMain.Controls.Add(this.lblSeq);
            this.gbMain.Controls.Add(this.txtBuildingEn);
            this.gbMain.Controls.Add(this.lblBuildingEn);
            this.gbMain.Controls.Add(this.lblBuildingTh);
            this.gbMain.Controls.Add(this.txtBuildingTh);
            this.gbMain.Controls.Add(this.txtPostCode);
            this.gbMain.Controls.Add(this.lblPostCode);
            this.gbMain.Controls.Add(this.txtDictrictEn);
            this.gbMain.Controls.Add(this.txtSubDictrictEn);
            this.gbMain.Controls.Add(this.txtRoadEn);
            this.gbMain.Controls.Add(this.txtLaneEn);
            this.gbMain.Controls.Add(this.txtAlleyEn);
            this.gbMain.Controls.Add(this.txtMoo);
            this.gbMain.Controls.Add(this.txtNameEn);
            this.gbMain.Controls.Add(this.cboProvince);
            this.gbMain.Controls.Add(this.lblProvince);
            this.gbMain.Controls.Add(this.lblDictrictEn);
            this.gbMain.Controls.Add(this.lblDictrictTh);
            this.gbMain.Controls.Add(this.txtDictrictTh);
            this.gbMain.Controls.Add(this.lblSubDictrictEn);
            this.gbMain.Controls.Add(this.lblSubDictrictTh);
            this.gbMain.Controls.Add(this.txtSubDictrictTh);
            this.gbMain.Controls.Add(this.lblRoadEn);
            this.gbMain.Controls.Add(this.lblRoadTh);
            this.gbMain.Controls.Add(this.txtRoadTh);
            this.gbMain.Controls.Add(this.lblLaneEn);
            this.gbMain.Controls.Add(this.lblLaneTh);
            this.gbMain.Controls.Add(this.txtLaneTh);
            this.gbMain.Controls.Add(this.lblAlleyEn);
            this.gbMain.Controls.Add(this.lblAlleyTh);
            this.gbMain.Controls.Add(this.txtAlleyTh);
            this.gbMain.Controls.Add(this.rLabel1);
            this.gbMain.Controls.Add(this.rLabel2);
            this.gbMain.Controls.Add(this.txtAddrNo);
            this.gbMain.Controls.Add(this.lblNameEn);
            this.gbMain.Controls.Add(this.lblNameTh);
            this.gbMain.Controls.Add(this.txtNameTh);
            this.gbMain.Location = new System.Drawing.Point(11, 36);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(846, 351);
            this.gbMain.TabIndex = 17;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "ข้อมูลทั่วไป";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomer.CausesValidation = false;
            this.txtCustomer.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.bs, "CUSTOMER_ID", true));
            this.txtCustomer.IntValue = null;
            this.txtCustomer.IsRequired = false;
            this.txtCustomer.Location = new System.Drawing.Point(124, 22);
            this.txtCustomer.MinLength = 0;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.OptionalTextBox = null;
            this.txtCustomer.SearchType = OIS.BaseViews.eSearchType.Customer;
            this.txtCustomer.Size = new System.Drawing.Size(665, 23);
            this.txtCustomer.StringValue = null;
            this.txtCustomer.TabIndex = 1;
            this.txtCustomer.TextValue = null;
            // 
            // lblDefaultLanguage
            // 
            this.lblDefaultLanguage.AutoSize = true;
            this.lblDefaultLanguage.Location = new System.Drawing.Point(71, 316);
            this.lblDefaultLanguage.Name = "lblDefaultLanguage";
            this.lblDefaultLanguage.Size = new System.Drawing.Size(47, 16);
            this.lblDefaultLanguage.TabIndex = 92;
            this.lblDefaultLanguage.Text = "ภาษา :";
            this.lblDefaultLanguage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(71, 25);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(47, 16);
            this.lblCustomer.TabIndex = 70;
            this.lblCustomer.Text = "ลูกค้า :";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSeq
            // 
            this.txtSeq.CausesValidation = false;
            this.txtSeq.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs, "SEQ", true));
            this.txtSeq.DecimalPlace = 0;
            this.txtSeq.DecimalValue = null;
            this.txtSeq.IsRequired = true;
            this.txtSeq.Location = new System.Drawing.Point(721, 284);
            this.txtSeq.MinLength = 0;
            this.txtSeq.MinValue = null;
            this.txtSeq.Name = "txtSeq";
            this.txtSeq.NullableDecimalValue = null;
            this.txtSeq.NullableIntValue = null;
            this.txtSeq.Size = new System.Drawing.Size(68, 23);
            this.txtSeq.TabIndex = 19;
            this.txtSeq.TextValue = null;
            // 
            // lblSeq
            // 
            this.lblSeq.AutoSize = true;
            this.lblSeq.Location = new System.Drawing.Point(668, 287);
            this.lblSeq.Name = "lblSeq";
            this.lblSeq.Size = new System.Drawing.Size(47, 16);
            this.lblSeq.TabIndex = 68;
            this.lblSeq.Text = "ลำดับ :";
            this.lblSeq.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBuildingEn
            // 
            this.txtBuildingEn.CausesValidation = false;
            this.txtBuildingEn.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "BUILDING_EN", true));
            this.txtBuildingEn.IsRequired = false;
            this.txtBuildingEn.Location = new System.Drawing.Point(539, 110);
            this.txtBuildingEn.MinLength = 0;
            this.txtBuildingEn.Name = "txtBuildingEn";
            this.txtBuildingEn.Size = new System.Drawing.Size(250, 23);
            this.txtBuildingEn.TabIndex = 6;
            this.txtBuildingEn.TextValue = null;
            // 
            // lblBuildingEn
            // 
            this.lblBuildingEn.AutoSize = true;
            this.lblBuildingEn.Location = new System.Drawing.Point(433, 113);
            this.lblBuildingEn.Name = "lblBuildingEn";
            this.lblBuildingEn.Size = new System.Drawing.Size(100, 16);
            this.lblBuildingEn.TabIndex = 65;
            this.lblBuildingEn.Text = "อาคาร(อังกฤษ) :";
            this.lblBuildingEn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBuildingTh
            // 
            this.lblBuildingTh.AutoSize = true;
            this.lblBuildingTh.Location = new System.Drawing.Point(33, 113);
            this.lblBuildingTh.Name = "lblBuildingTh";
            this.lblBuildingTh.Size = new System.Drawing.Size(85, 16);
            this.lblBuildingTh.TabIndex = 64;
            this.lblBuildingTh.Text = "อาคาร(ไทย) :";
            this.lblBuildingTh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBuildingTh
            // 
            this.txtBuildingTh.CausesValidation = false;
            this.txtBuildingTh.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "BUILDING_TH", true));
            this.txtBuildingTh.IsRequired = false;
            this.txtBuildingTh.Location = new System.Drawing.Point(124, 110);
            this.txtBuildingTh.MinLength = 0;
            this.txtBuildingTh.Name = "txtBuildingTh";
            this.txtBuildingTh.Size = new System.Drawing.Size(250, 23);
            this.txtBuildingTh.TabIndex = 5;
            this.txtBuildingTh.TextValue = null;
            // 
            // txtPostCode
            // 
            this.txtPostCode.CausesValidation = false;
            this.txtPostCode.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "POSTCODE", true));
            this.txtPostCode.IsRequired = false;
            this.txtPostCode.Location = new System.Drawing.Point(539, 284);
            this.txtPostCode.MaxLength = 5;
            this.txtPostCode.MinLength = 5;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(123, 23);
            this.txtPostCode.TabIndex = 18;
            this.txtPostCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPostCode.TextValue = null;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(444, 287);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(89, 16);
            this.lblPostCode.TabIndex = 61;
            this.lblPostCode.Text = "รหัสไปรษณีย์ :";
            this.lblPostCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDictrictEn
            // 
            this.txtDictrictEn.CausesValidation = false;
            this.txtDictrictEn.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "DISTRICT_EN", true));
            this.txtDictrictEn.IsRequired = false;
            this.txtDictrictEn.Location = new System.Drawing.Point(539, 255);
            this.txtDictrictEn.MinLength = 0;
            this.txtDictrictEn.Name = "txtDictrictEn";
            this.txtDictrictEn.Size = new System.Drawing.Size(250, 23);
            this.txtDictrictEn.TabIndex = 16;
            this.txtDictrictEn.TextValue = null;
            // 
            // txtSubDictrictEn
            // 
            this.txtSubDictrictEn.CausesValidation = false;
            this.txtSubDictrictEn.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "SUBDISTRICT_EN", true));
            this.txtSubDictrictEn.IsRequired = false;
            this.txtSubDictrictEn.Location = new System.Drawing.Point(539, 226);
            this.txtSubDictrictEn.MinLength = 0;
            this.txtSubDictrictEn.Name = "txtSubDictrictEn";
            this.txtSubDictrictEn.Size = new System.Drawing.Size(250, 23);
            this.txtSubDictrictEn.TabIndex = 14;
            this.txtSubDictrictEn.TextValue = null;
            // 
            // txtRoadEn
            // 
            this.txtRoadEn.CausesValidation = false;
            this.txtRoadEn.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "ROAD_EN", true));
            this.txtRoadEn.IsRequired = false;
            this.txtRoadEn.Location = new System.Drawing.Point(539, 197);
            this.txtRoadEn.MinLength = 0;
            this.txtRoadEn.Name = "txtRoadEn";
            this.txtRoadEn.Size = new System.Drawing.Size(250, 23);
            this.txtRoadEn.TabIndex = 12;
            this.txtRoadEn.TextValue = null;
            // 
            // txtLaneEn
            // 
            this.txtLaneEn.CausesValidation = false;
            this.txtLaneEn.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "LANE_EN", true));
            this.txtLaneEn.IsRequired = false;
            this.txtLaneEn.Location = new System.Drawing.Point(539, 168);
            this.txtLaneEn.MinLength = 0;
            this.txtLaneEn.Name = "txtLaneEn";
            this.txtLaneEn.Size = new System.Drawing.Size(250, 23);
            this.txtLaneEn.TabIndex = 10;
            this.txtLaneEn.TextValue = null;
            // 
            // txtAlleyEn
            // 
            this.txtAlleyEn.CausesValidation = false;
            this.txtAlleyEn.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "ALLEY_EN", true));
            this.txtAlleyEn.IsRequired = false;
            this.txtAlleyEn.Location = new System.Drawing.Point(539, 139);
            this.txtAlleyEn.MinLength = 0;
            this.txtAlleyEn.Name = "txtAlleyEn";
            this.txtAlleyEn.Size = new System.Drawing.Size(250, 23);
            this.txtAlleyEn.TabIndex = 8;
            this.txtAlleyEn.TextValue = null;
            // 
            // txtMoo
            // 
            this.txtMoo.CausesValidation = false;
            this.txtMoo.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "MOO", true));
            this.txtMoo.IsRequired = false;
            this.txtMoo.Location = new System.Drawing.Point(539, 81);
            this.txtMoo.MinLength = 0;
            this.txtMoo.Name = "txtMoo";
            this.txtMoo.Size = new System.Drawing.Size(250, 23);
            this.txtMoo.TabIndex = 4;
            this.txtMoo.TextValue = null;
            // 
            // txtNameEn
            // 
            this.txtNameEn.CausesValidation = false;
            this.txtNameEn.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "NAME_EN", true));
            this.txtNameEn.IsRequired = true;
            this.txtNameEn.Location = new System.Drawing.Point(539, 52);
            this.txtNameEn.MinLength = 0;
            this.txtNameEn.Name = "txtNameEn";
            this.txtNameEn.Size = new System.Drawing.Size(250, 23);
            this.txtNameEn.TabIndex = 2;
            this.txtNameEn.TextValue = null;
            // 
            // cboProvince
            // 
            this.cboProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboProvince.CausesValidation = false;
            this.cboProvince.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs, "PROVINCE_ID", true));
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.IsRequired = false;
            this.cboProvince.Location = new System.Drawing.Point(124, 284);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.NullableIntValue = null;
            this.cboProvince.Size = new System.Drawing.Size(250, 24);
            this.cboProvince.StringValue = null;
            this.cboProvince.TabIndex = 17;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(66, 287);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 16);
            this.lblProvince.TabIndex = 53;
            this.lblProvince.Text = "จังหวัด :";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDictrictEn
            // 
            this.lblDictrictEn.AutoSize = true;
            this.lblDictrictEn.Location = new System.Drawing.Point(408, 258);
            this.lblDictrictEn.Name = "lblDictrictEn";
            this.lblDictrictEn.Size = new System.Drawing.Size(125, 16);
            this.lblDictrictEn.TabIndex = 51;
            this.lblDictrictEn.Text = "อำเภอ/เขต(อังกฤษ) :";
            this.lblDictrictEn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDictrictTh
            // 
            this.lblDictrictTh.AutoSize = true;
            this.lblDictrictTh.Location = new System.Drawing.Point(8, 258);
            this.lblDictrictTh.Name = "lblDictrictTh";
            this.lblDictrictTh.Size = new System.Drawing.Size(110, 16);
            this.lblDictrictTh.TabIndex = 50;
            this.lblDictrictTh.Text = "อำเภอ/เขต(ไทย) :";
            this.lblDictrictTh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDictrictTh
            // 
            this.txtDictrictTh.CausesValidation = false;
            this.txtDictrictTh.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "DISTRICT_TH", true));
            this.txtDictrictTh.IsRequired = false;
            this.txtDictrictTh.Location = new System.Drawing.Point(124, 255);
            this.txtDictrictTh.MinLength = 0;
            this.txtDictrictTh.Name = "txtDictrictTh";
            this.txtDictrictTh.Size = new System.Drawing.Size(250, 23);
            this.txtDictrictTh.TabIndex = 15;
            this.txtDictrictTh.TextValue = null;
            // 
            // lblSubDictrictEn
            // 
            this.lblSubDictrictEn.AutoSize = true;
            this.lblSubDictrictEn.Location = new System.Drawing.Point(404, 229);
            this.lblSubDictrictEn.Name = "lblSubDictrictEn";
            this.lblSubDictrictEn.Size = new System.Drawing.Size(129, 16);
            this.lblSubDictrictEn.TabIndex = 47;
            this.lblSubDictrictEn.Text = "ตำบล/แขวง(อังกฤษ) :";
            this.lblSubDictrictEn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSubDictrictTh
            // 
            this.lblSubDictrictTh.AutoSize = true;
            this.lblSubDictrictTh.Location = new System.Drawing.Point(4, 229);
            this.lblSubDictrictTh.Name = "lblSubDictrictTh";
            this.lblSubDictrictTh.Size = new System.Drawing.Size(114, 16);
            this.lblSubDictrictTh.TabIndex = 46;
            this.lblSubDictrictTh.Text = "ตำบล/แขวง(ไทย) :";
            this.lblSubDictrictTh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSubDictrictTh
            // 
            this.txtSubDictrictTh.CausesValidation = false;
            this.txtSubDictrictTh.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "SUBDISTRICT_TH", true));
            this.txtSubDictrictTh.IsRequired = false;
            this.txtSubDictrictTh.Location = new System.Drawing.Point(124, 226);
            this.txtSubDictrictTh.MinLength = 0;
            this.txtSubDictrictTh.Name = "txtSubDictrictTh";
            this.txtSubDictrictTh.Size = new System.Drawing.Size(250, 23);
            this.txtSubDictrictTh.TabIndex = 13;
            this.txtSubDictrictTh.TextValue = null;
            // 
            // lblRoadEn
            // 
            this.lblRoadEn.AutoSize = true;
            this.lblRoadEn.Location = new System.Drawing.Point(443, 200);
            this.lblRoadEn.Name = "lblRoadEn";
            this.lblRoadEn.Size = new System.Drawing.Size(90, 16);
            this.lblRoadEn.TabIndex = 43;
            this.lblRoadEn.Text = "ถนน(อังกฤษ) :";
            this.lblRoadEn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRoadTh
            // 
            this.lblRoadTh.AutoSize = true;
            this.lblRoadTh.Location = new System.Drawing.Point(43, 200);
            this.lblRoadTh.Name = "lblRoadTh";
            this.lblRoadTh.Size = new System.Drawing.Size(75, 16);
            this.lblRoadTh.TabIndex = 42;
            this.lblRoadTh.Text = "ถนน(ไทย) :";
            this.lblRoadTh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRoadTh
            // 
            this.txtRoadTh.CausesValidation = false;
            this.txtRoadTh.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "ROAD_TH", true));
            this.txtRoadTh.IsRequired = false;
            this.txtRoadTh.Location = new System.Drawing.Point(124, 197);
            this.txtRoadTh.MinLength = 0;
            this.txtRoadTh.Name = "txtRoadTh";
            this.txtRoadTh.Size = new System.Drawing.Size(250, 23);
            this.txtRoadTh.TabIndex = 11;
            this.txtRoadTh.TextValue = null;
            // 
            // lblLaneEn
            // 
            this.lblLaneEn.AutoSize = true;
            this.lblLaneEn.Location = new System.Drawing.Point(442, 171);
            this.lblLaneEn.Name = "lblLaneEn";
            this.lblLaneEn.Size = new System.Drawing.Size(91, 16);
            this.lblLaneEn.TabIndex = 39;
            this.lblLaneEn.Text = "ซอย(อังกฤษ) :";
            this.lblLaneEn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLaneTh
            // 
            this.lblLaneTh.AutoSize = true;
            this.lblLaneTh.Location = new System.Drawing.Point(42, 171);
            this.lblLaneTh.Name = "lblLaneTh";
            this.lblLaneTh.Size = new System.Drawing.Size(76, 16);
            this.lblLaneTh.TabIndex = 38;
            this.lblLaneTh.Text = "ซอย(ไทย) :";
            this.lblLaneTh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLaneTh
            // 
            this.txtLaneTh.CausesValidation = false;
            this.txtLaneTh.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "LANE_TH", true));
            this.txtLaneTh.IsRequired = false;
            this.txtLaneTh.Location = new System.Drawing.Point(124, 168);
            this.txtLaneTh.MinLength = 0;
            this.txtLaneTh.Name = "txtLaneTh";
            this.txtLaneTh.Size = new System.Drawing.Size(250, 23);
            this.txtLaneTh.TabIndex = 9;
            this.txtLaneTh.TextValue = null;
            // 
            // lblAlleyEn
            // 
            this.lblAlleyEn.AutoSize = true;
            this.lblAlleyEn.Location = new System.Drawing.Point(437, 142);
            this.lblAlleyEn.Name = "lblAlleyEn";
            this.lblAlleyEn.Size = new System.Drawing.Size(96, 16);
            this.lblAlleyEn.TabIndex = 35;
            this.lblAlleyEn.Text = "ตรอก(อังกฤษ) :";
            this.lblAlleyEn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAlleyTh
            // 
            this.lblAlleyTh.AutoSize = true;
            this.lblAlleyTh.Location = new System.Drawing.Point(37, 142);
            this.lblAlleyTh.Name = "lblAlleyTh";
            this.lblAlleyTh.Size = new System.Drawing.Size(81, 16);
            this.lblAlleyTh.TabIndex = 34;
            this.lblAlleyTh.Text = "ตรอก(ไทย) :";
            this.lblAlleyTh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAlleyTh
            // 
            this.txtAlleyTh.CausesValidation = false;
            this.txtAlleyTh.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "ALLEY_TH", true));
            this.txtAlleyTh.IsRequired = false;
            this.txtAlleyTh.Location = new System.Drawing.Point(124, 139);
            this.txtAlleyTh.MinLength = 0;
            this.txtAlleyTh.Name = "txtAlleyTh";
            this.txtAlleyTh.Size = new System.Drawing.Size(250, 23);
            this.txtAlleyTh.TabIndex = 7;
            this.txtAlleyTh.TextValue = null;
            // 
            // rLabel1
            // 
            this.rLabel1.AutoSize = true;
            this.rLabel1.Location = new System.Drawing.Point(491, 84);
            this.rLabel1.Name = "rLabel1";
            this.rLabel1.Size = new System.Drawing.Size(42, 16);
            this.rLabel1.TabIndex = 31;
            this.rLabel1.Text = "หมู่ที่ :";
            this.rLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rLabel2
            // 
            this.rLabel2.AutoSize = true;
            this.rLabel2.Location = new System.Drawing.Point(72, 84);
            this.rLabel2.Name = "rLabel2";
            this.rLabel2.Size = new System.Drawing.Size(46, 16);
            this.rLabel2.TabIndex = 30;
            this.rLabel2.Text = "เลขที่ :";
            this.rLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAddrNo
            // 
            this.txtAddrNo.CausesValidation = false;
            this.txtAddrNo.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "ADDR_NO", true));
            this.txtAddrNo.IsRequired = false;
            this.txtAddrNo.Location = new System.Drawing.Point(124, 81);
            this.txtAddrNo.MinLength = 0;
            this.txtAddrNo.Name = "txtAddrNo";
            this.txtAddrNo.Size = new System.Drawing.Size(250, 23);
            this.txtAddrNo.TabIndex = 3;
            this.txtAddrNo.TextValue = null;
            // 
            // lblNameEn
            // 
            this.lblNameEn.AutoSize = true;
            this.lblNameEn.Location = new System.Drawing.Point(408, 55);
            this.lblNameEn.Name = "lblNameEn";
            this.lblNameEn.Size = new System.Drawing.Size(128, 16);
            this.lblNameEn.TabIndex = 27;
            this.lblNameEn.Text = "ชื่อโครงการ(อังกฤษ) :";
            this.lblNameEn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNameTh
            // 
            this.lblNameTh.AutoSize = true;
            this.lblNameTh.Location = new System.Drawing.Point(5, 55);
            this.lblNameTh.Name = "lblNameTh";
            this.lblNameTh.Size = new System.Drawing.Size(113, 16);
            this.lblNameTh.TabIndex = 26;
            this.lblNameTh.Text = "ชื่อโครงการ(ไทย) :";
            this.lblNameTh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNameTh
            // 
            this.txtNameTh.CausesValidation = false;
            this.txtNameTh.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs, "NAME_TH", true));
            this.txtNameTh.IsRequired = true;
            this.txtNameTh.Location = new System.Drawing.Point(124, 52);
            this.txtNameTh.MinLength = 0;
            this.txtNameTh.Name = "txtNameTh";
            this.txtNameTh.Size = new System.Drawing.Size(250, 23);
            this.txtNameTh.TabIndex = 1;
            this.txtNameTh.TextValue = null;
            // 
            // cboLanguage
            // 
            this.cboLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboLanguage.DataBindings.Add(new System.Windows.Forms.Binding("StringValue", this.bs, "DEFAULT_LANGUAGE", true));
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.IsRequired = true;
            this.cboLanguage.Location = new System.Drawing.Point(124, 314);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.NullableIntValue = null;
            this.cboLanguage.Size = new System.Drawing.Size(250, 24);
            this.cboLanguage.StringValue = null;
            this.cboLanguage.TabIndex = 93;
            // 
            // MAS202_CustomerProjectEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1164, 692);
            this.Name = "MAS202_CustomerProjectEntry";
            this.Text = "MAS202: ข้อมูลโครงการของลูกค้า";
            this.OnSave += new System.EventHandler(this.MAS202_CustomerProjectEntry_OnSave);
            this.OnCancel += new System.EventHandler(this.MAS202_CustomerProjectEntry_OnCancel);
            this.OnRecovery += new System.EventHandler(this.MAS202_CustomerProjectEntry_OnRecovery);
            this.Load += new System.EventHandler(this.MAS202_CustomerProjectEntry_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
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
        private BaseViews.rLabel lblHeader;
        private BaseViews.rGroupBox gbMain;
        private BaseViews.rNumericTextBox txtSeq;
        private BaseViews.rLabel lblSeq;
        private BaseViews.rTextBox txtBuildingEn;
        private BaseViews.rLabel lblBuildingEn;
        private BaseViews.rLabel lblBuildingTh;
        private BaseViews.rTextBox txtBuildingTh;
        private BaseViews.rTextBox txtPostCode;
        private BaseViews.rLabel lblPostCode;
        private BaseViews.rTextBox txtDictrictEn;
        private BaseViews.rTextBox txtSubDictrictEn;
        private BaseViews.rTextBox txtRoadEn;
        private BaseViews.rTextBox txtLaneEn;
        private BaseViews.rTextBox txtAlleyEn;
        private BaseViews.rTextBox txtMoo;
        private BaseViews.rTextBox txtNameEn;
        private BaseViews.rComboBox cboProvince;
        private BaseViews.rLabel lblProvince;
        private BaseViews.rLabel lblDictrictEn;
        private BaseViews.rLabel lblDictrictTh;
        private BaseViews.rTextBox txtDictrictTh;
        private BaseViews.rLabel lblSubDictrictEn;
        private BaseViews.rLabel lblSubDictrictTh;
        private BaseViews.rTextBox txtSubDictrictTh;
        private BaseViews.rLabel lblRoadEn;
        private BaseViews.rLabel lblRoadTh;
        private BaseViews.rTextBox txtRoadTh;
        private BaseViews.rLabel lblLaneEn;
        private BaseViews.rLabel lblLaneTh;
        private BaseViews.rTextBox txtLaneTh;
        private BaseViews.rLabel lblAlleyEn;
        private BaseViews.rLabel lblAlleyTh;
        private BaseViews.rTextBox txtAlleyTh;
        private BaseViews.rLabel rLabel1;
        private BaseViews.rLabel rLabel2;
        private BaseViews.rTextBox txtAddrNo;
        private BaseViews.rLabel lblNameEn;
        private BaseViews.rLabel lblNameTh;
        private BaseViews.rTextBox txtNameTh;
        private BaseViews.rLabel lblCustomer;
        private BaseViews.rLabel lblDefaultLanguage;
        private BaseViews.rSearchTextBox txtCustomer;
        private BaseViews.rComboBox cboLanguage;
    }
}