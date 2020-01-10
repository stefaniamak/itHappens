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
    public partial class notification : UserControl
    {
        public notification()
        {
            InitializeComponent();
        }

        public notification(string message)
        {
            InitializeComponent();

            notificationMessageLabel.Text = message;
        }
    }
}
