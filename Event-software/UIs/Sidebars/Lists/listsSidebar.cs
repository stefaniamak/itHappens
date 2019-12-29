using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Sidebars
{
    public partial class ListsSidebar : UserControl
    {
        public ListsSidebar()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                listsFlowLayoutPanel.Controls.Add(new Lists.ListsMini());
                //listsHorizontalListing.SetFlowBreak(listsHorizontalListing, true);
            }
        }

        private void listsHorizontalListing_Load(object sender, EventArgs e)
        {
            
        }

        private void carousel1_Load(object sender, EventArgs e)
        {

        }
    }
}
