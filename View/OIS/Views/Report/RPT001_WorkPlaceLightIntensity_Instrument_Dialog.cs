using OIS.BaseViews;
using OIS.Common;
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
    public partial class RPT001_WorkPlaceLightIntensity_Instrument_Dialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {
            ID,
            MEASURED_INSTRUMENT_ID,
        }
        #endregion

        #region "Variable"
        private ComboViewModel vmCombo = new ComboViewModel();
        private DataTable data;
        #endregion

        #region "Constructor"
        public RPT001_WorkPlaceLightIntensity_Instrument_Dialog(DataTable dataList)
        {
            InitializeComponent();
            this.data = dataList;
            this.InitialScreen();
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            gvDetail.SetOISStyle(true);
            gvDetail.MappingEnum(typeof(eCol));

            gvDetail.SetColumnComboBox((int)eCol.MEASURED_INSTRUMENT_ID, vmCombo.GetComboInstrument(), DataGridViewComboBoxDisplayStyle.Nothing);
            gvDetail.DataSource = this.data;
        }
        #endregion

        #region "Event"
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSearch.IntValue != null)
            {
                DataRow dr = this.data.NewRow();
                dr[(int)eCol.MEASURED_INSTRUMENT_ID] = txtSearch.IntValue;
                this.data.Rows.Add(dr);
                txtSearch.IntValue = null;
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
