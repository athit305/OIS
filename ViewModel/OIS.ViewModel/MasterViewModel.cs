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
using OIS.MAS.DTO.Criteria;
using System.Text.RegularExpressions;
using System.Data;

namespace OIS.ViewModel
{
    public class MasterViewModel
    {
        #region "Variable"
        MasterDataSvc service;
        #endregion

        #region "Constructor"
        public MasterViewModel()
        {
            service = new MasterDataSvc();
        }
        #endregion

        #region "MAS101-User"
        public SortableBindingList<sp_MAS101_GetUser_Result> GetUser(MAS101_User_Criteria criteria)
        {
            return service.GetUser(criteria);
        }
        public SortableBindingList<sp_MAS101_GetUser_Result> GetUser()
        {
            return service.GetUser(new MAS101_User_Criteria());
        }
        public sp_MAS101_GetUser_Result GetUser(string ID)
        {
            return service.GetUser(new MAS101_User_Criteria()
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
            }).FirstOrDefault();
        }
        public bool IsExistsUser(string userId)
        {
            return service.IsExistsUser(userId);
        }
        public string SaveUser(sp_MAS101_GetUser_Result user)
        {
            if (!user.PASS.IsNull())
            {
                user.PASS = Encryption.GetMd5Hash(user.PASS);
            }
            return service.SaveUser(user);
        }
        public void CancelUser(sp_MAS101_GetUser_Result data, bool ISCANCEL)
        {
            service.CancelUser(data, ISCANCEL);
        }
        #endregion

        #region "MAS Dialog"
        public SortableBindingList<sp_MAS_DialogCustomerLocation_Result> GetCustomerLocation(int? CustomerId)
        {
            return service.GetCustomerLocation(CustomerId);
        }
        public DataTable GetConditionReportWPLDialog()
        {
            return service.GetConditionReportWPLDialog();
        }
        #endregion

        #region "MAS102-Division"
        public SortableBindingList<sp_MAS102_GetDivision_Result> GetDivision(string NAME, bool SHOW_DELETE_RECORD)
        {
            return service.GetDivision(null, NAME, SHOW_DELETE_RECORD);
        }
        public sp_MAS102_GetDivision_Result GetDivision(int ID)
        {
            return service.GetDivision(ID, null, true).FirstOrDefault();
        }
        public int SaveDivision(sp_MAS102_GetDivision_Result data)
        {
            return service.SaveDivision(data);
        }
        public void CancelDivision(sp_MAS102_GetDivision_Result data, bool ISCANCEL)
        {
            service.CancelDivision(data, ISCANCEL);
        }
        #endregion

        #region "MAS103-SubDivision"
        public SortableBindingList<sp_MAS103_GetSubDivision_Result> GetSubDivision(int? DIVISION_ID, string NAME, bool SHOW_DELETE_RECORD)
        {
            return service.GetSubDivision(null, DIVISION_ID, NAME, SHOW_DELETE_RECORD);
        }
        public sp_MAS103_GetSubDivision_Result GetSubDivision(int ID)
        {
            return service.GetSubDivision(ID, null, null, true).FirstOrDefault();
        }
        public int SaveSubDivision(sp_MAS103_GetSubDivision_Result data)
        {
            return service.SaveSubDivision(data);
        }
        public void CancelSubDivision(sp_MAS103_GetSubDivision_Result data, bool ISCANCEL)
        {
            service.CancelSubDivision(data, ISCANCEL);
        }
        #endregion

        #region "MAS104-Position"
        public SortableBindingList<sp_MAS104_GetPosition_Result> GetPosition(string NAME, bool SHOW_DELETE_RECORD)
        {
            return service.GetPosition(null, NAME, SHOW_DELETE_RECORD);
        }
        public sp_MAS104_GetPosition_Result GetPosition(int ID)
        {
            return service.GetPosition(ID, null, true).FirstOrDefault();
        }
        public int SavePosition(sp_MAS104_GetPosition_Result data)
        {
            return service.SavePosition(data);
        }
        public void CancelPosition(sp_MAS104_GetPosition_Result data, bool ISCANCEL)
        {
            service.CancelPosition(data, ISCANCEL);
        }
        #endregion

        #region "MAS105-PreName"
        public SortableBindingList<sp_MAS105_GetPreName_Result> GetPreName(string NAME, bool SHOW_DELETE_RECORD)
        {
            return service.GetPreName(null, NAME, SHOW_DELETE_RECORD);
        }
        public sp_MAS105_GetPreName_Result GetPreName(int ID)
        {
            return service.GetPreName(ID, null, true).FirstOrDefault();
        }
        public int SavePreName(sp_MAS105_GetPreName_Result data)
        {
            return service.SavePreName(data);
        }
        public void CancelPreName(sp_MAS105_GetPreName_Result data, bool ISCANCEL)
        {
            service.CancelPreName(data, ISCANCEL);
        }
        #endregion

        #region "MAS106-Group"
        public SortableBindingList<sp_MAS106_GetGroup_Result> GetGroup(string NAME, bool SHOW_DELETE_RECORD)
        {
            return service.GetGroup(null, NAME, SHOW_DELETE_RECORD);
        }
        public GroupDTO GetGroup(int ID)
        {
            return service.GetGroup(ID);
        }

        public int SaveGroup(GroupDTO data)
        {
            return service.SaveGroup(data);
        }
        public void CancelGroup(GroupDTO data, bool ISCANCEL)
        {
            service.CancelGroup(data, ISCANCEL);
        }
        public SortableBindingList<sp_MAS106_GetGroupPermission_Result> GetGroupPermission(int ID)
        {
            return service.GetGroupPermission(ID);
        }
        #endregion

        #region "MAS201-Customer"
        public SortableBindingList<sp_MAS201_GetCustomer_Result> GetCustomer(string NAME, string ADDR, bool SHOW_DELETE_RECORD)
        {
            return service.GetCustomer(null, NAME, ADDR, SHOW_DELETE_RECORD);
        }
        public sp_MAS201_GetCustomer_Result GetCustomer(int ID)
        {
            return service.GetCustomer(ID, null, null, true).FirstOrDefault();
        }
        public int SaveCustomer(sp_MAS201_GetCustomer_Result data)
        {
            //if (!data.IS_LANG_EN.GetValueOrDefault())
            //{
            //    data.DEFAULT_LANGUAGE = "TH";
            //}
            //else
            //{
            //    data.DEFAULT_LANGUAGE = "EN";
            //}
            return service.SaveCustomer(data);
        }
        public SortableBindingList<sp_MAS201_GetCustomer_Result> GetCustomer()
        {
            return service.GetCustomer(null, null, null, false);
        }
        public void CancelCustomer(sp_MAS201_GetCustomer_Result data, bool ISCANCEL)
        {
            service.CancelCustomer(data, ISCANCEL);
        }
        #endregion

        #region "MAS202-CustomerProject"
        public SortableBindingList<sp_MAS202_GetCustomerProject_Result> GetCustomerProject(string NAME, string ADDR, int? CUSTOMER_ID, bool SHOW_DELETE_RECORD)
        {
            return service.GetCustomerProject(null, NAME, ADDR, CUSTOMER_ID, SHOW_DELETE_RECORD);
        }
        public sp_MAS202_GetCustomerProject_Result GetCustomerProject(int ID)
        {
            return service.GetCustomerProject(ID, null, null, null, true).FirstOrDefault();
        }
        public SortableBindingList<sp_MAS202_GetCustomerProject_Result> GetCustomerProject()
        {
            return service.GetCustomerProject(null, null, null, null, false);
        }
        public int SaveCustomerProject(sp_MAS202_GetCustomerProject_Result data)
        {
            return service.SaveCustomerProject(data);
        }
        public void CancelCustomerProject(sp_MAS202_GetCustomerProject_Result data, bool ISCANCEL)
        {
            service.CancelCustomerProject(data, ISCANCEL);
        }
        #endregion

        #region "MAS203-Province"
        public SortableBindingList<sp_MAS203_GetProvince_Result> GetProvince(string Name, bool SHOW_DELETE_RECORD)
        {
            return service.GetProvince(null, Name, SHOW_DELETE_RECORD);
        }
        public sp_MAS203_GetProvince_Result GetProvince(int ID)
        {
            return service.GetProvince(ID, null, true).FirstOrDefault();
        }
        public int SaveProvince(sp_MAS203_GetProvince_Result data)
        {
            return service.SaveProvince(data);
        }
        public void CancelProvince(sp_MAS203_GetProvince_Result data, bool ISCANCEL)
        {
            service.CancelProvince(data, ISCANCEL);
        }
        #endregion

        #region "MAS301-Unit"
        public SortableBindingList<sp_MAS301_GetUnit_Result> GetUnit(string Name, bool SHOW_DELETE_RECORD)
        {
            return service.GetUnit(null, Name, SHOW_DELETE_RECORD);
        }
        public sp_MAS301_GetUnit_Result GetUnit(int ID)
        {
            return service.GetUnit(ID, null, true).FirstOrDefault();
        }
        public int SaveUnit(sp_MAS301_GetUnit_Result unit)
        {
            return service.SaveUnit(unit);
        }
        public void CancelUnit(sp_MAS301_GetUnit_Result data, bool ISCANCEL)
        {
            service.CancelUnit(data, ISCANCEL);
        }
        #endregion

        #region "MAS302-STDLight"
        public SortableBindingList<sp_MAS302_GetSTDLight_Result> GetSTDLight(MAS302_STDLight_Criteria criteria)
        {
            return service.GetSTDLight(criteria);
        }
        public sp_MAS302_GetSTDLight_Result GetSTDLight(int ID)
        {
            return service.GetSTDLight(new MAS302_STDLight_Criteria()
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
            }).FirstOrDefault();
        }
        public int SaveSTDLight(sp_MAS302_GetSTDLight_Result data)
        {
            return service.SaveSTDLight(data);
        }
        public void CancelSTDLight(sp_MAS302_GetSTDLight_Result data, bool IS_CANCEL)
        {
            service.CancelSTDLight(data, IS_CANCEL);
        }
        #endregion

        #region "MAS303-Instrument"
        public SortableBindingList<sp_MAS303_GetInstrument_Result> GetInstrument(MAS303_Instrument_Criteria criteria)
        {
            return service.GetInstrument(criteria);
        }
        public sp_MAS303_GetInstrument_Result GetInstrument(int ID)
        {
            return service.GetInstrument(new MAS303_Instrument_Criteria()
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
                SHOW_EXPIRED = true,
            }).FirstOrDefault();
        }
        public SortableBindingList<sp_MAS303_GetInstrument_Result> GetInstrument()
        {
            return service.GetInstrument(new MAS303_Instrument_Criteria());
        }
        public int SaveInstrument(sp_MAS303_GetInstrument_Result data)
        {
            return service.SaveInstrument(data);
        }
        public void CancelInstrument(sp_MAS303_GetInstrument_Result data, bool ISCANCEL)
        {
            service.CancelInstrument(data, ISCANCEL);
        }
        #endregion

        #region "MAS304-Method Analysis"
        public SortableBindingList<sp_MAS304_GetMethodAnalysis_Result> GetMethodAnalysis(MAS304_MethodAnalysis_Criteria criteria)
        {
            return service.GetMethodAnalysis(criteria);
        }
        public SortableBindingList<sp_MAS304_GetMethodAnalysis_Result> GetMethodAnalysis()
        {
            return service.GetMethodAnalysis(new MAS304_MethodAnalysis_Criteria());
        }
        public sp_MAS304_GetMethodAnalysis_Result GetMethodAnalysis(int ID)
        {
            return service.GetMethodAnalysis(new MAS304_MethodAnalysis_Criteria()
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
            }).FirstOrDefault();
        }
        public int SaveMethodAnalysis(sp_MAS304_GetMethodAnalysis_Result data)
        {
            return service.SaveMethodAnalysis(data);
        }
        public void CancelMethodAnalysis(sp_MAS304_GetMethodAnalysis_Result data, bool ISCANCEL)
        {
            service.CancelMethodAnalysis(data, ISCANCEL);
        }
        #endregion

        #region "MAS305-Parameter Analysis"
        public SortableBindingList<sp_MAS305_GetParameterAnalysis_Result> GetParameterAnalysis(MAS305_ParameterAnalysis_Criteria criteria)
        {
            return service.GetParameterAnalysis(criteria);
        }
        public SortableBindingList<sp_MAS305_GetParameterAnalysis_Result> GetParameterAnalysis()
        {
            return service.GetParameterAnalysis(new MAS305_ParameterAnalysis_Criteria());
        }
        public sp_MAS305_GetParameterAnalysis_Result GetParameterAnalysis(int ID)
        {
            return service.GetParameterAnalysis(new MAS305_ParameterAnalysis_Criteria()
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
            }).FirstOrDefault();
        }
        public int SaveParameterAnalysis(sp_MAS305_GetParameterAnalysis_Result data)
        {
            return service.SaveParameterAnalysis(data);
        }
        public void CancelParameterAnalysis(sp_MAS305_GetParameterAnalysis_Result data, bool ISCANCEL)
        {
            service.CancelParameterAnalysis(data, ISCANCEL);
        }
        #endregion

        #region "MAS306-ConditionLight"
        public SortableBindingList<sp_MAS306_GetConditionLight_Result> GetConditionLight(MAS306_ConditionLight_Criteria criteria)
        {
            return service.GetConditionLight(criteria);
        }
        public sp_MAS306_GetConditionLight_Result GetConditionLight(int ID)
        {
            return service.GetConditionLight(new MAS306_ConditionLight_Criteria()
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
            }).FirstOrDefault();
        }
        public SortableBindingList<sp_MAS306_GetConditionLight_Result> GetConditionLight()
        {
            return service.GetConditionLight(new MAS306_ConditionLight_Criteria());
        }
        public int SaveConditionLight(sp_MAS306_GetConditionLight_Result data)
        {
            return service.SaveConditionLight(data);
        }
        public void CancelConditionLight(sp_MAS306_GetConditionLight_Result data, bool ISCANCEL)
        {
            service.CancelConditionLight(data, ISCANCEL);
        }
        public string ConvertConditionLightCodeToName(string CODE)
        {
            try
            {
                if (CODE.HasValue())
                {
                    var theString = Regex.Replace(CODE, @"\s+", "");

                    SortableBindingList<sp_MAS306_GetConditionLight_Result> result = GetConditionLight();                    

                    List<string> codeList = new List<string>();
                    List<string> nameList = new List<string>();
                    codeList.AddRange(theString.Split(',').ToList());

                    foreach (string c in codeList)
                    {
                        foreach (sp_MAS306_GetConditionLight_Result row in result)
                        {
                            if(row.CODE == c)
                            {
                                nameList.Add(row.NAME);
                            }
                        }
                    }

                    string strJoin = string.Join(", ", nameList);
                    return strJoin;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS307-InstitutionSTD"
        public SortableBindingList<sp_MAS307_GetInstitutionSTD_Result> GetInstitutionSTD(MAS307_InstitutionSTD_Criteria criteria)
        {
            return service.GetInstitutionSTD(criteria);
        }
        public SortableBindingList<sp_MAS307_GetInstitutionSTD_Result> GetInstitutionSTD()
        {
            return service.GetInstitutionSTD(new MAS307_InstitutionSTD_Criteria());
        }
        public sp_MAS307_GetInstitutionSTD_Result GetInstitutionSTD(int ID)
        {
            return service.GetInstitutionSTD(new MAS307_InstitutionSTD_Criteria()
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
            }).FirstOrDefault();
        }
        public int SaveInstitutionSTD(sp_MAS307_GetInstitutionSTD_Result data)
        {
            return service.SaveInstitutionSTD(data);
        }
        public void CancelInstitutionSTD(sp_MAS307_GetInstitutionSTD_Result data, bool ISCANCEL)
        {
            service.CancelInstitutionSTD(data, ISCANCEL);
        }
        #endregion

        #region "MAS308-ToolPick"
        public SortableBindingList<sp_MAS308_GetToolPick_Result> GetToolPick(MAS308_ToolPick_Criteria criteria)
        {
            return service.GetToolPick(criteria);
        }
        public SortableBindingList<sp_MAS308_GetToolPick_Result> GetToolPick()
        {
            return service.GetToolPick(new MAS308_ToolPick_Criteria());
        }
        public sp_MAS308_GetToolPick_Result GetToolPick(int ID)
        {
            return service.GetToolPick(new MAS308_ToolPick_Criteria()
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
            }).FirstOrDefault();
        }
        public int SaveToolPick(sp_MAS308_GetToolPick_Result data)
        {
            return service.SaveToolPick(data);
        }
        public void CancelToolPick(sp_MAS308_GetToolPick_Result data, bool ISCANCEL)
        {
            service.CancelToolPick(data, ISCANCEL);
        }
        #endregion

        #region "MAS309-ToolAnalysis"
        public SortableBindingList<sp_MAS309_GetToolAnalysis_Result> GetToolAnalysis(MAS309_ToolAnalysis_Criteria criteria)
        {
            return service.GetToolAnalysis(criteria);
        }
        public SortableBindingList<sp_MAS309_GetToolAnalysis_Result> GetToolAnalysis()
        {
            return service.GetToolAnalysis(new MAS309_ToolAnalysis_Criteria());
        }
        public sp_MAS309_GetToolAnalysis_Result GetToolAnalysis(int ID)
        {
            return service.GetToolAnalysis(new MAS309_ToolAnalysis_Criteria()
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
            }).FirstOrDefault();
        }
        public int SaveToolAnalysis(sp_MAS309_GetToolAnalysis_Result data)
        {
            return service.SaveToolAnalysis(data);
        }
        public void CancelToolAnalysis(sp_MAS309_GetToolAnalysis_Result data, bool ISCANCEL)
        {
            service.CancelToolAnalysis(data, ISCANCEL);
        }
        #endregion

        #region "MAS310-LabExt"
        public SortableBindingList<sp_MAS310_GetLabExt_Result> GetLabExt(MAS310_LabExt_Criteria criteria)
        {
            return service.GetLabExt(criteria);
        }
        public SortableBindingList<sp_MAS310_GetLabExt_Result> GetLabExt()
        {
            return service.GetLabExt(new MAS310_LabExt_Criteria());
        }
        public sp_MAS310_GetLabExt_Result GetLabExt(int ID)
        {
            return service.GetLabExt(new MAS310_LabExt_Criteria()
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
            }).FirstOrDefault();
        }
        public int SaveLabExt(sp_MAS310_GetLabExt_Result data)
        {
            return service.SaveLabExt(data);
        }
        public void CancelLabExt(sp_MAS310_GetLabExt_Result data, bool ISCANCEL)
        {
            service.CancelLabExt(data, ISCANCEL);
        }
        #endregion
    }
}
