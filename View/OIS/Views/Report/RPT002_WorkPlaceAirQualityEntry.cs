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
    public partial class RPT002_WorkPlaceAirQualityEntry : rBaseDialog
    {
        #region "Enum"
        private enum eCol
        {
            LOC_NAME_LV3,
            LOC_NAME_LV2,
            LOC_NAME,
            LOC_BTN,
            PARAMETER_NAME,
            PARAMETER_BTN,
            SAMPLING_DATE,
            SAMPLING_TIME,
            SAMPLING_MINS,
            AIR_FLOW,
            AIR_VOLUME,
            RESULT_VALUE,
            UNIT_NAME,
            STANDARD_THAI,
            STANDARD_ACGIH,
            CEILING_LIMIT,
            LESS_RESULT_VALUE,
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
        private ReportViewModel vmRpt = new ReportViewModel();
        private ComboViewModel vmCombo = new ComboViewModel();
        private SystemViewModel vmSys = new SystemViewModel();
        private MasterViewModel vmMas = new MasterViewModel();

        private ScreenMode mode;

        private RPT002_WorkPlaceAirDTO wpaResult;
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
        public RPT002_WorkPlaceAirQualityEntry()
        {
            InitializeComponent();
            wpaResult = vmRpt.GetWorkPlaceAir(0);
            mode = ScreenMode.Add;
        }
        public RPT002_WorkPlaceAirQualityEntry(int ID, bool isCopy = false)
        {
            InitializeComponent();
            wpaResult = vmRpt.GetWorkPlaceAir(ID);
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
            try
            {
                this.tsbDDPrint2.Text = "สอ.๓";

                this.tsbDDPrint2.Visible = true;
                this.tsbDDPrint2_Preview.Visible = false;
                this.tsbDDPrint2_Print.Visible = false;
                this.tsbDDPrint2_PDF.Visible = false;
                this.tsbDDPrint2_Word.Visible = false;
                this.tsbDDPrint_Excel.Visible = true;

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<sp_RPT002_GetWorkPlaceAirDt_Result, sp_RPT002_GetWorkPlaceAirDt_Result>();
                });
                mapper = config.CreateMapper();

                SetControlToValidate(txtAnalysisNo, txtJobNo, txtCustomer, txtProject, dtReceivedDate, dtAnalyticalDate, dtAnalyticalDateTo, dtReportDate, txtRegistration, txtLabSupervisor);

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
                this.Cursor = Cursors.WaitCursor;

                systemConfigResult = vmSys.GetSystemConfig();

                if (mode == ScreenMode.Add)
                {
                    if (wpaResult == null)
                    {
                        wpaResult = new RPT002_WorkPlaceAirDTO();
                        wpaResult.IS_WA = true;
                        wpaResult.IS_AWA = false;
                        wpaResult.REPORT_DATE = DateTime.Now;
                        wpaResult.CRT_DATE = DateTime.Now;
                        wpaResult.REGISTRATION_ID = systemConfigResult.DEFAULT_REPORT_WPA_REGISTRATION_ID;
                        wpaResult.REGISTRATION_NAME = systemConfigResult.DEFAULT_REPORT_WPA_REGISTRATION_NAME;
                        wpaResult.LAB_SUPERVISOR_ID = systemConfigResult.DEFAULT_REPORT_WPA_LAB_SUPERVISOR_ID;
                        wpaResult.LAB_SUPERVISOR_NAME = systemConfigResult.DEFAULT_REPORT_WPA_LAB_SUPERVISOR_NAME;
                        wpaResult.AGENT_FLAG = true;
                        wpaResult.SHOW_LV3_EACH_PAGE = true;
                        wpaResult.SHOW_LV3_CONT = true;
                        wpaResult.SHOW_LV2_CONT = false;
                        this.ToolBarSwitch = "2122222222";
                    }
                    else
                    {
                        wpaResult.ID = 0;
                        wpaResult.IS_WA = true;
                        wpaResult.IS_AWA = false;
                        wpaResult.ANALYSYS_NO = null;
                        wpaResult.JOB_NO = null;
                        wpaResult.CRT_ID = null;
                        wpaResult.CRT_DATE = DateTime.Now;
                        wpaResult.CRT_MACHINE = null;
                        wpaResult.CRT_NAME = null;
                        wpaResult.UPD_ID = null;
                        wpaResult.UPD_DATE = null;
                        wpaResult.UPD_MACHINE = null;
                        wpaResult.UPD_NAME = null;
                        wpaResult.DEL_ID = null;
                        wpaResult.DEL_DATE = null;
                        wpaResult.DEL_MACHINE = null;
                        wpaResult.DEL_NAME = null;
                        wpaResult.REGISTRATION_ID = systemConfigResult.DEFAULT_REPORT_WPA_REGISTRATION_ID;
                        wpaResult.REGISTRATION_NAME = systemConfigResult.DEFAULT_REPORT_WPA_REGISTRATION_NAME;
                        wpaResult.LAB_SUPERVISOR_ID = systemConfigResult.DEFAULT_REPORT_WPA_LAB_SUPERVISOR_ID;
                        wpaResult.LAB_SUPERVISOR_NAME = systemConfigResult.DEFAULT_REPORT_WPA_LAB_SUPERVISOR_NAME;
                        wpaResult.AGENT_FLAG = true;
                        wpaResult.AGENT_NAME = null;
                        wpaResult.SHOW_LV3_EACH_PAGE = true;
                        wpaResult.SHOW_LV3_CONT = true;
                        wpaResult.SHOW_LV2_CONT = false;
                        this.ToolBarSwitch = "2122222222";
                    }
                }
                else if (wpaResult.DEL_ID.IsNull())
                {
                    this.ToolBarSwitch = "2122112102";
                }
                else
                {
                    this.ToolBarSwitch = "2022002012";
                }


                CtrlUtil.EnableControls(!wpaResult.Is_Canceled, txtCustomer, txtCustomerAddr, txtProject, txtProjectAddr, dtReceivedDate, dtAnalyticalDate, dtAnalyticalDateTo, chkShowLv3EachPage, chkShowLv3Cont, chkShowLv2Cont);

                CtrlUtil.EnableControls(OISDataInfo.UserInfomation.GROUP_ID == 3 && !wpaResult.Is_Canceled, txtRegistration, txtLabSupervisor);

                this.SetDataToControl();
                
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
        private RPT002_WorkPlaceAirDTO GetDataFromControl()
        {
            try
            {
                DateTime now = DateTime.Now;
                this.wpaResult.REPORT_TYPE = (rdoWA.Checked? "WA":"AWA");
                this.wpaResult.ANALYSYS_NO = txtAnalysisNo.TextValue;
                this.wpaResult.JOB_NO = txtJobNo.TextValue;
                this.wpaResult.CUSTOMER_ID = txtCustomer.IntValue.GetValueOrDefault();
                this.wpaResult.CUSTOMER_ADDR = txtCustomerAddr.TextValue;
                this.wpaResult.CUSTOMER_PROJECT_ID = txtProject.IntValue;
                this.wpaResult.CUSTOMER_PROJECT_ADDR = txtProjectAddr.TextValue;
                this.wpaResult.RECEIVED_DATE = dtReceivedDate.DateValue;
                this.wpaResult.REPORT_DATE = dtReportDate.DateValue.GetValueOrDefault(now.Date);
                this.wpaResult.ANALYTICAL_DATE_FROM = dtAnalyticalDate.DateValue;
                this.wpaResult.ANALYTICAL_DATE_TO = dtAnalyticalDateTo.DateValue;
                this.wpaResult.AGENT_FLAG = rdoAgent1.Checked;
                this.wpaResult.AGENT_NAME = txtAgentName.TextValue;
                this.wpaResult.REGISTRATION_ID = txtRegistration.StringValue;
                this.wpaResult.LAB_SUPERVISOR_ID = txtLabSupervisor.StringValue;
                this.wpaResult.SHOW_LV3_EACH_PAGE = chkShowLv3EachPage.Checked;
                this.wpaResult.SHOW_LV3_CONT = chkShowLv3Cont.Checked;
                this.wpaResult.SHOW_LV2_CONT = chkShowLv2Cont.Checked;
                this.wpaResult.SHOW_PROJECT_ADDR = chkShowProjectAddr.Checked;

                return this.wpaResult;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void SetDataToControl()
        {
            try
            {
                if (this.wpaResult != null)
                {
                    rdoWA.Checked = this.wpaResult.REPORT_TYPE == "WA";
                    rdoAWA.Checked = this.wpaResult.REPORT_TYPE == "AWA";
                    txtAnalysisNo.Text = this.wpaResult.ANALYSYS_NO;
                    txtJobNo.Text = this.wpaResult.JOB_NO;
                    txtCustomer.IntValue = this.wpaResult.CUSTOMER_ID;
                    txtCustomerAddr.Text = this.wpaResult.CUSTOMER_ADDR;
                    txtProject.IntValue = this.wpaResult.CUSTOMER_PROJECT_ID;
                    txtProjectAddr.Text = this.wpaResult.CUSTOMER_PROJECT_ADDR;
                    dtReceivedDate.DateValue = this.wpaResult.RECEIVED_DATE;
                    dtReportDate.DateValue = this.wpaResult.REPORT_DATE;
                    dtAnalyticalDate.DateValue = this.wpaResult.ANALYTICAL_DATE_FROM;
                    dtAnalyticalDateTo.DateValue = this.wpaResult.ANALYTICAL_DATE_TO;
                    rdoAgent1.Checked = this.wpaResult.AGENT_FLAG;
                    rdoAgent2.Checked = !this.wpaResult.AGENT_FLAG;
                    txtAgentName.Text = this.wpaResult.AGENT_NAME;
                    txtRegistration.StringValue = this.wpaResult.REGISTRATION_ID;
                    txtLabSupervisor.StringValue = this.wpaResult.LAB_SUPERVISOR_ID;
                    chkShowLv3EachPage.Checked = this.wpaResult.SHOW_LV3_EACH_PAGE;
                    chkShowLv3Cont.Checked = this.wpaResult.SHOW_LV3_CONT;
                    chkShowLv2Cont.Checked = this.wpaResult.SHOW_LV2_CONT;
                    chkShowProjectAddr.Checked = this.wpaResult.SHOW_PROJECT_ADDR;

                    txtCrtId.Text = this.wpaResult.CRT_NAME;
                    txtCrtMachine.Text = this.wpaResult.CRT_MACHINE;
                    dtCrt.DateValue = this.wpaResult.CRT_DATE;
                    txtUpdId.Text = this.wpaResult.UPD_NAME;
                    txtUpdMachine.Text = this.wpaResult.UPD_MACHINE;
                    dtUpd.DateValue = this.wpaResult.UPD_DATE;
                    txtDelId.Text = this.wpaResult.DEL_NAME;
                    txtDelMachine.Text = this.wpaResult.DEL_MACHINE;
                    dtDel.DateValue = this.wpaResult.DEL_DATE;
                }
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
                gbHeader.Focus();
                this.GetDataFromControl();

                if (rdoWA.Checked)
                {
                    this.wpaResult.REPORT_TYPE = rdoWA.Text;
                }
                else if(rdoAWA.Checked)
                {
                    this.wpaResult.REPORT_TYPE = rdoAWA.Text;
                }
                else
                {
                    rMessageBox.ShowWarning(this, "กรุณาเลือกประเภท Analysis No.");
                    return false;
                }

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
        private void SaveData(bool showConfirmMsg = true)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (ValidateBeforeSave())
                {
                    if (!showConfirmMsg || rMessageBox.ShowConfirmation(this, MessageCode.CFM0001) == DialogResult.Yes)
                    {
                        int ID = vmRpt.SaveWorkPlaceAir(wpaResult);
                        rMessageBox.ShowInfomation(this, MessageCode.INF0002);
                        this.IsDataChange = true;
                        wpaResult = vmRpt.GetWorkPlaceAir(ID);
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
                    vmRpt.CancelWorkPlaceAir(wpaResult, isCancel);
                    if (isCancel)
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0004);
                    }
                    else
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0005);
                    }
                    this.IsDataChange = true;
                    wpaResult = vmRpt.GetWorkPlaceAir(wpaResult.ID);
                    RetriveData();
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }

        private void PrintReport(bool isPrint, ExportFormatType exportFormat = ExportFormatType.NoFormat)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                using (RPT002_Process rpt = new RPT002_Process(this.wpaResult.ID))
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
        #endregion
        
        #region "Event"
        private void RPT002_WorkPlaceAirQualityEntry_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void RPT002_WorkPlaceAirQualityEntry_OnSave(object sender, EventArgs e)
        {
            SaveData();
        }

        private void RPT002_WorkPlaceAirQualityEntry_OnDDPrint_Preview(object sender, EventArgs e)
        {
            PrintReport(false);
        }
        private void RPT002_WorkPlaceAirQualityEntry_OnDDPrint_Print(object sender, EventArgs e)
        {
            PrintReport(true);
        }
        private void RPT002_WorkPlaceAirQualityEntry_OnDDPrint_PDF(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.PortableDocFormat);
        }
        private void RPT002_WorkPlaceAirQualityEntry_OnDDPrint_Word(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.WordForWindows);
        }
        private void RPT002_WorkPlaceAirQualityEntry_OnDDPrint_Excel(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.Excel);
        }

        private void RPT002_WorkPlaceAirQualityEntry_OnDDPrint2_Excel(object sender, EventArgs e)
        {
            try
            {
                using (RPT002_2_Process rpt = new RPT002_2_Process(this.wpaResult.ID))
                {
                    
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }

        private void RPT002_WorkPlaceAirQualityEntry_OnCancel(object sender, EventArgs e)
        {
            CancelData(true);
        }

        private void RPT002_WorkPlaceAirQualityEntry_OnRecovery(object sender, EventArgs e)
        {
            CancelData(false);
        }

        private void RPT002_WorkPlaceAirQualityEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bool detailChanged = this.wpaResult.Detail.IsModified();
                bool userChanged = this.wpaResult.User.IsModified();
                if (detailChanged || userChanged)
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

        private void btnDetail_Click(object sender, EventArgs e)
        {
            bdSource.EndEdit();
            using (RPT002_WorkPlaceAirQuality_Detail_Dialog dlg = new RPT002_WorkPlaceAirQuality_Detail_Dialog(this.wpaResult))
            {
                dlg.ShowDialog(this);
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            using (RPT002_WorkPlaceAirQuality_User_Dialog dlg = new RPT002_WorkPlaceAirQuality_User_Dialog(this.wpaResult.User))
            {
                dlg.ShowDialog(this);
            }
        }
        #endregion
    }
}
