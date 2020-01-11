using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbstuff;

namespace itHappens.Classes
{
    class DatabaseGeneralMethods
    {
        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();

        public static int returnUsersIDWhenIsLogedIn(String username)
        {
            MySqlConnection con;
            String result = "";

            try
            {

                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select id from users where username= '" + username + "'";

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


            return Convert.ToInt32(result);

        }

        public static bool checkIfExistsInDatabaseInUsers(String variable, String s)
        {
            MySqlConnection con;
            bool flag = false; ;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select " + variable + " from users";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if (s.Equals(dataReader.GetString(0)))
                    {
                        flag = true;
                    }
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }

            return flag;
        }

        public static bool checkIfExistsInDatabaseWithAnotherID(int Uid, String variable, String s)
        {
            MySqlConnection con;
            bool flag = false; 

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select " + variable +",id from users";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    
                    if (s.Equals(dataReader.GetString(0)) && Uid != dataReader.GetInt32(1))
                    {
                        flag = true;
                    }
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!");
            }

            return flag;
        }


        public static String ReturnUsersPassword(String usern)
        {
            MySqlConnection con;
            String pass = ""; 

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select password from users where username= '" +usern+"'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    pass = dataReader.GetString(0);
                    
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!");
            }

            return pass;
        }
        

        public static int ReturnIdOfAray(String area)
        {
            int areaId = 0;
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

            return areaId;
        }

        public static int ReturnAgeOfUser(String user, String pass)
        {
            MySqlConnection con;
            int age = 0;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select age from users where username='"+user+"' and password='"+pass+"'";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    age = dataReader.GetInt32(0);
                }
                con.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!");
            }

            return age;
        }

        public static bool CheckIfEventBelongsToLoggedInUser(int eventid)
        {
            MySqlConnection con;
            bool result = false;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select ownerID from event where id="+eventid+"";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader.GetInt32(0).Equals(returnUsersIDWhenIsLogedIn(UIs.Sidebars.ProfileSidebar.Instance.usernameLable.Text)))
                    {
                        result = true;
                    }
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!");
            }

            return result;
        }

    }
}
