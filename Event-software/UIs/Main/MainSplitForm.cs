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
        public static Panel leftTopPanel;
        public static Panel leftMiddlePanel;
        public static Panel rightTopPanel;
        public static Panel rightBottomPanel;

        public MainSplitForm()
        {
            InitializeComponent();
            leftPanel = leftSplitContainer.Panel1;
            middlePanel = rightSplitContainer.Panel1;
            rightpanel = rightSplitContainer.Panel2;
            //leftTopPanel = splitContainer3.Panel1;
            leftTopPanel = upcommingEventsPanel;
            leftMiddlePanel = splitContainer3.Panel2;
            rightTopPanel = splitContainer1.Panel1;
            rightBottomPanel = splitContainer1.Panel2;
        }
      
        private void TestSplitForm_Load(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.addSidebarUpcomingEvents();
            Controllers.UIController.Instance.addSidebarLists();
            Controllers.UIController.Instance.addSidebarProfile();
            Controllers.UIController.Instance.addSidebarFriendList();

            Controllers.UIController.Instance.openHostForMainAndSearchPage();
            Controllers.UIController.Instance.openCommonSearchTextPage("main");
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.mainToolStripMenuItem_MiddlePanel();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.searchToolStripMenuItem_MiddlePanel();
        }

        private void eventsProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.eventsProfileToolStripMenuItem_MiddlePanel();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.logInToolStripMenuItem_MiddlePanel();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.signUpToolStripMenuItem_MiddlePanel();
        }

        private void createEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.createEventToolStripMenuItem_MiddlePanel();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.listToolStripMenuItem_MiddlePanel();
        }

        private void madeForYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.madeForYouToolStripMenuItem_MiddlePanel();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.settingsToolStripMenuItem_MiddlePanel();           
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.openHostForMainAndSearchPage();
            Controllers.UIController.Instance.openCommonSearchTextPage("main");
        }

        private void searchPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.openHostForMainAndSearchPage();
            Controllers.UIController.Instance.openCommonSearchTextPage("search");
        }

        private void CreateEvent_Click(object sender, EventArgs e)
        {
            if(UIs.anna.LogInPage.loggedInUser == true && UIs.anna.LogInPage.ageOfUser >= 18)
            {
                Controllers.UIController.Instance.createEventToolStripMenuItem_MiddlePanel();
            }
            else
            {
                //Ti tha emfanizei an den einai sundedemenos o xrhsths
            }
            
        }

        private void rightSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mainInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.openCommonSearchTextPage("main");
        }

        private void searchPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.openCommonSearchTextPage("search");
        }

        private void usersProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.mainToolStripMenuItem_MiddlePanel();
        }

        private void venuesProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.searchToolStripMenuItem_MiddlePanel();
        }

        private void eventsProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.eventsProfileToolStripMenuItem_MiddlePanel();
        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.logInToolStripMenuItem_MiddlePanel();
        }

        private void signUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.signUpToolStripMenuItem_MiddlePanel();
        }

        private void createEventToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.createEventToolStripMenuItem_MiddlePanel();
        }

        private void listsPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.listToolStripMenuItem_MiddlePanel();
        }

        private void listsContentPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.madeForYouToolStripMenuItem_MiddlePanel();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.settingsToolStripMenuItem_MiddlePanel();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.openHostForMainAndSearchPage();
            Controllers.UIController.Instance.openCommonSearchTextPage("main");
        }

        private void homePagePictureBox_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.openHostForMainAndSearchPage();
            Controllers.UIController.Instance.openCommonSearchTextPage("main");
        }
    }
}
