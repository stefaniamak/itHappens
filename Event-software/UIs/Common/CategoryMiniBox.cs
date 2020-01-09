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
    public partial class CategoryMiniBox : UserControl
    {
        public CategoryMiniBox()
        {
            InitializeComponent();
        }

        public CategoryMiniBox(string categoryName, string color)
        {
            InitializeComponent();
            Color catColor = Color.FromName(color);

            backgroundColorPanel.BackColor = catColor;
            backgroundColorPanel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            categoryLabel.Text = categoryName;
            categoryStrikeoutLabel.Text = categoryName;
            //categoryStrikeoutLabel.ForeColor = catColor;
        }

        private void CategoryMiniBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void categoryLabel_MouseClick(object sender, MouseEventArgs e)
        {
            categoryClicked();
        }

        private void backgroundColorPanel_MouseClick(object sender, MouseEventArgs e)
        {
            categoryClicked();
        }

        private void categoryClicked()
        {
            if (categoryLabel.Visible == false)
            {
                setVisibility(true, false);
                changeBackColor(40);
            } 
            else
            {
                setVisibility(false, true);
                changeBackColor(25);
            }
            
        }

        private void setVisibility(bool normal, bool stickout)
        {
            categoryLabel.Visible = normal;
            categoryStrikeoutLabel.Visible = stickout;
        }

        private void changeBackColor(int color)
        {
            upperPanel.BackColor = System.Drawing.Color.FromArgb(color,color,color);
        }

        private void categoryStrikeoutLabel_MouseClick(object sender, MouseEventArgs e)
        {
            categoryClicked();
        }
    }
}
