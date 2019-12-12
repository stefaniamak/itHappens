using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itHappens.Classes
{
    class EventList
    {
        public int id { get; set; }
        public string title { get; set; }
        public int creatorID { get; set; }

        public EventList(int id_, string title_, int creatorID_)
        {
            this.id = id_;
            this.title = title_;
            this.creatorID = creatorID_;
        }

    }
}
