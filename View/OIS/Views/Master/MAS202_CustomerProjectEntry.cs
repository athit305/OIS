using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class MAS202_CustomerProjectEntry : rBaseDialog
    {
        #region "Enum"
        private enum eCol
        {

        }
        #endregion

        #region "Variable"
        private MasterViewModel vmMas = new MasterViewModel();
        private ComboViewModel vmCombo = new ComboViewModel();

        private sp_MAS202_GetCustomerProject_Result custpResult;
        #endregion

        #region "Constructor"
        public MAS202_CustomerProjectEntry()
        {
            InitializeComponent();
        }
        public MAS202_CustomerProjectEntry(sp_MAS202_GetCustomerProject_Result data)
        {
            InitializeComponent();
            custpResult = data;
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            try
            {
                cboProvince.SetDataSource(vmCombo.GetComboProvince());
                cboLanguage.SetDataSource(vmCombo.GetComboLanguage());

                SetControlToValidate(txtNameTh, txtNameEn, txtCustomer, txtPostCode, cboLanguage, txtSeq);

                RetriveData();
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void RetriveData()
        {
            try
            {
                if (custpResult == null)
                {
                    custpResult = new sp_MAS202_GetCustomerProject_Result();
                    custpResult.CRT_DATE = DateTime.Now;
                    this.ToolBarSwitch = "2122222222";
                }
                else if (custpResult.DEL_ID.IsNull())
                {
                    this.ToolBarSwitch = "2122222102";
                }
                else
                {
                    this.ToolBarSwitch = "2022222012";
                }

                CtrlUtil.EnableControls(custpResult.DEL_ID.IsNull(), txtCustomer, txtNameTh, txtNameEn, txtAddrNo, txtMoo, txtBuildingEn, txtBuildingTh, txtAlleyEn, txtAlleyTh, txtLaneEn, txtLaneTh, txtRoadEn, txtRoadTh, txtSubDictrictEn, txtSubDictrictTh, txtDictrictEn, txtDictrictTh, cboProvince, txtPostCode, txtSeq);

                bs.DataSource = custpResult;
            }
            catch (Exception ex)
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

                if (!ValidateControl())
                {
                    return false;
                }

                //if (!custpResult.IS_LANG_EN.GetValueOrDefault())
                //{
                //    custpResult.DEFAULT_LANGUAGE = "TH";
                //}
                //else
                //{
                //    custpResult.DEFAULT_LANGUAGE = "EN";
                //}

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
                    if (rMessageBox.ShowConfirmation(this, MessageCode.CFM0001) == DialogResult.Yes)
                    {
                        int ID =vmMas.SaveCustomerProject(custpResult);
                        rMessageBox.ShowInfomation(this, MessageCode.INF0002);
                        this.IsDataChange = true;
                        custpResult = vmMas.GetCustomerProject(ID);
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
                    vmMas.CancelCustomerProject(custpResult, isCancel);
                    if (isCancel)
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0004);
                    }
                    else
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0005);
                    }
                    this.IsDataChange = true;
                    custpResult = vmMas.GetCustomerProject(custpResult.ID);
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
        private void MAS202_CustomerProjectEntry_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS202_CustomerProjectEntry_OnSave(object sender, EventArgs e)
        {
            SaveData();
        }

        private void MAS202_CustomerProjectEntry_OnCancel(object sender, EventArgs e)
        {
            CancelData(true);
        }

        private void MAS202_CustomerProjectEntry_OnRecovery(object sender, EventArgs e)
        {
            CancelData(false);
        }
        #endregion
    }
}
