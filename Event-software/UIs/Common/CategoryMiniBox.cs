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
        public bool IsSelected => categoryLabel.Visible;
        public int ID { get; private set; }


        public delegate void SelectionChanged();
        public SelectionChanged OnSelectionChanged;

        public CategoryMiniBox()
        {
            InitializeComponent();
        }

        public CategoryMiniBox(int id, string categoryName, string color)
        {
            InitializeComponent();

            ID = id;

            Color catColor = Color.FromName(color);
            backgroundColorPanel.BackColor = catColor;
            backgroundColorPanel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            categoryLabel.Text = categoryName;
            categoryStrikeoutLabel.Text = categoryName;

            categoryStrikeoutLabel.Visible = false;
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
            categoryLabel.Visible = !categoryLabel.Visible;
            categoryStrikeoutLabel.Visible = !categoryStrikeoutLabel.Visible;
            changeBackgroundPanelBackColor(IsSelected ? 45 : 25);

            OnSelectionChanged?.Invoke(); // -> OnSelectionChanged()
        }


        private void changeBackgroundPanelBackColor(int color)
        {
            upperPanel.BackColor = System.Drawing.Color.FromArgb(color, color, color);
        }

        private void categoryStrikeoutLabel_MouseClick(object sender, MouseEventArgs e)
        {
            categoryClicked();
        }


    }
}
