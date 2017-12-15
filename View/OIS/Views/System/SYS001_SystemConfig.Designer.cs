namespace OIS.Views
{
    partial class SYS001_SystemConfig
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
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.gbSystem = new OIS.BaseViews.rGroupBox();
            this.chkIsUpdateAutoUpdate = new System.Windows.Forms.CheckBox();
            this.gbReport = new OIS.BaseViews.rGroupBox();
            this.txtRevLight = new OIS.BaseViews.rTextBox();
            this.txtRegisLight = new OIS.BaseViews.rSearchTextBox();
            this.lblRegisLight = new OIS.BaseViews.rLabel();
            this.txtLabSLight = new OIS.BaseViews.rSearchTextBox();
            this.lblLabSLight = new OIS.BaseViews.rLabel();
            this.rGroupBox1 = new OIS.BaseViews.rGroupBox();
            this.txtRevChem = new OIS.BaseViews.rTextBox();
            this.txtRegisChem = new OIS.BaseViews.rSearchTextBox();
            this.lblRegisChem = new OIS.BaseViews.rLabel();
            this.lblLabSChem = new OIS.BaseViews.rLabel();
            this.txtLabSChem = new OIS.BaseViews.rSearchTextBox();
            this.lblRevLight = new OIS.BaseViews.rLabel();
            this.lblRevChem = new OIS.BaseViews.rLabel();
            this.bs2 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            this.gbSystem.SuspendLayout();
            this.gbReport.SuspendLayout();
            this.rGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.rGroupBox1);
            this.pnlMain.Controls.Add(this.gbReport);
            this.pnlMain.Controls.Add(this.gbSystem);
            this.pnlMain.Controls.Add(this.lblHeader);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(145, 33);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "ตั้งค่าระบบ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbSystem
            // 
            this.gbSystem.Controls.Add(this.chkIsUpdateAutoUpdate);
            this.gbSystem.Location = new System.Drawing.Point(9, 218);
            this.gbSystem.Name = "gbSystem";
            this.gbSystem.Size = new System.Drawing.Size(846, 54);
            this.gbSystem.TabIndex = 35;
            this.gbSystem.TabStop = false;
            this.gbSystem.Text = "ตั้งค่าระบบ";
            // 
            // chkIsUpdateAutoUpdate
            // 
            this.chkIsUpdateAutoUpdate.AutoSize = true;
            this.chkIsUpdateAutoUpdate.CausesValidation = false;
            this.chkIsUpdateAutoUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs2, "IS_UPDATE_AUTOUPDATE", true));
            this.chkIsUpdateAutoUpdate.Location = new System.Drawing.Point(53, 22);
            this.chkIsUpdateAutoUpdate.Name = "chkIsUpdateAutoUpdate";
            this.chkIsUpdateAutoUpdate.Size = new System.Drawing.Size(135, 20);
            this.chkIsUpdateAutoUpdate.TabIndex = 35;
            this.chkIsUpdateAutoUpdate.Text = "อัพเดท AutoUpdate";
            this.chkIsUpdateAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.lblRevLight);
            this.gbReport.Controls.Add(this.txtRevLight);
            this.gbReport.Controls.Add(this.txtRegisLight);
            this.gbReport.Controls.Add(this.lblRegisLight);
            this.gbReport.Controls.Add(this.txtLabSLight);
            this.gbReport.Controls.Add(this.lblLabSLight);
            this.gbReport.Location = new System.Drawing.Point(9, 36);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(846, 85);
            this.gbReport.TabIndex = 36;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "รายงาน Work Place Light Intensity";
            // 
            // txtRevLight
            // 
            this.txtRevLight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "REPORT_REV_WPL", true));
            this.txtRevLight.IsRequired = false;
            this.txtRevLight.Location = new System.Drawing.Point(101, 51);
            this.txtRevLight.MinLength = 0;
            this.txtRevLight.Name = "txtRevLight";
            this.txtRevLight.Size = new System.Drawing.Size(250, 23);
            this.txtRevLight.TabIndex = 51;
            this.txtRevLight.TextValue = null;
            // 
            // txtRegisLight
            // 
            this.txtRegisLight.BackColor = System.Drawing.SystemColors.Info;
            this.txtRegisLight.CausesValidation = false;
            this.txtRegisLight.DataBindings.Add(new System.Windows.Forms.Binding("StringValue", this.bs2, "DEFAULT_REPORT_REGISTRATION_ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRegisLight.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs2, "DEFAULT_REPORT_REGISTRATION_NAME", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRegisLight.IntValue = null;
            this.txtRegisLight.IsRequired = false;
            this.txtRegisLight.Location = new System.Drawing.Point(101, 22);
            this.txtRegisLight.MinLength = 0;
            this.txtRegisLight.Name = "txtRegisLight";
            this.txtRegisLight.OptionalTextBox = null;
            this.txtRegisLight.SearchType = OIS.BaseViews.eSearchType.User;
            this.txtRegisLight.Size = new System.Drawing.Size(250, 23);
            this.txtRegisLight.StringValue = null;
            this.txtRegisLight.TabIndex = 49;
            this.txtRegisLight.TextValue = null;
            // 
            // lblRegisLight
            // 
            this.lblRegisLight.AutoSize = true;
            this.lblRegisLight.Location = new System.Drawing.Point(10, 25);
            this.lblRegisLight.Name = "lblRegisLight";
            this.lblRegisLight.Size = new System.Drawing.Size(85, 16);
            this.lblRegisLight.TabIndex = 50;
            this.lblRegisLight.Text = "Registration :";
            this.lblRegisLight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLabSLight
            // 
            this.txtLabSLight.BackColor = System.Drawing.SystemColors.Info;
            this.txtLabSLight.CausesValidation = false;
            this.txtLabSLight.DataBindings.Add(new System.Windows.Forms.Binding("StringValue", this.bs2, "DEFAULT_REPORT_LAB_SUPERVISOR_ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLabSLight.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs2, "DEFAULT_REPORT_LAB_SUPERVISOR_NAME", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLabSLight.IntValue = null;
            this.txtLabSLight.IsRequired = false;
            this.txtLabSLight.Location = new System.Drawing.Point(493, 22);
            this.txtLabSLight.MinLength = 0;
            this.txtLabSLight.Name = "txtLabSLight";
            this.txtLabSLight.OptionalTextBox = null;
            this.txtLabSLight.SearchType = OIS.BaseViews.eSearchType.User;
            this.txtLabSLight.Size = new System.Drawing.Size(250, 23);
            this.txtLabSLight.StringValue = null;
            this.txtLabSLight.TabIndex = 47;
            this.txtLabSLight.TextValue = null;
            // 
            // lblLabSLight
            // 
            this.lblLabSLight.AutoSize = true;
            this.lblLabSLight.Location = new System.Drawing.Point(385, 25);
            this.lblLabSLight.Name = "lblLabSLight";
            this.lblLabSLight.Size = new System.Drawing.Size(102, 16);
            this.lblLabSLight.TabIndex = 48;
            this.lblLabSLight.Text = "Lab Supervisor :";
            this.lblLabSLight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rGroupBox1
            // 
            this.rGroupBox1.Controls.Add(this.lblRevChem);
            this.rGroupBox1.Controls.Add(this.txtRevChem);
            this.rGroupBox1.Controls.Add(this.txtRegisChem);
            this.rGroupBox1.Controls.Add(this.lblRegisChem);
            this.rGroupBox1.Controls.Add(this.lblLabSChem);
            this.rGroupBox1.Controls.Add(this.txtLabSChem);
            this.rGroupBox1.Location = new System.Drawing.Point(9, 127);
            this.rGroupBox1.Name = "rGroupBox1";
            this.rGroupBox1.Size = new System.Drawing.Size(846, 85);
            this.rGroupBox1.TabIndex = 55;
            this.rGroupBox1.TabStop = false;
            this.rGroupBox1.Text = "รายงาน Work Place Air Quality";
            // 
            // txtRevChem
            // 
            this.txtRevChem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs2, "REPORT_REV_WPA", true));
            this.txtRevChem.IsRequired = false;
            this.txtRevChem.Location = new System.Drawing.Point(101, 48);
            this.txtRevChem.MinLength = 0;
            this.txtRevChem.Name = "txtRevChem";
            this.txtRevChem.Size = new System.Drawing.Size(250, 23);
            this.txtRevChem.TabIndex = 52;
            this.txtRevChem.TextValue = null;
            // 
            // txtRegisChem
            // 
            this.txtRegisChem.BackColor = System.Drawing.SystemColors.Info;
            this.txtRegisChem.CausesValidation = false;
            this.txtRegisChem.DataBindings.Add(new System.Windows.Forms.Binding("StringValue", this.bs2, "DEFAULT_REPORT_WPA_REGISTRATION_ID", true));
            this.txtRegisChem.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs2, "DEFAULT_REPORT_WPA_REGISTRATION_NAME", true));
            this.txtRegisChem.IntValue = null;
            this.txtRegisChem.IsRequired = false;
            this.txtRegisChem.Location = new System.Drawing.Point(101, 19);
            this.txtRegisChem.MinLength = 0;
            this.txtRegisChem.Name = "txtRegisChem";
            this.txtRegisChem.OptionalTextBox = null;
            this.txtRegisChem.SearchType = OIS.BaseViews.eSearchType.User;
            this.txtRegisChem.Size = new System.Drawing.Size(250, 23);
            this.txtRegisChem.StringValue = null;
            this.txtRegisChem.TabIndex = 53;
            this.txtRegisChem.TextValue = null;
            // 
            // lblRegisChem
            // 
            this.lblRegisChem.AutoSize = true;
            this.lblRegisChem.Location = new System.Drawing.Point(10, 19);
            this.lblRegisChem.Name = "lblRegisChem";
            this.lblRegisChem.Size = new System.Drawing.Size(85, 16);
            this.lblRegisChem.TabIndex = 54;
            this.lblRegisChem.Text = "Registration :";
            this.lblRegisChem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLabSChem
            // 
            this.lblLabSChem.AutoSize = true;
            this.lblLabSChem.Location = new System.Drawing.Point(385, 19);
            this.lblLabSChem.Name = "lblLabSChem";
            this.lblLabSChem.Size = new System.Drawing.Size(102, 16);
            this.lblLabSChem.TabIndex = 52;
            this.lblLabSChem.Text = "Lab Supervisor :";
            this.lblLabSChem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLabSChem
            // 
            this.txtLabSChem.BackColor = System.Drawing.SystemColors.Info;
            this.txtLabSChem.CausesValidation = false;
            this.txtLabSChem.DataBindings.Add(new System.Windows.Forms.Binding("StringValue", this.bs2, "DEFAULT_REPORT_WPA_LAB_SUPERVISOR_ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLabSChem.DataBindings.Add(new System.Windows.Forms.Binding("TextValue", this.bs2, "DEFAULT_REPORT_WPA_LAB_SUPERVISOR_NAME", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLabSChem.IntValue = null;
            this.txtLabSChem.IsRequired = false;
            this.txtLabSChem.Location = new System.Drawing.Point(493, 16);
            this.txtLabSChem.MinLength = 0;
            this.txtLabSChem.Name = "txtLabSChem";
            this.txtLabSChem.OptionalTextBox = null;
            this.txtLabSChem.SearchType = OIS.BaseViews.eSearchType.User;
            this.txtLabSChem.Size = new System.Drawing.Size(250, 23);
            this.txtLabSChem.StringValue = null;
            this.txtLabSChem.TabIndex = 51;
            this.txtLabSChem.TextValue = null;
            // 
            // lblRevLight
            // 
            this.lblRevLight.AutoSize = true;
            this.lblRevLight.Location = new System.Drawing.Point(10, 54);
            this.lblRevLight.Name = "lblRevLight";
            this.lblRevLight.Size = new System.Drawing.Size(64, 16);
            this.lblRevLight.TabIndex = 52;
            this.lblRevLight.Text = "Revision :";
            this.lblRevLight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRevChem
            // 
            this.lblRevChem.AutoSize = true;
            this.lblRevChem.Location = new System.Drawing.Point(10, 51);
            this.lblRevChem.Name = "lblRevChem";
            this.lblRevChem.Size = new System.Drawing.Size(64, 16);
            this.lblRevChem.TabIndex = 53;
            this.lblRevChem.Text = "Revision :";
            this.lblRevChem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bs2
            // 
            this.bs2.DataSource = typeof(OIS.SYS.DTO.sp_SYS001_GetSystemConfig_Result);
            // 
            // SYS001_SystemConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Name = "SYS001_SystemConfig";
            this.OnSave += new System.EventHandler(this.SYS001_SystemConfig_OnSave);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.gbSystem.ResumeLayout(false);
            this.gbSystem.PerformLayout();
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            this.rGroupBox1.ResumeLayout(false);
            this.rGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseViews.rLabel lblHeader;
        private System.Windows.Forms.BindingSource bs2;
        private BaseViews.rGroupBox gbSystem;
        private System.Windows.Forms.CheckBox chkIsUpdateAutoUpdate;
        private BaseViews.rGroupBox gbReport;
        private BaseViews.rSearchTextBox txtLabSLight;
        private BaseViews.rLabel lblLabSLight;
        private BaseViews.rSearchTextBox txtRegisLight;
        private BaseViews.rLabel lblRegisLight;
        private BaseViews.rGroupBox rGroupBox1;
        private BaseViews.rTextBox txtRevChem;
        private BaseViews.rSearchTextBox txtRegisChem;
        private BaseViews.rLabel lblRegisChem;
        private BaseViews.rLabel lblLabSChem;
        private BaseViews.rSearchTextBox txtLabSChem;
        private BaseViews.rTextBox txtRevLight;
        private BaseViews.rLabel lblRevLight;
        private BaseViews.rLabel lblRevChem;
    }
}
