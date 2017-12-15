using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.Common.Extensions;
using OIS.ViewModel;
using OIS.Views.Dialogs;
using OIS.MAS.DTO;

namespace OIS.BaseViews
{
    public class rSearchTextBox : rTextBox
    {
        #region "Variable"
        private int? intValue { get; set; }
        private string stringValue { get; set; }
        private eSearchType sType { get; set; }
        private rTextBox optionalTextBox { get; set; }
        private object selectedrow { get; set; }

        public event EventHandler OnSelected;


        private int? IntV
        {
            get
            {
                return intValue;
            }
            set
            {
                intValue = value;
                SetText();
            }
        }

        public object SelectedData
        {
            get
            {
                return selectedrow;
            }
        }

        [Browsable(true)]
        public eSearchType SearchType
        {
            get
            {
                return sType;
            }
            set
            {
                sType = value;
            }
        }

        [Browsable(false)]
        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        public int? IntValue
        {
            get
            {
                return IntV;
            }
            set
            {
                IntV = value;
            }
        }

        [Browsable(false)]
        [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
        public string StringValue
        {
            get
            {
                if (stringValue != null && stringValue.Trim() == string.Empty)
                {
                    return null;
                }
                return stringValue;
            }
            set
            {
                stringValue = value;
                SetText();
            }
        }


        [Browsable(true)]
        public rTextBox OptionalTextBox
        {
            get
            {
                return optionalTextBox;
            }
            set
            {
                optionalTextBox = value;
            }
        }

        private SearchViewModel vmSearch = new SearchViewModel();
        private MasterViewModel vmMas = new MasterViewModel();
        #endregion

        #region "Constructor"
        public rSearchTextBox()
        {
            this.BackColor = Color.FromName("Info");
            MyBackColor = this.BackColor;
        }
        #endregion

        #region "Customize"
        private void TextChange()
        {
            int? tmp = this.IntV;

            if (this.Text.IsNull())
            {
                this.IntV = null;
                return;
            }
            if (this.Text == GetTextDisplay())
            {
                return;
            }

            switch (SearchType)
            {
                case eSearchType.None:
                    break;
                case eSearchType.User:
                    #region User
                    using (UserDialog dlg = new UserDialog(this.TextValue))
                    { 
                        if (dlg.RowCount == 1)
                        {
                            this.StringValue = dlg.SelectedData.ID;
                            this.selectedrow = dlg.SelectedData;
                        }
                        else if (dlg.RowCount > 1)
                        {
                            if (dlg.ShowDialog(this) == DialogResult.OK)
                            {
                                this.StringValue = dlg.SelectedData.ID;
                                this.selectedrow = dlg.SelectedData;
                            }
                        }
                        else
                        {
                            this.StringValue = null;
                            this.selectedrow = null;
                        }
                    }
                    #endregion
                    break;
                case eSearchType.Customer:
                    #region Customer
                    using (CustomerDialog dlg = new CustomerDialog(this.TextValue))
                    { 
                        if (dlg.RowCount == 1)
                        {
                            if (OptionalTextBox != null)
                            {
                                OptionalTextBox.Text = dlg.SelectedData.ADDR;
                            }
                            IntV = dlg.SelectedData.ID;
                            this.selectedrow = dlg.SelectedData;
                        }
                        else if (dlg.RowCount > 1)
                        {
                            if (dlg.ShowDialog(this) == DialogResult.OK)
                            {
                                if (OptionalTextBox != null)
                                {
                                    OptionalTextBox.Text = dlg.SelectedData.ADDR;
                                }
                                IntV = dlg.SelectedData.ID;
                                this.selectedrow = dlg.SelectedData;
                            }
                        }
                        else
                        {
                            if (OptionalTextBox != null)
                            {
                                OptionalTextBox.Text = null;
                            }
                            IntV = null;
                            this.selectedrow = null;
                        }
                    }
                    #endregion
                    break;
                case eSearchType.Project:
                    #region Project
                    using (ProjectDialog dlg = new ProjectDialog(this.TextValue))
                    { 
                        if (dlg.RowCount == 1)
                        {
                            if (OptionalTextBox != null)
                            {
                                OptionalTextBox.Text = dlg.SelectedData.ADDR;
                            }
                            IntV = dlg.SelectedData.ID;
                            this.selectedrow = dlg.SelectedData;
                        }
                        else if (dlg.RowCount > 1)
                        {
                            if (dlg.ShowDialog(this) == DialogResult.OK)
                            {
                                if (OptionalTextBox != null)
                                {
                                    OptionalTextBox.Text = dlg.SelectedData.ADDR;
                                }
                                IntV = dlg.SelectedData.ID;
                                this.selectedrow = dlg.SelectedData;
                            }
                        }
                        else
                        {
                            if (OptionalTextBox != null)
                            {
                                OptionalTextBox.Text = null;
                            }
                            IntV = null;
                            this.selectedrow = null;
                        }
                    }
                    #endregion
                    break;
                case eSearchType.Instrument:
                    #region Instrument
                    using (InstrumentDialog dlg = new InstrumentDialog(this.TextValue))
                    {
                        if (dlg.RowCount == 1)
                        {
                            IntV = dlg.SelectedData.ID;
                            this.selectedrow = dlg.SelectedData;
                        }
                        else if (dlg.RowCount > 1)
                        {
                            if (dlg.ShowDialog(this) == DialogResult.OK)
                            {
                                IntV = dlg.SelectedData.ID;
                                this.selectedrow = dlg.SelectedData;
                            }
                        }
                        else
                        {
                            IntV = null;
                            this.selectedrow = null;
                        }
                    }
                    #endregion
                    break;
                case eSearchType.MethodAnalysis:
                    #region MethodAnalysis
                    using (MethodAnalysisDialog dlg = new MethodAnalysisDialog(this.Text))
                    {
                        if (dlg.RowCount == 1)
                        {
                            IntV = dlg.SelectedData.ID;
                            this.selectedrow = dlg.SelectedData;
                        }
                        else if (dlg.RowCount > 1)
                        {
                            if (dlg.ShowDialog(this) == DialogResult.OK)
                            {
                                IntV = dlg.SelectedData.ID;
                                this.selectedrow = dlg.SelectedData;
                            }
                        }
                        else
                        {
                            IntV = null;
                            this.selectedrow = null;
                        }
                    }
                    #endregion
                    break;
                case eSearchType.ParameterAnalysis:
                    #region ParameterAnalysis
                    using (ParameterAnalysisDialog dlg = new ParameterAnalysisDialog(this.Text))
                    {
                        if (dlg.RowCount == 1)
                        {
                            IntV = dlg.SelectedData.ID;
                            this.selectedrow = dlg.SelectedData;
                        }
                        else if (dlg.RowCount > 1)
                        {
                            if (dlg.ShowDialog(this) == DialogResult.OK)
                            {
                                IntV = dlg.SelectedData.ID;
                                this.selectedrow = dlg.SelectedData;
                            }
                        }
                        else
                        {
                            IntV = null;
                            this.selectedrow = null;
                        }
                    }
                    #endregion
                    break;
                case eSearchType.ToolPick:
                    #region ToolPick
                    using (ToolPickDialog dlg = new ToolPickDialog(this.Text))
                    {
                        if (dlg.RowCount == 1)
                        {
                            IntV = dlg.SelectedData.ID;
                            this.selectedrow = dlg.SelectedData;
                        }
                        else if (dlg.RowCount > 1)
                        {
                            if (dlg.ShowDialog(this) == DialogResult.OK)
                            {
                                IntV = dlg.SelectedData.ID;
                                this.selectedrow = dlg.SelectedData;
                            }
                        }
                        else
                        {
                            IntV = null;
                            this.selectedrow = null;
                        }
                    }
                    #endregion
                    break;
                case eSearchType.ToolAnalysis:
                    #region ToolAnalysis
                    using (ToolAnalysisDialog dlg = new ToolAnalysisDialog(this.Text))
                    {
                        if (dlg.RowCount == 1)
                        {
                            IntV = dlg.SelectedData.ID;
                            this.selectedrow = dlg.SelectedData;
                        }
                        else if (dlg.RowCount > 1)
                        {
                            if (dlg.ShowDialog(this) == DialogResult.OK)
                            {
                                IntV = dlg.SelectedData.ID;
                                this.selectedrow = dlg.SelectedData;
                            }
                        }
                        else
                        {
                            IntV = null;
                            this.selectedrow = null;
                        }
                    }
                    #endregion
                    break;
                case eSearchType.StandardLight:
                    #region StandardLight
                    using (StandardLightDialog dlg = new StandardLightDialog(this.Text))
                    {
                        if (dlg.RowCount == 1)
                        {
                            IntV = dlg.SelectedData.ID;
                            this.selectedrow = dlg.SelectedData;
                        }
                        else if (dlg.RowCount > 1)
                        {
                            if (dlg.ShowDialog(this) == DialogResult.OK)
                            {
                                IntV = dlg.SelectedData.ID;
                                this.selectedrow = dlg.SelectedData;
                            }
                        }
                        else
                        {
                            IntV = null;
                            this.selectedrow = null;
                        }
                    }
                    #endregion
                    break;
            }
            if (OnSelected != null)
            {
                OnSelected(this, null);
            }
        }

        private void SearchOnDialog()
        {
            try
            {
                switch (SearchType)
                {
                    case eSearchType.None:
                        break;
                    case eSearchType.User:
                        #region User
                        using (UserDialog dlgu = new UserDialog(null))
                        {
                            if (dlgu.RowCount == 1)
                            {
                                this.selectedrow = dlgu.SelectedData;
                                this.StringValue = dlgu.SelectedData.ID;
                            }
                            else if (dlgu.RowCount > 1)
                            {
                                if (dlgu.ShowDialog(this) == DialogResult.OK)
                                {
                                    this.selectedrow = dlgu.SelectedData;
                                    this.StringValue = dlgu.SelectedData.ID;
                                }
                            }
                            else
                            {
                                this.selectedrow = null;
                                this.StringValue = null;
                            }
                        }
                        #endregion
                        break;
                    case eSearchType.Customer:
                        #region Customer
                        using (CustomerDialog dlgc = new CustomerDialog(null))
                        {
                            if (dlgc.RowCount == 1)
                            {
                                if (OptionalTextBox != null)
                                {
                                    OptionalTextBox.Text = dlgc.SelectedData.ADDR;
                                }
                                IntV = dlgc.SelectedData.ID;
                                this.selectedrow = dlgc.SelectedData;
                            }
                            else if (dlgc.RowCount > 1)
                            {
                                if (dlgc.ShowDialog(this) == DialogResult.OK)
                                {
                                    if (OptionalTextBox != null)
                                    {
                                        OptionalTextBox.Text = dlgc.SelectedData.ADDR;
                                    }
                                    IntV = dlgc.SelectedData.ID;
                                    this.selectedrow = dlgc.SelectedData;
                                }
                            }
                            else
                            {
                                if (OptionalTextBox != null)
                                {
                                    OptionalTextBox.Text = null;
                                }
                                IntV = null;
                                this.selectedrow = null;
                            }
                        }
                        #endregion
                        break;
                    case eSearchType.Project:
                        #region Project
                        using (ProjectDialog dlgp = new ProjectDialog(null))
                        {
                            if (dlgp.RowCount == 1)
                            {
                                if (OptionalTextBox != null)
                                {
                                    OptionalTextBox.Text = dlgp.SelectedData.ADDR;
                                }
                                IntV = dlgp.SelectedData.ID;
                                this.selectedrow = dlgp.SelectedData;
                            }
                            else if (dlgp.RowCount > 1)
                            {
                                if (dlgp.ShowDialog(this) == DialogResult.OK)
                                {
                                    if (OptionalTextBox != null)
                                    {
                                        OptionalTextBox.Text = dlgp.SelectedData.ADDR;
                                    }
                                    IntV = dlgp.SelectedData.ID;
                                    this.selectedrow = dlgp.SelectedData;
                                }
                            }
                            else
                            {
                                if (OptionalTextBox != null)
                                {
                                    OptionalTextBox.Text = null;
                                }
                                IntV = null;
                                this.selectedrow = null;
                            }
                        }
                        #endregion
                        break;
                    case eSearchType.Instrument:
                        #region Instrument
                        using (InstrumentDialog dlgi = new InstrumentDialog(null))
                        {
                            if (dlgi.RowCount == 1)
                            {
                                IntV = dlgi.SelectedData.ID;
                                this.selectedrow = dlgi.SelectedData;
                            }
                            else if (dlgi.RowCount > 1)
                            {
                                if (dlgi.ShowDialog(this) == DialogResult.OK)
                                {
                                    IntV = dlgi.SelectedData.ID;
                                    this.selectedrow = dlgi.SelectedData;
                                }
                            }
                            else
                            {
                                IntV = null;
                                this.selectedrow = null;
                            }
                        }
                        #endregion
                        break;
                    case eSearchType.MethodAnalysis:
                        #region MethodAnalysis
                        using (MethodAnalysisDialog dlgm = new MethodAnalysisDialog(null))
                        {
                            if (dlgm.RowCount == 1)
                            {
                                IntV = dlgm.SelectedData.ID;
                                this.selectedrow = dlgm.SelectedData;
                            }
                            else if (dlgm.RowCount > 1)
                            {
                                if (dlgm.ShowDialog(this) == DialogResult.OK)
                                {
                                    IntV = dlgm.SelectedData.ID;
                                    this.selectedrow = dlgm.SelectedData;
                                }
                            }
                            else
                            {
                                IntV = null;
                                this.selectedrow = null;
                            }
                        }
                        #endregion
                        break;
                    case eSearchType.ParameterAnalysis:
                        #region ParameterAnalysis
                        using (ParameterAnalysisDialog dlgm = new ParameterAnalysisDialog(null))
                        {
                            if (dlgm.RowCount == 1)
                            {
                                IntV = dlgm.SelectedData.ID;
                                this.selectedrow = dlgm.SelectedData;
                            }
                            else if (dlgm.RowCount > 1)
                            {
                                if (dlgm.ShowDialog(this) == DialogResult.OK)
                                {
                                    IntV = dlgm.SelectedData.ID;
                                    this.selectedrow = dlgm.SelectedData;
                                }
                            }
                            else
                            {
                                IntV = null;
                                this.selectedrow = null;
                            }
                        }
                        #endregion
                        break;
                    case eSearchType.ToolPick:
                        #region ToolPick
                        using (ToolPickDialog dlgm = new ToolPickDialog(null))
                        {
                            if (dlgm.RowCount == 1)
                            {
                                IntV = dlgm.SelectedData.ID;
                                this.selectedrow = dlgm.SelectedData;
                            }
                            else if (dlgm.RowCount > 1)
                            {
                                if (dlgm.ShowDialog(this) == DialogResult.OK)
                                {
                                    IntV = dlgm.SelectedData.ID;
                                    this.selectedrow = dlgm.SelectedData;
                                }
                            }
                            else
                            {
                                IntV = null;
                                this.selectedrow = null;
                            }
                        }
                        #endregion
                        break;
                    case eSearchType.ToolAnalysis:
                        #region ToolAnalysis
                        using (ToolAnalysisDialog dlgm = new ToolAnalysisDialog(null))
                        {
                            if (dlgm.RowCount == 1)
                            {
                                IntV = dlgm.SelectedData.ID;
                                this.selectedrow = dlgm.SelectedData;
                            }
                            else if (dlgm.RowCount > 1)
                            {
                                if (dlgm.ShowDialog(this) == DialogResult.OK)
                                {
                                    IntV = dlgm.SelectedData.ID;
                                    this.selectedrow = dlgm.SelectedData;
                                }
                            }
                            else
                            {
                                IntV = null;
                                this.selectedrow = null;
                            }
                        }
                        #endregion
                        break;
                    case eSearchType.StandardLight:
                        #region StandardLight
                        using (StandardLightDialog dlgm = new StandardLightDialog(null))
                        {
                            if (dlgm.RowCount == 1)
                            {
                                IntV = dlgm.SelectedData.ID;
                                this.selectedrow = dlgm.SelectedData;
                            }
                            else if (dlgm.RowCount > 1)
                            {
                                if (dlgm.ShowDialog(this) == DialogResult.OK)
                                {
                                    IntV = dlgm.SelectedData.ID;
                                    this.selectedrow = dlgm.SelectedData;
                                }
                            }
                            else
                            {
                                IntV = null;
                                this.selectedrow = null;
                            }
                        }
                        #endregion
                        break;
                }
                if (OnSelected != null)
                {
                    OnSelected(this, null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool ValidateControl()
        {
            if (this.IsRequired)
            {
                if ((!this.IntValue.HasValue || this.IntValue == 0) && this.StringValue.IsNull())
                {
                    SetValid("ค่าห้ามว่าง");
                    return false;
                }
            }
            return base.ValidateControl();
        }

        private void SetText()
        {
            try
            {
                this.Text = GetTextDisplay();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GetTextDisplay()
        {
            try
            {
                string text = null;
                if (IntV > 0 || StringValue.HasValue())
                {
                    switch (SearchType)
                    {
                        case eSearchType.None:
                            break;
                        case eSearchType.User:
                            var obj101 = vmMas.GetUser(StringValue);
                            text = obj101.FULLNAME_TH;
                            this.selectedrow = obj101;
                            break;
                        case eSearchType.Customer:
                            var obj201 = vmMas.GetCustomer(IntV.GetValueOrDefault());
                            text = obj201.NAME;
                            this.selectedrow = obj201;
                            break;
                        case eSearchType.Project:
                            var obj202 = vmMas.GetCustomerProject(IntV.GetValueOrDefault());
                            text = obj202.NAME;
                            this.selectedrow = obj202;
                            break;
                        case eSearchType.Instrument:
                            var obj303 = vmMas.GetInstrument(IntV.GetValueOrDefault());
                            text = obj303.NAME;
                            this.selectedrow = obj303;
                            break;
                        case eSearchType.MethodAnalysis:
                            this.selectedrow = vmMas.GetMethodAnalysis(IntV.GetValueOrDefault());
                            text = (this.selectedrow as sp_MAS304_GetMethodAnalysis_Result).NAME;
                            break;
                        case eSearchType.ParameterAnalysis:
                            this.selectedrow = vmMas.GetParameterAnalysis(IntV.GetValueOrDefault());
                            text = (this.selectedrow as sp_MAS305_GetParameterAnalysis_Result).NAME;
                            break;
                        case eSearchType.ToolPick:
                            var obj308 = vmMas.GetToolPick(IntV.GetValueOrDefault());
                            text = obj308.NAME;
                            this.selectedrow = obj308;
                            break;
                        case eSearchType.ToolAnalysis:
                            var obj309 = vmMas.GetToolAnalysis(IntV.GetValueOrDefault());
                            text = obj309.NAME;
                            this.selectedrow = obj309;
                            break;
                        case eSearchType.StandardLight:
                            var obj302 = vmMas.GetSTDLight(IntV.GetValueOrDefault());
                            text = obj302.ALIAS_NAME.GetValueOrDefault(obj302.NAME);
                            this.selectedrow = obj302;
                            break;
                    }
                }
                return text;
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
                    TextChange();
                    break;
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            TextChange();
        }
        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
            SearchOnDialog();
        }
        #endregion
    }

    public enum eSearchType
    {
        None,
        User,
        Customer,
        Project,
        Instrument,
        MethodAnalysis,
        ParameterAnalysis,
        ToolPick,
        ToolAnalysis,
        StandardLight,
    }
}
