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
    public partial class MAS309_ToolAnalysis : rBaseUC
    {
        #region "Enum"
        private enum eCol
        {
            NAME,
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

        SortableBindingList<sp_MAS309_GetToolAnalysis_Result> dataList = new SortableBindingList<sp_MAS309_GetToolAnalysis_Result>();
        private MAS309_ToolAnalysis_Criteria Criteria = new MAS309_ToolAnalysis_Criteria();
        #endregion

        #region "Constructor"
        public MAS309_ToolAnalysis()
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

            gvResult.SetColumnNumeric((int)eCol.SEQ, 0);
            gvResult.SetColumnDateTime((int)eCol.CRT_DATE);
            gvResult.SetColumnDateTime((int)eCol.UPD_DATE);
            gvResult.SetColumnDateTime((int)eCol.DEL_DATE);

            for (int i = (int)eCol.ID; i <= (int)eCol.DEL_ID; i++)
            {
                gvResult.Columns[i].Visible = false;
            }

            bdSource.DataSource = Criteria;
        }
        private void LoadData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                bdSource.EndEdit();
                dataList = vmMas.GetToolAnalysis(Criteria);
                gvResult.DataSource = dataList;

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
                using (MAS309_ToolAnalysisEntry dlg = new MAS309_ToolAnalysisEntry())
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void EditData(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                sp_MAS309_GetToolAnalysis_Result row = gvResult.Rows[e.RowIndex].DataBoundItem as sp_MAS309_GetToolAnalysis_Result;
                using (MAS309_ToolAnalysisEntry dlg = new MAS309_ToolAnalysisEntry(row))
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
            Criteria = new MAS309_ToolAnalysis_Criteria();
            bdSource.DataSource = Criteria;
            gvResult.DataSource = null;
            gvResult.Rows.Clear();
        }
        #endregion

        #region "Event"
        private void MAS309_ToolAnalysis_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS309_ToolAnalysis_OnNew(object sender, EventArgs e)
        {
            AddNew();
        }
        private void MAS309_ToolAnalysis_OnSearch(object sender, EventArgs e)
        {
            LoadData();
        }
        private void MAS309_ToolAnalysis_OnClear(object sender, EventArgs e)
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
