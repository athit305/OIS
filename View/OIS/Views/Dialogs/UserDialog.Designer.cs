namespace OIS.Views.Dialogs
{
    partial class UserDialog
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME_TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIVISION_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBDIVISION_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITION_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ID,
            this.FULLNAME_TH,
            this.DIVISION_NAME,
            this.SUBDIVISION_NAME,
            this.POSITION_NAME});
            this.gvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDetail.EnterToAddRow = true;
            this.gvDetail.Location = new System.Drawing.Point(3, 19);
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.Size = new System.Drawing.Size(854, 355);
            this.gvDetail.TabIndex = 0;
            this.gvDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetail_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "รหัสพนักงาน";
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // FULLNAME_TH
            // 
            this.FULLNAME_TH.HeaderText = "ชื่อพนักงาน";
            this.FULLNAME_TH.Name = "FULLNAME_TH";
            this.FULLNAME_TH.Width = 150;
            // 
            // DIVISION_NAME
            // 
            this.DIVISION_NAME.HeaderText = "ฝ่าย";
            this.DIVISION_NAME.Name = "DIVISION_NAME";
            this.DIVISION_NAME.Width = 250;
            // 
            // SUBDIVISION_NAME
            // 
            this.SUBDIVISION_NAME.HeaderText = "แผนก";
            this.SUBDIVISION_NAME.Name = "SUBDIVISION_NAME";
            this.SUBDIVISION_NAME.Width = 250;
            // 
            // POSITION_NAME
            // 
            this.POSITION_NAME.HeaderText = "ตำแหน่ง";
            this.POSITION_NAME.Name = "POSITION_NAME";
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
            // UserDialog
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
            this.Name = "UserDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ค้นหาพนักงาน";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME_TH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIVISION_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBDIVISION_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSITION_NAME;
    }
}