using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itHappens.DBs
{
    class TestDataClass
    {

        static Classes.User[] tableUser = new Classes.User[2];
        static Classes.Event[] eventTable = new Classes.Event[2];
        static Classes.Category[] catTable = new Classes.Category[2];

        public static void FillUserTable()
        {
            
            Classes.User us1 = new Classes.User(1, 1, "Antonis78", "antonakis78", "antonis78@gmail.com", "Antonis", "Papamixalis", 35);
            Classes.User us2 = new Classes.User(2, 2, "Maria47", "maraki47", "maria47@gmail.com", "Maria", "Antonopoulou", 27);

            tableUser[0] = us1;
            tableUser[1] = us2;
        }

        public static void FillEvents()
        {
            DateTime e1 = new DateTime(2019, 12, 15);
            DateTime e2 = new DateTime(2019, 12, 16);
            DateTime e3 = new DateTime(2019, 12, 17);
            DateTime e4 = new DateTime(2019, 12, 18);

            Classes.Event ev1 = new Classes.Event(1, 1, 1, 1, e1, e2, "First Event", "#firstEvent", 0.0);
            Classes.Event ev2 = new Classes.Event(2, 2, 2, 2, e3, e4, "Second Event", "#secondEvent", 1.0);

            eventTable[0] = ev1;
            eventTable[1] = ev2;
        }

        public static void FillCategory()
        {
            Classes.Category cat1 = new Classes.Category(1, "Music", 0);
            Classes.Category cat2 = new Classes.Category(2, "Sport",1);

            catTable[0] = cat1;
            catTable[1] = cat2;
        }

    }
}
