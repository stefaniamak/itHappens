using System.Windows.Forms;
using itHappends;

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
        private UIs.valentina.ListsContentPage theListsContentPage = null;
        private UIs.valentina.SettingsPage theSettingsPage = null;
        // Extra User Controls
        private UIs.Main.LoginWarning thisLoginWarningPage = null;

        public void designEditOfPanels(UserControl theUserControl)
        {
            theUserControl.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            theUserControl.Dock = DockStyle.Fill;
        }


// ------------------------ USER PROFILE ------------------------ 
        public void mainToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();

            if (UIs.anna.LogInPage.loggedInUser == true)
            {
                addUsersDetailsInUserProfile();
            }
            else
            {           
                theUserProfilePage = new UIs.andrea.UserProfilePage();               
            }
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theUserProfilePage);
            designEditOfPanels(theUserProfilePage);
        }

        private void addUsersDetailsInUserProfile()
        {
            int theUserId = UIs.anna.LogInPage.userId;


            var z = Db_connector.Query(@"SELECT users.id, users.name, surname FROM users WHERE users.id = @theUserId",
                      new string[,] {  { "@theUserId", theUserId + "" } });
            z.Read();
            theUserProfilePage = new UIs.andrea.UserProfilePage(z.GetInt32(0), z.GetString(1), z.GetString(2), null);

      
        }

// ------------------------ EVENT PROFILE ------------------------ 
        public void eventsProfileToolStripMenuItem(int eventId)
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();

            if (UIs.anna.LogInPage.loggedInUser == true)
            {
                addEventDetailsInEventProfile(eventId);
            }
            else
            {
                theEventProfilePage = new UIs.andrea.EventProfilePage();
            }

            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theEventProfilePage);
            designEditOfPanels(theEventProfilePage);
        }

        public void addEventDetailsInEventProfile(int eventId)
        {
            int theUserId = UIs.anna.LogInPage.userId;
            var v = Db_connector.Query(@"SELECT us.id, ev.id, ev.title, ve.name , cat.color, us.name, us.surname, ev.startingDate,
            ev.ticketprice, ev.description FROM event ev JOIN venues ve ON ev.venueID = ve.id
                JOIN area ar ON ar.id = ve.areaID JOIN users us ON us.id = ev.ownerID
                JOIN categories cat ON ev.categoryID = cat.id WHERE ev.id = @eventId ",
                       new string[,] { { "@eventId", eventId + "" } });
            v.Read();
            theEventProfilePage = new UIs.andrea.EventProfilePage(
                v.GetInt32(0), v.GetInt32(1),
                v.GetString(2), v.GetString(3),
                 v.GetString(4), null, v.GetString(5),
                 v.GetString(6), v.GetDateTime(7),
                 v.GetDouble(8), v.GetString(9));




            var z = Db_connector.Query(@"SELECT  us.name, us.surname, evL.title FROM following fol JOIN users us ON 
            fol.followed_user_id = us.id JOIN event_list evL ON fol.followed_user_id = evL.creatorID JOIN attendants att
            ON evL.id = att.eventListID JOIN event ev ON att.eventID = ev.id WHERE ev.id = @eventId AND fol.following_user_id = @theUserId ",
                       new string[,] { { "@eventId", eventId + "" }, { "@theUserId", theUserId + ""} });
            z.Read();
            theEventProfilePage.friendsWhoWillAttend(null, z.GetString(0), z.GetString(1), z.GetString(2));
           
        }


// ------------------------ VENUE PROFILE ------------------------ 
        public void venueProfileToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear(); 

            if (UIs.anna.LogInPage.loggedInUser == true)
            {
                addVenueDetailsToVenueProfile();
            }
            else
            {
                theSVenueProfilePage = new UIs.andrea.VenueProfilePage();
            }

            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theSVenueProfilePage);
            designEditOfPanels(theSVenueProfilePage);
        }

        public void addVenueDetailsToVenueProfile()
        {

                int venueId = -1;
                int theUserId = UIs.anna.LogInPage.userId;
                var v = Db_connector.Query(@"SELECT ve.id, ve.name, ar.country FROM venues ve JOIN area ar
                                            ON ve.areaID = ar.id WHERE ve.id = venueId ",
                           new string[,] { { "@venueId", venueId + "" } });
                v.Read();
            theSVenueProfilePage = new UIs.andrea.VenueProfilePage(
                v.GetInt32(0), v.GetString(1),null,null);


          
            var z = Db_connector.Query(@"SELECT DISTINCT us.name, us.surname, evL.title FROM following fol 
            JOIN users us ON fol.followed_user_id = us.id JOIN event_list evL ON fol.followed_user_id = evL.creatorID 
            JOIN attendants att ON evL.id = att.eventListID JOIN event ev ON att.eventID = ev.id
            WHERE evL.title='HISTORY' AND fol.following_user_id = @theUserId AND ve.id = @venueId ",
 
                       new string[,] { { "@theUserId", theUserId + "" }, { "@venueId", venueId + "" } });
            z.Read();
            UIs.andrea.VenueProfilePage.Instance.friendsWhoHaveVisited(
                z.GetString(0), z.GetString(1));

           

        }



        /*
        // ------------------------ SEARCH PAGE ------------------------ 
        public void searchToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theUserProfilePage = new UIs.andrea.UserProfilePage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theSVenueProfilePage);
            designEditOfPanels(theSVenueProfilePage);
        }
        */


        public void logInToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theLotInPage = new UIs.anna.LogInPage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theLotInPage);
            designEditOfPanels(theLotInPage);
        }

        public void signUpToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theSignUpPage = new UIs.SignUpUserControl();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theSignUpPage);
            designEditOfPanels(theSignUpPage);
        }

        public void createEventToolStripMenuItem(string value)
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theCreateEventPage = new UIs.anna.CreateEventPage(value);
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theCreateEventPage);
            designEditOfPanels(theCreateEventPage);
        }

        public void listToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theListPage = new UIs.valentina.ListPage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theListPage);
            designEditOfPanels(theListPage);
        }

        public void madeForYouToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theListsContentPage = new UIs.valentina.ListsContentPage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theListsContentPage);
            designEditOfPanels(theListsContentPage);
        }

        public void settingsToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theSettingsPage = new UIs.valentina.SettingsPage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theSettingsPage);
            designEditOfPanels(theSettingsPage);
        }

    }
}
