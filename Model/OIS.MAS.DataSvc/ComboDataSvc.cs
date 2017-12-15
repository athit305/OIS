using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OIS.MAS.DTO;
using OIS.MAS.DataSvcInt;

namespace OIS.MAS.DataSvc
{
    public class ComboDataSvc : IComboDataSvc
    {
        public List<sp_MAS_ComboDivision_Result> GetComboDivision(bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboDivision(IncludeDel).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboSubDivision_Result> GetComboSubDivision(int DivisionId, bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboSubDivision(DivisionId, IncludeDel).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboPosition_Result> GetComboPosition(bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboPosition(IncludeDel).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboGroup_Result> GetComboGroup(bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboGroup(IncludeDel).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboPreName_Result> GetComboPreName(bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboPreName(IncludeDel).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboCustomer_Result> GetComboCustomer(bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboCustomer(IncludeDel).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboProvince_Result> GetComboProvince(bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboProvince(IncludeDel).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BindingList<sp_MAS_ComboReportCode_Result> GetComboReportCode(string Group)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboReportCode(Group).ToList();
                    return new BindingList<sp_MAS_ComboReportCode_Result>(result);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboCustomerProject_Result> GetComboCustomerProject(int CustomerId, bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboCustomerProject(CustomerId, IncludeDel).ToList();
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboInstrument_Result> GetComboInstrument(bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboInstrument(IncludeDel).ToList();
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboUser_Result> GetComboUser(bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboUser(IncludeDel).ToList();
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboUnit_Result> GetComboUnit(bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboUnit(IncludeDel).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboInstitutionSTD_Result> GetComboInstitutionSTD(bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboInstitutionSTD(IncludeDel).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboLabExt_Result> GetComboLabExt(bool IncludeDel)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboLabExt(IncludeDel).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<sp_MAS_ComboLanguage_Result> GetComboLanguage()
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_ComboLanguage().ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
