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
            
            itHappens.Controllers.LoginController.FieldsValidation(UsernameBox.Text,PassBox.Text);
            UsernameBox.Text = "";
            PassBox.Text = "";
        }


        private void UsernameBox_Click(object sender, EventArgs e)
        {
            UsernameBox.Clear();
            picuser.BackgroundImage =  Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(46, 184, 184);
            UsernameBox.ForeColor = Color.FromArgb(46, 184, 184);


            picpass.BackgroundImage = Properties.Resources.pass1;
            panel2.BackColor = Color.WhiteSmoke;
            PassBox.ForeColor = Color.WhiteSmoke;


    
        }


        private void PassBox_Click(object sender, EventArgs e)
        {
            PassBox.Clear();
            PassBox.PasswordChar = '*';
            picpass.BackgroundImage = Properties.Resources.pass2;
            panel2.BackColor = Color.FromArgb(46, 184, 184);
            PassBox.ForeColor = Color.FromArgb(46, 184, 184);


            picuser.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = Color.WhiteSmoke;
            UsernameBox.ForeColor = Color.WhiteSmoke;

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
