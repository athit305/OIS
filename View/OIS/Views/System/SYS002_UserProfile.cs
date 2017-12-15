using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.BaseViews;
using OIS.Common;
using OIS.Common.Extensions;
using OIS.Definition;
using OIS.MAS.DTO;
using OIS.SYS.DTO;
using OIS.ViewModel;

namespace OIS.Views
{
    public partial class SYS002_UserProfile : rBaseUC
    {
        #region "Variable"
        SystemViewModel vmSys = new SystemViewModel();
        ComboViewModel vmCombo = new ComboViewModel();

        sp_SYS02_GetUserProfile_Result UserProfile;
        #endregion

        #region "Constructor"
        public SYS002_UserProfile()
        {
            InitializeComponent();
            InitialScreen();
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            this.ToolBarSwitch = "2122222222";

            cboPreName.SetDataSource(vmCombo.GetComboPreName(), true);
            cboDivision.SetDataSource(vmCombo.GetComboDivision(), true);
            cboSubDivision.SetDataSource(vmCombo.GetComboSubDivision(0), true);
            cboPosition.SetDataSource(vmCombo.GetComboPosition(), true);
            cboGroup.SetDataSource(vmCombo.GetComboGroup(), true);

            SetControlToValidate(cboPreName, txtFName_En, txtLName_En, txtFName_Th, txtLName_En, txtNickName, txtIDCard, dtBirthDate, dtStartDate, cboDivision, cboSubDivision, cboPosition, cboGroup, txtPassword, txtPasswordNew, txtPasswordConfirm);

            RetriveData();
        }
        private void RetriveData()
        {
            try
            {
                UserProfile = vmSys.GetUserProfile();
                UserProfile.PASS = null;
                bs2.DataSource = UserProfile;

                txtFName_Th.Focus();
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private bool ValidateBeforeSave()
        {
            if(!txtPassword.IsNull && txtPasswordNew.IsNull)
            {
                txtPasswordNew.SetValid("รหัสผ่านใหม่ห้ามว่าง");
                return false;
            }
            if (!txtPassword.IsNull && txtPasswordConfirm.IsNull)
            {
                txtPasswordConfirm.SetValid("ยืนยันรหัสผ่านห้ามว่าง");
                return false;
            }
            if (!txtPassword.IsNull && txtPasswordNew.Text != txtPasswordConfirm.Text)
            {
                txtPasswordConfirm.SetValid("รหัสผ่านใหม่และยืนยันรหัสผ่านต้องเหมือนกัน");
                return false;
            }
            if (!ValidateControl())
            {
                return false;
            }
            return true;
        }
        #endregion

        #region "Event"
        private void SYS02_UserProfile_OnSave(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (ValidateBeforeSave())
                {
                    if (rMessageBox.ShowConfirmation(this, MessageCode.CFM0001) == DialogResult.Yes)
                    {
                        bs2.EndEdit();
                        vmSys.SaveUserProfile(UserProfile);
                        rMessageBox.ShowInfomation(this, MessageCode.INF0002);

                        RetriveData();
                    }
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

        private void cboDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSubDivision.SetDataSource(vmCombo.GetComboSubDivision(cboDivision.NullableIntValue.GetValueOrDefault()), true);
        }

        private void picBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(dialog.FileName);
                if (fi.Length > 102400)
                {
                    rMessageBox.ShowWarning(this, "ขนาดไฟล์ต้องไม่เกิน 100kb.");
                    return;
                }
                picBox.Image = Image.FromFile(dialog.FileName);
                bs2.EndEdit();
            }
        }
        #endregion
    }
}
