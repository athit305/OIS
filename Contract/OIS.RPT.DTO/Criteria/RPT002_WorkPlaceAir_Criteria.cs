using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.RPT.DTO.Criteria
{
    public class RPT002_WorkPlaceAir_Criteria
    {
        public int? ID { get; set; }
        public string ANALYSYS_NO { get; set; }
        public string JOB_NO { get; set; }
        public int? CUSTOMER_ID { get; set; }
        public DateTime? ANALYTICAL_DATE_FROM { get; set; }
        public DateTime? ANALYTICAL_DATE_TO { get; set; }
        public DateTime? SAMPLING_DATE_FROM { get; set; }
        public DateTime? SAMPLING_DATE_TO { get; set; }
        public string SAMPING_BY { get; set; }
        public bool SHOW_DELETE_RECORD { get; set; }
    }
}
