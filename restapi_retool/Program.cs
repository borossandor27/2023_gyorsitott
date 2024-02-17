using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace restapi_retool
{
    internal static class Program
    {
        /// <summary>
        /// 
        /// GUI application for REST API testing
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {

            //readAllConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        /***
         * App.config file is used to store the configuration settings for the application.
         * bővebben: https://docs.microsoft.com/en-us/dotnet/api/system.configuration.configurationmanager.appsettings?view=netframework-4.8
         */
        private static void readAllConfig()
        {
            //-- 
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                if (appSettings.Count == 0)
                {
                    Console.WriteLine("Nincs beállítás a konfigurációs fájlban!");
                    Console.ReadLine();
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {

                Console.WriteLine("Hiba a konfigurációs fájl olvasásakor!");
                Console.ReadLine();
            }

        }
    

    }
}
