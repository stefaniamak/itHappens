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
                categoryIsSelected(true);
            } 
            else
            {
                categoryIsSelected(false);
            }
            
        }

        public void categoryIsSelected(bool isSelected)
        {
            if(isSelected == true)
            {
                changeCategoryMiniBoxStyle(true, false, 45);
            }
            else
            {
                changeCategoryMiniBoxStyle(false, true, 25);
            }
        }


        public void changeCategoryMiniBoxStyle(bool normal, bool stickout, int color)
        {
            setLabelVisibility(normal, stickout);
            changeBackgroundPanelBackColor(color);
        }

        private void setLabelVisibility(bool normal, bool stickout)
        {
            categoryLabel.Visible = normal;
            categoryStrikeoutLabel.Visible = stickout;
        }

        private void changeBackgroundPanelBackColor(int color)
        {
            upperPanel.BackColor = System.Drawing.Color.FromArgb(color,color,color);
        }

        private void categoryStrikeoutLabel_MouseClick(object sender, MouseEventArgs e)
        {
            categoryClicked();
        }

        
    }
}
