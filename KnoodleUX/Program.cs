using DataLayer.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KnoodleUX
{
    static class Program
    {
        public static Job ActiveJob;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Application.Run(new MainForm());
            //Application.Run(new MAIN());
        }

    

        private static void CurrentDomainOnUnhadledException(object sender, UnhandledExceptionEventArgs e)
        {
            var message = String.Format("Sorry, something went wrong.\r\n" +
               "{0}\r\n" +
               "Please contact support at ext 106",
               ((Exception)e.ExceptionObject).Message);

            Console.WriteLine("ERROR {0}: {1}",
                DateTimeOffset.Now, e.ExceptionObject);

            MessageBox.Show(message, "Unexpected Error");
        }

        private static void ApplicationOnThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            var message = String.Format("Sorry, something went wrong.\r\n" +
                                        "{0}\r\n" +
                                        "Please contact support at ext 106",
                                        e.Exception.Message);

            Console.WriteLine("ERROR {0}: {1}",
                DateTimeOffset.Now, e.Exception);

            MessageBox.Show(message, "Unexpected Error");
        }
    }
}
