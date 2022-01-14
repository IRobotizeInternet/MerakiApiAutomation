using MerakiApiAutomation.Settings;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace MerakiApiAutomation.Controls
{
    public class MerakiTextbox : ControlBase
    {
        public MerakiTextbox(IDriver driver, string id) : base(driver, id)
        {
        }

        public void SetText(string text)
        {
            Element.SendKeys(text);
        }
    }
}
