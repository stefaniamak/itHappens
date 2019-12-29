using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Sidebars
{
    public partial class UpcomingEventsSidebar : UserControl
    {
        public UpcomingEventsSidebar()
        {
            InitializeComponent();
            
            for (int i = 0; i < 10; i++)
            {
                var upevent = new UpcomingEvents.UpcomingEventMini();
                upcomingEventsFlowLayout.Controls.Add(upevent);
                //upevent
                //upevent.Anchor = (AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
                //upcomingEventsFlowLayout.SetFlowBreak(upcomingEventsFlowLayout, true);
            }

            //upcomingEventsFlowLayout.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);

        }

        private void mainFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
