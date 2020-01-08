using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbstuff;
using MySql.Data.MySqlClient;

namespace itHappens.UIs.valentina
{
    public partial class SettingsPage : UserControl
    {

        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();

        public SettingsPage()
        {
            InitializeComponent();
            if (UIs.anna.LogInPage.loggedInUser == true) 
            {
                fillTheFieldsWithUsersInfo();
            }
            
        }

        

        public void fillTheFieldsWithUsersInfo()
        {

            UsernameTextBox.Text = UIs.Sidebars.ProfileSidebar.usernameLable.Text;
            MySqlConnection con;
            int areaID=0;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select name,surname,email,areaID from users where username= '" + 
                    UIs.Sidebars.ProfileSidebar.usernameLable.Text + "'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    NameSettingsTextBox.Text = dataReader.GetString(0);
                    SurnameSettingsTextBox.Text = dataReader.GetString(1);
                    EmailSettingsTextBox.Text = dataReader.GetString(2);
                    areaID = Convert.ToInt32(dataReader.GetString(3));
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select country from area where id= '" +areaID+ "'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    AreaComboBox.Text = dataReader.GetString(0);
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }






        }

    }
}
