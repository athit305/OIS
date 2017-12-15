using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.Common.Extensions;

namespace OIS.BaseViews
{
    public partial class rComboBox : ComboBox
    {
        #region "Variable"
        private ErrorProvider errProvider = new ErrorProvider();
        private AutoCompleteMode autoCompleteMode = AutoCompleteMode.Suggest;

        private bool isrequire = false;

        [Browsable(true)]
        public bool IsRequired
        {
            get
            {
                return isrequire;
            }
            set
            {
                isrequire = value;
            }
        }

        /// <summary>
        /// Return true when text empty
        /// </summary>
        public bool IsNull
        {
            get
            {
                if (this.IsSelectAll())
                    return true;
                if (this.SelectedValue != null && false == String.IsNullOrWhiteSpace(this.SelectedValue.ToString()))
                {
                    return false;
                }
                return true;
            }
        }

        new public AutoCompleteMode AutoCompleteMode
        {
            get
            {
                return autoCompleteMode;
            }
            set
            {
                autoCompleteMode = value;
                base.AutoCompleteMode = value;
            }
        }

        [Browsable(false)]
        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        public int? NullableIntValue
        {
            get
            {
                if (this.IsSelectAll())
                    return null;

                if (this.SelectedValue != null && false == String.IsNullOrWhiteSpace(this.SelectedValue.ToString()))
                {
                    int iNum;
                    if (int.TryParse(this.SelectedValue.ToString(), out iNum))
                    {
                        return iNum;
                    }
                }
                return null;
            }
            set
            {
                if (value.HasValue)
                {
                    this.SelectedValue = value;
                }
                else
                {
                    this.SelectedValue = 0;
                }
            }
        }
        [Browsable(false)]
        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        public string StringValue
        {
            get
            {
                if (this.IsSelectAll())
                    return null;

                if (this.SelectedValue != null && false == String.IsNullOrWhiteSpace(this.SelectedValue.ToString()))
                {
                    return this.SelectedValue.ToString();
                }
                return null;
            }
            set
            {
                if (value.IsNull())
                {
                    this.SelectedValue = string.Empty;
                }
                else
                {
                    this.SelectedValue = value;
                }
            }
        }
        #endregion

        #region "Constructor"
        #endregion

        #region "Customize"
        /// <summary>
        /// Set or clear control style invalid
        /// </summary>
        /// <param name="text">text to show when invalid, empty string if not valid</param>
        public void SetValid(string text)
        {
            if (text.IsNull())
            {
                this.BackColor = Color.White;
                errProvider.SetError(this, string.Empty);
            }
            else
            {
                this.BackColor = Color.Pink;
                errProvider.SetError(this, text);
            }
        }

        /// <summary>
        /// Validate this control if assign rules
        /// </summary>
        /// <returns>This control is valid</returns>
        public bool ValidateControl()
        {
            if (this.IsRequired)
            {
                if (!this.NullableIntValue.HasValue && this.StringValue.IsNull())
                {
                    SetValid("ค่าห้ามว่าง");
                    return false;
                }
            }

            SetValid(null);
            return true;
        }
        #endregion

        #region "Event"
        #endregion
    }
}
