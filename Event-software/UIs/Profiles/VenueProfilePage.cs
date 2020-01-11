using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using itHappens.Classes;
using itHappens.UIs.Common;
using itHappends;

namespace itHappens.UIs.andrea
{
    public partial class VenueProfilePage : UserControl
    {
        public int venueId { get; set; }
        public int eventId { get; set; }

        private static VenueProfilePage _instance = new VenueProfilePage();
        public static VenueProfilePage Instance => _instance;

        public VenueProfilePage()
        {
            InitializeComponent();
        }

        private void VenueProfilePage_Load(object sender, EventArgs e)
        {
            showUserControls();
        }

        public VenueProfilePage(int venueId, string venueName, Image profilePicture, Image venueBackground)
        {
            InitializeComponent();

            //showUserControls();

            venueNameLabel.Text = venueName;
            venueProfilePictureOvalPictureBox.BackgroundImage = profilePicture;
            //backgroundPictureBox.BackgroundImage = eventBackground;
            //monthLabel.Text = Utility.Month(eventDateTime);
            //dayLabel.Text = Utility.Day(eventDateTime);
            //categoryColorPanel.BackColor = Color.FromName(categoryColor);
            //miniEventBackgroundPictureBox.BackgroundImage = eventBackground;

            this.venueId = venueId;
            this.eventId = eventId;
        }

        private void showUserControls()
        {
            for (int i = 0; i < 5; i++)
            {
                friendsVisitedFlowLayoutPanel.Controls.Add(new UIs.Common.FriendsWhoHaveVisited());
            }

            for (int i = 0; i < 10; i++)
            {
                eventsUserWillAttendCarousel.AddControl(new UIs.Common.EventMiniView());
            }
        }

        public void friendsWhoHaveVisited(string friendName, string friendSurname)
        {
            friendsVisitedFlowLayoutPanel.Controls.Add(new UIs.Common.FriendsWhoHaveVisited(friendName, friendSurname));
        }

        private void interestedButton_Click(object sender, EventArgs e)
        {

        }
     
    }
}
