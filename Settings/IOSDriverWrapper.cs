using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.IO;

namespace MerakiApiAutomation.Settings
{
    public class IOSDriverWrapper : IOSDriver<IOSElement>, IDriver<IOSElement>
    {

        private static IOSDriver<IOSElement> _driver;

        public static IOSDriver<IOSElement> Get()
        {
            if (_driver != null) return _driver;

            string testAppPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "TestApp.app.zip");
            var appCapabilities = new AppiumOptions();
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone 6");
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "11.3");
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.App, testAppPath);
            _driver = new IOSDriver<IOSElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appCapabilities);
            return _driver;
        }

        public void PressKeyCode()
        {
            Navigate().Back();
        }

        public IOSDriverWrapper(Uri remoteAddress, AppiumOptions appCapabilities) : base(remoteAddress, appCapabilities)
        {

        }
    }
}
