using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OIS.BaseViews;
using OIS.Common;
using OIS.Common.DTO;
using OIS.ViewModel;

namespace OIS
{
    public partial class SettingForm : rBaseForm
    {
        #region "Variable"
        SystemViewModel vmSys = new SystemViewModel();
        #endregion

        #region "Constructor"
        public SettingForm()
        {
            InitializeComponent();
        }
        #endregion

        #region "Customize"
        #endregion

        #region "Event"

        private void SettingForm_Load(object sender, EventArgs e)
        {
            DATABASE_INFO c = vmSys.LoadCredential();
            txtServerName.Text = c.DATASOURCE;
            txtDatabaseName.Text = c.DATABASENAME;
            txtUserName.Text = c.USERNAME;
            txtPassword.Text = c.PASSWORD;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (txtServerName.GetValue() == null)
                {
                    MessageBox.Show(this, "กรุณาระบบชื่อเซิฟเวอร์", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = txtServerName;
                }
                if (txtDatabaseName.GetValue() == null)
                {
                    MessageBox.Show(this, "กรุณาระบุชื่อฐานข้อมูล", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = txtDatabaseName;
                }
                if (txtUserName.GetValue() == null)
                {
                    MessageBox.Show(this, "กรุณาระบุชื่อผู้ใช้", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = txtUserName;
                }
                if (txtPassword.GetValue() == null)
                {
                    MessageBox.Show(this, "กรุณาระบุรหัสผ่าน", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = txtPassword;
                }
                else
                {
                    DATABASE_INFO credential = new DATABASE_INFO()
                    {
                        DATASOURCE = txtServerName.GetValue(),
                        DATABASENAME = txtDatabaseName.GetValue(),
                        USERNAME = txtUserName.GetValue(),
                        PASSWORD = txtPassword.GetValue(),
                    };
                    vmSys.SaveCredential(credential);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DATABASE_INFO credential = new DATABASE_INFO()
                {
                    DATASOURCE = txtServerName.GetValue(),
                    DATABASENAME = txtDatabaseName.GetValue(),
                    USERNAME = txtUserName.GetValue(),
                    PASSWORD = txtPassword.GetValue(),
                };
                if(vmSys.TestConnection(credential))
                {
                    rMessageBox.ShowInfomation(this, "เชื่อมต่อสำเร็จ");
                }
                else
                {
                    rMessageBox.ShowWarning(this, "ไม่สามารถเชื่อมต่อได้", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region "Override Method"
        #endregion
    }
}
