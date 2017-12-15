using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.BaseViews;
using OIS.Definition;
using OIS.Common;
using OIS.Common.Extensions;
using OIS.Common.Utils;
using OIS.MAS.DTO;
using OIS.MAS.DTO.Criteria;
using OIS.ViewModel;

namespace OIS.Views
{
    public partial class MAS101_User : rBaseUC
    {
        #region "Enum"
        private enum eCol
        {
            ID,
            FULLNAME_EN,
            FULLNAME_TH,
            NICKNAME,
            DIVISION_NAME,
            SUBDIVISION_NAME,
            POSITION_NAME,
            GROUP_NAME,
            BIRTHDATE,
            STARTDATE,
            CRT_NAME,
            CRT_DATE,
            CRT_MACHINE,
            UPD_NAME,
            UPD_DATE,
            UPD_MACHINE,
            DEL_NAME,
            DEL_DATE,
            DEL_MACHINE,
            PRENAME_ID,
            FNAME_EN,
            LNAME_EN,
            FNAME_TH,
            LNAME_TH,
            DIVISION_ID,
            SUBDIVISION_ID,
            POSITION_ID,
            GROUP_ID,
            PASS,
            CRT_ID,
            UPD_ID,
            DEL_ID,
        }
        #endregion

        #region "Variable"
        private MAS101_User_Criteria criteria;

        private MasterViewModel vmMas = new MasterViewModel();
        private ComboViewModel vmCombo = new ComboViewModel();

        SortableBindingList<sp_MAS101_GetUser_Result> UserList;
        #endregion

        #region "Constructor"
        public MAS101_User()
        {
            InitializeComponent();

        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            this.ToolBarSwitch = "1212221221";

            cboDivision.SetDataSource(vmCombo.GetComboDivision(), true);
            cboSubDivision.SetDataSource(vmCombo.GetComboSubDivision(cboDivision.NullableIntValue.GetValueOrDefault()), true);
            cboPosition.SetDataSource(vmCombo.GetComboPosition(), true);
            cboGroup.SetDataSource(vmCombo.GetComboGroup(), true);

            gvResult.SetOISStyle();
            gvResult.MappingEnum(typeof(eCol));

            gvResult.SetColumnText((int)eCol.ID);
            gvResult.SetColumnText((int)eCol.FULLNAME_EN);
            gvResult.SetColumnText((int)eCol.FULLNAME_TH);
            gvResult.SetColumnText((int)eCol.NICKNAME);
            gvResult.SetColumnText((int)eCol.DIVISION_NAME);
            gvResult.SetColumnText((int)eCol.SUBDIVISION_NAME);
            gvResult.SetColumnText((int)eCol.POSITION_NAME);
            gvResult.SetColumnText((int)eCol.GROUP_NAME);
            gvResult.SetColumnDate((int)eCol.BIRTHDATE);
            gvResult.SetColumnDate((int)eCol.STARTDATE);
            gvResult.SetColumnDateTime((int)eCol.CRT_DATE);
            gvResult.SetColumnDateTime((int)eCol.UPD_DATE);
            gvResult.SetColumnDateTime((int)eCol.DEL_DATE);

            for (int i = (int)eCol.PRENAME_ID; i<=(int)eCol.DEL_ID;i++)
            {
                gvResult.Columns[i].Visible = false;
            }

        }
        private void LoadData()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                criteria = new MAS101_User_Criteria()
                {
                    ID = txtID.GetValue(),
                    NAME = txtName.GetValue(),
                    DIVISION_ID = cboDivision.NullableIntValue,
                    SUBDIVISION_ID = cboSubDivision.NullableIntValue,
                    POSITION_ID = cboPosition.NullableIntValue,
                    GROUP_ID = cboGroup.NullableIntValue,
                    SHOW_DELETE_RECORD = chkShowDeleteRecord.Checked,
                };
                UserList = vmMas.GetUser(criteria);
                gvResult.DataSource = UserList;

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
            MAS101_UserEntry dlg = new MAS101_UserEntry();
            if(dlg.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void ClearScreen()
        {
            txtID.Text = txtName.Text = null;
            cboDivision.NullableIntValue = cboSubDivision.NullableIntValue = cboPosition.NullableIntValue = cboGroup.NullableIntValue = null;
            chkShowDeleteRecord.Checked = false;
            gvResult.DataSource = null;
            gvResult.Rows.Clear();
        }
        #endregion

        #region "Event"
        private void MAS101_User_Load(object sender, EventArgs e)
        {
            this.InitialScreen();
        }
        private void MAS101_User_OnNew(object sender, EventArgs e)
        {
            this.AddNew();
        }
        private void MAS101_User_OnSearch(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void MAS101_User_OnExport(object sender, EventArgs e)
        {

        }
        private void MAS101_User_OnClear(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void cboDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSubDivision.SetDataSource(vmCombo.GetComboSubDivision(cboDivision.NullableIntValue.GetValueOrDefault()), true);
        }

        private void gvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                sp_MAS101_GetUser_Result user = gvResult.Rows[e.RowIndex].DataBoundItem as sp_MAS101_GetUser_Result;
                MAS101_UserEntry dlg = new MAS101_UserEntry(user);
                if(dlg.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
        #endregion
    }
}
