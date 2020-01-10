using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.Classes
{
    class SidebarsMethods
    {
        
        // Use the Singleton pattern
        private static SidebarsMethods _instance = new SidebarsMethods();
        public static SidebarsMethods Instance => _instance;
        

        public static void addFriendList()
        {
            var FriendListSidebar = new UIs.Sidebars.FriendListSidebar();
            UIs.Common.MainSplitForm.rightBottomPanel.Controls.Add(FriendListSidebar);
            FriendListSidebar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            FriendListSidebar.Dock = DockStyle.Fill;
        }

        public static void addUpcomingEvents()
        {
            var upcomingEventsSidebar = new UIs.Sidebars.UpcomingEventsSidebar();
            UIs.Common.MainSplitForm.leftTopPanel.Controls.Add(upcomingEventsSidebar);
            upcomingEventsSidebar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            upcomingEventsSidebar.Dock = DockStyle.Fill;
        }

        public static void addLists()
        {
            var listsSidebar = new UIs.Sidebars.ListsSidebar();
            UIs.Common.MainSplitForm.leftMiddlePanel.Controls.Add(listsSidebar);
            listsSidebar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            listsSidebar.Dock = DockStyle.Fill;
        }

        public static void addProfile()
        {
            var Profileidebar = new UIs.Sidebars.ProfileSidebar();
            UIs.Common.MainSplitForm.rightTopPanel.Controls.Add(Profileidebar);
            Profileidebar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            Profileidebar.Dock = DockStyle.Fill;
        }

    }
}
