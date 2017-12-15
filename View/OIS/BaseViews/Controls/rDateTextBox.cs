using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.Common.Extensions;
using OIS.Definition;

namespace OIS.BaseViews
{
    public partial class rDateTextBox : rTextBox
    {
        #region "Variable"
        private DateTime? date { get; set; }
        private bool showTime = false;

        [Browsable(true)]
        public DateTime? Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                SetDate(date);
            }
        }

        [Browsable(false)]
        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        public DateTime? DateValue
        {
            get
            {
                return Date;
            }
            set
            {
                Date = value;
            }
        }

        [Browsable(true)]
        public bool ShowTime
        {
            get
            {
                return showTime;
            }
            set
            {
                showTime = value;
            }
        }

        public override int MaxLength
        {
            get
            {
                return 10;
            }
        }
        #endregion

        #region "Constructor"
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

            this.TextAlign = HorizontalAlignment.Center;
        }
        #endregion

        #region "Customize"
        private void SetDate(DateTime? date)
        {
            try
            {
                if(date.HasValue)
                {
                    if (showTime)
                    {
                        //this.Text = string.Format("{0}/{1}/{2} {3}:{4}:{5}", date.Value.Day.ToString("0#"), date.Value.Month.ToString("0#"), date.Value.Year + 543, date.Value.Hour.ToString("0#"), date.Value.Minute.ToString("0#"), date.Value.Second.ToString("0#"));
                        this.Text = date.ToStringDate(OISGridConstant.DateTimeFormat);
                    }
                    else
                    {
                        //this.Text = string.Format("{0}/{1}/{2}", date.Value.Day.ToString("0#"), date.Value.Month.ToString("0#"), date.Value.Year + 543);
                        this.Text = date.ToStringDate(OISGridConstant.DateFormat);
                    }
                }
                else
                {
                    this.Text = null;
                }
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private new void OnChange()
        {
            DateTime? tmp = this.Date;
            try
            {
                string text = this.Text;

                if (!text.IsNull())
                {
                    if(text == Date.ToStringDate())
                    {

                    }
                    else
                    {
                        Date = text.ToDateTime();
                    }
                }
                else
                {
                    Date = null;
                }
            }
            catch (Exception)
            {
                Date = null;
            }
            finally
            {
                if (tmp != this.Date)
                {
                    if (DateChange != null)
                    {
                        DateChange(this, null);
                    }
                }
            }

        }
        private DateTime? ConvertStringArrToDateTime(string[] strArr)
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
                        int year = 0;
                        if(yyyy.ToString().Length == 2)
                        {
                            year = (DateTime.Now.Year + 543) - ((DateTime.Now.Year + 543) % 100); 
                            yyyy = yyyy + year;
                        }
                        else if(yyyy.ToString().Length == 3)
                        {
                            year = (DateTime.Now.Year + 543) - ((DateTime.Now.Year + 543) % 1000);
                            yyyy = yyyy + year;
                        }
                        if (yyyy > DateTime.Now.Year + 100)
                        {
                            yyyy = yyyy - 543;
                        }
                        date = new DateTime(yyyy, mm, dd);
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
            catch (Exception ex)
            {
                throw ex;
            }
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
        public event EventHandler DateChange;
        #endregion

    }
}
