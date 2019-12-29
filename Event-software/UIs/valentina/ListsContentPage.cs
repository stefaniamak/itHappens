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
    public partial class ListsContentPage : UserControl
    {
        public ListsContentPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ListsContentPage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                var eventminiview = new Common.EventMiniView();
              //  eventminiview.Scale(0.55F);
                EventHolderFlowLayoutPanel.Controls.Add(eventminiview);
            }
        }
    }
}
