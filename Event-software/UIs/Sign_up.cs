using System;
using System.Drawing;
using System.Windows.Forms;

namespace CreateLogin.UIs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void UsernameBox_Click(object sender, EventArgs e)
        {
            UsernameBox.Clear();
            picuser.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(46, 184, 184);
            UsernameBox.ForeColor = Color.FromArgb(46, 184, 184);


            picpass.BackgroundImage = Properties.Resources.pass1;
            panel2.BackColor = Color.WhiteSmoke;
            PassBox.ForeColor = Color.WhiteSmoke;


            picemail.BackgroundImage = Properties.Resources.email1;
            panel3.BackColor = Color.WhiteSmoke;
            EmailBox.ForeColor = Color.WhiteSmoke;
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


            picemail.BackgroundImage = Properties.Resources.email1;
            panel3.BackColor = Color.WhiteSmoke;
            EmailBox.ForeColor = Color.WhiteSmoke;
        }

        private void EmailBox_Click(object sender, EventArgs e)
        {
            EmailBox.Clear();
            picemail.BackgroundImage = Properties.Resources.email2;
            panel3.BackColor = Color.FromArgb(46, 184, 184);
            EmailBox.ForeColor = Color.FromArgb(46, 184, 184);

            picuser.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = Color.WhiteSmoke;
            UsernameBox.ForeColor = Color.WhiteSmoke;

            picpass.BackgroundImage = Properties.Resources.pass1;
            panel2.BackColor = Color.WhiteSmoke;
            PassBox.ForeColor = Color.WhiteSmoke;



        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void picpass_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
