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
    public partial class rNumericTextBox : rTextBox
    {
        #region "Variable"

        private decimal? decValue { get; set; }
        private int decPlace { get; set; }
        private decimal? minValue { get; set; }

        public decimal? DecimalValue
        {
            get
            {
                //return decValue;
                decimal iDec;
                if (this.Text != null && this.Text.Trim() == "")
                {
                    return null;
                }
                else if (decimal.TryParse(this.Text, out iDec))
                {
                    return iDec;
                }
                return null;
            }
            set
            {
                //decValue = value;
                SetText(value);
            }
        }

        [Browsable(false)]
        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        public int? NullableIntValue
        {
            get
            {
                if (DecimalValue.HasValue)
                {
                    return (int)DecimalValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                DecimalValue = value;
            }
        }

        [Browsable(false)]
        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        public decimal? NullableDecimalValue
        {
            get
            {
                return DecimalValue;
            }
            set
            {
                DecimalValue = value;
            }
        }

        [Browsable(true)]
        public int DecimalPlace
        {
            get
            {
                return decPlace;
            }
            set
            {
                decPlace = value;
            }
        }

        [Browsable(true)]
        public decimal? MinValue
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
        private void SetText(decimal? value)
        {
            try
            {
                if(value.HasValue)
                {
                    this.Text = value.GetValueOrDefault().ToString(string.Format("N{0}", DecimalPlace));
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
        //private new void OnChange()
        //{
        //    decimal? tmp = this.DecimalValue;
        //    try
        //    {
        //        decimal iDec;
        //        if(this.Text != null && this.Text.Trim() == "")
        //        {
        //            DecimalValue = null;
        //        }
        //        else if (decimal.TryParse(this.Text, out iDec))
        //        {
        //            DecimalValue = iDec;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (tmp != this.DecimalValue)
        //        {
        //            if (ValueChange != null)
        //            {
        //                ValueChange(this, null);
        //            }
        //        }
        //    }
        //}
        public override bool ValidateControl()
        {
            if(this.MinValue.HasValue)
            {
                if (this.DecimalValue.GetValueOrDefault() < this.MinValue.GetValueOrDefault())
                {
                    SetValid(string.Format("ต้องระบุค่าอย่างน้อย {0}", this.MinValue.GetValueOrDefault()));
                    return false;
                }
            }

            return base.ValidateControl();
        }
        #endregion

        #region "Event"
        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    base.OnKeyDown(e);
            //switch (e.KeyCode)
            //{
            //    case Keys.Enter:
            //    case Keys.Tab:
            //        OnChange();
            //        break;
            //}
        //}
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (this.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        //protected override void OnLeave(EventArgs e)
        //{
        //    base.OnLeave(e);
        //    OnChange();
        //}

        [Browsable(true)]
        public event EventHandler ValueChange;
        #endregion
    }
}
