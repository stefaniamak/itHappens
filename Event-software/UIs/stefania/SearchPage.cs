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
    public partial class SearchPage : UserControl
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void SearchFormTest_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                flowLayoutPanel1.Controls.Add(new Common.CategoryMiniBox());
            }
            for (int i = 0; i < 20; i++)
            {
                flowLayoutPanel2.Controls.Add(new Common.CategoryMiniBox());
            }

            for (int i = 0; i < 20; i++)
            {
                flowLayoutPanel3.Controls.Add(new Common.EventMiniView());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
