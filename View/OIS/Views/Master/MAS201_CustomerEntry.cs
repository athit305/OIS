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
    public partial class MAS201_CustomerEntry : rBaseDialog
    {
        #region "Enum"
        private enum eCol
        {

        }
        #endregion

        #region "Variable"
        private MasterViewModel vmMas = new MasterViewModel();
        private ComboViewModel vmCombo = new ComboViewModel();

        private sp_MAS201_GetCustomer_Result custResult;
        #endregion

        #region "Constructor"
        public MAS201_CustomerEntry()
        {
            InitializeComponent();
        }
        public MAS201_CustomerEntry(sp_MAS201_GetCustomer_Result data)
        {
            InitializeComponent();
            custResult = data;
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            try
            {
                cboProvince.SetDataSource(vmCombo.GetComboProvince());
                cboLanguage.SetDataSource(vmCombo.GetComboLanguage());
                SetControlToValidate(txtNameTh, txtNameEn, txtAddrNo, txtMoo, txtBuildingEn, txtBuildingTh, txtAlleyEn, txtAlleyTh, txtLaneEn, txtLaneTh, txtRoadEn, txtRoadTh, txtSubDictrictEn, txtSubDictrictTh, txtDictrictEn, txtDictrictTh, cboProvince, txtPostCode, cboLanguage, txtSeq);

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
                if (custResult == null)
                {
                    custResult = new sp_MAS201_GetCustomer_Result();
                    custResult.IS_LANG_TH = true;
                    custResult.CRT_DATE = DateTime.Now;
                    this.ToolBarSwitch = "2122222222";
                }
                else if (custResult.DEL_ID.IsNull())
                {
                    this.ToolBarSwitch = "2122222102";
                }
                else
                {
                    this.ToolBarSwitch = "2022222012";
                }

                CtrlUtil.EnableControls(custResult.DEL_ID.IsNull(), txtNameTh, txtNameEn, txtAddrNo, txtMoo, txtBuildingEn, txtBuildingTh, txtAlleyEn, txtAlleyTh, txtLaneEn, txtLaneTh, txtRoadEn, txtRoadTh, txtSubDictrictEn, txtSubDictrictTh, txtDictrictEn, txtDictrictTh, cboProvince, txtPostCode, txtSeq);

                bs.DataSource = custResult;
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
                bs.EndEdit();
                gbMain.Focus();

                //if (rdoTh.Checked)
                //{
                //    this.custResult.DEFAULT_LANGUAGE = "TH";
                //    this.custResult.IS_LANG_TH = true;
                //    this.custResult.IS_LANG_EN = false;
                //}
                //else
                //{
                //    this.custResult.DEFAULT_LANGUAGE = "EN";
                //    this.custResult.IS_LANG_TH = false;
                //    this.custResult.IS_LANG_EN = true;
                //}

                if (!ValidateControl())
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
                    if (rMessageBox.ShowConfirmation(this, MessageCode.CFM0001) == DialogResult.Yes)
                    {
                        int ID =vmMas.SaveCustomer(custResult);
                        rMessageBox.ShowInfomation(this, MessageCode.INF0002);
                        this.IsDataChange = true;
                        custResult = vmMas.GetCustomer(ID);
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
                    vmMas.CancelCustomer(custResult, isCancel);
                    if (isCancel)
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0004);
                    }
                    else
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0005);
                    }
                    this.IsDataChange = true;
                    custResult = vmMas.GetCustomer(custResult.ID);
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
        private void MAS201_CustomerEntry_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS201_CustomerEntry_OnSave(object sender, EventArgs e)
        {
            SaveData();
        }

        private void MAS201_CustomerEntry_OnCancel(object sender, EventArgs e)
        {
            CancelData(true);
        }

        private void MAS201_CustomerEntry_OnRecovery(object sender, EventArgs e)
        {
            CancelData(false);
        }
        #endregion
    }
}
