using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.MAS.DTO.Criteria
{
    public class MAS101_User_Criteria
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public int? DIVISION_ID { get; set; }
        public int? SUBDIVISION_ID { get; set; }
        public int? POSITION_ID { get; set; }
        public int? GROUP_ID { get; set; }
        public bool SHOW_DELETE_RECORD { get; set; }
    }
}
