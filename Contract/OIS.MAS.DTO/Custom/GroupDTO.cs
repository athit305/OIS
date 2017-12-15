using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OIS.Common;

namespace OIS.MAS.DTO
{
    public class GroupDTO : sp_MAS106_GetGroup_Result
    {
        public SortableBindingList<sp_MAS106_GetGroupPermission_Result> Permission { get; set; }
        public SortableBindingList<sp_MAS106_GetGroupUser_Result> User { get; set; }
    }
}
