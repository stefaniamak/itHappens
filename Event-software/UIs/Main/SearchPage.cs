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
        public static string[] categoriesSelected;

        public SearchPage()
        {
            InitializeComponent();
            fillMostFrequent();
            fillAllCategories();
            showMatches();

        }

        private void SearchFormTest_Load(object sender, EventArgs e)
        {
            //Controllers.UIController.SearchPageFlowLayoutPanels_Load();       
        }

        public void fillMostFrequent()
        {

        }

        public static void fillAllCategories()
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
                    //Console.WriteLine(GlobalData.categoriesSelectedSelected[7]);
                    //categoriesSelectedSelected[Convert.ToInt32(dataReader.GetString(0))] = "hi";
                    if (Convert.ToInt32(dataReader.GetString(0)) < 4)
                    {
                        allcategoriesFlowLayoutPanel1.Controls.Add(new UIs.Common.CategoryMiniBox(dataReader.GetString(1), dataReader.GetString(2)));
                    } 
                    else if (Convert.ToInt32(dataReader.GetString(0)) < 36)
                    {
                        allcategoriesFlowLayoutPanel2.Controls.Add(new UIs.Common.CategoryMiniBox(dataReader.GetString(1), dataReader.GetString(2)));
                    } 
                    else
                    {
                        allcategoriesFlowLayoutPanel3.Controls.Add(new UIs.Common.CategoryMiniBox(dataReader.GetString(1), dataReader.GetString(2)));
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
            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "SELECT ev.title, cat.color " +            // When Images get inserted to database, there will be a -- event.image -- added, and the -- event.title -- will be removed.
                                     "FROM it_happens.event ev JOIN it_happens.categories cat " +
                                     "ON cat.id = ev.categoryID";  


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
