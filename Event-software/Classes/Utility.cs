using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itHappends;

namespace itHappens.Classes
{
    class Utility
    {
        
        //Oles oi methodoi na  einai static
        public static string Month(DateTime Date )
        {
            string[] months = new string[] { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
           int month = Int32.Parse(Date.ToString("MM"));
            return months[--month];
        }

        public static string Day (DateTime Date)
        {

           return Date.ToString("dd");
          
        }

        public static string DateToText(DateTime Date)
        {            
           return Date.ToString("yyyy-MM-dd HH:mm:ss");            
        }

        public static Color FromName(string colorName)
        {
            return Color.FromName(colorName);          
        }



        /*   public static List<int> searchEvents(string searchString,
                                        string country,
                                        DateTime date,
                                        int time,
                                        string organizer)
           {

               var organizerFullName = organizer.Split(' ');
               var reader = Db_connector.Query(@"select e.id, from events e
                                     join user u on e.creatorID = u.id
                                     where e.area = @country and
                                         e.date = @date and
                                         u.firstName = @firstname and
                                         u.lastname = @lastname
                                         e.title like @search",
                                           new string[,] { {"@country", country },
                                                   {"@date",DateToText(date) },
                                                   {"@firstname", organizerFullName[0]},
                                                   {"@lastname", organizerFullName[1]},
                                                   {"@search", "%" + searchString + "%"}});

               var events = Db_connector.Readrows(reader, new int [] { 0 });
               return events.Select(e => Int32.Parse(e[0])).ToList();

           }*/
    }
}
