using System;
using System.Drawing;
using System.Windows.Forms;

namespace itHappens.UIs.andrea
{
    public partial class UserProfilePage : UserControl
    {
        public UserProfilePage()
        {
            InitializeComponent();
        }

        public UserProfilePage(string userName, string userSurname, string venueName, Color categoryColor, Image profilePicture, Image userBackground, Image eventBackground, DateTime eventDateTime)
        {
            InitializeComponent();

            eventsUserWillAttend();

            userNameLabel.Text = userName; // prosthaise kai to userSurname
            userProfilePictureOvalPictureBox.BackgroundImage = profilePicture;
            userBackgroundPictureBox.BackgroundImage = userBackground;

            //monthLabel.Text =      // Tha Kaneis mia methodo pou tha emfanizei ta 3 prwta grammata tou mhna pou ginete, se kefalaia
            //dayLabel               // Mono thn mera, des to design
            categoryColorPanel.BackColor = categoryColor; 
            vanueLabel.Text = venueName;
            miniEventBakcgroundPictureBox.BackgroundImage = eventBackground;

        }

        private void UserProfilePage_Load(object sender, EventArgs e)
        {
            eventsUserWillAttend();
        }


        private void eventsUserWillAttend()
        {
            for (int i = 0; i < 10; i++)
            {
                eventsUserWillAttendCarousel.AddControl(new UIs.Common.EventMiniView());
            }
        }

    }
}
