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
using OIS.MAS.DataSvc;
using OIS.MAS.DTO;

namespace OIS.ViewModel
{
    public class SearchViewModel
    {
        #region "Variable"
        private MasterDataSvc masService;
        #endregion

        #region "Constructor"
        public SearchViewModel()
        {
            masService = new MasterDataSvc();
        }
        #endregion

        #region "Customize"
        private string GetNameInstrument(int ID)
        {
            return null;
        }
        #endregion
    }
}
