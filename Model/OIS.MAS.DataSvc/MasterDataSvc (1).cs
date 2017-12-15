using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using OIS.Common;
using OIS.MAS.DTO;
using OIS.MAS.DTO.Criteria;
using AutoMapper;

namespace OIS.MAS.DataSvc
{
    public class MasterDataSvc
    {
        #region "MAS101-User"
        public SortableBindingList<sp_MAS101_GetUser_Result> GetUser(MAS101_User_Criteria criteria)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS101_GetUser(criteria.ID,
                        criteria.NAME,
                        criteria.DIVISION_ID,
                        criteria.SUBDIVISION_ID,
                        criteria.POSITION_ID,
                        criteria.GROUP_ID,
                        criteria.SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS101_GetUser_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool IsExistsUser(string userId)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    bool result = ct.TBM_USER.Where(x => x.ID == userId).Any();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string SaveUser(sp_MAS101_GetUser_Result user)
        {
            try
            {
                string ID;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS101_SaveUser(user.ID,
                        user.PRENAME_ID,
                        user.FNAME_EN,
                        user.LNAME_EN,
                        user.FNAME_TH,
                        user.LNAME_TH,
                        user.NICKNAME,
                        user.IDCARD,
                        user.BIRTHDATE,
                        user.STARTDATE,
                        user.DIVISION_ID,
                        user.SUBDIVISION_ID,
                        user.POSITION_ID,
                        user.GROUP_ID,
                        user.REGISTRATION_NO,
                        user.LABSUPERVISOR_NO,
                        user.USER_PIC,
                        user.PASS,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelUser(sp_MAS101_GetUser_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS101_CancelUser(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS102-Division"
        public SortableBindingList<sp_MAS102_GetDivision_Result> GetDivision(int? ID, string NAME, bool SHOW_DELETE_RECORD)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS102_GetDivision(ID, NAME, SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS102_GetDivision_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveDivision(sp_MAS102_GetDivision_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS102_SaveDivision(data.ID,
                        data.NAME_EN,
                        data.NAME_TH,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelDivision(sp_MAS102_GetDivision_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS102_CancelDivision(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS103-SubDivision"
        public SortableBindingList<sp_MAS103_GetSubDivision_Result> GetSubDivision(int? ID, int? DIVISION_ID, string NAME, bool SHOW_DELETE_RECORD)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS103_GetSubDivision(ID, DIVISION_ID, NAME, SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS103_GetSubDivision_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveSubDivision(sp_MAS103_GetSubDivision_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS103_SaveSubDivision(data.ID,
                        data.DIVISION_ID,
                        data.NAME_EN,
                        data.NAME_TH,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelSubDivision(sp_MAS103_GetSubDivision_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS103_CancelSubDivision(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS104-Position"
        public SortableBindingList<sp_MAS104_GetPosition_Result> GetPosition(int? ID, string NAME, bool SHOW_DELETE_RECORD)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS104_GetPosition(ID, NAME, SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS104_GetPosition_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SavePosition(sp_MAS104_GetPosition_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS104_SavePosition(data.ID,
                        data.NAME_EN,
                        data.NAME_TH,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelPosition(sp_MAS104_GetPosition_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS104_CancelPosition(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS105-PreName"
        public SortableBindingList<sp_MAS105_GetPreName_Result> GetPreName(int? ID, string NAME, bool SHOW_DELETE_RECORD)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS105_GetPreName(ID, NAME, SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS105_GetPreName_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SavePreName(sp_MAS105_GetPreName_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS105_SavePreName(data.ID,
                        data.NAME_EN,
                        data.NAME_TH,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelPreName(sp_MAS105_GetPreName_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS105_CancelPreName(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS106-Group"
        public SortableBindingList<sp_MAS106_GetGroup_Result> GetGroup(int? ID, string NAME, bool SHOW_DELETE_RECORD)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS106_GetGroup(ID, NAME, SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS106_GetGroup_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public GroupDTO GetGroup(int ID)
        {
            try
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<sp_MAS106_GetGroup_Result, GroupDTO>();
                });

                IMapper mapper = config.CreateMapper();

                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS106_GetGroup(ID, null, true).FirstOrDefault();
                    GroupDTO group = mapper.Map<sp_MAS106_GetGroup_Result, GroupDTO>(result);
                    group.Permission = new SortableBindingList<sp_MAS106_GetGroupPermission_Result>(ct.sp_MAS106_GetGroupPermission(ID).ToList());
                    group.User = new SortableBindingList<sp_MAS106_GetGroupUser_Result>(ct.sp_MAS106_GetGroupUser(ID).ToList());
                    return group;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveGroup(GroupDTO data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS106_SaveGroup(data.ID,
                        data.NAME_EN,
                        data.NAME_TH,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();

                    if (data.ID == 0)
                    {
                        data.ID = ID;
                    }

                    var permissionList = ct.sp_MAS106_GetGroupPermission(data.ID).ToList();
                    foreach (var pApp in data.Permission)
                    {
                        foreach (var pDB in permissionList)
                        {
                            if (pDB.MENU_ID == pApp.MENU_ID && pDB.IS_ALLOW != pApp.IS_ALLOW)
                            {
                                ct.sp_MAS106_SaveGroupPermission(data.ID, pApp.MENU_ID, pApp.IS_ALLOW, OISDataInfo.UserInfomation.USER_ID);
                            }
                        }
                    }

                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelGroup(GroupDTO data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS106_CancelGroup(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SortableBindingList<sp_MAS106_GetGroupPermission_Result> GetGroupPermission(int ID)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS106_GetGroupPermission(ID).ToList();
                    return new SortableBindingList<sp_MAS106_GetGroupPermission_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS201-Customer"
        public SortableBindingList<sp_MAS201_GetCustomer_Result> GetCustomer(int? ID, string NAME, string ADDR, bool SHOW_DELETE_RECORD)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS201_GetCustomer(ID, NAME, ADDR, SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS201_GetCustomer_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveCustomer(sp_MAS201_GetCustomer_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS201_SaveCustomer(data.ID,
                        data.NAME_EN,
                        data.NAME_TH,
                        data.ADDR_NO,
                        data.MOO,
                        data.BUILDING_EN,
                        data.BUILDING_TH,
                        data.ALLEY_EN,
                        data.ALLEY_TH,
                        data.LANE_EN,
                        data.LANE_TH,
                        data.ROAD_EN,
                        data.ROAD_TH,
                        data.SUBDISTRICT_EN,
                        data.SUBDISTRICT_TH,
                        data.DISTRICT_EN,
                        data.DISTRICT_TH,
                        data.PROVINCE_ID,
                        data.POSTCODE,
                        data.COUNTRY,
                        data.DEFAULT_LANGUAGE,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelCustomer(sp_MAS201_GetCustomer_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS201_CancelCustomer(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS202-CustomerProject"
        public SortableBindingList<sp_MAS202_GetCustomerProject_Result> GetCustomerProject(int? ID, string NAME, string ADDR, int? CUSTOMER_ID, bool SHOW_DELETE_RECORD)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS202_GetCustomerProject(ID, NAME, ADDR, CUSTOMER_ID, SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS202_GetCustomerProject_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveCustomerProject(sp_MAS202_GetCustomerProject_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS202_SaveCustomerProject(data.ID,
                        data.NAME_EN,
                        data.NAME_TH,
                        data.ADDR_NO,
                        data.MOO,
                        data.BUILDING_EN,
                        data.BUILDING_TH,
                        data.ALLEY_EN,
                        data.ALLEY_TH,
                        data.LANE_EN,
                        data.LANE_TH,
                        data.ROAD_EN,
                        data.ROAD_TH,
                        data.SUBDISTRICT_EN,
                        data.SUBDISTRICT_TH,
                        data.DISTRICT_EN,
                        data.DISTRICT_TH,
                        data.PROVINCE_ID,
                        data.POSTCODE,
                        data.DEFAULT_LANGUAGE,
                        data.CUSTOMER_ID,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelCustomerProject(sp_MAS202_GetCustomerProject_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS202_CancelCustomerProject(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS203-Province"
        public SortableBindingList<sp_MAS203_GetProvince_Result> GetProvince(int? ID, string Name, bool SHOW_DELETE_RECORD)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS203_GetProvince(ID, Name, SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS203_GetProvince_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveProvince(sp_MAS203_GetProvince_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS203_SaveProvince(data.ID,
                        data.NAME_EN,
                        data.NAME_TH,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelProvince(sp_MAS203_GetProvince_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS203_CancelProvince(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS301-Unit"
        public SortableBindingList<sp_MAS301_GetUnit_Result> GetUnit(int? ID, string Name, bool SHOW_DELETE_RECORD)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS301_GetUnit(ID, Name, SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS301_GetUnit_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveUnit(sp_MAS301_GetUnit_Result unit)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS301_SaveUnit(unit.ID, unit.NAME, unit.SEQ, OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelUnit(sp_MAS301_GetUnit_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS301_CancelUnit(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS302-Standard Light Intensity"
        public SortableBindingList<sp_MAS302_GetSTDLight_Result> GetSTDLight(MAS302_STDLight_Criteria criteria)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS302_GetSTDLight(criteria.ID, criteria.TYPE_NAME, criteria.BUILDING_NAME, criteria.AREA_NAME, criteria.ALIAS_NAME, criteria.STANDARD_VALUE, criteria.SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS302_GetSTDLight_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveSTDLight(sp_MAS302_GetSTDLight_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS302_SaveSTDLight(data.ID,
                        data.NAME,
                        data.TYPE_NAME,
                        data.BUILDING_NAME,
                        data.ALIAS_NAME,
                        data.STANDARD,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelSTDLight(sp_MAS302_GetSTDLight_Result data, bool IS_CANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS302_CancelSTDLight(data.ID, IS_CANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS303-Instrument"
        public SortableBindingList<sp_MAS303_GetInstrument_Result> GetInstrument(MAS303_Instrument_Criteria criteria)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS303_GetInstrument(criteria.ID,
                        criteria.NAME,
                        criteria.MODEL,
                        criteria.SERIALNO,
                        criteria.SHOW_DELETE_RECORD,
                        criteria.SHOW_EXPIRED).ToList();
                    return new SortableBindingList<sp_MAS303_GetInstrument_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveInstrument(sp_MAS303_GetInstrument_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS303_SaveInstrument(data.ID,
                        data.NAME,
                        data.MODEL,
                        data.SERIALNO,
                        data.EXPIRE_DATE,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelInstrument(sp_MAS303_GetInstrument_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS303_CancelInstrument(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS304-Method Analysis"
        public SortableBindingList<sp_MAS304_GetMethodAnalysis_Result> GetMethodAnalysis(MAS304_MethodAnalysis_Criteria criteria)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS304_GetMethodAnalysis(criteria.ID,
                        criteria.NAME,
                        criteria.INSTITUTION_STD_ID,
                        criteria.SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS304_GetMethodAnalysis_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveMethodAnalysis(sp_MAS304_GetMethodAnalysis_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS304_SaveMethodAnalysis(data.ID,
                        data.NAME,
                        data.INSTITUTION_ID,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelMethodAnalysis(sp_MAS304_GetMethodAnalysis_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS304_CancelMethodAnalysis(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS305-Parameter Analysis"
        public SortableBindingList<sp_MAS305_GetParameterAnalysis_Result> GetParameterAnalysis(MAS305_ParameterAnalysis_Criteria criteria)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS305_GetParameterAnalysis(criteria.ID,
                        criteria.NAME,
                        criteria.METHOD_ID,
                        criteria.UNIT_ID,
                        criteria.STANDARD,
                        criteria.TOOL_PICK,
                        criteria.TOOL_ANALYSIS,
                        criteria.SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS305_GetParameterAnalysis_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveParameterAnalysis(sp_MAS305_GetParameterAnalysis_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS305_SaveParameterAnalysis(data.ID,
                        data.NAME,
                        data.ANALYSIS_DETAIL,
                        data.METHOD_REMARK,
                        data.METHOD_ID,
                        data.METHOD_REF,
                        data.METHOD_REF_NO,
                        data.UNIT_ID,
                        data.STANDARD_THAI,
                        data.STANDARD_ACGIH,
                        data.CEILING_LIMIT,
                        data.MRL_VALUE,
                        data.MRL_VALUE_DIV,
                        data.LOD_VALUE,
                        data.LOD_VALUE_DIV,
                        data.IDL_VALUE,
                        data.LAB_EXT_ID,
                        data.TOOL_PICK_ID,
                        data.TOOL_ANALYSIS_ID,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelParameterAnalysis(sp_MAS305_GetParameterAnalysis_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS305_CancelParameterAnalysis(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS306-Condition Light"
        public SortableBindingList<sp_MAS306_GetConditionLight_Result> GetConditionLight(MAS306_ConditionLight_Criteria criteria)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS306_GetConditionLight(criteria.ID,
                        criteria.CODE,
                        criteria.NAME,
                        criteria.SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS306_GetConditionLight_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveConditionLight(sp_MAS306_GetConditionLight_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS306_SaveConditionLight(data.ID,
                        data.CODE,
                        data.NAME,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelConditionLight(sp_MAS306_GetConditionLight_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS306_CancelConditionLight(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS307-Institution"
        public SortableBindingList<sp_MAS307_GetInstitutionSTD_Result> GetInstitutionSTD(MAS307_InstitutionSTD_Criteria criteria)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS307_GetInstitutionSTD(criteria.ID,
                        criteria.NAME,
                        criteria.SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS307_GetInstitutionSTD_Result>(result);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int SaveInstitutionSTD(sp_MAS307_GetInstitutionSTD_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS307_SaveInstitutionSTD(data.ID,
                        data.NAME,
                        data.SHORT_NAME,
                        data.EDITION_NAME,
                        data.PAGE_FROM,
                        data.PAGE_TO,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void CancelInstitutionSTD(sp_MAS307_GetInstitutionSTD_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS307_CancelInstitutionSTD(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS308-ToolPick"
        public SortableBindingList<sp_MAS308_GetToolPick_Result> GetToolPick(MAS308_ToolPick_Criteria criteria)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS308_GetToolPick(criteria.ID,
                        criteria.NAME,
                        criteria.SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS308_GetToolPick_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveToolPick(sp_MAS308_GetToolPick_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS308_SaveToolPick(data.ID,
                        data.NAME,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelToolPick(sp_MAS308_GetToolPick_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS308_CancelToolPick(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS309-ToolAnalysis"
        public SortableBindingList<sp_MAS309_GetToolAnalysis_Result> GetToolAnalysis(MAS309_ToolAnalysis_Criteria criteria)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS309_GetToolAnalysis(criteria.ID,
                        criteria.NAME,
                        criteria.SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS309_GetToolAnalysis_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveToolAnalysis(sp_MAS309_GetToolAnalysis_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS309_SaveToolAnalysis(data.ID,
                        data.NAME,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelToolAnalysis(sp_MAS309_GetToolAnalysis_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS309_CancelToolAnalysis(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS310-LabExt"
        public SortableBindingList<sp_MAS310_GetLabExt_Result> GetLabExt(MAS310_LabExt_Criteria criteria)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS310_GetLabExt(criteria.ID,
                        criteria.NAME,
                        criteria.SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_MAS310_GetLabExt_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveLabExt(sp_MAS310_GetLabExt_Result data)
        {
            try
            {
                int ID = 0;
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_MAS310_SaveLabExt(data.ID,
                        data.NAME,
                        data.SEQ,
                        OISDataInfo.UserInfomation.USER_ID).FirstOrDefault().GetValueOrDefault();
                    trans.Complete();
                }
                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelLabExt(sp_MAS310_GetLabExt_Result data, bool ISCANCEL)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ct.sp_MAS310_CancelLabExt(data.ID, ISCANCEL, OISDataInfo.UserInfomation.USER_ID);
                    trans.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "MAS Dialog"
        public SortableBindingList<sp_MAS_DialogCustomerLocation_Result> GetCustomerLocation(int? CustomerId)
        {
            try
            {
                using (OIS_MASEntities ct = new OIS_MASEntities())
                {
                    var result = ct.sp_MAS_DialogCustomerLocation(CustomerId).ToList();
                    return new SortableBindingList<sp_MAS_DialogCustomerLocation_Result>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
