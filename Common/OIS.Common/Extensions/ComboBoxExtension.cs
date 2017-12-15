using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.Definition;

namespace OIS.Common.Extensions
{
    public static class ComboBoxExtension
    {
        internal class ComboSelectAll<T> : IComboBoxData<T>
        {
            private string _DISPLAY;
            public string DISPLAY
            {
                get { return OISBaseConstant.COMBO_SELECTALL_TEXT; }
                set { _DISPLAY = value; }
            }
            public T VALUE { get; set; }
        }

        public static void SetDataSource<T>(this ComboBox control, List<IComboBoxData<T>> DataSource, bool IncludedAll, object selectedvalue)
        {
            if (DataSource != null)
            {
                if (IncludedAll)
                {
                    ComboSelectAll<T> cboAll = new ComboSelectAll<T>();
                    DataSource.Insert(0, cboAll);
                }

                control.DisplayMember = "DISPLAY";
                control.ValueMember = "VALUE";
                control.DataSource = DataSource;

                if (selectedvalue != null)
                {
                    control.SelectedValue = selectedvalue;
                    if (!object.Equals(control.SelectedValue, selectedvalue))
                    {
                        control.SelectedIndex = -1;
                    }
                }
                else
                {
                    control.SelectedIndex = IncludedAll == true ? 0 : -1;
                }
            }
        }
        public static void SetDataSource<T>(this ComboBox control, List<IComboBoxData<T>> DataSource)
        {
            SetDataSource(control, DataSource, false, null);
        }
        public static void SetDataSource<T>(this ComboBox control, List<IComboBoxData<T>> DataSource, bool IncludedAll)
        {
            SetDataSource(control, DataSource, IncludedAll, null);
        }

        public static void SetDataSource<T>(this ComboBox control, BindingList<IComboBoxData<T>> DataSource, bool IncludedAll)
        {
            if (DataSource != null)
            {
                if (IncludedAll)
                {
                    ComboSelectAll<T> cboAll = new ComboSelectAll<T>();
                    DataSource.Insert(0, cboAll);
                }

                control.DisplayMember = "DISPLAY";
                control.ValueMember = "VALUE";
                control.DataSource = DataSource;

                control.SelectedIndex = IncludedAll == true ? 0 : -1;
            }
        }
        public static void SetDataSource<T>(this ComboBox control, BindingList<IComboBoxData<T>> DataSource)
        {
            SetDataSource(control, DataSource, false);
        }

        public static bool IsSelectAll(this ComboBox control)
        {
            return String.IsNullOrEmpty(control.Text) ||
                control.Text == OISBaseConstant.COMBO_SELECTALL_TEXT ||
                control.Text.Trim() == OISBaseConstant.COMBO_SELECTALL_TEXT.Split(':')[0].Trim();
        }
    }
}
