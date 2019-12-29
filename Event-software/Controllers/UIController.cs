using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace itHappens.Controllers
{
    class UIController
    {
        public static void openPage(string page)
        {
            
            if (string.Equals(page, "main"))
            {
                hostTheMainPage();
            }
            else if (string.Equals(page, "search"))
            {
                hostTheSearchPage();
            }
            
        }


        public static void openHostForMainAndSearchPage()
        {
            UIs.Common.MainSplitForm.middlePanel.Controls.Clear();
            var hostPage = new UIs.stefania.CommonSearchTextPage();

            UIs.Common.MainSplitForm.middlePanel.Controls.Add(hostPage);
            hostPage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            hostPage.Dock = DockStyle.Fill;
        }


        public static void hostTheMainPage()
        {

            var mainPage = new UIs.stefania.MainPage();
            UIs.stefania.CommonSearchTextPage.hostPanel.Controls.Add(mainPage);
            mainPage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            mainPage.Dock = DockStyle.Fill;
        }
        public static void hostTheSearchPage()
        {
            var searchPage = new UIs.Common.SearchPage();
            UIs.stefania.CommonSearchTextPage.hostPanel.Controls.Add(searchPage);
            searchPage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            searchPage.Dock = DockStyle.Fill;
        }


        public static void MainPageTodayEventsAndMadeForYouCarousel_Load()
        {
            for (int i = 0; i < 10; i++)
            {
                UIs.stefania.MainPage.todayEventsCarousel.AddControl(new UIs.Common.EventMiniView());
            }

            for (int i = 0; i < 5; i++)
            {
                UIs.stefania.MainPage.madeForYouCarusel.AddControl(new UIs.Common.CategoryGroupBox());
            }
        }


        public static void SearchPageFlowLayoutPanels_Load()
        {

            for (int i = 0; i < 20; i++)
            {
                UIs.Common.SearchPage.flowLayoutPanel1.Controls.Add(new UIs.Common.CategoryMiniBox());
            }
            for (int i = 0; i < 20; i++)
            {
                UIs.Common.SearchPage.flowLayoutPanel2.Controls.Add(new UIs.Common.CategoryMiniBox());
            }

            for (int i = 0; i < 20; i++)
            {
                var eventminiview = new UIs.Common.EventMiniView();
                eventminiview.Scale(0.55F);
                UIs.Common.SearchPage.flowLayoutPanel3.Controls.Add(eventminiview);
            }
        }

        public static void AllCategoriesFlowPanel_Load()
        {
            for (int i = 0; i < 20; i++)
            {
                UIs.SearchForm.allCategoriesFlowPanel.Controls.Add(new UIs.Common.CategoryMiniBox());
            }
        }

    }
}
