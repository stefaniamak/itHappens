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
        string conStr = "Server=127.0.0.1;Database=it_happens;Uid=root;Pwd=0dinth0rz3us;";
        MySqlConnection con;

        public Db_connector()
        {
            try
            {
                con = new MySqlConnection(conStr);
                con.Open();
            }
            catch(Exception e) {
                Console.WriteLine("Error");
            }
        }

        MySqlDataReader doit (string query)
        {
            
            return new MySqlCommand(query, con).ExecuteReader();
        }
    }
    
    
}
