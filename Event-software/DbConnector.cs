using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dbstuff
{
    public class DbConnector
    {
        string conStr = "Server=127.0.0.1;Database=it_happens;Uid=root;Pwd=root;";
        MySqlConnection con;

        public DbConnector()
        {


            try
            {
                Console.WriteLine(conStr);
                con = new MySqlConnection(conStr);
                con.Open();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
        }

        MySqlDataReader doit(string query)
        {

            return new MySqlCommand(query, con).ExecuteReader();
        }


        public string GetConnectionString()
        {
            return conStr;
        }


    }


}
