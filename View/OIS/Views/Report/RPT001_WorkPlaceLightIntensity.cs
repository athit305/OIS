using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.BaseViews;
using OIS.Definition;
using OIS.Common;
using OIS.Common.Extensions;
using OIS.RPT.DTO;
using OIS.RPT.DTO.Criteria;
using OIS.ViewModel;
using OIS.Views.Reports;
using CrystalDecisions.Shared;

namespace OIS.Views
{
    public partial class RPT001_WorkPlaceLightIntensity : rBaseUC
    {
        #region "Enum"
        private enum eCol
        {
            REPORTNUMBER,
            CUSTOMER_NAME,
            CUSTOMER_PROJECT_NAME,
            MEASURED_DATE_LIST,
            MEASURED_NAME,
            INS_NAME,
            CRT_NAME,
            CRT_DATE,
            CRT_MACHINE,
            UPD_NAME,
            UPD_DATE,
            UPD_MACHINE,
            DEL_NAME,
            DEL_DATE,
            DEL_MACHINE,
            ID,
            CRT_ID,
            UPD_ID,
            DEL_ID,
        }
        #endregion

        #region "Variable"
        ReportViewModel vmRpt = new ReportViewModel();
        SearchViewModel vmSearch = new SearchViewModel();

        RPT001_WorkPlaceLight_Criteria criteria;
        SortableBindingList<sp_RPT001_GetWorkPlaceLight_Result> wlpList;
        #endregion

        #region "Constructor"
        public RPT001_WorkPlaceLightIntensity()
        {
            InitializeComponent();
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            try
            {
                this.ToolBarSwitch = "1212021221";

                gvResult.SetOISStyle();
                gvResult.MappingEnum(typeof(eCol));

                gvResult.SetColumnDate((int)eCol.MEASURED_DATE_LIST);
                gvResult.SetColumnDateTime((int)eCol.CRT_DATE);
                gvResult.SetColumnDateTime((int)eCol.UPD_DATE);
                gvResult.SetColumnDateTime((int)eCol.DEL_DATE);

                for (int i = (int)eCol.ID; i <= (int)eCol.DEL_ID; i++)
                {
                    gvResult.Columns[i].Visible = false;
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void LoadData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                criteria = new RPT001_WorkPlaceLight_Criteria()
                {
                    REPORTNUMBER = txtReportNumber.TextValue,
                    DATE_FROM = dtMeasuredDate.DateValue,
                    DATE_TO = dtMeasuredDateTo.DateValue,
                    CUSTOMER_ID = txtCustomer.IntValue,
                    MEASURED_BY = txtMeasuredBy.StringValue,
                    INSTRUMENT_ID = txtInstrument.IntValue,
                    SHOW_DELETE_RECORD = chkShowDeleteRecord.Checked,
                };
                wlpList = vmRpt.GetWorkPlaceLight(criteria);
                gvResult.DataSource = wlpList;

                gvResult.SetRowDeletedStyle((int)eCol.DEL_ID);

                if(gvResult.RowCount > 0)
                {
                    this.ToolBarSwitch = "1212121221";
                }
                else
                {
                    this.ToolBarSwitch = "1212021221";
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
        private void AddNew()
        {
            try
            {
                using (RPT001_WorkPlaceLightIntensityEntry dlg = new RPT001_WorkPlaceLightIntensityEntry())
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void EditData(DataGridViewCellEventArgs e)
        {
            try
            {
                if (e != null && e.RowIndex >= 0)
                {
                    sp_RPT001_GetWorkPlaceLight_Result row = gvResult.Rows[e.RowIndex].DataBoundItem as sp_RPT001_GetWorkPlaceLight_Result;
                    using (RPT001_WorkPlaceLightIntensityEntry dlg = new RPT001_WorkPlaceLightIntensityEntry(row.ID))
                    {
                        if (dlg.ShowDialog(this) == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                }
                else if (gvResult.SelectedRows != null && gvResult.SelectedRows.Count > 0)
                {
                    sp_RPT001_GetWorkPlaceLight_Result row = gvResult.SelectedRows[0].DataBoundItem as sp_RPT001_GetWorkPlaceLight_Result;
                    using (RPT001_WorkPlaceLightIntensityEntry dlg = new RPT001_WorkPlaceLightIntensityEntry(row.ID, true))
                    {
                        if (dlg.ShowDialog(this) == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void ClearScreen()
        {
            ClearControls(txtReportNumber, dtMeasuredDate, dtMeasuredDateTo, txtCustomer, txtMeasuredBy, txtInstrument, gvResult, chkShowDeleteRecord);
            this.ToolBarSwitch = "1212021221";
        }

        private void PrintReport(bool isPrint, ExportFormatType exportFormat = ExportFormatType.NoFormat)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (gvResult.CurrentRow.Index >= 0)
                {
                    sp_RPT001_GetWorkPlaceLight_Result row = gvResult.Rows[gvResult.CurrentRow.Index].DataBoundItem as sp_RPT001_GetWorkPlaceLight_Result;
                    using (RPT001_Process rpt = new RPT001_Process(row.ID))
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
        #endregion

        #region "Event"
        private void RPT001_WorkPlaceLightIntensity_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }
        private void RPT01_WorkPlaceLightIntensity_OnNew(object sender, EventArgs e)
        {
            AddNew();
        }

        private void RPT01_WorkPlaceLightIntensity_OnSearch(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RPT01_WorkPlaceLightIntensity_OnDDPrint_Preview(object sender, EventArgs e)
        {
            PrintReport(false);
        }

        private void RPT01_WorkPlaceLightIntensity_OnDDPrint_Print(object sender, EventArgs e)
        {

            PrintReport(true);
        }

        private void RPT001_WorkPlaceLightIntensity_OnDDPrint_PDF(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.PortableDocFormat);
        }

        private void RPT001_WorkPlaceLightIntensity_OnDDPrint_Excel(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.Excel);
        }

        private void RPT001_WorkPlaceLightIntensity_OnDDPrint_Word(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.WordForWindows);
        }

        private void RPT001_WorkPlaceLightIntensity_OnClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void gvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditData(e);
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            EditData(null);
        }

        private void ctxMenu_Opening(object sender, CancelEventArgs e)
        {
            miCopy.Enabled = gvResult.RowCount > 0;
        }
        #endregion
    }
}
