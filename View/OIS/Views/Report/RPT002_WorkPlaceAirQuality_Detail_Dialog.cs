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
    public partial class RPT002_WorkPlaceAirQuality_Detail_Dialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {
            LOC_NAME_LV3,
            LOC_NAME_LV2,
            LOC_NAME,
            PARAMETER_NAME,
            SAMPLING_DATE,
            SAMPLING_TIME,
            SAMPLING_MINS,
            AIR_FLOW,
            RESULT_VALUE,
            UNIT_NAME,
            STANDARD_THAI,
            STANDARD_ACGIH,
            CEILING_LIMIT,
            LESS_RESULT_VALUE,
            WAIT_RESULT,
            MRL_VALUE,
            REMARK,
            ID,
            WPA_ID,
            PARAMETER_ID,
            UNIT_ID,
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
        private RPT002_WorkPlaceAirDTO result;
        #endregion

        #region "Constructor"
        public RPT002_WorkPlaceAirQuality_Detail_Dialog(RPT002_WorkPlaceAirDTO data)
        {
            try
            {
                InitializeComponent();
                this.result = data;
                this.InitialScreen();
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
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

                gvDetail.SetColumnDate((int)eCol.SAMPLING_DATE);
                gvDetail.SetColumnTime((int)eCol.SAMPLING_TIME);
                gvDetail.SetColumnNumeric((int)eCol.SAMPLING_MINS);
                gvDetail.SetColumnNumeric((int)eCol.AIR_FLOW, 4);
                gvDetail.SetColumnNumeric((int)eCol.RESULT_VALUE, 3);
                gvDetail.SetColumnNumeric((int)eCol.STANDARD_THAI, 1);
                gvDetail.SetColumnNumeric((int)eCol.STANDARD_ACGIH, 1);
                gvDetail.SetColumnNumeric((int)eCol.MRL_VALUE, 5);
                
                gvDetail.Columns[(int)eCol.CEILING_LIMIT].Visible = false;

                gvDetail.Columns[(int)eCol.UNIT_NAME].ReadOnly = true;
                gvDetail.Columns[(int)eCol.MRL_VALUE].ReadOnly = true;

                for (int i = (int)eCol.ID; i <= (int)eCol.DEL_ID; i++)
                {
                    gvDetail.Columns[i].Visible = false;
                }

                cboUnit.SetDataSource(vmCombo.GetComboUnit(), false);

                CtrlUtil.EnableControls(false, txtStdThai, txtStdAcgih, txtMRL, cboUnit, chkC);

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
                    decimal? STANDARD_THAI = gvDetail.GetDecimalValueOrNull(r, (int)eCol.STANDARD_THAI);
                    decimal? STANDARD_ACGIH = gvDetail.GetDecimalValueOrNull(r, (int)eCol.STANDARD_ACGIH);
                    decimal RESULT_VALUE = gvDetail.GetDecimalValue(r, (int)eCol.RESULT_VALUE);

                    bool isError = (STANDARD_THAI.HasValue && RESULT_VALUE > STANDARD_THAI) || (STANDARD_ACGIH.HasValue && RESULT_VALUE > STANDARD_ACGIH);
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
                if (!dtSamplingDate.DateValue.HasValue)
                {
                    rMessageBox.ShowWarning(this, "Sampling Date ห้ามว่าง", MessageBoxButtons.OK);
                    dtSamplingDate.Focus();
                    return false;
                }
                if (!txtParameter.IntValue.HasValue)
                {
                    rMessageBox.ShowWarning(this, "Parameter ห้ามว่าง", MessageBoxButtons.OK);
                    txtParameter.Focus();
                    return false;
                }
                if (!dtSamplingTime.TimeValue.HasValue)
                {
                    rMessageBox.ShowWarning(this, "Sampling Time ห้ามว่าง", MessageBoxButtons.OK);
                    dtSamplingTime.Focus();
                    return false;
                }
                if (!txtSamplingMins.NullableIntValue.HasValue)
                {
                    rMessageBox.ShowWarning(this, "Sampling Minute ห้ามว่าง", MessageBoxButtons.OK);
                    txtSamplingMins.Focus();
                    return false;
                }
                if (!chkWaitResult.Checked && !txtResult.NullableDecimalValue.HasValue)
                {
                    rMessageBox.ShowWarning(this, "Result ห้ามว่าง", MessageBoxButtons.OK);
                    txtResult.Focus();
                    return false;
                }
                if (!chkWaitResult.Checked && txtMRL.NullableDecimalValue.HasValue && txtResult.NullableDecimalValue < txtMRL.NullableDecimalValue)
                {
                    rMessageBox.ShowWarning(this, "Result ต้องไม่น้อยกว่า MRL", MessageBoxButtons.OK);
                    txtResult.Focus();
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

        private sp_RPT002_GetWorkPlaceAirDt_Result GetDataFromRow(int rowIndex)
        {
            try
            {
                sp_RPT002_GetWorkPlaceAirDt_Result result = new sp_RPT002_GetWorkPlaceAirDt_Result()
                {
                    ID = gvDetail.GetIntValue(rowIndex, (int)eCol.ID),
                    WPA_ID = gvDetail.GetIntValue(rowIndex, (int)eCol.WPA_ID),
                    LOC_NAME = gvDetail.GetStringValue(rowIndex, (int)eCol.LOC_NAME),
                    LOC_NAME_LV2 = gvDetail.GetStringValue(rowIndex, (int)eCol.LOC_NAME_LV2),
                    LOC_NAME_LV3 = gvDetail.GetStringValue(rowIndex, (int)eCol.LOC_NAME_LV3),
                    SAMPLING_DATE = gvDetail.GetDateTimeValue(rowIndex, (int)eCol.SAMPLING_DATE),
                    PARAMETER_ID = gvDetail.GetIntValue(rowIndex, (int)eCol.PARAMETER_ID),
                    PARAMETER_NAME = gvDetail.GetStringValue(rowIndex, (int)eCol.PARAMETER_NAME),
                    SAMPLING_TIME = gvDetail.GetTimeValue(rowIndex, (int)eCol.SAMPLING_TIME),
                    SAMPLING_MINS = gvDetail.GetIntValue(rowIndex, (int)eCol.SAMPLING_MINS),
                    AIR_FLOW = gvDetail.GetDecimalValueOrNull(rowIndex, (int)eCol.AIR_FLOW),
                    AIR_VOLUME = null,
                    RESULT_VALUE = gvDetail.GetDecimalValue(rowIndex, (int)eCol.RESULT_VALUE),
                    LESS_RESULT_VALUE = gvDetail.GetBooleanValue(rowIndex, (int)eCol.LESS_RESULT_VALUE),
                    UNIT_ID = gvDetail.GetIntValue(rowIndex, (int)eCol.UNIT_ID),
                    STANDARD_THAI = gvDetail.GetDecimalValueOrNull(rowIndex, (int)eCol.STANDARD_THAI),
                    STANDARD_ACGIH = gvDetail.GetDecimalValueOrNull(rowIndex, (int)eCol.STANDARD_ACGIH),
                    CEILING_LIMIT = gvDetail.GetBooleanValue(rowIndex, (int)eCol.CEILING_LIMIT),
                    WAIT_RESULT = gvDetail.GetBooleanValue(rowIndex, (int)eCol.WAIT_RESULT),
                    REMARK = gvDetail.GetStringValue(rowIndex, (int)eCol.REMARK),
                    MRL_VALUE = gvDetail.GetDecimalValueOrNull(rowIndex, (int)eCol.MRL_VALUE),
                };

                return result;
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                return null;
            }
        }
        private sp_RPT002_GetWorkPlaceAirDt_Result GetDataFromControl()
        {
            try
            {
                sp_RPT002_GetWorkPlaceAirDt_Result result = new sp_RPT002_GetWorkPlaceAirDt_Result()
                {
                    WPA_ID = this.result.ID,
                    LOC_NAME = txtLocationName.TextValue,
                    LOC_NAME_LV2 = txtLocationLV2.TextValue,
                    LOC_NAME_LV3 = txtLocationLV3.TextValue,
                    SAMPLING_DATE = dtSamplingDate.DateValue.GetValueOrDefault(DateTime.Now.Date),
                    PARAMETER_ID = txtParameter.IntValue.GetValueOrDefault(),
                    PARAMETER_NAME = txtParameter.TextValue,
                    SAMPLING_TIME = dtSamplingTime.TimeValue.GetValueOrDefault(DateTime.Now.TimeOfDay),
                    SAMPLING_MINS = txtSamplingMins.NullableIntValue.GetValueOrDefault(),
                    AIR_FLOW = txtAirFlow.NullableDecimalValue,
                    AIR_VOLUME = null,
                    RESULT_VALUE = txtResult.NullableDecimalValue.GetValueOrDefault(),
                    LESS_RESULT_VALUE = chkLess.Checked,
                    UNIT_ID = cboUnit.NullableIntValue.GetValueOrDefault(),
                    UNIT_NAME = cboUnit.Text,
                    STANDARD_THAI = txtStdThai.NullableDecimalValue,
                    STANDARD_ACGIH = txtStdAcgih.NullableDecimalValue,
                    CEILING_LIMIT = chkC.Checked,
                    WAIT_RESULT = chkWaitResult.Checked,
                    REMARK = txtRemark.TextValue,
                    MRL_VALUE = txtMRL.NullableDecimalValue,
                };

                return result;
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                return null;
            }
        }

        private void SetDataToRow(sp_RPT002_GetWorkPlaceAirDt_Result data, int rowIndex)
        {
            try
            {
                DataGridViewRow dr = gvDetail.Rows[rowIndex];
                if (dr != null)
                {
                    dr.Cells[(int)eCol.ID].SetValue(data.ID);
                    dr.Cells[(int)eCol.LOC_NAME_LV3].SetValue(data.LOC_NAME_LV3);
                    dr.Cells[(int)eCol.LOC_NAME_LV2].SetValue(data.LOC_NAME_LV2);
                    dr.Cells[(int)eCol.LOC_NAME].SetValue(data.LOC_NAME);
                    dr.Cells[(int)eCol.SAMPLING_DATE].SetValue(data.SAMPLING_DATE);
                    dr.Cells[(int)eCol.PARAMETER_ID].SetValue(data.PARAMETER_ID);
                    dr.Cells[(int)eCol.PARAMETER_NAME].SetValue(data.PARAMETER_NAME);
                    dr.Cells[(int)eCol.SAMPLING_TIME].SetValue(data.SAMPLING_TIME);
                    dr.Cells[(int)eCol.SAMPLING_MINS].SetValue(data.SAMPLING_MINS);
                    dr.Cells[(int)eCol.AIR_FLOW].SetValue(data.AIR_FLOW);
                    dr.Cells[(int)eCol.RESULT_VALUE].SetValue(data.RESULT_VALUE);
                    dr.Cells[(int)eCol.LESS_RESULT_VALUE].SetValue(data.LESS_RESULT_VALUE);
                    dr.Cells[(int)eCol.UNIT_ID].SetValue(data.UNIT_ID);
                    dr.Cells[(int)eCol.UNIT_NAME].SetValue(data.UNIT_NAME);
                    dr.Cells[(int)eCol.STANDARD_THAI].SetValue(data.STANDARD_THAI);
                    dr.Cells[(int)eCol.STANDARD_ACGIH].SetValue(data.STANDARD_ACGIH);
                    dr.Cells[(int)eCol.CEILING_LIMIT].SetValue(data.CEILING_LIMIT);
                    dr.Cells[(int)eCol.WAIT_RESULT].SetValue(data.WAIT_RESULT);
                    dr.Cells[(int)eCol.REMARK].SetValue(data.REMARK);
                    dr.Cells[(int)eCol.MRL_VALUE].SetValue(data.MRL_VALUE);
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void SetDataToControl(sp_RPT002_GetWorkPlaceAirDt_Result data)
        {
            try
            {
                txtLocationLV3.Text = data.LOC_NAME_LV3;
                txtLocationLV2.Text = data.LOC_NAME_LV2;
                txtLocationName.Text = data.LOC_NAME;
                dtSamplingDate.DateValue = data.SAMPLING_DATE;
                txtParameter.IntValue = data.PARAMETER_ID;
                dtSamplingTime.TimeValue = data.SAMPLING_TIME;
                txtSamplingMins.NullableIntValue = data.SAMPLING_MINS;
                txtAirFlow.NullableDecimalValue = data.AIR_FLOW;
                txtResult.NullableDecimalValue = data.RESULT_VALUE;
                chkLess.Checked = data.LESS_RESULT_VALUE;
                cboUnit.NullableIntValue = data.UNIT_ID;
                txtStdThai.NullableDecimalValue = data.STANDARD_THAI;
                txtStdAcgih.NullableDecimalValue = data.STANDARD_ACGIH;
                chkC.Checked = data.CEILING_LIMIT;
                chkWaitResult.Checked = data.WAIT_RESULT;
                txtRemark.Text = data.REMARK;
                txtMRL.NullableDecimalValue = data.MRL_VALUE;
                
                if(txtParameter.IntValue.HasValue)
                {
                    sp_MAS305_GetParameterAnalysis_Result p = (txtParameter.SelectedData as sp_MAS305_GetParameterAnalysis_Result);
                    if (p.MRL_VALUE_DIV.HasValue && p.MRL_VALUE_DIV != txtMRL.NullableDecimalValue)
                    {
                        txtMRL.NullableDecimalValue = p.MRL_VALUE_DIV;
                    }
                }
            }
            catch(Exception ex)
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

                sp_RPT002_GetWorkPlaceAirDt_Result data = GetDataFromControl();
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

                sp_RPT002_GetWorkPlaceAirDt_Result data = GetDataFromControl();
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

                sp_RPT002_GetWorkPlaceAirDt_Result data = GetDataFromControl();
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

        private void txtParameter_OnSelected(object sender, EventArgs e)
        {
            try
            {
                if(txtParameter.IntValue.HasValue)
                {
                    sp_MAS305_GetParameterAnalysis_Result p = txtParameter.SelectedData as sp_MAS305_GetParameterAnalysis_Result;
                    if (p != null)
                    {
                        txtStdThai.NullableDecimalValue = p.STANDARD_THAI;
                        txtStdAcgih.NullableDecimalValue = p.STANDARD_ACGIH;
                        txtMRL.NullableDecimalValue = p.MRL_VALUE_DIV;
                        txtRemark.Text = p.LAB_REMARK;
                        cboUnit.NullableIntValue = p.UNIT_ID;
                        chkC.Checked = p.CEILING_LIMIT;
                    }
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }

        private void chkLess_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkLess.Checked)
                {
                    txtResult.NullableDecimalValue = txtMRL.NullableDecimalValue;
                }
                CtrlUtil.EnableControls(!chkLess.Checked, txtResult);
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }

        private void gvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = gvDetail.SelectedRowIndex;
                sp_RPT002_GetWorkPlaceAirDt_Result data = this.GetDataFromRow(rowIndex);

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
        #endregion
    }
}
