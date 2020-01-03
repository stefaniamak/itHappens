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
                hostTheMainPage();
            }
            else if (string.Equals(page, "search"))
            {
                hostTheSearchPage();
            }
            
        }


        public static void openHostForMainAndSearchPage()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var hostPage = new UIs.Main.CommonSearchTextPage();

            UIs.Common.MainSplitForm.middlePanel.Controls.Add(hostPage);
            hostPage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            hostPage.Dock = DockStyle.Fill;
        }


        public static void hostTheMainPage()
        {

            var mainPage = new UIs.Main.MainPage();
            UIs.Main.CommonSearchTextPage.hostPanel.Controls.Add(mainPage);
            mainPage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            mainPage.Dock = DockStyle.Fill;
        }
        public static void hostTheSearchPage()
        {
            var searchPage = new UIs.Common.SearchPage();
            UIs.Main.CommonSearchTextPage.hostPanel.Controls.Add(searchPage);
            searchPage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            searchPage.Dock = DockStyle.Fill;
        }


        public static void MainPageTodayEventsAndMadeForYouCarousel_Load()
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


        public static void SearchPageFlowLayoutPanels_Load()
        {

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
        }

        public static void AllCategoriesFlowPanel_Load()
        {
            for (int i = 0; i < 20; i++)
            {
                //UIs.SearchForm.allCategoriesFlowPanel.Controls.Add(new UIs.Common.CategoryMiniBox());
            }
        }

        public static void friendsAttendingPanel_Load()
        {
            for (int i = 0; i < 5; i++)
            {
                //UIs.andrea.EventProfilePage.friendsAttendingPanel.friendsFlowPanel.Controls.Add(new UIs.Common.FriendsAttending());
            }
        }

        public static void ListPageLoad()
        {
            for (int i = 0; i < 20; i++)
            {
                var listminibox = new UIs.Common.ListMiniBox();
                //  eventminiview.Scale(0.55F);
                UIs.valentina.ListPage.ListsFlowLayoutPanel.Controls.Add(listminibox);
            }
        }

        public static void ListsContentPageLoad()
        {
            for (int i = 0; i < 20; i++)
            {
                var eventminiview = new UIs.Common.EventMiniView();
                //  eventminiview.Scale(0.55F);
                UIs.valentina.ListsContentPage.EventHolderFlowLayoutPanel.Controls.Add(eventminiview);
            }
        }

        public static void addSidebarFriendList()
        {
            Classes.SidebarsMethods.addFriendList();
        }

        public static void addSidebarUpcomingEvents()
        {
            Classes.SidebarsMethods.addUpcomingEvents();
        }

        public static void addSidebarLists()
        {
            Classes.SidebarsMethods.addLists();
        }

        public static void addSidebarProfile()
        {
            Classes.SidebarsMethods.addProfile();
        }

        public static void mainToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.mainToolStripMenuItem();
        }

        public static void searchToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.searchToolStripMenuItem();
        }

        public static void eventsProfileToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.eventsProfileToolStripMenuItem();
        }

        public static void logInToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.logInToolStripMenuItem();
        }

        public static void signUpToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.signUpToolStripMenuItem();
        }

        public static void createEventToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.createEventToolStripMenuItem();
        }


        public static void listToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.listToolStripMenuItem();
        }

        public static void madeForYouToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.madeForYouToolStripMenuItem();
        }

        public static void settingsToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.settingsToolStripMenuItem();
        }

    }
}
