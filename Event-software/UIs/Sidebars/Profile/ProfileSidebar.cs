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
            
            usernameLable.Text = "Username";
            LogoutButton.Visible = false;
            Controllers.LogoutController.Instance.logoutActions();
        }

        private void userLogedIn(string username)
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
    }
}
