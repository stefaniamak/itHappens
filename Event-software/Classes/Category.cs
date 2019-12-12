using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itHappens.Classes
{
    class Category
    {
        public int id { get; set; }
        public string categories { get; set; }
        public int parent { get; set; }

        public Category(int id_, string categories_, int parent_)
        {
            this.id = id_;
            this.categories = categories_;
            this.parent = parent_;
        }

    }
}
