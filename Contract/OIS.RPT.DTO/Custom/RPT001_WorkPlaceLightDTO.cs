using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.RPT.DTO
{
    public class RPT001_WorkPlaceLightDTO : sp_RPT001_GetWorkPlaceLight_Result
    {
        public bool Is_Canceled
        {
            get
            {
                return this.DEL_DATE.HasValue;
            }
        }
        public DataTable Detail { get; set; }
        public DataTable Instrument { get; set; }
        public DataTable User { get; set; }
    }

}
