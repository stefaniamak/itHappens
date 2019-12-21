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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            /*
            Mutual.eventSmall testForm = new Mutual.eventSmall();
            testForm.TopLevel = false;
            testForm.TopMost = false;

            MainForm form1 = (MainForm)Application.OpenForms["MainForm"];
            Panel todayPanel = (Panel)form1.Controls["todayPanel"];
            todayPanel.Controls.Clear();
            todayPanel.Controls.Add(value: testForm);
            
            //todayPanel.Controls.Add(value: testForm);
            //todayPanel.Controls.Add(value: testForm);
            testForm.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            //testForm.Size = todayPanel.Size;
            testForm.Width = testForm.Width / 2;
            //testForm.Height = testForm.Height / 2;
            
            testForm.Location = new Point(todayPanel.Left + 4, todayPanel.Top - testForm.Height);


            testForm.Show();
            */

            for (int i = 0; i < 10; i++)
            {
                todayEventsCarousel.AddControl(new Common.EventMiniView());
            }

            for (int i = 0; i < 5; i++)
            {
                madeForYouCarusel.AddControl(new Common.categoryBox());
            }
            /*
            var scroll = todayEventsCarousel.AutoScrollPosition;
            scroll.X = 0;
            todayEventsCarousel.AutoScrollPosition = scroll;
            */



        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {



        }
    }
}
