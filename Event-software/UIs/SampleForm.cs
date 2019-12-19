using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
        }

        public void SampleForm_Load(object sender, EventArgs e)
        {
 
        }

        public void mainPage_Paint(object sender, PaintEventArgs e)
        {

        }

        public void mainPage_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stefaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void showPage(Form testForm)
        {
            

            testForm.TopLevel = false;
            testForm.TopMost = false;

            SampleForm form1 = (SampleForm)Application.OpenForms["SampleForm"];
            Panel middlePanel = (Panel)form1.Controls["middlePanel"];
            middlePanel.Controls.Clear();
            middlePanel.Controls.Add(value: testForm);
            testForm.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            testForm.Size = middlePanel.Size;
            testForm.Show();
        }
        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm Form = new LoginForm(); 
            showPage(Form);
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm Form = new MainForm();
            showPage(Form);
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfileForm Form = new UserProfileForm();
            showPage(Form);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VenueProfileForm Form = new VenueProfileForm();
            showPage(Form);
        }

        private void eventsProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventProfileForm Form = new EventProfileForm();
            showPage(Form);
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpForm Form = new SignUpForm();
            showPage(Form);
        }

        private void createEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEventForm Form = new CreateEventForm();
            showPage(Form);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListsForm Form = new ListsForm();
            showPage(Form);
        }

        private void madeForYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MadeForYouForm Form = new MadeForYouForm();
            showPage(Form);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm Form = new SettingsForm();
            showPage(Form);
        }

        private void searchPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm Form = new SearchForm();
            showPage(Form);
        }
    }
}
