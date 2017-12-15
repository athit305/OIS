using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.Definition;
using System.Data;
using System.Data.SqlClient;

namespace OIS.Common.Extensions
{
    public static class GridViewExtension
    {
        #region "Column Type"
        public static void SetColumnComboBox(this DataGridView gv, int colIndex, object dataSource, DataGridViewComboBoxDisplayStyle dispStyle = DataGridViewComboBoxDisplayStyle.DropDownButton)
        {
            DataGridViewComboBoxColumn col = gv.Columns[colIndex] as DataGridViewComboBoxColumn;
            col.ValueMember = "VALUE";
            col.DisplayMember = "DISPLAY";
            col.DataSource = dataSource;
            col.Width = 200;
            col.DisplayStyle = dispStyle;
        }
        public static void SetColumnDate(this DataGridView gv, int colIndex)
        {
            DataGridViewTextBoxColumn col = gv.Columns[colIndex] as DataGridViewTextBoxColumn;
            col.Width = 80;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.FormatProvider = CultureInfo.GetCultureInfo("th-TH");
            style.Format = OISGridConstant.DateFormat;

            col.DefaultCellStyle = style;
        }
        public static void SetColumnDateTime(this DataGridView gv, int colIndex)
        {
            DataGridViewTextBoxColumn col = gv.Columns[colIndex] as DataGridViewTextBoxColumn;
            col.Width = 100;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.FormatProvider = CultureInfo.GetCultureInfo("th-TH");
            style.Format = "g";
            style.Format = OISGridConstant.DateTimeFormat;

            col.DefaultCellStyle = style;
        }
        public static void SetColumnTime(this DataGridView gv, int colIndex)
        {
            DataGridViewTextBoxColumn col = gv.Columns[colIndex] as DataGridViewTextBoxColumn;
            col.Width = 50;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.FormatProvider = new TimeSpanFormatter();
            style.Format = OISGridConstant.TimeFormat;

            col.DefaultCellStyle = style;
        }
        public static void SetColumnNumeric(this DataGridView gv, int colIndex, int decimalPlace = 0)
        {
            DataGridViewTextBoxColumn col = gv.Columns[colIndex] as DataGridViewTextBoxColumn;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Alignment = DataGridViewContentAlignment.MiddleRight;
            style.Format = string.Format("N{0}", decimalPlace);
            if (col != null)
            {
                col.Width = 80;
                col.DefaultCellStyle = style;
            }
        }
        public static void SetColumnText(this DataGridView gv, int colIndex, int width = 200)
        {
            DataGridViewTextBoxColumn col = gv.Columns[colIndex] as DataGridViewTextBoxColumn;
            col.Width = width;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Format = "";

            col.DefaultCellStyle = style;
        }
        #endregion

        #region "Style"
        public static void SetColumnReadOnly(this DataGridView gv, int colIndex, bool isLock)
        {
            try
            {
                gv.Columns[colIndex].ReadOnly = isLock;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void SetOISStyle(this DataGridView gv, bool AllowDragDrop = false)
        {
            SetOISStyle(gv, DataGridViewEditMode.EditProgrammatically, AllowDragDrop);
        }
        public static void SetOISStyle(this DataGridView gv, DataGridViewEditMode editmode, bool AllowDragDrop = false)
        {
            gv.ColumnHeadersHeight = 40;
            gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gv.AllowUserToResizeColumns = true;
            gv.AllowUserToOrderColumns = true;
            gv.AllowDrop = AllowDragDrop;

            gv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gv.RowHeadersWidth = 60;
            gv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            if(editmode == DataGridViewEditMode.EditProgrammatically)
            {
                gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                for (int c = 0; c < gv.ColumnCount; c++)
                {
                    gv.Columns[c].ReadOnly = true;
                }
            }
            else
            {
                gv.EditMode = editmode;
            }

            gv.EnableHeadersVisualStyles = false;
            gv.AutoGenerateColumns = false;
            DataGridViewCellStyle headerStyle = gv.ColumnHeadersDefaultCellStyle;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.WrapMode = DataGridViewTriState.False;
            headerStyle.BackColor = Color.PowderBlue;
            headerStyle.ForeColor = Color.Navy;
            gv.ColumnHeadersDefaultCellStyle = headerStyle;

            DataGridViewCellStyle rowHeaderStyle = gv.RowHeadersDefaultCellStyle;
            rowHeaderStyle.BackColor = Color.PowderBlue;
            rowHeaderStyle.ForeColor = Color.Navy;
            rowHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gv.RowHeadersDefaultCellStyle = rowHeaderStyle;

            DataGridViewCellStyle style = gv.AlternatingRowsDefaultCellStyle;
            style.BackColor = Color.AliceBlue;
            gv.AlternatingRowsDefaultCellStyle = style;

            foreach(DataGridViewColumn col in gv.Columns)
            {
                if (editmode == DataGridViewEditMode.EditProgrammatically)
                {
                    col.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                else
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        public static void SetRowDeletedStyle(this DataGridView gv, int ColsDeleteFG)
        {
            for (int i = 0; i < gv.RowCount; i++)
            {
                if (gv.Rows[i].Cells[ColsDeleteFG].Value != null)
                {
                    DataGridViewCellStyle s = gv.Rows[i].DefaultCellStyle;
                    s.ForeColor = Color.Red;
                    gv.Rows[i].DefaultCellStyle = s;
                }
                else
                {
                    DataGridViewCellStyle s = gv.Rows[i].DefaultCellStyle;
                    s.ForeColor = Color.Black;
                    gv.Rows[i].DefaultCellStyle = s;
                }
            }
        }
        public static void SetRowDeletedStyle(this DataGridView gv, int rowIndex, bool isDeleted)
        {
            if (isDeleted)
            {
                gv.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
                gv.Rows[rowIndex].DefaultCellStyle.SelectionForeColor = Color.Red;
            }
            else
            {
                gv.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
                gv.Rows[rowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }
        #endregion

        public static void MappingEnum(this DataGridView gv, Type typeOfEnum)
        {
            string[] strEnumNames = Enum.GetNames(typeOfEnum);

            if (strEnumNames.Length == 0)
                return;

            for (int i = 0; i < gv.Columns.Count; i++)
            {
                if (i < strEnumNames.Length)
                    gv.Columns[i].DataPropertyName = strEnumNames[i];
            }
        }

        public static void RemoveCurrentRow(this DataGridView gv)
        {
            try
            {
                if(gv.RowCount > 0)
                {
                    int index = gv.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    if (index >= 0)
                    {
                        gv.Rows.RemoveAt(index);
                        gv.ClearSelection();
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool IsLastCellDisplay(this DataGridViewCell cell)
        {
            try
            {
                if(cell.ReadOnly)
                {
                    return false;
                }
                DataGridView gv = cell.DataGridView;
                foreach(DataGridViewCell c in gv.Rows[cell.RowIndex].Cells)
                {
                    if(c.ColumnIndex > cell.ColumnIndex && c.OwningColumn.Visible && !c.OwningColumn.ReadOnly && !c.ReadOnly)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #region "List"
        /// <summary>
        /// Adds all the data to a binding list
        /// </summary>
        public static void AddRange<T>(this BindingList<T> list, IEnumerable<T> data)
        {
            if (list == null || data == null)
            {
                return;
            }

            foreach (T t in data)
            {
                list.Add(t);
            }
        }

        public static void InsertRange<T>(this BindingList<T> list, int index, IEnumerable<T> data)
        {
            if (list == null || data == null)
            {
                return;
            }

            foreach (T t in data)
            {
                index++;
                list.Insert(index, t);
            }
        }

        public static void Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            try
            {
                T tmp = list[indexA];
                list[indexA] = list[indexB];
                list[indexB] = tmp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void MoveUp<T>(this IList<T> list, int index)
        {
            try
            {
                if(list != null && index > 0)
                {
                    list.Swap(index - 1, index);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void MoveDown<T>(this IList<T> list, int index)
        {
            try
            {
                if (list != null && index < list.Count - 1)
                {
                    list.Swap(index, index + 1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Cell Value"
        public static bool GetBooleanValue(this DataGridViewCell cell)
        {
            if (cell != null && cell.Value != null)
            {
                if (cell.Value is bool)
                {
                    return Convert.ToBoolean(cell.Value);
                }
            }
            return false;
        }
        public static int? GetIntValueOrNull(this DataGridViewCell cell)
        {
            if (cell != null && cell.Value != null)
            {
                 if (cell.Value is Int32)
                {
                    return Convert.ToInt32(cell.Value);
                }
            }
            return null;
        }
        public static int GetIntValue(this DataGridViewCell cell)
        {
            return GetIntValueOrNull(cell).GetValueOrDefault();
        }
        public static decimal? GetDecimalValueOrNull(this DataGridViewCell cell)
        {
            if (cell != null && cell.Value != null)
            {
                if (cell.Value is decimal)
                {
                    return Convert.ToDecimal(cell.Value);
                }
            }
            return null;
        }
        public static decimal GetDecimalValue(this DataGridViewCell cell)
        {
            return GetDecimalValueOrNull(cell).GetValueOrDefault();
        }
        public static DateTime? GetDateTimeValueOrNull(this DataGridViewCell cell)
        {
            if (cell != null && cell.Value != null)
            {
                if (cell.Value is DateTime)
                {
                    return Convert.ToDateTime(cell.Value);
                }
            }
            return null;
        }
        public static DateTime GetDateTimeValue(this DataGridViewCell cell)
        {
            return GetDateTimeValueOrNull(cell).GetValueOrDefault(DateTime.Now);
        }
        public static TimeSpan? GetTimeValueOrNull(this DataGridViewCell cell)
        {
            if (cell != null && cell.Value != null)
            {
                if (cell.Value is TimeSpan)
                {
                    return TimeSpan.Parse(cell.Value.ToString());
                }
                return null;
            }
            return null;
        }
        public static TimeSpan GetTimeValue(this DataGridViewCell cell)
        {
            return GetTimeValueOrNull(cell).GetValueOrDefault(DateTime.Now.TimeOfDay);
        }
        public static string GetStringValue(this DataGridViewCell cell)
        {
            if (cell != null && cell.Value != null)
            {
                if (cell.Value is string)
                {
                    return Convert.ToString(cell.Value);
                }
            }
            return null;
        }

        public static void SetBooleanValue(this DataGridViewCell cell, bool val)
        {
            if(cell != null)
            {
                cell.Value = val;
            }
        }
        public static void SetIntValue(this DataGridViewCell cell, int? val)
        {
            if (cell != null)
            {
                if (val != null)
                {
                    cell.Value = val;
                }
                else
                {
                    cell.Value = DBNull.Value;
                }
            }
        }
        public static void SetDecimalValue(this DataGridViewCell cell, decimal? val)
        {
            if (cell != null)
            {
                if (val != null)
                {
                    cell.Value = val;
                }
                else
                {
                    cell.Value = DBNull.Value;
                }
            }
        }
        public static void SetDateTimeValue(this DataGridViewCell cell, DateTime? val)
        {
            if (cell != null)
            {
                if (val != null)
                {
                    cell.Value = val;
                }
                else
                {
                    cell.Value = DBNull.Value;
                }
            }
        }
        public static void SetStringValue(this DataGridViewCell cell, string val)
        {
            if (cell != null)
            {
                if (val != null)
                {
                    cell.Value = val;
                }
                else
                {
                    cell.Value = DBNull.Value;
                }
            }
        }

        public static bool GetBooleanValue(this DataGridView gv, int RowIndex, int ColIndex)
        {
            DataGridViewCell cell = gv.Rows[RowIndex].Cells[ColIndex];
            return cell.GetBooleanValue();
        }
        public static int? GetIntValueOrNull(this DataGridView gv, int RowIndex, int ColIndex)
        {
            DataGridViewCell cell = gv.Rows[RowIndex].Cells[ColIndex];
            return cell.GetIntValueOrNull();
        }
        public static int GetIntValue(this DataGridView gv, int RowIndex, int ColIndex)
        {
            DataGridViewCell cell = gv.Rows[RowIndex].Cells[ColIndex];
            return cell.GetIntValue();
        }
        public static decimal? GetDecimalValueOrNull(this DataGridView gv, int RowIndex, int ColIndex)
        {
            DataGridViewCell cell = gv.Rows[RowIndex].Cells[ColIndex];
            return cell.GetDecimalValueOrNull();
        }
        public static decimal GetDecimalValue(this DataGridView gv, int RowIndex, int ColIndex)
        {
            DataGridViewCell cell = gv.Rows[RowIndex].Cells[ColIndex];
            return cell.GetDecimalValue();
        }
        public static DateTime? GetDateTimeValueOrNull(this DataGridView gv, int RowIndex, int ColIndex)
        {
            DataGridViewCell cell = gv.Rows[RowIndex].Cells[ColIndex];
            return cell.GetDateTimeValueOrNull();
        }
        public static DateTime GetDateTimeValue(this DataGridView gv, int RowIndex, int ColIndex)
        {
            DataGridViewCell cell = gv.Rows[RowIndex].Cells[ColIndex];
            return cell.GetDateTimeValue();
        }
        public static TimeSpan? GetTimeValueOrNull(this DataGridView gv, int RowIndex, int ColIndex)
        {
            DataGridViewCell cell = gv.Rows[RowIndex].Cells[ColIndex];
            return cell.GetTimeValueOrNull();
        }
        public static TimeSpan GetTimeValue(this DataGridView gv, int RowIndex, int ColIndex)
        {
            DataGridViewCell cell = gv.Rows[RowIndex].Cells[ColIndex];
            return cell.GetTimeValue();
        }
        public static string GetStringValue(this DataGridView gv, int RowIndex, int ColIndex)
        {
            DataGridViewCell cell = gv.Rows[RowIndex].Cells[ColIndex];
            return cell.GetStringValue();
        }
        #endregion
    }
}
;