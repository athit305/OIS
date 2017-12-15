using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.MAS.DTO.Criteria
{
    public class MAS302_STDLight_Criteria
    {
        public int? ID { get; set; }
        public string TYPE_NAME { get; set; }
        public string BUILDING_NAME { get; set; }
        public string AREA_NAME { get; set; }
        public string ALIAS_NAME { get; set; }
        public int? STANDARD_VALUE { get; set; }
        public bool SHOW_DELETE_RECORD { get; set; }
    }
}
