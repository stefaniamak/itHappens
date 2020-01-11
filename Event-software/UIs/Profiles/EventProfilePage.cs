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
    public partial class EventProfilePage : UserControl
    {
        public int organizerId { get; set; }
        public int eventId { get; set; }

        private static EventProfilePage _instance = new EventProfilePage();
        public static EventProfilePage Instance => _instance;

        public EventProfilePage()
        {
            InitializeComponent();
            friends();

        }


        //public EventProfilePage(string eventName, string venueName, string categoryColor, Image background, string organizerName,
        //                        string organizerSurename, DateTime eventDateTime, double ticketPrice, string description);

        public EventProfilePage(int organizerId, int eventId, string eventName, string venueName, string categoryColor, Image background, string organizerName, string organizerSurename, DateTime eventDateTime, double ticketPrice, string description)

        {
            InitializeComponent();

            friends();
            categoryColorPanel.BackColor = Utility.FromName(categoryColor);
            eventNameLabel.Text = eventName;
            monthLabel.Text = Utility.Month(eventDateTime);
            dayLabel.Text = Utility.Day(eventDateTime);
            //categoryColorLabel.BackColor = Utility.FromName(categoryColor); category color label doesnt exists
            backgroundPictureBox.BackgroundImage = background;
            locationTextBox.Text = venueName;
            organizerTextBox.Text = organizerName +" "+ organizerSurename ;
            dayTimeTextBox.Text = Utility.DateToText(eventDateTime);
            ticketPriceLabel.Text = ticketPrice + "";
            descriptionTextBox.Text = description;

            this.organizerId = organizerId;
            this.eventId = eventId;
        }

        private void friends()
        {
            for (int i = 0; i < 5; i++)
            {
                friendsFlowPanel.Controls.Add(new UIs.Common.FriendsAttending());
            }
        }

        public void friendsWhoWillAttend(Image friendProfilePicture, string friendName, string friendSurname, string attendingList)
        {
            friendsFlowPanel.Controls.Add(new UIs.Common.FriendsAttending(friendProfilePicture, friendName, friendSurname, attendingList));
        }

        private void EventProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }
        public static void openEventProfile(object sender, EventArgs e)
        {
            /*
            var eventview = (EventMiniView)sender;
            MainSplitForm.middlePanel.Controls.Clear();
            int eventid = eventview.eventId;
            var v = Db_connector.Query(@"Select event.title, venues.name, category.color, user.name , 
                        user.surname ,event.startingDate, 
						event.ticketprice,event.description  
						FROM events e JOIN venues v 
						ON e.venueID = v.id
						JOIN category c
						ON e.categoryID = c.id
						JOIN user u
						ON e.ownerID = u.id
						WHERE @eventid = e.id",
                       new string[,] { { "@eventid", eventid + "" } });
            v.Read();
            var middlePage = new UIs.andrea.EventProfilePage
                (v.GetString(0), v.GetString(1),
                 v.GetString(2), null, v.GetString(3),
                 v.GetString(4), v.GetDateTime(5),
                 v.GetDouble(6), v.GetString(7));
            MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
           */
        }
    }
}
