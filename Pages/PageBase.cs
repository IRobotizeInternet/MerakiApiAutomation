using MerakiApiAutomation.Settings;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.IO;

namespace MerakiApiAutomation.Pages
{
    public abstract class PageBase
    {
        private static IDriver _driver;
        protected static IDriver Driver
        {
            get
            {
                if (_driver != null) return _driver;
                InitPageBase();
                return _driver;
            }
        }
        public static void InitPageBase()
        {
            string appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "app-debug.apk");
            var appCapabilities = new AppiumOptions();
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Android 29");
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
            appCapabilities.AddAdditionalCapability("chromedriverExecutable", ".");
            appCapabilities.AddAdditionalCapability(AndroidMobileCapabilityType.AppWaitActivity, "com.meraki.*");
            _driver = (IDriver)Activator.CreateInstance(
                Type.GetType("MerakiApiAutomation.Settings.AndroidDriverWrapper"), 
                args: new object[] { 
                        new Uri("http://127.0.0.1:4723"), 
                        appCapabilities 
                }
            );
        }
    }
}
