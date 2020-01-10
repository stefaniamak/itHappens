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
using Microsoft.VisualBasic;

namespace itHappens.UIs.valentina
{
    public partial class SettingsPage : UserControl
    {

        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();
        public int UsersID;
        public static bool flagOldPass = true;

        public SettingsPage()
        {
            InitializeComponent();
            if (UIs.anna.LogInPage.loggedInUser == true) 
            {
                UsersID = Classes.DatabaseGeneralMethods.returnUsersIDWhenIsLogedIn(UIs.Sidebars.ProfileSidebar.usernameLable.Text);
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
                    if (UIs.anna.LogInPage.loggedInUser == true)
                    {
                        int userID = Classes.DatabaseGeneralMethods.returnUsersIDWhenIsLogedIn(UIs.Sidebars.ProfileSidebar.usernameLable.Text);

                        if (Classes.DatabaseGeneralMethods.checkIfExistsInDatabaseWithAnotherID(userID, "username", UsernameTextBox.Text))
                        {
                            UsernameWarningLabel.Text = "This username is used";
                        }
                        else
                        {
                            UsernameWarningLabel.Text = "";
                        }
                    }                       
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
                    if (UIs.anna.LogInPage.loggedInUser == true)
                    {
                        int userID = Classes.DatabaseGeneralMethods.returnUsersIDWhenIsLogedIn(UIs.Sidebars.ProfileSidebar.usernameLable.Text);
                     
                        if (Classes.DatabaseGeneralMethods.checkIfExistsInDatabaseWithAnotherID(userID, "email", EmailSettingsTextBox.Text))
                        {
                            EmailWarningLabel.Text = "This email is used";
                        }
                        else
                        {
                            EmailWarningLabel.Text = "";
                        }
                    }                   
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

        private void NewPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if( NewPasswordTextBox.Text.Equals("Type new password"))
            {
                NewPasswordTextBox.Text = "";

                NewPasswordTextBox.ForeColor = Color.Black;

                NewPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void NewPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.Text.Equals(""))
            {
                NewPasswordTextBox.UseSystemPasswordChar = false;

                NewPasswordTextBox.Text = "Type new password";

                NewPasswordTextBox.ForeColor = Color.Gray;
            }
            else
            {
                if(NewPasswordTextBox.Text.Length <= 4)
                {
                    TypeNewPasswordLabel.Text = "At least 5 characters";
                }
                else
                {
                    TypeNewPasswordLabel.Text = "";
                }
            }
        }

        private void RepeatNewPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (RepeatNewPasswordTextBox.Text.Equals("Re-type new password"))
            {
                RepeatNewPasswordTextBox.Text = "";

                RepeatNewPasswordTextBox.ForeColor = Color.Black;

                RepeatNewPasswordTextBox.UseSystemPasswordChar = true;

            }
        }

        private void RepeatNewPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (RepeatNewPasswordTextBox.Text.Equals(""))
            {
                RepeatNewPasswordTextBox.UseSystemPasswordChar = false;

                RepeatNewPasswordTextBox.Text = "Re-type new password";

                RepeatNewPasswordTextBox.ForeColor = Color.Gray;
            }
            else
            {
                if (!RepeatNewPasswordTextBox.Text.Equals(NewPasswordTextBox.Text))
                {
                    ReTypeLabel.Text = "It does not match with new password";
                }
                else
                {
                    ReTypeLabel.Text = "";
                }
            }
        }

        private void UpdateChangesButton_Click(object sender, EventArgs e)
        {
            if (NameSettingsTextBox.Text.Equals("") || SurnameSettingsTextBox.Text.Equals("")
                || UsernameTextBox.Text.Equals("") || EmailSettingsTextBox.Text.Equals(""))
            {
                MessageBox.Show("Fill the fields right", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (NameWarningLabel.Text.Equals("") && SurnameWarningLabel.Text.Equals("")
                      && UsernameWarningLabel.Text.Equals("") && EmailWarningLabel.Text.Equals("")
                      && ReTypeLabel.Text.Equals("") && TypeNewPasswordLabel.Text.Equals("")) 
                 { 
            
                    if (!NewPasswordTextBox.Text.Equals("Type new password") && !RepeatNewPasswordTextBox.Text.Equals("Re-type new password"))
                    {

                        UIs.InputOldPassForm form = new UIs.InputOldPassForm();
                        form.ShowDialog();

                        if (flagOldPass && GiveOldPasswordForm())
                        {
                            do_update();
                        }
                        else if (flagOldPass == false)
                        {
                            MessageBox.Show("You have to type your old password to update changes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        if (checkIfThereAreNotChangesInFields(NameSettingsTextBox.Text, SurnameSettingsTextBox.Text, UsernameTextBox.Text, EmailSettingsTextBox.Text))
                        {
                            updateUserProfileWithoutPass(UsernameTextBox.Text, EmailSettingsTextBox.Text, NameSettingsTextBox.Text, SurnameSettingsTextBox.Text);
                            MessageBox.Show("You successfully update your profile!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (!UIs.Sidebars.ProfileSidebar.usernameLable.Text.Equals(UsernameTextBox.Text))
                            {
                                UIs.Sidebars.ProfileSidebar.usernameLable.Text = UsernameTextBox.Text;
                            }
                        }
                        else
                        {
                            MessageBox.Show("There are no changes to update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                 }
        }

        public void do_update()
        {
            updateUserProfile(UsernameTextBox.Text, NewPasswordTextBox.Text, EmailSettingsTextBox.Text, NameSettingsTextBox.Text, SurnameSettingsTextBox.Text);
            if (!UIs.Sidebars.ProfileSidebar.usernameLable.Text.Equals(UsernameTextBox.Text))
            {
                UIs.Sidebars.ProfileSidebar.usernameLable.Text = UsernameTextBox.Text;
            }

            MessageBox.Show("You successfully update your profile!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NewPasswordTextBox.UseSystemPasswordChar = false;
            RepeatNewPasswordTextBox.UseSystemPasswordChar = false;
            NewPasswordTextBox.ForeColor = Color.Gray;
            RepeatNewPasswordTextBox.ForeColor = Color.Gray;
            NewPasswordTextBox.Text = "Type new password";
            RepeatNewPasswordTextBox.Text = "Re-type new password";
        }


        public void updateUserProfile(String userName,String pass,String email,String name,String surname)
        {
            int areaId = Classes.DatabaseGeneralMethods.ReturnIdOfAray(AreaComboBox.Text);
            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand cmd = con.CreateCommand(); ;

                String query = "UPDATE users SET areaID=@areaID , username=@username , password=@password , email=@email , name=@name , surname=@surname WHERE id=" + UsersID + "";


                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@areaID", areaId);
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                Console.WriteLine("Error Update Statement");
            }
        }

        public void updateUserProfileWithoutPass(String userName, String email, String name, String surname)
        {
            int areaId = Classes.DatabaseGeneralMethods.ReturnIdOfAray(AreaComboBox.Text);
            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand cmd = con.CreateCommand(); ;

                String query = "UPDATE users SET areaID=@areaID , username=@username , email=@email , name=@name , surname=@surname WHERE id=" + UsersID + "";

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@areaID", areaId);
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                Console.WriteLine("Error Update Statement Without Pass");
            }
        }

        public static bool GiveOldPasswordForm()
        {
            return UIs.InputOldPassForm.oldPass;
        }

        public bool checkIfThereAreNotChangesInFields(String name, String surname, String username, String email)
        {
            int areaId = Classes.DatabaseGeneralMethods.ReturnIdOfAray(AreaComboBox.Text);
            MySqlConnection con;
            bool result = true;

            try
            {

                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select name,surname,username,email,areaID from users where id=" + UsersID + "";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if (name.Equals(dataReader.GetString(0)) && surname.Equals(dataReader.GetString(1)) &&
                        username.Equals(dataReader.GetString(2)) && email.Equals(dataReader.GetString(3))
                        && areaId.Equals(dataReader.GetInt32(4)))
                    {
                        result = false;
                    }
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }


            return result;
        }



    }
}
