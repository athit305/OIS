namespace OIS
{
    partial class SettingForm
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
            this.rGroupBox1 = new OIS.BaseViews.rGroupBox();
            this.lblPassword = new OIS.BaseViews.rLabel();
            this.rLabel4 = new OIS.BaseViews.rLabel();
            this.rLabel3 = new OIS.BaseViews.rLabel();
            this.rLabel2 = new OIS.BaseViews.rLabel();
            this.txtPassword = new OIS.BaseViews.rTextBox();
            this.txtUserName = new OIS.BaseViews.rTextBox();
            this.txtDatabaseName = new OIS.BaseViews.rTextBox();
            this.txtServerName = new OIS.BaseViews.rTextBox();
            this.btnTest = new OIS.BaseViews.rButton();
            this.btnCancel = new OIS.BaseViews.rButton();
            this.btnOK = new OIS.BaseViews.rButton();
            this.rGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rGroupBox1
            // 
            this.rGroupBox1.Controls.Add(this.lblPassword);
            this.rGroupBox1.Controls.Add(this.rLabel4);
            this.rGroupBox1.Controls.Add(this.rLabel3);
            this.rGroupBox1.Controls.Add(this.rLabel2);
            this.rGroupBox1.Controls.Add(this.txtPassword);
            this.rGroupBox1.Controls.Add(this.txtUserName);
            this.rGroupBox1.Controls.Add(this.txtDatabaseName);
            this.rGroupBox1.Controls.Add(this.txtServerName);
            this.rGroupBox1.Controls.Add(this.btnTest);
            this.rGroupBox1.Location = new System.Drawing.Point(14, 15);
            this.rGroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rGroupBox1.Name = "rGroupBox1";
            this.rGroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rGroupBox1.Size = new System.Drawing.Size(373, 189);
            this.rGroupBox1.TabIndex = 0;
            this.rGroupBox1.TabStop = false;
            this.rGroupBox1.Text = "ฐานข้อมูล";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(59, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 16);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "รหัสผ่าน :";
            // 
            // rLabel4
            // 
            this.rLabel4.AutoSize = true;
            this.rLabel4.Location = new System.Drawing.Point(65, 89);
            this.rLabel4.Name = "rLabel4";
            this.rLabel4.Size = new System.Drawing.Size(55, 16);
            this.rLabel4.TabIndex = 7;
            this.rLabel4.Text = "ชื่อผู้ใช้ :";
            // 
            // rLabel3
            // 
            this.rLabel3.AutoSize = true;
            this.rLabel3.Location = new System.Drawing.Point(41, 27);
            this.rLabel3.Name = "rLabel3";
            this.rLabel3.Size = new System.Drawing.Size(79, 16);
            this.rLabel3.TabIndex = 6;
            this.rLabel3.Text = "ชื่อเซิฟเวอร์ :";
            // 
            // rLabel2
            // 
            this.rLabel2.AutoSize = true;
            this.rLabel2.Location = new System.Drawing.Point(34, 58);
            this.rLabel2.Name = "rLabel2";
            this.rLabel2.Size = new System.Drawing.Size(86, 16);
            this.rLabel2.TabIndex = 6;
            this.rLabel2.Text = "ชื่อฐานข้อมูล :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 117);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(241, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(126, 86);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(241, 23);
            this.txtUserName.TabIndex = 3;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(126, 55);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(241, 23);
            this.txtDatabaseName.TabIndex = 2;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(126, 24);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(241, 23);
            this.txtServerName.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(126, 148);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(241, 27);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "ทดสอบการเชื่อมต่อฐานข้อมูล";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(293, 212);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(200, 212);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 27);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "ตกลง";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SettingForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(401, 249);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rGroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ตั้งค่าการเชื่อมต่อ";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.rGroupBox1.ResumeLayout(false);
            this.rGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseViews.rGroupBox rGroupBox1;
        private BaseViews.rButton btnCancel;
        private BaseViews.rButton btnOK;
        private BaseViews.rTextBox txtPassword;
        private BaseViews.rTextBox txtUserName;
        private BaseViews.rTextBox txtDatabaseName;
        private BaseViews.rTextBox txtServerName;
        private BaseViews.rButton btnTest;
        private BaseViews.rLabel lblPassword;
        private BaseViews.rLabel rLabel4;
        private BaseViews.rLabel rLabel3;
        private BaseViews.rLabel rLabel2;
    }
}