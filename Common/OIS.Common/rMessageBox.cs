using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OIS.Definition;

namespace OIS.Common
{
    public static class rMessageBox
    {
        public static DialogResult ShowException(IWin32Window owner, Exception ex)
        {
            if (ex.InnerException != null)
            {
                return MessageBox.Show(owner, ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MessageBox.Show(owner, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowError(IWin32Window owner, string text)
        {
            return MessageBox.Show(owner, text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowInfomation(IWin32Window owner, string text)
        {
            return MessageBox.Show(owner, text, OISBaseConstant.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowWarning(IWin32Window owner, string text, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(owner, text, OISBaseConstant.MessageBoxTitle, buttons, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowConfirmation(IWin32Window owner, string text, MessageBoxButtons buttons = MessageBoxButtons.YesNo)
        {
            return MessageBox.Show(owner, text, OISBaseConstant.MessageBoxTitle, buttons, MessageBoxIcon.Question);
        }

        public static DialogResult ShowProcessCompleted(IWin32Window owner)
        {
            return MessageBox.Show(owner, MessageCode.INF0003, OISBaseConstant.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
