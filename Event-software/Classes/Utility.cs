using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itHappens.Classes
{
    class Utility
    {
        
        //Oles oi methodoi na  einai static
        public static string Month(DateTime Date )
        {
            string[] months = new string[] { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
           int month = Int32.Parse(Date.ToString("MM"));
            return months[month--];
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

    }
}
