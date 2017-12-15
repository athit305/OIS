using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OIS.Definition;

namespace OIS.Common.Extensions
{
    public static class DateTimeExtension
    {
        public static string ToStringDate(this DateTime? date, string format)
        {
            if (date.HasValue)
            {
                CultureInfo th = new CultureInfo("th-TH");
                string s = date.GetValueOrDefault().ToString(format, th);
                if(format == OISGridConstant.DateTimeFormat)
                {
                    s = string.Format("{0}/{1}/{2} {3}:{4}:{5}", date.Value.Day.ToString("0#"), date.Value.Month.ToString("0#"), date.Value.Year + 543, date.Value.Hour.ToString("0#"), date.Value.Minute.ToString("0#"), date.Value.Second.ToString("0#"));
                }
                else
                {
                    s = string.Format("{0}/{1}/{2}", date.Value.Day.ToString("0#"), date.Value.Month.ToString("0#"), date.Value.Year + 543);
                }
                return s;
            }
            else
            {
                return "";
            }
        }
        public static string ToStringDate(this DateTime? date)
        {
            return ToStringDate(date, "dd/MM/yyyy");
        }
        public static string ToStringTime(this TimeSpan? time)
        {
            if(time.HasValue)
            {
                string s = time.GetValueOrDefault().ToString(@"hh\:mm");
                s = string.Format("{0}:{1}", time.Value.Hours.ToString("0#"), time.Value.Minutes.ToString("0#"));
                return s;
            }
            else
            {
                return "";
            }
        }
    }

    public class TimeSpanFormatter : IFormatProvider, ICustomFormatter
    {
        private Regex _formatParser;

        public TimeSpanFormatter()
        {
            _formatParser = new Regex("d{1,2}|h{1,2}|m{1,2}|s{1,2}|f{1,7}", RegexOptions.Compiled);
        }

        #region IFormatProvider Members

        public object GetFormat(Type formatType)
        {
            if (typeof(ICustomFormatter).Equals(formatType))
            {
                return this;
            }

            return null;
        }

        #endregion

        #region ICustomFormatter Members

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg is TimeSpan)
            {
                var timeSpan = (TimeSpan)arg;
                return _formatParser.Replace(format, GetMatchEvaluator(timeSpan));
            }
            else
            {
                var formattable = arg as IFormattable;
                if (formattable != null)
                {
                    return formattable.ToString(format, formatProvider);
                }

                return arg != null ? arg.ToString() : string.Empty;
            }
        }

        #endregion

        private MatchEvaluator GetMatchEvaluator(TimeSpan timeSpan)
        {
            return m => EvaluateMatch(m, timeSpan);
        }

        private string EvaluateMatch(Match match, TimeSpan timeSpan)
        {
            switch (match.Value)
            {
                case "dd":
                    return timeSpan.Days.ToString("00");
                case "d":
                    return timeSpan.Hours.ToString("0");
                case "hh":
                    return timeSpan.Hours.ToString("00");
                case "h":
                    return timeSpan.Hours.ToString("0");
                case "mm":
                    return timeSpan.Minutes.ToString("00");
                case "m":
                    return timeSpan.Minutes.ToString("0");
                case "ss":
                    return timeSpan.Seconds.ToString("00");
                case "s":
                    return timeSpan.Seconds.ToString("0");
                case "fffffff":
                    return (timeSpan.Milliseconds * 10000).ToString("0000000");
                case "ffffff":
                    return (timeSpan.Milliseconds * 1000).ToString("000000");
                case "fffff":
                    return (timeSpan.Milliseconds * 100).ToString("00000");
                case "ffff":
                    return (timeSpan.Milliseconds * 10).ToString("0000");
                case "fff":
                    return (timeSpan.Milliseconds).ToString("000");
                case "ff":
                    return (timeSpan.Milliseconds / 10).ToString("00");
                case "f":
                    return (timeSpan.Milliseconds / 100).ToString("0");
                default:
                    return match.Value;
            }
        }
    }
}
