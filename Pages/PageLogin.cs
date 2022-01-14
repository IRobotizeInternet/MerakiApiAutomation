using MerakiApiAutomation.Controls;

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
