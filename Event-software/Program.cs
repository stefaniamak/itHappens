using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using itHappends;

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
            Db_connector Alpha = new Db_connector();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new UIs.SampleForm());
            Application.Run(new UIs.Common.MainSplitForm());

            //Application.Run(new LogEvents());


        }
    }
}
