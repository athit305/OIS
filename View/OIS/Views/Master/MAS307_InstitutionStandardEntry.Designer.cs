namespace OIS.Views
{
    partial class MAS307_InstitutionStandardEntry
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
            this.gbHistory = new OIS.BaseViews.rGroupBox();
            this.txtDelId = new OIS.BaseViews.rTextBox();
            this.lblDelId = new OIS.BaseViews.rLabel();
            this.txtDelMachine = new OIS.BaseViews.rTextBox();
            this.lblDelMachine = new OIS.BaseViews.rLabel();
            this.dtDel = new OIS.BaseViews.rDateTextBox();
            this.lblDelDate = new OIS.BaseViews.rLabel();
            this.txtUpdId = new OIS.BaseViews.rTextBox();
            this.lblUpdId = new OIS.BaseViews.rLabel();
            this.txtUpdMachine = new OIS.BaseViews.rTextBox();
            this.lblUpdMachine = new OIS.BaseViews.rLabel();
            this.dtUpd = new OIS.BaseViews.rDateTextBox();
            this.lblUpdDate = new OIS.BaseViews.rLabel();
            this.txtCrtId = new OIS.BaseViews.rTextBox();
            this.lblCrtId = new OIS.BaseViews.rLabel();
            this.txtCrtMachine = new OIS.BaseViews.rTextBox();
            this.lblCrtMachine = new OIS.BaseViews.rLabel();
            this.dtCrt = new OIS.BaseViews.rDateTextBox();
            this.lblCrtDate = new OIS.BaseViews.rLabel();
            this.gbMain = new OIS.BaseViews.rGroupBox();
            this.lblShortName = new OIS.BaseViews.rLabel();
            this.txtShortName = new OIS.BaseViews.rTextBox();
            this.txtSeq = new OIS.BaseViews.rNumericTextBox();
            this.lblSeq = new OIS.BaseViews.rLabel();
            this.lblName = new OIS.BaseViews.rLabel();
            this.txtName = new OIS.BaseViews.rTextBox();
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.lblEditionName = new OIS.BaseViews.rLabel();
            this.txtEditionName = new OIS.BaseViews.rTextBox();
            this.txtPageFrom = new OIS.BaseViews.rNumericTextBox();
            this.txtPageTo = new OIS.BaseViews.rNumericTextBox();
            this.lblPageFrom = new OIS.BaseViews.rLabel();
            this.lblPageTo = new OIS.BaseViews.rLabel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            this.gbHistory.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbHistory);
            this.pnlMain.Controls.Add(this.gbMain);
            this.pnlMain.Controls.Add(this.lblHeader);
            // 
            // bdSource
            // 
            this.bdSource.DataSource = typeof(OIS.MAS.DTO.sp_MAS307_GetInstitutionSTD_Result);
            // 
            // gbHistory
            // 
            this.gbHistory.Controls.Add(this.txtDelId);
            this.gbHistory.Controls.Add(this.lblDelId);
            this.gbHistory.Controls.Add(this.txtDelMachine);
            this.gbHistory.Controls.Add(this.lblDelMachine);
            this.gbHistory.Controls.Add(this.dtDel);
            this.gbHistory.Controls.Add(this.lblDelDate);
            this.gbHistory.Controls.Add(this.txtUpdId);
            this.gbHistory.Controls.Add(this.lblUpdId);
            this.gbHistory.Controls.Add(this.txtUpdMachine);
            this.gbHistory.Controls.Add(this.lblUpdMachine);
            this.gbHistory.Controls.Add(this.dtUpd);
            this.gbHistory.Controls.Add(this.lblUpdDate);
            this.gbHistory.Controls.Add(this.txtCrtId);
            this.gbHistory.Controls.Add(this.lblCrtId);
            this.gbHistory.Controls.Add(this.txtCrtMachine);
            this.gbHistory.Controls.Add(this.lblCrtMachine);
            this.gbHistory.Controls.Add(this.dtCrt);
            this.gbHistory.Controls.Add(this.lblCrtDate);
            this.gbHistory.Location = new System.Drawing.Point(11, 164);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(846, 118);
            this.gbHistory.TabIndex = 15;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "ประวัติการบันทึก";
            // 
            // txtDelId
            // 
            this.txtDelId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "DEL_NAME", true));
            this.txtDelId.Enabled = false;
            this.txtDelId.IsRequired = false;
            this.txtDelId.Location = new System.Drawing.Point(131, 80);
            this.txtDelId.MinLength = 0;
            this.txtDelId.Name = "txtDelId";
            this.txtDelId.Size = new System.Drawing.Size(150, 23);
            this.txtDelId.TabIndex = 43;
            this.txtDelId.TextValue = null;
            // 
            // lblDelId
            // 
            this.lblDelId.AutoSize = true;
            this.lblDelId.Location = new System.Drawing.Point(64, 83);
            this.lblDelId.Name = "lblDelId";
            this.lblDelId.Size = new System.Drawing.Size(61, 16);
            this.lblDelId.TabIndex = 44;
            this.lblDelId.Text = "ผู้ยกเลิก :";
            this.lblDelId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDelMachine
            // 
            this.txtDelMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "DEL_MACHINE", true));
            this.txtDelMachine.Enabled = false;
            this.txtDelMachine.IsRequired = false;
            this.txtDelMachine.Location = new System.Drawing.Point(679, 80);
            this.txtDelMachine.MinLength = 0;
            this.txtDelMachine.Name = "txtDelMachine";
            this.txtDelMachine.Size = new System.Drawing.Size(150, 23);
            this.txtDelMachine.TabIndex = 41;
            this.txtDelMachine.TextValue = null;
            // 
            // lblDelMachine
            // 
            this.lblDelMachine.AutoSize = true;
            this.lblDelMachine.Location = new System.Drawing.Point(579, 83);
            this.lblDelMachine.Name = "lblDelMachine";
            this.lblDelMachine.Size = new System.Drawing.Size(94, 16);
            this.lblDelMachine.TabIndex = 42;
            this.lblDelMachine.Text = "เครื่องที่ยกเลิก :";
            this.lblDelMachine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtDel
            // 
            this.dtDel.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bdSource, "DEL_DATE", true));
            this.dtDel.Date = null;
            this.dtDel.DateValue = null;
            this.dtDel.Enabled = false;
            this.dtDel.IsRequired = false;
            this.dtDel.Location = new System.Drawing.Point(406, 80);
            this.dtDel.MaxLength = 10;
            this.dtDel.MinLength = 0;
            this.dtDel.Name = "dtDel";
            this.dtDel.ShowTime = true;
            this.dtDel.Size = new System.Drawing.Size(150, 23);
            this.dtDel.TabIndex = 39;
            this.dtDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtDel.TextValue = null;
            // 
            // lblDelDate
            // 
            this.lblDelDate.AutoSize = true;
            this.lblDelDate.Location = new System.Drawing.Point(324, 83);
            this.lblDelDate.Name = "lblDelDate";
            this.lblDelDate.Size = new System.Drawing.Size(76, 16);
            this.lblDelDate.TabIndex = 40;
            this.lblDelDate.Text = "วันที่ยกเลิก :";
            this.lblDelDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUpdId
            // 
            this.txtUpdId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "UPD_NAME", true));
            this.txtUpdId.Enabled = false;
            this.txtUpdId.IsRequired = false;
            this.txtUpdId.Location = new System.Drawing.Point(131, 51);
            this.txtUpdId.MinLength = 0;
            this.txtUpdId.Name = "txtUpdId";
            this.txtUpdId.Size = new System.Drawing.Size(150, 23);
            this.txtUpdId.TabIndex = 37;
            this.txtUpdId.TextValue = null;
            // 
            // lblUpdId
            // 
            this.lblUpdId.AutoSize = true;
            this.lblUpdId.Location = new System.Drawing.Point(69, 54);
            this.lblUpdId.Name = "lblUpdId";
            this.lblUpdId.Size = new System.Drawing.Size(56, 16);
            this.lblUpdId.TabIndex = 38;
            this.lblUpdId.Text = "ผู้แก้ไข :";
            this.lblUpdId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUpdMachine
            // 
            this.txtUpdMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "UPD_MACHINE", true));
            this.txtUpdMachine.Enabled = false;
            this.txtUpdMachine.IsRequired = false;
            this.txtUpdMachine.Location = new System.Drawing.Point(679, 51);
            this.txtUpdMachine.MinLength = 0;
            this.txtUpdMachine.Name = "txtUpdMachine";
            this.txtUpdMachine.Size = new System.Drawing.Size(150, 23);
            this.txtUpdMachine.TabIndex = 35;
            this.txtUpdMachine.TextValue = null;
            // 
            // lblUpdMachine
            // 
            this.lblUpdMachine.AutoSize = true;
            this.lblUpdMachine.Location = new System.Drawing.Point(584, 54);
            this.lblUpdMachine.Name = "lblUpdMachine";
            this.lblUpdMachine.Size = new System.Drawing.Size(89, 16);
            this.lblUpdMachine.TabIndex = 36;
            this.lblUpdMachine.Text = "เครื่องที่แก้ไข :";
            this.lblUpdMachine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtUpd
            // 
            this.dtUpd.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bdSource, "UPD_DATE", true));
            this.dtUpd.Date = null;
            this.dtUpd.DateValue = null;
            this.dtUpd.Enabled = false;
            this.dtUpd.IsRequired = false;
            this.dtUpd.Location = new System.Drawing.Point(406, 51);
            this.dtUpd.MaxLength = 10;
            this.dtUpd.MinLength = 0;
            this.dtUpd.Name = "dtUpd";
            this.dtUpd.ShowTime = true;
            this.dtUpd.Size = new System.Drawing.Size(150, 23);
            this.dtUpd.TabIndex = 33;
            this.dtUpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtUpd.TextValue = null;
            // 
            // lblUpdDate
            // 
            this.lblUpdDate.AutoSize = true;
            this.lblUpdDate.Location = new System.Drawing.Point(329, 54);
            this.lblUpdDate.Name = "lblUpdDate";
            this.lblUpdDate.Size = new System.Drawing.Size(71, 16);
            this.lblUpdDate.TabIndex = 34;
            this.lblUpdDate.Text = "วันที่แก้ไข :";
            this.lblUpdDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCrtId
            // 
            this.txtCrtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "CRT_NAME", true));
            this.txtCrtId.Enabled = false;
            this.txtCrtId.IsRequired = false;
            this.txtCrtId.Location = new System.Drawing.Point(131, 22);
            this.txtCrtId.MinLength = 0;
            this.txtCrtId.Name = "txtCrtId";
            this.txtCrtId.Size = new System.Drawing.Size(150, 23);
            this.txtCrtId.TabIndex = 31;
            this.txtCrtId.TextValue = null;
            // 
            // lblCrtId
            // 
            this.lblCrtId.AutoSize = true;
            this.lblCrtId.Location = new System.Drawing.Point(74, 25);
            this.lblCrtId.Name = "lblCrtId";
            this.lblCrtId.Size = new System.Drawing.Size(51, 16);
            this.lblCrtId.TabIndex = 32;
            this.lblCrtId.Text = "ผู้สร้าง :";
            this.lblCrtId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCrtMachine
            // 
            this.txtCrtMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "CRT_MACHINE", true));
            this.txtCrtMachine.Enabled = false;
            this.txtCrtMachine.IsRequired = false;
            this.txtCrtMachine.Location = new System.Drawing.Point(679, 22);
            this.txtCrtMachine.MinLength = 0;
            this.txtCrtMachine.Name = "txtCrtMachine";
            this.txtCrtMachine.Size = new System.Drawing.Size(150, 23);
            this.txtCrtMachine.TabIndex = 29;
            this.txtCrtMachine.TextValue = null;
            // 
            // lblCrtMachine
            // 
            this.lblCrtMachine.AutoSize = true;
            this.lblCrtMachine.Location = new System.Drawing.Point(589, 25);
            this.lblCrtMachine.Name = "lblCrtMachine";
            this.lblCrtMachine.Size = new System.Drawing.Size(84, 16);
            this.lblCrtMachine.TabIndex = 30;
            this.lblCrtMachine.Text = "เครื่องที่สร้าง :";
            this.lblCrtMachine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtCrt
            // 
            this.dtCrt.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bdSource, "CRT_DATE", true));
            this.dtCrt.Date = null;
            this.dtCrt.DateValue = null;
            this.dtCrt.Enabled = false;
            this.dtCrt.IsRequired = false;
            this.dtCrt.Location = new System.Drawing.Point(406, 22);
            this.dtCrt.MaxLength = 10;
            this.dtCrt.MinLength = 0;
            this.dtCrt.Name = "dtCrt";
            this.dtCrt.ShowTime = true;
            this.dtCrt.Size = new System.Drawing.Size(150, 23);
            this.dtCrt.TabIndex = 27;
            this.dtCrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtCrt.TextValue = null;
            // 
            // lblCrtDate
            // 
            this.lblCrtDate.AutoSize = true;
            this.lblCrtDate.Location = new System.Drawing.Point(334, 25);
            this.lblCrtDate.Name = "lblCrtDate";
            this.lblCrtDate.Size = new System.Drawing.Size(66, 16);
            this.lblCrtDate.TabIndex = 28;
            this.lblCrtDate.Text = "วันที่สร้าง :";
            this.lblCrtDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lblPageTo);
            this.gbMain.Controls.Add(this.lblPageFrom);
            this.gbMain.Controls.Add(this.txtPageTo);
            this.gbMain.Controls.Add(this.txtPageFrom);
            this.gbMain.Controls.Add(this.lblEditionName);
            this.gbMain.Controls.Add(this.txtEditionName);
            this.gbMain.Controls.Add(this.lblShortName);
            this.gbMain.Controls.Add(this.txtShortName);
            this.gbMain.Controls.Add(this.txtSeq);
            this.gbMain.Controls.Add(this.lblSeq);
            this.gbMain.Controls.Add(this.lblName);
            this.gbMain.Controls.Add(this.txtName);
            this.gbMain.Location = new System.Drawing.Point(11, 36);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(846, 122);
            this.gbMain.TabIndex = 14;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "ข้อมูลทั่วไป";
            // 
            // lblShortName
            // 
            this.lblShortName.AutoSize = true;
            this.lblShortName.Location = new System.Drawing.Point(401, 25);
            this.lblShortName.Name = "lblShortName";
            this.lblShortName.Size = new System.Drawing.Size(49, 16);
            this.lblShortName.TabIndex = 26;
            this.lblShortName.Text = "ชื่อย่อ :";
            this.lblShortName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtShortName
            // 
            this.txtShortName.CausesValidation = false;
            this.txtShortName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "SHORT_NAME", true));
            this.txtShortName.IsRequired = true;
            this.txtShortName.Location = new System.Drawing.Point(456, 22);
            this.txtShortName.MaxLength = 50;
            this.txtShortName.MinLength = 0;
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(250, 23);
            this.txtShortName.TabIndex = 2;
            this.txtShortName.TextValue = null;
            // 
            // txtSeq
            // 
            this.txtSeq.CausesValidation = false;
            this.txtSeq.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bdSource, "SEQ", true));
            this.txtSeq.DecimalPlace = 0;
            this.txtSeq.DecimalValue = null;
            this.txtSeq.IsRequired = true;
            this.txtSeq.Location = new System.Drawing.Point(131, 83);
            this.txtSeq.MinLength = 0;
            this.txtSeq.MinValue = null;
            this.txtSeq.Name = "txtSeq";
            this.txtSeq.NullableDecimalValue = null;
            this.txtSeq.NullableIntValue = null;
            this.txtSeq.Size = new System.Drawing.Size(100, 23);
            this.txtSeq.TabIndex = 6;
            this.txtSeq.TextValue = null;
            // 
            // lblSeq
            // 
            this.lblSeq.AutoSize = true;
            this.lblSeq.Location = new System.Drawing.Point(78, 86);
            this.lblSeq.Name = "lblSeq";
            this.lblSeq.Size = new System.Drawing.Size(47, 16);
            this.lblSeq.TabIndex = 23;
            this.lblSeq.Text = "ลำดับ :";
            this.lblSeq.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(92, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "ชื่อ :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.CausesValidation = false;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "NAME", true));
            this.txtName.IsRequired = true;
            this.txtName.Location = new System.Drawing.Point(131, 22);
            this.txtName.MaxLength = 50;
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
            this.lblHeader.Size = new System.Drawing.Size(403, 33);
            this.lblHeader.TabIndex = 13;
            this.lblHeader.Text = "ข้อมูลหน่วยงานกำหนดมาตรฐาน";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEditionName
            // 
            this.lblEditionName.AutoSize = true;
            this.lblEditionName.Location = new System.Drawing.Point(22, 54);
            this.lblEditionName.Name = "lblEditionName";
            this.lblEditionName.Size = new System.Drawing.Size(103, 16);
            this.lblEditionName.TabIndex = 28;
            this.lblEditionName.Text = "Volume/Edition :";
            this.lblEditionName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEditionName
            // 
            this.txtEditionName.CausesValidation = false;
            this.txtEditionName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdSource, "EDITION_NAME", true));
            this.txtEditionName.IsRequired = false;
            this.txtEditionName.Location = new System.Drawing.Point(131, 51);
            this.txtEditionName.MaxLength = 50;
            this.txtEditionName.MinLength = 0;
            this.txtEditionName.Name = "txtEditionName";
            this.txtEditionName.Size = new System.Drawing.Size(250, 23);
            this.txtEditionName.TabIndex = 3;
            this.txtEditionName.TextValue = null;
            // 
            // txtPageFrom
            // 
            this.txtPageFrom.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bdSource, "PAGE_FROM", true));
            this.txtPageFrom.DecimalPlace = 0;
            this.txtPageFrom.DecimalValue = null;
            this.txtPageFrom.IsRequired = false;
            this.txtPageFrom.Location = new System.Drawing.Point(456, 51);
            this.txtPageFrom.MinLength = 0;
            this.txtPageFrom.MinValue = null;
            this.txtPageFrom.Name = "txtPageFrom";
            this.txtPageFrom.NullableDecimalValue = null;
            this.txtPageFrom.NullableIntValue = null;
            this.txtPageFrom.Size = new System.Drawing.Size(100, 23);
            this.txtPageFrom.TabIndex = 4;
            this.txtPageFrom.TextValue = null;
            // 
            // txtPageTo
            // 
            this.txtPageTo.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bdSource, "PAGE_TO", true));
            this.txtPageTo.DecimalPlace = 0;
            this.txtPageTo.DecimalValue = null;
            this.txtPageTo.IsRequired = false;
            this.txtPageTo.Location = new System.Drawing.Point(606, 51);
            this.txtPageTo.MinLength = 0;
            this.txtPageTo.MinValue = null;
            this.txtPageTo.Name = "txtPageTo";
            this.txtPageTo.NullableDecimalValue = null;
            this.txtPageTo.NullableIntValue = null;
            this.txtPageTo.Size = new System.Drawing.Size(100, 23);
            this.txtPageTo.TabIndex = 5;
            this.txtPageTo.TextValue = null;
            // 
            // lblPageFrom
            // 
            this.lblPageFrom.AutoSize = true;
            this.lblPageFrom.Location = new System.Drawing.Point(411, 54);
            this.lblPageFrom.Name = "lblPageFrom";
            this.lblPageFrom.Size = new System.Drawing.Size(39, 16);
            this.lblPageFrom.TabIndex = 31;
            this.lblPageFrom.Text = "หน้า :";
            this.lblPageFrom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPageTo
            // 
            this.lblPageTo.AutoSize = true;
            this.lblPageTo.Location = new System.Drawing.Point(579, 54);
            this.lblPageTo.Name = "lblPageTo";
            this.lblPageTo.Size = new System.Drawing.Size(13, 16);
            this.lblPageTo.TabIndex = 32;
            this.lblPageTo.Text = "-";
            this.lblPageTo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MAS307_InstitutionStandardEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 668);
            this.Name = "MAS307_InstitutionStandardEntry";
            this.Text = "MAS307: ข้อมูลหน่วยงานกำหนดมาตรฐาน";
            this.OnSave += new System.EventHandler(this.MAS307_InstitutionStandardEntry_OnSave);
            this.OnCancel += new System.EventHandler(this.MAS307_InstitutionStandardEntry_OnCancel);
            this.OnRecovery += new System.EventHandler(this.MAS307_InstitutionStandardEntry_OnRecovery);
            this.Load += new System.EventHandler(this.MAS307_InstitutionStandardEntry_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseViews.rGroupBox gbHistory;
        private BaseViews.rTextBox txtDelId;
        private BaseViews.rLabel lblDelId;
        private BaseViews.rTextBox txtDelMachine;
        private BaseViews.rLabel lblDelMachine;
        private BaseViews.rDateTextBox dtDel;
        private BaseViews.rLabel lblDelDate;
        private BaseViews.rTextBox txtUpdId;
        private BaseViews.rLabel lblUpdId;
        private BaseViews.rTextBox txtUpdMachine;
        private BaseViews.rLabel lblUpdMachine;
        private BaseViews.rDateTextBox dtUpd;
        private BaseViews.rLabel lblUpdDate;
        private BaseViews.rTextBox txtCrtId;
        private BaseViews.rLabel lblCrtId;
        private BaseViews.rTextBox txtCrtMachine;
        private BaseViews.rLabel lblCrtMachine;
        private BaseViews.rDateTextBox dtCrt;
        private BaseViews.rLabel lblCrtDate;
        private BaseViews.rGroupBox gbMain;
        private BaseViews.rLabel lblShortName;
        private BaseViews.rTextBox txtShortName;
        private BaseViews.rNumericTextBox txtSeq;
        private BaseViews.rLabel lblSeq;
        private BaseViews.rLabel lblName;
        private BaseViews.rTextBox txtName;
        private BaseViews.rLabel lblHeader;
        private BaseViews.rLabel lblPageTo;
        private BaseViews.rLabel lblPageFrom;
        private BaseViews.rNumericTextBox txtPageTo;
        private BaseViews.rNumericTextBox txtPageFrom;
        private BaseViews.rLabel lblEditionName;
        private BaseViews.rTextBox txtEditionName;
    }
}