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
    public partial class StandardLightDialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {
            ALIAS_NAME,
            ALIAS_NAME_EN,
            STANDARD,
            TYPE_NAME,
            BUILDING_NAME,
            NAME,
        }
        #endregion

        #region "Variable"
        MasterViewModel vmMas = new MasterViewModel();
        SearchViewModel vmSearch = new SearchViewModel();

        private SortableBindingList<sp_MAS302_GetSTDLight_Result> stdList;
        private int id;

        public sp_MAS302_GetSTDLight_Result SelectedData;
        public int RowCount
        {
            get
            {
                return gvDetail.RowCount;
            }
        }
        #endregion

        #region "Constructor"
        public StandardLightDialog(string strSearch)
        {
            InitializeComponent();
            InitialScreen(strSearch);
        }
        public StandardLightDialog(int ID)
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

                gvDetail.SetColumnNumeric((int)eCol.STANDARD);

                stdList = vmMas.GetSTDLight(new MAS302_STDLight_Criteria());

                SortableBindingList<sp_MAS302_GetSTDLight_Result> result = new SortableBindingList<sp_MAS302_GetSTDLight_Result>();
                result.AddRange(stdList);

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
        private void StandardLightDialog_Load(object sender, EventArgs e)
        {
            ActiveControl = txtSearch;
        }

        private void gvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    SelectedData = gvDetail.GetDataBound(e.RowIndex) as sp_MAS302_GetSTDLight_Result;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text.ToUpper();
            var result = stdList.Where(x => x.ALIAS_NAME.GetValueOrDefault().ToUpper().Contains(txt) || x.NAME.GetValueOrDefault().ToUpper().Contains(txt) || x.TYPE_NAME.GetValueOrDefault().ToUpper().Contains(txt) || x.BUILDING_NAME.GetValueOrDefault().ToUpper().Contains(txt) || x.STANDARD.ToString().Contains(txt)).ToList();
            gvDetail.DataSource = new SortableBindingList<sp_MAS302_GetSTDLight_Result>(result);

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
