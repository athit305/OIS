using OIS.BaseViews;
using OIS.Common;
using OIS.Common.Extensions;
using OIS.Common.Utils;
using OIS.MAS.DTO;
using OIS.RPT.DTO;
using OIS.ViewModel;
using OIS.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIS.Views.Report
{
    public partial class RPT001_WorkPlaceLightIntensity_Detail_Dialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {
            LOC_NAME_LV3,
            LOC_NAME_LV2,
            LOC_NAME,
            LOC_BTN,
            STDLIGHT_NAME,
            STDLIGHT_BTN,
            RESULT_DAY,
            RESULT_NIGHT,
            STDLIGHT_STANDARD,
            CONDITION,
            ID,
            WPL_ID,
            STDLIGHT_ID,
            CRT_NAME,
            CRT_DATE,
            CRT_MACHINE,
            UPD_NAME,
            UPD_DATE,
            UPD_MACHINE,
            DEL_NAME,
            DEL_DATE,
            DEL_MACHINE,
            CRT_ID,
            UPD_ID,
            DEL_ID,
        }
        #endregion

        #region "Variable"
        private ComboViewModel vmCombo = new ComboViewModel();
        private MasterViewModel vmMas = new MasterViewModel();
        private RPT001_WorkPlaceLightDTO result;
        #endregion

        #region "Constructor"
        public RPT001_WorkPlaceLightIntensity_Detail_Dialog(RPT001_WorkPlaceLightDTO data)
        {
            try
            {
                InitializeComponent();
                this.result = data;
                this.InitialScreen();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            try
            {
                gvDetail.SetOISStyle(true);
                gvDetail.MappingEnum(typeof(eCol));

                gvDetail.SetColumnNumeric((int)eCol.STDLIGHT_STANDARD);
                gvDetail.SetColumnNumeric((int)eCol.RESULT_DAY);
                gvDetail.SetColumnNumeric((int)eCol.RESULT_NIGHT);
                gvDetail.SetColumnText((int)eCol.CONDITION);

                for (int i = (int)eCol.ID; i <= (int)eCol.DEL_ID; i++)
                {
                    gvDetail.Columns[i].Visible = false;
                }
                gvDetail.Columns[(int)eCol.LOC_BTN].Visible = false;
                gvDetail.Columns[(int)eCol.STDLIGHT_BTN].Visible = false;

                gvDetail.Columns[(int)eCol.RESULT_DAY].Visible = this.result.MEASURED_DATE.HasValue;
                gvDetail.Columns[(int)eCol.RESULT_NIGHT].Visible = this.result.MEASURED_DATE_NIGHT.HasValue;

                CtrlUtil.EnableControls(this.result.MEASURED_DATE.HasValue, txtResultDay);
                CtrlUtil.EnableControls(this.result.MEASURED_DATE_NIGHT.HasValue, txtResultNight);
                CtrlUtil.EnableControls(false, txtStdName);

                gvDetail.DataSource = this.result.Detail;


                this.SetGridError();
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void SetGridError()
        {
            try
            {
                for (int r = 0; r < gvDetail.RowCount; r++)
                {
                    int? STDLIGHT_STANDARD = gvDetail.GetIntValueOrNull(r, (int)eCol.STDLIGHT_STANDARD);
                    int? RESULT_DAY = gvDetail.GetIntValueOrNull(r, (int)eCol.RESULT_DAY);
                    int? RESULT_NIGHT = gvDetail.GetIntValueOrNull(r, (int)eCol.RESULT_NIGHT);

                    bool isError = (RESULT_DAY.HasValue && STDLIGHT_STANDARD > RESULT_DAY) || (RESULT_NIGHT.HasValue && STDLIGHT_STANDARD > RESULT_NIGHT);
                    gvDetail.SetRowDeletedStyle(r, isError);
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private bool ValidateData()
        {
            try
            {
                if (txtLocationName.GetValue() == null)
                {
                    rMessageBox.ShowWarning(this, "Measured Location ห้ามว่าง", MessageBoxButtons.OK);
                    txtLocationName.Focus();
                    return false;
                }
                if (!txtStdLight.IntValue.HasValue)
                {
                    rMessageBox.ShowWarning(this, "Type of Work ห้ามว่าง", MessageBoxButtons.OK);
                    txtStdLight.Focus();
                    return false;
                }
                if (!txtResultDay.NullableIntValue.HasValue && !txtResultNight.NullableIntValue.HasValue)
                {
                    rMessageBox.ShowWarning(this, "Result ห้ามว่าง", MessageBoxButtons.OK);
                    if (txtResultDay.Enabled)
                    {
                        txtResultDay.Focus();
                    }
                    else
                    {
                        txtResultNight.Focus();
                    }
                    return false;
                }
                if (txtResultDay.NullableIntValue > 0 && txtResultDay.NullableIntValue < txtStdValue.NullableIntValue && txtCondition.TextValue == null)
                {
                    rMessageBox.ShowWarning(this, "Condition ห้ามว่าง", MessageBoxButtons.OK);
                    txtCondition.Focus();
                    return false;
                }
                if (txtResultNight.NullableIntValue > 0 && txtResultNight.NullableIntValue < txtStdValue.NullableIntValue && txtCondition.TextValue == null)
                {
                    rMessageBox.ShowWarning(this, "Condition ห้ามว่าง", MessageBoxButtons.OK);
                    txtCondition.Focus();
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                return false;
            }
        }

        private sp_RPT001_GetWorkPlaceLightDt_Result GetDataFromRow(int rowIndex)
        {
            try
            {
                sp_RPT001_GetWorkPlaceLightDt_Result result = new sp_RPT001_GetWorkPlaceLightDt_Result()
                {
                    WPL_ID = gvDetail.GetIntValue(rowIndex, (int)eCol.WPL_ID),
                    LOC_NAME = gvDetail.GetStringValue(rowIndex, (int)eCol.LOC_NAME),
                    LOC_NAME_LV2 = gvDetail.GetStringValue(rowIndex, (int)eCol.LOC_NAME_LV2),
                    LOC_NAME_LV3 = gvDetail.GetStringValue(rowIndex, (int)eCol.LOC_NAME_LV3),
                    STDLIGHT_ID = gvDetail.GetIntValueOrNull(rowIndex, (int)eCol.STDLIGHT_ID),
                    STDLIGHT_NAME = gvDetail.GetStringValue(rowIndex, (int)eCol.STDLIGHT_NAME),
                    STDLIGHT_STANDARD = gvDetail.GetIntValue(rowIndex, (int)eCol.STDLIGHT_STANDARD),
                    RESULT_DAY = gvDetail.GetIntValueOrNull(rowIndex, (int)eCol.RESULT_DAY),
                    RESULT_NIGHT = gvDetail.GetIntValueOrNull(rowIndex, (int)eCol.RESULT_NIGHT),
                    CONDITION = gvDetail.GetStringValue(rowIndex, (int)eCol.CONDITION),
                };

                return result;
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                return null;
            }
        }
        private sp_RPT001_GetWorkPlaceLightDt_Result GetDataFromControl()
        {
            try
            {
                sp_RPT001_GetWorkPlaceLightDt_Result result = new sp_RPT001_GetWorkPlaceLightDt_Result()
                {
                    WPL_ID = this.result.ID,
                    LOC_NAME = txtLocationName.TextValue,
                    LOC_NAME_LV2 = txtLocationLV2.TextValue,
                    LOC_NAME_LV3 = txtLocationLV3.TextValue,
                    STDLIGHT_ID = txtStdLight.IntValue,
                    STDLIGHT_NAME = txtStdName.TextValue,
                    STDLIGHT_STANDARD = txtStdValue.NullableIntValue.GetValueOrDefault(),
                    RESULT_DAY = txtResultDay.NullableIntValue,
                    RESULT_NIGHT = txtResultNight.NullableIntValue,
                    CONDITION = txtCondition.TextValue,
                };

                return result;
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                return null;
            }
        }

        private void SetDataToRow(sp_RPT001_GetWorkPlaceLightDt_Result data, int rowIndex)
        {
            try
            {
                DataGridViewRow dr = gvDetail.Rows[rowIndex];
                if (dr != null)
                {
                    dr.Cells[(int)eCol.ID].SetValue(data.ID);
                    dr.Cells[(int)eCol.WPL_ID].SetValue(this.result.ID);
                    dr.Cells[(int)eCol.LOC_NAME_LV3].SetValue(data.LOC_NAME_LV3);
                    dr.Cells[(int)eCol.LOC_NAME_LV2].SetValue(data.LOC_NAME_LV2);
                    dr.Cells[(int)eCol.LOC_NAME].SetValue(data.LOC_NAME);
                    dr.Cells[(int)eCol.STDLIGHT_ID].SetValue(data.STDLIGHT_ID);
                    dr.Cells[(int)eCol.STDLIGHT_NAME].SetValue(data.STDLIGHT_NAME);
                    dr.Cells[(int)eCol.STDLIGHT_STANDARD].SetValue(data.STDLIGHT_STANDARD);
                    dr.Cells[(int)eCol.RESULT_DAY].SetValue(data.RESULT_DAY);
                    dr.Cells[(int)eCol.RESULT_NIGHT].SetValue(data.RESULT_NIGHT);
                    dr.Cells[(int)eCol.CONDITION].SetValue(data.CONDITION);
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void SetDataToControl(sp_RPT001_GetWorkPlaceLightDt_Result data)
        {
            try
            {
                txtLocationLV3.Text = data.LOC_NAME_LV3;
                txtLocationLV2.Text = data.LOC_NAME_LV2;
                txtLocationName.Text = data.LOC_NAME;
                txtStdLight.IntValue = data.STDLIGHT_ID;
                txtStdName.Text = data.STDLIGHT_NAME;
                txtStdValue.NullableIntValue = data.STDLIGHT_STANDARD;
                txtResultDay.NullableIntValue = data.RESULT_DAY;
                txtResultNight.NullableIntValue = data.RESULT_NIGHT;
                txtCondition.Text = data.CONDITION;

                CtrlUtil.EnableControls(txtStdValue.NullableIntValue.HasValue, txtStdName);
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        #endregion

        #region "Event"
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if(!this.ValidateData())
                {
                    return;
                }

                DataRow dr = this.result.Detail.NewRow();
                this.result.Detail.Rows.Add(dr);

                int rowIndex = this.gvDetail.RowCount - 1;

                sp_RPT001_GetWorkPlaceLightDt_Result data = GetDataFromControl();
                data.ID = 0;
                this.SetDataToRow(data, rowIndex);
                this.SetGridError();

                this.gvDetail.ScrollToRow(rowIndex);
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ValidateData())
                {
                    return;
                }

                DataRow dr = this.result.Detail.NewRow();
                int rowIndex = gvDetail.SelectedRowIndex;
                this.result.Detail.Rows.InsertAt(dr, rowIndex);

                sp_RPT001_GetWorkPlaceLightDt_Result data = GetDataFromControl();
                data.ID = 0;
                this.SetDataToRow(data, rowIndex);
                this.SetGridError();

                this.gvDetail.ScrollToRow(rowIndex);
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ValidateData())
                {
                    return;
                }

                int rowIndex = gvDetail.SelectedRowIndex;

                sp_RPT001_GetWorkPlaceLightDt_Result data = GetDataFromControl();
                this.SetDataToRow(data, rowIndex);
                this.SetGridError();
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.result.Detail.Rows.Count > 0 && gvDetail.SelectedRowIndex >= 0)
                {
                    this.result.Detail.Rows.RemoveAt(gvDetail.SelectedRowIndex);
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }

        private void txtStdLight_OnSelected(object sender, EventArgs e)
        {
            try
            {
                if (txtStdLight.IntValue != null)
                {
                    sp_MAS302_GetSTDLight_Result data = (txtStdLight.SelectedData as sp_MAS302_GetSTDLight_Result);
                    sp_MAS201_GetCustomer_Result cust = vmMas.GetCustomer(this.result.CUSTOMER_ID);
                    txtStdValue.NullableIntValue = data.STANDARD;
                    txtStdName.Text = data.ALIAS_NAME.GetValueOrDefault(data.NAME);
                    if (cust != null)
                    {
                        if (cust.IS_LANG_TH == true)
                        {
                            txtStdName.Text = data.ALIAS_NAME.GetValueOrDefault(data.NAME);
                        }
                        else
                        {
                            txtStdName.Text = data.ALIAS_NAME_EN.GetValueOrDefault(data.NAME);
                        }
                    }
                    CtrlUtil.EnableControls(true, txtStdName);
                }
                else
                {
                    txtStdValue.NullableIntValue = null;
                    txtStdName.Text = null;
                    CtrlUtil.EnableControls(false, txtStdName);
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void txtCondition_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F2:
                    using (HelpFillDataDialog dlg = new HelpFillDataDialog(eHelpType.LightCondition))
                    {
                        if (dlg.ShowDialog(this) == DialogResult.OK)
                        {
                            txtCondition.Text = dlg.SelectedText;
                        }
                    }
                    break;
            }
        }
        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool isError = (txtResultDay.NullableIntValue.HasValue && txtStdValue.NullableIntValue > txtResultDay.NullableIntValue) || (txtResultNight.NullableIntValue.HasValue && txtStdValue.NullableIntValue > txtResultNight.NullableIntValue);
                CtrlUtil.EnableControls(isError, txtCondition);
                if (!isError)
                {
                    txtCondition.Text = null;
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }

        private void gvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = gvDetail.SelectedRowIndex;
                sp_RPT001_GetWorkPlaceLightDt_Result data = this.GetDataFromRow(rowIndex);

                if (data != null)
                {
                    this.SetDataToControl(data);
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }

        private void lCondition_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtCondition.Enabled)
                {
                    using (HelpFillDataDialog dlg = new HelpFillDataDialog(eHelpType.LightCondition))
                    {
                        if (dlg.ShowDialog(this) == DialogResult.OK)
                        {
                            txtCondition.Text = dlg.SelectedText;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        #endregion
    }
}
