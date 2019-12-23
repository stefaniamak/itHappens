using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.stefania
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void todayEventsCarousel_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                todayEventsCarousel.AddControl(new Common.EventMiniView());
            }

            for (int i = 0; i < 5; i++)
            {
                madeForYouCarusel.AddControl(new Common.CategoryGroupBox());
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
