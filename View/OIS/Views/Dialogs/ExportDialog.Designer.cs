namespace OIS.Views.Dialogs
{
    partial class ExportDialog
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
            this.gbMain = new OIS.BaseViews.rGroupBox();
            this.btnFileName = new OIS.BaseViews.rButton();
            this.lblFileName = new OIS.BaseViews.rLabel();
            this.txtFileName = new OIS.BaseViews.rTextBox();
            this.ChkOpenWhenFinish = new System.Windows.Forms.CheckBox();
            this.lblRow = new OIS.BaseViews.rLabel();
            this.btnOK = new OIS.BaseViews.rButton();
            this.btnCancel = new OIS.BaseViews.rButton();
            this.progressBarExport = new System.Windows.Forms.ProgressBar();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorkerExport = new System.ComponentModel.BackgroundWorker();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnFileName);
            this.gbMain.Controls.Add(this.lblFileName);
            this.gbMain.Controls.Add(this.txtFileName);
            this.gbMain.Controls.Add(this.ChkOpenWhenFinish);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(460, 78);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "เงื่อนไข";
            // 
            // btnFileName
            // 
            this.btnFileName.Location = new System.Drawing.Point(424, 48);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(29, 23);
            this.btnFileName.TabIndex = 4;
            this.btnFileName.Text = "...";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(38, 51);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(57, 16);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "ชื่อไฟล์ :";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.IsRequired = false;
            this.txtFileName.Location = new System.Drawing.Point(101, 48);
            this.txtFileName.MinLength = 0;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(317, 23);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // ChkOpenWhenFinish
            // 
            this.ChkOpenWhenFinish.AutoSize = true;
            this.ChkOpenWhenFinish.Checked = true;
            this.ChkOpenWhenFinish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkOpenWhenFinish.Location = new System.Drawing.Point(101, 22);
            this.ChkOpenWhenFinish.Name = "ChkOpenWhenFinish";
            this.ChkOpenWhenFinish.Size = new System.Drawing.Size(116, 20);
            this.ChkOpenWhenFinish.TabIndex = 1;
            this.ChkOpenWhenFinish.Text = "เปิดไฟล์เมื่อเสร็จ";
            this.ChkOpenWhenFinish.UseVisualStyleBackColor = true;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRow.Location = new System.Drawing.Point(12, 137);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(0, 13);
            this.lblRow.TabIndex = 5;
            this.lblRow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(163, 123);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ตกลง";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(244, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // progressBarExport
            // 
            this.progressBarExport.Location = new System.Drawing.Point(12, 96);
            this.progressBarExport.Name = "progressBarExport";
            this.progressBarExport.Size = new System.Drawing.Size(460, 23);
            this.progressBarExport.TabIndex = 3;
            // 
            // backgroundWorkerExport
            // 
            this.backgroundWorkerExport.WorkerReportsProgress = true;
            this.backgroundWorkerExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerExport_DoWork);
            this.backgroundWorkerExport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerExport_ProgressChanged);
            this.backgroundWorkerExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerExport_RunWorkerCompleted);
            // 
            // ExportDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 162);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.progressBarExport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ส่งออกข้อมูล";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseViews.rGroupBox gbMain;
        private BaseViews.rButton btnOK;
        private BaseViews.rButton btnCancel;
        private System.Windows.Forms.CheckBox ChkOpenWhenFinish;
        private BaseViews.rButton btnFileName;
        private BaseViews.rLabel lblFileName;
        private BaseViews.rTextBox txtFileName;
        private System.Windows.Forms.ProgressBar progressBarExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
        private System.ComponentModel.BackgroundWorker backgroundWorkerExport;
        private BaseViews.rLabel lblRow;
    }
}