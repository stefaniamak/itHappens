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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            for (int i = 0; i < 20; i++)
            {
                //allCategoriesList.AddControl(new Common.CategoryMiniBox());
                //allCategoriesList.AddControl(new Common.CategoryMiniBox());
                //allCategoriesList.Controls.Add(DataGridLineStyle 5);
                
            }

            for (int i = 0; i < 20; i++)
            {
                allCategoriesFlowPanel.Controls.Add(new Common.CategoryMiniBox());
            }
        }
    }
}
