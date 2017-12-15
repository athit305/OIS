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
    public partial class ProjectDialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {
            NAME_TH,
            NAME_EN,
            ADDR_TH,
            ADDR_EN,
        }
        #endregion

        #region "Variable"
        MasterViewModel vmMas = new MasterViewModel();
        SearchViewModel vmSearch = new SearchViewModel();

        private SortableBindingList<sp_MAS202_GetCustomerProject_Result> custPList;
        private int id;

        public sp_MAS202_GetCustomerProject_Result SelectedData;
        public int RowCount
        {
            get
            {
                return gvDetail.RowCount;
            }
        }
        #endregion

        #region "Constructor"
        public ProjectDialog(string strSearch)
        {
            InitializeComponent();
            InitialScreen(strSearch);
        }
        public ProjectDialog(int ID)
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

                custPList = vmMas.GetCustomerProject();

                List<sp_MAS202_GetCustomerProject_Result> result = new List<sp_MAS202_GetCustomerProject_Result>();
                result.AddRange(custPList);

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
            if (e.RowIndex >= 0)
            {
                SelectedData = gvDetail.GetDataBound(e.RowIndex) as sp_MAS202_GetCustomerProject_Result;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text.ToUpper();
            var result = custPList.Where(x => x.NAME_TH.Contains(txt) || x.NAME_EN.ToUpper().Contains(txt) || x.ADDR_TH.ToString().Contains(txt) || x.ADDR_EN.ToUpper().ToString().Contains(txt)).ToList();
            gvDetail.DataSource = new SortableBindingList<sp_MAS202_GetCustomerProject_Result>(result);

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
