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
    public partial class UpcomingEventsSidebar : UserControl
    {

        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();
        public UpcomingEventsSidebar()
        {
            InitializeComponent();

            //kanoume ta object pou tha xreisimopoisoume gia na kanoume connect stin database
            MySqlConnection con;
            MySqlCommand command;
            MySqlDataReader dataReader;

            //kane tin syndesy stin database
            try
            {

                con = new MySqlConnection(conStr);
                con.Open();

                //to query pou xreisimopoioume gia na travixoume ta dedomena apo tin database
                string queryString = "SELECT (id,title,location,startingDate) FROM event";


                command = new MySqlCommand(queryString, con);
                dataReader = command.ExecuteReader();
                int List = (Convert.ToInt32(dataReader.GetString(0)));
                while (dataReader.Read())
                {
                    for (int i = 0; i < List; i++)
                    {

                        var upevent = new UpcomingEvents.UpcomingEventMini(dataReader.GetString(1), dataReader.GetString(2),dataReader.GetDateTime(3));
                        upcomingEventsFlowLayout.Controls.Add(upevent);

                    }
                    con.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //upcomingEventsFlowLayout.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);

        }

        private void mainFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
