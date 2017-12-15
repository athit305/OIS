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
    public partial class MAS305_ParameterAnalysisEntry : rBaseDialog
    {
        #region "Enum"
        private enum eCol
        {

        }
        #endregion

        #region "Variable"
        private MasterViewModel vmMas = new MasterViewModel();
        private ComboViewModel vmCombo = new ComboViewModel();

        private sp_MAS305_GetParameterAnalysis_Result ParameterResult;
        #endregion

        #region "Constructor"
        public MAS305_ParameterAnalysisEntry()
        {
            InitializeComponent();
        }
        public MAS305_ParameterAnalysisEntry(sp_MAS305_GetParameterAnalysis_Result data)
        {
            InitializeComponent();
            ParameterResult = data;
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            try
            {
                cboUnit.SetDataSource(vmCombo.GetComboUnit(), true);
                cboLabExt.SetDataSource(vmCombo.GetComboLabExt(), true);
                SetControlToValidate(txtName, txtMethod, cboUnit, txtStandardThai, txtStandardACGIH, txtToolPick, txtToolAnalysis, txtSeq);

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
                if (ParameterResult == null)
                {
                    ParameterResult = new sp_MAS305_GetParameterAnalysis_Result();
                    ParameterResult.CRT_DATE = DateTime.Now;
                    this.ToolBarSwitch = "2122222222";
                }
                else if (ParameterResult.DEL_ID.IsNull())
                {
                    this.ToolBarSwitch = "2122222102";
                }
                else
                {
                    this.ToolBarSwitch = "2022222012";
                }

                CtrlUtil.EnableControls(ParameterResult.DEL_ID.IsNull(), txtName, txtMethod, cboUnit, txtStandardThai, txtStandardACGIH, txtToolPick, txtToolAnalysis, txtSeq);
                CtrlUtil.EnableControls(ParameterResult.DEL_ID.IsNull(), txtMethodRef, txtMethodRemark, txtMRLValue, cboLabExt, txtAnalysisDetail, chkCeilingLimit);

                bdSource.DataSource = ParameterResult;
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
                bdSource.EndEdit();

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
                        int ID = vmMas.SaveParameterAnalysis(ParameterResult);
                        rMessageBox.ShowInfomation(this, MessageCode.INF0002);
                        this.IsDataChange = true;
                        ParameterResult = vmMas.GetParameterAnalysis(ID);
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
                    vmMas.CancelParameterAnalysis(ParameterResult, isCancel);
                    if (isCancel)
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0004);
                    }
                    else
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0005);
                    }
                    this.IsDataChange = true;
                    ParameterResult = vmMas.GetParameterAnalysis(ParameterResult.ID);
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
        private void MAS305_ParameterAnalysisEntry_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS305_ParameterAnalysisEntry_OnSave(object sender, EventArgs e)
        {
            SaveData();
        }

        private void MAS305_ParameterAnalysisEntry_OnCancel(object sender, EventArgs e)
        {
            CancelData(true);
        }

        private void MAS305_ParameterAnalysisEntry_OnRecovery(object sender, EventArgs e)
        {
            CancelData(false);
        }
        #endregion
    }
}
