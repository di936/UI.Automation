using System.Windows.Automation;
using UIA.Framework.Helpers;

namespace UIA.Framework.Elements
{
    public class Button : Element
    {
        public Button(AutomationElement element) : base(element)
        {

        }

        public void Invoke(int ms = 0)
        {
            Wait.Milliseconds(100);
            ((InvokePattern)RawElement.GetCurrentPattern(InvokePattern.Pattern)).Invoke();
        }
    }
}
