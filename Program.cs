using MerakiApiAutomation.Settings;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Service.Options;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace MerakiApiAutomation
{
    class Program
    {
        private static IOSDriver<IOSElement> _driverio;
        static void Main(string[] args)
        {

            // Check whether the environment variable exists.
            var value = Environment.GetEnvironmentVariable("ANDROID_HOME");
            
            // If necessary, create it.
            if (value == null) 
                Environment.SetEnvironmentVariable("ANDROID_HOME", @"C:\Users\alir2t2\AppData\Local\Android\Sdk");

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C Appium -a 127.0.0.1 -p 4723 --allow-cors --base-path=/";
            process.Start();



            var _driver = AndroidDriverWrapper.Get();
            var _driver = IOSDriverWrapper.Get();
            
            var element = _driver.FindElementById("com.meraki.mapidemo:id/apiKeyTxt");
            element.SendKeys("5da1735a6a6b1360986bb2c8c10ae2817e476244");
            _driver.FindElementById("com.meraki.mapidemo:id/goButton").Click();
            var title = _driver.FindElementById("com.meraki.mapidemo:id/toolbar");
            var listItems = _driver.FindElementsById("com.meraki.mapidemo:id/user_list_item");
            foreach (var item in listItems)
            {
                var currDeviceName = item.FindElementById("com.meraki.mapidemo:id/deviceName");
                var currDeviceDetails = item.FindElementById("com.meraki.mapidemo:id/deviceDetails");
                Console.WriteLine($"{currDeviceName.Text} | {currDeviceDetails.Text}");
                item.Click();
                var modelValue = _driver.FindElementById("com.meraki.mapidemo:id/modelValue");
                var serialValue = _driver.FindElementById("com.meraki.mapidemo:id/serialValue");
                var usageValue = _driver.FindElementById("com.meraki.mapidemo:id/usageValue");
                var numClientsValue = _driver.FindElementById("com.meraki.mapidemo:id/numClientsValue");
                Console.WriteLine($"{modelValue.Text} | {serialValue.Text} | {usageValue.Text} | {numClientsValue.Text}");
                _driver.PressKeyCode(AndroidKeyCode.Back);
                
            }
        }
    }
}
