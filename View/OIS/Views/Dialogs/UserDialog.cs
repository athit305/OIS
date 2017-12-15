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
    public partial class UserDialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {
            ID,
            FULLNAME_TH,
            DIVISION_NAME,
            SUBDIVISION_NAME,
            POSITION_NAME,
        }
        #endregion

        #region "Variable"
        MasterViewModel vmMas = new MasterViewModel();
        SearchViewModel vmSearch = new SearchViewModel();

        private SortableBindingList<sp_MAS101_GetUser_Result> userList;

        public sp_MAS101_GetUser_Result SelectedData;
        public int RowCount
        {
            get
            {
                return gvDetail.RowCount;
            }
        }
        #endregion

        #region "Constructor"
        public UserDialog(string strSearch)
        {
            InitializeComponent();
            InitialScreen(strSearch);
        }
        #endregion

        #region "Customize"
        public void InitialScreen(string strSearch)
        {
            try
            {
                gvDetail.SetOISStyle();
                gvDetail.MappingEnum(typeof(eCol));

                userList = vmMas.GetUser();

                SortableBindingList<sp_MAS101_GetUser_Result> result = new SortableBindingList<sp_MAS101_GetUser_Result>();
                result.AddRange(userList);

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
                SelectedData = gvDetail.GetDataBound(e.RowIndex) as sp_MAS101_GetUser_Result;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text.ToUpper();
            var result = userList.Where(x => x.FULLNAME_TH.Contains(txt) || x.FULLNAME_EN.ToUpper().Contains(txt) || x.DIVISION_NAME.ToUpper().Contains(txt) || x.SUBDIVISION_NAME.ToUpper().Contains(txt) || x.POSITION_NAME.ToUpper().Contains(txt) || x.ID.ToString().Contains(txt)).ToList();
            gvDetail.DataSource = new SortableBindingList<sp_MAS101_GetUser_Result>(result);

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
