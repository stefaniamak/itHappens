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
        public List<EventMiniView> TodaysEvents = new List<EventMiniView>();
        public todayEventsCarousel()
        {
            
            MySqlDataReader reader = Db_connector.ActiveEvents();
            List<List<string>> Events = Db_connector.Readrows(reader,new int[] { 0 , 1, 2 });
         
            for (int i = 0; i < Events.Count; i++){
            EventMiniView obj = new EventMiniView(Events [i][2], Int32.Parse(Events[i][0]),Events [i][1]);
                TodaysEvents.Add(obj);

            }

        }




    }
}
