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


    }
}
