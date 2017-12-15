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
using OIS.SYS.DTO;
using OIS.ViewModel;

namespace OIS
{
    public partial class LoginForm : rBaseForm
    {
        #region "Variable"
        SystemViewModel vmSys = new SystemViewModel();
        #endregion

        #region "Constructor"
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region "Customize"
        #endregion

        #region "Event"
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = vmSys.LoadLastUserLogin();
            lblDatabase.Text = vmSys.LoadCredential().DatabaseString;
            if(txtUserName.GetValue() != null)
            {
                this.ActiveControl = txtPassword;
            }
        }

        private void rButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (txtUserName.GetValue() != null && txtPassword.GetValue() != null)
                {
                    if (vmSys.Login(txtUserName.GetValue(), txtPassword.GetValue()))
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Closed += (s, args) => this.Close();
                        mainForm.Show();
                    }
                    else
                    {
                        rMessageBox.ShowWarning(this, "ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", MessageBoxButtons.OK);
                    }
                }
                else if (txtUserName.GetValue() == null)
                {
                    rMessageBox.ShowWarning(this, "กรุณาระบุชื่อผู้ใช้", MessageBoxButtons.OK);
                }
                else if (txtPassword.GetValue() == null)
                {
                    rMessageBox.ShowWarning(this, "กรุณาระบุรหัสผ่าน", MessageBoxButtons.OK);
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

        private void rButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rButtonConfig_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            if (settingForm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                lblDatabase.Text = vmSys.LoadCredential().DatabaseString;
            }
        }
        #endregion

        #region "Override Method"
        #endregion
    }
}
