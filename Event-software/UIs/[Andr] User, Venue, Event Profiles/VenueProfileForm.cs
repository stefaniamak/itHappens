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
    public partial class VenueProfileForm : Form
    {
        public VenueProfileForm()
        {
            InitializeComponent();
        }

        private void VenueProfileForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
