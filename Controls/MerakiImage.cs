using MerakiApiAutomation.Settings;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MerakiApiAutomation.Controls
{
    public class MerakiImage : ControlBase
    {
        public MerakiImage(IDriver driver, string id, AppiumWebElement parentElement = null) : base(driver, id, parentElement)
        {

        }
    }
}
