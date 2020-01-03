﻿using System;
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
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool flag = false;
            bool validation = Controllers.LoginController.FieldsValidation(UsernameTextBox.Text, PasswordTextBox.Text, flag);

            if (validation == true)
            {
                String userName = Controllers.LoginController.DatabaseFieldValidation(UsernameTextBox.Text, PasswordTextBox.Text);
                if (!userName.Equals(""))
                {
                    //oti theloume na emfanizei meta tin sundesi
                    UIs.Sidebars.ProfileSidebar.usernameLable.Text = Controllers.LoginController.loginNameSurnameToProfile(UsernameTextBox.Text, PasswordTextBox.Text);
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

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                LoginButton_Click(sender, e);
            }
        }

        private void createAccountLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controllers.UIController.signUpToolStripMenuItem_MiddlePanel();
        }
    }
}