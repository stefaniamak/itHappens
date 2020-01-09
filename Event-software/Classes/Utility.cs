using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itHappens.Classes
{
    class Utility
    {
        //Oles oi methodoi na  einai static
        public static string MonthToText(DateTime Date )
        {
            return Date.ToString("MM");
            
        }
        public static string DateToText(DateTime Date)
        {            
           return Date.ToString("yyyy-MM-dd HH:mm:ss");            
        }
    }
}
