using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.Common.DTO
{
    public class USER_INFO
    {
        public string USER_ID { get; set; }
        public string USER_FNAME { get; set; }
        public string USER_LNAME { get; set; }
        public string USER_FULLNAME { get; set; }
        public DateTime? BIRTH_DATE { get; set; }
        public int? GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public int? DIVISION_ID { get; set; }
        public string DIVISION_NAME { get; set; }
        public int? SUBDIVISION_ID { get; set; }
        public string SUBDIVISION_NAME { get; set; }
        public int? POSITION_ID { get; set; }
        public string POSITION_NAME { get; set; }
        public string MACHINE { get; set; }
        public string LAST_LOGIN { get; set; }
    }
}
