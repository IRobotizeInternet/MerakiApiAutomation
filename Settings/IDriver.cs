using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MerakiApiAutomation.Settings
{
    
    public interface IDriver
    {
        public AppiumWebElement FindElementById(string id);
        public ReadOnlyCollection<AppiumWebElement> FindElementsById(string id);
        public void PressKeyCode(int keycode);
    }
}
