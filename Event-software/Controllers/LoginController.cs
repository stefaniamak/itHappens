using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.Controllers
{
    class LoginController
    {

        public static bool FieldsValidation(String username,String password,bool flag)
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

        public static String DatabaseFieldValidation(String username, String password)
        {
            string conStr = "Server=127.0.0.1;Database=it_happens;Uid=root;Pwd=0dinth0rz3us;";
            MySqlConnection con;
            String result = "";

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select Username from users where Username= '" + username + "' and password= '" + password + "'";

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
                Console.WriteLine("Error");
            }


            return result;

        }

        public static String loginNameSurnameToProfile(String usern, String pass)
        {
            string conStr = "Server=127.0.0.1;Database=it_happens;Uid=root;Pwd=0dinth0rz3us;";
            MySqlConnection con;
            String Name = "";
            String Surname = "";

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select name,surname from users where Username= '" + usern + "' and password= '" + pass + "'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Name = dataReader.GetString(0);
                    Surname = dataReader.GetString(1);
                }

                
                con.Close();

                return Name+ " "+Surname;


            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }


            return Name+Surname;

        }




    }
}
