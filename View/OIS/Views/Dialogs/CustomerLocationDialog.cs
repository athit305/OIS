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
    public partial class CustomerLocationDialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {
            CUSTOMER_NAME,
            LOC_NAME_LV3,
            LOC_NAME_LV2,
            LOC_NAME,
            CUSTOMER_ID,
            TOTAL,
        }
        #endregion

        #region "Variable"
        MasterViewModel vmMas = new MasterViewModel();

        private SortableBindingList<sp_MAS_DialogCustomerLocation_Result> clocList;
        private int id;

        public sp_MAS_DialogCustomerLocation_Result SelectedData;
        public int RowCount
        {
            get
            {
                return gvDetail.RowCount;
            }
        }
        #endregion

        #region "Constructor"
        public CustomerLocationDialog(string strSearch)
        {
            InitializeComponent();
            InitialScreen(strSearch);
        }
        public CustomerLocationDialog(int ID)
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

                gvDetail.SetColumnNumeric((int)eCol.TOTAL);
                gvDetail.SetColumnNumeric((int)eCol.CUSTOMER_ID);

                gvDetail.Columns[(int)eCol.TOTAL].Visible = false;
                gvDetail.Columns[(int)eCol.CUSTOMER_ID].Visible = false;

                clocList = vmMas.GetCustomerLocation(id);

                SortableBindingList<sp_MAS_DialogCustomerLocation_Result> result = new SortableBindingList<sp_MAS_DialogCustomerLocation_Result>();
                result.AddRange(clocList);

                gvDetail.DataSource = result;

                txtSearch.Text = strSearch;
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
            if (e.RowIndex >= 0)
            {
                SelectedData = gvDetail.GetDataBound(e.RowIndex) as sp_MAS_DialogCustomerLocation_Result;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text.ToUpper();
            var result = clocList.Where(x => x.LOC_NAME_LV3.GetValueOrDefault().ToUpper().Contains(txt) || x.LOC_NAME_LV2.GetValueOrDefault().ToUpper().Contains(txt) || x.LOC_NAME.GetValueOrDefault().ToUpper().Contains(txt)).ToList();
            gvDetail.DataSource = new SortableBindingList<sp_MAS_DialogCustomerLocation_Result>(result);

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
