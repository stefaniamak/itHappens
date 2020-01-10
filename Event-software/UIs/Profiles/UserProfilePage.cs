using System;
using System.Drawing;
using System.Windows.Forms;
using itHappens.Classes;
using itHappens.UIs.Common;

namespace itHappens.UIs.andrea
{
    public partial class UserProfilePage : UserControl
    {
        public int userId { get; set; }
        public int eventId { get; set; }

        public UserProfilePage()
        {
            InitializeComponent();
        }

        public UserProfilePage(int userId, int eventId, string userName, string userSurname, string venueName, string categoryColor, Image profilePicture, Image eventBackground, DateTime eventDateTime)
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

            this.userId = userId;
            this.eventId = eventId;

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

        public static void openUserPage(object sender, EventArgs e)
        {
            MainSplitForm.middlePanel.Controls.Clear();
            var middlePage = new UIs.andrea.UserProfilePage();
            MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

    }
}
