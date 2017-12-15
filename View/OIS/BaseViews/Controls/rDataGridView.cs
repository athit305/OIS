using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.Common.Extensions;
using OIS.Definition;
using OIS.Common;

namespace OIS.BaseViews
{
    public partial class rDataGridView : DataGridView
    {
        #region "Variable"
        private bool mbAutoGenerateColumns = false;
        private bool mEnterToAddRow = true;

        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        [Browsable(true)]
        new public bool AutoGenerateColumns
        {
            get { return base.AutoGenerateColumns; }
            set { base.AutoGenerateColumns = mbAutoGenerateColumns = value; }
        }

        private DataGridViewTextBoxEditingControl tb;
        private CalendarEditingControl cld;
        private Color cellBackColor;

        [Browsable(true)]
        public bool EnterToAddRow
        {
            get
            {
                return mEnterToAddRow;
            }
            set
            {
                mEnterToAddRow = value;
            }
        }
        #endregion

        #region "Constructor"
        public rDataGridView()
        {
            // Set AGC to false right on the start
            AutoGenerateColumns = false;
            AllowDrop = true;
        }
        #endregion

        #region "Customize"
        public void ScrollToRow(int rowIndex)
        {
            try
            {
                if (this.RowCount > 0 && rowIndex >= 0)
                {
                    this.FirstDisplayedScrollingRowIndex = rowIndex;
                    this.CurrentCell = this.Rows[rowIndex].Cells[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetDataBound(int rowIndex)
        {
            try
            {
                if (this.DataSource != null && this.RowCount > 0)
                {
                    return this.Rows[rowIndex].DataBoundItem;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object CurrentDataBound
        {
            get
            {
                try
                {
                    if (this.DataSource != null && this.RowCount > 0)
                    {
                        int rowIndex = this.SelectedRowIndex;
                        if (rowIndex == -1 && this.CurrentCell.RowIndex >= 0)
                        {
                            rowIndex = this.CurrentCell.RowIndex;
                        }
                        if (rowIndex >= 0)
                        {
                            return this.Rows[rowIndex].DataBoundItem;
                        }
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Get Selected Row Index
        /// </summary>
        public int SelectedRowIndex
        {
            get
            {
                try
                {
                    if (this.RowCount > 0)
                    {
                        int index = this.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                        return index;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void ValidateDateTime(int RowIndex, int ColumnIndex)
        {
            if (this.EditingControl != null)
            {
                DataGridViewCellStyle style = this.Columns[ColumnIndex].DefaultCellStyle;
                if (style.Format == OISGridConstant.DateFormat)
                {
                    DataGridViewCell cell = this.Rows[RowIndex].Cells[ColumnIndex];
                    DateTime? dt = this.EditingControl.Text.ToDateTime();
                    if (cell.ValueType == typeof(DateTime))
                    {
                        if (!dt.HasValue)
                        {
                            dt = DateTime.Now;
                        }
                        this.EditingControl.Text = dt.ToStringDate();
                    }
                    else if (cell.ValueType == typeof(DateTime?))
                    {
                        if (dt.HasValue)
                        {
                            this.EditingControl.Text = dt.ToStringDate();
                        }
                        else
                        {
                            this.EditingControl.Text = "";
                        }
                    }
                }
                else if(style.Format == OISGridConstant.TimeFormat)
                {
                    DataGridViewCell cell = this.Rows[RowIndex].Cells[ColumnIndex];
                    TimeSpan? time = this.EditingControl.Text.ToTime();
                    if (cell.ValueType == typeof(TimeSpan))
                    {
                        if (!time.HasValue)
                        {
                            time = DateTime.Now.TimeOfDay;
                        }
                        this.EditingControl.Text = time.ToStringTime();
                    }
                    else if (cell.ValueType == typeof(TimeSpan?))
                    {
                        if (time.HasValue)
                        {
                            this.EditingControl.Text = time.ToStringTime();
                        }
                        else
                        {
                            this.EditingControl.Text = "";
                        }
                    }
                }
            }
        }
        #endregion

        #region "Event"
        protected override void OnAutoGenerateColumnsChanged(EventArgs e)
        {
            base.OnAutoGenerateColumnsChanged(e);
        }

        protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
        {
            base.OnRowsAdded(e);
            try
            {
                foreach (DataGridViewRow row in this.Rows)
                {
                    row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected override void OnRowsRemoved(DataGridViewRowsRemovedEventArgs e)
        {
            base.OnRowsRemoved(e);
            foreach (DataGridViewRow row in this.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
            }
        }

        #region "Drag n Drop"
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Right)
            {
                var hti = this.HitTest(e.X, e.Y);
                //this.ClearSelection();
                if (hti.RowIndex >= 0)
                {
                    this.Rows[hti.RowIndex].Selected = true;
                }
            }
            else if (e.Button == MouseButtons.Left && this.AllowDrop)
            {
                // Get the index of the item the mouse is below.
                rowIndexFromMouseDown = this.HitTest(e.X, e.Y).RowIndex;
                if (rowIndexFromMouseDown != -1)
                {
                    // Remember the point where the mouse down occurred. 
                    // The DragSize indicates the size that the mouse can move 
                    // before a drag event should be started.                
                    Size dragSize = SystemInformation.DragSize;

                    // Create a rectangle using the DragSize, with the mouse position being
                    // at the center of the rectangle.
                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                                   e.Y - (dragSize.Height / 2)),
                                        dragSize);
                }
                else
                {
                    // Reset the rectangle if the mouse is not over an item in the ListBox.
                    dragBoxFromMouseDown = Rectangle.Empty;
                }
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left && this.AllowDrop)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = this.DoDragDrop(
                    this.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }
        protected override void OnDragOver(DragEventArgs drgevent)
        {
            base.OnDragOver(drgevent);
            if (this.AllowDrop)
            {
                drgevent.Effect = DragDropEffects.Move;
            }
        }
        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            base.OnDragDrop(drgevent);
            if (this.AllowDrop)
            {
                // The mouse locations are relative to the screen, so they must be 
                // converted to client coordinates.
                Point clientPoint = this.PointToClient(new Point(drgevent.X, drgevent.Y));

                // Get the row index of the item the mouse is below. 
                rowIndexOfItemUnderMouseToDrop =
                    this.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

                // If the drag operation was a move then remove and insert the row.
                if (drgevent.Effect == DragDropEffects.Move)
                {
                    DataGridViewRow rowToMove = drgevent.Data.GetData(
                        typeof(DataGridViewRow)) as DataGridViewRow;
                    //this.Rows.RemoveAt(rowIndexFromMouseDown);
                    //this.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                    if (this.DataSource != null)
                    {
                        if (rowIndexOfItemUnderMouseToDrop >= 0 && rowIndexFromMouseDown >= 0)
                        {
                            DataTable dt = this.DataSource as DataTable;
                            if (dt != null)
                            {
                                DataRow dr = dt.Rows[rowIndexFromMouseDown];
                                DataRow dr2 = dt.NewRow();
                                //for (int c = 0; c < dr.Table.Columns.Count; c++)
                                //{
                                //    dr2[c] = dr[c];
                                //}
                                dr2.ItemArray = dr.ItemArray.Clone() as object[];

                                dt.Rows.RemoveAt(rowIndexFromMouseDown);
                                dt.Rows.InsertAt(dr2, rowIndexOfItemUnderMouseToDrop);
                                this.ClearSelection();
                                this.CurrentCell = this.Rows[rowIndexOfItemUnderMouseToDrop].Cells[this.CurrentCell.ColumnIndex];
                                this.Rows[rowIndexOfItemUnderMouseToDrop].Selected = true;
                            }
                        }
                    }

                }
            }
        }
        #endregion

        protected override void OnEditingControlShowing(DataGridViewEditingControlShowingEventArgs e)
        {
            base.OnEditingControlShowing(e);
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                tb = (DataGridViewTextBoxEditingControl)e.Control;
                tb.KeyPress += new KeyPressEventHandler(dataGridView_KeyPress);
            }
            else if(e.Control is CalendarEditingControl)
            {
                cld = (CalendarEditingControl)e.Control;
                cld.KeyPress += new KeyPressEventHandler(dataGridView_KeyPress);
            }
            e.Control.KeyPress += new KeyPressEventHandler(dataGridView_KeyPress);
        }
        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string format = this.Columns[this.CurrentCell.ColumnIndex].DefaultCellStyle.Format;
                if (format.Length > 0)
                {
                    if (format.Substring(0, 1) == "N")
                    {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                        {
                            e.Handled = true;
                        }

                        if (format.Substring(1, 1) == "0")
                        {
                            if (e.KeyChar == '.')
                            {
                                e.Handled = true;
                            }
                        }
                        else
                        {
                            if ((e.KeyChar == '.') && (tb.Text.IndexOf('.') > -1))
                            {
                                e.Handled = true;
                            }
                        }
                    }
                    else if (format == OISGridConstant.DateFormat)
                    {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/') && (e.KeyChar != '-') && (e.KeyChar != '+'))
                        {
                            e.Handled = true;
                        }
                        if ((e.KeyChar == '/') && (tb.Text.Split('/').Length > 3))
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw new Exception("dataGridView_KeyPress");
            }
        }

        protected override void OnCellBeginEdit(DataGridViewCellCancelEventArgs e)
        {
            base.OnCellBeginEdit(e);
            cellBackColor = this.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor;
            this.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightYellow;
        }
        protected override void OnCellEndEdit(DataGridViewCellEventArgs e)
        {
            try
            {
                base.OnCellEndEdit(e);
                this.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = cellBackColor;
            }
            catch(Exception ex)
            {
                throw new Exception("OnCellEndEdit : " + ex.Message);
            }
        }

        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            base.OnCellFormatting(e);
            var formatter = e.CellStyle.FormatProvider as ICustomFormatter;
            if (formatter != null)
            {
                e.Value = formatter.Format(e.CellStyle.Format, e.Value, e.CellStyle.FormatProvider);
                e.FormattingApplied = true;
            }
        }

        protected override void OnCellValidating(DataGridViewCellValidatingEventArgs e)
        {
            base.OnCellValidating(e);
            ValidateDateTime(e.RowIndex, e.ColumnIndex);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            switch(e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                case Keys.Tab:
                    break;
                case Keys.Enter:
                    if (this.CurrentCell != null)
                    {
                        ValidateDateTime(this.CurrentCell.RowIndex, this.CurrentCell.ColumnIndex);
                    }
                    OnKeyDown(e);
                    break;
                default:
                    OnKeyDown(e);
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}
