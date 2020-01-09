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
        public EventMiniView()
        {
            InitializeComponent();
        }

        public EventMiniView(Image eventImage, string categoryColor) : this()
        {
            Color catColor = Color.FromName(categoryColor);

            eventPictureBox.Image = eventImage;
            categoryColorPanel.BackColor = catColor;
        }

        public EventMiniView(string categoryColor) : this()
        {
            Color catColor = Color.FromName(categoryColor);
            categoryColorPanel.BackColor = catColor;

        }


        private void EventMiniView_MouseHover(object sender, EventArgs e)
        {

        }

        private void eventTableLayout_Paint(object sender, PaintEventArgs e)
        {
            // Method for the Controller
        }
    }
}
