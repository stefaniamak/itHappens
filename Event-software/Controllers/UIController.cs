using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.Controllers
{
    class UIController
    {
        public static void openPage(string page)
        {
            
            if (string.Equals(page, "main"))
            {
                UIs.stefania.CommonSearchTextPage.hostTheMainPage();
            }
            else if (string.Equals(page, "search"))
            {
                UIs.stefania.CommonSearchTextPage.hostTheSearchPage();
            }
            
        }


        public static void openHostForMainAndSearchPage()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var hostPage = new UIs.stefania.CommonSearchTextPage();

            UIs.Common.MainSplitForm.middlePanel.Controls.Add(hostPage);
            hostPage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            hostPage.Dock = DockStyle.Fill;
        }



    }
}
