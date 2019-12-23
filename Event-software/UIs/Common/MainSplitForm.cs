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
        Panel middlePanel;
        Panel rightpanel;

        public MainSplitForm()
        {
            InitializeComponent();
            leftPanel = leftSplitContainer.Panel1;
            middlePanel = rightSplitContainer.Panel1;
            rightpanel = rightSplitContainer.Panel2;
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

        public void addPageToMiddlePanel()
        {
            
        }

        private void TestSplitForm_Load(object sender, EventArgs e)
        {
            
            //var searchForm = new SearchFormTest();
            //middlePanel.Controls.Add(searchForm);
            //searchForm.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            //searchForm.Dock = DockStyle.Fill;
            

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
            var middlePage = new valentina.MadeForYouPage();
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
            middlePanel.Controls.Clear();
            var middlePage = new stefania.MainPage();
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }

        private void searchPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            middlePanel.Controls.Clear();
            var middlePage = new SearchPage();
            middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;
        }
    }
}
