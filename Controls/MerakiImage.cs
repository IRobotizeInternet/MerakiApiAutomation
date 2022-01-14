using MerakiApiAutomation.Settings;
using OpenQA.Selenium.Appium;

namespace MerakiApiAutomation.Controls
{
    public class MerakiImage : ControlBase
    {
        public MerakiImage(IDriver driver, string id, AppiumWebElement parentElement = null) : base(driver, id, parentElement)
        {

        }
    }
}
