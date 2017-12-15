using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OIS.Common.Extensions;

namespace OIS.BaseViews
{
    public partial class rTextBox : TextBox
    {
        #region "Variable"
        private ErrorProvider errProvider = new ErrorProvider();

        private bool isrequire = false;
        private int minlength { get; set; }
        protected Color MyBackColor { get; set; }

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
        
        /// <summary>
        /// Get text or null value
        /// </summary>
        [Browsable(false)]
        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        public string TextValue
        {
            get
            {
                if (this.Text == null || this.Text == string.Empty || this.Text.Length == 0)
                {
                    return null;
                }
                else
                {
                    return this.Text;
                }
            }
            set
            {
                this.Text = value;
            }
        }

        [Browsable(true)]
        public event EventHandler OnChange;
        #endregion

        #region "Constructor"
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.BackColor = Color.White;
            MyBackColor = this.BackColor;
            this.ResumeLayout(false);
        }
        #endregion

        #region "Customize"
        /// <summary>
        /// Get string text value or null.
        /// </summary>
        /// <returns></returns>        
        public string GetValue()
        {
            if (this.Text == null || this.Text == string.Empty || this.Text.Length == 0)
            {
                return null;
            }
            else
            {
                return this.Text;
            }
        }

        /// <summary>
        /// Return true when text empty
        /// </summary>
        public bool IsNull
        {
            get
            {
                return this.Text == null || this.Text == string.Empty || this.Text.Length == 0;
            }
        }

        /// <summary>
        /// Set or clear control style invalid
        /// </summary>
        /// <param name="text">text to show when invalid, empty string if not valid</param>
        public void SetValid(string text)
        {
            if(text.IsNull())
            {
                if (this.Enabled)
                {
                    this.BackColor = MyBackColor;
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
        public virtual bool ValidateControl()
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
                if (this.TextLength < this.MinLength)
                {
                    SetValid(string.Format("ต้องระบุค่าอย่างน้อย {0} ตัวอักษร", this.MinLength));
                    return false;
                }
            }
            if (this.MinLength > 0)
            {
                if (this.TextLength > 0 && this.TextLength < this.MinLength)
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
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            //if (this.DataBindings != null && this.DataBindings.Count > 0)
            //{
            //    this.DataBindings[0].WriteValue();
            //}
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch(e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Tab:
                    if (this.OnChange != null)
                    {
                        OnChange(this, e);
                    }
                    break;
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (this.OnChange != null)
            {
                OnChange(this, e);
            }
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
        }

        #endregion
    }
}
