using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateLogin
{
    public partial class LogEvents : Form
    {
        public LogEvents()
        {
            InitializeComponent();
        }

             

        private void LoginButton_Click(object sender, EventArgs e)
        {

            itHappens.Controllers.LoginController.FieldsValidation(UsernameTextBox.Text,PasswordTextBox.Text);
            PasswordTextBox.Text = "";
        }

        public void ClearFields()
        {
            
        }

        
        private void GooglePictureBox_Click(object sender, EventArgs e)
        {
            var GForm = new GoogleForm();
            GForm.Show();
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                LoginButton_Click(sender, e);
            }
        }
    }
}
