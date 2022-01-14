using MerakiApiAutomation.Settings;
using OpenQA.Selenium.Appium;

namespace MerakiApiAutomation.Controls
{
    public abstract class ControlBase
    {
        public AppiumWebElement Element; 
        public ControlBase(IDriver driver, string id, AppiumWebElement parentElement = null)
        {
            Element = parentElement != null 
                ? parentElement.FindElementById(id) 
                :  driver.FindElementById(id);
        }

        public string Text => Element.Text;
    }
}
