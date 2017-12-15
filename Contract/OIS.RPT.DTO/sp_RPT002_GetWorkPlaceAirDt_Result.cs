//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OIS.RPT.DTO
{
    using System;
    
    public partial class sp_RPT002_GetWorkPlaceAirDt_Result
    {
        public int ID { get; set; }
        public int WPA_ID { get; set; }
        public int SEQ { get; set; }
        public string LOC_NAME { get; set; }
        public string LOC_NAME_LV2 { get; set; }
        public string LOC_NAME_LV3 { get; set; }
        public System.DateTime SAMPLING_DATE { get; set; }
        public int PARAMETER_ID { get; set; }
        public System.TimeSpan SAMPLING_TIME { get; set; }
        public Nullable<decimal> AIR_FLOW { get; set; }
        public int SAMPLING_MINS { get; set; }
        public Nullable<decimal> AIR_VOLUME { get; set; }
        public decimal RESULT_VALUE { get; set; }
        public bool LESS_RESULT_VALUE { get; set; }
        public int UNIT_ID { get; set; }
        public Nullable<decimal> STANDARD_THAI { get; set; }
        public Nullable<decimal> STANDARD_ACGIH { get; set; }
        public bool CEILING_LIMIT { get; set; }
        public string CRT_ID { get; set; }
        public System.DateTime CRT_DATE { get; set; }
        public string CRT_MACHINE { get; set; }
        public string UPD_ID { get; set; }
        public Nullable<System.DateTime> UPD_DATE { get; set; }
        public string UPD_MACHINE { get; set; }
        public string DEL_ID { get; set; }
        public Nullable<System.DateTime> DEL_DATE { get; set; }
        public string DEL_MACHINE { get; set; }
        public string PARAMETER_NAME { get; set; }
        public string CRT_NAME { get; set; }
        public string UPD_NAME { get; set; }
        public string DEL_NAME { get; set; }
        public string UNIT_NAME { get; set; }
        public Nullable<decimal> MRL_VALUE { get; set; }
        public string REMARK { get; set; }
        public bool WAIT_RESULT { get; set; }
    }
}
