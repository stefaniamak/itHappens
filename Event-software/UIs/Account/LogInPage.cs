using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.anna
{
    public partial class LogInPage : UserControl
    {
        public static bool loggedInUser;
        public static int ageOfUser;
        public static int userId = -1;

        public LogInPage()
        {
            InitializeComponent();
        }
        
        public static String userName;

        private void LoginButton_Click(object sender, EventArgs e)
        {
          
            bool flag = false;
            bool validation = Controllers.LoginController.Instance.FieldsValidation(UsernameTextBox.Text, PasswordTextBox.Text, flag);

            if (validation == true)
            {
                userName = Controllers.LoginController.Instance.DatabaseFieldValidation(UsernameTextBox.Text, PasswordTextBox.Text);
                if (!userName.Equals(""))
                {
                    loginActions();
                }
                else
                {
                    MessageBox.Show("There is an error! \nThe data you gave do not exist in the database!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void loginActions()
        {
            ageOfUser = Classes.DatabaseGeneralMethods.ReturnAgeOfUser(UsernameTextBox.Text, PasswordTextBox.Text);
            loggedInUser = true;
            
            Controllers.UIController.Instance.openHostForMainAndSearchPage();
            Controllers.UIController.Instance.openCommonSearchTextPage("main");
            Controllers.UIController.Instance.showSidebars(UsernameTextBox.Text);
            Controllers.UIController.Instance.MainSplitForm.logInSignOutButtonsVisibility();
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                LoginButton_Click(sender, e);
            }
        }

        private void createAccountLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controllers.UIController.Instance.signUpToolStripMenuItem_MiddlePanel();
        }
    }
}
