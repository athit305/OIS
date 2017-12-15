using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.MAS.DataSvcInt
{
    public interface ISearchAble
    {
        object SelectedData { get; set; }
        void Filter(string strFilter);
    }
}
