using dbstuff;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itHappens.Controllers
{
    class UpcomingEventsController
    {
        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();

        public static bool UpcomingEventsMini(string eventTitle, string categoryLocation, string eventDate);
        {
            MySqlConnection con;
            string eventTitle = "";
            string categoryLocation = "";
            string eventDate = "";
        }
    }
}
