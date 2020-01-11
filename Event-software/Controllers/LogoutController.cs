using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itHappens.Controllers
{
    class LogoutController
    {
        private static LogoutController _instance = new LogoutController();
        public static LogoutController Instance => _instance;

        public void logoutActions()
        {
            UIs.anna.LogInPage.loggedInUser = false;
            Controllers.UIController.Instance.openHostForMainAndSearchPage();
            Controllers.UIController.Instance.openCommonSearchTextPage("main");
            Controllers.UIController.Instance.showSidebars("Username");
            UIs.anna.LogInPage.userId = -1;
        }
    }
}
