using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using OIS.Common;
using OIS.Common.Extensions;
using OIS.SYS.DTO;

namespace OIS.SYS.DataSvc
{
    public class SystemDataSvc
    {
        #region "System"
        public sp_SYS_UserLogin_Result UserLogin(string UserId,string Password)
        {
            try
            {
                using (OIS_SYSEntities ct = new OIS_SYSEntities())
                {
                    string AppVersion = Application.ProductVersion;
                    sp_SYS_UserLogin_Result user = ct.sp_SYS_UserLogin(UserId, Password, AppVersion).FirstOrDefault();
                    return user;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void UserLogout(string UserId)
        {
            try
            {
                using (OIS_SYSEntities ct = new OIS_SYSEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_SYS_UserLogout(UserId);
                    trans.Complete();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_SYS_GetMenu_Result> LoadMenu()
        {
            try
            {
                using (OIS_SYSEntities ct = new OIS_SYSEntities())
                {
                    ct.Configuration.LazyLoadingEnabled = false;

                    List<sp_SYS_GetMenu_Result> menus = ct.sp_SYS_GetMenu(OISDataInfo.UserInfomation.USER_ID).ToList();
                    return menus;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public TBS_SYSTEM_CONFIG LoadSystemConfig()
        {
            try
            {
                using (OIS_SYSEntities ct = new OIS_SYSEntities())
                {
                    TBS_SYSTEM_CONFIG result = ct.TBS_SYSTEM_CONFIG.FirstOrDefault();
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void SaveSystemConfig(TBS_SYSTEM_CONFIG data)
        {
            try
            {
                using (OIS_SYSEntities ct = new OIS_SYSEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    TBS_SYSTEM_CONFIG result = ct.TBS_SYSTEM_CONFIG.FirstOrDefault();

                    result.IS_UPDATE_AUTOUPDATE = data.IS_UPDATE_AUTOUPDATE;

                    result.UPD_ID = OISDataInfo.UserInfomation.USER_ID;
                    result.UPD_DATE = GetCurDateTime();
                    result.UPD_MACHINE = OISDataInfo.UserInfomation.MACHINE;

                    ct.SaveChanges();
                    trans.Complete();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DateTime GetCurDateTime()
        {
            try
            {
                using (OIS_SYSEntities ct = new OIS_SYSEntities())
                {
                    DateTime dt = ct.Database.SqlQuery<DateTime>("SELECT GETDATE()").FirstOrDefault();
                    return dt;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public string GetServerName()
        {
            try
            {
                using (OIS_SYSEntities ct = new OIS_SYSEntities())
                {
                    string serverName = ct.Database.SqlQuery<string>("SELECT @@SERVERNAME").FirstOrDefault();
                    return serverName;
                }
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
            try
            {
                using (OIS_SYSEntities ct = new OIS_SYSEntities())
                {
                    sp_SYS001_GetSystemConfig_Result result = ct.sp_SYS001_GetSystemConfig().FirstOrDefault();
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void SaveSystemConfig(sp_SYS001_GetSystemConfig_Result data)
        {
            try
            {
                using (OIS_SYSEntities ct = new OIS_SYSEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_SYS001_SaveSystemConfig(data.IS_UPDATE_AUTOUPDATE,
                        data.DEFAULT_REPORT_REGISTRATION_ID,
                        data.DEFAULT_REPORT_LAB_SUPERVISOR_ID,
                        data.REPORT_REV_WPL,
                        data.DEFAULT_REPORT_WPA_REGISTRATION_ID,
                        data.DEFAULT_REPORT_WPA_LAB_SUPERVISOR_ID,
                        data.REPORT_REV_WPA,
                        OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "SYS02 - UserProfile"
        public sp_SYS02_GetUserProfile_Result GetUserProfile()
        {
            try
            {
                using (OIS_SYSEntities ct = new OIS_SYSEntities())
                {
                    var result = ct.sp_SYS02_GetUserProfile(OISDataInfo.UserInfomation.USER_ID).FirstOrDefault();
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void SaveUserProfile(sp_SYS02_GetUserProfile_Result data)
        {
            try
            {
                using (OIS_SYSEntities ct = new OIS_SYSEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_SYS02_SaveUserProfile(data.ID,
                        data.PRENAME_ID,
                        data.FNAME_EN,
                        data.LNAME_EN,
                        data.FNAME_TH,
                        data.LNAME_TH,
                        data.NICKNAME,
                        data.IDCARD,
                        data.BIRTHDATE,
                        data.STARTDATE,
                        data.DIVISION_ID,
                        data.SUBDIVISION_ID,
                        data.POSITION_ID,
                        data.GROUP_ID,
                        data.REGISTRATION_NO,
                        data.LABSUPERVISOR_NO,
                        data.USER_PIC,
                        data.PASS,
                        data.PASS_NEW,
                        data.PASS_CONFIRM,
                        OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
