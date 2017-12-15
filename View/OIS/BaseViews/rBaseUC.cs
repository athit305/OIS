using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.Common;
using OIS.Definition;
using OIS.SYS.DTO;
using OIS.Views.Dialogs;

namespace OIS.BaseViews
{
    public partial class rBaseUC : UserControl
    {
        #region "Variable"
        private string toolbarswitch = "1111111111";
        private bool isdatachange = false;
        private Control[] controlsToValidate;
        private AutoScaleMode autoScaleMode = AutoScaleMode.None;
        private rDataGridView dataGV { get; set; }

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
        new public virtual AutoScaleMode AutoScaleMode
        {
            get
            {
                return autoScaleMode;
            }
            set
            {
                base.AutoScaleMode = autoScaleMode = value;
            }
        }

        [Browsable(true)]
        public rDataGridView ExportGrid
        {
            get
            {
                return dataGV;
            }
            set
            {
                dataGV = value;
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
        public event EventHandler OnCancel;
        [Browsable(true)]
        public event EventHandler OnRecovery;
        [Browsable(true)]
        public event EventHandler OnClear;
        #endregion

        #region "Constructor"
        public rBaseUC()
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
            catch(Exception ex)
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
                switch(switchChar)
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
            catch(Exception ex)
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
        /// Validate all controls if set
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
                    else if(ctrl is rNumericTextBox)
                    {
                        rNumericTextBox txt = ctrl as rNumericTextBox;
                        if(!txt.ValidateControl())
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
                    else if(ctrl is rMaskedTextBox)
                    {
                        rMaskedTextBox txt = ctrl as rMaskedTextBox;
                        if(!txt.ValidateControl())
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

        public void ClearControls(params Control[] Ctrls)
        {
            try
            {
                if (Ctrls != null && Ctrls.Length > 0)
                {
                    foreach (Control ctrl in Ctrls)
                    {

                        if (ctrl is rSearchTextBox)
                        {
                            rSearchTextBox txt = ctrl as rSearchTextBox;
                            txt.IntValue = null;
                            txt.StringValue = null;
                            txt.Text = null;
                        }
                        else if (ctrl is rNumericTextBox)
                        {
                            rNumericTextBox txt = ctrl as rNumericTextBox;
                            txt.NullableIntValue = null;
                            txt.DecimalValue = null;
                        }
                        else if(ctrl is rDateTextBox)
                        {
                            rDateTextBox txt = ctrl as rDateTextBox;
                            txt.DateValue = null;
                        }
                        else if(ctrl is rTimeTextBox)
                        {
                            rTimeTextBox txt = ctrl as rTimeTextBox;
                            txt.TimeValue = null;
                        }
                        else if (ctrl is rTextBox)
                        {
                            rTextBox txt = ctrl as rTextBox;
                            txt.Text = null;
                        }
                        else if (ctrl is rComboBox)
                        {
                            rComboBox cbo = ctrl as rComboBox;
                            cbo.NullableIntValue = null;
                            cbo.StringValue = null;
                        }
                        else if (ctrl is rMaskedTextBox)
                        {
                            rMaskedTextBox txt = ctrl as rMaskedTextBox;
                            txt.Text = null;
                        }
                        else if(ctrl is rDataGridView)
                        {
                            rDataGridView gv = ctrl as rDataGridView;
                            gv.DataSource = null;
                            gv.Rows.Clear();
                        }
                        else if(ctrl is CheckBox)
                        {
                            CheckBox chk = ctrl as CheckBox;
                            chk.Checked = false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
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
            if(OnDDPrint_Word != null)
            {
                OnDDPrint_Word(sender, e);
            }
        }

        private void tsbDDPrint_Excel_Click(object sender, EventArgs e)
        {
            if(OnDDPrint_Excel != null)
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
            if(OnDDPrint2_PDF != null)
            {
                OnDDPrint2_PDF(sender, e);
            }
        }

        private void tsbDDPrint2_Word_Click(object sender, EventArgs e)
        {
            if(OnDDPrint2_Word != null)
            {
                OnDDPrint2_Word(sender, e);
            }
        }

        private void tsbDDPrint2_Excel_Click(object sender, EventArgs e)
        {
            if(OnDDPrint2_Excel != null)
            {
                OnDDPrint2_Excel(sender, e);
            }
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            if (ExportGrid != null)
            {
                if (ExportGrid.Rows.Count > 0)
                {
                    try
                    {
                        using (ExportDialog expDlg = new ExportDialog(ExportGrid))
                        {
                            expDlg.ShowDialog(this);
                        }
                    }
                    catch(Exception ex)
                    {
                        rMessageBox.ShowException(this, ex);
                    }
                }
                else
                {
                    rMessageBox.ShowInfomation(this, MessageCode.INF0001);
                }
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
            if(OnClear != null)
            {
                OnClear(sender, e);
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            if (this.Parent != null && this.Parent.Controls is TabPage.TabPageControlCollection)
            {
                //if (rMessageBox.ShowConfirmation(this, "คุณต้องการปิดหน้าจอนี้ใช้หรือไม่ ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                    TabPage tab = this.Parent as TabPage;
                    InternalVariable.MainForm_Instance.CloseTab(tab.Tag as sp_SYS_GetMenu_Result);
                //}
            }
        }
        #endregion

        #region "Override Method"
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.N):
                    tsbNew_Click(null, null);
                    break;
                case (Keys.Enter):
                    tsbSearch_Click(null, null);
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}
