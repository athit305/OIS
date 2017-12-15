using System;
using System.ComponentModel;
using System.Linq;
using System.Transactions;
using OIS.Common;
using OIS.RPT.DTO;
using OIS.RPT.DTO.Criteria;
using AutoMapper;
using System.Collections.Generic;
using System.Data;
using OIS.Common.Extensions;

namespace OIS.RPT.DataSvc
{
    public class ReportDataSvc
    {
        #region "RPT001-WorkPlaceLightIntensity"
        public SortableBindingList<sp_RPT001_GetWorkPlaceLight_Result> GetWorkPlaceLight(RPT001_WorkPlaceLight_Criteria criteria)
        {
            try
            {
                //var config = new MapperConfiguration(cfg => {
                //    cfg.CreateMap<sp_RPT001_GetWorkPlaceLight_Result, RPT001_WorkPlaceLightDTO>();
                //    cfg.CreateMap<List<sp_RPT001_GetWorkPlaceLight_Result>, List<RPT001_WorkPlaceLightDTO>>();
                //});
                //IMapper mapper = config.CreateMapper();

                using (OIS_RPTEntities ct = new OIS_RPTEntities())
                {
                    var result = ct.sp_RPT001_GetWorkPlaceLight(
                        criteria.ID,
                        criteria.REPORTNUMBER,
                        criteria.CUSTOMER_ID,
                        criteria.DATE_FROM,
                        criteria.DATE_TO,
                        criteria.MEASURED_BY,
                        criteria.INSTRUMENT_ID,
                        criteria.CRT_USER_ID,
                        criteria.SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_RPT001_GetWorkPlaceLight_Result>(result);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetWorkPlaceLightDt(int ID)
        {
            try
            {
                using (OIS_RPTEntities ct = new OIS_RPTEntities())
                {
                    var result = ct.sp_RPT001_GetWorkPlaceLightDt(ID).ToList();
                    if(result == null)
                    {
                        result = new List<sp_RPT001_GetWorkPlaceLightDt_Result>();
                    }
                    return result.ToDataTable();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetWorkPlaceLightInstrument(int ID)
        {
            try
            {
                using (OIS_RPTEntities ct = new OIS_RPTEntities())
                {
                    var result = ct.TBR_WORK_PLACE_LIGHT_INSTRUMENT.Where(x => x.ID == ID).ToList();
                    if(result == null)
                    {
                        result = new List<TBR_WORK_PLACE_LIGHT_INSTRUMENT>();
                    }
                    return result.ToDataTable();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetWorkPlaceLightUser(int ID)
        {
            try
            {
                using (OIS_RPTEntities ct = new OIS_RPTEntities())
                {
                    var result = ct.TBR_WORK_PLACE_LIGHT_USER.Where(x => x.ID == ID).ToList();
                    if(result == null)
                    {
                        result = new List<TBR_WORK_PLACE_LIGHT_USER>();
                    }
                    return result.ToDataTable();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveWorkPlaceLight(RPT001_WorkPlaceLightDTO data, bool IS_CANCEL = false)
        {
            try
            {
                int ID = 0;
                using (OIS_RPTEntities ct = new OIS_RPTEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_RPT001_SaveWorkPlaceLight(data.ID,
                        data.REPORT_CODE,
                        data.CUSTOMER_ID,
                        data.CUSTOMER_LANG,
                        data.CUSTOMER_NAME,
                        data.CUSTOMER_ADDR,
                        data.CUSTOMER_PROJECT_ID,
                        data.CUSTOMER_PROJECT_LANG,
                        data.CUSTOMER_PROJECT_NAME,
                        data.CUSTOMER_PROJECT_ADDR,
                        data.MEASURED_DATE,
                        data.MEASURED_DATE_TO,
                        data.MEASURED_TIME_FROM,
                        data.MEASURED_TIME_TO,
                        data.MEASURED_DATE_NIGHT,
                        data.MEASURED_DATE_NIGHT_TO,
                        data.MEASURED_TIME_FROM_NIGHT,
                        data.MEASURED_TIME_TO_NIGHT,
                        data.MEASURED_BY,
                        data.MEASURED_INSTRUMENT_ID,
                        data.REGISTRATION_ID,
                        data.LAB_SUPERVISOR_ID,
                        data.SHOW_LV3_EACH_PAGE,
                        data.SHOW_LV3_CONT,
                        data.SHOW_LV2_CONT,
                        data.SHOW_PROJECT_ADDR,
                        OISDataInfo.UserInfomation.USER_ID,
                        IS_CANCEL).FirstOrDefault().GetValueOrDefault();
                    if (data.Detail != null)
                    {
                        foreach (DataRow dr in data.Detail.Rows)
                        {
                            ct.sp_RPT001_SaveWorkPlaceLightDt(dr.Field<int?>("ID"),
                                ID,
                                null,
                                dr.Field<string>("LOC_NAME"),
                                dr.Field<string>("LOC_NAME_LV2"),
                                dr.Field<string>("LOC_NAME_LV3"),
                                dr.Field<int?>("STDLIGHT_ID"),
                                dr.Field<string>("STDLIGHT_NAME"),
                                dr.Field<int>("STDLIGHT_STANDARD"),
                                dr.Field<int?>("RESULT_DAY"),
                                dr.Field<int?>("RESULT_NIGHT"),
                                dr.Field<string>("CONDITION"),
                                OISDataInfo.UserInfomation.USER_ID,
                                false);
                        }
                    }
                    string sql = "";
                    if (data.Instrument != null)
                    {
                        foreach (DataRow dr in data.Instrument.Rows)
                        {
                            if(sql.Length > 0)
                            {
                                sql = sql + Environment.NewLine;
                            }
                            sql = sql + string.Format("INSERT INTO TBR_WORK_PLACE_LIGHT_INSTRUMENT VALUES ({0}, {1});", ID, dr.Field<int>("MEASURED_INSTRUMENT_ID"));
                        }
                    }
                    if (data.User != null)
                    {
                        foreach (DataRow dr in data.User.Rows)
                        {
                            if (sql.Length > 0)
                            {
                                sql = sql + Environment.NewLine;
                            }
                            sql = sql + string.Format("INSERT INTO TBR_WORK_PLACE_LIGHT_USER VALUES ({0}, '{1}');", ID, dr.Field<string>("MEASURED_BY"));
                        }
                    }
                    if (sql.Length > 0)
                    {
                        ct.Database.ExecuteSqlCommand(sql);
                    }
                    trans.Complete();
                }
                return ID;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public SortableBindingList<sp_RPT001_GetWorkPlaceLightReport_Result> GetWorkPlaceLightReport(int ID)
        {
            try
            {
                using (OIS_RPTEntities ct = new OIS_RPTEntities())
                {
                    var result = ct.sp_RPT001_GetWorkPlaceLightReport(ID).ToList();
                    return new SortableBindingList<sp_RPT001_GetWorkPlaceLightReport_Result>(result);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "RPT002-WorkPlaceAirQuality"
        public SortableBindingList<sp_RPT002_GetWorkPlaceAir_Result> GetWorkPlaceAir(RPT002_WorkPlaceAir_Criteria criteria)
        {
            try
            {
                using (OIS_RPTEntities ct = new OIS_RPTEntities())
                {
                    var result = ct.sp_RPT002_GetWorkPlaceAir(criteria.ID,
                        criteria.ANALYSYS_NO,
                        criteria.JOB_NO,
                        criteria.CUSTOMER_ID,
                        criteria.ANALYTICAL_DATE_FROM,
                        criteria.ANALYTICAL_DATE_TO,
                        criteria.SAMPLING_DATE_FROM,
                        criteria.SAMPLING_DATE_TO,
                        criteria.SAMPING_BY,
                        criteria.SHOW_DELETE_RECORD).ToList();
                    return new SortableBindingList<sp_RPT002_GetWorkPlaceAir_Result>(result);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetWorkPlaceAirDt(int ID)
        {
            try
            {
                using (OIS_RPTEntities ct = new OIS_RPTEntities())
                {
                    var result = ct.sp_RPT002_GetWorkPlaceAirDt(ID).ToList();
                    if(result == null)
                    {
                        result = new List<sp_RPT002_GetWorkPlaceAirDt_Result>();
                    }
                    var bd = result.ToDataTable();
                    return bd;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetWorkPlaceAirUser(int ID)
        {
            try
            {
                using (OIS_RPTEntities ct = new OIS_RPTEntities())
                {
                    var result = ct.TBR_WORK_PLACE_AIR_USER.Where(x => x.ID == ID).ToList();
                    if (result == null)
                    {
                        result = new List<TBR_WORK_PLACE_AIR_USER>();
                    }
                    return result.ToDataTable();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveWorkPlaceAir(RPT002_WorkPlaceAirDTO data, bool IS_CANCEL)
        {
            try
            {
                int ID = 0;
                using (OIS_RPTEntities ct = new OIS_RPTEntities())
                using (TransactionScope trans = new TransactionScope())
                {
                    ID = ct.sp_RPT002_SaveWorkPlaceAir(data.ID,
                        data.REPORT_DATE,
                        data.REPORT_TYPE,
                        data.ANALYSYS_NO,
                        data.CUSTOMER_ID,
                        data.CUSTOMER_ADDR,
                        data.CUSTOMER_PROJECT_ID,
                        data.CUSTOMER_PROJECT_ADDR,
                        data.RECEIVED_DATE,
                        data.ANALYTICAL_DATE_FROM,
                        data.ANALYTICAL_DATE_TO,
                        data.ANALYSIS_ID,
                        data.JOB_NO,
                        data.SAMPLING_BY,
                        data.REGISTRATION_ID,
                        data.LAB_SUPERVISOR_ID,
                        data.AGENT_FLAG,
                        data.AGENT_NAME,
                        data.SHOW_LV3_EACH_PAGE,
                        data.SHOW_LV3_CONT,
                        data.SHOW_LV2_CONT,
                        data.SHOW_PROJECT_ADDR,
                        OISDataInfo.UserInfomation.USER_ID,
                        IS_CANCEL).FirstOrDefault().GetValueOrDefault();
                    if (data.Detail != null)
                    {
                        foreach (DataRow dr in data.Detail.Rows)
                        {
                            ct.sp_RPT002_SaveWorkPlaceAirDt(dr.Field<int?>("ID"),
                                ID,
                                null,
                                dr.Field<string>("LOC_NAME"),
                                dr.Field<string>("LOC_NAME_LV2"),
                                dr.Field<string>("LOC_NAME_LV3"),
                                dr.Field<DateTime>("SAMPLING_DATE"),
                                dr.Field<int>("PARAMETER_ID"),
                                dr.Field<TimeSpan>("SAMPLING_TIME"),
                                dr.Field<decimal?>("AIR_FLOW"),
                                dr.Field<int>("SAMPLING_MINS"),
                                dr.Field<decimal?>("AIR_VOLUME"),
                                dr.Field<decimal?>("RESULT_VALUE"),
                                dr.Field<bool>("LESS_RESULT_VALUE"),
                                dr.Field<int>("UNIT_ID"),
                                dr.Field<decimal?>("STANDARD_THAI"),
                                dr.Field<decimal?>("STANDARD_ACGIH"),
                                dr.Field<bool>("CEILING_LIMIT"),
                                dr.Field<bool>("WAIT_RESULT"),
                                dr.Field<string>("REMARK"),
                                OISDataInfo.UserInfomation.USER_ID,
                                false);
                        }
                    }
                    string sql = "";
                    if (data.User != null)
                    {
                        foreach (DataRow dr in data.User.Rows)
                        {
                            if (sql.Length > 0)
                            {
                                sql = sql + Environment.NewLine;
                            }
                            sql = sql + string.Format("INSERT INTO TBR_WORK_PLACE_AIR_USER VALUES ({0}, '{1}');", ID, dr.Field<string>("SAMPLING_BY"));
                        }
                    }
                    if (sql.Length > 0)
                    {
                        ct.Database.ExecuteSqlCommand(sql);
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

        public List<sp_RPT002_GetWorkPlaceAirReport_2_Result> GetWorkPlaceAirReport_2(int ID)
        {
            try
            {
                using (OIS_RPTEntities ct = new OIS_RPTEntities())
                {
                    var result = ct.sp_RPT002_GetWorkPlaceAirReport_2(ID).ToList();
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
