using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Common
{
    public partial class CategoryGroupBox : UserControl
    {
        public CategoryGroupBox()
        {
            InitializeComponent();
        }

        public CategoryGroupBox(string categoryName, Image firstEventImage, Image secondEventImage, string categoryColor) : this()
        {
            Color catColor = Color.FromName(categoryColor);
            categoryNameLabel.Text = categoryName;
            firstEventimagePictureBox.Image = firstEventImage;
            secondEventimagePictureBox.Image = secondEventImage;
            categoryColorControl.BackColor = catColor;
        }

        //  -----------  Προσωρινός Constructor χωρίς τα insert εικόνων.  -----------  
        public CategoryGroupBox(string categoryName, string categoryColor) : this()
        {
            Color catColor = Color.FromName(categoryColor);
            categoryNameLabel.Text = categoryName;
            categoryColorControl.BackColor = catColor;
        }

        private void categoryName_Click(object sender, EventArgs e)
        {

        }
    }
}
