using itHappens.UIs.Sidebars;

namespace itHappens.Classes
{
    class SidebarsMethods
    {

        // Use the Singleton pattern
        private static SidebarsMethods _instance = new SidebarsMethods();
        public static SidebarsMethods Instance => _instance;

        public ProfileSidebar TheProfileSidebar { get => theProfileSidebar; set => theProfileSidebar = value; }

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
            addProfile();
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
           Controllers.UIController.Instance.MainSplitForm.rightBottomPanel.Controls.Clear();
           Controllers.UIController.Instance.MainSplitForm.leftTopPanel.Controls.Clear();
           Controllers.UIController.Instance.MainSplitForm.leftMiddlePanel.Controls.Clear();
           Controllers.UIController.Instance.MainSplitForm.rightTopPanel.Controls.Clear();
        }

        public void addFriendList()
        {
            theUptheFriendListSidebar = new UIs.Sidebars.FriendListSidebar();
           Controllers.UIController.Instance.MainSplitForm.rightBottomPanel.Controls.Add(theUptheFriendListSidebar);
            Controllers.UIController.Instance.designEditOfPanels(theUptheFriendListSidebar);
        }

        public void addUpcomingEvents()
        {
            theUpcomingEvetsSidebar = new UIs.Sidebars.UpcomingEventsSidebar();
           Controllers.UIController.Instance.MainSplitForm.leftTopPanel.Controls.Add(theUpcomingEvetsSidebar);
            Controllers.UIController.Instance.designEditOfPanels(theUpcomingEvetsSidebar);
        }

        public void addLists()
        {
            theListsSidebar = new UIs.Sidebars.ListsSidebar();
           Controllers.UIController.Instance.MainSplitForm.leftMiddlePanel.Controls.Add(theListsSidebar);
            Controllers.UIController.Instance.designEditOfPanels(theListsSidebar);
        }

        public void addProfile()
        {
            TheProfileSidebar = new UIs.Sidebars.ProfileSidebar();
           Controllers.UIController.Instance.MainSplitForm.rightTopPanel.Controls.Add(TheProfileSidebar);
            Controllers.UIController.Instance.designEditOfPanels(TheProfileSidebar);
        }

        public void addWarningToLogIn()
        {
            thisLoginWarningPage = new UIs.Main.LoginWarning();
           Controllers.UIController.Instance.MainSplitForm.leftTopPanel.Controls.Add(thisLoginWarningPage);
            Controllers.UIController.Instance.designEditOfPanels(thisLoginWarningPage);

            thisLoginWarningPage = new UIs.Main.LoginWarning();
           Controllers.UIController.Instance.MainSplitForm.leftMiddlePanel.Controls.Add(thisLoginWarningPage);
            Controllers.UIController.Instance.designEditOfPanels(thisLoginWarningPage);

            thisLoginWarningPage = new UIs.Main.LoginWarning();
           Controllers.UIController.Instance.MainSplitForm.rightBottomPanel.Controls.Add(thisLoginWarningPage);
            Controllers.UIController.Instance.designEditOfPanels(thisLoginWarningPage);

        }
    }
}
