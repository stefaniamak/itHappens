using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Sidebars.UpcomingEvents
{
    public partial class UpcomingEventMini : UserControl
    {
        public UpcomingEventMini()
        {
            InitializeComponent();
        }

        public UpcomingEventMini(string eventTitle, string categoryLocation, string eventDate) : this()
        {
            eventName.Text = eventTitle;
            location.Text = categoryLocation;
            date.Text = eventDate;
            //month.Text = eventDate;
        }

        private void eventName_Click(object sender, EventArgs e)
        {

        }

        private void location_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void month_Click(object sender, EventArgs e)
        {

        }
    }
}
