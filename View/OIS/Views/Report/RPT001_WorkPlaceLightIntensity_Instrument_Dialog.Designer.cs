namespace OIS.Views.Report
{
    partial class RPT001_WorkPlaceLightIntensity_Instrument_Dialog
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new OIS.BaseViews.rButton();
            this.btnAdd = new OIS.BaseViews.rButton();
            this.txtSearch = new OIS.BaseViews.rSearchTextBox();
            this.gvDetail = new OIS.BaseViews.rDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEASURED_INSTRUMENT_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gvDetail);
            this.splitContainer.Size = new System.Drawing.Size(684, 244);
            this.splitContainer.SplitterDistance = 36;
            this.splitContainer.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(606, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(525, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearch.IntValue = null;
            this.txtSearch.IsRequired = false;
            this.txtSearch.Location = new System.Drawing.Point(12, 5);
            this.txtSearch.MinLength = 0;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.OptionalTextBox = null;
            this.txtSearch.SearchType = OIS.BaseViews.eSearchType.Instrument;
            this.txtSearch.Size = new System.Drawing.Size(507, 23);
            this.txtSearch.StringValue = null;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextValue = null;
            // 
            // gvDetail
            // 
            this.gvDetail.AllowDrop = true;
            this.gvDetail.AllowUserToAddRows = false;
            this.gvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            this.MEASURED_INSTRUMENT_ID});
            this.gvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDetail.EnterToAddRow = true;
            this.gvDetail.Location = new System.Drawing.Point(0, 0);
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.Size = new System.Drawing.Size(684, 204);
            this.gvDetail.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // MEASURED_INSTRUMENT_ID
            // 
            this.MEASURED_INSTRUMENT_ID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MEASURED_INSTRUMENT_ID.HeaderText = "Instrument";
            this.MEASURED_INSTRUMENT_ID.Name = "MEASURED_INSTRUMENT_ID";
            this.MEASURED_INSTRUMENT_ID.Width = 550;
            // 
            // RPT001_WorkPlaceLightIntensity_Instrument_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 244);
            this.Controls.Add(this.splitContainer);
            this.Name = "RPT001_WorkPlaceLightIntensity_Instrument_Dialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Place Light Intensity Instrument Dialog";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private BaseViews.rSearchTextBox txtSearch;
        private BaseViews.rButton btnAdd;
        private BaseViews.rButton btnDelete;
        private BaseViews.rDataGridView gvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn MEASURED_INSTRUMENT_ID;
    }
}