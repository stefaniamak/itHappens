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
        private UIs.anna.ContactForm theContactPage = null;

        public void mainToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theUserProfilePage = new UIs.andrea.UserProfilePage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theUserProfilePage);
            designEditOfPanels(theUserProfilePage);
        }

        public void designEditOfPanels(UserControl theUserControl)
        {
            theUserControl.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            theUserControl.Dock = DockStyle.Fill;
        }

        public void searchToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theSVenueProfilePage = new UIs.andrea.VenueProfilePage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theSVenueProfilePage);
            designEditOfPanels(theSVenueProfilePage);
        }

        public void eventsProfileToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theEventProfilePage = new UIs.andrea.EventProfilePage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theEventProfilePage);
            designEditOfPanels(theEventProfilePage);
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
        public void ContactToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            theContactPage = new UIs.anna.ContactForm();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(theContactPage);
            designEditOfPanels(theContactPage);
        }

    }
}
