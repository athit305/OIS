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
using OIS.Common;
using OIS.Common.Utils;
using OIS.Definition;
using OIS.SYS.DTO;
using OIS.ViewModel;

namespace OIS.Views
{
    public partial class SYS001_SystemConfig : rBaseUC
    {
        #region "Enum"
        #endregion

        #region "Variable"
        SystemViewModel vmSys = new SystemViewModel();
        sp_SYS001_GetSystemConfig_Result ConfigDTO;
        #endregion

        #region "Constructor"
        public SYS001_SystemConfig()
        {
            InitializeComponent();
            InitialScreen();
        }
        #endregion

        #region "Customize"
        private void InitialScreen()
        {
            this.ToolBarSwitch = "2122222222";
            ConfigDTO = vmSys.GetSystemConfig();
            bs2.DataSource = ConfigDTO;
            CtrlUtil.VisibleControls(OISDataInfo.UserInfomation.GROUP_ID == 1, gbSystem);
        }
        private void SaveData()
        {
            try
            {
                if (rMessageBox.ShowConfirmation(this, MessageCode.CFM0001) == DialogResult.Yes)
                {
                    bs2.EndEdit();
                    vmSys.SaveSystemConfig(ConfigDTO);

                    rMessageBox.ShowInfomation(this, MessageCode.INF0002);
                    InitialScreen();
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        #endregion

        #region "Event"
        private void SYS001_SystemConfig_OnSave(object sender, EventArgs e)
        {
            SaveData();
        }
        #endregion
    }
}
