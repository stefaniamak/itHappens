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
    public partial class CommonSearchTextPage : UserControl
    {
        public string chosenPage;
        public CommonSearchTextPage()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.openCommonSearchTextPage("search");
        }
    }
}
