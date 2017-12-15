using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.Common.Extensions;

namespace OIS.BaseViews
{
    public partial class rTimeTextBox : rTextBox
    {
        #region "Variable"
        private TimeSpan? time { get; set; }
        private TimeSpan? minValue { get; set; }
        [Browsable(true)]
        public TimeSpan? Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                SetTime(time);
            }
        }

        [Browsable(false)]
        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        public TimeSpan? TimeValue
        {
            get
            {
                return Time;
            }
            set
            {
                Time = value;
            }
        }

        public override int MaxLength
        {
            get
            {
                return 5;
            }
        }

        public TimeSpan? MinValue
        {
            get
            {
                return minValue;
            }
            set
            {
                minValue = value;
            }
        }
        #endregion

        #region "Constructor"
        #endregion

        #region "Customize"
        private void SetTime(TimeSpan? time)
        {
            try
            {
                if (time.HasValue)
                {
                    this.Text = string.Format("{0}:{1}", time.Value.Hours.ToString("0#"), time.Value.Minutes.ToString("0#"));
                }
                else
                {
                    this.Text = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private new void OnChange()
        {
            TimeSpan? tmp = this.Time;
            try
            {
                string text = this.Text;

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
            }
            catch (Exception)
            {
                Time = null;
            }
            finally
            {
                if (tmp != this.Time)
                {
                    if (TimeChange != null)
                    {
                        TimeChange(this, null);
                    }
                }
            }

        }
        private TimeSpan? ConvertStringArrToTime(string[] strArr)
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
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public override bool ValidateControl()
        {
            if (this.MinValue.HasValue && this.TimeValue.HasValue)
            {
                if (this.TimeValue.GetValueOrDefault() < this.MinValue.GetValueOrDefault())
                {
                    SetValid(string.Format("ต้องระบุค่าอย่างน้อย {0}", this.MinValue.GetValueOrDefault().ToString(@"hh\:mm")));
                    return false;
                }
            }
            return base.ValidateControl();
        }
        #endregion

        #region "Event"
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Tab:
                    OnChange();
                    break;
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            OnChange();
        }

        [Browsable(true)]
        public event EventHandler TimeChange;
        #endregion
    }
}
