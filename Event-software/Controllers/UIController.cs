using System.Windows.Forms;


namespace itHappens.Controllers
{
    class UIController
    {
        // Main User Controls
        private UIs.Main.CommonSearchTextPage theHostPage = null;
        private UIs.Main.MainPage theMainPage = null;
        private UIs.Common.SearchPage theSearchPage = null;



        // Use the Singleton pattern
        private static UIController _instance = new UIController();
        public static UIController Instance => _instance;

        private UIController()
        {
        }

        public void designEditOfPanels(UserControl theUserControl)
        {
            theUserControl.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            theUserControl.Dock = DockStyle.Fill;
        }

        public void openCommonSearchTextPage(string page)
        {
            Controllers.UIController.Instance.openHostForMainAndSearchPage();
            if (string.Equals(page, "main"))
            {
                hostTheMainPage();
            }
            else if (string.Equals(page, "search"))
            {
                hostTheSearchPage();
            }

        }


        public void openHostForMainAndSearchPage()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theHostPage = new UIs.Main.CommonSearchTextPage();
            if (theHostPage != null)
            {
                UIs.Common.MainSplitForm.middlePanel.Controls.Add(theHostPage);
                designEditOfPanels(theHostPage);
            }

        }
        

        public void hostTheMainPage()
        {
            theMainPage = new UIs.Main.MainPage();
            if (theMainPage != null)
            {
                UIs.Main.CommonSearchTextPage.hostPanel.Controls.Add(theMainPage);
                designEditOfPanels(theMainPage);
            }
        }
        public void hostTheSearchPage()
        {
            theSearchPage = new UIs.Common.SearchPage();
            if (theSearchPage != null)
            {
                UIs.Main.CommonSearchTextPage.hostPanel.Controls.Add(theSearchPage);
                designEditOfPanels(theSearchPage);
            }
        }


        public void MainPageTodayEventsAndMadeForYouCarousel_Load()
        {
            for (int i = 0; i < 10; i++)
            {
                UIs.Main.MainPage.todayEventsCarousel.AddControl(new UIs.Common.EventMiniView());
            }

            for (int i = 0; i < 5; i++)
            {
                UIs.Main.MainPage.madeForYouCarusel.AddControl(new UIs.Common.CategoryGroupBox());
            }
        }


        public void SearchPageFlowLayoutPanels_Load()
        {
            theSearchPage.fillAllCategories();
        }

        public void AllCategoriesFlowPanel_Load()
        {
        }

        public void friendsAttendingPanel_Load()
        {

        }

        public void ListPageLoad()
        {
            for (int i = 0; i < 20; i++)
            {
                var listminibox = new UIs.Common.ListMiniBox();
                //  eventminiview.Scale(0.55F);
                UIs.valentina.ListPage.ListsFlowLayoutPanel.Controls.Add(listminibox);
            }
        }

        public void ListsContentPageLoad()
        {
            for (int i = 0; i < 20; i++)
            {
                var eventminiview = new UIs.Common.EventMiniView();
                //  eventminiview.Scale(0.55F);
                UIs.valentina.ListsContentPage.EventHolderFlowLayoutPanel.Controls.Add(eventminiview);
            }
        }

        //    ----------    Sidebar Methods    ----------    
        public void addSidebarFriendList()
        {
            Classes.SidebarsMethods.Instance.addFriendList();
        }

        public void addSidebarUpcomingEvents()
        {
            Classes.SidebarsMethods.Instance.addUpcomingEvents();
        }

        public void addSidebarLists()
        {
            Classes.SidebarsMethods.Instance.addLists();
        }

        public void addSidebarProfile()
        {
            Classes.SidebarsMethods.Instance.addProfile();
        }

        //    ----------    Middle Panel Methods    ----------    
        
        
        
        public void mainToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.mainToolStripMenuItem();
        }

        public void searchToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.searchToolStripMenuItem();
        }

        public void eventsProfileToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.eventsProfileToolStripMenuItem();
        }

        public void logInToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.logInToolStripMenuItem();
        }

        public void signUpToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.signUpToolStripMenuItem();
        }

        public void createEventToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.createEventToolStripMenuItem("create");
        }


        public void listToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.listToolStripMenuItem();
        }

        public void madeForYouToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.madeForYouToolStripMenuItem();
        }

        public void settingsToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.settingsToolStripMenuItem();
        }

    }
}
