using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itHappens.Classes;
using MySql.Data.MySqlClient;

namespace itHappends
{
    public class Db_connector
    {
        public static MySqlDataReader connection()
        {

            return ExecuteQuery(@"SELECT COUNT(*) FROM area WHERE country = @country",
                                   new MySqlParameter("@country", "Greece"));

        }
        public static MySqlConnection Connect()
        {
            String conStr = "Server=127.0.0.1;Database=it_happens;Uid=root;Pwd=123456Steph;";
            MySqlConnection con;
            con = new MySqlConnection(conStr);
            con.Open();
            Console.WriteLine("CONNECTED DATABASE VERSION: " + con.ServerVersion);
            return con;
        }
        public static MySqlDataReader ExecuteQuery(string query, MySqlParameter parameter)
        {
            return ExecuteQuery(query, new[] { parameter });
        }
        public static MySqlDataReader ExecuteQuery(string query, MySqlParameter[] parameters)
        {
            try
            {
                var Command = new MySqlCommand(query, Connect());
                // Hack cause it throws an exeption when using the Add function... Something about incompatible MySql versions
                foreach (var parameter in parameters)
                    Command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);


                return Command.ExecuteReader();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("My SQL Error: " + e.Message);
                return null;
            }



        }

        public static MySqlDataReader ActiveEvents()
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);

            return ExecuteQuery(@"SELECT event.id, event.title, categories.color, event.image FROM event JOIN categories ON categories.id = event.categoryID WHERE startingDate >= @Today AND startingDate < @Tomorrow ",
                                  new[] { new MySqlParameter("@Today", today), new MySqlParameter("@Tomorrow", tomorrow) });
        }

        public static List<List<string>> Readrows(MySqlDataReader reader, int[] parameters)
        {

            List<List<string>> collumns = new List<List<string>>();
            while (reader.Read())
            {
                List<string> rows = new List<string>();

                foreach (int i in parameters)
                {
                    rows.Add(reader.IsDBNull(i) ? "" : reader.GetString(i));
                }
                collumns.Add(rows);
            }

            return collumns;
        }
        public static MySqlDataReader Categories(int limit)
        {
            return ExecuteQuery(@"Select title, color FROM categories LIMIT @limit",
                        new MySqlParameter("@limit", limit));
        }

        public static MySqlDataReader GetEvent(int id)
        {
            return ExecuteQuery(@"Select * FROM event WHERE id = @id "
                        , new MySqlParameter("@id", id));
        }


    }
    //String sql = " ";
    //sql = "Insert into event(id,onwerID,venueID,categoryID,startingDate,EndingDate,description,tags,ticketprice) values('"id" + "ownerID" + "venueID" + "categoryID" + "startingDate" + "endingDate" + "description" + "tags" + "ticketprice"')";
    //sql = "Insert into venues(id,accID,areaID,name,capacity) values('"id" + "accID" + "areaID" + "name" + "capacity"')";
    //sql = "Insert into area(id,contiment,country,city,zip_code,address) values('"id" + "contiment" + "country" + "city" + "zip_code" + "address"')";


}
