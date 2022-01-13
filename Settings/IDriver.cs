using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MerakiApiAutomation.Settings
{
    public interface IDriver<W>
    {
        public W FindElement(By by);
        public W FindElement(string by, string value);
        public W FindElementByAccessibilityId(string selector);
        public W FindElementByClassName(string className);
        public W FindElementByCssSelector(string cssSelector);
        public W FindElementById(string id);
        public W FindElementByImage(string base64Template);
        public W FindElementByLinkText(string linkText);
        public W FindElementByName(string name);
        public W FindElementByPartialLinkText(string partialLinkText);
        public W FindElementByTagName(string tagName);
        public W FindElementByXPath(string xpath);
    }

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

        public AndroidDriverWrapper(Uri remoteAddress, AppiumOptions appCapabilities) : base(remoteAddress, appCapabilities)
        {

        }
        
    }

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

        public IOSDriverWrapper(Uri remoteAddress, AppiumOptions appCapabilities) : base(remoteAddress, appCapabilities)
        {

        }
    }
}
