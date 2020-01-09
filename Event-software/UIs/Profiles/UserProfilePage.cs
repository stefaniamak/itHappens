using System;
using System.Drawing;
using System.Windows.Forms;
using itHappens.Classes;

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

            userNameLabel.Text = userName + " " + userSurname; 
            userProfilePictureOvalPictureBox.BackgroundImage = profilePicture;
            userBackgroundPictureBox.BackgroundImage = userBackground;
            monthLabel.Text = Utility.Month(eventDateTime);
            dayLabel.Text = Utility.Day(eventDateTime);

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
