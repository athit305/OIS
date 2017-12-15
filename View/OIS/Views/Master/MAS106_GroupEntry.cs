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
using OIS.ViewModel;

namespace OIS.Views
{
    public partial class MAS106_GroupEntry : rBaseDialog
    {
        #region "Enum"
        private enum eCol
        {
            MENU_NAME,
            PARENT_NAME,
            IS_ALLOW,
            MENU_ID,
        }
        private enum eColUser
        {
            USER_ID,
            FULLNAME,
            POSITION_NAME,
        }
        #endregion

        #region "Variable"
        private MasterViewModel vmMas = new MasterViewModel();

        private GroupDTO groupResult;
        #endregion

        #region "Constructor"
        public MAS106_GroupEntry()
        {
            InitializeComponent();
        }
        public MAS106_GroupEntry(sp_MAS106_GetGroup_Result data)
        {
            InitializeComponent();
            groupResult = new GroupDTO()
            {
                ID = data.ID,
                DEL_ID = data.DEL_ID,
            };
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            try
            {
                gvPermission.SetOISStyle(DataGridViewEditMode.EditOnF2);
                gvPermission.MappingEnum(typeof(eCol));
                gvPermission.Columns[(int)eCol.MENU_ID].Visible = false;
                gvPermission.Columns[(int)eCol.MENU_NAME].ReadOnly = true;
                gvPermission.Columns[(int)eCol.PARENT_NAME].ReadOnly = true;

                gvUser.SetOISStyle();
                gvUser.MappingEnum(typeof(eColUser));


                SetControlToValidate(txtNameTh, txtNameEn, txtSeq);

                RetriveData();
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void RetriveData()
        {
            try
            {
                if (groupResult == null)
                {
                    groupResult = new GroupDTO();
                    groupResult.CRT_DATE = DateTime.Now;
                    groupResult.Permission = vmMas.GetGroupPermission(groupResult.ID);
                    this.ToolBarSwitch = "2122222222";
                }
                else if (groupResult.DEL_ID.IsNull())
                {
                    this.ToolBarSwitch = "2122222102";
                    groupResult = vmMas.GetGroup(groupResult.ID);
                }
                else
                {
                    this.ToolBarSwitch = "2022222012";
                    groupResult = vmMas.GetGroup(groupResult.ID);
                }

                CtrlUtil.EnableControls(groupResult.DEL_ID.IsNull(), txtNameTh, txtNameEn, txtSeq);

                bs.DataSource = groupResult;
                gvPermission.DataSource = groupResult.Permission;
                gvUser.DataSource = groupResult.User;
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private bool ValidateBeforeSave()
        {

            try
            {
                gbMain.Focus();
                bs.EndEdit();

                if (!ValidateControl())
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                return false;
            }
        }
        private void SaveData()
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (ValidateBeforeSave())
                {
                    if (rMessageBox.ShowConfirmation(this, MessageCode.CFM0001) == DialogResult.Yes)
                    {
                        int ID = vmMas.SaveGroup(groupResult);
                        rMessageBox.ShowInfomation(this, MessageCode.INF0002);
                        this.IsDataChange = true;
                        groupResult = vmMas.GetGroup(ID);
                        RetriveData();
                    }
                }
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
        private void CancelData(bool isCancel)
        {

            try
            {
                string msg;
                if (isCancel)
                {
                    msg = MessageCode.CFM0003;
                }
                else
                {
                    msg = MessageCode.CFM0004;
                }
                if (rMessageBox.ShowConfirmation(this, msg) == DialogResult.Yes)
                {
                    vmMas.CancelGroup(groupResult, isCancel);
                    if (isCancel)
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0004);
                    }
                    else
                    {
                        rMessageBox.ShowInfomation(this, MessageCode.INF0005);
                    }
                    this.IsDataChange = true;
                    groupResult = vmMas.GetGroup(groupResult.ID);
                    RetriveData();
                }
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        #endregion

        #region "Event"
        private void MAS106_GroupEntry_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void MAS106_GroupEntry_OnSave(object sender, EventArgs e)
        {
            SaveData();
        }

        private void MAS106_GroupEntry_OnCancel(object sender, EventArgs e)
        {
            CancelData(true);
        }

        private void MAS106_GroupEntry_OnRecovery(object sender, EventArgs e)
        {
            CancelData(false);
        }
        #endregion
    }
}
