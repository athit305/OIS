using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace OIS.Common.Extensions
{
    public static class StringExtension
    {
        public static bool IsNull(this string Text)
        {
            return Text == null || Text.Length == 0;
        }
        public static bool HasValue(this string Text)
        {
            return Text != null && Text.Trim().Length > 0;
        }
        public static bool IsNumeric(this string Text)
        {
            int n;
            bool isNumeric = int.TryParse(Text, out n);
            return isNumeric;
        }
        public static int? ToInt(this string Text)
        {
            if(Text.IsNumeric())
            {
                int i = Convert.ToInt32(Text);
                return i;
            }
            else
            {
                return null;
            }
        }
        public static string GetValueOrDefault(this string Text)
        {
            return GetValueOrDefault(Text, "");
        }
        public static string GetValueOrDefault(this string Text, string defaultValue)
        {
            if(Text.IsNull())
            {
                return defaultValue;
            }
            else
            {
                return Text;
            }
        }
        public static string ReplaceInvalidFileNameChars(this string Text)
        {
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());

            foreach (char c in invalid)
            {
                Text = Text.Replace(c.ToString(), "");
            }
            return Text;
        }
        public static DateTime? ToDateTime(this string text)
        {
            try
            {
                DateTime? Date = null;
                if (!text.IsNull())
                {
                    if (text == Date.ToStringDate())
                    {

                    }
                    else if (text.IsNumeric())
                    {
                        if (text.Substring(0, 1) == "+" || text.Substring(0, 1) == "-")
                        {
                            Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(text.ToInt().GetValueOrDefault());
                        }
                        else
                        {
                            if (text.ToInt() == 0)
                            {
                                Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                            }
                            else if (text.Length <= 2)
                            {
                                Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, text.ToInt().GetValueOrDefault());
                            }
                            else if (text.Length <= 4)
                            {
                                int dd = text.Substring(0, 2).ToInt().GetValueOrDefault();
                                int mm = text.Substring(2, 2).ToInt().GetValueOrDefault();
                                Date = new DateTime(DateTime.Now.Year, mm, dd);
                            }
                            else if (text.Length <= 6)
                            {
                                int dd = text.Substring(0, 2).ToInt().GetValueOrDefault();
                                int mm = text.Substring(2, 2).ToInt().GetValueOrDefault();
                                int yy = text.Substring(4, 2).ToInt().GetValueOrDefault();

                                int year = (DateTime.Now.Year + 543) - ((DateTime.Now.Year + 543) % 100);
                                year = Convert.ToInt32("20" + yy);
                                if (year > DateTime.Now.Year + 5)
                                {
                                    year = Convert.ToInt32((DateTime.Now.Year + 543).ToString().Substring(0, 2) + yy);
                                    year = year - 543;
                                }

                                Date = new DateTime(year, mm, dd);
                            }
                            else if (text.Length <= 8)
                            {
                                int dd = text.Substring(0, 2).ToInt().GetValueOrDefault();
                                int mm = text.Substring(2, 2).ToInt().GetValueOrDefault();
                                int yyyy = text.Substring(4, 4).ToInt().GetValueOrDefault();
                                if (yyyy > DateTime.Now.Year + 5)
                                {
                                    yyyy = yyyy - 543;
                                }
                                Date = new DateTime(yyyy, mm, dd);
                            }
                            else
                            {
                                Date = null;
                            }
                        }
                    }
                    else if (!text.IsNumeric())
                    {
                        if (text.IndexOf('/') > 0 && text.IndexOf('-') < 0)
                        {
                            string[] arrText = text.Split('/');
                            DateTime? date = ConvertStringArrToDateTime(arrText);
                            Date = date;
                        }
                        else if (text.IndexOf('-') > 0 && text.IndexOf('/') < 0)
                        {
                            string[] arrText = text.Split('-');
                            DateTime? date = ConvertStringArrToDateTime(arrText);
                            Date = date;
                        }
                        else
                        {
                            Date = null;
                        }
                    }
                    else
                    {
                        Date = null;
                    }
                }
                else
                {
                    Date = null;
                }
                return Date;
            }
            catch(Exception)
            {
                return null;
            }
        }
        public static TimeSpan? ToTime(this string text)
        {
            try
            {
                TimeSpan? Time = null;
                if (!text.IsNull())
                {
                    if (text == Time.ToStringTime())
                    {

                    }
                    else if (text.IsNumeric())
                    {
                        if (text.Substring(0, 1) == "+" || text.Substring(0, 1) == "-")
                        {
                            DateTime now = DateTime.Now.AddHours(text.ToInt().GetValueOrDefault());
                            Time = new TimeSpan(now.Hour, now.Minute, 0);
                        }
                        else
                        {
                            if (text.ToInt() == 0)
                            {
                                Time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
                            }
                            else if (text.Length <= 2)
                            {
                                Time = new TimeSpan(text.ToInt().GetValueOrDefault(), 0, 0);
                            }
                            else if (text.Length <= 4)
                            {
                                int hh = text.Substring(0, 2).ToInt().GetValueOrDefault();
                                int mm = text.Substring(2, 2).ToInt().GetValueOrDefault();
                                Time = new TimeSpan(hh, mm, 0);
                            }
                            else
                            {
                                Time = null;
                            }
                        }
                    }
                    else if (!text.IsNumeric())
                    {
                        if (text.IndexOf(':') > 0 && text.IndexOf('.') < 0)
                        {
                            string[] arrText = text.Split(':');
                            TimeSpan? time = ConvertStringArrToTime(arrText);
                            Time = time;
                        }
                        else if (text.IndexOf('.') > 0 && text.IndexOf(':') < 0)
                        {
                            string[] arrText = text.Split('.');
                            TimeSpan? time = ConvertStringArrToTime(arrText);
                            Time = time;
                        }
                        else
                        {
                            Time = null;
                        }
                    }
                    else
                    {
                        Time = null;
                    }
                }
                else
                {
                    Time = null;
                }
                return Time;
            }
            catch(Exception)
            {
                return null;
            }
        }
        private static DateTime? ConvertStringArrToDateTime(string[] strArr)
        {
            try
            {
                DateTime? date;
                if (strArr.Length == 2)
                {
                    if (strArr[0].IsNumeric() && strArr[1].IsNumeric())
                    {
                        date = new DateTime(DateTime.Now.Year, strArr[1].ToInt().GetValueOrDefault(), strArr[0].ToInt().GetValueOrDefault());
                    }
                    else
                    {
                        date = null;
                    }
                }
                else if (strArr.Length == 3)
                {
                    if (strArr[0].IsNumeric() && strArr[1].IsNumeric() && strArr[2].IsNumeric())
                    {
                        int dd = strArr[0].ToInt().GetValueOrDefault();
                        int mm = strArr[1].ToInt().GetValueOrDefault();
                        int yyyy = strArr[2].ToInt().GetValueOrDefault();
                        int year = yyyy;
                        if (yyyy.ToString().Length == 2)
                        {
                            year = Convert.ToInt32(DateTime.Now.Year.ToString().Substring(0, 2) + yyyy);
                        }
                        if (year.ToString().Length == 4)
                        {
                            if (year > DateTime.Now.Year + 5)
                            {
                                if (year < 2550)
                                {
                                    year = Convert.ToInt32((DateTime.Now.Year + 543).ToString().Substring(0, 2) + yyyy);
                                }
                                year = year - 543;
                            }
                            date = new DateTime(year, mm, dd);
                        }
                        else
                        {
                            date = null;
                        }
                    }
                    else
                    {
                        date = null;
                    }
                }
                else
                {
                    date = null;
                }
                return date;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private static TimeSpan? ConvertStringArrToTime(string[] strArr)
        {
            try
            {
                TimeSpan? time;
                if (strArr.Length == 2)
                {
                    if (strArr[0].IsNumeric() && strArr[1].IsNumeric())
                    {
                        time = new TimeSpan(strArr[0].ToInt().GetValueOrDefault(), strArr[1].ToInt().GetValueOrDefault(), 0);
                    }
                    else
                    {
                        time = null;
                    }
                }
                else
                {
                    time = null;
                }
                return time;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
