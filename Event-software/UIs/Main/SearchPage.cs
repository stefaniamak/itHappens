using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using dbstuff;

namespace itHappens.UIs.Common
{
    public partial class SearchPage : UserControl
    {
        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();
        //public string[] categoriesSelected;

        public SearchPage()
        {
            InitializeComponent();
            fillMostFrequent();
            fillAllCategories();
            showMatches();

        }

        private void SearchFormTest_Load(object sender, EventArgs e)
        {
            //Controllers.UIController.Instance.SearchPageFlowLayoutPanels_Load();       
        }

        public void fillMostFrequent()
        {

        }

        public void fillAllCategories()
        {
            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "SELECT id, title, color FROM categories";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var box = new UIs.Common.CategoryMiniBox(Convert.ToInt32(dataReader.GetString(0)), dataReader.GetString(1), dataReader.GetString(2));
                    box.OnSelectionChanged += () => { this.showMatches(); }; // new SelectionChanged(this.showMatches);

                    if (Convert.ToInt32(dataReader.GetString(0)) < 4)
                    {
                        allcategoriesFlowLayoutPanel1.Controls.Add(box);
                    } 
                    else if (Convert.ToInt32(dataReader.GetString(0)) < 36)
                    {
                        allcategoriesFlowLayoutPanel2.Controls.Add(box);
                    } 
                    else
                    {
                        allcategoriesFlowLayoutPanel3.Controls.Add(box);
                    }
                    
                }
                con.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
        }

        public void showMatches()
        {
            matchesFlowLayoutPanel.Controls.Clear();

            List<string> selectedCategoryIds = new List<string>();

            foreach (CategoryMiniBox box in allcategoriesFlowLayoutPanel2.Controls)
                if (box.IsSelected)
                    selectedCategoryIds.Add(box.ID.ToString());
            
            foreach (CategoryMiniBox box in allcategoriesFlowLayoutPanel3.Controls)
                if (box.IsSelected)
                    selectedCategoryIds.Add(box.ID.ToString());



            var ids = String.Join(",", selectedCategoryIds);

            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "SELECT ev.title, cat.color " +            // When Images get inserted to database, there will be a -- event.image -- added, and the -- event.title -- will be removed.
                                     "FROM it_happens.event ev JOIN it_happens.categories cat " +
                                     "ON cat.id = ev.categoryID " +
                                     "WHERE cat.id IN (" + ids + ")";  


                command = new MySqlCommand(queryString, con);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    var eventminiview = new UIs.Common.EventMiniView(dataReader.GetString(1));
                    eventminiview.Scale(0.90F);
                    matchesFlowLayoutPanel.Controls.Add(eventminiview);
                }
                con.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
            /*
            var eventminiview = new UIs.Common.EventMiniView();
            eventminiview.Scale(0.55F);
            matchesFlowLayoutPanel.Controls.Add(eventminiview);
            */
        }

        private void clearSelections_MouseClick(object sender, MouseEventArgs e)
        {
            //UIs.Common.CategoryMiniBox.setDefaultCategoryMiniBoxes();
        }
    }
}
