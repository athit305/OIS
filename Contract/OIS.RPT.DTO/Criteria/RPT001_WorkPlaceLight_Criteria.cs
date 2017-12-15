using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.RPT.DTO.Criteria
{
    public class RPT001_WorkPlaceLight_Criteria
    {
        public int? ID { get; set; }
        public string REPORTNUMBER { get; set; }
        public int? CUSTOMER_ID { get; set; }
        public DateTime? DATE_FROM { get; set; }
        public DateTime? DATE_TO { get; set; }
        public string MEASURED_BY { get; set; }
        public int? INSTRUMENT_ID { get; set; }
        public string CRT_USER_ID { get; set; }
        public bool SHOW_DELETE_RECORD { get; set; }
    }
}
