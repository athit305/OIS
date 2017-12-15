namespace OIS.Views
{
    partial class MAS202_CustomerProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbResult = new OIS.BaseViews.rGroupBox();
            this.gvResult = new OIS.BaseViews.rDataGridView();
            this.NAME_TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDR_TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDR_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.chkShowDeleteRecord = new System.Windows.Forms.CheckBox();
            this.lblCustomer = new OIS.BaseViews.rLabel();
            this.lblModel = new OIS.BaseViews.rLabel();
            this.txtAddr = new OIS.BaseViews.rTextBox();
            this.lblName = new OIS.BaseViews.rLabel();
            this.txtName = new OIS.BaseViews.rTextBox();
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.txtCustomer = new OIS.BaseViews.rSearchTextBox();
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
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.gvResult);
            this.gbResult.Location = new System.Drawing.Point(9, 154);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(846, 285);
            this.gbResult.TabIndex = 12;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "รายการ";
            // 
            // gvResult
            // 
            this.gvResult.AllowDrop = true;
            this.gvResult.AllowUserToAddRows = false;
            this.gvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            this.NAME_TH,
            this.NAME_EN,
            this.CUSTOMER_NAME,
            this.ADDR_TH,
            this.ADDR_EN,
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
            this.gvResult.Size = new System.Drawing.Size(840, 263);
            this.gvResult.TabIndex = 0;
            this.gvResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResult_CellDoubleClick);
            // 
            // NAME_TH
            // 
            this.NAME_TH.HeaderText = "ชื่อโครงการ (ไทย)";
            this.NAME_TH.Name = "NAME_TH";
            this.NAME_TH.Width = 200;
            // 
            // NAME_EN
            // 
            this.NAME_EN.HeaderText = "ชื่อโครงการ (อังกฤษ)";
            this.NAME_EN.Name = "NAME_EN";
            this.NAME_EN.Width = 200;
            // 
            // CUSTOMER_NAME
            // 
            this.CUSTOMER_NAME.HeaderText = "ชื่อลูกค้า";
            this.CUSTOMER_NAME.Name = "CUSTOMER_NAME";
            // 
            // ADDR_TH
            // 
            this.ADDR_TH.HeaderText = "ที่อยู่ (ไทย)";
            this.ADDR_TH.Name = "ADDR_TH";
            this.ADDR_TH.Width = 300;
            // 
            // ADDR_EN
            // 
            this.ADDR_EN.HeaderText = "ที่อยู่ (อังกฤษ)";
            this.ADDR_EN.Name = "ADDR_EN";
            this.ADDR_EN.Width = 300;
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
            this.gbCriteria.Controls.Add(this.txtCustomer);
            this.gbCriteria.Controls.Add(this.chkShowDeleteRecord);
            this.gbCriteria.Controls.Add(this.lblCustomer);
            this.gbCriteria.Controls.Add(this.lblModel);
            this.gbCriteria.Controls.Add(this.txtAddr);
            this.gbCriteria.Controls.Add(this.lblName);
            this.gbCriteria.Controls.Add(this.txtName);
            this.gbCriteria.Location = new System.Drawing.Point(9, 36);
            this.gbCriteria.Name = "gbCriteria";
            this.gbCriteria.Size = new System.Drawing.Size(846, 112);
            this.gbCriteria.TabIndex = 11;
            this.gbCriteria.TabStop = false;
            this.gbCriteria.Text = "ค้นหา";
            // 
            // chkShowDeleteRecord
            // 
            this.chkShowDeleteRecord.AutoSize = true;
            this.chkShowDeleteRecord.Location = new System.Drawing.Point(140, 81);
            this.chkShowDeleteRecord.Name = "chkShowDeleteRecord";
            this.chkShowDeleteRecord.Size = new System.Drawing.Size(158, 20);
            this.chkShowDeleteRecord.TabIndex = 46;
            this.chkShowDeleteRecord.Text = "แสดงรายการที่ถูกยกเลิก";
            this.chkShowDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(87, 54);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(47, 16);
            this.lblCustomer.TabIndex = 42;
            this.lblCustomer.Text = "ลูกค้า :";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(447, 25);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(42, 16);
            this.lblModel.TabIndex = 40;
            this.lblModel.Text = "ที่อยู่ :";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAddr
            // 
            this.txtAddr.IsRequired = false;
            this.txtAddr.Location = new System.Drawing.Point(495, 22);
            this.txtAddr.MinLength = 0;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(250, 23);
            this.txtAddr.TabIndex = 2;
            this.txtAddr.TextValue = null;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 16);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "ชื่อโครงการ :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.IsRequired = false;
            this.txtName.Location = new System.Drawing.Point(140, 22);
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
            this.lblHeader.Size = new System.Drawing.Size(241, 33);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "โครงการของลูกค้า";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomer.CausesValidation = false;
            this.txtCustomer.IntValue = null;
            this.txtCustomer.IsRequired = false;
            this.txtCustomer.Location = new System.Drawing.Point(140, 51);
            this.txtCustomer.MinLength = 0;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.OptionalTextBox = null;
            this.txtCustomer.SearchType = OIS.BaseViews.eSearchType.Customer;
            this.txtCustomer.Size = new System.Drawing.Size(605, 23);
            this.txtCustomer.StringValue = null;
            this.txtCustomer.TabIndex = 3;
            this.txtCustomer.TextValue = null;
            // 
            // MAS202_CustomerProject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Name = "MAS202_CustomerProject";
            this.OnNew += new System.EventHandler(this.MAS202_CustomerProject_OnNew);
            this.OnSearch += new System.EventHandler(this.MAS202_CustomerProject_OnSearch);
            this.OnClear += new System.EventHandler(this.MAS202_CustomerProject_OnClear);
            this.Load += new System.EventHandler(this.MAS202_CustomerProject_Load);
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

        private BaseViews.rGroupBox gbResult;
        private BaseViews.rDataGridView gvResult;
        private BaseViews.rGroupBox gbCriteria;
        private BaseViews.rLabel lblModel;
        private BaseViews.rTextBox txtAddr;
        private BaseViews.rLabel lblName;
        private BaseViews.rTextBox txtName;
        private BaseViews.rLabel lblHeader;
        private BaseViews.rLabel lblCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_TH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDR_TH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDR_EN;
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
        private System.Windows.Forms.CheckBox chkShowDeleteRecord;
        private BaseViews.rSearchTextBox txtCustomer;
    }
}
