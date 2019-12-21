using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itHappens.Classes
{
    class Venue
    {
        public int id { get; set; }
        public int accID { get; set; }
        public int areaID { get; set; }
        public string name { get; set; }
        public double capacity { get; set; }

        public Venue(int id_, int accID_, int areaID_, string name_, double capacity_)
        {
            this.id = id_;
            this.accID = accID_;
            this.areaID = areaID_;
            this.name = name_;
            this.capacity = capacity_;
        }

    }
}
