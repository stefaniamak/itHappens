using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbstuff;

namespace itHappens.Classes
{
    class CreateList
    {


        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();

        public static void createEvent_ListMethod(String Etitle, int EcreatorID)
        {
            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand cmd = con.CreateCommand(); ;

                String query = "INSERT INTO event_list(title,creatorID) VALUES(@title,@creatorID)";

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@title", Etitle);
                cmd.Parameters.AddWithValue("@creatorID", EcreatorID);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                Console.WriteLine("Error Insert Statement");
            }
        }


    }
}
