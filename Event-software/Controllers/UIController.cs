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

        private UIs.Common.SearchPage theSearchPage = null;


        // Use the Singleton pattern
        private static UIController _instance = new UIController();
        public static UIController Instance => _instance;

        private UIController()
        {
        }

        public void openPage(string page)
        {
            
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
            var hostPage = new UIs.Main.CommonSearchTextPage();

            UIs.Common.MainSplitForm.middlePanel.Controls.Add(hostPage);
            hostPage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            hostPage.Dock = DockStyle.Fill;
        }


        public void hostTheMainPage()
        {

            var mainPage = new UIs.Main.MainPage();
            UIs.Main.CommonSearchTextPage.hostPanel.Controls.Add(mainPage);
            mainPage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            mainPage.Dock = DockStyle.Fill;
        }
        public void hostTheSearchPage()
        {
            theSearchPage = new UIs.Common.SearchPage();
            UIs.Main.CommonSearchTextPage.hostPanel.Controls.Add(theSearchPage);
            theSearchPage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            theSearchPage.Dock = DockStyle.Fill;
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
            /*
            for (int i = 0; i < 20; i++)
            {
                UIs.Common.SearchPage.flowLayoutPanel1.Controls.Add(new UIs.Common.CategoryMiniBox());
            }
            for (int i = 0; i < 20; i++)
            {
                UIs.Common.SearchPage.flowLayoutPanel2.Controls.Add(new UIs.Common.CategoryMiniBox());
            }

            for (int i = 0; i < 20; i++)
            {
                var eventminiview = new UIs.Common.EventMiniView();
                eventminiview.Scale(0.55F);
                UIs.Common.SearchPage.flowLayoutPanel3.Controls.Add(eventminiview);
            }
            */
        }

        public void AllCategoriesFlowPanel_Load()
        {
            for (int i = 0; i < 20; i++)
            {
                //UIs.SearchForm.allCategoriesFlowPanel.Controls.Add(new UIs.Common.CategoryMiniBox());
            }
        }

        public void friendsAttendingPanel_Load()
        {
            for (int i = 0; i < 5; i++)
            {
                //UIs.andrea.EventProfilePage.friendsAttendingPanel.friendsFlowPanel.Controls.Add(new UIs.Common.FriendsAttending());
            }
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

        public void addSidebarFriendList()
        {
            Classes.SidebarsMethods.addFriendList();
        }

        public void addSidebarUpcomingEvents()
        {
            Classes.SidebarsMethods.addUpcomingEvents();
        }

        public void addSidebarLists()
        {
            Classes.SidebarsMethods.addLists();
        }

        public void addSidebarProfile()
        {
            Classes.SidebarsMethods.addProfile();
        }

        public void mainToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.mainToolStripMenuItem();
        }

        public void searchToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.searchToolStripMenuItem();
        }

        public void eventsProfileToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.eventsProfileToolStripMenuItem();
        }

        public void logInToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.logInToolStripMenuItem();
        }

        public void signUpToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.signUpToolStripMenuItem();
        }

        public void createEventToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.createEventToolStripMenuItem();
        }


        public void listToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.listToolStripMenuItem();
        }

        public void madeForYouToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.madeForYouToolStripMenuItem();
        }

        public void settingsToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.settingsToolStripMenuItem();
        }

    }
}
