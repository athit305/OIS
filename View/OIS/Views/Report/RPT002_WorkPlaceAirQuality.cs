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
using OIS.Common.Utils;
using OIS.RPT.DTO;
using OIS.RPT.DTO.Criteria;
using OIS.ViewModel;
using OIS.Views.Reports;
using CrystalDecisions.Shared;

namespace OIS.Views
{
    public partial class RPT002_WorkPlaceAirQuality : rBaseUC
    {
        #region "Enum"
        private enum eCol
        {
            ANALYSYS_NO_DISP,
            CUSTOMER_NAME,
            CUSTOMER_PROJECT_NAME,
            ANALYTICAL_DATE,
            SAMPLING_NAME,
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

        RPT002_WorkPlaceAir_Criteria criteria;
        SortableBindingList<sp_RPT002_GetWorkPlaceAir_Result> rptList;
        #endregion

        #region "Constructor"
        public RPT002_WorkPlaceAirQuality()
        {
            InitializeComponent();
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            try
            {
                this.ToolBarSwitch = "1212001221";
                this.tsbDDPrint2.Text = "สอ.๓";

                this.tsbDDPrint2_Preview.Visible = false;
                this.tsbDDPrint2_Print.Visible = false;
                this.tsbDDPrint2_PDF.Visible = false;
                this.tsbDDPrint2_Word.Visible = false;
                this.tsbDDPrint_Excel.Visible = true;

                gvResult.SetOISStyle();
                gvResult.MappingEnum(typeof(eCol));

                gvResult.SetColumnDateTime((int)eCol.CRT_DATE);
                gvResult.SetColumnDateTime((int)eCol.UPD_DATE);
                gvResult.SetColumnDateTime((int)eCol.DEL_DATE);

                for (int i = (int)eCol.ID; i <= (int)eCol.DEL_ID; i++)
                {
                    gvResult.Columns[i].Visible = false;
                }

                criteria = new RPT002_WorkPlaceAir_Criteria();
                bdSource.DataSource = criteria;
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void LoadData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bdSource.EndEdit();
                criteria = new RPT002_WorkPlaceAir_Criteria()
                {
                    ANALYSYS_NO = txtReportNumber.TextValue,
                    JOB_NO = txtJobNo.TextValue,
                    ANALYTICAL_DATE_FROM = dtMeasuredDate.DateValue,
                    ANALYTICAL_DATE_TO = dtMeasuredDateTo.DateValue,
                    CUSTOMER_ID = txtCustomer.IntValue,
                    SAMPING_BY = txtMeasuredBy.StringValue,
                    SHOW_DELETE_RECORD = chkShowDeleteRecord.Checked,
                };

                rptList = vmRpt.GetWorkPlaceAir(criteria);
                gvResult.DataSource = rptList;

                gvResult.SetRowDeletedStyle((int)eCol.DEL_ID);

                if (gvResult.RowCount > 0)
                {
                    this.ToolBarSwitch = "1212111221";
                    //this.ToolBarSwitch = "1212121221";
                }
                else
                {
                    this.ToolBarSwitch = "1212001221";
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
        private void AddNew()
        {
            try
            {
                using (RPT002_WorkPlaceAirQualityEntry dlg = new RPT002_WorkPlaceAirQualityEntry())
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
                if (e.RowIndex >= 0)
                {
                    sp_RPT002_GetWorkPlaceAir_Result row = gvResult.Rows[e.RowIndex].DataBoundItem as sp_RPT002_GetWorkPlaceAir_Result;
                    using (RPT002_WorkPlaceAirQualityEntry dlg = new RPT002_WorkPlaceAirQualityEntry(row.ID))
                    {
                        if (dlg.ShowDialog(this) == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void ClearScreen()
        {
            gvResult.DataSource = null;
            gvResult.Rows.Clear();
            criteria = new RPT002_WorkPlaceAir_Criteria();
            bdSource.DataSource = criteria;
            this.ToolBarSwitch = "1212001221";
        }

        private void PrintReport(bool isPrint, ExportFormatType exportFormat = ExportFormatType.NoFormat)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (gvResult.CurrentRow.Index >= 0)
                {
                    sp_RPT002_GetWorkPlaceAir_Result row = gvResult.Rows[gvResult.CurrentRow.Index].DataBoundItem as sp_RPT002_GetWorkPlaceAir_Result;
                    using (RPT002_Process rpt = new RPT002_Process(row.ID))
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
        private void PrintReport2()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (gvResult.CurrentRow.Index >= 0)
                {
                    sp_RPT002_GetWorkPlaceAir_Result data = gvResult.CurrentDataBound as sp_RPT002_GetWorkPlaceAir_Result;
                    if (data != null)
                    {
                        try
                        {
                            using (RPT002_2_Process rpt = new RPT002_2_Process(data.ID))
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            rMessageBox.ShowException(this, ex);
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
        private void RPT002_WorkPlaceAirQuality_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void RPT002_WorkPlaceAirQuality_OnNew(object sender, EventArgs e)
        {
            AddNew();
        }

        private void RPT002_WorkPlaceAirQuality_OnSearch(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RPT002_WorkPlaceAirQuality_OnClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void gvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditData(e);
        }
        #endregion

        private void RPT002_WorkPlaceAirQuality_OnDDPrint_Print(object sender, EventArgs e)
        {
            PrintReport(true);
        }

        private void RPT002_WorkPlaceAirQuality_OnDDPrint_Preview(object sender, EventArgs e)
        {
            PrintReport(false);
        }

        private void RPT002_WorkPlaceAirQuality_OnDDPrint_PDF(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.PortableDocFormat);
        }

        private void RPT002_WorkPlaceAirQuality_OnDDPrint_Excel(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.Excel);
        }

        private void RPT002_WorkPlaceAirQuality_OnDDPrint_Word(object sender, EventArgs e)
        {
            PrintReport(false, ExportFormatType.WordForWindows);
        }

        private void RPT002_WorkPlaceAirQuality_OnDDPrint2_Excel(object sender, EventArgs e)
        {
            PrintReport2();
        }
    }
}
