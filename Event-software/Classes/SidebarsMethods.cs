namespace itHappens.Classes
{
    class SidebarsMethods
    {

        // Use the Singleton pattern
        private static SidebarsMethods _instance = new SidebarsMethods();
        public static SidebarsMethods Instance => _instance;
        // Profiles User Controls
        private UIs.Sidebars.UpcomingEventsSidebar theUpcomingEvetsSidebar = null;
        private UIs.Sidebars.ListsSidebar theListsSidebar = null;
        private UIs.Sidebars.ProfileSidebar theProfileSidebar = null;
        private UIs.Sidebars.FriendListSidebar theUptheFriendListSidebar = null;
        // Extra User Controls
        private UIs.Main.LoginWarning thisLoginWarningPage = null;


        public void showLogedOutSidebars()
        {
            clearSidebars();
            Classes.SidebarsMethods.Instance.addProfile();
            Classes.SidebarsMethods.Instance.addWarningToLogIn();
        }

        public void showLogedInSidebars()
        {
            clearSidebars();
            Classes.SidebarsMethods.Instance.addUpcomingEvents();
            Classes.SidebarsMethods.Instance.addLists();
            Classes.SidebarsMethods.Instance.addProfile();
            Classes.SidebarsMethods.Instance.addFriendList();
        }

        public void clearSidebars()
        {
            UIs.Common.MainSplitForm.rightBottomPanel.Controls.Clear();
            UIs.Common.MainSplitForm.leftTopPanel.Controls.Clear();
            UIs.Common.MainSplitForm.leftMiddlePanel.Controls.Clear();
            UIs.Common.MainSplitForm.rightTopPanel.Controls.Clear();
        }

        public void addFriendList()
        {
            theUptheFriendListSidebar = new UIs.Sidebars.FriendListSidebar();
            UIs.Common.MainSplitForm.rightBottomPanel.Controls.Add(theUptheFriendListSidebar);
            Controllers.UIController.Instance.designEditOfPanels(theUptheFriendListSidebar);
        }

        public void addUpcomingEvents()
        {
            theUpcomingEvetsSidebar = new UIs.Sidebars.UpcomingEventsSidebar();
            UIs.Common.MainSplitForm.leftTopPanel.Controls.Add(theUpcomingEvetsSidebar);
            Controllers.UIController.Instance.designEditOfPanels(theUpcomingEvetsSidebar);
        }

        public void addLists()
        {
            theListsSidebar = new UIs.Sidebars.ListsSidebar();
            UIs.Common.MainSplitForm.leftMiddlePanel.Controls.Add(theListsSidebar);
            Controllers.UIController.Instance.designEditOfPanels(theListsSidebar);
        }

        public void addProfile()
        {
            theProfileSidebar = new UIs.Sidebars.ProfileSidebar();
            UIs.Common.MainSplitForm.rightTopPanel.Controls.Add(theProfileSidebar);
            Controllers.UIController.Instance.designEditOfPanels(theProfileSidebar);
        }

        public void addWarningToLogIn()
        {
            thisLoginWarningPage = new UIs.Main.LoginWarning();
            UIs.Common.MainSplitForm.leftTopPanel.Controls.Add(thisLoginWarningPage);
            Controllers.UIController.Instance.designEditOfPanels(thisLoginWarningPage);

            thisLoginWarningPage = new UIs.Main.LoginWarning();
            UIs.Common.MainSplitForm.leftMiddlePanel.Controls.Add(thisLoginWarningPage);
            Controllers.UIController.Instance.designEditOfPanels(thisLoginWarningPage);

            thisLoginWarningPage = new UIs.Main.LoginWarning();
            UIs.Common.MainSplitForm.rightBottomPanel.Controls.Add(thisLoginWarningPage);
            Controllers.UIController.Instance.designEditOfPanels(thisLoginWarningPage);

        }
    }
}
