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
    public partial class rMaskedTextBox : MaskedTextBox
    {
        #region "Variable"
        private ErrorProvider errProvider = new ErrorProvider();

        private bool isrequire = false;
        private int minlength { get; set; }

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
        [Browsable(true)]
        public int MinLength
        {
            get
            {
                return minlength;
            }
            set
            {
                minlength = value;
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
                if (this.Enabled)
                {
                    this.BackColor = Color.White;
                }
                else
                {
                    this.BackColor = Color.FromName("Control");
                }
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
                if (this.Text.IsNull())
                {
                    SetValid("ค่าห้ามว่าง");
                    return false;
                }
            }
            if (this.IsRequired && this.MinLength > 0)
            {
                if (this.Text.Length < this.MinLength)
                {
                    SetValid(string.Format("ต้องระบุค่าอย่างน้อย {0} ตัวอักษร", this.MinLength));
                    return false;
                }
            }
            if (this.MinLength > 0)
            {
                if (this.Text.Length > 0 && this.Text.Length < this.MinLength)
                {
                    SetValid(string.Format("ต้องระบุค่าอย่างน้อย {0} ตัวอักษร", this.MinLength));
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
