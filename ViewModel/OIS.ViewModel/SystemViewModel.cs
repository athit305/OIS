using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.Common;
using OIS.Common.DTO;
using OIS.Common.Extensions;
using OIS.Common.Utils;
using OIS.Definition;
using OIS.SYS.DataSvc;
using OIS.SYS.DTO;

namespace OIS.ViewModel
{
    public class SystemViewModel : IDisposable
    {
        #region "Variable"
        SystemDataSvc service;
        #endregion

        #region "Constructor"
        public SystemViewModel()
        {
            service = new SystemDataSvc();
        }

        public void Dispose()
        {
            service = null;
        }
        #endregion

        #region "System"
        public string LoadLastUserLogin()
        {
            try
            {
                INIFile iniF = new INIFile(Path.Combine(Application.StartupPath, OISBaseConstant.iniFileName));
                string lastUserLogin = iniF.Read(OISBaseConstant.SectionNameApplication, OISBaseConstant.KeyUserLastLogin);
                iniF.Dispose();
                return lastUserLogin;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void SaveLastUserLogin(USER_INFO data)
        {
            try
            {
                INIFile iniFD = new INIFile(Path.Combine(Application.StartupPath, OISBaseConstant.iniFileName));
                iniFD.Write(OISBaseConstant.SectionNameApplication, OISBaseConstant.KeyUserLastLogin, data.USER_ID);
                iniFD.Dispose();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool Login(string UserId, string Password)
        {
            try
            {
                DATABASE_INFO credential = LoadCredential();
                OISDataInfo.RegisterDatabaseInformation(credential);
                Password = Encryption.GetMd5Hash(Password);
                sp_SYS_UserLogin_Result user = service.UserLogin(UserId, Password);
                if(user != null)
                {
                    USER_INFO userInfo = new USER_INFO()
                    {
                        USER_ID = user.USER_ID,
                        USER_FNAME = user.USER_FNAME,
                        USER_LNAME = user.USER_LNAME,
                        USER_FULLNAME = user.USER_FULLNAME,
                        BIRTH_DATE = user.BIRTHDATE,
                        GROUP_ID = user.GROUP_ID,
                        GROUP_NAME = user.GROUP_NAME,
                        DIVISION_ID = user.DIVISION_ID,
                        DIVISION_NAME = user.DIVISION_NAME,
                        SUBDIVISION_ID = user.SUBDIVISION_ID,
                        SUBDIVISION_NAME = user.SUBDIVISION_NAME,
                        POSITION_ID = user.POSITION_ID,
                        POSITION_NAME = user.POSITION_NAME,
                        MACHINE = Environment.MachineName,
                        LAST_LOGIN = user.LAST_LOGIN,
                    };
                    OISDataInfo.RegisterUserInformation(userInfo);
                    SaveLastUserLogin(userInfo);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void UserLogout()
        {
            service.UserLogout(OISDataInfo.UserInfomation.USER_ID);
        }

        public DATABASE_INFO LoadCredential()
        {
            try
            {
                INIFile iniF = new INIFile(Path.Combine(Application.StartupPath, OISBaseConstant.iniFileName));

                string serverName = iniF.Read(OISBaseConstant.SectionNameDatabaseSetting, OISBaseConstant.KeyServerName);
                string dbName = iniF.Read(OISBaseConstant.SectionNameDatabaseSetting, OISBaseConstant.KeyDatabaseName);
                string username = iniF.Read(OISBaseConstant.SectionNameDatabaseSetting, OISBaseConstant.KeyUsername);
                string password = iniF.Read(OISBaseConstant.SectionNameDatabaseSetting, OISBaseConstant.KeyPassword);

                DATABASE_INFO credential = new DATABASE_INFO()
                {
                    DATASOURCE = serverName,
                    DATABASENAME = dbName,
                    USERNAME = username,
                    PASSWORD = password,
                };
                iniF.Dispose();
                return credential;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void SaveCredential(DATABASE_INFO data)
        {
            try
            {
                INIFile iniF = new INIFile(Path.Combine(Application.StartupPath, OISBaseConstant.iniFileName));
                iniF.Write(OISBaseConstant.SectionNameDatabaseSetting, OISBaseConstant.KeyServerName, data.DATASOURCE);
                iniF.Write(OISBaseConstant.SectionNameDatabaseSetting, OISBaseConstant.KeyDatabaseName, data.DATABASENAME);
                iniF.Write(OISBaseConstant.SectionNameDatabaseSetting, OISBaseConstant.KeyUsername, data.USERNAME);
                iniF.Write(OISBaseConstant.SectionNameDatabaseSetting, OISBaseConstant.KeyPassword, data.PASSWORD);
                iniF.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool TestConnection(DATABASE_INFO data)
        {
            using (var l_oConnection = new SqlConnection(data.ConnectionString))
            {
                try
                {
                    l_oConnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
        public TBS_SYSTEM_CONFIG LoadSystemConfig()
        {
            return service.LoadSystemConfig();
        }
        public void SaveSystemConfig(TBS_SYSTEM_CONFIG data)
        {
            service.SaveSystemConfig(data);
        }

        public List<sp_SYS_GetMenu_Result> LoadMenu()
        {
            try
            {
                List<sp_SYS_GetMenu_Result> menus = service.LoadMenu();
                return menus;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "SYS001 - SystemConfig"
        public sp_SYS001_GetSystemConfig_Result GetSystemConfig()
        {
            return service.GetSystemConfig();
        }
        public void SaveSystemConfig(sp_SYS001_GetSystemConfig_Result data)
        {
            service.SaveSystemConfig(data);
        }
        #endregion

        #region "SYS02 - UserProfile"
        public sp_SYS02_GetUserProfile_Result GetUserProfile()
        {
            return service.GetUserProfile();
        }
        public void SaveUserProfile(sp_SYS02_GetUserProfile_Result data)
        {
            if (!data.PASS.IsNull())
            {
                data.PASS = Encryption.GetMd5Hash(data.PASS);
            }
            if (!data.PASS_NEW.IsNull())
            {
                data.PASS_NEW = Encryption.GetMd5Hash(data.PASS_NEW);
            }
            if (!data.PASS_CONFIRM.IsNull())
            {
                data.PASS_CONFIRM = Encryption.GetMd5Hash(data.PASS_CONFIRM);
            }
            service.SaveUserProfile(data);
        }
        #endregion

    }
}
