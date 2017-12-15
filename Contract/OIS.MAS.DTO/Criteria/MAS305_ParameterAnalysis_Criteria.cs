using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.MAS.DTO.Criteria
{
    public class MAS305_ParameterAnalysis_Criteria
    {
        public int? ID { get; set; }
        public string NAME { get; set; }
        public int? METHOD_ID { get; set; }
        public int? UNIT_ID { get; set; }
        public decimal? STANDARD { get; set; }
        public int? TOOL_PICK { get; set; }
        public int? TOOL_ANALYSIS { get; set; }
        public bool SHOW_DELETE_RECORD { get; set; }
    }
}
