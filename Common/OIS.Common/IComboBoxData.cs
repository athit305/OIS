using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.Common
{
    public interface IComboBoxData<T>
    {
        string DISPLAY { get; set; }
        T VALUE { get; set; }
    }
}
