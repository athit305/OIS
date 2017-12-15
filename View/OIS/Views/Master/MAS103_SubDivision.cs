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
    public partial class MAS103_SubDivision : rBaseUC
    {
        #region "Enum"
        private enum eCol
        {
            NAME_EN,
            NAME_TH,
            DIVISION_NAME,
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
            DIVISION_ID,
            CRT_ID,
            UPD_ID,
            DEL_ID,
        }
        #endregion

        #region "Variable"
        MasterViewModel vmMas = new MasterViewModel();
        ComboViewModel vmCombo = new ComboViewModel();

        private SortableBindingList<sp_MAS103_GetSubDivision_Result> subdivisionList;
        #endregion

        #region "Constructor"
        public MAS103_SubDivision()
        {
            InitializeComponent();
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            this.ToolBarSwitch = "1212221221";

            cboDivision.SetDataSource(vmCombo.GetComboDivision(), true);

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
                subdivisionList = vmMas.GetSubDivision(cboDivision.NullableIntValue, txtName.TextValue, chkShowDeleteRecord.Checked);
                gvResult.DataSource = subdivisionList;

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
                using (MAS103_SubDivisionEntry dlg = new MAS103_SubDivisionEntry())
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
                sp_MAS103_GetSubDivision_Result row = gvResult.Rows[e.RowIndex].DataBoundItem as sp_MAS103_GetSubDivision_Result;
                using (MAS103_SubDivisionEntry dlg = new MAS103_SubDivisionEntry(row))
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
            cboDivision.NullableIntValue = null;
            chkShowDeleteRecord.Checked = false;
            gvResult.DataSource = null;
            gvResult.Rows.Clear();
        }
        #endregion

        #region "Event"
        private void MAS103_SubDivision_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS103_SubDivision_OnNew(object sender, EventArgs e)
        {
            AddNew();
        }

        private void MAS103_SubDivision_OnSearch(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MAS103_SubDivision_OnClear(object sender, EventArgs e)
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
