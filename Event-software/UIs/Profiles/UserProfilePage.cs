using System;
using System.Drawing;
using System.Windows.Forms;

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

            userNameLabel.Text = userName; // prosthaise kai to userSurname
            userProfilePictureOvalPictureBox.BackgroundImage = profilePicture;

            //monthLabel.Text =      // Tha Kaneis mia methodo pou tha emfanizei ta 3 prwta grammata tou mhna pou ginete, se kefalaia
            //dayLabel               // Mono thn mera, des to design
            categoryColorPanel.BackColor = Color.FromName(categoryColor); 
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

    }
}
