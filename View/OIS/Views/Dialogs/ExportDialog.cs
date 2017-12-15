using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.BaseViews;
using OIS.Common;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.HSSF.Util;

namespace OIS.Views.Dialogs
{
    public partial class ExportDialog : rBaseForm
    {
        #region "Variable"
        private DataGridView dataGV;
        private HSSFWorkbook _workbook;
        private ISheet _activeSheet;

        private int colWidth = 45;
        #endregion

        #region "Constructor"
        public ExportDialog()
        {
            InitializeComponent();
        }
        public ExportDialog(DataGridView gv)
        {
            InitializeComponent();
            dataGV = gv;
            lblRow.Text = string.Format("0/{0}", dataGV.RowCount);
        }
        #endregion

        #region "Customize"
        private void CreateFile()
        {
            try
            {
                _workbook = new HSSFWorkbook();

                _activeSheet = _workbook.CreateSheet("Sheet1");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Export()
        {
            try
            {
                IRow header = _activeSheet.CreateRow(0);
                IFont boldFont = _workbook.CreateFont();
                IDataFormat dataFormat = _workbook.CreateDataFormat();
                boldFont.Boldweight = (short)FontBoldWeight.Bold;

                ICellStyle headerStyle = _workbook.CreateCellStyle();
                headerStyle.SetFont(boldFont);
                headerStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                headerStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;

                ICellStyle dateStyle = _workbook.CreateCellStyle();
                dateStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                dateStyle.DataFormat = dataFormat.GetFormat("d mmm yyyy");

                ICellStyle datetimeStyle = _workbook.CreateCellStyle();
                datetimeStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                datetimeStyle.DataFormat = dataFormat.GetFormat("d mmm yyyy hh:mm:ss");

                for (int i = 0; i < dataGV.ColumnCount; i++)
                {
                    DataGridViewColumn gvCol = dataGV.Columns[i];
                    if (gvCol.Visible)
                    {
                        ICell cell = header.CreateCell(i, CellType.String);
                        cell.CellStyle = headerStyle;
                        cell.SetCellValue(gvCol.HeaderText);
                        _activeSheet.SetColumnWidth(i, gvCol.Width * colWidth);
                    }
                }

                for (int i = 0; i < dataGV.RowCount; i++)
                {
                    DataGridViewRow gvRow = dataGV.Rows[i];                    
                    IRow row = _activeSheet.CreateRow(i + 1);

                    for (int j = 0; j < dataGV.ColumnCount; j++)
                    {
                        DataGridViewColumn gvCol = dataGV.Columns[j];
                        if (gvCol.Visible)
                        {
                            string styleFormat = gvCol.DefaultCellStyle.Format;
                            if (styleFormat != string.Empty && styleFormat.Substring(0, 1) == "N")
                            {
                                styleFormat = styleFormat.Substring(0, 1);
                            }
                            DataGridViewCell gvCell = gvRow.Cells[j];

                            ICell cell;
                            switch (styleFormat)
                            {
                                case "":
                                    cell = row.CreateCell(j, CellType.String);
                                    if (gvCell.Value != null)
                                    {
                                        cell.SetCellValue(gvCell.Value.ToString());
                                    }
                                    else
                                    {
                                        cell.SetCellValue("");
                                    }
                                    break;
                                case "N":
                                    cell = row.CreateCell(j, CellType.Numeric);
                                    if (gvCell.Value != null)
                                    {
                                        cell.SetCellValue(Convert.ToDouble(gvCell.Value));
                                    }
                                    else
                                    {
                                        cell.SetCellValue("");
                                    }
                                    break;
                                case "dd/MM/yyyy":
                                    cell = row.CreateCell(j, CellType.String);
                                    if (gvCell.Value != null)
                                    {
                                        DateTime dt = Convert.ToDateTime(gvCell.Value);
                                        cell.SetCellValue(dt);
                                        cell.CellStyle = dateStyle;
                                    }
                                    else
                                    {
                                        cell.SetCellValue("");
                                    }
                                    break;
                                case "dd/MM/yyyy HH:mm:ss":
                                    cell = row.CreateCell(j, CellType.String);
                                    if (gvCell.Value != null)
                                    {
                                        DateTime dt = Convert.ToDateTime(gvCell.Value);
                                        cell.SetCellValue(dt);
                                        cell.CellStyle = datetimeStyle;
                                    }
                                    else
                                    {
                                        cell.SetCellValue("");
                                    }
                                    break;
                                default:
                                    cell = row.CreateCell(j, CellType.String);
                                    if (gvCell.Value != null)
                                    {
                                        cell.SetCellValue(gvCell.Value.ToString());
                                    }
                                    else
                                    {
                                        cell.SetCellValue("");
                                    }
                                    break;
                            }
                        }
                    }
                    backgroundWorkerExport.ReportProgress(i + 1);
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void WriteFile()
        {
            try
            {
                using (FileStream file = new FileStream(txtFileName.Text, FileMode.Create))
                {
                    _workbook.Write(file);
                    file.Close();
                }

                rMessageBox.ShowProcessCompleted(this);

                if (ChkOpenWhenFinish.Checked)
                {
                    Process.Start(txtFileName.Text);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool FileIsLocked(string strFullFileName)
        {
            bool blnReturn = false;
            FileStream fs;
            try
            {
                fs = File.Open(strFullFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                fs.Close();
            }
            catch (IOException)
            {
                blnReturn = true;
            }
            return blnReturn;
        }
        #endregion

        #region "Event"
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!backgroundWorkerExport.IsBusy)
                {
                    if (FileIsLocked(txtFileName.Text))
                    {
                        rMessageBox.ShowWarning(this, "File is used by another program.", MessageBoxButtons.OK);
                    }
                    else
                    {
                        CreateFile();
                        progressBarExport.Maximum = dataGV.RowCount;
                        progressBarExport.Step = 1;
                        progressBarExport.Value = 0;
                        backgroundWorkerExport.RunWorkerAsync();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.Filter = "Excel Files|*.xls;*.xlsx;";
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = saveFileDialogExport.FileName;
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = !txtFileName.IsNull;
        }

        private void backgroundWorkerExport_DoWork(object sender, DoWorkEventArgs e)
        {
            Export();
        }

        private void backgroundWorkerExport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarExport.Value = e.ProgressPercentage;
            lblRow.Text = string.Format("{0}/{1}", e.ProgressPercentage, dataGV.RowCount);
        }

        private void backgroundWorkerExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            WriteFile();
        }
        #endregion
    }
}
