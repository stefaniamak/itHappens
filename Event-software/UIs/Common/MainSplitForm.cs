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
            leftTopPanel = splitContainer3.Panel1;
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

        }
        
    }
}
