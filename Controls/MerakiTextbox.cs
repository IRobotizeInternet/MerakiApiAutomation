using MerakiApiAutomation.Settings;

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
