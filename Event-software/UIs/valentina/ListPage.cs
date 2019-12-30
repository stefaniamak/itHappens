using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.valentina
{
    public partial class ListPage : UserControl
    {
        public ListPage()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ListPage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                var listminibox = new Common.ListMiniBox();
                //  eventminiview.Scale(0.55F);
                ListsFlowLayoutPanel.Controls.Add(listminibox);
            }
        }
    }
}
