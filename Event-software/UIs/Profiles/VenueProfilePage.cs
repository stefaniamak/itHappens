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
            showUserControls();
        }

        public VenueProfilePage(string venueName, Color categoryColor, Image profilePicture, Image venueBackground, Image eventBackground, DateTime eventDateTime)
        {
            InitializeComponent();

            showUserControls();

            venueNameLabel.Text = venueName; // prosthaise kai to userSurname
            venueProfilePictureOvalPictureBox.BackgroundImage = profilePicture;
            backgroundPictureBox.BackgroundImage = eventBackground;
            //monthLabel.Text =      // Tha Kaneis mia methodo pou tha emfanizei ta 3 prwta grammata tou mhna pou ginete, se kefalaia
            //dayLabel               // Mono thn mera, des to design
            categoryColorPanel.BackColor = categoryColor; 
            miniEventBackgroundPictureBox.BackgroundImage = eventBackground;

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
