namespace OIS.Views
{
    partial class SYS002_UserProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.gbPassword = new OIS.BaseViews.rGroupBox();
            this.lblPasswordConfirm = new OIS.BaseViews.rLabel();
            this.lblPasswordNew = new OIS.BaseViews.rLabel();
            this.lblPassword = new OIS.BaseViews.rLabel();
            this.txtPasswordConfirm = new OIS.BaseViews.rTextBox();
            this.bs2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtPasswordNew = new OIS.BaseViews.rTextBox();
            this.txtPassword = new OIS.BaseViews.rTextBox();
            this.gbMain = new OIS.BaseViews.rGroupBox();
            this.lblLabSupervisorNo = new OIS.BaseViews.rLabel();
            this.txtLabSupervisorNo = new OIS.BaseViews.rTextBox();
            this.lblRegistrationNo = new OIS.BaseViews.rLabel();
            this.txtRegistrationNo = new OIS.BaseViews.rTextBox();
            this.gbPicture = new OIS.BaseViews.rGroupBox();
            this.picBox = new System.Windows.Forms.PictureBox();
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
            this.pnlMain.SuspendLayout();
            this.gbPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs2)).BeginInit();
            this.gbMain.SuspendLayout();
            this.gbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbPassword);
            this.pnlMain.Controls.Add(this.gbMain);
            this.pnlMain.Controls.Add(this.lblHeader);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(139, 33);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "ข้อมูลผู้ใช้";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.lblPasswordConfirm);
            this.gbPassword.Controls.Add(this.lblPasswordNew);
            this.gbPassword.Controls.Add(this.lblPassword);
            this.gbPassword.Controls.Add(this.txtPasswordConfirm);
            this.gbPassword.Controls.Add(this.txtPasswordNew);
            this.gbPassword.Controls.Add(this.txtPassword);
            this.gbPassword.Location = new System.Drawing.Point(9, 322);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(846, 118);
            this.gbPassword.TabIndex = 5;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "เปลี่ยนรหัสผ่าน";
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.Location = new System.Drawing.Point(32, 83);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(93, 16);
            this.lblPasswordConfirm.TabIndex = 5;
            this.lblPasswordConfirm.Text = "ยืนยันรหัสผ่าน :";
            this.lblPasswordConfirm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPasswordNew
            // 
            this.lblPasswordNew.Location = new System.Drawing.Point(42, 54);
            this.lblPasswordNew.Name = "lblPasswordNew";
            this.lblPasswordNew.Size = new System.Drawing.Size(83, 16);
            this.lblPasswordNew.TabIndex = 4;
            this.lblPasswordNew.Text = "รหัสผ่านใหม่ :";
            this.lblPasswordNew.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(44, 25);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "รหัสผ่านเดิม :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.CausesValidation = false;
            this.txtPasswordConfirm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "PASS_CONFIRM", true));
            this.txtPasswordConfirm.IsRequired = false;
            this.txtPasswordConfirm.Location = new System.Drawing.Point(131, 80);
            this.txtPasswordConfirm.MinLength = 4;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(200, 23);
            this.txtPasswordConfirm.TabIndex = 22;
            this.txtPasswordConfirm.TextValue = null;
            this.txtPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // bs
            // 
            this.bs2.DataSource = typeof(OIS.SYS.DTO.sp_SYS02_GetUserProfile_Result);
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.CausesValidation = false;
            this.txtPasswordNew.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "PASS_NEW", true));
            this.txtPasswordNew.IsRequired = false;
            this.txtPasswordNew.Location = new System.Drawing.Point(131, 51);
            this.txtPasswordNew.MinLength = 4;
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.Size = new System.Drawing.Size(200, 23);
            this.txtPasswordNew.TabIndex = 21;
            this.txtPasswordNew.TextValue = null;
            this.txtPasswordNew.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.CausesValidation = false;
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "PASS", true));
            this.txtPassword.IsRequired = false;
            this.txtPassword.Location = new System.Drawing.Point(131, 22);
            this.txtPassword.MinLength = 4;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.TextValue = null;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lblLabSupervisorNo);
            this.gbMain.Controls.Add(this.txtLabSupervisorNo);
            this.gbMain.Controls.Add(this.lblRegistrationNo);
            this.gbMain.Controls.Add(this.txtRegistrationNo);
            this.gbMain.Controls.Add(this.gbPicture);
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
            this.gbMain.Location = new System.Drawing.Point(3, 36);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(846, 280);
            this.gbMain.TabIndex = 4;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "ข้อมูลทั่วไป";
            // 
            // lblLabSupervisorNo
            // 
            this.lblLabSupervisorNo.AutoSize = true;
            this.lblLabSupervisorNo.Location = new System.Drawing.Point(333, 231);
            this.lblLabSupervisorNo.Name = "lblLabSupervisorNo";
            this.lblLabSupervisorNo.Size = new System.Drawing.Size(129, 16);
            this.lblLabSupervisorNo.TabIndex = 38;
            this.lblLabSupervisorNo.Text = "Lab. Supervisor No. :";
            this.lblLabSupervisorNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLabSupervisorNo
            // 
            this.txtLabSupervisorNo.CausesValidation = false;
            this.txtLabSupervisorNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "LABSUPERVISOR_NO", true));
            this.txtLabSupervisorNo.IsRequired = false;
            this.txtLabSupervisorNo.Location = new System.Drawing.Point(468, 228);
            this.txtLabSupervisorNo.MinLength = 0;
            this.txtLabSupervisorNo.Name = "txtLabSupervisorNo";
            this.txtLabSupervisorNo.Size = new System.Drawing.Size(200, 23);
            this.txtLabSupervisorNo.TabIndex = 15;
            this.txtLabSupervisorNo.TextValue = null;
            // 
            // lblRegistrationNo
            // 
            this.lblRegistrationNo.AutoSize = true;
            this.lblRegistrationNo.Location = new System.Drawing.Point(17, 231);
            this.lblRegistrationNo.Name = "lblRegistrationNo";
            this.lblRegistrationNo.Size = new System.Drawing.Size(108, 16);
            this.lblRegistrationNo.TabIndex = 36;
            this.lblRegistrationNo.Text = "Registration No. :";
            this.lblRegistrationNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.CausesValidation = false;
            this.txtRegistrationNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "REGISTRATION_NO", true));
            this.txtRegistrationNo.IsRequired = false;
            this.txtRegistrationNo.Location = new System.Drawing.Point(131, 227);
            this.txtRegistrationNo.MinLength = 0;
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(200, 23);
            this.txtRegistrationNo.TabIndex = 14;
            this.txtRegistrationNo.TextValue = null;
            // 
            // gbPicture
            // 
            this.gbPicture.Controls.Add(this.picBox);
            this.gbPicture.Location = new System.Drawing.Point(709, 21);
            this.gbPicture.Name = "gbPicture";
            this.gbPicture.Size = new System.Drawing.Size(131, 195);
            this.gbPicture.TabIndex = 33;
            this.gbPicture.TabStop = false;
            this.gbPicture.Text = "รูป";
            // 
            // picBox
            // 
            this.picBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bs2, "USER_PIC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            // txtIDCard
            // 
            this.txtIDCard.CausesValidation = false;
            this.txtIDCard.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "IDCARD", true));
            this.txtIDCard.IsRequired = false;
            this.txtIDCard.Location = new System.Drawing.Point(468, 111);
            this.txtIDCard.Mask = "0-0000-00000-00-0";
            this.txtIDCard.MinLength = 13;
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(200, 23);
            this.txtIDCard.TabIndex = 7;
            this.txtIDCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDCard.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Location = new System.Drawing.Point(353, 114);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(109, 16);
            this.lblIDCard.TabIndex = 31;
            this.lblIDCard.Text = "เลขบัตรประชาชน :";
            this.lblIDCard.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CausesValidation = false;
            this.dtStartDate.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bs2, "STARTDATE", true));
            this.dtStartDate.Date = null;
            this.dtStartDate.DateValue = null;
            this.dtStartDate.Enabled = false;
            this.dtStartDate.IsRequired = true;
            this.dtStartDate.Location = new System.Drawing.Point(468, 138);
            this.dtStartDate.MaxLength = 10;
            this.dtStartDate.MinLength = 0;
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.ShowTime = false;
            this.dtStartDate.Size = new System.Drawing.Size(200, 23);
            this.dtStartDate.TabIndex = 9;
            this.dtStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtStartDate.TextValue = null;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CausesValidation = false;
            this.dtBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bs2, "BIRTHDATE", true));
            this.dtBirthDate.Date = null;
            this.dtBirthDate.DateValue = null;
            this.dtBirthDate.IsRequired = false;
            this.dtBirthDate.Location = new System.Drawing.Point(131, 138);
            this.dtBirthDate.MaxLength = 10;
            this.dtBirthDate.MinLength = 0;
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.ShowTime = false;
            this.dtBirthDate.Size = new System.Drawing.Size(200, 23);
            this.dtBirthDate.TabIndex = 8;
            this.dtBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtBirthDate.TextValue = null;
            // 
            // lblNickName
            // 
            this.lblNickName.Location = new System.Drawing.Point(44, 112);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(82, 16);
            this.lblNickName.TabIndex = 27;
            this.lblNickName.Text = "ชื่อ(เล่น) :";
            this.lblNickName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNickName
            // 
            this.txtNickName.CausesValidation = false;
            this.txtNickName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "NICKNAME", true));
            this.txtNickName.IsRequired = false;
            this.txtNickName.Location = new System.Drawing.Point(131, 109);
            this.txtNickName.MinLength = 0;
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(200, 23);
            this.txtNickName.TabIndex = 6;
            this.txtNickName.TextValue = null;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(380, 143);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(82, 16);
            this.lblStartDate.TabIndex = 25;
            this.lblStartDate.Text = "วันเริ่มจ้าง :";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Location = new System.Drawing.Point(44, 143);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(82, 16);
            this.lblBirthDate.TabIndex = 24;
            this.lblBirthDate.Text = "วันเกิด :";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPreName
            // 
            this.lblPreName.Location = new System.Drawing.Point(365, 25);
            this.lblPreName.Name = "lblPreName";
            this.lblPreName.Size = new System.Drawing.Size(97, 16);
            this.lblPreName.TabIndex = 23;
            this.lblPreName.Text = "คำนำหน้าชื่อ :";
            this.lblPreName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboPreName
            // 
            this.cboPreName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPreName.CausesValidation = false;
            this.cboPreName.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs2, "PRENAME_ID", true));
            this.cboPreName.FormattingEnabled = true;
            this.cboPreName.IsRequired = true;
            this.cboPreName.Location = new System.Drawing.Point(468, 21);
            this.cboPreName.Name = "cboPreName";
            this.cboPreName.NullableIntValue = null;
            this.cboPreName.Size = new System.Drawing.Size(200, 24);
            this.cboPreName.StringValue = null;
            this.cboPreName.TabIndex = 1;
            // 
            // lblSubDivision
            // 
            this.lblSubDivision.Location = new System.Drawing.Point(413, 170);
            this.lblSubDivision.Name = "lblSubDivision";
            this.lblSubDivision.Size = new System.Drawing.Size(49, 16);
            this.lblSubDivision.TabIndex = 19;
            this.lblSubDivision.Text = "ฝ่าย :";
            this.lblSubDivision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboSubDivision
            // 
            this.cboSubDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboSubDivision.CausesValidation = false;
            this.cboSubDivision.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs2, "SUBDIVISION_ID", true));
            this.cboSubDivision.Enabled = false;
            this.cboSubDivision.FormattingEnabled = true;
            this.cboSubDivision.IsRequired = false;
            this.cboSubDivision.Location = new System.Drawing.Point(468, 167);
            this.cboSubDivision.Name = "cboSubDivision";
            this.cboSubDivision.NullableIntValue = null;
            this.cboSubDivision.Size = new System.Drawing.Size(200, 24);
            this.cboSubDivision.StringValue = null;
            this.cboSubDivision.TabIndex = 11;
            // 
            // cboGroup
            // 
            this.cboGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboGroup.CausesValidation = false;
            this.cboGroup.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs2, "GROUP_ID", true));
            this.cboGroup.Enabled = false;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.IsRequired = true;
            this.cboGroup.Location = new System.Drawing.Point(468, 197);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.NullableIntValue = null;
            this.cboGroup.Size = new System.Drawing.Size(200, 24);
            this.cboGroup.StringValue = null;
            this.cboGroup.TabIndex = 13;
            // 
            // cboPosition
            // 
            this.cboPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPosition.CausesValidation = false;
            this.cboPosition.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs2, "POSITION_ID", true));
            this.cboPosition.Enabled = false;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.IsRequired = false;
            this.cboPosition.Location = new System.Drawing.Point(131, 197);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.NullableIntValue = null;
            this.cboPosition.Size = new System.Drawing.Size(200, 24);
            this.cboPosition.StringValue = null;
            this.cboPosition.TabIndex = 12;
            // 
            // cboDivision
            // 
            this.cboDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDivision.CausesValidation = false;
            this.cboDivision.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs2, "DIVISION_ID", true));
            this.cboDivision.Enabled = false;
            this.cboDivision.FormattingEnabled = true;
            this.cboDivision.IsRequired = false;
            this.cboDivision.Location = new System.Drawing.Point(131, 167);
            this.cboDivision.Name = "cboDivision";
            this.cboDivision.NullableIntValue = null;
            this.cboDivision.Size = new System.Drawing.Size(200, 24);
            this.cboDivision.StringValue = null;
            this.cboDivision.TabIndex = 10;
            this.cboDivision.SelectedIndexChanged += new System.EventHandler(this.cboDivision_SelectedIndexChanged);
            // 
            // lblLNameEn
            // 
            this.lblLNameEn.Location = new System.Drawing.Point(350, 83);
            this.lblLNameEn.Name = "lblLNameEn";
            this.lblLNameEn.Size = new System.Drawing.Size(112, 16);
            this.lblLNameEn.TabIndex = 14;
            this.lblLNameEn.Text = "นามสกุล(อังกฤษ) :";
            this.lblLNameEn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLNameTh
            // 
            this.lblLNameTh.Location = new System.Drawing.Point(365, 54);
            this.lblLNameTh.Name = "lblLNameTh";
            this.lblLNameTh.Size = new System.Drawing.Size(97, 16);
            this.lblLNameTh.TabIndex = 13;
            this.lblLNameTh.Text = "นามสกุล(ไทย) :";
            this.lblLNameTh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGroup
            // 
            this.lblGroup.Location = new System.Drawing.Point(399, 200);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(63, 16);
            this.lblGroup.TabIndex = 12;
            this.lblGroup.Text = "กลุ่มผู้ใช้ :";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(64, 200);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(61, 16);
            this.lblPosition.TabIndex = 11;
            this.lblPosition.Text = "ตำแหน่ง :";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDivision
            // 
            this.lblDivision.Location = new System.Drawing.Point(76, 170);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(49, 16);
            this.lblDivision.TabIndex = 10;
            this.lblDivision.Text = "แผนก :";
            this.lblDivision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFNameEn
            // 
            this.lblFNameEn.Location = new System.Drawing.Point(44, 83);
            this.lblFNameEn.Name = "lblFNameEn";
            this.lblFNameEn.Size = new System.Drawing.Size(82, 16);
            this.lblFNameEn.TabIndex = 9;
            this.lblFNameEn.Text = "ชื่อ(อังกฤษ) :";
            this.lblFNameEn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFNameTh
            // 
            this.lblFNameTh.Location = new System.Drawing.Point(58, 54);
            this.lblFNameTh.Name = "lblFNameTh";
            this.lblFNameTh.Size = new System.Drawing.Size(67, 16);
            this.lblFNameTh.TabIndex = 8;
            this.lblFNameTh.Text = "ชื่อ(ไทย) :";
            this.lblFNameTh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblID
            // 
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
            this.txtLName_En.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "LNAME_EN", true));
            this.txtLName_En.IsRequired = true;
            this.txtLName_En.Location = new System.Drawing.Point(468, 80);
            this.txtLName_En.MinLength = 0;
            this.txtLName_En.Name = "txtLName_En";
            this.txtLName_En.Size = new System.Drawing.Size(200, 23);
            this.txtLName_En.TabIndex = 5;
            this.txtLName_En.TextValue = null;
            // 
            // txtFName_En
            // 
            this.txtFName_En.CausesValidation = false;
            this.txtFName_En.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "FNAME_EN", true));
            this.txtFName_En.IsRequired = true;
            this.txtFName_En.Location = new System.Drawing.Point(131, 80);
            this.txtFName_En.MinLength = 0;
            this.txtFName_En.Name = "txtFName_En";
            this.txtFName_En.Size = new System.Drawing.Size(200, 23);
            this.txtFName_En.TabIndex = 4;
            this.txtFName_En.TextValue = null;
            // 
            // txtLName_Th
            // 
            this.txtLName_Th.CausesValidation = false;
            this.txtLName_Th.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "LNAME_TH", true));
            this.txtLName_Th.IsRequired = true;
            this.txtLName_Th.Location = new System.Drawing.Point(468, 51);
            this.txtLName_Th.MinLength = 0;
            this.txtLName_Th.Name = "txtLName_Th";
            this.txtLName_Th.Size = new System.Drawing.Size(200, 23);
            this.txtLName_Th.TabIndex = 3;
            this.txtLName_Th.TextValue = null;
            // 
            // txtFName_Th
            // 
            this.txtFName_Th.CausesValidation = false;
            this.txtFName_Th.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "FNAME_TH", true));
            this.txtFName_Th.IsRequired = true;
            this.txtFName_Th.Location = new System.Drawing.Point(131, 51);
            this.txtFName_Th.MinLength = 0;
            this.txtFName_Th.Name = "txtFName_Th";
            this.txtFName_Th.Size = new System.Drawing.Size(200, 23);
            this.txtFName_Th.TabIndex = 2;
            this.txtFName_Th.TextValue = null;
            // 
            // txtID
            // 
            this.txtID.CausesValidation = false;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "ID", true));
            this.txtID.Enabled = false;
            this.txtID.IsRequired = false;
            this.txtID.Location = new System.Drawing.Point(131, 22);
            this.txtID.MinLength = 0;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 23);
            this.txtID.TabIndex = 0;
            this.txtID.TextValue = null;
            // 
            // SYS002_UserProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Name = "SYS002_UserProfile";
            this.OnSave += new System.EventHandler(this.SYS02_UserProfile_OnSave);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs2)).EndInit();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseViews.rLabel lblHeader;
        private System.Windows.Forms.BindingSource bs2;
        private BaseViews.rGroupBox gbPassword;
        private BaseViews.rLabel lblPasswordConfirm;
        private BaseViews.rLabel lblPasswordNew;
        private BaseViews.rLabel lblPassword;
        private BaseViews.rTextBox txtPasswordConfirm;
        private BaseViews.rTextBox txtPasswordNew;
        private BaseViews.rTextBox txtPassword;
        private BaseViews.rGroupBox gbMain;
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
        private BaseViews.rComboBox cboGroup;
        private BaseViews.rComboBox cboPosition;
        private BaseViews.rComboBox cboDivision;
        private BaseViews.rLabel lblSubDivision;
        private BaseViews.rComboBox cboSubDivision;
        private BaseViews.rLabel lblPreName;
        private BaseViews.rComboBox cboPreName;
        private BaseViews.rLabel lblStartDate;
        private BaseViews.rLabel lblBirthDate;
        private BaseViews.rLabel lblNickName;
        private BaseViews.rTextBox txtNickName;
        private BaseViews.rDateTextBox dtBirthDate;
        private BaseViews.rDateTextBox dtStartDate;
        private BaseViews.rMaskedTextBox txtIDCard;
        private BaseViews.rLabel lblIDCard;
        private BaseViews.rGroupBox gbPicture;
        private System.Windows.Forms.PictureBox picBox;
        private BaseViews.rLabel lblLabSupervisorNo;
        private BaseViews.rTextBox txtLabSupervisorNo;
        private BaseViews.rLabel lblRegistrationNo;
        private BaseViews.rTextBox txtRegistrationNo;
    }
}
