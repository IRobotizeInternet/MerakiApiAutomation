using MerakiApiAutomation.Settings;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MerakiApiAutomation.Controls
{
    public class MerakiLabel : ControlBase
    {
        public MerakiLabel(IDriver driver, string id, AppiumWebElement element = null) : base(driver, id, element)
        {

        }

        public void Click()
        {
            Element.Click();
        }
    }
}
