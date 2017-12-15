namespace OIS.Views
{
    partial class MAS103_SubDivision
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.gbMain = new OIS.BaseViews.rGroupBox();
            this.gvResult = new OIS.BaseViews.rDataGridView();
            this.NAME_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIVISION_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_MACHINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_MACHINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_MACHINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIVISION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCriteria = new OIS.BaseViews.rGroupBox();
            this.cboDivision = new OIS.BaseViews.rComboBox();
            this.lblName = new OIS.BaseViews.rLabel();
            this.txtName = new OIS.BaseViews.rTextBox();
            this.lblDivision = new OIS.BaseViews.rLabel();
            this.chkShowDeleteRecord = new System.Windows.Forms.CheckBox();
            this.pnlMain.SuspendLayout();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.gbCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbCriteria);
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
            this.lblHeader.Size = new System.Drawing.Size(88, 33);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "แผนก";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Controls.Add(this.gvResult);
            this.gbMain.Location = new System.Drawing.Point(9, 125);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(846, 314);
            this.gbMain.TabIndex = 3;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "รายการ";
            // 
            // gvResult
            // 
            this.gvResult.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.gvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvResult.ColumnHeadersHeight = 40;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME_EN,
            this.NAME_TH,
            this.DIVISION_NAME,
            this.SEQ,
            this.CRT_FULLNAME,
            this.CRT_DATE,
            this.CRT_MACHINE,
            this.UPD_FULLNAME,
            this.UPD_DATE,
            this.UPD_MACHINE,
            this.DEL_FULLNAME,
            this.DEL_DATE,
            this.DEL_MACHINE,
            this.ID,
            this.DIVISION_ID,
            this.CRT_ID,
            this.UPD_ID,
            this.DEL_ID});
            this.gvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvResult.Location = new System.Drawing.Point(3, 19);
            this.gvResult.Name = "gvResult";
            this.gvResult.Size = new System.Drawing.Size(840, 292);
            this.gvResult.TabIndex = 0;
            this.gvResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResult_CellDoubleClick);
            // 
            // NAME_EN
            // 
            this.NAME_EN.DataPropertyName = "NAME_EN";
            this.NAME_EN.FillWeight = 141.585F;
            this.NAME_EN.HeaderText = "ชื่อแผนก (อังกฤษ)";
            this.NAME_EN.Name = "NAME_EN";
            this.NAME_EN.Width = 300;
            // 
            // NAME_TH
            // 
            this.NAME_TH.DataPropertyName = "NAME_TH";
            this.NAME_TH.FillWeight = 108.6892F;
            this.NAME_TH.HeaderText = "ชื่อแผนก (ไทย)";
            this.NAME_TH.Name = "NAME_TH";
            this.NAME_TH.Width = 300;
            // 
            // DIVISION_NAME
            // 
            this.DIVISION_NAME.HeaderText = "ฝ่าย";
            this.DIVISION_NAME.Name = "DIVISION_NAME";
            this.DIVISION_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DIVISION_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DIVISION_NAME.Width = 300;
            // 
            // SEQ
            // 
            this.SEQ.DataPropertyName = "SEQ";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.SEQ.DefaultCellStyle = dataGridViewCellStyle3;
            this.SEQ.FillWeight = 88.83887F;
            this.SEQ.HeaderText = "ลำดับ";
            this.SEQ.Name = "SEQ";
            this.SEQ.Width = 63;
            // 
            // CRT_FULLNAME
            // 
            this.CRT_FULLNAME.DataPropertyName = "CRT_FULLNAME";
            this.CRT_FULLNAME.FillWeight = 90.87174F;
            this.CRT_FULLNAME.HeaderText = "ผู้สร้าง";
            this.CRT_FULLNAME.Name = "CRT_FULLNAME";
            this.CRT_FULLNAME.ReadOnly = true;
            this.CRT_FULLNAME.Width = 67;
            // 
            // CRT_DATE
            // 
            this.CRT_DATE.DataPropertyName = "CRT_DATE";
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.CRT_DATE.DefaultCellStyle = dataGridViewCellStyle4;
            this.CRT_DATE.FillWeight = 106.5916F;
            this.CRT_DATE.HeaderText = "วันที่สร้าง";
            this.CRT_DATE.Name = "CRT_DATE";
            this.CRT_DATE.ReadOnly = true;
            // 
            // CRT_MACHINE
            // 
            this.CRT_MACHINE.DataPropertyName = "CRT_MACHINE";
            this.CRT_MACHINE.FillWeight = 122.3777F;
            this.CRT_MACHINE.HeaderText = "เครื่องที่สร้าง";
            this.CRT_MACHINE.Name = "CRT_MACHINE";
            this.CRT_MACHINE.ReadOnly = true;
            // 
            // UPD_FULLNAME
            // 
            this.UPD_FULLNAME.DataPropertyName = "UPD_FULLNAME";
            this.UPD_FULLNAME.FillWeight = 115.0406F;
            this.UPD_FULLNAME.HeaderText = "ผู้แก้ไขล่าสุด";
            this.UPD_FULLNAME.Name = "UPD_FULLNAME";
            this.UPD_FULLNAME.ReadOnly = true;
            this.UPD_FULLNAME.Width = 102;
            // 
            // UPD_DATE
            // 
            this.UPD_DATE.DataPropertyName = "UPD_DATE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "g";
            dataGridViewCellStyle5.NullValue = null;
            this.UPD_DATE.DefaultCellStyle = dataGridViewCellStyle5;
            this.UPD_DATE.FillWeight = 121.8119F;
            this.UPD_DATE.HeaderText = "วันที่แก้ไขล่าสุด";
            this.UPD_DATE.Name = "UPD_DATE";
            this.UPD_DATE.ReadOnly = true;
            // 
            // UPD_MACHINE
            // 
            this.UPD_MACHINE.DataPropertyName = "UPD_MACHINE";
            this.UPD_MACHINE.FillWeight = 99.32052F;
            this.UPD_MACHINE.HeaderText = "เครื่องที่แก้ไข";
            this.UPD_MACHINE.Name = "UPD_MACHINE";
            this.UPD_MACHINE.ReadOnly = true;
            this.UPD_MACHINE.Width = 105;
            // 
            // DEL_FULLNAME
            // 
            this.DEL_FULLNAME.DataPropertyName = "DEL_FULLNAME";
            this.DEL_FULLNAME.FillWeight = 75.58643F;
            this.DEL_FULLNAME.HeaderText = "ผู้ที่ยกเลิก";
            this.DEL_FULLNAME.Name = "DEL_FULLNAME";
            this.DEL_FULLNAME.ReadOnly = true;
            this.DEL_FULLNAME.Width = 86;
            // 
            // DEL_DATE
            // 
            this.DEL_DATE.DataPropertyName = "DEL_DATE";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "g";
            this.DEL_DATE.DefaultCellStyle = dataGridViewCellStyle6;
            this.DEL_DATE.FillWeight = 77.43581F;
            this.DEL_DATE.HeaderText = "วันที่ยกเลิก";
            this.DEL_DATE.Name = "DEL_DATE";
            this.DEL_DATE.ReadOnly = true;
            // 
            // DEL_MACHINE
            // 
            this.DEL_MACHINE.DataPropertyName = "DEL_MACHINE";
            this.DEL_MACHINE.FillWeight = 88.23704F;
            this.DEL_MACHINE.HeaderText = "เครื่องที่ยกเลิก";
            this.DEL_MACHINE.Name = "DEL_MACHINE";
            this.DEL_MACHINE.ReadOnly = true;
            this.DEL_MACHINE.Width = 110;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // DIVISION_ID
            // 
            this.DIVISION_ID.HeaderText = "DIVISION_ID";
            this.DIVISION_ID.Name = "DIVISION_ID";
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
            this.gbCriteria.Controls.Add(this.chkShowDeleteRecord);
            this.gbCriteria.Controls.Add(this.cboDivision);
            this.gbCriteria.Controls.Add(this.lblName);
            this.gbCriteria.Controls.Add(this.txtName);
            this.gbCriteria.Controls.Add(this.lblDivision);
            this.gbCriteria.Location = new System.Drawing.Point(9, 36);
            this.gbCriteria.Name = "gbCriteria";
            this.gbCriteria.Size = new System.Drawing.Size(847, 83);
            this.gbCriteria.TabIndex = 7;
            this.gbCriteria.TabStop = false;
            this.gbCriteria.Text = "ค้นหา";
            // 
            // cboDivision
            // 
            this.cboDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboDivision.FormattingEnabled = true;
            this.cboDivision.IsRequired = false;
            this.cboDivision.Location = new System.Drawing.Point(140, 21);
            this.cboDivision.Name = "cboDivision";
            this.cboDivision.NullableIntValue = null;
            this.cboDivision.Size = new System.Drawing.Size(250, 24);
            this.cboDivision.StringValue = null;
            this.cboDivision.TabIndex = 43;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(424, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 16);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "ชื่อแผนก :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.IsRequired = false;
            this.txtName.Location = new System.Drawing.Point(495, 22);
            this.txtName.MinLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TextValue = null;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(95, 25);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(39, 16);
            this.lblDivision.TabIndex = 38;
            this.lblDivision.Text = "ฝ่าย :";
            this.lblDivision.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chkShowDeleteRecord
            // 
            this.chkShowDeleteRecord.AutoSize = true;
            this.chkShowDeleteRecord.Location = new System.Drawing.Point(140, 51);
            this.chkShowDeleteRecord.Name = "chkShowDeleteRecord";
            this.chkShowDeleteRecord.Size = new System.Drawing.Size(158, 20);
            this.chkShowDeleteRecord.TabIndex = 46;
            this.chkShowDeleteRecord.Text = "แสดงรายการที่ถูกยกเลิก";
            this.chkShowDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // MAS103_SubDivision
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ExportGrid = this.gvResult;
            this.Name = "MAS103_SubDivision";
            this.OnNew += new System.EventHandler(this.MAS103_SubDivision_OnNew);
            this.OnSearch += new System.EventHandler(this.MAS103_SubDivision_OnSearch);
            this.OnClear += new System.EventHandler(this.MAS103_SubDivision_OnClear);
            this.Load += new System.EventHandler(this.MAS103_SubDivision_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.gbCriteria.ResumeLayout(false);
            this.gbCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseViews.rLabel lblHeader;
        private BaseViews.rGroupBox gbMain;
        private BaseViews.rDataGridView gvResult;
        private BaseViews.rGroupBox gbCriteria;
        private BaseViews.rLabel lblName;
        private BaseViews.rTextBox txtName;
        private BaseViews.rLabel lblDivision;
        private BaseViews.rComboBox cboDivision;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_TH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIVISION_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_MACHINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_MACHINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_MACHINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIVISION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_ID;
        private System.Windows.Forms.CheckBox chkShowDeleteRecord;
    }
}
