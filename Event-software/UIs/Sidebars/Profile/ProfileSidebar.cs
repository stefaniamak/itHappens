using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Sidebars
{
    public partial class ProfileSidebar : UserControl
    {
        public ProfileSidebar()
        {
            InitializeComponent();

            shownotificationUserControl();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

            userLogOut();
            Controllers.UIController.Instance.MainSplitForm.SettingsMenuButton.Visible = false;
            Controllers.LogoutController.Instance.logoutActions();
            Controllers.UIController.Instance.MainSplitForm.logInSignOutButtonsVisibility();
        }

        public void userLogOut()
        {
            usernameLable.Text = "Username";
            LogoutButton.Visible = false;
        }

        public void userLogedIn(string username)
        {
            LogoutButton.Visible = true;
            usernameLable.Text = username;
        }

        private void shownotificationUserControl()
        {
            for (int i = 0; i < 5; i++)
            {
                notificationBox.AddControl(new Common.Notification());
            }
        }

        private void bellNotificationPictureBox_Click(object sender, EventArgs e)
        {
            notificationBox.Visible = !notificationBox.Visible;
        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.mainToolStripMenuItem_MiddlePanel();
        }

        private void usernameLable_Click(object sender, EventArgs e)
        {
            Controllers.UIController.Instance.mainToolStripMenuItem_MiddlePanel();
        }
    }
}
