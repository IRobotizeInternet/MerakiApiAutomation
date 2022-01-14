using MerakiApiAutomation.Controls;
using MerakiApiAutomation.Settings;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;

namespace MerakiApiAutomation.Pages
{
    public class PageLogin : PageBase
    {
        public PageLogin()
        {
        }

        public MerakiTextbox TextboxAPIKey = 
            new MerakiTextbox(Driver, "com.meraki.mapidemo:id/apiKeyTxt");

        public MerakiTriggerButton<PageNetworks> ButtonGo = 
            new MerakiTriggerButton<PageNetworks>(Driver, "com.meraki.mapidemo:id/goButton");
    }
}
