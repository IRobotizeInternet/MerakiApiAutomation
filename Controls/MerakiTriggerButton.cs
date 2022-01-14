using MerakiApiAutomation.Pages;
using MerakiApiAutomation.Settings;
using System;
using System.Threading;

namespace MerakiApiAutomation.Controls
{
    public class MerakiTriggerButton<EventResult> : ControlBase where EventResult : PageBase
    {
        public MerakiTriggerButton(IDriver driver, string id) : base(driver, id)
        {
        }

        public EventResult Click()
        {
            // TODO: We need to think about this things in future, othere it will cause significant delay. 
            // setting it to sleep for demo purpose only.
            Element.Click();
            Thread.Sleep(7000);
            return (EventResult)Activator.CreateInstance(typeof(EventResult));
        }

    }
}
