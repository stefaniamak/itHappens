using System;
using System.Drawing;
using System.Windows.Forms;
using itHappends;
using MySql.Data.MySqlClient;

namespace itHappens.Classes
{
    class MiddlePanelMethods
    {
        // Use the Singleton pattern
        private static MiddlePanelMethods _instance = new MiddlePanelMethods();
        public static MiddlePanelMethods Instance => _instance;



        // Account User Controls
        private UIs.anna.CreateEventPage theCreateEventPage = null;
        private UIs.anna.LogInPage theLotInPage = null;
        private UIs.SignUpUserControl theSignUpPage = null;
        // Profiles User Controls
        private UIs.andrea.EventProfilePage theEventProfilePage = null;
        private UIs.andrea.UserProfilePage theUserProfilePage = null;
        private UIs.andrea.VenueProfilePage theSVenueProfilePage = null;
        // Lists and Settings Controls
        private UIs.valentina.ListPage theListPage = null;
        public UIs.valentina.ListsContentPage theListsContentPage = null;
        private UIs.valentina.SettingsPage theSettingsPage = null;
        // Extra User Controls
        private UIs.Main.LoginWarning thisLoginWarningPage = null;
        private UIs.anna.ContactForm theContactPage = null;

        public void designEditOfPanels(UserControl theUserControl)
        {
            theUserControl.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            theUserControl.Dock = DockStyle.Fill;
        }


        // ------------------------ USER PROFILE ------------------------
        public void mainToolStripMenuItem()
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();

            if (UIs.anna.LogInPage.loggedInUser == true)
            {
                addUsersDetailsInUserProfile();
            }
            else
            {
                theUserProfilePage = new UIs.andrea.UserProfilePage();
            }
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theUserProfilePage);
            designEditOfPanels(theUserProfilePage);
        }

        private void addUsersDetailsInUserProfile()
        {
            int theUserId = UIs.anna.LogInPage.userId;


            var z = Db_connector.ExecuteQuery(@"SELECT users.id, users.name, surname FROM users WHERE users.id = @theUserId",
                      new MySqlParameter("@theUserId", theUserId));
            try
            {
                z.Read();
                theUserProfilePage = new UIs.andrea.UserProfilePage(z.GetInt32(0), z.GetString(1), z.GetString(2), null);
            }
            catch
            {
                theUserProfilePage = new UIs.andrea.UserProfilePage(-1, "No", "User", null);
            }

        }

        public void eventsProfileToolStripMenuItem()
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();

            theEventProfilePage = new UIs.andrea.EventProfilePage();


            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theEventProfilePage);
            designEditOfPanels(theEventProfilePage);
        }

        // ------------------------ EVENT PROFILE ------------------------
        public void eventsProfileToolStripMenuItem(int eventId)
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();
            Console.WriteLine("xaxa" + eventId);
            addEventDetailsInEventProfile(eventId);


            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theEventProfilePage);
            designEditOfPanels(theEventProfilePage);
        }

        public void addEventDetailsInEventProfile(int eventId)
        {
            int theUserId = UIs.anna.LogInPage.userId;
            var v = Db_connector.ExecuteQuery(@"SELECT us.id, ev.id, ev.title, ve.name, cat.color, ev.image, us.name, us.surname, ev.startingDate, ev.ticketprice, ev.description " +
                                                "FROM event ev " +
                                                "JOIN venues ve ON ev.venueID = ve.id " +
                                                "JOIN area ar ON ar.id = ve.areaID " +
                                                "JOIN users us ON us.id = ev.ownerID " +
                                                "JOIN categories cat ON ev.categoryID = cat.id " +
                                                "WHERE ev.id = @eventId ",
                                                new MySqlParameter("@eventId", eventId));
            try
            {
                v.Read();

                Image img = v.IsDBNull(5) ? null : Classes.Utility.DownloadImage(v.GetString(5));
                theEventProfilePage = new UIs.andrea.EventProfilePage(
                    v.GetInt32(0), v.GetInt32(1),
                    v.GetString(2), v.GetString(3),
                     v.GetString(4), img, v.GetString(6),
                     v.GetString(7), v.GetDateTime(8),
                     v.GetDouble(9), v.GetString(10));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                theEventProfilePage = new UIs.andrea.EventProfilePage(-1, -1, "NoEventFound", "", "", null, "", "", DateTime.Now, 1.00, "");
            }


            //bool userLoggedIn = false;
            if (UIs.anna.LogInPage.loggedInUser == true)
            {
                var z = Db_connector.ExecuteQuery(@"SELECT  us.name, us.surname, evL.title FROM following fol JOIN users us ON
            fol.followed_user_id = us.id JOIN event_list evL ON fol.followed_user_id = evL.creatorID JOIN attendants att
            ON evL.id = att.eventListID JOIN event ev ON att.eventID = ev.id WHERE ev.id = @eventId AND fol.following_user_id = @theUserId ",
                       new[] { new MySqlParameter("@eventId", eventId), new MySqlParameter("@theUserId", theUserId) });
                try
                {
                    while (z.Read())
                    {
                        theEventProfilePage.friendsWhoWillAttend(null, z.GetString(0), z.GetString(1), z.GetString(2));
                    }
                    //userLoggedIn = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //userLoggedIn = false;
                }

            }

            //if (!userLoggedIn)
            //theEventProfilePage.friendsWhoWillAttend(null, "No", "User", "");
        }


        // ------------------------ VENUE PROFILE ------------------------
        public void venueProfileToolStripMenuItem()
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();

            if (UIs.anna.LogInPage.loggedInUser == true)
            {
                addVenueDetailsToVenueProfile();
            }
            else
            {
                theSVenueProfilePage = new UIs.andrea.VenueProfilePage();
            }

            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theSVenueProfilePage);
            designEditOfPanels(theSVenueProfilePage);
        }

        public void addVenueDetailsToVenueProfile()
        {

            int venueId = -1;
            int theUserId = UIs.anna.LogInPage.userId;
            var v = Db_connector.ExecuteQuery(@"SELECT ve.id, ve.name, ar.country FROM venues ve JOIN area ar
                                            ON ve.areaID = ar.id WHERE ve.id = venueId ",
                       new MySqlParameter("@venueId", venueId));
            try
            {
                v.Read();
                theSVenueProfilePage = new UIs.andrea.VenueProfilePage(v.GetInt32(0), v.GetString(1), null, null);

            }
            catch
            {
                theSVenueProfilePage = new UIs.andrea.VenueProfilePage(-1, "No Venue", null, null);
            }


            var z = Db_connector.ExecuteQuery(@"SELECT DISTINCT us.name, us.surname, evL.title FROM following fol
                                                JOIN users us ON fol.followed_user_id = us.id JOIN event_list evL ON fol.followed_user_id = evL.creatorID
                                                JOIN attendants att ON evL.id = att.eventListID JOIN event ev ON att.eventID = ev.id
                                                WHERE evL.title='HISTORY' AND fol.following_user_id = @theUserId AND ev.id = @venueId ",
                        new[] { new MySqlParameter("@theUserId", theUserId), new MySqlParameter("@venueId", venueId) });
            try
            {
                z.Read();
                UIs.andrea.VenueProfilePage.Instance.friendsWhoHaveVisited(z.GetString(0), z.GetString(1));

            }
            catch
            {
                UIs.andrea.VenueProfilePage.Instance.friendsWhoHaveVisited("No", "User");
            }

        }



        /*
        // ------------------------ SEARCH PAGE ------------------------
        public void searchToolStripMenuItem()
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();
            theUserProfilePage = new UIs.andrea.UserProfilePage();
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theSVenueProfilePage);
            designEditOfPanels(theSVenueProfilePage);
        }
        */


        public void logInToolStripMenuItem()
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();
            theLotInPage = new UIs.anna.LogInPage();
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theLotInPage);
            designEditOfPanels(theLotInPage);
        }

        public void signUpToolStripMenuItem()
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();
            theSignUpPage = new UIs.SignUpUserControl();
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theSignUpPage);
            designEditOfPanels(theSignUpPage);
        }

        public void createEventToolStripMenuItem(string value,int EvId)
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();
            theCreateEventPage = new UIs.anna.CreateEventPage(value,EvId);
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theCreateEventPage);
            designEditOfPanels(theCreateEventPage);
        }

        public void listToolStripMenuItem()
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();
            theListPage = new UIs.valentina.ListPage();
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theListPage);
            designEditOfPanels(theListPage);
        }

        public void madeForYouToolStripMenuItem()
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();
            theListsContentPage = new UIs.valentina.ListsContentPage();
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theListsContentPage);
            designEditOfPanels(theListsContentPage);
        }

        public void settingsToolStripMenuItem()
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();
            theSettingsPage = new UIs.valentina.SettingsPage();
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theSettingsPage);
            designEditOfPanels(theSettingsPage);
        }
        public void ContactToolStripMenuItem()
        {
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Clear();
            theContactPage = new UIs.anna.ContactForm();
            Controllers.UIController.Instance.MainSplitForm.middlePanel.Controls.Add(theContactPage);
            designEditOfPanels(theContactPage);
        }

    }
}
