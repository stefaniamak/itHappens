
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;


using System.Windows.Forms;
using itHappens.Classes;

using itHappens.UIs.Common;

namespace itHappens.Controllers
{
    class UIController
    {

        private MainSplitForm mainSplitForm = null;
        public MainSplitForm MainSplitForm
        {
            get
            {
                // Lazy initialization
                if (mainSplitForm == null)
                    mainSplitForm = new MainSplitForm();
                return mainSplitForm;
            }

        }

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

        public void showSidebars(string username)
        {

            if (UIs.anna.LogInPage.loggedInUser == true)
            {
                Classes.SidebarsMethods.Instance.showLogedInSidebars();
                Classes.SidebarsMethods.Instance.TheProfileSidebar.userLogedIn(username);
            }
            else
            {
                Classes.SidebarsMethods.Instance.showLogedOutSidebars();
                Classes.SidebarsMethods.Instance.TheProfileSidebar.userLogOut();
            }

        }

        public void openHostForMainAndSearchPage()
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();
            theHostPage = new UIs.Main.CommonSearchTextPage();
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theHostPage);
            designEditOfPanels(theHostPage);

        }


        public void hostTheMainPage()
        {
            if (theHostPage != null)
            {
                theMainPage = new UIs.Main.MainPage();
                theHostPage.hostPanel.Controls.Add(theMainPage);
                designEditOfPanels(theMainPage);
            }
        }
        public void hostTheSearchPage()
        {
            if (theHostPage != null)
            {
                theSearchPage = new UIs.Common.SearchPage();
                theHostPage.hostPanel.Controls.Add(theSearchPage);
                designEditOfPanels(theSearchPage);
            }
        }


        public void MainPageTodayEventsAndMadeForYouCarousel_Load()
        {
            todayEventsCarousel ob = new todayEventsCarousel();
            for (int i = 0; i < ob.TodaysEvents.Count; i++)
            {
                UIs.Main.MainPage.todayEventsCarousel.AddControl(ob.TodaysEvents[i]);
            }
            madeForYouCarousel obj = new madeForYouCarousel(false);
            for (int i = 0; i < obj.GroupBox.Count; i++)
            {
                UIs.Main.MainPage.madeForYouCarusel.AddControl(obj.GroupBox[i]);
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

        public static ArrayList eventIDList = new ArrayList();
        public static ArrayList eventCategoryIDList = new ArrayList();
        public void MyEventsListsContentPageLoad(int userId, UIs.valentina.ListsContentPage theListContentPage)
        {
            int EventNum = Classes.DatabaseGeneralMethods.ReturnNumberOfUserEvents(userId);


            Classes.DatabaseGeneralMethods.GetUserEventCategoryIds(userId);
            Classes.DatabaseGeneralMethods.GetUserEventIds(userId);

            for (int i = 0; i < EventNum; i++)
            {
                var eventImagePath = Classes.DatabaseGeneralMethods.returnImageOfEvent(Convert.ToInt32(eventIDList[i]));
                var eventImage = eventImagePath == "" ? null : Classes.Utility.DownloadImage(eventImagePath);
                var eventTitle = Classes.DatabaseGeneralMethods.returnTitleOfEvent(Convert.ToInt32(eventIDList[i]));
                var catColor = Classes.DatabaseGeneralMethods.GetCategoryColorOfEvent(Convert.ToInt32(eventCategoryIDList[i]));
                var eventminiview = new UIs.Common.EventMiniView(catColor, Convert.ToInt32(eventIDList[i]), eventTitle, eventImage);
                //  eventminiview.Scale(0.55F);
                theListContentPage.EventHolderFlowLayoutPanel.Controls.Add(eventminiview);
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


        public void venueProfileToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.venueProfileToolStripMenuItem();
        }

        public void mainToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.mainToolStripMenuItem();
        }

        public void searchToolStripMenuItem_MiddlePanel()
        {
            //Classes.MiddlePanelMethods.Instance.searchToolStripMenuItem();
        }

        public void eventsProfileToolStripMenuItem_MiddlePanel(int eventId)
        {
            Classes.MiddlePanelMethods.Instance.eventsProfileToolStripMenuItem(eventId);
        }

        public void eventsProfileToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.eventsProfileToolStripMenuItem();
        }

        public void logInToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.logInToolStripMenuItem();
        }

        public void ContactToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.ContactToolStripMenuItem();
        }

        public void signUpToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.signUpToolStripMenuItem();
        }

        public void createEventToolStripMenuItem_MiddlePanel()
        {
            Classes.MiddlePanelMethods.Instance.createEventToolStripMenuItem("create",0);
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
