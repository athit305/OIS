using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using OIS.BaseViews;
using OIS.Common;
using OIS.Common.Utils;
using OIS.SYS.DTO;
using OIS.Views;
using OIS.ViewModel;

namespace OIS
{
    public sealed partial class MainForm : Form
    {
        #region "Enum"
        #endregion

        #region "Variable"
        SystemViewModel vmSys = new SystemViewModel();

        TBS_SYSTEM_CONFIG Config;
        #endregion

        #region "Constructor"
        public MainForm()
        {
            InitializeComponent();

            InternalVariable.MainForm_Instance = this;
            this.tabControl.Visible = false;
            this.LoadMenu();
        }
        #endregion

        #region "Customize"
        private void LoadMenu()
        {
            List<sp_SYS_GetMenu_Result> menus = vmSys.LoadMenu();

            foreach (var m in menus)
            {
                if (m.PARENT_ID == null)
                {
                    ToolStripMenuItem menu = new ToolStripMenuItem()
                    {
                        Name = m.ID,
                        Text = "&" + m.MENU_NAME,
                        Tag = m,
                    };
                    menuStrip.Items.Add(menu);
                }
                else
                {
                    if (m.MENU_TYPE == "FORM")
                    {
                        ToolStripItem form = new ToolStripMenuItem()
                        {
                            Name = m.ID,
                            Text = "&" + m.MENU_NAME,
                            Tag = m,
                        };
                        form.Click += new EventHandler(MenuItem_Click);
                        foreach (ToolStripMenuItem d in menuStrip.Items)
                        {
                            sp_SYS_GetMenu_Result data = d.Tag as sp_SYS_GetMenu_Result;
                            if (d.DropDownItems.Count > 0)
                            {
                                foreach(ToolStripMenuItem d2 in d.DropDownItems)
                                {
                                    sp_SYS_GetMenu_Result data2 = d2.Tag as sp_SYS_GetMenu_Result;
                                    if (data2.ID == m.PARENT_ID)
                                    {
                                        d2.DropDownItems.Add(form);
                                    }
                                }
                            }
                            if (data.ID == m.PARENT_ID)
                            {
                                d.DropDownItems.Add(form);
                            }
                        }
                    }
                    else if(m.MENU_TYPE == "MENU")
                    {
                        ToolStripMenuItem menu = new ToolStripMenuItem()
                        {
                            Name = m.ID,
                            Text = "&" + m.MENU_NAME,
                            Tag = m,
                        };
                        foreach (ToolStripMenuItem d in menuStrip.Items)
                        {
                            if (((sp_SYS_GetMenu_Result)d.Tag).ID == m.PARENT_ID)
                            {
                                d.DropDownItems.Add(menu);
                            }
                        }
                    }
                }
            }
        }
        public void CloseTab(sp_SYS_GetMenu_Result data)
        {
            try
            {
                for (int i = 0; i < tabControl.TabCount; i++)
                {
                    if (tabControl.TabPages[i].Tag as sp_SYS_GetMenu_Result == data)
                    {
                        tabControl.TabPages.RemoveAt(i);
                    }
                }

                tabControl.Visible = tabControl.TabPages.Count > 0;
            }
            catch (Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
        }
        private void OpenScreen(sp_SYS_GetMenu_Result data)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!IsScreenOpened(data))
                {
                    var uc = GetUserControlFromID(data.ID);
                    if (uc != null)
                    {
                        TabPage tab = new TabPage(data.ID);
                        tab.Name = data.ID;
                        tab.Text = string.Format("{0}: {1}", data.ID, data.MENU_NAME);
                        tab.Tag = data;
                        uc.Dock = DockStyle.Fill;
                        tab.Controls.Add(uc);
                        tabControl.TabPages.Add(tab);
                        tabControl.SelectedIndex = tabControl.TabPages.Count - 1;

                        tabControl.Visible = tabControl.TabPages.Count > 0;
                    }
                    else
                    {
                        rMessageBox.ShowWarning(this, string.Format("ไม่พบไฟล์หน้าจอนี้ [{0}]", data.ID), MessageBoxButtons.OK);
                    }
                }
                else
                {
                    foreach (TabPage tabPage in tabControl.TabPages)
                    {
                        if ((tabPage.Tag as sp_SYS_GetMenu_Result) == data)
                        {
                            tabControl.SelectedTab = tabPage;
                        }
                    }
                }
                if (tabControl.SelectedTab != null)
                {
                    this.ActiveControl = tabControl.SelectedTab.Controls[0].Controls[0];
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private rBaseUC GetUserControlFromID(string ID)
        {
            try
            {
                rBaseUC uc;
                switch (ID)
                {
                    case "MAS101":
                        //ผู้ใช้งานระบบ
                        uc = new MAS101_User();
                        break;
                    case "MAS102":
                        //ฝ่าย
                        uc = new MAS102_Division();
                        break;
                    case "MAS103":
                        //แผนก
                        uc = new MAS103_SubDivision(); ;
                        break;
                    case "MAS104":
                        //ตำแหน่ง
                        uc = new MAS104_Position();
                        break;
                    case "MAS105":
                        //คำนำหน้า
                        uc = new MAS105_PreName();
                        break;
                    case "MAS106":
                        //กลุ่มผู้ใช้
                        uc = new MAS106_Group();
                        break;
                    case "MAS201":
                        //ลูกค้า
                        uc = new MAS201_Customer();
                        break;
                    case "MAS202":
                        //โครงการของลูกค้า
                        uc = new MAS202_CustomerProject();
                        break;
                    case "MAS203":
                        //จังหวัด
                        uc = new MAS203_Province();
                        break;
                    case "MAS301":
                        //หน่วย
                        uc = new MAS301_Unit();
                        break;
                    case "MAS302":
                        //Standard Light Intensity
                        uc = new MAS302_StandardLightIntensity();
                        break;
                    case "MAS303":
                        //เครื่องมือ
                        uc = new MAS303_Instrument();
                        break;
                    case "MAS304":
                        //Method
                        uc = new MAS304_MethodAnalysis();
                        break;
                    case "MAS305":
                        //Parameter
                        uc = new MAS305_ParameterAnalysis();
                        break;
                    case "MAS306":
                        //Condition Light
                        uc = new MAS306_ConditionLight();
                        break;
                    case "MAS307":
                        //Institution Standard
                        uc = new MAS307_InstitutionStandard();
                        break;
                    case "MAS308":
                        //ToolPick
                        uc = new MAS308_ToolPick();
                        break;
                    case "MAS309":
                        //ToolAnalysis
                        uc = new MAS309_ToolAnalysis();
                        break;
                    case "MAS310":
                        //LabExt
                        uc = new MAS310_LabExt();
                        break;
                    case "RPT001":
                        //Work Place Light Intensity
                        uc = new RPT001_WorkPlaceLightIntensity();
                        break;
                    case "RPT002":
                        //Work Place Air Quality
                        uc = new RPT002_WorkPlaceAirQuality();
                        break;
                    case "SYS001":
                        //ตั้งค่าระบบ
                        uc = new SYS001_SystemConfig();
                        break;
                    case "SYS002":
                        //ข้อมูลผู้ใช้
                        uc = new SYS002_UserProfile();
                        break;
                    default:
                        uc = null;
                        break;
                }
                return uc;
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                return null;
            }
        }
        private bool IsScreenOpened(sp_SYS_GetMenu_Result data)
        {
            try
            {
                foreach(TabPage tab in tabControl.TabPages)
                {
                    if(tab.Tag as sp_SYS_GetMenu_Result == data)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
                return true;
            }
        }
        private void UpdateFile()
        {
            try
            {
                if (Config == null)
                {
                    Config = vmSys.LoadSystemConfig();
                }
                if (Config.IS_UPDATE_AUTOUPDATE)
                {
                    string AutoUpdateFilePath = Path.Combine("C:\\", ConfigurationManager.AppSettings["AutoUpdateFilePath"]);
                    string DeployPath_AutoUpdate = Path.Combine(ConfigurationManager.AppSettings["DeployPath_AutoUpdate"]);

                    //Now Create all of the directories
                    foreach (string dirPath in Directory.GetDirectories(DeployPath_AutoUpdate, "*", SearchOption.AllDirectories))
                    {
                        Directory.CreateDirectory(dirPath.Replace(DeployPath_AutoUpdate, AutoUpdateFilePath));
                    }

                    //Copy all the files & Replaces any files with the same name
                    foreach (string newPath in Directory.GetFiles(DeployPath_AutoUpdate, "*.*", SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(DeployPath_AutoUpdate, AutoUpdateFilePath), true);
                    }
                }
            }
            catch(Exception)
            {

            }
        }
        #endregion

        #region "Event"
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.tsslblUser.Text = string.Format("ชื่อผู้ใช้ : {0}", OISDataInfo.UserInfomation.USER_FULLNAME);
            this.tsslblMachine.Text = string.Format("ชื่อเครื่อง : {0}", OISDataInfo.UserInfomation.MACHINE);
            this.tsslblLastLogin.Text = string.Format("เข้าสู่ระบบล่าสุด : {0}", OISDataInfo.UserInfomation.LAST_LOGIN);

            this.tsslblVersion.Text = string.Format("Version : {0}", Application.ProductVersion);
            this.tsslblServer.Text = string.Format("เซิฟเวอร์ : {0}", OISDataInfo.DatabaseInfomation.DATASOURCE);
            this.tsslblDB.Text = string.Format("ฐานข้อมูล: {0}", OISDataInfo.DatabaseInfomation.DATABASENAME);
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            UpdateFile();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(rMessageBox.ShowConfirmation(this, "คุณต้องการปิดโปรแกรมใช่หรือไม่ ?") != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            try
            {
                using (SystemViewModel vmSys = new SystemViewModel())
                {
                    vmSys.UserLogout();
                }
            }
            catch(Exception ex)
            {
                rMessageBox.ShowException(this, ex);
            }
            FilesUtil.ClearApplicationTempPath();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            sp_SYS_GetMenu_Result row = ((ToolStripItem)sender).Tag as sp_SYS_GetMenu_Result;
            this.OpenScreen(row);
        }
        #endregion

        #region "Override Method"
        #endregion
    }
}
