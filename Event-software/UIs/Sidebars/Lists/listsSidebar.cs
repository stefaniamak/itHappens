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

            MySqlConnection con;
            MySqlCommand command;
            MySqlDataReader dataReader;
            try
            {
                con = new MySqlConnection(conStr);
                con.Open();
                string queryString = "SELECT (*) FROM event_list";

                command = new MySqlCommand(queryString, con);
                dataReader = command.ExecuteReader();
                int List = (Convert.ToInt32(dataReader.GetString(0)));
                while (dataReader.Read())
                {
                    for (int i = 0; i < List; i++)
                    {
                        listsFlowLayoutPanel.Controls.Add(new Lists.ListsMini(dataReader.GetString(2)));

                    }
                    con.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
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
    }
}
