
﻿using System;
using System.Collections;
using System.Windows.Forms;


﻿using System.Windows.Forms;
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
            if (theHostPage != null)
            {
                Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theHostPage);
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

        public static ArrayList eventIDList = new ArrayList();
        public static ArrayList eventCategoryIDList = new ArrayList();
        public void MyEventsListsContentPageLoad(int userId)
        {
            int EventNum = Classes.DatabaseGeneralMethods.ReturnNumberOfUserEvents(userId);
            string catColor;
            string eventTitles;
            Classes.DatabaseGeneralMethods.GetUserEventCategoryIds(userId);
            Classes.DatabaseGeneralMethods.GetUserEventIds(userId);

            for (int i = 0; i < EventNum; i++)
            {
                eventTitles = Classes.DatabaseGeneralMethods.returnTitleOfEvent(Convert.ToInt32(eventIDList[i]));
                catColor = Classes.DatabaseGeneralMethods.GetCategoryColorOfEvent(Convert.ToInt32(eventCategoryIDList[i]));
                var eventminiview = new UIs.Common.EventMiniView(catColor,Convert.ToInt32(eventIDList[i]), eventTitles);
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
