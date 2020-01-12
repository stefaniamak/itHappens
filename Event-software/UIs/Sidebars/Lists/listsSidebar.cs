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
using dbstuff;

namespace itHappens.UIs.Sidebars
{
    public partial class ListsSidebar : UserControl
    {
        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();


        public ListsSidebar()
        {
            InitializeComponent();

            createListPage.Visible = false;
            fillAllLists();
            
        }

        private void fillAllLists()
        {
            MySqlConnection con;
            MySqlCommand command;
            MySqlDataReader dataReader;
            try
            {
                string username = "x";
                    //= UIs.anna.LogInPage.userName;
                con = new MySqlConnection(conStr);
                con.Open();
                string queryString = "SELECT event_list.title " +
                                     "FROM event_list " +
                                     "JOIN users ON event_list.creatorID = users.id " +
                                     "WHERE users.username = '" + username + "'";

                command = new MySqlCommand(queryString, con);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    listsFlowLayoutPanel.Controls.Add(new Lists.ListsMini(dataReader.GetString(0)));

                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void listsHorizontalListing_Load(object sender, EventArgs e)
        {

        }

        private void carousel1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            createListPage.Visible = !createListPage.Visible;
        }
    }
}
