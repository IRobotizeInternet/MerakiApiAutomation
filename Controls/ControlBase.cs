using MerakiApiAutomation.Settings;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Collections.Generic;
using System.Text;

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
