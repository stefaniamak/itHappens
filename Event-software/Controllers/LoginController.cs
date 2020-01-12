using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbstuff;

namespace itHappens.Controllers
{
    class LoginController
    {
        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();

        private static LoginController _instance = new LoginController();
        public static LoginController Instance => _instance;

        public bool FieldsValidation(String username,String password,bool flag)
        {
            if (String.IsNullOrEmpty(username) && String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fill the fields!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                if (String.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Give username", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Give password", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public String DatabaseFieldValidation(String username, String password)
        {
            MySqlConnection con;
            String result = "";

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select username, id from users where username= '" + username + "' and password= '" + password + "'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    result = dataReader.GetString(0);
                    UIs.anna.LogInPage.userId = dataReader.GetInt32(1);
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return result;

        }

        public String loginNameSurnameToProfile(String usern, String pass)
        {
            MySqlConnection con;
            String userName = "";

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select username from users where username= '" + usern + "' and password= '" + pass + "'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    userName = dataReader.GetString(0);
                }


                con.Close();

                return userName;


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return userName;

        }

        public int returnUsersID(String username, String password)
        {
            MySqlConnection con;
            String result = "";

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select id from users where username= '" + username + "' and password= '" + password + "'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    result = dataReader.GetString(0);
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return Convert.ToInt32(result);

        }



    }
}
