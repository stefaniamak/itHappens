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
            string categoryColorString = "";
            int theUserId = UIs.anna.LogInPage.userId;

            // Grapse ton kwdika sou edw gia thn emfanish stoixeiwn

            // to query gia na vreis auta pou thes:
            // "SELECT users.id, users.name, surname FROM users WHERE users.id = '" + theUserId + "'""
            // den xreiazetai na allakseis kati se auto to query, par to opws einai.

            // Xrisimopoihse ton allon constuctor (tis emfaniseis apo to query apo panw tis evala me thn seira pou ths zhtaei o constructor), kai dwse null stis eikones:
                // UserProfilePage(int userId, string userName, string userSurname, Image profilePicture)
            theUserProfilePage = new UIs.andrea.UserProfilePage(); 
       
            
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

            // ----------- Gia na gemiseis to profil tou EVENT --------

            

/*
            var eventview = (EventMiniView)sender;
            int eventid = eventview.eventId;
            var v = Db_connector.Query(@"SELECT us.id, ev.id, ev.title, ve.name , cat.color, us.name, us.surname, ev.startingDate,
            ev.ticketprice, ev.description FROM event ev JOIN venues ve ON ev.venueID = ve.id
                JOIN area ar ON ar.id = ve.areaID JOIN users us ON us.id = ev.ownerID
                JOIN categories cat ON ev.categoryID = cat.id WHERE ev.id = EDW ",
                       new string[,] { { "@eventid", eventid + "" } });
            v.Read();
            theEventProfilePage = new UIs.andrea.EventProfilePage (
                v.GetInt32(0), v.GetInt32(1),
                v.GetString(2), v.GetString(3),
                 v.GetString(4), null, v.GetString(5),
                 v.GetString(6), v.GetDateTime(7),
                 v.GetDouble(8), v.GetString(9));
            

*/        

         
           

        // ----------- Gia na gemiseis to flowLayout me tous filous pou exoun auto to event sta lists tous GOING h INTERESTED --------
            // To query gia na gemiseis to flowLayout me tous filous.  (diavase to NOTES FOR QUERY mia seira pio katw, prin xrhsimopoieiseis to query):
                // SELECT  it_happens.us.name, it_happens.us.surname, evL.title FROM it_happens.following fol JOIN it_happens.users us ON fol.followed_user_id = us.id JOIN it_happens.event_list evL ON fol.followed_user_id = evL.creatorID JOIN it_happens.attendants att ON evL.id = att.eventListID JOIN it_happens.event ev ON att.eventID = ev.id WHERE ev.id = 42 AND fol.following_user_id = 4
            // ****NOTES FOR QUERY:****
            //sto telos sto "WHERE ev.id = 42 AND us.id = 4" vale to event id anti gia 42, kai vale to user id anti gia 4. Des pws to ekana  sto panw query pou s egrapsa
            // svise ola ta "it_happens." apo to query
            // To query s epistrefei to noma tou filou, to epitheto tou filou kai ton titlo ths listas tou filou pou to event auto uparxei

            // Kalese to katw gia na emfaniseis tous filous pou exoun stis listes GOING h INTERESTED tous to event, steile NULL gia thn eikona
            //UIs.andrea.EventProfilePage.Instance.friendsWhoWillAttend(friendProfilePicture, friendName, friendSurname, listTitle);
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

            // ----------- Gia na gemiseis to profil tou VENUE --------
            // to query:
            // SELECT ve.id, ve.name, ar.country FROM it_happens.venues ve JOIN it_happens.area ar ON ve.areaID = ar.id WHERE ve.id = 106
            // GUERY NOTES
            // svise ola ta "it_happens."
            // allakse to WHERE ve.id = 106 kai vale anti gia 106, to eventId pou hsoun, prin pathseis na anoiksei to venue profile

            theSVenueProfilePage = new UIs.andrea.VenueProfilePage(); // xrhsimopoieise ton allon constructor. Vale null stis eikones

            // ----------- Gia na gemiseis to FRIENDS WHO HAVE VISITED ----------- 
            // to query s:
            // SELECT DISTINCT it_happens.us.name, it_happens.us.surname, evL.title FROM it_happens.following fol JOIN it_happens.users us ON fol.followed_user_id = us.id JOIN it_happens.event_list evL ON fol.followed_user_id = evL.creatorID JOIN it_happens.attendants att ON evL.id = att.eventListID JOIN it_happens.event ev ON att.eventID = ev.id WHERE evL.title='HISTORY' AND fol.following_user_id = 4
            // QUERY NOTES
            // diegrapse ola ta "it_happens." 
            // allakse ta: 
            // fol.following_user_id = 4 => anti gia 4 tha valeis to onoma tou user pou einai sundedemenos
            // ve.id = 107               => anti gia 107, tha valeis to venue ID tou venue pou pathses

            //UIs.andrea.VenueProfilePage.Instance.friendsWhoHaveVisited(string friendName, string friendSurname); // svise apla ta "strings" kai dwse tis times apoto query pou s egrapsa

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
