using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OIS.Common;
using OIS.Common.Extensions;
using OIS.Common.Utils;
using OIS.RPT.DataSvc;
using OIS.RPT.DTO;
using OIS.RPT.DTO.Criteria;
using AutoMapper;
using System.Data;

namespace OIS.ViewModel
{
    public class ReportViewModel
    {
        #region "Variable"
        ReportDataSvc service;
        IMapper mapper;
        #endregion

        #region "Constructor"
        public ReportViewModel()
        {
            service = new ReportDataSvc();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<sp_RPT001_GetWorkPlaceLight_Result, RPT001_WorkPlaceLightDTO>();
                cfg.CreateMap<List<sp_RPT001_GetWorkPlaceLight_Result>, List<RPT001_WorkPlaceLightDTO>>();
                cfg.CreateMap<sp_RPT002_GetWorkPlaceAir_Result, RPT002_WorkPlaceAirDTO>();
                cfg.CreateMap<List<sp_RPT002_GetWorkPlaceAir_Result>, List<RPT002_WorkPlaceAirDTO>>();
            });
            mapper = config.CreateMapper();
        }
        #endregion

        #region "RPT001-WorkPlaceLightIntensity"
        public SortableBindingList<sp_RPT001_GetWorkPlaceLight_Result> GetWorkPlaceLight(RPT001_WorkPlaceLight_Criteria criteria)
        {
            return service.GetWorkPlaceLight(criteria);
        }
        public RPT001_WorkPlaceLightDTO GetWorkPlaceLight(int ID)
        {
            var result = service.GetWorkPlaceLight(new RPT001_WorkPlaceLight_Criteria()
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
            }).FirstOrDefault();
            if(result == null)
            {
                result = new sp_RPT001_GetWorkPlaceLight_Result();
            }
            RPT001_WorkPlaceLightDTO wplDTO = mapper.Map<sp_RPT001_GetWorkPlaceLight_Result, RPT001_WorkPlaceLightDTO>(result);
            wplDTO.Detail = service.GetWorkPlaceLightDt(ID);
            wplDTO.Instrument = service.GetWorkPlaceLightInstrument(ID);
            wplDTO.User = service.GetWorkPlaceLightUser(ID);
            return wplDTO;
        }
        public int SaveWorkPlaceLight(RPT001_WorkPlaceLightDTO data)
        {
            return service.SaveWorkPlaceLight(data);
        }
        public void CancelWorkPlaceLight(RPT001_WorkPlaceLightDTO data, bool IS_CANCEL)
        {
            service.SaveWorkPlaceLight(data, IS_CANCEL);
        }
        public SortableBindingList<sp_RPT001_GetWorkPlaceLightReport_Result> GetWorkPlaceLightReport(int ID)
        {
            return service.GetWorkPlaceLightReport(ID);
        }
        #endregion

        #region "RPT002-WorkPlaceAirQuality"
        public SortableBindingList<sp_RPT002_GetWorkPlaceAir_Result> GetWorkPlaceAir(RPT002_WorkPlaceAir_Criteria criteria)
        {
            return service.GetWorkPlaceAir(criteria);
        }
        public RPT002_WorkPlaceAirDTO GetWorkPlaceAir(int ID)
        {
            var result = service.GetWorkPlaceAir(new RPT002_WorkPlaceAir_Criteria
            {
                ID = ID,
                SHOW_DELETE_RECORD = true,
            }).FirstOrDefault();
            if(result == null)
            {
                result = new sp_RPT002_GetWorkPlaceAir_Result();
            }
            RPT002_WorkPlaceAirDTO wpaDTO = mapper.Map<sp_RPT002_GetWorkPlaceAir_Result, RPT002_WorkPlaceAirDTO>(result);
            wpaDTO.Detail = service.GetWorkPlaceAirDt(ID);
            wpaDTO.User = service.GetWorkPlaceAirUser(ID);
            return wpaDTO;
        }
        public int SaveWorkPlaceAir(RPT002_WorkPlaceAirDTO data)
        {
            return service.SaveWorkPlaceAir(data, false);
        }
        public void CancelWorkPlaceAir(RPT002_WorkPlaceAirDTO data, bool IS_CANCEL)
        {
            service.SaveWorkPlaceAir(data, IS_CANCEL);
        }
        public List<sp_RPT002_GetWorkPlaceAirReport_2_Result> GetWorkPlaceAirReport_2(int ID)
        {
            return service.GetWorkPlaceAirReport_2(ID);
        }
        #endregion
    }
}
