using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens
{
    public partial class LogEvents : Form
    {
        public LogEvents()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }       

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            itHappens.Controllers.LoginController.FieldsValidation(UsernameTextBox.Text,PasswordTextBox.Text);
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
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
