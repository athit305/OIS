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
using OIS.MAS.DTO;
using OIS.MAS.DTO.Criteria;
using OIS.ViewModel;

namespace OIS.Views.Dialogs
{
    public partial class ParameterAnalysisDialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {
            NAME,
            METHOD_NAME,
            METHOD_REF,
            TOOL_PICK_NAME,
            TOOL_ANALYSIS_NAME,
        }
        #endregion

        #region "Variable"
        MasterViewModel vmMas = new MasterViewModel();
        SearchViewModel vmSearch = new SearchViewModel();

        private SortableBindingList<sp_MAS305_GetParameterAnalysis_Result> dataList;
        private int id;

        public sp_MAS305_GetParameterAnalysis_Result SelectedData;
        public int RowCount
        {
            get
            {
                return gvDetail.RowCount;
            }
        }
        #endregion

        #region "Constructor"
        public ParameterAnalysisDialog(string strSearch)
        {
            InitializeComponent();
            InitialScreen(strSearch);
        }
        public ParameterAnalysisDialog(int ID)
        {
            InitializeComponent();
            id = ID;
            InitialScreen(null);
        }
        #endregion

        #region "Customize"
        public void InitialScreen(string strSearch)
        {
            try
            {
                gvDetail.SetOISStyle();
                gvDetail.MappingEnum(typeof(eCol));

                dataList = vmMas.GetParameterAnalysis();

                SortableBindingList<sp_MAS305_GetParameterAnalysis_Result> result = new SortableBindingList<sp_MAS305_GetParameterAnalysis_Result>();
                result.AddRange(dataList);

                gvDetail.DataSource = result;

                txtSearch.Text = strSearch;

                if (id > 0)
                {
                    SelectedData = result.Where(x => x.ID == id).FirstOrDefault();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Event"
        private void ParameterAnalysisDialog_Load(object sender, EventArgs e)
        {
            ActiveControl = txtSearch;
        }

        private void gvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedData = gvDetail.CurrentDataBound as sp_MAS305_GetParameterAnalysis_Result;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text.ToUpper();
            var result = dataList.Where(x => x.NAME.ToUpper().Contains(txt) || x.METHOD_NAME.GetValueOrDefault().ToUpper().Contains(txt) || x.TOOL_PICK_NAME.GetValueOrDefault().ToUpper().Contains(txt) || x.TOOL_ANALYSIS_NAME.GetValueOrDefault().ToUpper().Contains(txt) || x.METHOD_REF.GetValueOrDefault().ToUpper().Contains(txt)).ToList();
            gvDetail.DataSource = new SortableBindingList<sp_MAS305_GetParameterAnalysis_Result>(result);

            if(result.Count == 1)
            {
                SelectedData = result[0];
            }
            else
            {
                SelectedData = null;
            }
        }
        #endregion
    }
}
