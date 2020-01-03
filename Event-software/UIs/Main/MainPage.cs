using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Main
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void todayEventsCarousel_Load(object sender, EventArgs e)
        {
            Controllers.UIController.MainPageTodayEventsAndMadeForYouCarousel_Load();
        }

       
    }
}
