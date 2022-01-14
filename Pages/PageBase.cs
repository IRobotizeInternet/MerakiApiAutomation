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
                _driver = AppiumServerUtil.GetDriver();
                return _driver;
            }
        }
    }
}
