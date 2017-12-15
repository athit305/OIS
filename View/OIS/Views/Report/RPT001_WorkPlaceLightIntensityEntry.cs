using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
using OIS.RPT.DTO;
using OIS.Views.Dialogs;
using OIS.Views.Reports;
using OIS.ViewModel;
using OIS.SYS.DTO;
using CrystalDecisions.Shared;
using AutoMapper;
using OIS.Views.Report;

namespace OIS.Views
{
    public partial class RPT001_WorkPlaceLightIntensityEntry : rBaseDialog
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
        private ReportViewModel vmRpt = new ReportViewModel();
        private ComboViewModel vmCombo = new ComboViewModel();
        private SystemViewModel vmSys = new SystemViewModel();
        private MasterViewModel vmMas = new MasterViewModel();

        private ScreenMode mode;

        private RPT001_WorkPlaceLightDTO wplResult;
        private sp_SYS001_GetSystemConfig_Result systemConfigResult;

        IMapper mapper;

        private class TotalSummary
        {
            public int PassD { get; set; }
            public int PassN { get; set; }
            public int NotPassD { get; set; }
            public int NotPassN { get; set; }
        }
        #endregion

        #region "Constructor"
        public RPT001_WorkPlaceLightIntensityEntry()
        {
            InitializeComponent();
            wplResult = vmRpt.GetWorkPlaceLight(0);
            mode = ScreenMode.Add;
        }
        public RPT001_WorkPlaceLightIntensityEntry(int ID, bool isCopy = false)
        {
            InitializeComponent();
            wplResult = vmRpt.GetWorkPlaceLight(ID);
            if (isCopy)
            {
                mode = ScreenMode.Add;
            }
            else
            {
                mode = ScreenMode.Edit;
            }
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<sp_RPT001_GetWorkPlaceLightDt_Result, sp_RPT001_GetWorkPlaceLightDt_Result>();
            });
            mapper = config.CreateMapper();

            cboReportCode.SetDataSource(vmCombo.GetComboReportCode(ReportType.WPLIGHT));

            SetControlToValidate(cboReportCode, txtCustomer, txtProject, dtMeasuredDate, dtMeasuredDateTo, dtTimeFrom, dtTimeTo, dtMeasuredDateNight, dtMeasuredDateNightTo, dtTimeFromNight, dtTimeToNight, txtRegistration, txtLabSupervisor);

            RetriveData();
        }
        private void RetriveData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                systemConfigResult = vmSys.GetSystemConfig();

                if (mode == ScreenMode.Add)
                {
                    if (wplResult == null)
                    {
                        wplResult = new RPT001_WorkPlaceLightDTO();
                        wplResult.CRT_DATE = DateTime.Now;
                        wplResult.REGISTRATION_ID = systemConfigResult.DEFAULT_REPORT_REGISTRATION_ID;
                        wplResult.REGISTRATION_NAME = systemConfigResult.DEFAULT_REPORT_REGISTRATION_NAME;
                        wplResult.LAB_SUPERVISOR_ID = systemConfigResult.DEFAULT_REPORT_LAB_SUPERVISOR_ID;
                        wplResult.LAB_SUPERVISOR_NAME = systemConfigResult.DEFAULT_REPORT_LAB_SUPERVISOR_NAME;
                        this.ToolBarSwitch = "2122222222";
                        CtrlUtil.EnableControls(true, cboReportCode);
                    }
                    else
                    {
                        wplResult.ID = 0;
                        wplResult.REPORTNUMBER = null;
                        wplResult.REPORT_CODE = null;
                        wplResult.CRT_ID = null;
                        wplResult.CRT_DATE = DateTime.Now;
                        wplResult.CRT_MACHINE = null;
                        wplResult.CRT_NAME = null;
                        wplResult.UPD_ID = null;
                        wplResult.UPD_DATE = null;
                        wplResult.UPD_MACHINE = null;
                        wplResult.UPD_NAME = null;
                        wplResult.DEL_ID = null;
                        wplResult.DEL_DATE = null;
                        wplResult.DEL_MACHINE = null;
                        wplResult.DEL_NAME = null;
                        wplResult.REGISTRATION_ID = systemConfigResult.DEFAULT_REPORT_REGISTRATION_ID;
                        wplResult.REGISTRATION_NAME = systemConfigResult.DEFAULT_REPORT_REGISTRATION_NAME;
                        wplResult.LAB_SUPERVISOR_ID = systemConfigResult.DEFAULT_REPORT_LAB_SUPERVISOR_ID;
                        wplResult.LAB_SUPERVISOR_NAME = systemConfigResult.DEFAULT_REPORT_LAB_SUPERVISOR_NAME;
                        this.ToolBarSwitch = "2122222222";
                        CtrlUtil.EnableControls(true, cboReportCode);
                    }
                }
                else if (wplResult.DEL_ID.IsNull())
                {
                    this.ToolBarSwitch = "2122122102";
                    CtrlUtil.EnableControls(false, cboReportCode);
                }
                else
                {
                    this.ToolBarSwitch = "2022022012";
                    CtrlUtil.EnableControls(false, cboReportCode);
                }


                CtrlUtil.EnableControls(!wplResult.Is_Canceled, txtCustomer, txtCustomerAddr, txtProject, txtProjectAddr, dtMeasuredDate, dtMeasuredDateTo, dtTimeFrom, dtTimeTo, dtMeasuredDateNight, dtMeasuredDateNightTo, dtTimeFromNight, dtTimeToNight, btnUpdateCustomer, btnUpdateProject, chkShowLv3EachPage, chkShowLv3Cont, chkShowLv2Cont);

                CtrlUtil.EnableControls(OISDataInfo.UserInfomation.GROUP_ID == 3 && !wplResult.Is_Canceled, txtRegistration, txtLabSupervisor);

                //bs.DataSource = wplResult;
                BindData();
                ApplySummary();
                
                dtMeasuredDate_DateChange(null, null);
                dtMeasuredDateNight_DateChange(null, null);
                this.wplResult.Detail.AcceptChanges();
                this.wplResult.User.AcceptChanges();
                this.wplResult.Instrument.AcceptChanges();
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
        private bool ValidateBeforeSave()
        {

            try
            {
                gbHeader.Focus();
                GetData();

                if (!ValidateControl())
                {
                    return false;
                }

                if (dtMeasuredDateNight.DateValue.HasValue && (!dtTimeFromNight.TimeValue.HasValue || !dtTimeToNight.TimeValue.HasValue))
                {
                    rMessageBox.ShowWarning(this, "Measured Time (Night) ห้ามว่าง");
                    return false;
                }

                if (!ValidateGV(true))
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
        private void BindData()
        {
            try
            {
                txtReportNumber.TextValue = wplResult.REPORTNUMBER;
                cboReportCode.StringValue = wplResult.REPORT_CODE;
                txtCustomerAddr.TextValue = wplResult.CUSTOMER_ADDR;
                txtCustomer.TextValue = wplResult.CUSTOMER_NAME;
                txtCustomer.IntValue = wplResult.CUSTOMER_ID;
                txtProjectAddr.TextValue = wplResult.CUSTOMER_PROJECT_ADDR;
                txtProject.TextValue = wplResult.CUSTOMER_PROJECT_NAME;
                txtProject.IntValue = wplResult.CUSTOMER_PROJECT_ID;
                dtMeasuredDate.DateValue = wplResult.MEASURED_DATE;
                dtMeasuredDateTo.DateValue = wplResult.MEASURED_DATE_TO;
                dtTimeFrom.TimeValue = wplResult.MEASURED_TIME_FROM;
                dtTimeTo.TimeValue = wplResult.MEASURED_TIME_TO;
                dtMeasuredDateNight.DateValue = wplResult.MEASURED_DATE_NIGHT;
                dtMeasuredDateNightTo.DateValue = wplResult.MEASURED_DATE_NIGHT_TO;
                dtTimeFromNight.TimeValue = wplResult.MEASURED_TIME_FROM_NIGHT;
                dtTimeToNight.TimeValue = wplResult.MEASURED_TIME_TO_NIGHT;
                txtRegistration.TextValue = wplResult.REGISTRATION_NAME;
                txtRegistration.StringValue = wplResult.REGISTRATION_ID;
                txtLabSupervisor.TextValue = wplResult.LAB_SUPERVISOR_NAME;
                txtLabSupervisor.StringValue = wplResult.LAB_SUPERVISOR_ID;
                chkShowLv3EachPage.Checked = wplResult.SHOW_LV3_EACH_PAGE;
                chkShowLv3Cont.Checked = wplResult.SHOW_LV3_CONT;
                chkShowLv2Cont.Checked = wplResult.SHOW_LV2_CONT;
                chkShowProjectAddr.Checked = wplResult.SHOW_PROJECT_ADDR;

                txtCrtId.Text = wplResult.CRT_NAME;
                txtCrtMachine.Text = wplResult.CRT_MACHINE;
                dtCrt.DateValue = wplResult.CRT_DATE;
                txtUpdId.Text = wplResult.UPD_NAME;
                txtUpdMachine.Text = wplResult.UPD_MACHINE;
                dtUpd.DateValue = wplResult.UPD_DATE;
                txtDelId.Text = wplResult.DEL_NAME;
                txtDelMachine.Text = wplResult.DEL_MACHINE;
                dtDel.DateValue = wplResult.DEL_DATE;
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private RPT001_WorkPlaceLightDTO GetData()
        {
            try
            {
                wplResult.REPORTNUMBER = txtReportNumber.TextValue;
                wplResult.REPORT_CODE = cboReportCode.StringValue;
                wplResult.CUSTOMER_ID = txtCustomer.IntValue.GetValueOrDefault();
                wplResult.CUSTOMER_NAME = txtCustomer.TextValue;
                wplResult.CUSTOMER_ADDR = txtCustomerAddr.TextValue;
                wplResult.CUSTOMER_PROJECT_ID = txtProject.IntValue;
                wplResult.CUSTOMER_PROJECT_NAME = txtProject.TextValue;
                wplResult.CUSTOMER_PROJECT_ADDR = txtProjectAddr.TextValue;
                wplResult.MEASURED_DATE = dtMeasuredDate.DateValue;
                wplResult.MEASURED_DATE_TO = dtMeasuredDateTo.DateValue;
                wplResult.MEASURED_TIME_FROM = dtTimeFrom.TimeValue;
                wplResult.MEASURED_TIME_TO = dtTimeTo.TimeValue;
                wplResult.MEASURED_DATE_NIGHT = dtMeasuredDateNight.DateValue;
                wplResult.MEASURED_DATE_NIGHT_TO = dtMeasuredDateNightTo.DateValue;
                wplResult.MEASURED_TIME_FROM_NIGHT = dtTimeFromNight.TimeValue;
                wplResult.MEASURED_TIME_TO_NIGHT = dtTimeToNight.TimeValue;
                wplResult.REGISTRATION_ID = txtRegistration.StringValue;
                wplResult.REGISTRATION_NAME = txtRegistration.TextValue;
                wplResult.LAB_SUPERVISOR_ID = txtLabSupervisor.StringValue;
                wplResult.LAB_SUPERVISOR_NAME = txtLabSupervisor.TextValue;
                wplResult.SHOW_LV3_EACH_PAGE = chkShowLv3EachPage.Checked;
                wplResult.SHOW_LV3_CONT = chkShowLv3Cont.Checked;
                wplResult.SHOW_LV2_CONT = chkShowLv2Cont.Checked;
                wplResult.SHOW_PROJECT_ADDR = chkShowProjectAddr.Checked;

                return wplResult;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void SaveData(bool showConfirmMsg = true)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (ValidateBeforeSave())
                {
                    if (!showConfirmMsg || rMessageBox.ShowConfirmation(this, MessageCode.CFM0001) == DialogResult.Yes)
                    {
                        int ID = vmRpt.SaveWorkPlaceLight(wplResult);
                        rMessageBox.ShowInfomation(this, MessageCode.INF0002);
                        this.IsDataChange = true;
                        wplResult = vmRpt.GetWorkPlaceLight(ID);
                        mode = ScreenMode.Edit;
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
                    vmRpt.CancelWorkPlaceLight(wplResult, isCancel);
                    if (isCancel)
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0004);
                    }
                    else
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0005);
                    }
                    this.IsDataChange = true;
                    wplResult = vmRpt.GetWorkPlaceLight(wplResult.ID);
                    RetriveData();
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private bool ValidateGV(bool showMsg = false)
        {
            try
            {
                //ApplySummary();
                //if (gvDetail.RowCount > 0)
                //{
                //    bool hasResultNight = false;
                //    bool hasResultDay = false;
                //    int i = 1;
                //    foreach (DataGridViewRow row in gvDetail.Rows)
                //    {
                //        sp_RPT001_GetWorkPlaceLightDt_Result data = row.DataBoundItem as sp_RPT001_GetWorkPlaceLightDt_Result;

                //        data.SEQ = i;
                //        i++;

                //        bool isError = (data.RESULT_DAY.HasValue && data.STDLIGHT_STANDARD > data.RESULT_DAY) || (data.RESULT_NIGHT.HasValue && data.STDLIGHT_STANDARD > data.RESULT_NIGHT);
                //        gvDetail.SetRowDeletedStyle(row.Index, isError);
                //        gvDetail.Rows[row.Index].Cells[(int)eCol.CONDITION].ReadOnly = !isError;
                //        if(!isError)
                //        {
                //            gvDetail.Rows[row.Index].Cells[(int)eCol.CONDITION].Value = null;
                //        }

                //        if (showMsg)
                //        {
                //            if (data.LOC_NAME.IsNull())
                //            {
                //                rMessageBox.ShowWarning(this, "Measured Location ห้ามว่าง", MessageBoxButtons.OK);
                //                gvDetail.CurrentCell = gvDetail.Rows[row.Index].Cells[(int)eCol.LOC_NAME];
                //                return false;
                //            }

                //            if (isError && data.CONDITION.IsNull())
                //            {
                //                rMessageBox.ShowWarning(this, "Condition ห้ามว่าง", MessageBoxButtons.OK);
                //                gvDetail.CurrentCell = gvDetail.Rows[row.Index].Cells[(int)eCol.CONDITION];
                //                return false;
                //            }
                //            if(data.RESULT_DAY.HasValue)
                //            {
                //                hasResultDay = true;
                //            }
                //            if(data.RESULT_NIGHT.HasValue)
                //            {
                //                hasResultNight = true;
                //            }
                //        }
                //    }
                //    if (showMsg && dtMeasuredDateNight.DateValue.HasValue && !hasResultNight)
                //    {
                //        rMessageBox.ShowWarning(this, "Result (Night) ห้ามว่าง", MessageBoxButtons.OK);
                //        return false;
                //    }
                //    if (showMsg && dtMeasuredDate.DateValue.HasValue && !hasResultDay)
                //    {
                //        rMessageBox.ShowWarning(this, "Result ห้ามว่าง", MessageBoxButtons.OK);
                //        return false;
                //    }
                //}
                return true;
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                return false;
            }
        }

        private void PrintReport(bool isPrint, ExportFormatType exportFormat = ExportFormatType.NoFormat)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (RPT001_Process rpt = new RPT001_Process(this.wplResult.ID))
                {
                    if (isPrint)
                    {
                        rpt.PrintReport();
                    }
                    else if (!isPrint && exportFormat == ExportFormatType.NoFormat)
                    {
                        rpt.PreviewDialog();
                    }
                    else if (exportFormat == ExportFormatType.Excel)
                    {
                        rpt.ExportExcelSpecial();
                    }
                    else if (!isPrint)
                    {
                        rpt.Export(exportFormat);
                    }
                    else
                    {
                        rpt.PrintReport();
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

        private void ApplySummary()
        {
            try
            {
                TotalSummary total = new TotalSummary();

                if (this.wplResult.Detail.Rows.Count > 0)
                {
                    foreach (DataRow row in this.wplResult.Detail.Rows)
                    {
                        sp_RPT001_GetWorkPlaceLightDt_Result data = new sp_RPT001_GetWorkPlaceLightDt_Result()
                        {
                            RESULT_DAY = row.Field<int?>("RESULT_DAY"),
                            RESULT_NIGHT = row.Field<int?>("RESULT_NIGHT"),
                            STDLIGHT_STANDARD = row.Field<int>("STDLIGHT_STANDARD"),
                        };

                        if(data.RESULT_DAY.HasValue && data.RESULT_DAY >= data.STDLIGHT_STANDARD)
                        {
                            total.PassD++;
                        }
                        else if (data.RESULT_DAY.HasValue && data.RESULT_DAY < data.STDLIGHT_STANDARD)
                        {
                            total.NotPassD++;
                        }
                        if(data.RESULT_NIGHT.HasValue && data.RESULT_NIGHT >= data.STDLIGHT_STANDARD)
                        {
                            total.PassN++;
                        }
                        else if (data.RESULT_NIGHT.HasValue && data.RESULT_NIGHT < data.STDLIGHT_STANDARD)
                        {
                            total.NotPassN++;
                        }
                    }
                }

                lblPassD.Text = total.PassD.ToString();
                lblPassN.Text = total.PassN.ToString();
                lblNoPassD.Text = total.NotPassD.ToString();
                lblNoPassN.Text = total.NotPassN.ToString();

                lblTotalD.Text = (total.PassD + total.NotPassD).ToString();
                lblTotalN.Text = (total.PassN + total.NotPassN).ToString();

                lblTotalPass.Text = (total.PassD + total.PassN).ToString();
                lblTotalNotPass.Text = (total.NotPassD + total.NotPassN).ToString();

                lblTotalAll.Text = (total.PassD + total.PassN + total.NotPassD + total.NotPassN).ToString();
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        #endregion

        #region "Event"
        private void RPT001_WorkPlaceLightIntensityEntry_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void RPT001_WorkPlaceLightIntensityEntry_OnSave(object sender, EventArgs e)
        {
            SaveData();
        }

        private void RPT001_WorkPlaceLightIntensityEntry_OnDDPrint_Preview(object sender, EventArgs e)
        {
            PrintReport(false);
        }
        private void RPT001_WorkPlaceLightIntensityEntry_OnDDPrint_Print(object sender, EventArgs e)
        {
            PrintReport(true);
        }
        private void RPT001_WorkPlaceLightIntensityEntry_OnDDPrint_PDF(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.PortableDocFormat);
        }
        private void RPT001_WorkPlaceLightIntensityEntry_OnDDPrint_Word(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.WordForWindows);
        }
        private void RPT001_WorkPlaceLightIntensityEntry_OnDDPrint_Excel(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.Excel);
        }

        private void RPT001_WorkPlaceLightIntensityEntry_OnCancel(object sender, EventArgs e)
        {
            CancelData(true);
        }

        private void RPT001_WorkPlaceLightIntensityEntry_OnRecovery(object sender, EventArgs e)
        {
            CancelData(false);
        }

        private void RPT001_WorkPlaceLightIntensityEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bool detailChanged = this.wplResult.Detail.IsModified();
                bool userChanged = this.wplResult.User.IsModified();
                bool insChanged = this.wplResult.Instrument.IsModified();
                if (detailChanged || userChanged || insChanged)
                {
                    DialogResult dr = rMessageBox.ShowConfirmation(this, "ข้อมูลมีการเปลี่ยนแปลง ต้องการบันทึกหรือไม่?", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes)
                    {
                        e.Cancel = true;
                        this.SaveData(false);
                    }
                    else if (dr == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                e.Cancel = true;
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCustomer.IntValue > 0)
                {
                    sp_MAS201_GetCustomer_Result result = vmMas.GetCustomer(txtCustomer.IntValue.GetValueOrDefault());
                    txtCustomerAddr.Text = result.ADDR;
                    txtCustomer.Text = result.NAME;
                    txtCustomer.IntValue = result.ID;
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtProject.IntValue > 0)
                {
                    sp_MAS202_GetCustomerProject_Result result = vmMas.GetCustomerProject(txtProject.IntValue.GetValueOrDefault());
                    txtProjectAddr.Text = result.ADDR;
                    txtProject.Text = result.NAME;
                    txtProject.IntValue = result.ID;
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }

        private void dtMeasuredDate_DateChange(object sender, EventArgs e)
        {
            CtrlUtil.EnableControls(dtMeasuredDate.DateValue.HasValue, dtTimeFrom, dtTimeTo);
            if (!dtMeasuredDate.DateValue.HasValue)
            {
                dtTimeFrom.TimeValue = dtTimeTo.TimeValue = null;
                if (wplResult != null && wplResult.Detail != null)
                {
                    foreach (DataRow dr in wplResult.Detail.Rows)
                    {
                        dr.SetValue("RESULT_DAY", null);
                    }
                }
            }
        }

        private void dtMeasuredDateNight_DateChange(object sender, EventArgs e)
        {
            CtrlUtil.EnableControls(dtMeasuredDateNight.DateValue.HasValue, dtTimeFromNight, dtTimeToNight);
            if (!dtMeasuredDateNight.DateValue.HasValue)
            {
                dtTimeFromNight.TimeValue = dtTimeToNight.TimeValue = null;
                if (wplResult != null && wplResult.Detail != null)
                {
                    foreach (DataRow dr in wplResult.Detail.Rows)
                    {
                        dr.SetValue("RESULT_NIGHT", null);
                    }
                }
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            this.GetData();
            using (RPT001_WorkPlaceLightIntensity_Detail_Dialog dlg = new RPT001_WorkPlaceLightIntensity_Detail_Dialog(this.wplResult))
            {
                dlg.ShowDialog(this);
                this.ApplySummary();
            }
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            using (RPT001_WorkPlaceLightIntensity_User_Dialog dlg = new RPT001_WorkPlaceLightIntensity_User_Dialog(this.wplResult.User))
            {
                dlg.ShowDialog(this);
            }
        }
        private void btnInstrument_Click(object sender, EventArgs e)
        {
            using (RPT001_WorkPlaceLightIntensity_Instrument_Dialog dlg = new RPT001_WorkPlaceLightIntensity_Instrument_Dialog(this.wplResult.Instrument))
            {
                dlg.ShowDialog(this);
            }
        }
        #endregion
    }
}
