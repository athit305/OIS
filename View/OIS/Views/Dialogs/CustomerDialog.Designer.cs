namespace OIS.Views.Dialogs
{
    partial class CustomerDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDetail = new OIS.BaseViews.rGroupBox();
            this.gvDetail = new OIS.BaseViews.rDataGridView();
            this.NAME_TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDR_TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDR_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSearch = new OIS.BaseViews.rGroupBox();
            this.txtSearch = new OIS.BaseViews.rTextBox();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            this.gvSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetail
            // 
            this.gbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetail.Controls.Add(this.gvDetail);
            this.gbDetail.Location = new System.Drawing.Point(12, 73);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(860, 377);
            this.gbDetail.TabIndex = 1;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "รายการ";
            // 
            // gvDetail
            // 
            this.gvDetail.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDetail.ColumnHeadersHeight = 40;
            this.gvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME_TH,
            this.NAME_EN,
            this.ADDR_TH,
            this.ADDR_EN});
            this.gvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDetail.EnterToAddRow = true;
            this.gvDetail.Location = new System.Drawing.Point(3, 19);
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.Size = new System.Drawing.Size(854, 355);
            this.gvDetail.TabIndex = 0;
            this.gvDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetail_CellDoubleClick);
            // 
            // NAME_TH
            // 
            this.NAME_TH.HeaderText = "ชื่อลูกค้า (ไทย)";
            this.NAME_TH.Name = "NAME_TH";
            this.NAME_TH.Width = 150;
            // 
            // NAME_EN
            // 
            this.NAME_EN.HeaderText = "ชื่อลูกค้า (อังกฤษ)";
            this.NAME_EN.Name = "NAME_EN";
            this.NAME_EN.Width = 150;
            // 
            // ADDR_TH
            // 
            this.ADDR_TH.HeaderText = "ที่อยู่ (ไทย)";
            this.ADDR_TH.Name = "ADDR_TH";
            this.ADDR_TH.Width = 250;
            // 
            // ADDR_EN
            // 
            this.ADDR_EN.HeaderText = "ที่อยู่ (อังกฤษ)";
            this.ADDR_EN.Name = "ADDR_EN";
            this.ADDR_EN.Width = 250;
            // 
            // gvSearch
            // 
            this.gvSearch.Controls.Add(this.txtSearch);
            this.gvSearch.Location = new System.Drawing.Point(12, 12);
            this.gvSearch.Name = "gvSearch";
            this.gvSearch.Size = new System.Drawing.Size(860, 55);
            this.gvSearch.TabIndex = 2;
            this.gvSearch.TabStop = false;
            this.gvSearch.Text = "ค้นหา";
            // 
            // txtSearch
            // 
            this.txtSearch.IsRequired = false;
            this.txtSearch.Location = new System.Drawing.Point(6, 22);
            this.txtSearch.MinLength = 0;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(848, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextValue = null;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // CustomerDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.gvSearch);
            this.Controls.Add(this.gbDetail);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ค้นหาลูกค้า";
            this.Load += new System.EventHandler(this.StandardLightDialog_Load);
            this.gbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            this.gvSearch.ResumeLayout(false);
            this.gvSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private BaseViews.rGroupBox gbDetail;
        private BaseViews.rDataGridView gvDetail;
        private BaseViews.rGroupBox gvSearch;
        private BaseViews.rTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_TH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDR_TH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDR_EN;
    }
}