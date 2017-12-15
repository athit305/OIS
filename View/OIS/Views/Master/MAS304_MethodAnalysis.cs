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
    public partial class MAS304_MethodAnalysis : rBaseUC
    {
        #region "Enum"
        private enum eCol
        {
            NAME,
            INSTITUTION_STD_NAME,
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
        private SortableBindingList<sp_MAS304_GetMethodAnalysis_Result> methodList;
        private MAS304_MethodAnalysis_Criteria criteria = new MAS304_MethodAnalysis_Criteria();
        #endregion

        #region "Constructor"
        public MAS304_MethodAnalysis()
        {
            InitializeComponent();
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            this.ToolBarSwitch = "1212221221";

            cboInstitution.SetDataSource(vmCombo.GetComboInstitutionSTD(), true);

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

            bdSource.DataSource = criteria;
        }
        private void LoadData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bdSource.EndEdit();
                methodList = vmMas.GetMethodAnalysis(bdSource.DataSource as MAS304_MethodAnalysis_Criteria);
                gvResult.DataSource = methodList;

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
                using (MAS304_MethodAnalysisEntry dlg = new MAS304_MethodAnalysisEntry())
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
                sp_MAS304_GetMethodAnalysis_Result row = gvResult.Rows[e.RowIndex].DataBoundItem as sp_MAS304_GetMethodAnalysis_Result;
                using (MAS304_MethodAnalysisEntry dlg = new MAS304_MethodAnalysisEntry(row))
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
            criteria = new MAS304_MethodAnalysis_Criteria();
            bdSource.DataSource = criteria;
            gvResult.DataSource = null;
            gvResult.Rows.Clear();
        }
        #endregion

        #region "Event"
        private void MAS304_MethodAnalysis_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS304_MethodAnalysis_OnNew(object sender, EventArgs e)
        {
            AddNew();
        }

        private void MAS304_MethodAnalysis_OnSearch(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MAS304_MethodAnalysis_OnClear(object sender, EventArgs e)
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
