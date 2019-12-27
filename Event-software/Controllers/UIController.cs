using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
