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
            Controllers.UIController.SearchPageFlowLayoutPanels_Load();       
        }


    }
}
