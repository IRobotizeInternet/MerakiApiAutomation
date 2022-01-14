using OpenQA.Selenium.Appium.iOS;
using System;
using System.Diagnostics;

namespace MerakiApiAutomation
{
    class Program
    {
        private static IOSDriver<IOSElement> _driverio;
        static void Main(string[] args)
        {

            //// Check whether the environment variable exists.
            //var value = Environment.GetEnvironmentVariable("ANDROID_HOME");
            
            //// If necessary, create it.
            //if (value == null) 
            //    Environment.SetEnvironmentVariable("ANDROID_HOME", @"C:\Users\alir2t2\AppData\Local\Android\Sdk");

            //Process process = new Process();
            //process.StartInfo.FileName = "cmd.exe";
            //process.StartInfo.Arguments = "/C Appium -a 127.0.0.1 -p 4723 --allow-cors --base-path=/";
            //process.Start();

            //IDriver<AndroidElement> _driver = AndroidDriverWrapper.Get();
            ////IDriver<IOSElement> _driver1 = IOSDriverWrapper.Get();
            
            //var element = _driver.FindElementById("com.meraki.mapidemo:id/apiKeyTxt");
            //element.SendKeys("");
            //_driver.FindElementById("com.meraki.mapidemo:id/goButton").Click();
            //var title = _driver.FindElementById("com.meraki.mapidemo:id/toolbar");
            //var listItems = _driver.FindElementsById("com.meraki.mapidemo:id/user_list_item");
            //foreach (var item in listItems)
            //{
            //    var currDeviceName = item.FindElementById("com.meraki.mapidemo:id/deviceName");
            //    var currDeviceDetails = item.FindElementById("com.meraki.mapidemo:id/deviceDetails");
            //    Console.WriteLine($"{currDeviceName.Text} | {currDeviceDetails.Text}");
            //    item.Click();
            //    var modelValue = _driver.FindElementById("com.meraki.mapidemo:id/modelValue");
            //    var serialValue = _driver.FindElementById("com.meraki.mapidemo:id/serialValue");
            //    var usageValue = _driver.FindElementById("com.meraki.mapidemo:id/usageValue");
            //    var numClientsValue = _driver.FindElementById("com.meraki.mapidemo:id/numClientsValue");
            //    Console.WriteLine($"{modelValue.Text} | {serialValue.Text} | {usageValue.Text} | {numClientsValue.Text}");
            //    _driver.PressKeyCode(AndroidKeyCode.Back);
                
            //}
        }
    }
}
