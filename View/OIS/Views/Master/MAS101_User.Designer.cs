namespace OIS.Views
{
    partial class MAS101_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.gbCriteria = new OIS.BaseViews.rGroupBox();
            this.lblGroup = new OIS.BaseViews.rLabel();
            this.cboGroup = new OIS.BaseViews.rComboBox();
            this.lblPosition = new OIS.BaseViews.rLabel();
            this.cboPosition = new OIS.BaseViews.rComboBox();
            this.lblDivision = new OIS.BaseViews.rLabel();
            this.cboDivision = new OIS.BaseViews.rComboBox();
            this.lblName = new OIS.BaseViews.rLabel();
            this.txtName = new OIS.BaseViews.rTextBox();
            this.lblID = new OIS.BaseViews.rLabel();
            this.txtID = new OIS.BaseViews.rTextBox();
            this.lblSubDivision = new OIS.BaseViews.rLabel();
            this.cboSubDivision = new OIS.BaseViews.rComboBox();
            this.gbResult = new OIS.BaseViews.rGroupBox();
            this.gvResult = new OIS.BaseViews.rDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME_TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NICKNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIVISION_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBDIVISION_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITION_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GROUP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIRTHDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STARTDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_MACHINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_MACHINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_MACHINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENAME_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNAME_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LNAME_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNAME_TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LNAME_TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIVISION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBDIVISION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GROUP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkShowDeleteRecord = new System.Windows.Forms.CheckBox();
            this.pnlMain.SuspendLayout();
            this.gbCriteria.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbResult);
            this.pnlMain.Controls.Add(this.gbCriteria);
            this.pnlMain.Controls.Add(this.lblHeader);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(120, 33);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "พนักงาน";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbCriteria
            // 
            this.gbCriteria.Controls.Add(this.chkShowDeleteRecord);
            this.gbCriteria.Controls.Add(this.lblGroup);
            this.gbCriteria.Controls.Add(this.cboGroup);
            this.gbCriteria.Controls.Add(this.lblPosition);
            this.gbCriteria.Controls.Add(this.cboPosition);
            this.gbCriteria.Controls.Add(this.lblDivision);
            this.gbCriteria.Controls.Add(this.cboDivision);
            this.gbCriteria.Controls.Add(this.lblName);
            this.gbCriteria.Controls.Add(this.txtName);
            this.gbCriteria.Controls.Add(this.lblID);
            this.gbCriteria.Controls.Add(this.txtID);
            this.gbCriteria.Controls.Add(this.lblSubDivision);
            this.gbCriteria.Controls.Add(this.cboSubDivision);
            this.gbCriteria.Location = new System.Drawing.Point(9, 36);
            this.gbCriteria.Name = "gbCriteria";
            this.gbCriteria.Size = new System.Drawing.Size(846, 144);
            this.gbCriteria.TabIndex = 4;
            this.gbCriteria.TabStop = false;
            this.gbCriteria.Text = "ค้นหา";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(426, 84);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(63, 16);
            this.lblGroup.TabIndex = 44;
            this.lblGroup.Text = "กลุ่มผู้ใช้ :";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboGroup
            // 
            this.cboGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.IsRequired = false;
            this.cboGroup.Location = new System.Drawing.Point(495, 81);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.NullableIntValue = null;
            this.cboGroup.Size = new System.Drawing.Size(250, 24);
            this.cboGroup.StringValue = null;
            this.cboGroup.TabIndex = 43;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(73, 84);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(61, 16);
            this.lblPosition.TabIndex = 42;
            this.lblPosition.Text = "ตำแหน่ง :";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboPosition
            // 
            this.cboPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.IsRequired = false;
            this.cboPosition.Location = new System.Drawing.Point(140, 81);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.NullableIntValue = null;
            this.cboPosition.Size = new System.Drawing.Size(250, 24);
            this.cboPosition.StringValue = null;
            this.cboPosition.TabIndex = 41;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(95, 54);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(39, 16);
            this.lblDivision.TabIndex = 40;
            this.lblDivision.Text = "ฝ่าย :";
            this.lblDivision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboDivision
            // 
            this.cboDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDivision.FormattingEnabled = true;
            this.cboDivision.IsRequired = false;
            this.cboDivision.Location = new System.Drawing.Point(140, 51);
            this.cboDivision.Name = "cboDivision";
            this.cboDivision.NullableIntValue = null;
            this.cboDivision.Size = new System.Drawing.Size(250, 24);
            this.cboDivision.StringValue = null;
            this.cboDivision.TabIndex = 39;
            this.cboDivision.SelectedIndexChanged += new System.EventHandler(this.cboDivision_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(456, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 16);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "ชื่อ :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.IsRequired = false;
            this.txtName.Location = new System.Drawing.Point(495, 22);
            this.txtName.MinLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 37;
            this.txtName.TextValue = null;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(50, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(84, 16);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "รหัสพนักงาน :";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtID
            // 
            this.txtID.IsRequired = false;
            this.txtID.Location = new System.Drawing.Point(140, 22);
            this.txtID.MinLength = 0;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 23);
            this.txtID.TabIndex = 33;
            this.txtID.TextValue = null;
            // 
            // lblSubDivision
            // 
            this.lblSubDivision.AutoSize = true;
            this.lblSubDivision.Location = new System.Drawing.Point(440, 54);
            this.lblSubDivision.Name = "lblSubDivision";
            this.lblSubDivision.Size = new System.Drawing.Size(49, 16);
            this.lblSubDivision.TabIndex = 35;
            this.lblSubDivision.Text = "แผนก :";
            this.lblSubDivision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboSubDivision
            // 
            this.cboSubDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboSubDivision.FormattingEnabled = true;
            this.cboSubDivision.IsRequired = false;
            this.cboSubDivision.Location = new System.Drawing.Point(495, 51);
            this.cboSubDivision.Name = "cboSubDivision";
            this.cboSubDivision.NullableIntValue = null;
            this.cboSubDivision.Size = new System.Drawing.Size(250, 24);
            this.cboSubDivision.StringValue = null;
            this.cboSubDivision.TabIndex = 34;
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.gvResult);
            this.gbResult.Location = new System.Drawing.Point(9, 186);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(846, 254);
            this.gbResult.TabIndex = 5;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "รายการ";
            // 
            // gvResult
            // 
            this.gvResult.AllowUserToAddRows = false;
            this.gvResult.ColumnHeadersHeight = 40;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FULLNAME_EN,
            this.FULLNAME_TH,
            this.NICKNAME,
            this.DIVISION_NAME,
            this.SUBDIVISION_NAME,
            this.POSITION_NAME,
            this.GROUP_NAME,
            this.BIRTHDATE,
            this.STARTDATE,
            this.CRT_NAME,
            this.CRT_DATE,
            this.CRT_MACHINE,
            this.UPD_NAME,
            this.UPD_DATE,
            this.UPD_MACHINE,
            this.DEL_NAME,
            this.DEL_DATE,
            this.DEL_MACHINE,
            this.PRENAME_ID,
            this.FNAME_EN,
            this.LNAME_EN,
            this.FNAME_TH,
            this.LNAME_TH,
            this.DIVISION_ID,
            this.SUBDIVISION_ID,
            this.POSITION_ID,
            this.GROUP_ID,
            this.PASS,
            this.CRT_ID,
            this.UPD_ID,
            this.DEL_ID});
            this.gvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvResult.Location = new System.Drawing.Point(3, 19);
            this.gvResult.Name = "gvResult";
            this.gvResult.Size = new System.Drawing.Size(840, 232);
            this.gvResult.TabIndex = 0;
            this.gvResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResult_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "รหัสพนักงาน";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FULLNAME_EN
            // 
            this.FULLNAME_EN.HeaderText = "ชื่อ-สกุล (อังกฤษ)";
            this.FULLNAME_EN.Name = "FULLNAME_EN";
            // 
            // FULLNAME_TH
            // 
            this.FULLNAME_TH.HeaderText = "ชื่อ-สกุล (ไทย)";
            this.FULLNAME_TH.Name = "FULLNAME_TH";
            // 
            // NICKNAME
            // 
            this.NICKNAME.HeaderText = "ชื่อเล่น";
            this.NICKNAME.Name = "NICKNAME";
            // 
            // DIVISION_NAME
            // 
            this.DIVISION_NAME.HeaderText = "ฝ่าย";
            this.DIVISION_NAME.Name = "DIVISION_NAME";
            // 
            // SUBDIVISION_NAME
            // 
            this.SUBDIVISION_NAME.HeaderText = "แผนก";
            this.SUBDIVISION_NAME.Name = "SUBDIVISION_NAME";
            // 
            // POSITION_NAME
            // 
            this.POSITION_NAME.HeaderText = "ตำแหน่ง";
            this.POSITION_NAME.Name = "POSITION_NAME";
            // 
            // GROUP_NAME
            // 
            this.GROUP_NAME.HeaderText = "กลุ่มผู้ใช้";
            this.GROUP_NAME.Name = "GROUP_NAME";
            // 
            // BIRTHDATE
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.BIRTHDATE.DefaultCellStyle = dataGridViewCellStyle1;
            this.BIRTHDATE.HeaderText = "วันเกิด";
            this.BIRTHDATE.Name = "BIRTHDATE";
            // 
            // STARTDATE
            // 
            this.STARTDATE.HeaderText = "วันที่เริ่มทำงาน";
            this.STARTDATE.Name = "STARTDATE";
            // 
            // CRT_NAME
            // 
            this.CRT_NAME.HeaderText = "ผู้สร้าง";
            this.CRT_NAME.Name = "CRT_NAME";
            // 
            // CRT_DATE
            // 
            this.CRT_DATE.HeaderText = "วันที่สร้าง";
            this.CRT_DATE.Name = "CRT_DATE";
            // 
            // CRT_MACHINE
            // 
            this.CRT_MACHINE.HeaderText = "เครื่องที่สร้าง";
            this.CRT_MACHINE.Name = "CRT_MACHINE";
            // 
            // UPD_NAME
            // 
            this.UPD_NAME.HeaderText = "ผู้แก้ไข";
            this.UPD_NAME.Name = "UPD_NAME";
            // 
            // UPD_DATE
            // 
            this.UPD_DATE.HeaderText = "วันที่แก้ไข";
            this.UPD_DATE.Name = "UPD_DATE";
            // 
            // UPD_MACHINE
            // 
            this.UPD_MACHINE.HeaderText = "เครื่องที่แก้ไข";
            this.UPD_MACHINE.Name = "UPD_MACHINE";
            // 
            // DEL_NAME
            // 
            this.DEL_NAME.HeaderText = "ผู้ยกเลิก";
            this.DEL_NAME.Name = "DEL_NAME";
            // 
            // DEL_DATE
            // 
            this.DEL_DATE.HeaderText = "วันที่ยกเลิก";
            this.DEL_DATE.Name = "DEL_DATE";
            // 
            // DEL_MACHINE
            // 
            this.DEL_MACHINE.HeaderText = "เครื่องที่ยกเลิก";
            this.DEL_MACHINE.Name = "DEL_MACHINE";
            // 
            // PRENAME_ID
            // 
            this.PRENAME_ID.HeaderText = "PRENAME_ID";
            this.PRENAME_ID.Name = "PRENAME_ID";
            // 
            // FNAME_EN
            // 
            this.FNAME_EN.HeaderText = "FNAME_EN";
            this.FNAME_EN.Name = "FNAME_EN";
            // 
            // LNAME_EN
            // 
            this.LNAME_EN.HeaderText = "LNAME_EN";
            this.LNAME_EN.Name = "LNAME_EN";
            // 
            // FNAME_TH
            // 
            this.FNAME_TH.HeaderText = "FNAME_TH";
            this.FNAME_TH.Name = "FNAME_TH";
            // 
            // LNAME_TH
            // 
            this.LNAME_TH.HeaderText = "LNAME_TH";
            this.LNAME_TH.Name = "LNAME_TH";
            // 
            // DIVISION_ID
            // 
            this.DIVISION_ID.HeaderText = "DIVISION_ID";
            this.DIVISION_ID.Name = "DIVISION_ID";
            // 
            // SUBDIVISION_ID
            // 
            this.SUBDIVISION_ID.HeaderText = "SUBDIVISION_ID";
            this.SUBDIVISION_ID.Name = "SUBDIVISION_ID";
            // 
            // POSITION_ID
            // 
            this.POSITION_ID.HeaderText = "POSITION_ID";
            this.POSITION_ID.Name = "POSITION_ID";
            // 
            // GROUP_ID
            // 
            this.GROUP_ID.HeaderText = "GROUP_ID";
            this.GROUP_ID.Name = "GROUP_ID";
            // 
            // PASS
            // 
            this.PASS.HeaderText = "PASS";
            this.PASS.Name = "PASS";
            // 
            // CRT_ID
            // 
            this.CRT_ID.HeaderText = "CRT_ID";
            this.CRT_ID.Name = "CRT_ID";
            // 
            // UPD_ID
            // 
            this.UPD_ID.HeaderText = "UPD_ID";
            this.UPD_ID.Name = "UPD_ID";
            // 
            // DEL_ID
            // 
            this.DEL_ID.HeaderText = "DEL_ID";
            this.DEL_ID.Name = "DEL_ID";
            // 
            // chkShowDeleteRecord
            // 
            this.chkShowDeleteRecord.AutoSize = true;
            this.chkShowDeleteRecord.Location = new System.Drawing.Point(140, 111);
            this.chkShowDeleteRecord.Name = "chkShowDeleteRecord";
            this.chkShowDeleteRecord.Size = new System.Drawing.Size(158, 20);
            this.chkShowDeleteRecord.TabIndex = 45;
            this.chkShowDeleteRecord.Text = "แสดงรายการที่ถูกยกเลิก";
            this.chkShowDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // MAS101_User
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ExportGrid = this.gvResult;
            this.Name = "MAS101_User";
            this.OnNew += new System.EventHandler(this.MAS101_User_OnNew);
            this.OnSearch += new System.EventHandler(this.MAS101_User_OnSearch);
            this.OnClear += new System.EventHandler(this.MAS101_User_OnClear);
            this.Load += new System.EventHandler(this.MAS101_User_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbCriteria.ResumeLayout(false);
            this.gbCriteria.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BaseViews.rGroupBox gbCriteria;
        private BaseViews.rLabel lblHeader;
        private BaseViews.rDataGridView gvResult;
        private BaseViews.rLabel lblID;
        private BaseViews.rTextBox txtID;
        private BaseViews.rLabel lblSubDivision;
        private BaseViews.rComboBox cboSubDivision;
        private BaseViews.rLabel lblGroup;
        private BaseViews.rComboBox cboGroup;
        private BaseViews.rLabel lblPosition;
        private BaseViews.rComboBox cboPosition;
        private BaseViews.rLabel lblDivision;
        private BaseViews.rComboBox cboDivision;
        private BaseViews.rLabel lblName;
        private BaseViews.rTextBox txtName;
        private BaseViews.rGroupBox gbResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME_TH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NICKNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIVISION_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBDIVISION_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSITION_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROUP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIRTHDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STARTDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_MACHINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_MACHINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_MACHINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENAME_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNAME_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LNAME_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNAME_TH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LNAME_TH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIVISION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBDIVISION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSITION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROUP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_ID;
        private System.Windows.Forms.CheckBox chkShowDeleteRecord;
    }
}
