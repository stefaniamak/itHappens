using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Common
{
    public partial class EventMiniView : UserControl
    {
        public static int eventId;
        public EventMiniView()
        {
            InitializeComponent();
            hoverOverPanel.Visible = false;
        }

        public EventMiniView(Image eventImage, string categoryColor) : this()
        {
            InitializeComponent();
            Color catColor = Color.FromName(categoryColor);


            eventPictureBox.Image = eventImage;
            categoryColorPanel.BackColor = catColor;
            hoverOverPanel.Visible = false;
        }

        //  -----------  Προσωρινός Constructor χωρίς τα insert εικόνων.  -----------
        public EventMiniView(string categoryColor, int theEventId) : this()
        {
            Color catColor = Color.FromName(categoryColor);
            categoryColorPanel.BackColor = catColor;
            hoverOverPanel.Visible = false;
            eventId = theEventId;
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
            Controllers.UIController.Instance.eventsProfileToolStripMenuItem_MiddlePanel(eventId);
        }

        private void goingListOvalPictureBox_Click(object sender, EventArgs e)
        {
            // Adds that Event on the GOING list
        }

        private void intrestedListOvalPictureBox_Click(object sender, EventArgs e)
        {
            // Adds that Event on the INTERESTED list
        }
    }
}
