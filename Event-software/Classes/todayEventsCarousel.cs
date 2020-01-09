using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itHappends;
using itHappens.UIs.Common;
using MySql.Data.MySqlClient;

namespace itHappens.Classes
{
    class todayEventsCarousel
    {
        List<EventMiniView> TodaysEvents;
        public todayEventsCarousel()
        {

            for (int i = 0; i < 5; i++){

                TodaysEvents.Add  (new EventMiniView("Red"));

            }

           // MySqlDataReader reader = Db_connector.ActiveEvents();
           // Db_connector.Readrows(reader,new int[] { 0, 1, 2 });
        }
     
        


    }
}
