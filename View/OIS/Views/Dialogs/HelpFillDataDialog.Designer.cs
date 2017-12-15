namespace OIS.Views.Dialogs
{
    partial class HelpFillDataDialog
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.txtFilter = new OIS.BaseViews.rTextBox();
            this.btnOK = new OIS.BaseViews.rButton();
            this.gvDetail = new OIS.BaseViews.rDataGridView();
            this.IS_SELECT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_VALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnOK);
            this.splitContainer.Panel1.Controls.Add(this.txtFilter);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gvDetail);
            this.splitContainer.Size = new System.Drawing.Size(584, 261);
            this.splitContainer.SplitterDistance = 33;
            this.splitContainer.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtFilter.IsRequired = false;
            this.txtFilter.Location = new System.Drawing.Point(3, 5);
            this.txtFilter.MinLength = 0;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(397, 23);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextValue = null;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(406, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gvDetail
            // 
            this.gvDetail.AllowDrop = true;
            this.gvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IS_SELECT,
            this.CODE,
            this.DATA_VALUE});
            this.gvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDetail.EnterToAddRow = true;
            this.gvDetail.Location = new System.Drawing.Point(0, 0);
            this.gvDetail.Name = "gvDetail";
            this.gvDetail.Size = new System.Drawing.Size(584, 224);
            this.gvDetail.TabIndex = 0;
            this.gvDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetail_CellDoubleClick);
            // 
            // IS_SELECT
            // 
            this.IS_SELECT.HeaderText = "";
            this.IS_SELECT.Name = "IS_SELECT";
            this.IS_SELECT.Width = 30;
            // 
            // CODE
            // 
            this.CODE.HeaderText = "Code";
            this.CODE.Name = "CODE";
            this.CODE.ReadOnly = true;
            this.CODE.Width = 80;
            // 
            // DATA_VALUE
            // 
            this.DATA_VALUE.HeaderText = "Value";
            this.DATA_VALUE.Name = "DATA_VALUE";
            this.DATA_VALUE.ReadOnly = true;
            this.DATA_VALUE.Width = 350;
            // 
            // HelpFillDataDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.splitContainer);
            this.Name = "HelpFillDataDialog";
            this.ShowIcon = false;
            this.Text = "Help Dialog";
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
        private BaseViews.rTextBox txtFilter;
        private BaseViews.rButton btnOK;
        private BaseViews.rDataGridView gvDetail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IS_SELECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_VALUE;
    }
}