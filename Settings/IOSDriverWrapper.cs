using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace MerakiApiAutomation.Settings
{
    public class IOSDriverWrapper : IDriver
    {
        public static IOSDriverWrapper Get()
        {
            string testAppPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "filePath");
            var appCapabilities = new AppiumOptions();
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone 6");
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "11.3");
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.App, testAppPath);
            return new IOSDriverWrapper(new Uri("http://127.0.0.1:4723"), appCapabilities);
        }

        public void PressKeyCode(int keycode)
        {
            //Navigate().Back();
        }

        public AppiumWebElement FindElementById(string id)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<AppiumWebElement> FindElementsById(string id)
        {
            throw new NotImplementedException();
        }

        public IOSDriverWrapper(Uri remoteAddress, AppiumOptions appCapabilities)
        {

        }
    }
}
