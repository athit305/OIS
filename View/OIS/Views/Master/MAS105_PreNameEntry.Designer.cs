﻿namespace OIS.Views
{
    partial class MAS105_PreNameEntry
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
            this.components = new System.ComponentModel.Container();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
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
            this.lblHeader = new OIS.BaseViews.rLabel();
            this.gbMain = new OIS.BaseViews.rGroupBox();
            this.lblModel = new OIS.BaseViews.rLabel();
            this.txtNameEn = new OIS.BaseViews.rTextBox();
            this.txtSeq = new OIS.BaseViews.rNumericTextBox();
            this.lblSeq = new OIS.BaseViews.rLabel();
            this.lblName = new OIS.BaseViews.rLabel();
            this.txtNameTh = new OIS.BaseViews.rTextBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.gbHistory.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbHistory);
            this.pnlMain.Controls.Add(this.lblHeader);
            this.pnlMain.Controls.Add(this.gbMain);
            this.pnlMain.Size = new System.Drawing.Size(1164, 638);
            // 
            // bs
            // 
            this.bs.DataSource = typeof(OIS.MAS.DTO.sp_MAS105_GetPreName_Result);
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
            this.gbHistory.Location = new System.Drawing.Point(11, 131);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(846, 118);
            this.gbHistory.TabIndex = 18;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "ประวัติการบันทึก";
            // 
            // txtDelId
            // 
            this.txtDelId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "DEL_NAME", true));
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
            this.txtDelMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "DEL_MACHINE", true));
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
            this.dtDel.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bs, "DEL_DATE", true));
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
            this.txtUpdId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "UPD_NAME", true));
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
            this.txtUpdMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "UPD_MACHINE", true));
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
            this.dtUpd.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bs, "UPD_DATE", true));
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
            this.txtCrtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "CRT_NAME", true));
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
            this.txtCrtMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "CRT_MACHINE", true));
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
            this.dtCrt.DataBindings.Add(new System.Windows.Forms.Binding("DateValue", this.bs, "CRT_DATE", true));
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
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(202, 33);
            this.lblHeader.TabIndex = 16;
            this.lblHeader.Text = "ข้อมูลคำนำหน้า";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lblModel);
            this.gbMain.Controls.Add(this.txtNameEn);
            this.gbMain.Controls.Add(this.txtSeq);
            this.gbMain.Controls.Add(this.lblSeq);
            this.gbMain.Controls.Add(this.lblName);
            this.gbMain.Controls.Add(this.txtNameTh);
            this.gbMain.Location = new System.Drawing.Point(11, 36);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(846, 89);
            this.gbMain.TabIndex = 17;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "ข้อมูลทั่วไป";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(389, 25);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(132, 16);
            this.lblModel.TabIndex = 26;
            this.lblModel.Text = "ชื่อคำนำหน้า (อังกฤษ):";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNameEn
            // 
            this.txtNameEn.CausesValidation = false;
            this.txtNameEn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "NAME_EN", true));
            this.txtNameEn.IsRequired = true;
            this.txtNameEn.Location = new System.Drawing.Point(527, 22);
            this.txtNameEn.MaxLength = 50;
            this.txtNameEn.MinLength = 0;
            this.txtNameEn.Name = "txtNameEn";
            this.txtNameEn.Size = new System.Drawing.Size(250, 23);
            this.txtNameEn.TabIndex = 2;
            this.txtNameEn.TextValue = null;
            // 
            // txtSeq
            // 
            this.txtSeq.CausesValidation = false;
            this.txtSeq.DataBindings.Add(new System.Windows.Forms.Binding("NullableIntValue", this.bs, "SEQ", true));
            this.txtSeq.DecimalPlace = 0;
            this.txtSeq.DecimalValue = null;
            this.txtSeq.IsRequired = true;
            this.txtSeq.Location = new System.Drawing.Point(131, 51);
            this.txtSeq.MinLength = 0;
            this.txtSeq.MinValue = null;
            this.txtSeq.Name = "txtSeq";
            this.txtSeq.NullableDecimalValue = null;
            this.txtSeq.NullableIntValue = null;
            this.txtSeq.Size = new System.Drawing.Size(100, 23);
            this.txtSeq.TabIndex = 3;
            this.txtSeq.TextValue = null;
            // 
            // lblSeq
            // 
            this.lblSeq.AutoSize = true;
            this.lblSeq.Location = new System.Drawing.Point(78, 54);
            this.lblSeq.Name = "lblSeq";
            this.lblSeq.Size = new System.Drawing.Size(47, 16);
            this.lblSeq.TabIndex = 23;
            this.lblSeq.Text = "ลำดับ :";
            this.lblSeq.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "ชื่อคำนำหน้า (ไทย) :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNameTh
            // 
            this.txtNameTh.CausesValidation = false;
            this.txtNameTh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "NAME_TH", true));
            this.txtNameTh.IsRequired = true;
            this.txtNameTh.Location = new System.Drawing.Point(131, 22);
            this.txtNameTh.MaxLength = 50;
            this.txtNameTh.MinLength = 0;
            this.txtNameTh.Name = "txtNameTh";
            this.txtNameTh.Size = new System.Drawing.Size(250, 23);
            this.txtNameTh.TabIndex = 1;
            this.txtNameTh.TextValue = null;
            // 
            // MAS105_PreNameEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1164, 692);
            this.Name = "MAS105_PreNameEntry";
            this.Text = "MAS105: ข้อมูลคำนำหน้า";
            this.OnSave += new System.EventHandler(this.MAS105_PreNameEntry_OnSave);
            this.OnCancel += new System.EventHandler(this.MAS105_PreNameEntry_OnCancel);
            this.OnRecovery += new System.EventHandler(this.MAS105_PreNameEntry_OnRecovery);
            this.Load += new System.EventHandler(this.MAS105_PreNameEntry_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
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
        private BaseViews.rLabel lblHeader;
        private BaseViews.rGroupBox gbMain;
        private BaseViews.rLabel lblModel;
        private BaseViews.rTextBox txtNameEn;
        private BaseViews.rNumericTextBox txtSeq;
        private BaseViews.rLabel lblSeq;
        private BaseViews.rLabel lblName;
        private BaseViews.rTextBox txtNameTh;
    }
}