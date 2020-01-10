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

            venueNameLabel.Text = venueName; // prosthaise kai to userSurname
            venueProfilePictureOvalPictureBox.BackgroundImage = profilePicture;
            backgroundPictureBox.BackgroundImage = eventBackground;
            //monthLabel.Text =      // Tha Kaneis mia methodo pou tha emfanizei ta 3 prwta grammata tou mhna pou ginete, se kefalaia
            //dayLabel               // Mono thn mera, des to design
            categoryColorPanel.BackColor = Color.FromName(categoryColor); 
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
    }
}
