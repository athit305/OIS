namespace OIS.Views
{
    partial class MAS101_UserEntry
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
            this.gbPassword = new OIS.BaseViews.rGroupBox();
            this.lblPassword = new OIS.BaseViews.rLabel();
            this.txtPassword = new OIS.BaseViews.rTextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.gbMain = new OIS.BaseViews.rGroupBox();
            this.lblLabSupervisorNo = new OIS.BaseViews.rLabel();
            this.txtLabSupervisorNo = new OIS.BaseViews.rTextBox();
            this.lblRegistrationNo = new OIS.BaseViews.rLabel();
            this.txtRegistrationNo = new OIS.BaseViews.rTextBox();
            this.txtIDCard = new OIS.BaseViews.rMaskedTextBox();
            this.lblIDCard = new OIS.BaseViews.rLabel();
            this.dtStartDate = new OIS.BaseViews.rDateTextBox();
            this.dtBirthDate = new OIS.BaseViews.rDateTextBox();
            this.lblNickName = new OIS.BaseViews.rLabel();
            this.txtNickName = new OIS.BaseViews.rTextBox();
            this.lblStartDate = new OIS.BaseViews.rLabel();
            this.lblBirthDate = new OIS.BaseViews.rLabel();
            this.lblPreName = new OIS.BaseViews.rLabel();
            this.cboPreName = new OIS.BaseViews.rComboBox();
            this.lblSubDivision = new OIS.BaseViews.rLabel();
            this.cboSubDivision = new OIS.BaseViews.rComboBox();
            this.cboGroup = new OIS.BaseViews.rComboBox();
            this.cboPosition = new OIS.BaseViews.rComboBox();
            this.cboDivision = new OIS.BaseViews.rComboBox();
            this.lblLNameEn = new OIS.BaseViews.rLabel();
            this.lblLNameTh = new OIS.BaseViews.rLabel();
            this.lblGroup = new OIS.BaseViews.rLabel();
            this.lblPosition = new OIS.BaseViews.rLabel();
            this.lblDivision = new OIS.BaseViews.rLabel();
            this.lblFNameEn = new OIS.BaseViews.rLabel();
            this.lblFNameTh = new OIS.BaseViews.rLabel();
            this.lblID = new OIS.BaseViews.rLabel();
            this.txtLName_En = new OIS.BaseViews.rTextBox();
            this.txtFName_En = new OIS.BaseViews.rTextBox();
            this.txtLName_Th = new OIS.BaseViews.rTextBox();
            this.txtFName_Th = new OIS.BaseViews.rTextBox();
            this.txtID = new OIS.BaseViews.rTextBox();
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.gbHistory = new OIS.BaseViews.rGroupBox();
            this.txtDelId = new OIS.BaseViews.rTextBox();
            this.lblDelId = new OIS.BaseViews.rLabel();
            this.txtDelMachine = new OIS.BaseViews.rTextBox();
            this.rLabel8 = new OIS.BaseViews.rLabel();
            this.dtDel = new OIS.BaseViews.rDateTextBox();
            this.rLabel9 = new OIS.BaseViews.rLabel();
            this.txtUpdId = new OIS.BaseViews.rTextBox();
            this.lblUpdId = new OIS.BaseViews.rLabel();
            this.txtUpdMachine = new OIS.BaseViews.rTextBox();
            this.rLabel5 = new OIS.BaseViews.rLabel();
            this.dtUpd = new OIS.BaseViews.rDateTextBox();
            this.rLabel6 = new OIS.BaseViews.rLabel();
            this.txtCrtId = new OIS.BaseViews.rTextBox();
            this.lblCrtId = new OIS.BaseViews.rLabel();
            this.txtCrtMachine = new OIS.BaseViews.rTextBox();
            this.rLabel1 = new OIS.BaseViews.rLabel();
            this.dtCrt = new OIS.BaseViews.rDateTextBox();
            this.rLabel2 = new OIS.BaseViews.rLabel();
            this.gbPicture = new OIS.BaseViews.rGroupBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.gbMain.SuspendLayout();
            this.gbHistory.SuspendLayout();
            this.gbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbPicture);
            this.pnlMain.Controls.Add(this.gbHistory);
            this.pnlMain.Controls.Add(this.gbPassword);
            this.pnlMain.Controls.Add(this.gbMain);
            this.pnlMain.Controls.Add(this.lblHeader);
            this.pnlMain.Size = new System.Drawing.Size(1164, 638);
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.lblPassword);
            this.gbPassword.Controls.Add(this.txtPassword);
            this.gbPassword.Location = new System.Drawing.Point(9, 306);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(846, 56);
            this.gbPassword.TabIndex = 8;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "เปลี่ยนรหัสผ่าน";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(64, 25);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "รหัสผ่าน :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPassword
            // 
            this.txtPassword.CausesValidation = false;
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "PASS", true));
            this.txtPassword.IsRequired = false;
            this.txtPassword.Location = new System.Drawing.Point(131, 22);
            this.txtPassword.MinLength = 4;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 23);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.TextValue = null;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(OIS.MAS.DTO.sp_MAS101_GetUser_Result);
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lblLabSupervisorNo);
            this.gbMain.Controls.Add(this.txtLabSupervisorNo);
            this.gbMain.Controls.Add(this.lblRegistrationNo);
            this.gbMain.Controls.Add(this.txtRegistrationNo);
            this.gbMain.Controls.Add(this.txtIDCard);
            this.gbMain.Controls.Add(this.lblIDCard);
            this.gbMain.Controls.Add(this.dtStartDate);
            this.gbMain.Controls.Add(this.dtBirthDate);
            this.gbMain.Controls.Add(this.lblNickName);
            this.gbMain.Controls.Add(this.txtNickName);
            this.gbMain.Controls.Add(this.lblStartDate);
            this.gbMain.Controls.Add(this.lblBirthDate);
            this.gbMain.Controls.Add(this.lblPreName);
            this.gbMain.Controls.Add(this.cboPreName);
            this.gbMain.Controls.Add(this.lblSubDivision);
            this.gbMain.Controls.Add(this.cboSubDivision);
            this.gbMain.Controls.Add(this.cboGroup);
            this.gbMain.Controls.Add(this.cboPosition);
            this.gbMain.Controls.Add(this.cboDivision);
            this.gbMain.Controls.Add(this.lblLNameEn);
            this.gbMain.Controls.Add(this.lblLNameTh);
            this.gbMain.Controls.Add(this.lblGroup);
            this.gbMain.Controls.Add(this.lblPosition);
            this.gbMain.Controls.Add(this.lblDivision);
            this.gbMain.Controls.Add(this.lblFNameEn);
            this.gbMain.Controls.Add(this.lblFNameTh);
            this.gbMain.Controls.Add(this.lblID);
            this.gbMain.Controls.Add(this.txtLName_En);
            this.gbMain.Controls.Add(this.txtFName_En);
            this.gbMain.Controls.Add(this.txtLName_Th);
            this.gbMain.Controls.Add(this.txtFName_Th);
            this.gbMain.Controls.Add(this.txtID);
            this.gbMain.Location = new System.Drawing.Point(9, 36);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(846, 264);
            this.gbMain.TabIndex = 7;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "ข้อมูลทั่วไป";
            // 
            // lblLabSupervisorNo
            // 
            this.lblLabSupervisorNo.AutoSize = true;
            this.lblLabSupervisorNo.Location = new System.Drawing.Point(392, 231);
            this.lblLabSupervisorNo.Name = "lblLabSupervisorNo";
            this.lblLabSupervisorNo.Size = new System.Drawing.Size(129, 16);
            this.lblLabSupervisorNo.TabIndex = 34;
            this.lblLabSupervisorNo.Text = "Lab. Supervisor No. :";
            this.lblLabSupervisorNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLabSupervisorNo
            // 
            this.txtLabSupervisorNo.CausesValidation = false;
            this.txtLabSupervisorNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LABSUPERVISOR_NO", true));
            this.txtLabSupervisorNo.IsRequired = false;
            this.txtLabSupervisorNo.Location = new System.Drawing.Point(527, 228);
            this.txtLabSupervisorNo.MinLength = 0;
            this.txtLabSupervisorNo.Name = "txtLabSupervisorNo";
            this.txtLabSupervisorNo.Size = new System.Drawing.Size(250, 23);
            this.txtLabSupervisorNo.TabIndex = 16;
            this.txtLabSupervisorNo.TextValue = null;
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.Location = new System.Drawing.Point(17, 231);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(108, 16);
            this.lblRegistrationNo.TabIndex = 32;
            this.lblRegistrationNo.Text = "Registration No. :";
            this.lblRegistrationNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.CausesValidation = false;
            this.txtRegistrationNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "REGISTRATION_NO", true));
            this.txtRegistrationNo.IsRequired = false;
            this.txtRegistrationNo.Location = new System.Drawing.Point(131, 227);
            this.txtRegistrationNo.MinLength = 0;
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(250, 23);
            this.txtRegistrationNo.TabIndex = 15;
            this.txtRegistrationNo.TextValue = null;
            // 
            // txtIDCard
            // 
            this.txtIDCard.CausesValidation = false;
            this.txtIDCard.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "IDCARD", true));
            this.txtIDCard.IsRequired = false;
            this.txtIDCard.Location = new System.Drawing.Point(527, 109);
            this.txtIDCard.Mask = "0-0000-00000-00-0";
            this.txtIDCard.MinLength = 13;
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(250, 23);
            this.txtIDCard.TabIndex = 8;
            this.txtIDCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDCard.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Location = new System.Drawing.Point(412, 112);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(109, 16);
            this.lblIDCard.TabIndex = 29;
            this.lblIDCard.Text = "เลขบัตรประชาชน :";
            this.lblIDCard.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CausesValidation = false;
            this.dtStartDate.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bs, "STARTDATE", true));
            this.dtStartDate.Date = null;
            this.dtStartDate.DateValue = null;
            this.dtStartDate.IsRequired = true;
            this.dtStartDate.Location = new System.Drawing.Point(527, 139);
            this.dtStartDate.MaxLength = 10;
            this.dtStartDate.MinLength = 0;
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.ShowTime = false;
            this.dtStartDate.Size = new System.Drawing.Size(250, 23);
            this.dtStartDate.TabIndex = 10;
            this.dtStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtStartDate.TextValue = null;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CausesValidation = false;
            this.dtBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bs, "BIRTHDATE", true));
            this.dtBirthDate.Date = null;
            this.dtBirthDate.DateValue = null;
            this.dtBirthDate.IsRequired = false;
            this.dtBirthDate.Location = new System.Drawing.Point(131, 138);
            this.dtBirthDate.MaxLength = 10;
            this.dtBirthDate.MinLength = 0;
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.ShowTime = false;
            this.dtBirthDate.Size = new System.Drawing.Size(250, 23);
            this.dtBirthDate.TabIndex = 9;
            this.dtBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtBirthDate.TextValue = null;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(62, 112);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(63, 16);
            this.lblNickName.TabIndex = 27;
            this.lblNickName.Text = "ชื่อ(เล่น) :";
            this.lblNickName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNickName
            // 
            this.txtNickName.CausesValidation = false;
            this.txtNickName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "NICKNAME", true));
            this.txtNickName.IsRequired = false;
            this.txtNickName.Location = new System.Drawing.Point(131, 109);
            this.txtNickName.MinLength = 0;
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(250, 23);
            this.txtNickName.TabIndex = 7;
            this.txtNickName.TextValue = null;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(453, 142);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(68, 16);
            this.lblStartDate.TabIndex = 25;
            this.lblStartDate.Text = "วันเริ่มจ้าง :";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(74, 141);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(51, 16);
            this.lblBirthDate.TabIndex = 24;
            this.lblBirthDate.Text = "วันเกิด :";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPreName
            // 
            this.lblPreName.AutoSize = true;
            this.lblPreName.Location = new System.Drawing.Point(438, 26);
            this.lblPreName.Name = "lblPreName";
            this.lblPreName.Size = new System.Drawing.Size(83, 16);
            this.lblPreName.TabIndex = 23;
            this.lblPreName.Text = "คำนำหน้าชื่อ :";
            this.lblPreName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboPreName
            // 
            this.cboPreName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPreName.BackColor = System.Drawing.SystemColors.Window;
            this.cboPreName.CausesValidation = false;
            this.cboPreName.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs, "PRENAME_ID", true));
            this.cboPreName.FormattingEnabled = true;
            this.cboPreName.IsRequired = true;
            this.cboPreName.Location = new System.Drawing.Point(527, 22);
            this.cboPreName.Name = "cboPreName";
            this.cboPreName.NullableIntValue = null;
            this.cboPreName.Size = new System.Drawing.Size(250, 24);
            this.cboPreName.StringValue = null;
            this.cboPreName.TabIndex = 2;
            // 
            // lblSubDivision
            // 
            this.lblSubDivision.AutoSize = true;
            this.lblSubDivision.Location = new System.Drawing.Point(472, 171);
            this.lblSubDivision.Name = "lblSubDivision";
            this.lblSubDivision.Size = new System.Drawing.Size(49, 16);
            this.lblSubDivision.TabIndex = 19;
            this.lblSubDivision.Text = "แผนก :";
            this.lblSubDivision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboSubDivision
            // 
            this.cboSubDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboSubDivision.CausesValidation = false;
            this.cboSubDivision.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs, "SUBDIVISION_ID", true));
            this.cboSubDivision.FormattingEnabled = true;
            this.cboSubDivision.IsRequired = false;
            this.cboSubDivision.Location = new System.Drawing.Point(527, 168);
            this.cboSubDivision.Name = "cboSubDivision";
            this.cboSubDivision.NullableIntValue = null;
            this.cboSubDivision.Size = new System.Drawing.Size(250, 24);
            this.cboSubDivision.StringValue = null;
            this.cboSubDivision.TabIndex = 12;
            // 
            // cboGroup
            // 
            this.cboGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboGroup.CausesValidation = false;
            this.cboGroup.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs, "GROUP_ID", true));
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.IsRequired = true;
            this.cboGroup.Location = new System.Drawing.Point(527, 198);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.NullableIntValue = null;
            this.cboGroup.Size = new System.Drawing.Size(250, 24);
            this.cboGroup.StringValue = null;
            this.cboGroup.TabIndex = 14;
            // 
            // cboPosition
            // 
            this.cboPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPosition.CausesValidation = false;
            this.cboPosition.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs, "POSITION_ID", true));
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.IsRequired = false;
            this.cboPosition.Location = new System.Drawing.Point(131, 197);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.NullableIntValue = null;
            this.cboPosition.Size = new System.Drawing.Size(250, 24);
            this.cboPosition.StringValue = null;
            this.cboPosition.TabIndex = 13;
            // 
            // cboDivision
            // 
            this.cboDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDivision.CausesValidation = false;
            this.cboDivision.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs, "DIVISION_ID", true));
            this.cboDivision.FormattingEnabled = true;
            this.cboDivision.IsRequired = false;
            this.cboDivision.Location = new System.Drawing.Point(131, 167);
            this.cboDivision.Name = "cboDivision";
            this.cboDivision.NullableIntValue = null;
            this.cboDivision.Size = new System.Drawing.Size(250, 24);
            this.cboDivision.StringValue = null;
            this.cboDivision.TabIndex = 11;
            this.cboDivision.SelectedIndexChanged += new System.EventHandler(this.cboDivision_SelectedIndexChanged);
            // 
            // lblLNameEn
            // 
            this.lblLNameEn.AutoSize = true;
            this.lblLNameEn.Location = new System.Drawing.Point(409, 84);
            this.lblLNameEn.Name = "lblLNameEn";
            this.lblLNameEn.Size = new System.Drawing.Size(112, 16);
            this.lblLNameEn.TabIndex = 14;
            this.lblLNameEn.Text = "นามสกุล(อังกฤษ) :";
            this.lblLNameEn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLNameTh
            // 
            this.lblLNameTh.AutoSize = true;
            this.lblLNameTh.Location = new System.Drawing.Point(424, 55);
            this.lblLNameTh.Name = "lblLNameTh";
            this.lblLNameTh.Size = new System.Drawing.Size(97, 16);
            this.lblLNameTh.TabIndex = 13;
            this.lblLNameTh.Text = "นามสกุล(ไทย) :";
            this.lblLNameTh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(458, 201);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(63, 16);
            this.lblGroup.TabIndex = 12;
            this.lblGroup.Text = "กลุ่มผู้ใช้ :";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(64, 200);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(61, 16);
            this.lblPosition.TabIndex = 11;
            this.lblPosition.Text = "ตำแหน่ง :";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(86, 170);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(39, 16);
            this.lblDivision.TabIndex = 10;
            this.lblDivision.Text = "ฝ่าย :";
            this.lblDivision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFNameEn
            // 
            this.lblFNameEn.AutoSize = true;
            this.lblFNameEn.Location = new System.Drawing.Point(43, 83);
            this.lblFNameEn.Name = "lblFNameEn";
            this.lblFNameEn.Size = new System.Drawing.Size(82, 16);
            this.lblFNameEn.TabIndex = 9;
            this.lblFNameEn.Text = "ชื่อ(อังกฤษ) :";
            this.lblFNameEn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFNameTh
            // 
            this.lblFNameTh.AutoSize = true;
            this.lblFNameTh.Location = new System.Drawing.Point(58, 54);
            this.lblFNameTh.Name = "lblFNameTh";
            this.lblFNameTh.Size = new System.Drawing.Size(67, 16);
            this.lblFNameTh.TabIndex = 8;
            this.lblFNameTh.Text = "ชื่อ(ไทย) :";
            this.lblFNameTh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(41, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(84, 16);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "รหัสพนักงาน :";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLName_En
            // 
            this.txtLName_En.CausesValidation = false;
            this.txtLName_En.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LNAME_EN", true));
            this.txtLName_En.IsRequired = true;
            this.txtLName_En.Location = new System.Drawing.Point(527, 81);
            this.txtLName_En.MinLength = 0;
            this.txtLName_En.Name = "txtLName_En";
            this.txtLName_En.Size = new System.Drawing.Size(250, 23);
            this.txtLName_En.TabIndex = 6;
            this.txtLName_En.TextValue = null;
            // 
            // txtFName_En
            // 
            this.txtFName_En.BackColor = System.Drawing.SystemColors.Window;
            this.txtFName_En.CausesValidation = false;
            this.txtFName_En.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "FNAME_EN", true));
            this.txtFName_En.IsRequired = true;
            this.txtFName_En.Location = new System.Drawing.Point(131, 80);
            this.txtFName_En.MinLength = 0;
            this.txtFName_En.Name = "txtFName_En";
            this.txtFName_En.Size = new System.Drawing.Size(250, 23);
            this.txtFName_En.TabIndex = 5;
            this.txtFName_En.TextValue = null;
            // 
            // txtLName_Th
            // 
            this.txtLName_Th.CausesValidation = false;
            this.txtLName_Th.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "LNAME_TH", true));
            this.txtLName_Th.IsRequired = true;
            this.txtLName_Th.Location = new System.Drawing.Point(527, 52);
            this.txtLName_Th.MinLength = 0;
            this.txtLName_Th.Name = "txtLName_Th";
            this.txtLName_Th.Size = new System.Drawing.Size(250, 23);
            this.txtLName_Th.TabIndex = 4;
            this.txtLName_Th.TextValue = null;
            // 
            // txtFName_Th
            // 
            this.txtFName_Th.BackColor = System.Drawing.SystemColors.Window;
            this.txtFName_Th.CausesValidation = false;
            this.txtFName_Th.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "FNAME_TH", true));
            this.txtFName_Th.IsRequired = true;
            this.txtFName_Th.Location = new System.Drawing.Point(131, 51);
            this.txtFName_Th.MinLength = 0;
            this.txtFName_Th.Name = "txtFName_Th";
            this.txtFName_Th.Size = new System.Drawing.Size(250, 23);
            this.txtFName_Th.TabIndex = 3;
            this.txtFName_Th.TextValue = null;
            // 
            // txtID
            // 
            this.txtID.CausesValidation = false;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "ID", true));
            this.txtID.Enabled = false;
            this.txtID.IsRequired = true;
            this.txtID.Location = new System.Drawing.Point(131, 22);
            this.txtID.MaxLength = 8;
            this.txtID.MinLength = 8;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 23);
            this.txtID.TabIndex = 1;
            this.txtID.TextValue = null;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(191, 33);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "ข้อมูลพนักงาน";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbHistory
            // 
            this.gbHistory.Controls.Add(this.txtDelId);
            this.gbHistory.Controls.Add(this.lblDelId);
            this.gbHistory.Controls.Add(this.txtDelMachine);
            this.gbHistory.Controls.Add(this.rLabel8);
            this.gbHistory.Controls.Add(this.dtDel);
            this.gbHistory.Controls.Add(this.rLabel9);
            this.gbHistory.Controls.Add(this.txtUpdId);
            this.gbHistory.Controls.Add(this.lblUpdId);
            this.gbHistory.Controls.Add(this.txtUpdMachine);
            this.gbHistory.Controls.Add(this.rLabel5);
            this.gbHistory.Controls.Add(this.dtUpd);
            this.gbHistory.Controls.Add(this.rLabel6);
            this.gbHistory.Controls.Add(this.txtCrtId);
            this.gbHistory.Controls.Add(this.lblCrtId);
            this.gbHistory.Controls.Add(this.txtCrtMachine);
            this.gbHistory.Controls.Add(this.rLabel1);
            this.gbHistory.Controls.Add(this.dtCrt);
            this.gbHistory.Controls.Add(this.rLabel2);
            this.gbHistory.Location = new System.Drawing.Point(9, 368);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(846, 118);
            this.gbHistory.TabIndex = 9;
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
            // rLabel8
            // 
            this.rLabel8.AutoSize = true;
            this.rLabel8.Location = new System.Drawing.Point(579, 83);
            this.rLabel8.Name = "rLabel8";
            this.rLabel8.Size = new System.Drawing.Size(94, 16);
            this.rLabel8.TabIndex = 42;
            this.rLabel8.Text = "เครื่องที่ยกเลิก :";
            this.rLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // rLabel9
            // 
            this.rLabel9.AutoSize = true;
            this.rLabel9.Location = new System.Drawing.Point(324, 83);
            this.rLabel9.Name = "rLabel9";
            this.rLabel9.Size = new System.Drawing.Size(76, 16);
            this.rLabel9.TabIndex = 40;
            this.rLabel9.Text = "วันที่ยกเลิก :";
            this.rLabel9.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // rLabel5
            // 
            this.rLabel5.AutoSize = true;
            this.rLabel5.Location = new System.Drawing.Point(584, 54);
            this.rLabel5.Name = "rLabel5";
            this.rLabel5.Size = new System.Drawing.Size(89, 16);
            this.rLabel5.TabIndex = 36;
            this.rLabel5.Text = "เครื่องที่แก้ไข :";
            this.rLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // rLabel6
            // 
            this.rLabel6.AutoSize = true;
            this.rLabel6.Location = new System.Drawing.Point(329, 54);
            this.rLabel6.Name = "rLabel6";
            this.rLabel6.Size = new System.Drawing.Size(71, 16);
            this.rLabel6.TabIndex = 34;
            this.rLabel6.Text = "วันที่แก้ไข :";
            this.rLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // rLabel1
            // 
            this.rLabel1.AutoSize = true;
            this.rLabel1.Location = new System.Drawing.Point(589, 25);
            this.rLabel1.Name = "rLabel1";
            this.rLabel1.Size = new System.Drawing.Size(84, 16);
            this.rLabel1.TabIndex = 30;
            this.rLabel1.Text = "เครื่องที่สร้าง :";
            this.rLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // rLabel2
            // 
            this.rLabel2.AutoSize = true;
            this.rLabel2.Location = new System.Drawing.Point(334, 25);
            this.rLabel2.Name = "rLabel2";
            this.rLabel2.Size = new System.Drawing.Size(66, 16);
            this.rLabel2.TabIndex = 28;
            this.rLabel2.Text = "วันที่สร้าง :";
            this.rLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbPicture
            // 
            this.gbPicture.Controls.Add(this.picBox);
            this.gbPicture.Location = new System.Drawing.Point(861, 36);
            this.gbPicture.Name = "gbPicture";
            this.gbPicture.Size = new System.Drawing.Size(131, 195);
            this.gbPicture.TabIndex = 34;
            this.gbPicture.TabStop = false;
            this.gbPicture.Text = "รูป";
            // 
            // picBox
            // 
            this.picBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bs, "USER_PIC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(3, 19);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(125, 173);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_DoubleClick);
            this.picBox.DoubleClick += new System.EventHandler(this.picBox_DoubleClick);
            // 
            // MAS101_UserEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1164, 692);
            this.Name = "MAS101_UserEntry";
            this.Text = "MAS101: ข้อมูลพนักงาน";
            this.OnSave += new System.EventHandler(this.MAS101_UserEntry_OnSave);
            this.OnCancel += new System.EventHandler(this.MAS101_UserEntry_OnCancel);
            this.OnRecovery += new System.EventHandler(this.MAS101_UserEntry_OnRecovery);
            this.Load += new System.EventHandler(this.MAS101_UserEntry_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            this.gbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private BaseViews.rGroupBox gbPassword;
        private BaseViews.rLabel lblPassword;
        private BaseViews.rTextBox txtPassword;
        private BaseViews.rGroupBox gbMain;
        private BaseViews.rDateTextBox dtStartDate;
        private BaseViews.rDateTextBox dtBirthDate;
        private BaseViews.rLabel lblNickName;
        private BaseViews.rTextBox txtNickName;
        private BaseViews.rLabel lblStartDate;
        private BaseViews.rLabel lblBirthDate;
        private BaseViews.rLabel lblPreName;
        private BaseViews.rComboBox cboPreName;
        private BaseViews.rLabel lblSubDivision;
        private BaseViews.rComboBox cboSubDivision;
        private BaseViews.rComboBox cboGroup;
        private BaseViews.rComboBox cboPosition;
        private BaseViews.rComboBox cboDivision;
        private BaseViews.rLabel lblLNameEn;
        private BaseViews.rLabel lblLNameTh;
        private BaseViews.rLabel lblGroup;
        private BaseViews.rLabel lblPosition;
        private BaseViews.rLabel lblDivision;
        private BaseViews.rLabel lblFNameEn;
        private BaseViews.rLabel lblFNameTh;
        private BaseViews.rLabel lblID;
        private BaseViews.rTextBox txtLName_En;
        private BaseViews.rTextBox txtFName_En;
        private BaseViews.rTextBox txtLName_Th;
        private BaseViews.rTextBox txtFName_Th;
        private BaseViews.rTextBox txtID;
        private BaseViews.rLabel lblHeader;
        private BaseViews.rGroupBox gbHistory;
        private BaseViews.rTextBox txtCrtId;
        private BaseViews.rLabel lblCrtId;
        private BaseViews.rTextBox txtCrtMachine;
        private BaseViews.rLabel rLabel1;
        private BaseViews.rDateTextBox dtCrt;
        private BaseViews.rLabel rLabel2;
        private BaseViews.rTextBox txtDelId;
        private BaseViews.rLabel lblDelId;
        private BaseViews.rTextBox txtDelMachine;
        private BaseViews.rLabel rLabel8;
        private BaseViews.rDateTextBox dtDel;
        private BaseViews.rLabel rLabel9;
        private BaseViews.rTextBox txtUpdId;
        private BaseViews.rLabel lblUpdId;
        private BaseViews.rTextBox txtUpdMachine;
        private BaseViews.rLabel rLabel5;
        private BaseViews.rDateTextBox dtUpd;
        private BaseViews.rLabel rLabel6;
        private BaseViews.rLabel lblIDCard;
        private BaseViews.rMaskedTextBox txtIDCard;
        private BaseViews.rGroupBox gbPicture;
        private System.Windows.Forms.PictureBox picBox;
        private BaseViews.rLabel lblLabSupervisorNo;
        private BaseViews.rTextBox txtLabSupervisorNo;
        private BaseViews.rLabel lblRegistrationNo;
        private BaseViews.rTextBox txtRegistrationNo;
    }
}