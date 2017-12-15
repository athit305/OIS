namespace OIS.BaseViews
{
    partial class rBaseUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rBaseUC));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tssSearch = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbConfirm = new System.Windows.Forms.ToolStripButton();
            this.tssPrint = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDDPrint = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbDDPrint_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDDPrint_Preview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDDPrint_PDF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDDPrint_Word = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDDPrint_Excel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDDPrint2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbDDPrint2_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDDPrint2_Preview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDDPrint2_PDF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDDPrint2_Word = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbDDPrint2_Excel = new System.Windows.Forms.ToolStripMenuItem();
            this.tssExport = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tssCancel = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbRecovery = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tssClear = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.bdSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tsMenu);
            this.splitContainerMain.Panel1MinSize = 55;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.pnlMain);
            this.splitContainerMain.Size = new System.Drawing.Size(860, 500);
            this.splitContainerMain.SplitterDistance = 55;
            this.splitContainerMain.SplitterWidth = 1;
            this.splitContainerMain.TabIndex = 0;
            // 
            // tsMenu
            // 
            this.tsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbSave,
            this.tssSearch,
            this.tsbSearch,
            this.tsbConfirm,
            this.tssPrint,
            this.tsbDDPrint,
            this.tsbDDPrint2,
            this.tssExport,
            this.tsbExport,
            this.tssCancel,
            this.tsbCancel,
            this.tsbRecovery,
            this.tsbClose,
            this.toolStripSeparator3,
            this.tssClear,
            this.tsbClear});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(860, 54);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(36, 51);
            this.tsbNew.Text = "สร้าง";
            this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(40, 51);
            this.tsbSave.Text = "บันทึก";
            this.tsbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tssSearch
            // 
            this.tssSearch.Name = "tssSearch";
            this.tssSearch.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(38, 51);
            this.tsbSearch.Text = "ค้นหา";
            this.tsbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbConfirm
            // 
            this.tsbConfirm.Image = ((System.Drawing.Image)(resources.GetObject("tsbConfirm.Image")));
            this.tsbConfirm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbConfirm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfirm.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsbConfirm.Name = "tsbConfirm";
            this.tsbConfirm.Size = new System.Drawing.Size(41, 51);
            this.tsbConfirm.Text = "ยืนยัน";
            this.tsbConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConfirm.Click += new System.EventHandler(this.tsbConfirm_Click);
            // 
            // tssPrint
            // 
            this.tssPrint.Name = "tssPrint";
            this.tssPrint.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbDDPrint
            // 
            this.tsbDDPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDDPrint_Print,
            this.tsbDDPrint_Preview,
            this.tsbDDPrint_PDF,
            this.tsbDDPrint_Word,
            this.tsbDDPrint_Excel});
            this.tsbDDPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbDDPrint.Image")));
            this.tsbDDPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbDDPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDDPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDDPrint.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsbDDPrint.Name = "tsbDDPrint";
            this.tsbDDPrint.Size = new System.Drawing.Size(56, 51);
            this.tsbDDPrint.Text = "รายงาน";
            this.tsbDDPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbDDPrint_Print
            // 
            this.tsbDDPrint_Print.Name = "tsbDDPrint_Print";
            this.tsbDDPrint_Print.Size = new System.Drawing.Size(162, 22);
            this.tsbDDPrint_Print.Text = "พิมพ์";
            this.tsbDDPrint_Print.Click += new System.EventHandler(this.tsbDDPrint_Print_Click);
            // 
            // tsbDDPrint_Preview
            // 
            this.tsbDDPrint_Preview.Name = "tsbDDPrint_Preview";
            this.tsbDDPrint_Preview.Size = new System.Drawing.Size(162, 22);
            this.tsbDDPrint_Preview.Text = "ดูตัวอย่าง";
            this.tsbDDPrint_Preview.Click += new System.EventHandler(this.tsbDDPrint_Preview_Click);
            // 
            // tsbDDPrint_PDF
            // 
            this.tsbDDPrint_PDF.Name = "tsbDDPrint_PDF";
            this.tsbDDPrint_PDF.Size = new System.Drawing.Size(162, 22);
            this.tsbDDPrint_PDF.Text = "PDF";
            this.tsbDDPrint_PDF.Click += new System.EventHandler(this.tsbDDPrint_PDF_Click);
            // 
            // tsbDDPrint_Word
            // 
            this.tsbDDPrint_Word.Name = "tsbDDPrint_Word";
            this.tsbDDPrint_Word.Size = new System.Drawing.Size(162, 22);
            this.tsbDDPrint_Word.Text = "Word Document";
            this.tsbDDPrint_Word.Click += new System.EventHandler(this.tsbDDPrint_Word_Click);
            // 
            // tsbDDPrint_Excel
            // 
            this.tsbDDPrint_Excel.Name = "tsbDDPrint_Excel";
            this.tsbDDPrint_Excel.Size = new System.Drawing.Size(162, 22);
            this.tsbDDPrint_Excel.Text = "Excel";
            this.tsbDDPrint_Excel.Click += new System.EventHandler(this.tsbDDPrint_Excel_Click);
            // 
            // tsbDDPrint2
            // 
            this.tsbDDPrint2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDDPrint2_Print,
            this.tsbDDPrint2_Preview,
            this.tsbDDPrint2_PDF,
            this.tsbDDPrint2_Word,
            this.tsbDDPrint2_Excel});
            this.tsbDDPrint2.Image = ((System.Drawing.Image)(resources.GetObject("tsbDDPrint2.Image")));
            this.tsbDDPrint2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbDDPrint2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDDPrint2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDDPrint2.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsbDDPrint2.Name = "tsbDDPrint2";
            this.tsbDDPrint2.Size = new System.Drawing.Size(63, 51);
            this.tsbDDPrint2.Text = "รายงาน2";
            this.tsbDDPrint2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbDDPrint2_Print
            // 
            this.tsbDDPrint2_Print.Name = "tsbDDPrint2_Print";
            this.tsbDDPrint2_Print.Size = new System.Drawing.Size(162, 22);
            this.tsbDDPrint2_Print.Text = "พิมพ์";
            this.tsbDDPrint2_Print.Click += new System.EventHandler(this.tsbDDPrint2_Print_Click);
            // 
            // tsbDDPrint2_Preview
            // 
            this.tsbDDPrint2_Preview.Name = "tsbDDPrint2_Preview";
            this.tsbDDPrint2_Preview.Size = new System.Drawing.Size(162, 22);
            this.tsbDDPrint2_Preview.Text = "ดูตัวอย่าง";
            this.tsbDDPrint2_Preview.Click += new System.EventHandler(this.tsbDDPrint2_Preview_Click);
            // 
            // tsbDDPrint2_PDF
            // 
            this.tsbDDPrint2_PDF.Name = "tsbDDPrint2_PDF";
            this.tsbDDPrint2_PDF.Size = new System.Drawing.Size(162, 22);
            this.tsbDDPrint2_PDF.Text = "PDF";
            this.tsbDDPrint2_PDF.Click += new System.EventHandler(this.tsbDDPrint2_PDF_Click);
            // 
            // tsbDDPrint2_Word
            // 
            this.tsbDDPrint2_Word.Name = "tsbDDPrint2_Word";
            this.tsbDDPrint2_Word.Size = new System.Drawing.Size(162, 22);
            this.tsbDDPrint2_Word.Text = "Word Document";
            this.tsbDDPrint2_Word.Click += new System.EventHandler(this.tsbDDPrint2_Word_Click);
            // 
            // tsbDDPrint2_Excel
            // 
            this.tsbDDPrint2_Excel.Name = "tsbDDPrint2_Excel";
            this.tsbDDPrint2_Excel.Size = new System.Drawing.Size(162, 22);
            this.tsbDDPrint2_Excel.Text = "Excel";
            this.tsbDDPrint2_Excel.Click += new System.EventHandler(this.tsbDDPrint2_Excel_Click);
            // 
            // tssExport
            // 
            this.tssExport.Name = "tssExport";
            this.tssExport.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbExport
            // 
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbExport.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(41, 51);
            this.tsbExport.Text = "ส่งออก";
            this.tsbExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // tssCancel
            // 
            this.tssCancel.Name = "tssCancel";
            this.tssCancel.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbCancel.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(43, 51);
            this.tsbCancel.Text = "ยกเลิก";
            this.tsbCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbRecovery
            // 
            this.tsbRecovery.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecovery.Image")));
            this.tsbRecovery.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbRecovery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRecovery.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbRecovery.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsbRecovery.Name = "tsbRecovery";
            this.tsbRecovery.Size = new System.Drawing.Size(36, 51);
            this.tsbRecovery.Text = "กู้คืน";
            this.tsbRecovery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRecovery.Click += new System.EventHandler(this.tsbRecovery_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(57, 51);
            this.tsbClose.Text = "ปิดหน้าจอ";
            this.tsbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // tssClear
            // 
            this.tssClear.Name = "tssClear";
            this.tssClear.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbClear
            // 
            this.tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbClear.Image")));
            this.tsbClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(59, 51);
            this.tsbClear.Text = "ล้างหน้าจอ";
            this.tsbClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(860, 444);
            this.pnlMain.TabIndex = 0;
            // 
            // rBaseUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.splitContainerMain);
            this.Name = "rBaseUC";
            this.Size = new System.Drawing.Size(860, 500);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.Panel pnlMain;
        protected System.Windows.Forms.ToolStripButton tsbRecovery;
        protected System.Windows.Forms.ToolStripButton tsbNew;
        protected System.Windows.Forms.ToolStripButton tsbSave;
        protected System.Windows.Forms.ToolStripButton tsbCancel;
        protected System.Windows.Forms.ToolStripButton tsbSearch;
        protected System.Windows.Forms.ToolStripButton tsbConfirm;
        protected System.Windows.Forms.ToolStripDropDownButton tsbDDPrint;
        protected System.Windows.Forms.ToolStripDropDownButton tsbDDPrint2;
        protected System.Windows.Forms.ToolStrip tsMenu;
        protected System.Windows.Forms.ToolStripSeparator tssPrint;
        protected System.Windows.Forms.ToolStripSeparator tssSearch;
        protected System.Windows.Forms.ToolStripSeparator tssCancel;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripSeparator tssExport;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripSeparator tssClear;
        protected System.Windows.Forms.BindingSource bdSource;
        public System.Windows.Forms.ToolStripMenuItem tsbDDPrint_Preview;
        public System.Windows.Forms.ToolStripMenuItem tsbDDPrint_Print;
        public System.Windows.Forms.ToolStripMenuItem tsbDDPrint2_Preview;
        public System.Windows.Forms.ToolStripMenuItem tsbDDPrint2_Print;
        public System.Windows.Forms.ToolStripMenuItem tsbDDPrint_Word;
        public System.Windows.Forms.ToolStripMenuItem tsbDDPrint_Excel;
        public System.Windows.Forms.ToolStripMenuItem tsbDDPrint2_Word;
        public System.Windows.Forms.ToolStripMenuItem tsbDDPrint2_Excel;
        public System.Windows.Forms.ToolStripMenuItem tsbDDPrint_PDF;
        public System.Windows.Forms.ToolStripMenuItem tsbDDPrint2_PDF;
    }
}
