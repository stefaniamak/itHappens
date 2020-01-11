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
    public partial class InputOldPassForm : Form
    {

        public static bool oldPass;
        public InputOldPassForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!OldPassTextBox.Text.Equals(""))
            {
                String oldpasswrd = Classes.DatabaseGeneralMethods.ReturnUsersPassword(Classes.SidebarsMethods.Instance.TheProfileSidebar.usernameLable.Text);

                if (!OldPassTextBox.Text.Equals(oldpasswrd))
                {
                    WarningLabel.Text = "It does not match with your old password.";
                    OldPassTextBox.Text = "";
                }
                else
                {

                    oldPass = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                WarningLabel.Text = "No value! Type your old password.";

            }

        }

        private void InputOldPassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                UIs.valentina.SettingsPage.flagOldPass = false;
            }
            else if (this.DialogResult == DialogResult.OK)
            {
                UIs.valentina.SettingsPage.flagOldPass = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OldPassTextBox_Enter(object sender, EventArgs e)
        {
            if (!WarningLabel.Text.Equals(""))
            {
                WarningLabel.Text = "";
            }
        }

        private void OldPassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals(Convert.ToChar(13)))
            {
                OkButton_Click(sender, e);
            }
        }
    }
}
