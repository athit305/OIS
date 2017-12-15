using OIS.BaseViews;
using OIS.Common;
using OIS.Common.Extensions;
using OIS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIS.Views.Dialogs
{
    public enum eHelpType
    {
        LightCondition,
    }
    public partial class HelpFillDataDialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {
            IS_SELECT,
            CODE,
            DATA_VALUE,
        }
        #endregion

        #region "Variable"
        private DataTable _dt;
        private string _separate;
        private string _selectedText;

        private MasterViewModel vmMas = new MasterViewModel();

        public string SelectedText
        {
            get
            {
                return _selectedText;
            }
        }
        #endregion

        #region "Constructor"
        public HelpFillDataDialog(eHelpType type, string separate = ",")
        {
            InitializeComponent();
            this._separate = separate;

            this.gvDetail.SetOISStyle(DataGridViewEditMode.EditOnEnter);
            this.gvDetail.MappingEnum(typeof(eCol));

            this.gvDetail.Columns[(int)eCol.IS_SELECT].ReadOnly = false;
            this.gvDetail.Columns[(int)eCol.CODE].ReadOnly = true;
            this.gvDetail.Columns[(int)eCol.DATA_VALUE].ReadOnly = true;

            this.LoadData(type);
        }
        #endregion

        #region "Customize"
        private void LoadData(eHelpType type)
        {
            try
            {
                this._dt = vmMas.GetConditionReportWPLDialog();
                this.gvDetail.DataSource = this._dt;
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        #endregion

        #region "Event"
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFilter.TextValue != null)
                {
                    (gvDetail.DataSource as DataTable).DefaultView.RowFilter = string.Format("DATA_VALUE LIKE '*{0}*' OR CODE LIKE '*{0}*'", txtFilter.Text);
                }
                else
                {
                    (gvDetail.DataSource as DataTable).DefaultView.RowFilter = "";
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedText = "";
                for (int r = 0; r < gvDetail.RowCount; r++)
                {
                    if (gvDetail.GetBooleanValue(r, (int)eCol.IS_SELECT))
                    {
                        if(_selectedText != "")
                        {
                            _selectedText = _selectedText + this._separate;
                        }
                        _selectedText = _selectedText + gvDetail.GetStringValue(r, (int)eCol.DATA_VALUE);
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }

        private void gvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedText = this.gvDetail.GetStringValue(e.RowIndex, (int)eCol.DATA_VALUE);
            this.DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
