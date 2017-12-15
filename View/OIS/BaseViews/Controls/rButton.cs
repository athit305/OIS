using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OIS.BaseViews
{
    public partial class rButton : Button
    {
        protected override Size DefaultSize
        {
            get
            {
                return new Size(75, 27);
            }
        }
    }
}
