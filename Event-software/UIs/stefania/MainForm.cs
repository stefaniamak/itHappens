using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
      

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            for (int i = 0; i < 10; i++)
            {
                todayEventsCarousel.AddControl(new Common.EventMiniView());
            }

            for (int i = 0; i < 5; i++)
            {
                madeForYouCarusel.AddControl(new Common.CategoryGroupBox());
            }
            */

            /*
            var scroll = todayEventsCarousel.AutoScrollPosition;
            scroll.X = 0;
            todayEventsCarousel.AutoScrollPosition = scroll;
            */
        }

    }
}
