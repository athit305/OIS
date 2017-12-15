using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OIS.Common.DTO;

namespace OIS.Common
{
    public class OISDataInfo
    {
        private static USER_INFO m_UserInformation;
        private static DATABASE_INFO m_DatabaseInformation;

        public static USER_INFO UserInfomation
        {
            get { return m_UserInformation; }
        }
        public static DATABASE_INFO DatabaseInfomation
        {
            get { return m_DatabaseInformation; }
        }

        public static void RegisterUserInformation(USER_INFO userInfo)
        {
            m_UserInformation = userInfo;
        }
        public static void RegisterDatabaseInformation(DATABASE_INFO DbInfo)
        {
            m_DatabaseInformation = DbInfo;
        }
    }
}
