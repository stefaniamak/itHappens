using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Common
{

    

    public partial class MainSplitForm : Form
    {

        Panel leftPanel;
        public static Panel middlePanel;
        Panel rightpanel;
        Panel leftTopPanel;
        Panel leftMiddlePanel;
        Panel rightTopPanel;
        Panel rightBottomPanel;

        public MainSplitForm()
        {
            InitializeComponent();
            leftPanel = leftSplitContainer.Panel1;
            middlePanel = rightSplitContainer.Panel1;
            rightpanel = rightSplitContainer.Panel2;
            leftTopPanel = splitContainer3.Panel1;
            leftMiddlePanel = splitContainer3.Panel2;
            rightTopPanel = splitContainer1.Panel1;
            rightBottomPanel = splitContainer1.Panel2;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        /*
        public void openClickedPage(string page)
        {
            var middlePage = new stefania.MainPage();

            if (string.Compare(page,"searchPage")==0)
            {
                var middlePage2 = new SearchFormTest();
            } else
            {

            }
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }
        */


        public void addSidebarUpcomingEvents()
        {
            var upcomingEventsSidebar = new Sidebars.UpcomingEventsSidebar();
            leftTopPanel.Controls.Add(upcomingEventsSidebar);
            upcomingEventsSidebar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            upcomingEventsSidebar.Dock = DockStyle.Fill;
        }

        public void addSidebarLists()
        {
            var listsSidebar = new Sidebars.ListsSidebar();
            leftMiddlePanel.Controls.Add(listsSidebar);
            listsSidebar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            listsSidebar.Dock = DockStyle.Fill;
        }

        public void addSidebarProfile()
        {
            var Profileidebar = new Sidebars.ProfileSidebar();
            rightTopPanel.Controls.Add(Profileidebar);
            Profileidebar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            Profileidebar.Dock = DockStyle.Fill;
        }

        public void addSidebarFriendList()
        {
            var FriendListSidebar = new Sidebars.FriendListSidebar();
            rightBottomPanel.Controls.Add(FriendListSidebar);
            FriendListSidebar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            FriendListSidebar.Dock = DockStyle.Fill;
        }

        private void TestSplitForm_Load(object sender, EventArgs e)
        {
            addSidebarUpcomingEvents();
            addSidebarLists();
            addSidebarProfile();
            addSidebarFriendList();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mainInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            middlePanel.Controls.Clear();
            var middlePage = new andrea.UserProfilePage();
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            middlePanel.Controls.Clear();
            var middlePage = new andrea.VenueProfilePage();
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        private void eventsProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            middlePanel.Controls.Clear();
            var middlePage = new andrea.EventProfilePage();
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            middlePanel.Controls.Clear();
            var middlePage = new anna.LogInPage();
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            middlePanel.Controls.Clear();
            var middlePage = new anna.SignUpPage();
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        private void createEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            middlePanel.Controls.Clear();
            var middlePage = new anna.CreateEventPage();
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            middlePanel.Controls.Clear();
            var middlePage = new valentina.ListPage();
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        private void madeForYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            middlePanel.Controls.Clear();
            var middlePage = new valentina.ListsContentPage();
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            middlePanel.Controls.Clear();
            var middlePage = new valentina.SettingsPage();
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
            
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.openHostForMainAndSearchPage();
            Controllers.UIController.openPage("main");
            //stefania.CommonSearchTextPage.

        }

        private void searchPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.openHostForMainAndSearchPage();
            Controllers.UIController.openPage("search");
        }

       

        private void CreateEvent_Click(object sender, EventArgs e)
        {

        }
        
    }
}
