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
            Controllers.UIController.addSidebarUpcomingEvents();
            Controllers.UIController.addSidebarLists();
            Controllers.UIController.addSidebarProfile();
            Controllers.UIController.addSidebarFriendList();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.mainToolStripMenuItem_MiddlePanel();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.searchToolStripMenuItem_MiddlePanel();
        }

        private void eventsProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.eventsProfileToolStripMenuItem_MiddlePanel();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.logInToolStripMenuItem_MiddlePanel();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.signUpToolStripMenuItem_MiddlePanel();
        }

        private void createEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.createEventToolStripMenuItem_MiddlePanel();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.listToolStripMenuItem_MiddlePanel();
        }

        private void madeForYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.madeForYouToolStripMenuItem_MiddlePanel();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.settingsToolStripMenuItem_MiddlePanel();           
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.openHostForMainAndSearchPage();
            Controllers.UIController.openPage("main");
        }

        private void searchPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.openHostForMainAndSearchPage();
            Controllers.UIController.openPage("search");
        }

        private void CreateEvent_Click(object sender, EventArgs e)
        {
            if(UIs.anna.LogInPage.loggedInUser == true)
            {
                Controllers.UIController.createEventToolStripMenuItem_MiddlePanel();
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
            Controllers.UIController.openHostForMainAndSearchPage();
            Controllers.UIController.openPage("main");
        }

        private void searchPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.openHostForMainAndSearchPage();
            Controllers.UIController.openPage("search");
        }

        private void usersProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.mainToolStripMenuItem_MiddlePanel();
        }

        private void venuesProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.searchToolStripMenuItem_MiddlePanel();
        }

        private void eventsProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.eventsProfileToolStripMenuItem_MiddlePanel();
        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.logInToolStripMenuItem_MiddlePanel();
        }

        private void signUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.signUpToolStripMenuItem_MiddlePanel();
        }

        private void createEventToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.createEventToolStripMenuItem_MiddlePanel();
        }

        private void listsPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.listToolStripMenuItem_MiddlePanel();
        }

        private void listsContentPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controllers.UIController.madeForYouToolStripMenuItem_MiddlePanel();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.settingsToolStripMenuItem_MiddlePanel();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.openHostForMainAndSearchPage();
            Controllers.UIController.openPage("main");
        }

        private void homePagePictureBox_Click(object sender, EventArgs e)
        {
            Controllers.UIController.openHostForMainAndSearchPage();
            Controllers.UIController.openPage("main");
        }
    }
}
