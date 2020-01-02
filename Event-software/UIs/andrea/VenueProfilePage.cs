using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.andrea
{
    public partial class VenueProfilePage : UserControl
    {
        public VenueProfilePage()
        {
            InitializeComponent();
        }    

        private void VenueProfilePage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                friendsVisitedFlowLayoutPanel.Controls.Add(new UIs.Common.FriendsAttending());
            }
        }

        private void interestedButton_Click(object sender, EventArgs e)
        {

        }
    }
}
