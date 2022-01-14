using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace MerakiApiAutomation.Settings
{
    public class AppSettings
    {
        public static string IPAddress { get; set; }
        public static string Port { get; set; }
        public static string PlatfromType { get; set; }

        /// <summary>
        /// Initializes static members of the <see cref="AppSettings"/> class.
        /// </summary>
        static AppSettings()
        {
            IPAddress = ConfigurationManager.AppSettings[nameof(IPAddress)];
            Port = ConfigurationManager.AppSettings[nameof(Port)];
            PlatfromType = ConfigurationManager.AppSettings[nameof(PlatfromType)];
        }
    }
}
