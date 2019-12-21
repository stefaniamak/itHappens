using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itHappens.Classes
{
    class Event
    {
        public int id { get; set; }
        public int ownerID { get; set; }
        public int venueID { get; set; }
        public int categoryID { get; set; }
        public DateTime startingDate { get; set; }
        public DateTime endingDate { get; set; }
        public string description { get; set; }
        public string tags { get; set; }
        public double ticketprice { get; set; }

        public Event (int id_, int ownerID_, int venueID_, int categoryID_, DateTime startingDate_, DateTime endingDate_, string description_, string tags_, double ticketprice_)
        {
		    this.id = id_;
		    this.ownerID = ownerID_;
		    this.venueID = venueID_;
		    this.categoryID = categoryID_;
		    this.startingDate = startingDate_;
		    this.endingDate = endingDate_;
		    this.description = description_;
		    this.tags = tags_;
		    this.ticketprice = ticketprice_;
        }

    }
}
