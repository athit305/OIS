using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OIS.Definition
{
    public class OISBaseConstant
    {
        public static string iniFileName = "config.ini";
        public static string SectionNameDatabaseSetting = "DatabaseSetting";
        public static string SectionNameApplication = "Application";
        public static string KeyServerName = "ServerName";
        public static string KeyDatabaseName = "DatabaseName";
        public static string KeyUsername = "Username";
        public static string KeyPassword = "Password";
        public static string KeyUserLastLogin = "UserLastLogin";

        public static string MessageBoxTitle = "ERTC: OIS";

        public const string COMBO_SELECTALL_TEXT = "- ไม่ระบุ -";

        #region "File"
        public const string DEFAULT_EXPORT_FILENAME = "{0}_{1:yyyyMMddHHmmss_ffffff}.{2}";
        public const string DEFAULT_TMP_FILENAME = "_tmpFile_{0:yyyyMMddHHmmss_ffffff}.{1}";
        public const string DEFAULT_TMP_FILENAME_NO_EXT = "_tmpFile_{0:yyyyMMddHHmmss_ffffff}";
        public const string DEFAULT_TMP_FOLDER = "_oisTempDir";

        public const string PATH_TEMPLATE = "Views\\Reports";
        #endregion

    }

    public class OISGridConstant
    {
        public static string DateFormat = "dd/MM/yyyy";
        public static string DateTimeFormat = "dd/MM/yyyy HH:mm:ss";
        public static string TimeFormat = "hh:mm";
    }

    public class OISFormConstant
    {
        public static Color BackColor
        {
            get
            {
                return Color.FromName("AliceBlue");
            }

        }
        public static Size DefaultButtonSize
        {
            get
            {
                return new Size(75, 27);
            }
        }
    }
}
