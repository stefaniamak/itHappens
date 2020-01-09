using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/// <summary>
///se auto pou tha paei o xristis ..... ?
/// </summary>
namespace itHappens.UIs.valentina
{
    public partial class ListPage : UserControl
    {
        public ListPage()
        {
            InitializeComponent();
        }

        private void ListPage_Load(object sender, EventArgs e)
        {
            Controllers.UIController.ListPageLoad();
        }
    }
}
