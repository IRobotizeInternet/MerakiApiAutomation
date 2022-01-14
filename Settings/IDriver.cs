using OpenQA.Selenium.Appium;
using System.Collections.ObjectModel;

namespace MerakiApiAutomation.Settings
{

    public interface IDriver
    {
        public AppiumWebElement FindElementById(string id);
        public ReadOnlyCollection<AppiumWebElement> FindElementsById(string id);
        public void PressKeyCode(int keycode);
    }
}
