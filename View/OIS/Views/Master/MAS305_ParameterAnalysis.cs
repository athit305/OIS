using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using OIS.MAS.DTO.Criteria;
using OIS.ViewModel;

namespace OIS.Views
{
    public partial class MAS305_ParameterAnalysis : rBaseUC
    {
        #region "Enum"
        private enum eCol
        {
            NAME,
            METHOD_NAME,
            UNIT_NAME,
            STANDARD_THAI,
            STANDARD_ACGIH,
            TOOL_PICK_NAME,
            TOOL_ANALYSIS_NAME,
            SEQ,
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
        private MasterViewModel vmMas = new MasterViewModel();
        private ComboViewModel vmCombo = new ComboViewModel();
        private SortableBindingList<sp_MAS305_GetParameterAnalysis_Result> paramList;
        private MAS305_ParameterAnalysis_Criteria criteria = new MAS305_ParameterAnalysis_Criteria();
        #endregion

        #region "Constructor"
        public MAS305_ParameterAnalysis()
        {
            InitializeComponent();
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            this.ToolBarSwitch = "1212221221";

            cboUnit.SetDataSource(vmCombo.GetComboUnit(), true);

            gvResult.SetOISStyle();
            gvResult.MappingEnum(typeof(eCol));

            gvResult.SetColumnNumeric((int)eCol.STANDARD_THAI, 2);
            gvResult.SetColumnNumeric((int)eCol.STANDARD_ACGIH, 2);
            gvResult.SetColumnNumeric((int)eCol.SEQ);
            gvResult.SetColumnDateTime((int)eCol.CRT_DATE);
            gvResult.SetColumnDateTime((int)eCol.UPD_DATE);
            gvResult.SetColumnDateTime((int)eCol.DEL_DATE);

            for (int i = (int)eCol.ID; i <= (int)eCol.DEL_ID; i++)
            {
                gvResult.Columns[i].Visible = false;
            }

            bdSource.DataSource = criteria;
        }
        private void LoadData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bdSource.EndEdit();
                paramList = vmMas.GetParameterAnalysis(bdSource.DataSource as MAS305_ParameterAnalysis_Criteria);
                gvResult.DataSource = paramList;

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
                using (MAS305_ParameterAnalysisEntry dlg = new MAS305_ParameterAnalysisEntry())
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
                sp_MAS305_GetParameterAnalysis_Result row = gvResult.Rows[e.RowIndex].DataBoundItem as sp_MAS305_GetParameterAnalysis_Result;
                using (MAS305_ParameterAnalysisEntry dlg = new MAS305_ParameterAnalysisEntry(row))
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
            criteria = new MAS305_ParameterAnalysis_Criteria();
            txtMethod.Text = txtToolAnalysis.Text = txtToolPick.Text = null;
            bdSource.DataSource = criteria;
            gvResult.DataSource = null;
            gvResult.Rows.Clear();
        }
        #endregion

        #region "Event"
        private void MAS305_ParameterAnalysis_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS305_ParameterAnalysis_OnNew(object sender, EventArgs e)
        {
            AddNew();
        }

        private void MAS305_ParameterAnalysis_OnSearch(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MAS305_ParameterAnalysis_OnClear(object sender, EventArgs e)
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
