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
            //InitializeComponent();
            //fillMostFrequent();
            //fillAllCategories();
            //showMatches();
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
                    if (Convert.ToInt32(dataReader.GetString(0)) < 4)
                    {
                        flowLayoutPanel2.Controls.Add(new UIs.Common.CategoryMiniBox(dataReader.GetString(1), dataReader.GetString(2)));
                    } 
                    else if (Convert.ToInt32(dataReader.GetString(0)) < 36)
                    {
                        flowLayoutPanel4.Controls.Add(new UIs.Common.CategoryMiniBox(dataReader.GetString(1), dataReader.GetString(2)));
                    } 
                    else
                    {
                        flowLayoutPanel5.Controls.Add(new UIs.Common.CategoryMiniBox(dataReader.GetString(1), dataReader.GetString(2)));
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

        }



    }
}
