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
    
    public partial class sp_RPT001_GetWorkPlaceLightReport_Result
    {
        public int ID { get; set; }
        public string REPORTNUMBER { get; set; }
        public int CUSTOMER_ID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string CUSTOMER_ADDR { get; set; }
        public Nullable<int> CUSTOMER_PROJECT_ID { get; set; }
        public string CUSTOMER_PROJECT_NAME { get; set; }
        public string CUSTOMER_PROJECT_ADDR { get; set; }
        public string MEASURED_DATE { get; set; }
        public string MEASURED_TIME { get; set; }
        public string MEASURED_BY { get; set; }
        public string INSTRUMENT { get; set; }
        public Nullable<bool> HAS_NOT_WITHIN_STANDARD { get; set; }
        public Nullable<int> DETAIL_ID { get; set; }
        public string LOC_NAME_LV3 { get; set; }
        public string LOC_NAME_LV2 { get; set; }
        public string LOC_NAME { get; set; }
        public Nullable<int> STDLIGHT_ID { get; set; }
        public string STDLIGHT_NAME { get; set; }
        public Nullable<int> RESULT_DAY { get; set; }
        public Nullable<int> RESULT_NIGHT { get; set; }
        public Nullable<int> STDLIGHT_STANDARD { get; set; }
        public string RESULT_DAY_STR { get; set; }
        public string RESULT_NIGHT_STR { get; set; }
        public string STDLIGHT_STANDARD_STR { get; set; }
        public string CONDITION { get; set; }
        public Nullable<bool> HAS_PROJECT { get; set; }
        public Nullable<bool> HAS_NIGHT_RESULT { get; set; }
        public string LABSUPERVISOR_NAME { get; set; }
        public string LABSUPERVISOR_NO { get; set; }
        public Nullable<bool> HAS_DAY_RESULT { get; set; }
        public string REGISTRATION_NAME { get; set; }
        public string REGISTRATION_NO { get; set; }
        public Nullable<int> SEQ { get; set; }
        public string CONT_STR { get; set; }
        public Nullable<int> TOTAL_LINE { get; set; }
        public int TOTAL_LINE_LV3 { get; set; }
        public int TOTAL_LINE_LV2 { get; set; }
        public Nullable<int> TOTAL_LINE_SHOW { get; set; }
        public bool SHOW_LV3_EACH_PAGE { get; set; }
        public bool SHOW_LV3_CONT { get; set; }
        public bool SHOW_LV2_CONT { get; set; }
        public bool SHOW_PROJECT_ADDR { get; set; }
        public string REVISION { get; set; }
    }
}
