using System;
using System.Drawing;
using System.Windows.Forms;
using itHappends;
using itHappens.Classes;
using itHappens.UIs.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using dbstuff;

namespace itHappens.UIs.andrea
{

    public partial class UserProfilePage : UserControl
    {

        public int userId { get; set; }
        public int eventId { get; set; }

        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();

        private static UserProfilePage _instance = new UserProfilePage();
        public static UserProfilePage Instance => _instance;

        public UserProfilePage()
        {
            InitializeComponent();
        }

        public UserProfilePage(int userId, string userName, string userSurname, Image profilePicture)
        {
            InitializeComponent();

            //eventsUserWillAttend();
            //vanueLabel.Text = evLocation;
            userNameLabel.Text = userName + " " + userSurname;
            userProfilePictureOvalPictureBox.BackgroundImage = profilePicture;
            //monthLabel.Text = Utility.Month(eventDateTime);
            //dayLabel.Text = Utility.Day(eventDateTime);

            //categoryColorPanel.BackColor = Color.FromName(categoryColor);
            //vanueLabel.Text = venueName;
            //miniEventBakcgroundPictureBox.BackgroundImage = eventBackground;

            this.userId = userId;
            this.eventId = eventId;

        }
       
        private void usersUpcomingEvents()
        {
            
            MySqlConnection con;
            
            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                int userId = UIs.anna.LogInPage.userId;
                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "SELECT ev.id, cat.color, ev.title, ve.name, ev.startingDate   " +
                                     "FROM users us " +
                                     "JOIN event_list evL ON us.id = evL.creatorID " +
                                     "JOIN attendants att ON evL.id = att.eventListID " +
                                     "JOIN event ev ON att.eventID = ev.id " +
                                     "JOIN categories cat ON cat.id = ev.categoryID " +
                                     "JOIN venues ve ON ve.id = ev.venueID " +
                                     "WHERE us.id = '" + userId + "'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    miniCaruselFillWithEventMiniView(dataReader.GetString(1), Convert.ToInt32(dataReader.GetString(0)), dataReader.GetString(2));
                }
                con.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
            
        }


        private void UserProfilePage_Load(object sender, EventArgs e)
        {
            eventsUserWillAttend();
        }

        
        private void eventsUserWillAttend()
        {
            for (int i = 0; i < 10; i++)
            {
                eventsUserWillAttendCarousel.AddControl(new UIs.Common.EventMiniView());
            }
        }

        public void miniCaruselFillWithEventMiniView(string categoryColor, int theEventId, string eventTitle)
        {
            eventsUserWillAttendCarousel.AddControl(new UIs.Common.EventMiniView(categoryColor, theEventId, eventTitle));
        }

        
    /*   public static void openUserPage(object sender, EventArgs e, int userId)
        {
           
            MainSplitForm.middlePanel.Controls.Clear();
            var v = Db_connector.Query(@"Select user.id, user.name , user.surname,                                         
						FROM user
						WHERE @userId = ",
                      new string[,] { { "@userId", userId + "" } });
            v.Read();
            var middlePage = new  UserProfilePage
                (v.GetInt32(0),v.GetInt32(1),v.GetString(2), v.GetString(3),
                 v.GetString(4),v.GetString(5) , v.GetString(6),null,null,v.GetDateTime(7));
            MainSplitForm.middlePanel.Controls.Add(middlePage);
            middlePage.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            middlePage.Dock = DockStyle.Fill;


        }*/

    }
}
