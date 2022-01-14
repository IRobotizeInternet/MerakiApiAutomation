using System.Configuration;

namespace MerakiApiAutomation.Settings
{
    public class AppSettings
    {
        public static string IPAddress { get; set; }
        public static string Port { get; set; }
        public static string PlatfromType { get; set; }
        public static string AppName { get; set; }
        public static string PlatformName { get; set; }
        public static string DeviceName { get; set; }


        /// <summary>
        /// Initializes static members of the <see cref="AppSettings"/> class.
        /// </summary>
        static AppSettings()
        {
            IPAddress = ConfigurationManager.AppSettings[nameof(IPAddress)];
            Port = ConfigurationManager.AppSettings[nameof(Port)];
            PlatfromType = ConfigurationManager.AppSettings[nameof(PlatfromType)];
            AppName = ConfigurationManager.AppSettings[nameof(AppName)];
            PlatformName = ConfigurationManager.AppSettings[nameof(PlatformName)];
            DeviceName = ConfigurationManager.AppSettings[nameof(DeviceName)];
        }
    }
}
