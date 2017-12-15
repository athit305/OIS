namespace OIS.Views
{
    partial class RPT001_WorkPlaceLightIntensity
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbResult = new OIS.BaseViews.rGroupBox();
            this.gvResult = new OIS.BaseViews.rDataGridView();
            this.REPORTNUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_PROJECT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEASURED_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEASURED_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCriteria = new OIS.BaseViews.rGroupBox();
            this.txtCustomer = new OIS.BaseViews.rSearchTextBox();
            this.txtMeasuredBy = new OIS.BaseViews.rSearchTextBox();
            this.lblMeasuredTo = new OIS.BaseViews.rLabel();
            this.rLabel1 = new OIS.BaseViews.rLabel();
            this.txtInstrument = new OIS.BaseViews.rSearchTextBox();
            this.dtMeasuredDateTo = new OIS.BaseViews.rDateTextBox();
            this.lblMeasuredBy = new OIS.BaseViews.rLabel();
            this.lblMeasuredDate = new OIS.BaseViews.rLabel();
            this.dtMeasuredDate = new OIS.BaseViews.rDateTextBox();
            this.lblModel = new OIS.BaseViews.rLabel();
            this.lblReportNumber = new OIS.BaseViews.rLabel();
            this.txtReportNumber = new OIS.BaseViews.rTextBox();
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.chkShowDeleteRecord = new System.Windows.Forms.CheckBox();
            this.pnlMain.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.ctxMenu.SuspendLayout();
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
            this.gbResult.Location = new System.Drawing.Point(9, 180);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(846, 259);
            this.gbResult.TabIndex = 10;
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
            this.REPORTNUMBER,
            this.CUSTOMER_NAME,
            this.CUSTOMER_PROJECT_NAME,
            this.MEASURED_DATE,
            this.MEASURED_NAME,
            this.INS_NAME,
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
            this.gvResult.ContextMenuStrip = this.ctxMenu;
            this.gvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvResult.Location = new System.Drawing.Point(3, 19);
            this.gvResult.Name = "gvResult";
            this.gvResult.Size = new System.Drawing.Size(840, 237);
            this.gvResult.TabIndex = 0;
            this.gvResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResult_CellDoubleClick);
            // 
            // REPORTNUMBER
            // 
            this.REPORTNUMBER.HeaderText = "Report Numer";
            this.REPORTNUMBER.Name = "REPORTNUMBER";
            // 
            // CUSTOMER_NAME
            // 
            this.CUSTOMER_NAME.HeaderText = "Customer";
            this.CUSTOMER_NAME.Name = "CUSTOMER_NAME";
            // 
            // CUSTOMER_PROJECT_NAME
            // 
            this.CUSTOMER_PROJECT_NAME.HeaderText = "Project";
            this.CUSTOMER_PROJECT_NAME.Name = "CUSTOMER_PROJECT_NAME";
            // 
            // MEASURED_DATE
            // 
            this.MEASURED_DATE.HeaderText = "Measured Date";
            this.MEASURED_DATE.Name = "MEASURED_DATE";
            // 
            // MEASURED_NAME
            // 
            this.MEASURED_NAME.HeaderText = "Measured By";
            this.MEASURED_NAME.Name = "MEASURED_NAME";
            // 
            // INS_NAME
            // 
            this.INS_NAME.HeaderText = "Measured Instrument";
            this.INS_NAME.Name = "INS_NAME";
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
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCopy});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(139, 26);
            this.ctxMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenu_Opening);
            // 
            // miCopy
            // 
            this.miCopy.Name = "miCopy";
            this.miCopy.Size = new System.Drawing.Size(138, 22);
            this.miCopy.Text = "Copy รายการ";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // gbCriteria
            // 
            this.gbCriteria.Controls.Add(this.chkShowDeleteRecord);
            this.gbCriteria.Controls.Add(this.txtCustomer);
            this.gbCriteria.Controls.Add(this.txtMeasuredBy);
            this.gbCriteria.Controls.Add(this.lblMeasuredTo);
            this.gbCriteria.Controls.Add(this.rLabel1);
            this.gbCriteria.Controls.Add(this.txtInstrument);
            this.gbCriteria.Controls.Add(this.dtMeasuredDateTo);
            this.gbCriteria.Controls.Add(this.lblMeasuredBy);
            this.gbCriteria.Controls.Add(this.lblMeasuredDate);
            this.gbCriteria.Controls.Add(this.dtMeasuredDate);
            this.gbCriteria.Controls.Add(this.lblModel);
            this.gbCriteria.Controls.Add(this.lblReportNumber);
            this.gbCriteria.Controls.Add(this.txtReportNumber);
            this.gbCriteria.Location = new System.Drawing.Point(9, 36);
            this.gbCriteria.Name = "gbCriteria";
            this.gbCriteria.Size = new System.Drawing.Size(846, 138);
            this.gbCriteria.TabIndex = 9;
            this.gbCriteria.TabStop = false;
            this.gbCriteria.Text = "ค้นหา";
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
            this.txtCustomer.Size = new System.Drawing.Size(250, 23);
            this.txtCustomer.StringValue = null;
            this.txtCustomer.TabIndex = 4;
            this.txtCustomer.TextValue = null;
            // 
            // txtMeasuredBy
            // 
            this.txtMeasuredBy.BackColor = System.Drawing.SystemColors.Info;
            this.txtMeasuredBy.CausesValidation = false;
            this.txtMeasuredBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMeasuredBy.IntValue = null;
            this.txtMeasuredBy.IsRequired = false;
            this.txtMeasuredBy.Location = new System.Drawing.Point(140, 80);
            this.txtMeasuredBy.MinLength = 0;
            this.txtMeasuredBy.Name = "txtMeasuredBy";
            this.txtMeasuredBy.OptionalTextBox = null;
            this.txtMeasuredBy.SearchType = OIS.BaseViews.eSearchType.User;
            this.txtMeasuredBy.Size = new System.Drawing.Size(250, 23);
            this.txtMeasuredBy.StringValue = null;
            this.txtMeasuredBy.TabIndex = 6;
            this.txtMeasuredBy.TextValue = null;
            // 
            // lblMeasuredTo
            // 
            this.lblMeasuredTo.AutoSize = true;
            this.lblMeasuredTo.Location = new System.Drawing.Point(651, 25);
            this.lblMeasuredTo.Name = "lblMeasuredTo";
            this.lblMeasuredTo.Size = new System.Drawing.Size(13, 16);
            this.lblMeasuredTo.TabIndex = 49;
            this.lblMeasuredTo.Text = "-";
            this.lblMeasuredTo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rLabel1
            // 
            this.rLabel1.AutoSize = true;
            this.rLabel1.Location = new System.Drawing.Point(448, 83);
            this.rLabel1.Name = "rLabel1";
            this.rLabel1.Size = new System.Drawing.Size(79, 16);
            this.rLabel1.TabIndex = 48;
            this.rLabel1.Text = "Instrument :";
            this.rLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtInstrument
            // 
            this.txtInstrument.BackColor = System.Drawing.SystemColors.Info;
            this.txtInstrument.CausesValidation = false;
            this.txtInstrument.IntValue = null;
            this.txtInstrument.IsRequired = false;
            this.txtInstrument.Location = new System.Drawing.Point(533, 80);
            this.txtInstrument.MinLength = 0;
            this.txtInstrument.Name = "txtInstrument";
            this.txtInstrument.OptionalTextBox = null;
            this.txtInstrument.SearchType = OIS.BaseViews.eSearchType.Instrument;
            this.txtInstrument.Size = new System.Drawing.Size(250, 23);
            this.txtInstrument.StringValue = null;
            this.txtInstrument.TabIndex = 7;
            this.txtInstrument.TextValue = null;
            // 
            // dtMeasuredDateTo
            // 
            this.dtMeasuredDateTo.Date = null;
            this.dtMeasuredDateTo.DateValue = null;
            this.dtMeasuredDateTo.IsRequired = false;
            this.dtMeasuredDateTo.Location = new System.Drawing.Point(668, 22);
            this.dtMeasuredDateTo.MaxLength = 10;
            this.dtMeasuredDateTo.MinLength = 0;
            this.dtMeasuredDateTo.Name = "dtMeasuredDateTo";
            this.dtMeasuredDateTo.ShowTime = false;
            this.dtMeasuredDateTo.Size = new System.Drawing.Size(115, 23);
            this.dtMeasuredDateTo.TabIndex = 3;
            this.dtMeasuredDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtMeasuredDateTo.TextValue = null;
            // 
            // lblMeasuredBy
            // 
            this.lblMeasuredBy.AutoSize = true;
            this.lblMeasuredBy.Location = new System.Drawing.Point(44, 83);
            this.lblMeasuredBy.Name = "lblMeasuredBy";
            this.lblMeasuredBy.Size = new System.Drawing.Size(90, 16);
            this.lblMeasuredBy.TabIndex = 46;
            this.lblMeasuredBy.Text = "Measured By :";
            this.lblMeasuredBy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeasuredDate
            // 
            this.lblMeasuredDate.AutoSize = true;
            this.lblMeasuredDate.Location = new System.Drawing.Point(428, 25);
            this.lblMeasuredDate.Name = "lblMeasuredDate";
            this.lblMeasuredDate.Size = new System.Drawing.Size(99, 16);
            this.lblMeasuredDate.TabIndex = 44;
            this.lblMeasuredDate.Text = "Measured Date:";
            this.lblMeasuredDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtMeasuredDate
            // 
            this.dtMeasuredDate.Date = null;
            this.dtMeasuredDate.DateValue = null;
            this.dtMeasuredDate.IsRequired = false;
            this.dtMeasuredDate.Location = new System.Drawing.Point(533, 22);
            this.dtMeasuredDate.MaxLength = 10;
            this.dtMeasuredDate.MinLength = 0;
            this.dtMeasuredDate.Name = "dtMeasuredDate";
            this.dtMeasuredDate.ShowTime = false;
            this.dtMeasuredDate.Size = new System.Drawing.Size(115, 23);
            this.dtMeasuredDate.TabIndex = 2;
            this.dtMeasuredDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtMeasuredDate.TextValue = null;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(62, 54);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(72, 16);
            this.lblModel.TabIndex = 40;
            this.lblModel.Text = "Customer :";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReportNumber
            // 
            this.lblReportNumber.AutoSize = true;
            this.lblReportNumber.Location = new System.Drawing.Point(30, 25);
            this.lblReportNumber.Name = "lblReportNumber";
            this.lblReportNumber.Size = new System.Drawing.Size(104, 16);
            this.lblReportNumber.TabIndex = 38;
            this.lblReportNumber.Text = "Report Number :";
            this.lblReportNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtReportNumber
            // 
            this.txtReportNumber.IsRequired = false;
            this.txtReportNumber.Location = new System.Drawing.Point(140, 22);
            this.txtReportNumber.MinLength = 0;
            this.txtReportNumber.Name = "txtReportNumber";
            this.txtReportNumber.Size = new System.Drawing.Size(250, 23);
            this.txtReportNumber.TabIndex = 1;
            this.txtReportNumber.TextValue = null;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(375, 33);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Work Place Light Intensity";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chkShowDeleteRecord
            // 
            this.chkShowDeleteRecord.AutoSize = true;
            this.chkShowDeleteRecord.Location = new System.Drawing.Point(140, 109);
            this.chkShowDeleteRecord.Name = "chkShowDeleteRecord";
            this.chkShowDeleteRecord.Size = new System.Drawing.Size(158, 20);
            this.chkShowDeleteRecord.TabIndex = 50;
            this.chkShowDeleteRecord.Text = "แสดงรายการที่ถูกยกเลิก";
            this.chkShowDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // RPT001_WorkPlaceLightIntensity
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ExportGrid = this.gvResult;
            this.Name = "RPT001_WorkPlaceLightIntensity";
            this.OnNew += new System.EventHandler(this.RPT01_WorkPlaceLightIntensity_OnNew);
            this.OnSearch += new System.EventHandler(this.RPT01_WorkPlaceLightIntensity_OnSearch);
            this.OnDDPrint_Preview += new System.EventHandler(this.RPT01_WorkPlaceLightIntensity_OnDDPrint_Preview);
            this.OnDDPrint_Print += new System.EventHandler(this.RPT01_WorkPlaceLightIntensity_OnDDPrint_Print);
            this.OnDDPrint_PDF += new System.EventHandler(this.RPT001_WorkPlaceLightIntensity_OnDDPrint_PDF);
            this.OnDDPrint_Word += new System.EventHandler(this.RPT001_WorkPlaceLightIntensity_OnDDPrint_Word);
            this.OnDDPrint_Excel += new System.EventHandler(this.RPT001_WorkPlaceLightIntensity_OnDDPrint_Excel);
            this.OnClear += new System.EventHandler(this.RPT001_WorkPlaceLightIntensity_OnClear);
            this.Load += new System.EventHandler(this.RPT001_WorkPlaceLightIntensity_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.gbCriteria.ResumeLayout(false);
            this.gbCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseViews.rGroupBox gbResult;
        private BaseViews.rDataGridView gvResult;
        private BaseViews.rGroupBox gbCriteria;
        private BaseViews.rLabel lblModel;
        private BaseViews.rLabel lblReportNumber;
        private BaseViews.rTextBox txtReportNumber;
        private BaseViews.rLabel lblHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORTNUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_PROJECT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEASURED_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEASURED_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn INS_NAME;
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
        private BaseViews.rLabel lblMeasuredBy;
        private BaseViews.rLabel lblMeasuredDate;
        private BaseViews.rDateTextBox dtMeasuredDate;
        private BaseViews.rDateTextBox dtMeasuredDateTo;
        private BaseViews.rLabel rLabel1;
        private BaseViews.rSearchTextBox txtInstrument;
        private BaseViews.rLabel lblMeasuredTo;
        private BaseViews.rSearchTextBox txtMeasuredBy;
        private BaseViews.rSearchTextBox txtCustomer;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem miCopy;
        private System.Windows.Forms.CheckBox chkShowDeleteRecord;
    }
}
