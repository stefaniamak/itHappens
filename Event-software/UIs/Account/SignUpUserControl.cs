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

namespace itHappens.UIs
{
    public partial class SignUpUserControl : UserControl
    {
        public SignUpUserControl()
        {
            InitializeComponent();
            fillTheComboBox();
            areaComboBox.Items.RemoveAt(0);
            areaComboBox.Items.Insert(0, "Select");
            areaComboBox.SelectedIndex = 0;

        }

        private void SignUpUserControl_Load(object sender, EventArgs e)
        {

        }

        public void fillTheComboBox()
        {
            string conStr = "Server=127.0.0.1;Database=it_happens;Uid=root;Pwd=0dinth0rz3us;";
            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select distinct country from area";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();              

                while (dataReader.Read())
                {                  
                   areaComboBox.Items.Add(dataReader.GetString(0));                    
                }
                con.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
        }


        public void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameTextBox.Text.Equals(""))
            {
                nameValLabel.Text = "Name is empty";
            }
            else if (!nameTextBox.Text.Equals(""))
            {
                nameValLabel.Text = "";
            }
        }

        private void nameTextBox_Validated(object sender, EventArgs e)
        {
            if (!nameTextBox.Text.Equals(""))
            {
                if (IsAllLetters(nameTextBox.Text))
                {
                    nameValLabel.Text = "";
                }
                else
                {
                    nameValLabel.Text = "Write only letters";
                }

            }
        }

        private void surnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (surnameTextBox.Text.Equals(""))
            {
                surnameValLabel.Text = "Surname is empty";
            }
        }

        private void surnameTextBox_Validated(object sender, EventArgs e)
        {
            if (!surnameTextBox.Text.Equals(""))
            {
                if (IsAllLetters(surnameTextBox.Text))
                {
                    surnameValLabel.Text = "";
                }
                else
                {
                    surnameValLabel.Text = "Write only letters";
                }
            }
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (emailTextBox.Text.Equals(""))
            {
                emailValLabel.Text = "Email is empty";
            }
        }

        private void emailTextBox_Validated(object sender, EventArgs e)
        {
            if (!emailTextBox.Text.Equals(""))
            {
                string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                        @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                        @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(emailTextBox.Text))
                {
                    emailValLabel.Text = "";
                }
                else
                {
                    emailValLabel.Text = "Invalid email format";
                }
            }
        }

        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (usernameTextBox.Text.Equals(""))
            {
                usernameValLabel.Text = "Username is empty";
            }
        }

        private void usernameTextBox_Validated(object sender, EventArgs e)
        {
            if (!usernameTextBox.Text.Equals(""))
            {
                usernameValLabel.Text = "";
            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (passwordTextBox.Text.Equals(""))
            {
                passwordValLabel.Text = "Password is empty";
            }
        }

        private void passwordTextBox_Validated(object sender, EventArgs e)
        {
            if (!passwordTextBox.Text.Equals(""))
            {
                passwordValLabel.Text = "";
            }
        }

        private void repassTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (repassTextBox.Text.Equals(""))
            {
                repassValLabel.Text = "Re-Type Password is empty";
            }
            else if (!repassTextBox.Text.Equals(""))
            {
                if (!repassTextBox.Text.Equals(passwordTextBox.Text))
                {
                    repassValLabel.Text = "It does not match with Password";
                }
            }
        }

        private void repassTextBox_Validated(object sender, EventArgs e)
        {
            if (!repassTextBox.Text.Equals("") && repassTextBox.Text.Equals(passwordTextBox.Text))
            {
                repassValLabel.Text = "";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Equals("") && surnameTextBox.Text.Equals("") && emailTextBox.Text.Equals("")
                && usernameTextBox.Text.Equals("") && passwordTextBox.Text.Equals("") && repassTextBox.Text.Equals(""))
            {
                nameValLabel.Text = "Name is empty";
                surnameValLabel.Text = "Surname is empty";
                emailValLabel.Text = "Email is empty";
                usernameValLabel.Text = "Username is empty";
                passwordValLabel.Text = "Password is empty";
                repassValLabel.Text = "Re-Type Password is empty";
            }
            else if (nameTextBox.Text.Equals(""))
            {
                nameValLabel.Text = "Name is empty";
            }
            else if (surnameTextBox.Text.Equals(""))
            {
                surnameValLabel.Text = "Surname is empty";
            }
            else if (emailTextBox.Text.Equals(""))
            {
                emailValLabel.Text = "Email is empty";
            }
            else if (usernameTextBox.Text.Equals(""))
            {
                usernameValLabel.Text = "Username is empty";
            }
            else if (passwordTextBox.Text.Equals(""))
            {
                passwordValLabel.Text = "Password is empty";
            }
            else if (repassTextBox.Text.Equals(""))
            {
                repassValLabel.Text = "Re-Type Password is empty";
            }
            else if (!repassTextBox.Text.Equals(passwordTextBox.Text))
            {
                repassValLabel.Text = "It does not match with Password";
            }
            else if (areaComboBox.Text.Equals("Select"))
            {
                areaValLabel.Text = "Select a country";
            }
            else
            {
                areaValLabel.Text = "";
                MessageBox.Show("Your registration has been successfully completed!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                signUpCon(areaComboBox.SelectedItem.ToString(), Convert.ToInt32(numericUpDown.Value), usernameTextBox.Text,
                    passwordTextBox.Text, nameTextBox.Text, surnameTextBox.Text, emailTextBox.Text);
                int creatorid = Controllers.LoginController.returnUsersID(usernameTextBox.Text, passwordTextBox.Text);
                Classes.CreateList.createEvent_ListMethod("History",creatorid);
                Classes.CreateList.createEvent_ListMethod("Going", creatorid);
                Classes.CreateList.createEvent_ListMethod("Interested", creatorid);
                clearTextBoxes();
                Controllers.UIController.logInToolStripMenuItem_MiddlePanel();

            }

        }

        public void clearTextBoxes()
        {
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            emailTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            repassTextBox.Text = "";
            
        }

        public static void signUpCon(String area, int age, String userName, String pass, String name, String surname, String email)
        {
            int areaId = 0;
            string conStr = "Server=127.0.0.1;Database=it_happens;Uid=root;Pwd=0dinth0rz3us;";
            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select id from area where country= '" + area + "'";

                command = new MySqlCommand(queryString, con);


                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    areaId = Convert.ToInt32(dataReader.GetString(0));
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

                MySqlCommand cmd = con.CreateCommand(); ;

                String query = "INSERT INTO users(areaID,username,password,email,name,surname,age) VALUES(@areaId,@username,@password,@email,@name,@surname,@age)";

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@areaId", areaId);
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@age", age);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                Console.WriteLine("Error Insert Statement");
            }

        }

        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        
    }
}
