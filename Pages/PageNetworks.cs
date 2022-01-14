using MerakiApiAutomation.Controls;
using MerakiApiAutomation.Settings;
using OpenQA.Selenium.Appium;
using System.Collections.Generic;
using System.Linq;

namespace MerakiApiAutomation.Pages
{
    public class PageNetworks : PageBase
    {
        private IReadOnlyCollection<AppiumWebElement> Items = Driver.FindElementsById("com.meraki.mapidemo:id/user_list_item");
        public MerakiLabel LabelTitle = new MerakiLabel(Driver, "com.meraki.mapidemo:id/toolbar");
        public List<Network> Networks()
        {
            var networks = new List<Network>();
            foreach(var item in Items) networks.Add(new Network(Driver, item));

            return networks;
        }

        public bool CheckNetworkExist(string name) => Items.Where(item => item.Text == name) != null;

        public PageNetworks(){}

        public class Network
        {
            public MerakiLabel LabelDeviceDetails;
            public MerakiLabel LabelDeviceName;
            public MerakiImage ImageDeviceIcon;

            public Network(IDriver driver, AppiumWebElement parentElement)
            {
                ImageDeviceIcon = new MerakiImage(driver, "com.meraki.mapidemo:id/deviceName", parentElement);
                LabelDeviceName = new MerakiLabel(driver, "com.meraki.mapidemo:id/deviceName", parentElement);
                LabelDeviceDetails = new MerakiLabel(driver, "com.meraki.mapidemo:id/deviceDetails", parentElement);
            }
        }
    }
}
