using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace MerakiApiAutomation.Settings
{
    public class AndroidDriverWrapper : AndroidDriver<AndroidElement>, IDriver
    {
        public static AndroidDriverWrapper Driver;
        //private static AndroidDriverWrapper Get()
        //{
        //    if (Driver != null) return Driver;
        //    string appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "app-debug.apk");
        //    var appCapabilities = new AppiumOptions();
        //    appCapabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
        //    appCapabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Android 29");
        //    appCapabilities.AddAdditionalCapability(MobileCapabilityType.App, appPath);
        //    appCapabilities.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
        //    appCapabilities.AddAdditionalCapability("chromedriverExecutable", ".");
        //    appCapabilities.AddAdditionalCapability(AndroidMobileCapabilityType.AppWaitActivity, "com.meraki.*");
        //    return new AndroidDriverWrapper(new Uri("http://127.0.0.1:4723"), appCapabilities);
        //}

        public void PressKeyCode(int keycode)
        {
            //base.PressKeyCode(keycode);
        }

        public AppiumWebElement FindElementById(string id)
        {
            return base.FindElementById(id);
        }

        public ReadOnlyCollection<AppiumWebElement> FindElementsById(string id)
        {
            var elements = base.FindElementsById(id).ToList<AppiumWebElement>();
            return new ReadOnlyCollection<AppiumWebElement>(elements);
        }

        public AndroidDriverWrapper(Uri remoteAddress, AppiumOptions appCapabilities) : base (remoteAddress, appCapabilities)
        {

        }
        
    }
}
