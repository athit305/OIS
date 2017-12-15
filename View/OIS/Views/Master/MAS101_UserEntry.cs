using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.BaseViews;
using OIS.Common;
using OIS.Common.Extensions;
using OIS.Common.Utils;
using OIS.Definition;
using OIS.MAS.DTO;
using OIS.ViewModel;

namespace OIS.Views
{
    public partial class MAS101_UserEntry : rBaseDialog
    {
        #region "Enum"
        private enum eCol
        {

        }
        #endregion

        #region "Variable"
        private MasterViewModel vmMas = new MasterViewModel();
        private ComboViewModel vmCombo = new ComboViewModel();

        private sp_MAS101_GetUser_Result user;
        #endregion

        #region "Constructor"
        public MAS101_UserEntry()
        {
            InitializeComponent();
        }
        public MAS101_UserEntry(sp_MAS101_GetUser_Result user)
        {
            InitializeComponent();
            this.user = user;
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            try
            {
                cboPreName.SetDataSource(vmCombo.GetComboPreName(), true);
                cboDivision.SetDataSource(vmCombo.GetComboDivision(), true);
                cboSubDivision.SetDataSource(vmCombo.GetComboSubDivision(-1), true);
                cboPosition.SetDataSource(vmCombo.GetComboPosition(), true);
                cboGroup.SetDataSource(vmCombo.GetComboGroup(), true);

                SetControlToValidate(txtID, cboPreName, txtFName_En, txtLName_En, txtFName_Th, txtLName_Th, txtNickName, txtIDCard, dtBirthDate, dtStartDate, cboDivision, cboSubDivision, cboPosition, cboGroup, txtPassword);

                RetriveData();
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void RetriveData()
        {
            try
            {
                if (user == null)
                {
                    user = new sp_MAS101_GetUser_Result();
                    user.CRT_DATE = DateTime.Now;
                    this.ToolBarSwitch = "2122222222";
                    CtrlUtil.EnableControls(true, txtID);
                }
                else if (user.DEL_ID.IsNull())
                {
                    this.ToolBarSwitch = "2122222102";
                    CtrlUtil.EnableControls(false, txtID);
                }
                else
                {
                    this.ToolBarSwitch = "2022222012";
                    CtrlUtil.EnableControls(false, txtID);
                }

                CtrlUtil.EnableControls(user.DEL_ID.IsNull(), cboPreName, cboDivision, cboSubDivision, cboPosition, cboGroup);
                CtrlUtil.EnableControls(user.DEL_ID.IsNull(), txtFName_En, txtLName_En, txtFName_Th, txtLName_Th, txtNickName, txtIDCard, dtBirthDate, dtStartDate, txtPassword, txtRegistrationNo, txtLabSupervisorNo);

                user.PASS = null;
                bs.DataSource = user;
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private bool ValidateBeforeSave()
        {

            try
            {
                gbMain.Focus();
                bs.EndEdit();

                if (user.CRT_ID.IsNull() && vmMas.IsExistsUser(user.ID))
                {
                    txtID.SetValid("รหัสพนักงานซ้ำ");
                    return false;
                }

                if(!ValidateControl())
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                return false;
            }
        }
        private void SaveData()
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (ValidateBeforeSave())
                {
                    if(rMessageBox.ShowConfirmation(this, MessageCode.CFM0001) == DialogResult.Yes)
                    {
                        string ID = vmMas.SaveUser(user);
                        rMessageBox.ShowInfomation(this, MessageCode.INF0002);
                        this.IsDataChange = true;
                        user = vmMas.GetUser(ID);
                        RetriveData();
                    }
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void CancelData(bool isCancel)
        {

            try
            {
                string msg;
                if (isCancel)
                {
                    msg = MessageCode.CFM0003;
                }
                else
                {
                    msg = MessageCode.CFM0004;
                }
                if (rMessageBox.ShowConfirmation(this, msg) == DialogResult.Yes)
                {
                    vmMas.CancelUser(user, isCancel);
                    if (isCancel)
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0004);
                    }
                    else
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0005);
                    }
                    this.IsDataChange = true;
                    user = vmMas.GetUser(user.ID);
                    RetriveData();
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        #endregion

        #region "Event"
        private void MAS101_UserEntry_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS101_UserEntry_OnSave(object sender, EventArgs e)
        {
            SaveData();
        }

        private void MAS101_UserEntry_OnCancel(object sender, EventArgs e)
        {
            CancelData(true);
        }

        private void MAS101_UserEntry_OnRecovery(object sender, EventArgs e)
        {
            CancelData(false);
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
                bs.EndEdit();
            }
        }
        #endregion
    }
}
