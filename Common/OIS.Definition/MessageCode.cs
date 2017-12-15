using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIS.Definition
{
    public static class MessageCode
    {
        /// <summary>
        /// ไม่พบข้อมูล
        /// </summary>
        public static string INF0001 = "ไม่พบข้อมูล";
        /// <summary>
        /// บันทึกข้อมูลเรียบร้อยแล้ว
        /// </summary>
        public static string INF0002 = "บันทึกข้อมูลเรียบร้อยแล้ว";
        /// <summary>
        /// การทำงานเสร็จสมบูรณ์
        /// </summary>
        public static string INF0003 = "การทำงานเสร็จสมบูรณ์";
        /// <summary>
        /// ยกเลิกข้อมูลเรียบร้อยแล้ว
        /// </summary>
        public static string INF0004 = "ยกเลิกข้อมูลเรียบร้อยแล้ว";
        /// <summary>
        /// กู้คืนข้อมูลเรียบร้อยแล้ว
        /// </summary>
        public static string INF0005 = "กู้คืนข้อมูลเรียบร้อยแล้ว";

        /// <summary>
        /// คุณต้องการจะบันทึกข้อมูลใช่หรือไม่?
        /// </summary>
        public static string CFM0001 = "คุณต้องการจะบันทึกข้อมูลใช่หรือไม่?";
        /// <summary>
        /// คุณต้องการจะปิดโปรแกรมใช่หรือไม่?
        /// </summary>
        public static string CFM0002 = "คุณต้องการจะปิดโปรแกรมใช่หรือไม่?";
        /// <summary>
        /// คุณต้องการจะยกเลิกใช่หรือไม่?
        /// </summary>
        public static string CFM0003 = "คุณต้องการจะยกเลิกใช่หรือไม่?";
        /// <summary>
        /// คุณต้องการจะกู้คืนใช่หรือไม่?
        /// </summary>
        public static string CFM0004 = "คุณต้องการจะกู้คืนใช่หรือไม่?";
    }
}
