using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbstuff;
using eventful;

namespace itHappens
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EventfulAPI eventful = new EventfulAPI();
            
            // Add Location & Number of Results
            // Add Month otherwise default month is January
            eventful.GetXmlData("Greece",20);
            //EventsFromCities getCities = new EventsFromCities();
          

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new UIs.SampleForm());
            Application.Run(new UIs.Common.MainSplitForm());

            //Application.Run(new LogEvents());


        }
    }
}
