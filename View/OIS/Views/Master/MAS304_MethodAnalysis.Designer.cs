namespace OIS.Views
{
    partial class MAS304_MethodAnalysis
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
            this.gbResult = new OIS.BaseViews.rGroupBox();
            this.gvResult = new OIS.BaseViews.rDataGridView();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTITUTION_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_MACHINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_MACHINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_MACHINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCriteria = new OIS.BaseViews.rGroupBox();
            this.lblInstitution = new OIS.BaseViews.rLabel();
            this.cboInstitution = new OIS.BaseViews.rComboBox();
            this.chkShowDeleteRecord = new System.Windows.Forms.CheckBox();
            this.lblName = new OIS.BaseViews.rLabel();
            this.txtName = new OIS.BaseViews.rTextBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.gbCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbResult);
            this.pnlMain.Controls.Add(this.gbCriteria);
            this.pnlMain.Controls.Add(this.lblHeader);
            // 
            // bdSource
            // 
            this.bdSource.DataSource = typeof(OIS.MAS.DTO.Criteria.MAS304_MethodAnalysis_Criteria);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(117, 33);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Method";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.gvResult);
            this.gbResult.Location = new System.Drawing.Point(9, 122);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(846, 317);
            this.gbResult.TabIndex = 13;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "รายการ";
            // 
            // gvResult
            // 
            this.gvResult.AllowUserToAddRows = false;
            this.gvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvResult.ColumnHeadersHeight = 40;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.INSTITUTION_NAME,
            this.SEQ,
            this.CRT_NAME,
            this.CRT_DATE,
            this.CRT_MACHINE,
            this.UPD_NAME,
            this.UPD_DATE,
            this.UPD_MACHINE,
            this.DEL_NAME,
            this.DEL_DATE,
            this.DEL_MACHINE,
            this.ID,
            this.CRT_ID,
            this.UPD_ID,
            this.DEL_ID});
            this.gvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvResult.EnterToAddRow = true;
            this.gvResult.Location = new System.Drawing.Point(3, 19);
            this.gvResult.Name = "gvResult";
            this.gvResult.Size = new System.Drawing.Size(840, 295);
            this.gvResult.TabIndex = 1;
            this.gvResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResult_CellDoubleClick);
            // 
            // NAME
            // 
            this.NAME.HeaderText = "ชื่อ";
            this.NAME.Name = "NAME";
            // 
            // INSTITUTION_NAME
            // 
            this.INSTITUTION_NAME.HeaderText = "หน่วยงาน";
            this.INSTITUTION_NAME.Name = "INSTITUTION_NAME";
            // 
            // SEQ
            // 
            this.SEQ.HeaderText = "ลำดับ";
            this.SEQ.Name = "SEQ";
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
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
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
            // gbCriteria
            // 
            this.gbCriteria.Controls.Add(this.lblInstitution);
            this.gbCriteria.Controls.Add(this.cboInstitution);
            this.gbCriteria.Controls.Add(this.chkShowDeleteRecord);
            this.gbCriteria.Controls.Add(this.lblName);
            this.gbCriteria.Controls.Add(this.txtName);
            this.gbCriteria.Location = new System.Drawing.Point(9, 36);
            this.gbCriteria.Name = "gbCriteria";
            this.gbCriteria.Size = new System.Drawing.Size(846, 80);
            this.gbCriteria.TabIndex = 12;
            this.gbCriteria.TabStop = false;
            this.gbCriteria.Text = "ค้นหา";
            // 
            // lblInstitution
            // 
            this.lblInstitution.AutoSize = true;
            this.lblInstitution.Location = new System.Drawing.Point(450, 25);
            this.lblInstitution.Name = "lblInstitution";
            this.lblInstitution.Size = new System.Drawing.Size(67, 16);
            this.lblInstitution.TabIndex = 50;
            this.lblInstitution.Text = "หน่วยงาน :";
            this.lblInstitution.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboInstitution
            // 
            this.cboInstitution.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboInstitution.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bdSource, "INSTITUTION_STD_ID", true));
            this.cboInstitution.FormattingEnabled = true;
            this.cboInstitution.IsRequired = false;
            this.cboInstitution.Location = new System.Drawing.Point(523, 22);
            this.cboInstitution.Name = "cboInstitution";
            this.cboInstitution.NullableIntValue = null;
            this.cboInstitution.Size = new System.Drawing.Size(250, 24);
            this.cboInstitution.StringValue = null;
            this.cboInstitution.TabIndex = 49;
            // 
            // chkShowDeleteRecord
            // 
            this.chkShowDeleteRecord.AutoSize = true;
            this.chkShowDeleteRecord.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdSource, "SHOW_DELETE_RECORD", true));
            this.chkShowDeleteRecord.Location = new System.Drawing.Point(140, 51);
            this.chkShowDeleteRecord.Name = "chkShowDeleteRecord";
            this.chkShowDeleteRecord.Size = new System.Drawing.Size(158, 20);
            this.chkShowDeleteRecord.TabIndex = 48;
            this.chkShowDeleteRecord.Text = "แสดงรายการที่ถูกยกเลิก";
            this.chkShowDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(101, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 16);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "ชื่อ :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "NAME", true));
            this.txtName.IsRequired = false;
            this.txtName.Location = new System.Drawing.Point(140, 22);
            this.txtName.MinLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TextValue = null;
            // 
            // MAS304_MethodAnalysis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ExportGrid = this.gvResult;
            this.Name = "MAS304_MethodAnalysis";
            this.OnNew += new System.EventHandler(this.MAS304_MethodAnalysis_OnNew);
            this.OnSearch += new System.EventHandler(this.MAS304_MethodAnalysis_OnSearch);
            this.OnClear += new System.EventHandler(this.MAS304_MethodAnalysis_OnClear);
            this.Load += new System.EventHandler(this.MAS304_MethodAnalysis_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.gbCriteria.ResumeLayout(false);
            this.gbCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseViews.rLabel lblHeader;
        private BaseViews.rGroupBox gbResult;
        private BaseViews.rDataGridView gvResult;
        private BaseViews.rGroupBox gbCriteria;
        private System.Windows.Forms.CheckBox chkShowDeleteRecord;
        private BaseViews.rLabel lblName;
        private BaseViews.rTextBox txtName;
        private BaseViews.rLabel lblInstitution;
        private BaseViews.rComboBox cboInstitution;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTITUTION_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_MACHINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_MACHINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_MACHINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_ID;
    }
}
