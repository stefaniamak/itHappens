using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.Classes
{
    class MiddlePanelMethods
    {

        public static void mainToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var middlePage = new UIs.andrea.UserProfilePage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        public static void searchToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var middlePage = new UIs.andrea.VenueProfilePage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        public static void eventsProfileToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var middlePage = new UIs.andrea.EventProfilePage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        public static void logInToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var middlePage = new UIs.anna.LogInPage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        public static void signUpToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var middlePage = new UIs.anna.SignUpPage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        public static void createEventToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var middlePage = new UIs.anna.CreateEventPage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        public static void listToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var middlePage = new UIs.valentina.ListPage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        public static void madeForYouToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var middlePage = new UIs.valentina.ListsContentPage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        public static void settingsToolStripMenuItem()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var middlePage = new UIs.valentina.SettingsPage();
            UIs.Common.MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

    }
}
