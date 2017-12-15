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
using OIS.Common;
using OIS.Common.Extensions;
using OIS.MAS.DTO;
using OIS.ViewModel;

namespace OIS.Views
{
    public partial class MAS104_Position : rBaseUC
    {
        #region "Enum"
        private enum eCol
        {
            NAME_EN,
            NAME_TH,
            SEQ,
            CRT_FULLNAME,
            CRT_DATE,
            CRT_MACHINE,
            UPD_FULLNAME,
            UPD_DATE,
            UPD_MACHINE,
            DEL_FULLNAME,
            DEL_DATE,
            DEL_MACHINE,
            ID,
            CRT_ID,
            UPD_ID,
            DEL_ID,
            DELETEFLAG,
        }
        #endregion

        #region "Variable"
        MasterViewModel vmMas = new MasterViewModel();

        private SortableBindingList<sp_MAS104_GetPosition_Result> positionList;
        #endregion

        #region "Constructor"
        public MAS104_Position()
        {
            InitializeComponent();
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            this.ToolBarSwitch = "1212221221";

            gvResult.SetOISStyle();
            gvResult.MappingEnum(typeof(eCol));

            gvResult.SetColumnNumeric((int)eCol.SEQ);
            gvResult.SetColumnDateTime((int)eCol.CRT_DATE);
            gvResult.SetColumnDateTime((int)eCol.UPD_DATE);
            gvResult.SetColumnDateTime((int)eCol.DEL_DATE);

            for (int i = (int)eCol.ID; i <= (int)eCol.DEL_ID; i++)
            {
                gvResult.Columns[i].Visible = false;
            }
        }
        private void LoadData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                positionList = vmMas.GetPosition(txtName.TextValue, chkShowDeleteRecord.Checked);
                gvResult.DataSource = positionList;

                gvResult.SetRowDeletedStyle((int)eCol.DEL_ID);
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
                using (MAS104_PositionEntry dlg = new MAS104_PositionEntry())
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

            if (e.RowIndex >= 0)
            {
                sp_MAS104_GetPosition_Result row = gvResult.Rows[e.RowIndex].DataBoundItem as sp_MAS104_GetPosition_Result;
                using (MAS104_PositionEntry dlg = new MAS104_PositionEntry(row))
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }
        private void ClearScreen()
        {
            txtName.Text = null;
            chkShowDeleteRecord.Checked = false;
            gvResult.DataSource = null;
            gvResult.Rows.Clear();
        }
        #endregion

        #region "Event"
        private void MAS104_Position_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS104_Position_OnNew(object sender, EventArgs e)
        {
            AddNew();
        }

        private void MAS104_Position_OnSearch(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MAS104_Position_OnClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void gvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditData(e);
        }
        #endregion
    }
}
