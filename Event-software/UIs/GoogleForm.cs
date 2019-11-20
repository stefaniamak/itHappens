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
using Owin;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;
using FluentNHibernate.Mapping;
using Nancy.Json;

namespace itHappens
{
    public partial class GoogleForm : Form
    {
        public GoogleForm()
        {
            InitializeComponent();
        }


        public void GoogleSignIn()
        {
            
            GoogleWebBrowser.Navigate("https://www.google.gr");
           
        }

        



        private void GoogleForm_Load(object sender, EventArgs e)
        {
            GoogleSignIn();
        }

    

    }
}








