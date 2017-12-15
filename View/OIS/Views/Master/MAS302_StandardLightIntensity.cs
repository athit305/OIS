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
    public partial class MAS302_StandardLightIntensity : rBaseUC
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

        private MAS302_STDLight_Criteria criteria;
        private SortableBindingList<sp_MAS302_GetSTDLight_Result> stdLightList;
        #endregion

        #region "Constructor"
        public MAS302_StandardLightIntensity()
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

            gvResult.SetColumnNumeric((int)eCol.STANDARD);
            gvResult.SetColumnNumeric((int)eCol.SEQ);
            gvResult.SetColumnDateTime((int)eCol.CRT_DATE);
            gvResult.SetColumnDateTime((int)eCol.UPD_DATE);
            gvResult.SetColumnDateTime((int)eCol.DEL_DATE);

            for (int i = (int)eCol.ID; i <= (int)eCol.DEL_ID; i++)
            {
                gvResult.Columns[i].Visible = false;
            }
        }
        private void LoadData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                criteria = new MAS302_STDLight_Criteria()
                {
                    //AREA_NAME = txtName.TextValue,
                    TYPE_NAME = txtTypeName.TextValue,
                    BUILDING_NAME = txtBuildingName.TextValue,
                    ALIAS_NAME = txtName.TextValue,
                    STANDARD_VALUE = txtStandard.NullableIntValue,
                    SHOW_DELETE_RECORD = chkShowDeleteRecord.Checked,
                };
                stdLightList = vmMas.GetSTDLight(criteria);
                gvResult.DataSource = stdLightList;

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
                using (MAS302_StandardLightIntensityEntry dlg = new MAS302_StandardLightIntensityEntry())
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
                sp_MAS302_GetSTDLight_Result row = gvResult.Rows[e.RowIndex].DataBoundItem as sp_MAS302_GetSTDLight_Result;
                using (MAS302_StandardLightIntensityEntry dlg = new MAS302_StandardLightIntensityEntry(row))
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
            txtName.Text = txtTypeName.Text = txtBuildingName.Text = null;
            txtStandard.NullableIntValue = null;
            chkShowDeleteRecord.Checked = false;
            gvResult.DataSource = null;
            gvResult.Rows.Clear();
        }
        #endregion

        #region "Event"
        private void MAS302_StandardLightIntensity_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS302_StandardLightIntensity_OnNew(object sender, EventArgs e)
        {
            AddNew();
        }

        private void MAS302_StandardLightIntensity_OnSearch(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MAS302_StandardLightIntensity_OnClear(object sender, EventArgs e)
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
