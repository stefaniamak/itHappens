using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itHappens.Classes
{
    class Area
    {
        public int id { get; set; }
        public string continent { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public int zip_code { get; set; }
        public string address { get; set; }

        public Area(int id_, string continent_, string country_, string city_, int zip_code_, string address_)
        {
            this.id = id_;
            this.continent = continent_;
            this.country = country_;
            this.city = city_;
            this.zip_code = zip_code_;
            this.address = address_;
        }

    }
}
