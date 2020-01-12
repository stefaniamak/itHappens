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
using dbstuff;

namespace itHappens.UIs.Common
{
    public partial class EventMiniView : UserControl
    {
        public static int eventId;
        private DbController dbCon = new DbController();
        public EventMiniView()
        {
            InitializeComponent();
            hoverOverPanel.Visible = false;
            if (UIs.anna.LogInPage.loggedInUser == true)
                EnableButtons();
        }

        public EventMiniView(Image eventImage, string categoryColor) : this()
        {
            InitializeComponent();
            Color catColor = Color.FromName(categoryColor);


            eventPictureBox.Image = eventImage;
            categoryColorPanel.BackColor = catColor;
            hoverOverPanel.Visible = false;
            if (UIs.anna.LogInPage.loggedInUser == true)
                EnableButtons();
        }

        //  -----------  Προσωρινός Constructor χωρίς τα insert εικόνων.  -----------
        public EventMiniView(string categoryColor, int theEventId, string eventTitle, Image eventImage) : this()
        {
            Color catColor = Color.FromName(categoryColor);
            categoryColorPanel.BackColor = catColor;
            hoverOverPanel.Visible = false;

            //eventIdLabel.Text = theEventId.ToString();
            eventId = theEventId;
            savedEventId.Text = theEventId + "";

            eventTitleLabel.Text = eventTitle;

            if (eventImage != null)
            {
                eventPictureBox.BackgroundImage = eventImage;
            }

        }

        public int getEventId()
        {
            string eventIdString = savedEventId.Text;

            int eventInt = Int32.Parse(eventIdString);
            return eventInt;
        }

        public void EnableButtons()
        {
            goingListOvalPictureBox.Enabled = true;
            intrestedListOvalPictureBox.Enabled = true;
        }

        private void eventTableLayout_Paint(object sender, PaintEventArgs e)
        {
            // Method for the Controller
        }

        private void hoverOverPanel_MouseHover(object sender, EventArgs e)
        {

        }

        private void hoverOverPanel_MouseEnter(object sender, EventArgs e)
        {

        }

        private void EventMiniView_MouseEnter(object sender, EventArgs e)
        {

        }

        private void eventPictureBox_MouseHover(object sender, EventArgs e)
        {

        }

        private void EventMiniView_MouseHover(object sender, EventArgs e)
        {

        }

        private void eventPictureBox_MouseEnter(object sender, EventArgs e)
        {
            hoverPanelVisibility(true);
        }

        private void hoverOverPanel_MouseLeave(object sender, EventArgs e)
        {
            hoverPanelVisibility(false);
        }

        private void hoverPanelVisibility(bool requestedState)
        {
            hoverOverPanel.Visible = requestedState;
        }

        private void detailsButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void goingListOvalPictureBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void intrestedListOvalPictureBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            // opens Venue Profile Page
            int eventId = getEventId();
            Controllers.UIController.Instance.eventsProfileToolStripMenuItem_MiddlePanel(eventId);
            hoverPanelVisibility(false);
        }

        private void goingListOvalPictureBox_Click(object sender, EventArgs e)
        {
            hoverPanelVisibility(false);
            dbCon.addGoing(getEventId(), UIs.anna.LogInPage.userId); // Adds that Event on the GOING list
        }

        private void intrestedListOvalPictureBox_Click(object sender, EventArgs e)
        {
            hoverPanelVisibility(false);
            dbCon.addInterested(getEventId(), UIs.anna.LogInPage.userId); // Adds that Event on the INTERESTED list
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            hoverPanelVisibility(false);
        }

        private void categoryColorPanel_Paint(object sender, PaintEventArgs e)
        {
            hoverPanelVisibility(false);
        }
    }
}
