using System;
using System.Drawing;
using System.Windows.Forms;
using itHappends;
using itHappens.Classes;
using itHappens.UIs.Common;

namespace itHappens.UIs.andrea
{
    public partial class UserProfilePage : UserControl
    {

        public int userId { get; set; }
        public int eventId { get; set; }

        private static UserProfilePage _instance = new UserProfilePage();
        public static UserProfilePage Instance => _instance;

        public UserProfilePage()
        {
            InitializeComponent();
        }

        public UserProfilePage(int userId, string userName, string userSurname, Image profilePicture)
        {
            InitializeComponent();

            //eventsUserWillAttend();
            //vanueLabel.Text = evLocation;
            userNameLabel.Text = userName + " " + userSurname;
            userProfilePictureOvalPictureBox.BackgroundImage = profilePicture;
            //monthLabel.Text = Utility.Month(eventDateTime);
            //dayLabel.Text = Utility.Day(eventDateTime);

            //categoryColorPanel.BackColor = Color.FromName(categoryColor);
            //vanueLabel.Text = venueName;
            //miniEventBakcgroundPictureBox.BackgroundImage = eventBackground;

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

        public void miniCaruselFillWithEventMiniView(string categoryColor, int theEventId)
        {
            eventsUserWillAttendCarousel.AddControl(new UIs.Common.EventMiniView(categoryColor, theEventId));
        }

        /*
        public static void openUserPage(object sender, EventArgs e, int userId)
        {
            
            MainSplitForm.middlePanel.Controls.Clear();
            var v = Db_connector.Query(@"Select user.id, user.name , user.surname, venues.name, category.color,
                                        event.startingDate  
						FROM events e JOIN venues v 
						ON e.venueID = v.id
						JOIN category c
						ON e.categoryID = c.id
						JOIN user u
						ON e.ownerID = u.id
						WHERE @userId = e.id",
                      new string[,] { { "@userId", userId + "" } });
            v.Read();
            var middlePage = new UserProfilePage
                ( v.GetString(1),
                 v.GetString(2), v.GetString(3),
                 null, null, null, null, v.GetDateTime(5));
            MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
           
            
        }*/

    }
}
