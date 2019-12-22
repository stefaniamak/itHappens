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
    public partial class Carousel : UserControl
    {
        public Carousel()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        public void AddControl(UserControl control)
        {
            carouselFlowLayout.Controls.Add(control);
        }

        public void Clear()
        {
            carouselFlowLayout.Controls.Clear();
        }
    }
}
