using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OIS.Common.Extensions;
using OIS.Definition;

namespace OIS.Common.Utils
{
    public class FilesUtil
    {
        private static readonly string TmpPath = Path.Combine(Path.GetTempPath(), OISBaseConstant.DEFAULT_TMP_FOLDER);

        public static string GetApplicationTempPath()
        {
            if (!Directory.Exists(TmpPath))
                Directory.CreateDirectory(TmpPath);

            return TmpPath;
        }

        public static void ClearApplicationTempPath()
        {
            try
            {
                if (Directory.Exists(TmpPath))
                    Directory.Delete(TmpPath, true);
            }
            catch { }//Ignor Error
        }

        public static String GetTmpPdfFileName(string FileName = "")
        {
            FileName = FileName.ReplaceInvalidFileNameChars();
            return Path.Combine(FilesUtil.GetApplicationTempPath(), String.Format(OISBaseConstant.DEFAULT_EXPORT_FILENAME, FileName, DateTime.Now, "pdf"));
        }

        public static String GetTmpDocFileName(string FileName = "")
        {
            FileName = FileName.ReplaceInvalidFileNameChars();
            return Path.Combine(FilesUtil.GetApplicationTempPath(), String.Format(OISBaseConstant.DEFAULT_EXPORT_FILENAME, FileName, DateTime.Now, "doc"));
        }

        public static String GetTmpXlsFileName(string FileName = "")
        {
            FileName = FileName.ReplaceInvalidFileNameChars();
            return Path.Combine(FilesUtil.GetApplicationTempPath(), String.Format(OISBaseConstant.DEFAULT_EXPORT_FILENAME, FileName, DateTime.Now, "xls"));
        }

        public static String GetTmpXlsxFileName(string FileName = "")
        {
            FileName = FileName.ReplaceInvalidFileNameChars();
            return Path.Combine(FilesUtil.GetApplicationTempPath(), String.Format(OISBaseConstant.DEFAULT_EXPORT_FILENAME, FileName, DateTime.Now, "xlsx"));
        }
    }
}
