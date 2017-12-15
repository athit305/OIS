namespace OIS.Views
{
    partial class MAS305_ParameterAnalysisEntry
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
            this.gbMain = new OIS.BaseViews.rGroupBox();
            this.lblMRLValue = new OIS.BaseViews.rLabel();
            this.txtMRLValue = new OIS.BaseViews.rNumericTextBox();
            this.lblLabExt = new OIS.BaseViews.rLabel();
            this.txtSeq = new OIS.BaseViews.rNumericTextBox();
            this.lblSeq = new OIS.BaseViews.rLabel();
            this.cboLabExt = new OIS.BaseViews.rComboBox();
            this.lblAnalysisDetail = new OIS.BaseViews.rLabel();
            this.lblMethodRemark = new OIS.BaseViews.rLabel();
            this.lblMethodRef = new OIS.BaseViews.rLabel();
            this.txtMethodRef = new OIS.BaseViews.rTextBox();
            this.txtMethodRemark = new OIS.BaseViews.rTextBox();
            this.txtAnalysisDetail = new OIS.BaseViews.rTextBox();
            this.chkCeilingLimit = new System.Windows.Forms.CheckBox();
            this.lblStandardACGIH = new OIS.BaseViews.rLabel();
            this.txtStandardACGIH = new OIS.BaseViews.rNumericTextBox();
            this.lblStandardThai = new OIS.BaseViews.rLabel();
            this.txtStandardThai = new OIS.BaseViews.rNumericTextBox();
            this.lblToolAnalysis = new OIS.BaseViews.rLabel();
            this.txtToolAnalysis = new OIS.BaseViews.rSearchTextBox();
            this.lblToolPick = new OIS.BaseViews.rLabel();
            this.txtToolPick = new OIS.BaseViews.rSearchTextBox();
            this.lblMethod = new OIS.BaseViews.rLabel();
            this.txtMethod = new OIS.BaseViews.rSearchTextBox();
            this.lblUnit = new OIS.BaseViews.rLabel();
            this.cboUnit = new OIS.BaseViews.rComboBox();
            this.lblName = new OIS.BaseViews.rLabel();
            this.txtName = new OIS.BaseViews.rTextBox();
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            this.gbHistory.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbHistory);
            this.pnlMain.Controls.Add(this.gbMain);
            this.pnlMain.Controls.Add(this.lblHeader);
            this.pnlMain.TabIndex = 7;
            // 
            // bdSource
            // 
            this.bdSource.DataSource = typeof(OIS.MAS.DTO.sp_MAS305_GetParameterAnalysis_Result);
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
            this.gbHistory.Location = new System.Drawing.Point(9, 367);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(846, 118);
            this.gbHistory.TabIndex = 21;
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
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lblMRLValue);
            this.gbMain.Controls.Add(this.txtMRLValue);
            this.gbMain.Controls.Add(this.lblLabExt);
            this.gbMain.Controls.Add(this.txtSeq);
            this.gbMain.Controls.Add(this.lblSeq);
            this.gbMain.Controls.Add(this.cboLabExt);
            this.gbMain.Controls.Add(this.lblAnalysisDetail);
            this.gbMain.Controls.Add(this.lblMethodRemark);
            this.gbMain.Controls.Add(this.lblMethodRef);
            this.gbMain.Controls.Add(this.txtMethodRef);
            this.gbMain.Controls.Add(this.txtMethodRemark);
            this.gbMain.Controls.Add(this.txtAnalysisDetail);
            this.gbMain.Controls.Add(this.chkCeilingLimit);
            this.gbMain.Controls.Add(this.lblStandardACGIH);
            this.gbMain.Controls.Add(this.txtStandardACGIH);
            this.gbMain.Controls.Add(this.lblStandardThai);
            this.gbMain.Controls.Add(this.txtStandardThai);
            this.gbMain.Controls.Add(this.lblToolAnalysis);
            this.gbMain.Controls.Add(this.txtToolAnalysis);
            this.gbMain.Controls.Add(this.lblToolPick);
            this.gbMain.Controls.Add(this.txtToolPick);
            this.gbMain.Controls.Add(this.lblMethod);
            this.gbMain.Controls.Add(this.txtMethod);
            this.gbMain.Controls.Add(this.lblUnit);
            this.gbMain.Controls.Add(this.cboUnit);
            this.gbMain.Controls.Add(this.lblName);
            this.gbMain.Controls.Add(this.txtName);
            this.gbMain.Location = new System.Drawing.Point(11, 36);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(844, 325);
            this.gbMain.TabIndex = 20;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "ข้อมูลทั่วไป";
            // 
            // lblMRLValue
            // 
            this.lblMRLValue.AutoSize = true;
            this.lblMRLValue.Location = new System.Drawing.Point(118, 266);
            this.lblMRLValue.Name = "lblMRLValue";
            this.lblMRLValue.Size = new System.Drawing.Size(41, 16);
            this.lblMRLValue.TabIndex = 82;
            this.lblMRLValue.Text = "MRL :";
            this.lblMRLValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMRLValue
            // 
            this.txtMRLValue.DataBindings.Add(new System.Windows.Forms.Binding("NullableDecimalValue", this.bdSource, "MRL_VALUE", true));
            this.txtMRLValue.DecimalPlace = 3;
            this.txtMRLValue.DecimalValue = null;
            this.txtMRLValue.IsRequired = false;
            this.txtMRLValue.Location = new System.Drawing.Point(165, 263);
            this.txtMRLValue.MinLength = 0;
            this.txtMRLValue.MinValue = null;
            this.txtMRLValue.Name = "txtMRLValue";
            this.txtMRLValue.NullableDecimalValue = null;
            this.txtMRLValue.NullableIntValue = null;
            this.txtMRLValue.Size = new System.Drawing.Size(250, 23);
            this.txtMRLValue.TabIndex = 12;
            this.txtMRLValue.TextValue = null;
            // 
            // lblLabExt
            // 
            this.lblLabExt.AutoSize = true;
            this.lblLabExt.Location = new System.Drawing.Point(68, 178);
            this.lblLabExt.Name = "lblLabExt";
            this.lblLabExt.Size = new System.Drawing.Size(91, 16);
            this.lblLabExt.TabIndex = 80;
            this.lblLabExt.Text = "ห้องปฏิบัติการ :";
            this.lblLabExt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSeq
            // 
            this.txtSeq.CausesValidation = false;
            this.txtSeq.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bdSource, "SEQ", true));
            this.txtSeq.DecimalPlace = 0;
            this.txtSeq.DecimalValue = null;
            this.txtSeq.IsRequired = true;
            this.txtSeq.Location = new System.Drawing.Point(165, 292);
            this.txtSeq.MinLength = 0;
            this.txtSeq.MinValue = null;
            this.txtSeq.Name = "txtSeq";
            this.txtSeq.NullableDecimalValue = null;
            this.txtSeq.NullableIntValue = null;
            this.txtSeq.Size = new System.Drawing.Size(100, 23);
            this.txtSeq.TabIndex = 14;
            this.txtSeq.TextValue = null;
            // 
            // lblSeq
            // 
            this.lblSeq.AutoSize = true;
            this.lblSeq.Location = new System.Drawing.Point(112, 295);
            this.lblSeq.Name = "lblSeq";
            this.lblSeq.Size = new System.Drawing.Size(47, 16);
            this.lblSeq.TabIndex = 23;
            this.lblSeq.Text = "ลำดับ :";
            this.lblSeq.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboLabExt
            // 
            this.cboLabExt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboLabExt.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bdSource, "LAB_EXT_ID", true));
            this.cboLabExt.FormattingEnabled = true;
            this.cboLabExt.IsRequired = true;
            this.cboLabExt.Location = new System.Drawing.Point(165, 175);
            this.cboLabExt.Name = "cboLabExt";
            this.cboLabExt.NullableIntValue = null;
            this.cboLabExt.Size = new System.Drawing.Size(250, 24);
            this.cboLabExt.StringValue = null;
            this.cboLabExt.TabIndex = 6;
            // 
            // lblAnalysisDetail
            // 
            this.lblAnalysisDetail.AutoSize = true;
            this.lblAnalysisDetail.Location = new System.Drawing.Point(23, 112);
            this.lblAnalysisDetail.Name = "lblAnalysisDetail";
            this.lblAnalysisDetail.Size = new System.Drawing.Size(136, 16);
            this.lblAnalysisDetail.TabIndex = 78;
            this.lblAnalysisDetail.Text = "รายละเอียดวิธีวิเคราะห์ :";
            this.lblAnalysisDetail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMethodRemark
            // 
            this.lblMethodRemark.AutoSize = true;
            this.lblMethodRemark.Location = new System.Drawing.Point(27, 83);
            this.lblMethodRemark.Name = "lblMethodRemark";
            this.lblMethodRemark.Size = new System.Drawing.Size(132, 16);
            this.lblMethodRemark.TabIndex = 77;
            this.lblMethodRemark.Text = "เครื่องมือที่ใช้วิเคราะห์ :";
            this.lblMethodRemark.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMethodRef
            // 
            this.lblMethodRef.AutoSize = true;
            this.lblMethodRef.Location = new System.Drawing.Point(446, 54);
            this.lblMethodRef.Name = "lblMethodRef";
            this.lblMethodRef.Size = new System.Drawing.Size(97, 16);
            this.lblMethodRef.TabIndex = 76;
            this.lblMethodRef.Text = "Method อ้างอิง :";
            this.lblMethodRef.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMethodRef
            // 
            this.txtMethodRef.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bdSource, "METHOD_REF", true));
            this.txtMethodRef.IsRequired = false;
            this.txtMethodRef.Location = new System.Drawing.Point(549, 51);
            this.txtMethodRef.MinLength = 0;
            this.txtMethodRef.Name = "txtMethodRef";
            this.txtMethodRef.Size = new System.Drawing.Size(250, 23);
            this.txtMethodRef.TabIndex = 3;
            this.txtMethodRef.TextValue = null;
            // 
            // txtMethodRemark
            // 
            this.txtMethodRemark.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bdSource, "METHOD_REMARK", true));
            this.txtMethodRemark.IsRequired = false;
            this.txtMethodRemark.Location = new System.Drawing.Point(165, 80);
            this.txtMethodRemark.MinLength = 0;
            this.txtMethodRemark.Name = "txtMethodRemark";
            this.txtMethodRemark.Size = new System.Drawing.Size(634, 23);
            this.txtMethodRemark.TabIndex = 4;
            this.txtMethodRemark.TextValue = null;
            // 
            // txtAnalysisDetail
            // 
            this.txtAnalysisDetail.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bdSource, "ANALYSIS_DETAIL", true));
            this.txtAnalysisDetail.IsRequired = false;
            this.txtAnalysisDetail.Location = new System.Drawing.Point(165, 109);
            this.txtAnalysisDetail.MinLength = 0;
            this.txtAnalysisDetail.Multiline = true;
            this.txtAnalysisDetail.Name = "txtAnalysisDetail";
            this.txtAnalysisDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnalysisDetail.Size = new System.Drawing.Size(634, 60);
            this.txtAnalysisDetail.TabIndex = 5;
            this.txtAnalysisDetail.TextValue = null;
            // 
            // chkCeilingLimit
            // 
            this.chkCeilingLimit.AutoSize = true;
            this.chkCeilingLimit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdSource, "CEILING_LIMIT", true));
            this.chkCeilingLimit.Location = new System.Drawing.Point(549, 265);
            this.chkCeilingLimit.Name = "chkCeilingLimit";
            this.chkCeilingLimit.Size = new System.Drawing.Size(118, 20);
            this.chkCeilingLimit.TabIndex = 13;
            this.chkCeilingLimit.Text = "Ceiling Limit (C)";
            this.chkCeilingLimit.UseVisualStyleBackColor = true;
            // 
            // lblStandardACGIH
            // 
            this.lblStandardACGIH.AutoSize = true;
            this.lblStandardACGIH.Location = new System.Drawing.Point(434, 237);
            this.lblStandardACGIH.Name = "lblStandardACGIH";
            this.lblStandardACGIH.Size = new System.Drawing.Size(109, 16);
            this.lblStandardACGIH.TabIndex = 72;
            this.lblStandardACGIH.Text = "Standard ACGIH :";
            this.lblStandardACGIH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtStandardACGIH
            // 
            this.txtStandardACGIH.DataBindings.Add(new System.Windows.Forms.Binding("NullableDecimalValue", this.bdSource, "STANDARD_ACGIH", true));
            this.txtStandardACGIH.DecimalPlace = 2;
            this.txtStandardACGIH.DecimalValue = null;
            this.txtStandardACGIH.IsRequired = false;
            this.txtStandardACGIH.Location = new System.Drawing.Point(549, 234);
            this.txtStandardACGIH.MinLength = 0;
            this.txtStandardACGIH.MinValue = null;
            this.txtStandardACGIH.Name = "txtStandardACGIH";
            this.txtStandardACGIH.NullableDecimalValue = null;
            this.txtStandardACGIH.NullableIntValue = null;
            this.txtStandardACGIH.Size = new System.Drawing.Size(250, 23);
            this.txtStandardACGIH.TabIndex = 11;
            this.txtStandardACGIH.TextValue = null;
            // 
            // lblStandardThai
            // 
            this.lblStandardThai.AutoSize = true;
            this.lblStandardThai.Location = new System.Drawing.Point(61, 237);
            this.lblStandardThai.Name = "lblStandardThai";
            this.lblStandardThai.Size = new System.Drawing.Size(98, 16);
            this.lblStandardThai.TabIndex = 70;
            this.lblStandardThai.Text = "Standard Thai :";
            this.lblStandardThai.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtStandardThai
            // 
            this.txtStandardThai.DataBindings.Add(new System.Windows.Forms.Binding("NullableDecimalValue", this.bdSource, "STANDARD_THAI", true));
            this.txtStandardThai.DecimalPlace = 2;
            this.txtStandardThai.DecimalValue = null;
            this.txtStandardThai.IsRequired = false;
            this.txtStandardThai.Location = new System.Drawing.Point(165, 234);
            this.txtStandardThai.MinLength = 0;
            this.txtStandardThai.MinValue = null;
            this.txtStandardThai.Name = "txtStandardThai";
            this.txtStandardThai.NullableDecimalValue = null;
            this.txtStandardThai.NullableIntValue = null;
            this.txtStandardThai.Size = new System.Drawing.Size(250, 23);
            this.txtStandardThai.TabIndex = 10;
            this.txtStandardThai.TextValue = null;
            // 
            // lblToolAnalysis
            // 
            this.lblToolAnalysis.AutoSize = true;
            this.lblToolAnalysis.Location = new System.Drawing.Point(425, 208);
            this.lblToolAnalysis.Name = "lblToolAnalysis";
            this.lblToolAnalysis.Size = new System.Drawing.Size(118, 16);
            this.lblToolAnalysis.TabIndex = 69;
            this.lblToolAnalysis.Text = "เครื่องมือที่วิเคราะห์ :";
            this.lblToolAnalysis.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtToolAnalysis
            // 
            this.txtToolAnalysis.BackColor = System.Drawing.SystemColors.Info;
            this.txtToolAnalysis.CausesValidation = false;
            this.txtToolAnalysis.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.bdSource, "TOOL_ANALYSIS_ID", true));
            this.txtToolAnalysis.IntValue = null;
            this.txtToolAnalysis.IsRequired = false;
            this.txtToolAnalysis.Location = new System.Drawing.Point(549, 205);
            this.txtToolAnalysis.MinLength = 0;
            this.txtToolAnalysis.Name = "txtToolAnalysis";
            this.txtToolAnalysis.OptionalTextBox = null;
            this.txtToolAnalysis.SearchType = OIS.BaseViews.eSearchType.ToolAnalysis;
            this.txtToolAnalysis.Size = new System.Drawing.Size(250, 23);
            this.txtToolAnalysis.StringValue = null;
            this.txtToolAnalysis.TabIndex = 9;
            this.txtToolAnalysis.TextValue = null;
            // 
            // lblToolPick
            // 
            this.lblToolPick.AutoSize = true;
            this.lblToolPick.Location = new System.Drawing.Point(32, 208);
            this.lblToolPick.Name = "lblToolPick";
            this.lblToolPick.Size = new System.Drawing.Size(127, 16);
            this.lblToolPick.TabIndex = 68;
            this.lblToolPick.Text = "เครื่องมือเก็บตัวอย่าง :";
            this.lblToolPick.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtToolPick
            // 
            this.txtToolPick.BackColor = System.Drawing.SystemColors.Info;
            this.txtToolPick.CausesValidation = false;
            this.txtToolPick.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.bdSource, "TOOL_PICK_ID", true));
            this.txtToolPick.IntValue = null;
            this.txtToolPick.IsRequired = false;
            this.txtToolPick.Location = new System.Drawing.Point(165, 205);
            this.txtToolPick.MinLength = 0;
            this.txtToolPick.Name = "txtToolPick";
            this.txtToolPick.OptionalTextBox = null;
            this.txtToolPick.SearchType = OIS.BaseViews.eSearchType.ToolPick;
            this.txtToolPick.Size = new System.Drawing.Size(250, 23);
            this.txtToolPick.StringValue = null;
            this.txtToolPick.TabIndex = 8;
            this.txtToolPick.TextValue = null;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(100, 54);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(59, 16);
            this.lblMethod.TabIndex = 67;
            this.lblMethod.Text = "Method :";
            this.lblMethod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMethod
            // 
            this.txtMethod.BackColor = System.Drawing.SystemColors.Info;
            this.txtMethod.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.bdSource, "METHOD_ID", true));
            this.txtMethod.IntValue = null;
            this.txtMethod.IsRequired = true;
            this.txtMethod.Location = new System.Drawing.Point(165, 51);
            this.txtMethod.MinLength = 0;
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.OptionalTextBox = null;
            this.txtMethod.SearchType = OIS.BaseViews.eSearchType.MethodAnalysis;
            this.txtMethod.Size = new System.Drawing.Size(250, 23);
            this.txtMethod.StringValue = null;
            this.txtMethod.TabIndex = 2;
            this.txtMethod.TextValue = null;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(496, 178);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(47, 16);
            this.lblUnit.TabIndex = 66;
            this.lblUnit.Text = "หน่วย :";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboUnit
            // 
            this.cboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboUnit.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bdSource, "UNIT_ID", true));
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.IsRequired = true;
            this.cboUnit.Location = new System.Drawing.Point(549, 175);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.NullableIntValue = null;
            this.cboUnit.Size = new System.Drawing.Size(250, 24);
            this.cboUnit.StringValue = null;
            this.cboUnit.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(126, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "ชื่อ :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "NAME", true));
            this.txtName.IsRequired = true;
            this.txtName.Location = new System.Drawing.Point(165, 22);
            this.txtName.MaxLength = 50;
            this.txtName.MinLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextValue = null;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(237, 33);
            this.lblHeader.TabIndex = 19;
            this.lblHeader.Text = "ข้อมูล Parameter";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MAS305_ParameterAnalysisEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1140, 668);
            this.Name = "MAS305_ParameterAnalysisEntry";
            this.Text = "MAS305: Parameter";
            this.OnSave += new System.EventHandler(this.MAS305_ParameterAnalysisEntry_OnSave);
            this.OnCancel += new System.EventHandler(this.MAS305_ParameterAnalysisEntry_OnCancel);
            this.OnRecovery += new System.EventHandler(this.MAS305_ParameterAnalysisEntry_OnRecovery);
            this.Load += new System.EventHandler(this.MAS305_ParameterAnalysisEntry_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private BaseViews.rGroupBox gbMain;
        private BaseViews.rNumericTextBox txtSeq;
        private BaseViews.rLabel lblSeq;
        private BaseViews.rLabel lblName;
        private BaseViews.rTextBox txtName;
        private BaseViews.rLabel lblHeader;
        private BaseViews.rLabel lblStandardACGIH;
        private BaseViews.rNumericTextBox txtStandardACGIH;
        private BaseViews.rLabel lblStandardThai;
        private BaseViews.rNumericTextBox txtStandardThai;
        private BaseViews.rLabel lblToolAnalysis;
        private BaseViews.rSearchTextBox txtToolAnalysis;
        private BaseViews.rLabel lblToolPick;
        private BaseViews.rSearchTextBox txtToolPick;
        private BaseViews.rLabel lblMethod;
        private BaseViews.rSearchTextBox txtMethod;
        private BaseViews.rLabel lblUnit;
        private BaseViews.rComboBox cboUnit;
        private System.Windows.Forms.CheckBox chkCeilingLimit;
        private BaseViews.rTextBox txtAnalysisDetail;
        private BaseViews.rTextBox txtMethodRemark;
        private BaseViews.rTextBox txtMethodRef;
        private BaseViews.rLabel lblMethodRef;
        private BaseViews.rLabel lblAnalysisDetail;
        private BaseViews.rLabel lblMethodRemark;
        private BaseViews.rLabel lblLabExt;
        private BaseViews.rComboBox cboLabExt;
        private BaseViews.rLabel lblMRLValue;
        private BaseViews.rNumericTextBox txtMRLValue;
    }
}