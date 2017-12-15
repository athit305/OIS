using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using OIS.Common;
using OIS.Common.Extensions;
using OIS.Common.Utils;
using OIS.Definition;
using OIS.RPT.DTO;
using OIS.Views.Dialogs;
using OIS.ViewModel;
using OfficeOpenXml;

namespace OIS.Views.Reports
{
    public class RPT002_Process : IDisposable
    {
        private int WPA_ID;
        private RPT001_WorkPlaceLightDTO result = new RPT001_WorkPlaceLightDTO();
        private SortableBindingList<sp_RPT001_GetWorkPlaceLightReport_Result> dataList;

        private ReportViewModel vmRpt = new ReportViewModel();

        public RPT002_Process(int ID)
        {
            try
            {
                this.WPA_ID = ID;
                this.LoadData();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void LoadData()
        {
            //result = vmRpt.GetWorkPlaceLight(this.WPA_ID);
            //this.dataList = vmRpt.GetWorkPlaceLightReport(this.WPA_ID);
        }

        public void PrintReport()
        {
            try
            {
                if (this.WPA_ID == 0)
                {
                    return;
                }
                using (ReportDocument rpt = new RPT002_WorkPlaceAirQualityReport())
                {
                    rpt.SetParameterValue("@p_ID", WPA_ID);
                    rpt.SetDatabaseLogon(OISDataInfo.DatabaseInfomation.USERNAME, OISDataInfo.DatabaseInfomation.PASSWORD, OISDataInfo.DatabaseInfomation.DATASOURCE, OISDataInfo.DatabaseInfomation.DATABASENAME);
                    SetConnection(rpt);

                    using (PrintDialog p = new PrintDialog())
                    {
                        p.AllowPrintToFile = false;
                        p.AllowCurrentPage = true;
                        p.AllowSomePages = true;
                        if (p.ShowDialog() == DialogResult.OK)
                        {
                            PageSettings ps = new PageSettings(p.PrinterSettings);
                            rpt.PrintToPrinter(p.PrinterSettings, ps, false);
                        }
                    }
                    CloseConnection(rpt);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExportExcelSpecial()
        {
            try
            {
                if (dataList != null && dataList.Count > 0)
                {
                    string tmpFileName = FilesUtil.GetTmpXlsxFileName();
                    FileInfo newFile = new FileInfo(tmpFileName);
                    using (ExcelPackage NewPck = new ExcelPackage(newFile))
                    using (ExcelWorkbook NewWb = NewPck.Workbook)
                    {
                        //load template
                        string TEMPLATE_FILE_NAME = "RPT001_Template.xlsx";
                        string TemplatePath = Path.Combine(Application.StartupPath, OISBaseConstant.PATH_TEMPLATE, TEMPLATE_FILE_NAME);
                        FileInfo OrgFile = new FileInfo(TemplatePath);

                        //create sheet
                        using (ExcelPackage OrgPck = new ExcelPackage(OrgFile))
                        using (ExcelWorkbook OrgWb = OrgPck.Workbook)
                        {
                            ExcelWorksheet OrgSheet;
                            int firstRecordRow, templateColumnCount, LV3Row, LV2Row, LOCRow;

                                OrgSheet = OrgWb.Worksheets[1];
                                firstRecordRow = 3;
                                templateColumnCount = 6;
                                LV3Row = 3;
                                LV2Row = 4;
                                LOCRow = 5;

                            //add sheet
                            NewWb.Worksheets.Add(dataList[0].REPORTNUMBER, OrgSheet);
                            ExcelWorksheet sht = NewWb.Worksheets[1];
                            sht.DeleteRow(firstRecordRow, 4);
                            sht.Cells.Worksheet.Workbook.Styles.UpdateXml();

                            int nextRow = firstRecordRow;
                            string tmpLV3 = "", tmpLV2 = "";
                            for (int i = 0; i < dataList.Count; i++)
                            {
                                sp_RPT001_GetWorkPlaceLightReport_Result data = dataList[i];

                                if (!data.LOC_NAME_LV3.IsNull())
                                {
                                    if (tmpLV3 != data.LOC_NAME_LV3)
                                    {
                                        tmpLV3 = data.LOC_NAME_LV3;
                                        OrgSheet.Cells[LV3Row, 1, LV3Row, templateColumnCount].Copy(sht.Cells[nextRow, 1, nextRow, templateColumnCount]);
                                        sht.Cells[nextRow, 2].Value = data.LOC_NAME_LV3;
                                        nextRow++;
                                    }
                                }
                                if (!data.LOC_NAME_LV2.IsNull())
                                {
                                    if (tmpLV2 != data.LOC_NAME_LV2)
                                    {
                                        tmpLV2 = data.LOC_NAME_LV2;
                                        OrgSheet.Cells[LV2Row, 1, LV2Row, templateColumnCount].Copy(sht.Cells[nextRow, 1, nextRow, templateColumnCount]);
                                        sht.Cells[nextRow, 2].Value = data.LOC_NAME_LV2;
                                        nextRow++;
                                    }
                                }
                                if (i + 1 == dataList.Count)
                                {
                                    OrgSheet.Cells[firstRecordRow + 3, 1, firstRecordRow + 3, templateColumnCount].Copy(sht.Cells[nextRow, 1, nextRow, templateColumnCount]);
                                }
                                else
                                {
                                    OrgSheet.Cells[LOCRow, 1, LOCRow, templateColumnCount].Copy(sht.Cells[nextRow, 1, nextRow, templateColumnCount]);
                                }
                                sht.Cells[nextRow, 1].Value = i + 1;
                                sht.Cells[nextRow, 2].Value = data.LOC_NAME;
                                sht.Cells[nextRow, 3].Value = data.STDLIGHT_NAME;
                                if (data.RESULT_DAY.HasValue)
                                {
                                    sht.Cells[nextRow, 4].Value = data.RESULT_DAY_STR;
                                }
                                else
                                {
                                    sht.Cells[nextRow, 4].Value = data.RESULT_NIGHT_STR;
                                }
                                //sht.Cells[nextRow, 5].Value = data.STDLIGHT_STANDARD_STR;
                                sht.Cells[nextRow, 6].Value = data.CONDITION;

                                var rtDir2 = sht.Cells[nextRow, 5].RichText.Add(data.STDLIGHT_STANDARD.GetValueOrDefault().ToString("#,##0"));
                                rtDir2.UnderLine = false;
                                nextRow++;
                            }

                            //Open Excel
                            NewPck.Save();
                            Process.Start(tmpFileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void PreviewDialog()
        {
            try
            {
                using (ReportDocument rpt = new RPT002_WorkPlaceAirQualityReport())
                {
                    rpt.SetParameterValue("@p_ID", WPA_ID);
                    rpt.SetDatabaseLogon(OISDataInfo.DatabaseInfomation.USERNAME, OISDataInfo.DatabaseInfomation.PASSWORD, OISDataInfo.DatabaseInfomation.DATASOURCE, OISDataInfo.DatabaseInfomation.DATABASENAME);
                    SetConnection(rpt);
                    using (ReportViewer dlg = new ReportViewer(rpt))
                    {
                        dlg.ShowDialog(null);
                    }
                    CloseConnection(rpt);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Export(ExportFormatType exportFormat)
        {
            try
            {
                string tmpFileName;
                string ReportNumber = "";
                if (result != null)
                {
                    ReportNumber = result.REPORTNUMBER + " " + result.CUSTOMER_NAME;
                }
                switch (exportFormat)
                {
                    case ExportFormatType.PortableDocFormat:
                        tmpFileName = FilesUtil.GetTmpPdfFileName(ReportNumber);
                        break;
                    case ExportFormatType.WordForWindows:
                    case ExportFormatType.EditableRTF:
                        tmpFileName = FilesUtil.GetTmpDocFileName(ReportNumber);
                        break;
                    case ExportFormatType.Excel:
                        tmpFileName = FilesUtil.GetTmpXlsFileName(ReportNumber);
                        break;
                    default:
                        tmpFileName = FilesUtil.GetTmpPdfFileName(ReportNumber);
                        break;
                }
                using (ReportDocument rpt = new RPT002_WorkPlaceAirQualityReport())
                {
                    rpt.SetParameterValue("@p_ID", WPA_ID);
                    rpt.SetDatabaseLogon(OISDataInfo.DatabaseInfomation.USERNAME, OISDataInfo.DatabaseInfomation.PASSWORD, OISDataInfo.DatabaseInfomation.DATASOURCE, OISDataInfo.DatabaseInfomation.DATABASENAME);
                    SetConnection(rpt);

                    rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                    rpt.ExportToDisk(exportFormat, tmpFileName);
                    Process.Start(tmpFileName);

                    CloseConnection(rpt);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            WPA_ID = 0;
            dataList = null;

            // Use SupressFinalize in case a subclass 
            // of this type implements a finalizer.
            GC.SuppressFinalize(this);
        }


        private void SetConnection(ReportDocument rpt)
        {
            try
            {
                ReportObjects crReportObjects;
                SubreportObject crSubreportObject;
                ReportDocument crSubreportDocument;
                Database crDatabase;
                Tables crTables;
                TableLogOnInfo crTableLogOnInfo;

                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                //pass the necessary parameters to the connectionInfo object
                crConnectionInfo.ServerName = OISDataInfo.DatabaseInfomation.DATASOURCE;
                crConnectionInfo.UserID = OISDataInfo.DatabaseInfomation.USERNAME;
                crConnectionInfo.Password = OISDataInfo.DatabaseInfomation.PASSWORD;
                crConnectionInfo.DatabaseName = OISDataInfo.DatabaseInfomation.DATABASENAME;

                //set up the database and tables objects to refer to the current report
                crDatabase = rpt.Database;
                crTables = crDatabase.Tables;

                //loop through all the tables and pass in the connection info
                foreach (Table crTable in crTables)
                {
                    crTableLogOnInfo = crTable.LogOnInfo;
                    crTableLogOnInfo.ConnectionInfo = crConnectionInfo;
                    crTable.ApplyLogOnInfo(crTableLogOnInfo);
                }

                //set the crSections object to the current report's sections
                Sections crSections = rpt.ReportDefinition.Sections;

                //loop through all the sections to find all the report objects
                foreach (Section crSection in crSections)
                {
                    crReportObjects = crSection.ReportObjects;
                    //loop through all the report objects to find all the subreports
                    foreach (ReportObject crReportObject in crReportObjects)
                    {
                        if (crReportObject.Kind == ReportObjectKind.SubreportObject)
                        {
                            //you will need to typecast the reportobject to a subreport 
                            //object once you find it
                            crSubreportObject = (SubreportObject)crReportObject;

                            //open the subreport object
                            crSubreportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName);

                            //set the database and tables objects to work with the subreport
                            crDatabase = crSubreportDocument.Database;
                            crTables = crDatabase.Tables;

                            //loop through all the tables in the subreport and 
                            //set up the connection info and apply it to the tables
                            foreach (Table crTable in crTables)
                            {
                                crConnectionInfo.ServerName = OISDataInfo.DatabaseInfomation.DATASOURCE;
                                crConnectionInfo.UserID = OISDataInfo.DatabaseInfomation.USERNAME;
                                crConnectionInfo.Password = OISDataInfo.DatabaseInfomation.PASSWORD;
                                crConnectionInfo.DatabaseName = OISDataInfo.DatabaseInfomation.DATABASENAME;

                                crTableLogOnInfo = crTable.LogOnInfo;
                                crTableLogOnInfo.ConnectionInfo = crConnectionInfo;
                                crTable.ApplyLogOnInfo(crTableLogOnInfo);
                            }
                        }
                    }
                }

                TableLogOnInfos crTableLogonInfos = new TableLogOnInfos();
                TableLogOnInfo crTableLogonInfo = new TableLogOnInfo();
                foreach (Table table in rpt.Database.Tables)
                {
                    crTableLogonInfo.TableName = table.Name;
                    crTableLogonInfo.ConnectionInfo = crConnectionInfo;
                    crTableLogonInfos.Add(crTableLogonInfo);
                    table.ApplyLogOnInfo(crTableLogonInfo);
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(null, ex);
            }
        }
        private void CloseConnection(ReportDocument rpt)
        {
            try
            {
                foreach (Table table in rpt.Database.Tables)
                {
                    table.Dispose();
                }

                foreach (Section crSection in rpt.ReportDefinition.Sections)
                {
                    var crReportObjects = crSection.ReportObjects;
                    foreach (ReportObject crReportObject in crReportObjects)
                    {
                        if (crReportObject.Kind == ReportObjectKind.SubreportObject)
                        {
                            var crSubreportObject = (SubreportObject)crReportObject;

                            var crSubreportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName);

                            var crDatabase = crSubreportDocument.Database;
                            var crTables = crDatabase.Tables;
                            foreach (Table crTable in crTables)
                            {
                                crTable.Dispose();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(null, ex);
            }
        }
    }

    public class RPT002_2_Process : IDisposable
    {
        private ReportViewModel vmRpt = new ReportViewModel();

        public RPT002_2_Process(int WPA_ID)
        {
            try
            {
                List<sp_RPT002_GetWorkPlaceAirReport_2_Result> dataList = vmRpt.GetWorkPlaceAirReport_2(WPA_ID);
                if (dataList != null && dataList.Count > 0)
                {
                    string fileName = string.Format("{0} ({1})", dataList[0].ANALYSYS_NO, dataList[0].CUSTOMER_NAME_TH);
                    string tmpFileName = FilesUtil.GetTmpXlsxFileName(fileName);
                    FileInfo newFile = new FileInfo(tmpFileName);
                    using (ExcelPackage NewPck = new ExcelPackage(newFile))
                    using (ExcelWorkbook NewWb = NewPck.Workbook)
                    {
                        //load template
                        string TEMPLATE_FILE_NAME = "RPT002_Template.xlsx";
                        string TemplatePath = Path.Combine(Application.StartupPath, OISBaseConstant.PATH_TEMPLATE, TEMPLATE_FILE_NAME);
                        FileInfo OrgFile = new FileInfo(TemplatePath);

                        //create sheet
                        using (ExcelPackage OrgPck = new ExcelPackage(OrgFile))
                        using (ExcelWorkbook OrgWb = OrgPck.Workbook)
                        {
                            ExcelWorksheet OrgSheet;
                            int firstRecordRow, templateColumnCount, firstReferenceRow;

                            OrgSheet = OrgWb.Worksheets[1];
                            firstRecordRow = 15;
                            firstReferenceRow = 17;
                            templateColumnCount = CellStringToIndex("BV");

                            //add sheet
                            NewWb.Worksheets.Add(dataList[0].ANALYSYS_NO, OrgSheet);
                            ExcelWorksheet sht = NewWb.Worksheets[1];
                            sht.DeleteRow(16);
                            sht.Cells.Worksheet.Workbook.Styles.UpdateXml();

                            // Header
                            sht.Cells[4, CellStringToIndex("J")].Value = dataList[0].CUSTOMER_NAME_TH;
                            sht.Cells[5, CellStringToIndex("F")].Value = dataList[0].CUSTOMER_ADDRNO;
                            sht.Cells[5, CellStringToIndex("N")].Value = dataList[0].CUSTOMER_MOO;
                            sht.Cells[5, CellStringToIndex("R")].Value = dataList[0].CUSTOMER_ROAD;
                            sht.Cells[5, CellStringToIndex("AC")].Value = dataList[0].CUSTOMER_SUBDISTRICT;
                            sht.Cells[5, CellStringToIndex("AT")].Value = dataList[0].CUSTOMER_DISTRICT;
                            sht.Cells[5, CellStringToIndex("BJ")].Value = dataList[0].CUSTOMER_PROVINCE;
                            sht.Cells[6, CellStringToIndex("G")].Value = dataList[0].CUSTOMER_POSTCODE;
                            sht.Cells[5, CellStringToIndex("O")].Value = dataList[0].CUSTOMER_TEL;
                            sht.Cells[22, CellStringToIndex("W")].Value = dataList[0].ANALYST_NAME;
                            sht.Cells[22, CellStringToIndex("BH")].Value = dataList[0].AGENT_NAME;

                            string t = sht.Cells[23, CellStringToIndex("BH")].Text;
                            sht.Cells[23, CellStringToIndex("BH")].Value = null;
                            var rt1 = sht.Cells[23, CellStringToIndex("BH")].RichText.Add("นายจ้าง");
                            var rt2 = sht.Cells[23, CellStringToIndex("BH")].RichText.Add("/");
                            var rt3 = sht.Cells[23, CellStringToIndex("BH")].RichText.Add("ผู้กระทำแทน");
                            if (dataList[0].AGENT_FLAG)
                            {
                                rt3.Strike = true;
                            }
                            else
                            {
                                rt1.Strike = true;
                            }

                            // Reference
                            int nextRow = firstReferenceRow;
                            var instList = dataList
                                .Where(x => x.INST_NAME != null)
                                .Select(x => new
                                {
                                    INST_NAME = x.INST_NAME,
                                    INST_EDITION = x.INST_EDITION,
                                    INST_PAGE_FROM = x.INST_PAGE_FROM,
                                    INST_PAGE_TO = x.INST_PAGE_TO,
                                }).Distinct().ToList();
                            if (instList != null && instList.Count > 0)
                            {
                                for (int i = 0; i < instList.Count; i++)
                                {
                                    if (i > 0 && i < instList.Count - 1)
                                    {
                                        sht.InsertRow(nextRow, 1, firstReferenceRow);
                                        OrgSheet.Cells[firstReferenceRow + 1, 1, firstReferenceRow + 1, templateColumnCount].Copy(sht.Cells[nextRow, 1, nextRow, templateColumnCount]);
                                    }

                                    var data = instList[i];
                                    sht.Cells[nextRow, CellStringToIndex("V")].Value = string.Format("{0}. {1}", i + 1, data.INST_NAME);
                                    sht.Cells[nextRow, CellStringToIndex("AT")].Value = data.INST_EDITION;
                                    sht.Cells[nextRow, CellStringToIndex("BG")].Value = data.INST_PAGE_FROM;
                                    sht.Cells[nextRow, CellStringToIndex("BP")].Value = data.INST_PAGE_TO;
                                }
                            }

                            // Detail
                            nextRow = firstRecordRow;
                            for (int i = 0; i < dataList.Count; i++)
                            {
                                if (i > 0 && i < dataList.Count - 1)
                                {
                                    sht.InsertRow(nextRow, 1, firstRecordRow);
                                    OrgSheet.Cells[firstRecordRow + 1, 1, firstRecordRow + 1, templateColumnCount].Copy(sht.Cells[nextRow, 1, nextRow, templateColumnCount]);
                                }

                                sp_RPT002_GetWorkPlaceAirReport_2_Result data = dataList[i];

                                sht.Cells[nextRow, CellStringToIndex("A")].Value = data.PARAMETER_NAME;
                                sht.Cells[nextRow, CellStringToIndex("H")].Value = data.SAMPLING_DATE;
                                sht.Cells[nextRow, CellStringToIndex("L")].Value = data.LOC_NAME;
                                sht.Cells[nextRow, CellStringToIndex("Y")].Value = data.TOOLPICK_NAME;
                                sht.Cells[nextRow, CellStringToIndex("AK")].Value = data.AIR_FLOW;
                                sht.Cells[nextRow, CellStringToIndex("AN")].Value = data.SAMPLING_TIME;
                                sht.Cells[nextRow, CellStringToIndex("AS")].Value = data.ANALYTICAL_DATE;
                                sht.Cells[nextRow, CellStringToIndex("AX")].Value = data.TOOLANALYSIS_NAME;
                                sht.Cells[nextRow, CellStringToIndex("BJ")].Value = data.RESULT_DISP.ToString();
                                sht.Cells[nextRow, CellStringToIndex("BO")].Value = data.STANDARD_DISP;
                                sht.Cells[nextRow, CellStringToIndex("BS")].Value = "ไม่เกิน";


                                nextRow++;
                            }

                            //Open Excel
                            NewPck.Save();
                            Process.Start(tmpFileName);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        private int CellStringToIndex(string columnName)
        {
            try
            {
                if (string.IsNullOrEmpty(columnName)) throw new ArgumentNullException("columnName");

                columnName = columnName.ToUpperInvariant();

                int sum = 0;

                for (int i = 0; i < columnName.Length; i++)
                {
                    sum *= 26;
                    sum += (columnName[i] - 'A' + 1);
                }

                return sum;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
