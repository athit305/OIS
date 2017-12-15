using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OIS.Common;
using OIS.Common.DTO;
using OIS.Common.Extensions;
using OIS.Common.Utils;
using OIS.Definition;
using OIS.MAS.DataSvc;
using OIS.MAS.DTO;


namespace OIS.ViewModel
{
    public class ComboViewModel
    {
        #region "Variable"
        ComboDataSvc service;
        #endregion

        #region "Constructor"
        public ComboViewModel()
        {
            service = new ComboDataSvc();
        }
        #endregion

        public List<IComboBoxData<int>> GetComboDivision(bool IncludeDel = false)
        {
            return service.GetComboDivision(IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<int>> GetComboSubDivision(int DivisionId, bool IncludeDel = false)
        {
            return service.GetComboSubDivision(DivisionId, IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<int>> GetComboPosition(bool IncludeDel = false)
        {
            return service.GetComboPosition(IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<int>> GetComboGroup(bool IncludeDel = false)
        {
            return service.GetComboGroup(IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<int>> GetComboPreName(bool IncludeDel = false)
        {
            return service.GetComboPreName(IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<int>> GetComboCustomer(bool IncludeDel = false)
        {
            return service.GetComboCustomer(IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<int>> GetComboProvince(bool IncludeDel = false)
        {
            return service.GetComboProvince(IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<string>> GetComboReportCode(ReportType Group)
        {
            return service.GetComboReportCode(Group.ToString()).ToList<IComboBoxData<string>>();
        }
        public List<IComboBoxData<int>> GetComboCustomerProject(int CustomerId, bool IncludeDel = false)
        {
            return service.GetComboCustomerProject(CustomerId, IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<int>> GetComboInstrument(bool IncludeDel = false)
        {
            return service.GetComboInstrument(IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<string>> GetComboUser(bool IncludeDel = false)
        {
            return service.GetComboUser(IncludeDel).ToList<IComboBoxData<string>>();
        }
        public List<IComboBoxData<int>> GetComboUnit(bool IncludeDel = false)
        {
            return service.GetComboUnit(IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<int>> GetComboInstitutionSTD(bool IncludeDel = false)
        {
            return service.GetComboInstitutionSTD(IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<int>> GetComboLabExt(bool IncludeDel = false)
        {
            return service.GetComboLabExt(IncludeDel).ToList<IComboBoxData<int>>();
        }
        public List<IComboBoxData<string>> GetComboLanguage()
        {
            return service.GetComboLanguage().ToList<IComboBoxData<string>>();
        }
    }
}
