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

        public UserProfilePage(int userId, int eventId, string userName, string userSurname, string venueName, string evLocation, string categoryColor, Image profilePicture, Image eventBackground, DateTime eventDateTime)
        {
            InitializeComponent();

            //eventsUserWillAttend();
            vanueLabel.Text = evLocation;
            userNameLabel.Text = userName + " " + userSurname;
            userProfilePictureOvalPictureBox.BackgroundImage = profilePicture;
            monthLabel.Text = Utility.Month(eventDateTime);
            dayLabel.Text = Utility.Day(eventDateTime);

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

        public void miniCaruselFillWithEventMiniView(string categoryColor, int theEventId)
        {
            eventsUserWillAttendCarousel.AddControl(new UIs.Common.EventMiniView(categoryColor, theEventId));
        }

        
      /*  public static void openUserPage(object sender, EventArgs e, int userId)
        {
           
            MainSplitForm.middlePanel.Controls.Clear();
            var v = Db_connector.Query(@"Select user.id, event.id, user.name , user.surname, venues.name, area.address, category.color,
                                        event.startingDate ,
						FROM events e JOIN venues v 
						ON e.venueID = v.id
						JOIN category c
						ON e.categoryID = c.id
						JOIN user u
						ON e.ownerID = u.id
                        JOIN area a
                        ON e
						WHERE @userId = e.id",
                      new string[,] { { "@userId", userId + "" } });
            v.Read();
            var middlePage = new UserProfilePage
                (v.GetInt32(0),v.GetInt32(1),v.GetString(2), v.GetString(3),
                 v.GetString(4),v.GetString(5) , v.GetString(6),null,null,v.GetDateTime(7));
            MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;


        }*/

    }
}
