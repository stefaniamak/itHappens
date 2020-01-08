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
using System.Text.RegularExpressions;

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
                UIs.SignUpUserControl.fillTheAreaComboBox(AreaComboBox);
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

        private void NameSettingsTextBox_Validated(object sender, EventArgs e)
        {
            if (!NameSettingsTextBox.Text.Equals(""))
            {
                if (UIs.SignUpUserControl.IsAllLetters(NameSettingsTextBox.Text))
                {
                    NameWarningLabel.Text = "";
                }
                else
                {
                    NameWarningLabel.Text = "Write only letters";
                }

            }
            else
            {
                NameWarningLabel.Text = "Name is empty";
            }
        }

        private void SurnameSettingsTextBox_Validated(object sender, EventArgs e)
        {
            if (!SurnameSettingsTextBox.Text.Equals(""))
            {
                if (UIs.SignUpUserControl.IsAllLetters(SurnameSettingsTextBox.Text))
                {
                    SurnameWarningLabel.Text = "";
                }
                else
                {
                    SurnameWarningLabel.Text = "Write only letters";
                }

            }
            else
            {
                SurnameWarningLabel.Text = "Surname is empty";
            }
        }



        private void UsernameTextBox_Validated(object sender, EventArgs e)
        {
            if (!UsernameTextBox.Text.Equals(""))
            {
                if (Char.IsLetter(UsernameTextBox.Text[0]))
                {
                    UsernameWarningLabel.Text = "";
                }
                else
                {
                    UsernameWarningLabel.Text = "Must start with letter";
                }

            }
            else
            {
                UsernameWarningLabel.Text = "Username is empty";
            }
        }

        private void EmailSettingsTextBox_Validated(object sender, EventArgs e)
        {
            Regex re = new Regex(UIs.SignUpUserControl.strRegex);

            if (!EmailSettingsTextBox.Text.Equals(""))
            {
                if (re.IsMatch(EmailSettingsTextBox.Text))
                {
                    EmailWarningLabel.Text = "";
                }
                else
                {
                    EmailWarningLabel.Text = "Invalid email format";
                }
            }
            else
            {
                EmailWarningLabel.Text = "Email is empty";
            }
        }

        private void EmailSettingsTextBox_TextChanged(object sender, EventArgs e)
        {
            if(UIs.anna.LogInPage.loggedInUser == true)
            {
                int userID = Classes.DatabaseGeneralMethods.returnUsersIDWhenIsLogedIn(UIs.Sidebars.ProfileSidebar.usernameLable.Text);
                //Not finished
            }

        }
    }
}
