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
    public partial class MethodAnalysisDialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {
            NAME,
            INSTITUTION_STD_NAME,
        }
        #endregion

        #region "Variable"
        MasterViewModel vmMas = new MasterViewModel();
        SearchViewModel vmSearch = new SearchViewModel();

        private SortableBindingList<sp_MAS304_GetMethodAnalysis_Result> methodList;
        private int id;

        public sp_MAS304_GetMethodAnalysis_Result SelectedData;
        public int RowCount
        {
            get
            {
                return gvDetail.RowCount;
            }
        }
        #endregion

        #region "Constructor"
        public MethodAnalysisDialog(string strSearch)
        {
            InitializeComponent();
            InitialScreen(strSearch);
        }
        public MethodAnalysisDialog(int ID)
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

                methodList = vmMas.GetMethodAnalysis();

                SortableBindingList<sp_MAS304_GetMethodAnalysis_Result> result = new SortableBindingList<sp_MAS304_GetMethodAnalysis_Result>();
                result.AddRange(methodList);

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
        private void MethodAnalysisDialog_Load(object sender, EventArgs e)
        {
            ActiveControl = txtSearch;
        }

        private void gvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedData = gvDetail.CurrentDataBound as sp_MAS304_GetMethodAnalysis_Result;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text.ToUpper();
            var result = methodList.Where(x => x.NAME.ToUpper().Contains(txt) || x.INSTITUTION_STD_NAME.GetValueOrDefault().ToUpper().Contains(txt)).ToList();
            gvDetail.DataSource = new SortableBindingList<sp_MAS304_GetMethodAnalysis_Result>(result);

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
