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
        public VenueProfilePage()
        {
            InitializeComponent();
        }

        private void VenueProfilePage_Load(object sender, EventArgs e)
        {
            showUserControls();
        }

        public VenueProfilePage(int venueId, int eventId, string venueName, string categoryColor, Image profilePicture, Image venueBackground, Image eventBackground, DateTime eventDateTime)
        {
            InitializeComponent();

            showUserControls();

            venueNameLabel.Text = venueName;
            venueProfilePictureOvalPictureBox.BackgroundImage = profilePicture;
            backgroundPictureBox.BackgroundImage = eventBackground;
            monthLabel.Text = Utility.Month(eventDateTime);
            dayLabel.Text = Utility.Day(eventDateTime);
            categoryColorPanel.BackColor = categoryColor;
            miniEventBackgroundPictureBox.BackgroundImage = eventBackground;

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

        private void interestedButton_Click(object sender, EventArgs e)
        {

        }
     /*  public static void OpenVenueProfile(object sender, EventArgs e, int venueId)
        {
            MainSplitForm.middlePanel.Controls.Clear();
            var v = Db_connector.Query(@"Select event.startingDate, venues.name                                         
					        	       FROM events e JOIN venues v 
						               ON e.venueID = v.id						
						               WHERE @venueId = e.id",
                                        new string[,] { { "@venueId", venueId + "" } });
            v.Read();
            var middlePage = new VenueProfilePage(v.GetString(0),null, null, null, null, v.GetDateTime(1));
            MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;


        }*/
    }
}
