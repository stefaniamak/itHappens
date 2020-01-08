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
    public partial class FriendsWhoHaveVisited : UserControl
    {
        public FriendsWhoHaveVisited()
        {
            InitializeComponent();
        }

        public FriendsWhoHaveVisited(Image friendProfilePicture, string friendName, string friendSurname)
        {
            InitializeComponent();

            friendPicOvalPictureBox.BackgroundImage = friendProfilePicture;
            friendnameLabel.Text = friendName; // Sundiase to onoma tou filou me to epitheto 
        }
    }
}
