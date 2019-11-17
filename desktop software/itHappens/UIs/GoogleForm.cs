using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Reflection;
using System.IO;

namespace CreateLogin
{
    public partial class GoogleForm : Form
    {
        public GoogleForm()
        {
            InitializeComponent();
        }


        public void GoogleSignIn()
        {
            //Code for Google Sign in Auth
            GoogleWebBrowser.Navigate("https://www.google.com");

           
        }


        private void GoogleForm_Load(object sender, EventArgs e)
        {
            GoogleSignIn();
        }

        
    }
}








