using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Diagnostics;
using System.IO;

namespace MerakiApiAutomation.Settings
{
    public class AppiumServerUtil
    {
        public bool IsAppiumRunning { get; private set; }

        public static void StartAppium()
        {
            // Check whether the environment variable exists.
            var value = Environment.GetEnvironmentVariable("ANDROID_HOME");

            // If necessary, create it.
            // This could also be set through setting, for the purpose of demo hard coding it.
            if (value == null) Environment.SetEnvironmentVariable("ANDROID_HOME", @"C:\Users\alir2t2\AppData\Local\Android\Sdk");

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/C Appium -a {AppSettings.IPAddress} -p {AppSettings.Port} --allow-cors --base-path=/";
            process.Start();
        }

        public static IDriver GetDriver()
        {
            StartAppium();

            string appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", AppSettings.AppName);
            var appCapabilities = new AppiumOptions();
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, AppSettings.PlatformName);
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, AppSettings.DeviceName);
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
            appCapabilities.AddAdditionalCapability("chromedriverExecutable", ".");
            appCapabilities.AddAdditionalCapability(AndroidMobileCapabilityType.AppWaitActivity, "com.meraki.*");
            return (IDriver)Activator.CreateInstance(
                Type.GetType(AppSettings.PlatfromType),
                args: new object[] {
                        new Uri($"http://{AppSettings.IPAddress}:{AppSettings.Port}"),
                        appCapabilities
                }
            );
        }
    }
}
