﻿using OIS.BaseViews;
using OIS.Common.Extensions;
using OIS.Common.Utils;
using OIS.RPT.DTO;
using OIS.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIS.Views.Report
{
    public partial class RPT002_WorkPlaceAirQuality_User_Dialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {
            ID,
            SAMPLING_BY,
        }
        #endregion

        #region "Variable"
        private ComboViewModel vmCombo = new ComboViewModel();
        private DataTable data;
        #endregion

        #region "Constructor"
        public RPT002_WorkPlaceAirQuality_User_Dialog(DataTable dataList)
        {
            try
            {
                InitializeComponent();
                this.data = dataList;
                this.InitialScreen();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            gvDetail.SetOISStyle(true);
            gvDetail.MappingEnum(typeof(eCol));

            gvDetail.SetColumnComboBox((int)eCol.SAMPLING_BY, vmCombo.GetComboUser(), DataGridViewComboBoxDisplayStyle.Nothing);
            gvDetail.DataSource = this.data;
        }
        #endregion

        #region "Event"
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSearch.StringValue != null)
            {
                DataRow dr = this.data.NewRow();
                dr[(int)eCol.SAMPLING_BY] = txtSearch.StringValue;
                this.data.Rows.Add(dr);
                txtSearch.StringValue = null;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.data.Rows.Count > 0 && gvDetail.SelectedRowIndex >= 0)
            {
                this.data.Rows.RemoveAt(gvDetail.SelectedRowIndex);
            }
        }
        #endregion
    }
}
