using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OIS.MAS.DTO;

namespace OIS.MAS.DataSvcInt
{
    public interface IComboDataSvc
    {
        List<sp_MAS_ComboDivision_Result> GetComboDivision(bool IncludeDel);
        List<sp_MAS_ComboSubDivision_Result> GetComboSubDivision(int DivisionId, bool IncludeDel);
        List<sp_MAS_ComboPosition_Result> GetComboPosition(bool IncludeDel);
        List<sp_MAS_ComboGroup_Result> GetComboGroup(bool IncludeDel);
        List<sp_MAS_ComboPreName_Result> GetComboPreName(bool IncludeDel);
        List<sp_MAS_ComboCustomer_Result> GetComboCustomer(bool IncludeDel);
        List<sp_MAS_ComboLabExt_Result> GetComboLabExt(bool IncludeDel);
    }
}
