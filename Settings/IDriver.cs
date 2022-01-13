using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using System.Text;

namespace MerakiApiAutomation.Settings
{
    public interface IDriver<W>
    {
        public W FindElement(By by);
        public W FindElement(string by, string value);
        public W FindElementByAccessibilityId(string selector);
        public W FindElementByClassName(string className);
        public W FindElementByCssSelector(string cssSelector);
        public W FindElementById(string id);
        public W FindElementByImage(string base64Template);
        public W FindElementByLinkText(string linkText);
        public W FindElementByName(string name);
        public W FindElementByPartialLinkText(string partialLinkText);
        public W FindElementByTagName(string tagName);
        public W FindElementByXPath(string xpath);
        public void PressKeyCode();
    }
}
