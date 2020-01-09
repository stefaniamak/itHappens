using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace itHappends
{
    public class Db_connector
    {
        public static MySqlDataReader connection()
        {

            return Query(@"SELECT COUNT(*) FROM area WHERE country = @country",
                                   new string[,] { { "@country", "Greece" } });

        }
        public static MySqlConnection Connect()
        {
            String conStr = "Server=127.0.0.1;Database=it_happens;Uid=root;Pwd=0dinth0rz3us;";
            MySqlConnection con;
            con = new MySqlConnection(conStr);
            con.Open();
            return con;
        }
        public static MySqlDataReader Query(string query, string[,] parameters)
        {
            var Command = new MySqlCommand(query, Connect());
            for (int i = 0; i < parameters.GetLength(0); i++)
            {
                Command.Parameters.AddWithValue(parameters[i, 0], parameters[i, 1]);
            }
            return Command.ExecuteReader();

        }

        public static MySqlDataReader ActiveEvents ()
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd HH:mm:ss");

            return Query(@"SELECT * FROM event WHERE startingDate < @Date AND endingDate  > @Date ",
                                   new string[,] { { "@Date", sqlFormattedDate } });
        }

        public static List<List<string>> Readrows (MySqlDataReader reader , int[] parameters)
        {
           
            List<List<string>> collumns = new List<List<string>>();
            while (reader.Read())
            {
                List<string> rows = new List<string>();

                foreach (int i in parameters)
                {               
                    rows.Add(reader.GetString(i));
                }
               collumns.Add(rows);
            }

            return collumns;
        }
        public static MySqlDataReader Categories(int limit)
        {
            return Query(@"Select categories FROM categories LIMIT @limit",new string[,] { { "@limit", limit + "" } });
        }
    }
    //String sql = " ";
    //sql = "Insert into event(id,onwerID,venueID,categoryID,startingDate,EndingDate,description,tags,ticketprice) values('"id" + "ownerID" + "venueID" + "categoryID" + "startingDate" + "endingDate" + "description" + "tags" + "ticketprice"')";
    //sql = "Insert into venues(id,accID,areaID,name,capacity) values('"id" + "accID" + "areaID" + "name" + "capacity"')";
    //sql = "Insert into area(id,contiment,country,city,zip_code,address) values('"id" + "contiment" + "country" + "city" + "zip_code" + "address"')";


}
