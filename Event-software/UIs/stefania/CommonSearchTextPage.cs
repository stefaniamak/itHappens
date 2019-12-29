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
    public partial class CommonSearchTextPage : UserControl
    {
        public string chosenPage;
        public CommonSearchTextPage()
        {
            InitializeComponent();
            //hostTheMainPage();
            //hostTheSearchPage();
            
        }

        private void hostPanel_Paint(object sender, PaintEventArgs e)
        {
            //hostPanel.AddControl(new stefania.MainPage());
            
        }

       

        /*
private void chosePageToHost(string page)
{
   hostPanel.Controls.Clear();
   if(string.Equals(page, "main"))
   {
       hostTheMainPage();
   }
   else if (string.Equals(page, "search"))
   {
       hostTheSearchPage();
   }
}
*/

    }
}
