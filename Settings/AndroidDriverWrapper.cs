using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.IO;

namespace MerakiApiAutomation.Settings
{
    public class AndroidDriverWrapper : AndroidDriver<AndroidElement>, IDriver<AndroidElement>
    {
        public static AndroidDriverWrapper Get()
        {
            string appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "app-debug.apk");
            var appCapabilities = new AppiumOptions();
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Android 29");
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
            appCapabilities.AddAdditionalCapability("chromedriverExecutable", ".");
            appCapabilities.AddAdditionalCapability(AndroidMobileCapabilityType.AppWaitActivity, "com.meraki.*");
            return new AndroidDriverWrapper(new Uri("http://127.0.0.1:4723"), appCapabilities);
        }

        public void PressKeyCode()
        {
            PressKeyCode(AndroidKeyCode.Back);
        }

        public AndroidDriverWrapper(Uri remoteAddress, AppiumOptions appCapabilities) : base(remoteAddress, appCapabilities)
        {

        }
        
    }
}
