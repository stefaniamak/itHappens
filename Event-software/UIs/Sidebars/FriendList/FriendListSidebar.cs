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
    public partial class FriendListSidebar : UserControl
    {

        //
        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();
        public FriendListSidebar()


        {
            MySqlConnection con;
            MySqlCommand command;
            MySqlDataReader dataReader;
            try
            {
                con = new MySqlConnection(conStr);
                con.Open();
                string queryString = "SELECT (following_user_id) FROM following";

                command = new MySqlCommand(queryString, con);
                dataReader = command.ExecuteReader();
                int List = (Convert.ToInt32(dataReader.GetString(0)));

                

                while (dataReader.Read())
                {
                    for (int i = 0; i < List; i++)
                    {


                        string userName = "SELECT (name) FROM users WHERE user_id = List";
                        string userSurname = "SELECT (surname) FROM users WHERE user_id = List";

                        //prosolina values mexri na prosthethoun ta sosta query
                        string eventName = "test";
                        string venuelocation = "test";
                        DateTime date = DateTime.Now;


                        //string eventinfo = "SELECT  * FROM event_list WHERE user_id = List";


                        var friendMiniView = new FriendList.FriendListMini(userName, userSurname, eventName, venuelocation, date);
                        friendMiniView.Anchor = (AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
                        friendListsFlowLayoutPanel.Controls.Add(friendMiniView);

                    }
                    con.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
