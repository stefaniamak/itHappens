using System.Windows.Forms;

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
            int theEventId = -1;

            // Grapse ton kwdika sou edw gia thn emfanish stoixeiwn

            // to query gia na vreis auta pou thes:
                // "SELECT us.id, ev.id, us.username, us.surname, ev.title, ar.country, cat.color FROM users us JOIN  event_list evL ON us.id = evL.creatorID JOIN attendants att ON evL.id = att.eventListID JOIN event ev ON att.eventID = ev.id JOIN categories cat ON ev.categoryID = cat.id JOIN venues v ON v.id = ev.venueID JOIN area ar ON v.areaID = ar.id WHERE evL.title = 'GOING' AND us.id = '" + theUserId + "'"

            // Auth h methodos tha periexei ta events pou o xrisths tha paei, dwse ws parametro to xrwma kathgorias tou event kai to id, apo to panw query pou s egrapsa.
            UIs.andrea.UserProfilePage.Instance.miniCaruselFillWithEventMiniView(categoryColorString, theEventId);

            // Xrisimopoihse ton allon constuctor (tis emfaniseis apo to query apo panw tis evala me thn seira pou ths zhtaei o constructor), kai dwse null stis eikones:
                // UserProfilePage(int userId, int eventId, string userName, string userSurname, string venueName, string categoryColor, Image profilePicture, Image eventBackground, DateTime eventDateTime, string evLocation)
            theUserProfilePage = new UIs.andrea.UserProfilePage(); 
            
        }

// ------------------------ EVENT PROFILE ------------------------ 
        public void eventsProfileToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();

            if (UIs.anna.LogInPage.loggedInUser == true)
            {
                addEventDetailsInEventProfile();
            }
            else
            {
                theEventProfilePage = new UIs.andrea.EventProfilePage();
            }

            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theEventProfilePage);
            designEditOfPanels(theEventProfilePage);
        }

        public void addEventDetailsInEventProfile()
        {

// ----------- Gia na gemiseis to profil tou EVENT --------
            
            // Vale edw ton kwdika s

            // to query:
            // SELECT us.id, ev.id, ev.title, ve.name , cat.color, us.name, us.surname, ev.startingDate, ev.ticketprice, ev.description FROM it_happens.event ev JOIN it_happens.venues ve ON ev.venueID = ve.id JOIN it_happens.area ar ON ar.id = ve.areaID JOIN it_happens.users us ON us.id = ev.ownerID JOIN it_happens.categories cat ON ev.categoryID = cat.id WHERE ev.id = 42
            // GUERY NOTES
                // svise ola ta "it_happens."
             // allakse to WHERE ev.id = 42 kai vale anti gia 42 -> to it tou event pou epilextike

             theEventProfilePage = new UIs.andrea.EventProfilePage(); // Xrisimopoihse ton allon constuctor, kai dwse null stis eikones. Sou exw valei ta Select me thn idia seira pou ta zhtaei o constructor

// ----------------------------------------------------------------------------------------------------------------------------

           

// ----------- Gia na gemiseis to flowLayout me tous filous pou exoun auto to event sta lists tous GOING h INTERESTED --------
            // To query gia na gemiseis to flowLayout me tous filous.  (diavase to NOTES FOR QUERY mia seira pio katw, prin xrhsimopoieiseis to query):
                // SELECT  it_happens.us.name, it_happens.us.surname, evL.title FROM it_happens.following fol JOIN it_happens.users us ON fol.followed_user_id = us.id JOIN it_happens.event_list evL ON fol.followed_user_id = evL.creatorID JOIN it_happens.attendants att ON evL.id = att.eventListID JOIN it_happens.event ev ON att.eventID = ev.id WHERE ev.id = 42 AND fol.following_user_id = 4
            // ****NOTES FOR QUERY:****
            //sto telos sto "WHERE ev.id = 42 AND us.id = 4" vale to event id anti gia 42, kai vale to user id anti gia 4. Des pws to ekana  sto panw query pou s egrapsa
            // svise ola ta "it_happens." apo to query
            // To query s epistrefei to noma tou filou, to epitheto tou filou kai ton titlo ths listas tou filou pou to event auto uparxei

            // Kalese to katw gia na emfaniseis tous filous pou exoun stis listes GOING h INTERESTED tous to event, steile NULL gia thn eikona
            //UIs.andrea.EventProfilePage.Instance.friendsWhoWillAttend(friendProfilePicture, friendName, friendSurname, listTitle);
// ----------------------------------------------------------------------------------------------------------------------------

        }

// ------------------------ SEARCH PAGE ------------------------ 
        public void searchToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            
            if (UIs.anna.LogInPage.loggedInUser == true)
            {
                addEventDetailsInEventProfile();
            }
            else
            {
                theUserProfilePage = new UIs.andrea.UserProfilePage();
            }

            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theSVenueProfilePage);
            designEditOfPanels(theSVenueProfilePage);
        }

        

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

        public void createEventToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theCreateEventPage = new UIs.anna.CreateEventPage();
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
