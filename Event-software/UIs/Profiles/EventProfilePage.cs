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

namespace itHappens.UIs.andrea
{
    public partial class EventProfilePage : UserControl
    {
        public int organizerId { get; set; }
        public int eventId { get; set; }

        public EventProfilePage()
        {
            InitializeComponent();
            friends();

        }

        public EventProfilePage(int organizerId, int eventId, string eventName, string venueName, string categoryColor, Image background, string organizerName, string organizerSurename, DateTime  eventDateTime, double ticketPrice, string description)
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

        private void EventProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }
        public static void openEventProfile(object sender, EventArgs e)
        {
            MainSplitForm.middlePanel.Controls.Clear();
            var middlePage = new UIs.andrea.EventProfilePage();
            MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }
    }
}
