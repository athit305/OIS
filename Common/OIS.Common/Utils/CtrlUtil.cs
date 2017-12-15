using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIS.Common.Utils
{
    public static class CtrlUtil
    {
        public static void EnableControls(bool isEnable, params Control[] controls)
        {
            try
            {
                foreach(Control ctrl in controls)
                {
                    ctrl.Enabled = isEnable;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void EnableControls(bool isEnable, params ToolStripMenuItem[] ts)
        {
            try
            {
                foreach (ToolStripMenuItem ctrl in ts)
                {
                    ctrl.Enabled = isEnable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void VisibleControls(bool isVisible, params Control[] controls)
        {
            try
            {
                foreach(Control ctrl in controls)
                {
                    ctrl.Visible = isVisible;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
