using MerakiApiAutomation.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace MerakiApiAutomation.Pages
{
    public class PageNetworkDetails : PageBase
    {
        public MerakiLabel LabelModel = new MerakiLabel(Driver, "com.meraki.mapidemo:id/modelLabel");
        public MerakiLabel LabelSerial = new MerakiLabel(Driver, "com.meraki.mapidemo:id/serialLabel");
        public MerakiLabel LabelUsage = new MerakiLabel(Driver, "com.meraki.mapidemo:id/usageLabel");
        public MerakiLabel LabelnumClients = new MerakiLabel(Driver, "com.meraki.mapidemo:id/numClientsLabel");

        public MerakiLabel LabelModelValue = new MerakiLabel(Driver, "com.meraki.mapidemo:id/modelValue");
        public MerakiLabel LabelSerialValue = new MerakiLabel(Driver, "com.meraki.mapidemo:id/serialValue");
        public MerakiLabel LabelUsageValue = new MerakiLabel(Driver, "com.meraki.mapidemo:id/usageValue");
        public MerakiLabel LabelNumClientsValue = new MerakiLabel(Driver, "com.meraki.mapidemo:id/numClientsValue");
    }
}
