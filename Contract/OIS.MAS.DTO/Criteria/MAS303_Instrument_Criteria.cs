using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.MAS.DTO.Criteria
{
    public class MAS303_Instrument_Criteria
    {
        public int? ID { get; set; }
        public string NAME { get; set; }
        public string MODEL { get; set; }
        public string SERIALNO { get; set; }
        public bool SHOW_DELETE_RECORD { get; set; }
        public bool SHOW_EXPIRED { get; set; }
    }
}
