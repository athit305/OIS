namespace OIS.Views
{
    partial class MAS308_ToolPick
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
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.gbCriteria = new OIS.BaseViews.rGroupBox();
            this.chkShowDeleteRecord = new System.Windows.Forms.CheckBox();
            this.lblName = new OIS.BaseViews.rLabel();
            this.txtName = new OIS.BaseViews.rTextBox();
            this.gbResult = new OIS.BaseViews.rGroupBox();
            this.gvResult = new OIS.BaseViews.rDataGridView();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
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
            // bdSource
            // 
            this.bdSource.DataSource = typeof(OIS.MAS.DTO.Criteria.MAS308_ToolPick_Criteria);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(266, 33);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "เครื่องมือเก็บตัวอย่าง";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbCriteria
            // 
            this.gbCriteria.Controls.Add(this.chkShowDeleteRecord);
            this.gbCriteria.Controls.Add(this.lblName);
            this.gbCriteria.Controls.Add(this.txtName);
            this.gbCriteria.Location = new System.Drawing.Point(9, 36);
            this.gbCriteria.Name = "gbCriteria";
            this.gbCriteria.Size = new System.Drawing.Size(846, 81);
            this.gbCriteria.TabIndex = 5;
            this.gbCriteria.TabStop = false;
            this.gbCriteria.Text = "ค้นหา";
            // 
            // chkShowDeleteRecord
            // 
            this.chkShowDeleteRecord.AutoSize = true;
            this.chkShowDeleteRecord.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdSource, "SHOW_DELETE_RECORD", true));
            this.chkShowDeleteRecord.Location = new System.Drawing.Point(140, 51);
            this.chkShowDeleteRecord.Name = "chkShowDeleteRecord";
            this.chkShowDeleteRecord.Size = new System.Drawing.Size(158, 20);
            this.chkShowDeleteRecord.TabIndex = 46;
            this.chkShowDeleteRecord.Text = "แสดงรายการที่ถูกยกเลิก";
            this.chkShowDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 16);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "ชื่อเครื่องมือ :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bdSource, "NAME", true));
            this.txtName.IsRequired = false;
            this.txtName.Location = new System.Drawing.Point(140, 22);
            this.txtName.MinLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 37;
            this.txtName.TextValue = null;
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.gvResult);
            this.gbResult.Location = new System.Drawing.Point(9, 123);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(846, 316);
            this.gbResult.TabIndex = 6;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "รายการ";
            // 
            // gvResult
            // 
            this.gvResult.AllowDrop = true;
            this.gvResult.AllowUserToAddRows = false;
            this.gvResult.ColumnHeadersHeight = 40;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
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
            this.gvResult.Size = new System.Drawing.Size(840, 294);
            this.gvResult.TabIndex = 0;
            this.gvResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResult_CellDoubleClick);
            // 
            // NAME
            // 
            this.NAME.HeaderText = "ชื่อเครื่องมือ";
            this.NAME.Name = "NAME";
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
            // MAS308_ToolPick
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ExportGrid = this.gvResult;
            this.Name = "MAS308_ToolPick";
            this.OnNew += new System.EventHandler(this.MAS308_ToolPick_OnNew);
            this.OnSearch += new System.EventHandler(this.MAS308_ToolPick_OnSearch);
            this.OnClear += new System.EventHandler(this.MAS308_ToolPick_OnClear);
            this.Load += new System.EventHandler(this.MAS308_ToolPick_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.gbCriteria.ResumeLayout(false);
            this.gbCriteria.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseViews.rLabel lblHeader;
        private BaseViews.rGroupBox gbCriteria;
        private BaseViews.rLabel lblName;
        private BaseViews.rTextBox txtName;
        private BaseViews.rGroupBox gbResult;
        private BaseViews.rDataGridView gvResult;
        private System.Windows.Forms.CheckBox chkShowDeleteRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
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
