using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.BaseViews;

namespace OIS.BaseViews
{
    public partial class rBaseDialog : rBaseForm
    {
        #region "Enum"
        private enum eCol
        {

        }
        #endregion

        #region "Variable"
        private string toolbarswitch = "1111111111";
        private bool isdatachange = false;
        private Control[] controlsToValidate;

        /// <summary>
        /// Manage Toolbar
        /// New/Save/Search/Confirm/Print/Print2/Export/Cancel/Recovery/Clear
        /// </summary>
        [Browsable(true)]
        public string ToolBarSwitch
        {
            set
            {
                toolbarswitch = value;
                this.OnToolBarSwitchChange();
            }
            get
            {
                return toolbarswitch;
            }
        }

        public bool IsDataChange
        {
            get
            {
                return isdatachange;
            }
            set
            {
                isdatachange = value;
            }
        }

        [Browsable(true)]
        public event EventHandler OnNew;
        [Browsable(true)]
        public event EventHandler OnSave;
        [Browsable(true)]
        public event EventHandler OnSearch;
        [Browsable(true)]
        public event EventHandler OnConfirm;
        [Browsable(true)]
        public event EventHandler OnDDPrint_Preview;
        [Browsable(true)]
        public event EventHandler OnDDPrint_Print;
        [Browsable(true)]
        public event EventHandler OnDDPrint_PDF;
        [Browsable(true)]
        public event EventHandler OnDDPrint_Word;
        [Browsable(true)]
        public event EventHandler OnDDPrint_Excel;
        [Browsable(true)]
        public event EventHandler OnDDPrint2_Preview;
        [Browsable(true)]
        public event EventHandler OnDDPrint2_Print;
        [Browsable(true)]
        public event EventHandler OnDDPrint2_PDF;
        [Browsable(true)]
        public event EventHandler OnDDPrint2_Word;
        [Browsable(true)]
        public event EventHandler OnDDPrint2_Excel;
        [Browsable(true)]
        public event EventHandler OnExport;
        [Browsable(true)]
        public event EventHandler OnCancel;
        [Browsable(true)]
        public event EventHandler OnRecovery;
        [Browsable(true)]
        public event EventHandler OnClear;
        [Browsable(true)]
        public event EventHandler OnClose;
        #endregion

        #region "Constructor"
        public rBaseDialog()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
        }
        #endregion

        #region "Customize"
        private void OnToolBarSwitchChange()
        {
            try
            {
                for (int i = 0; i < toolbarswitch.Length; i++)
                {
                    string str = GetToolBarChar(i);
                    switch (i)
                    {
                        case 0:
                            this.SwitchToolBar(tsbNew, str);
                            break;
                        case 1:
                            this.SwitchToolBar(tsbSave, str);
                            break;
                        case 2:
                            this.SwitchToolBar(tsbSearch, str);
                            break;
                        case 3:
                            this.SwitchToolBar(tsbConfirm, str);
                            break;
                        case 4:
                            this.SwitchToolBar(tsbDDPrint, str);
                            break;
                        case 5:
                            this.SwitchToolBar(tsbDDPrint2, str);
                            break;
                        case 6:
                            this.SwitchToolBar(tsbExport, str);
                            break;
                        case 7:
                            this.SwitchToolBar(tsbCancel, str);
                            break;
                        case 8:
                            this.SwitchToolBar(tsbRecovery, str);
                            break;
                        case 9:
                            this.SwitchToolBar(tsbClear, str);
                            break;
                    }
                }

                tssSearch.Visible = tsbSearch.Visible || tsbConfirm.Visible;
                tssPrint.Visible = tsbDDPrint.Visible || tsbDDPrint2.Visible;
                tssExport.Visible = tsbExport.Visible;
                tssCancel.Visible = tsbCancel.Visible || tsbRecovery.Visible;
                tssClear.Visible = tsbClear.Visible;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private string GetToolBarChar(int PositionIndex)
        {
            return toolbarswitch.Substring(PositionIndex, 1);
        }
        private void SwitchToolBar(ToolStripDropDownButton tsb, string switchChar)
        {
            try
            {
                switch (switchChar)
                {
                    case "1":
                        tsb.Visible = true;
                        tsb.Enabled = true;
                        break;
                    case "0":
                        tsb.Visible = true;
                        tsb.Enabled = false;
                        break;
                    case "2":
                    default:
                        tsb.Visible = false;
                        tsb.Enabled = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SwitchToolBar(ToolStripButton tsb, string switchChar)
        {
            try
            {
                switch (switchChar)
                {
                    case "1":
                        tsb.Visible = true;
                        tsb.Enabled = true;
                        break;
                    case "0":
                        tsb.Visible = true;
                        tsb.Enabled = false;
                        break;
                    case "2":
                    default:
                        tsb.Visible = false;
                        tsb.Enabled = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Set control to validate
        /// </summary>
        /// <param name="Ctrls">Control to validate</param>
        public void SetControlToValidate(params Control[] Ctrls)
        {
            controlsToValidate = Ctrls;
        }

        /// <summary>
        /// Validate all defined criteria controls 
        /// </summary>
        /// <returns>True when all controls is valid</returns>
        public bool ValidateControl()
        {
            bool isValid = true;
            if (controlsToValidate != null && controlsToValidate.Length > 0)
            {
                foreach (Control ctrl in controlsToValidate)
                {

                    if (ctrl is rSearchTextBox)
                    {
                        rSearchTextBox txt = ctrl as rSearchTextBox;
                        if (!txt.ValidateControl())
                        {
                            isValid = false;
                        }
                    }
                    else if (ctrl is rNumericTextBox)
                    {
                        rNumericTextBox txt = ctrl as rNumericTextBox;
                        if (!txt.ValidateControl())
                        {
                            isValid = false;
                        }
                    }
                    else if (ctrl is rTextBox)
                    {
                        rTextBox txt = ctrl as rTextBox;
                        if (!txt.ValidateControl())
                        {
                            isValid = false;
                        }
                    }
                    else if (ctrl is rComboBox)
                    {
                        rComboBox cbo = ctrl as rComboBox;
                        if (!cbo.ValidateControl())
                        {
                            isValid = false;
                        }
                    }
                    else if (ctrl is rMaskedTextBox)
                    {
                        rMaskedTextBox txt = ctrl as rMaskedTextBox;
                        if (!txt.ValidateControl())
                        {
                            isValid = false;
                        }
                    }
                    else
                    {
                        isValid = false;
                    }
                }
            }
            return isValid;
        }
        #endregion

        #region "Event"
        private void tsbNew_Click(object sender, EventArgs e)
        {
            if (OnNew != null)
            {
                OnNew(sender, e);
            }
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (OnSave != null)
            {
                OnSave(sender, e);
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            if (OnSearch != null)
            {
                OnSearch(sender, e);
            }
        }
        private void tsbConfirm_Click(object sender, EventArgs e)
        {
            if (OnConfirm != null)
            {
                OnConfirm(sender, e);
            }
        }

        private void tsbDDPrint_Preview_Click(object sender, EventArgs e)
        {
            if (OnDDPrint_Preview != null)
            {
                OnDDPrint_Preview(sender, e);
            }
        }
        private void tsbDDPrint_Print_Click(object sender, EventArgs e)
        {
            if (OnDDPrint_Print != null)
            {
                OnDDPrint_Print(sender, e);
            }
        }
        private void tsbDDPrint_PDF_Click(object sender, EventArgs e)
        {
            if (OnDDPrint_PDF != null)
            {
                OnDDPrint_PDF(sender, e);
            }
        }
        private void tsbDDPrint_Word_Click(object sender, EventArgs e)
        {
            if (OnDDPrint_Word != null)
            {
                OnDDPrint_Word(sender, e);
            }
        }
        private void tsbDDPrint_Excel_Click(object sender, EventArgs e)
        {
            if (OnDDPrint_Excel != null)
            {
                OnDDPrint_Excel(sender, e);
            }
        }

        private void tsbDDPrint2_Preview_Click(object sender, EventArgs e)
        {
            if (OnDDPrint2_Preview != null)
            {
                OnDDPrint2_Preview(sender, e);
            }
        }
        private void tsbDDPrint2_Print_Click(object sender, EventArgs e)
        {
            if (OnDDPrint2_Print != null)
            {
                OnDDPrint2_Print(sender, e);
            }
        }
        private void tsbDDPrint2_PDF_Click(object sender, EventArgs e)
        {

            if (OnDDPrint2_PDF != null)
            {
                OnDDPrint2_PDF(sender, e);
            }
        }
        private void tsbDDPrint2_Word_Click(object sender, EventArgs e)
        {

            if (OnDDPrint2_Word != null)
            {
                OnDDPrint2_Word(sender, e);
            }
        }
        private void tsbDDPrint2_Excel_Click(object sender, EventArgs e)
        {

            if (OnDDPrint2_Excel != null)
            {
                OnDDPrint2_Excel(sender, e);
            }
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            if (OnExport != null)
            {
                OnExport(sender, e);
            }
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            if (OnCancel != null)
            {
                OnCancel(sender, e);
            }
        }
        private void tsbRecovery_Click(object sender, EventArgs e)
        {
            if (OnRecovery != null)
            {
                OnRecovery(sender, e);
            }
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            if (OnClear != null)
            {
                OnClear(sender, e);
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            if (OnClose != null)
            {
                OnClose(sender, e);
            }
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.S:
                    OnSave(null, null);
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if(this.IsDataChange)
            {
                DialogResult = DialogResult.OK;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }
        #endregion
    }
}
