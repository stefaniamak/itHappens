using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itHappens.Classes
{
    class User
    {
        public int id { get; set; }
        public int areaID { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

        public User(int id_, int areaID_, string Username_, string password_, string email_, string name_, string surname_, int age_)
        {
            this.id = id_;
            this.areaID = areaID_;
            this.Username = Username_;
            this.password = password_;
            this.email = email_;
            this.name = name_;
            this.surname = surname_;
            this.age = age_;
        }

    }
}
