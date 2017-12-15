using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.RPT.DTO
{
    public class RPT002_WorkPlaceAirDTO : sp_RPT002_GetWorkPlaceAir_Result
    {
        public bool Is_Canceled
        {
            get
            {
                return this.DEL_DATE.HasValue;
            }
        }
        public DataTable Detail { get; set; }
        public DataTable User { get; set; }
    }
}
