using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eventful;

namespace itHappens
{
    class EventsFromCities
    {
        EventfulAPI eventful = new EventfulAPI();

        public EventsFromCities()
        {
            List<string> citiesList = new List<string>();
            string txtPath = Application.StartupPath + "/Cities/cities.txt";
            foreach (string line in File.ReadLines(txtPath, Encoding.UTF8))
            {
                citiesList.Add(line);
            }

            string[] cities = citiesList.ToArray();
            Console.Write(cities);
            foreach (string city in cities)
            {
                eventful.GetXmlData(city, 200);
            }
        }

        
       
    }
}
