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
            backgroundColorPanel.BackColor = Color.FromName(color);
            backgroundColorPanel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            categoryLabel.Text = categoryName;
        }
    }
}
