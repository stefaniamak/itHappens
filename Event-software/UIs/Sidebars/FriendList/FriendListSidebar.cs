using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Sidebars
{
    public partial class FriendListSidebar : UserControl
    {
        public FriendListSidebar()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                var friendMiniView = new FriendList.FriendListMini();
                friendListsFlowLayoutPanel.Controls.Add(friendMiniView);
                /*
                friendMiniView.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
                friendListsFlowLayoutPanel.SetFlowBreak(friendMiniView, true);
                */
            }
        }
    }
}
