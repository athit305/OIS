using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OIS.BaseViews
{
    public partial class rLabel : Label
    {
        private bool autoSize = true;

        public override ContentAlignment TextAlign
        {
            get
            {
                return ContentAlignment.TopRight;
            }
        }

        public override bool AutoSize
        {
            get
            {
                return autoSize;
            }

            set
            {
                autoSize = value;
                base.AutoSize = value;
            }
        }
    }
}
