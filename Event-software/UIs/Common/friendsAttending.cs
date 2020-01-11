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
    public partial class FriendsAttending : UserControl
    {
        public FriendsAttending()
        {
            InitializeComponent();
        }

        public FriendsAttending(Image friendProfilePicture, string friendName, string friendSurname, string attendingList)
        {
            InitializeComponent();
            Color attendingColor;// = Color.FromName(attendingColor);

            if (Equals(attendingList, "GOING"))
            {
                attendingColor = Color.FromName("lime");
            }
            else
            {
                attendingColor = Color.FromName("yellow");
            }
            
            friendPicOvalPictureBox.BackgroundImage = friendProfilePicture;
            friendnameLabel.Text = friendName;
            friendSurnameLabel.Text = friendSurname;
            colorControl.BackColor = attendingColor;
        }

        //  -----------  Προσωρινός Constructor χωρίς τα insert εικόνων.  -----------  
        public FriendsAttending(string friendName, string friendSurname, string attendingColor)
        {
            InitializeComponent();
            Color atColor = Color.FromName(attendingColor);
            friendnameLabel.Text = friendName;
            friendSurnameLabel.Text = friendSurname;
            colorControl.BackColor = atColor;
        }
    }
}
