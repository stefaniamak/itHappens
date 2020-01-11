using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Common
{
    public partial class NotificationBox : UserControl
    {
        public NotificationBox()
        {
            InitializeComponent();
        }

        public void AddControl(UserControl control)
        {
            notificationFlowLayoutPanel.Controls.Add(control);
        }
    }
}
