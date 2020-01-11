using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Sidebars.FriendList
{
    public partial class FriendListMini : UserControl
    {
        public FriendListMini()
        {
            InitializeComponent();
        }

        public FriendListMini(Image friendProfilePic, string friendName, string friendSurname, string EventName, string venueLocation, DateTime time)
        {
            InitializeComponent();

            friendProfilePicOvalPictureBox.BackgroundImage = friendProfilePic;
            friendNameLabel.Text = friendName;
            FriendSurnameLabel.Text = friendSurname;
            eventNameLabel.Text = EventName;
            locationLabel.Text = venueLocation;

            DateTime dt = time;
            string timef = dt.ToString("hh,ss");
            timeLabel.Text = timef;

        }

        //  -----------  Προσωρινός Constructor χωρίς τα insert εικόνων.  -----------  
        public FriendListMini(string friendName, string friendSurname, string EventName, string venueLocation, DateTime time)
        {
            InitializeComponent();

            friendNameLabel.Text = friendName;
            FriendSurnameLabel.Text = friendSurname;
            eventNameLabel.Text = EventName;
            locationLabel.Text = venueLocation;

            DateTime dt = time;
            string timef = dt.ToString("hh,ss");
            timeLabel.Text = timef;
        }


        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
