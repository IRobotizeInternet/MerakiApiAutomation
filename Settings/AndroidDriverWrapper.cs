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
        
        public void PressKeyCode(int keycode)
        {
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
