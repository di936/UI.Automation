using System.Windows.Automation;
using UIA.Framework.Configuration;
using UIA.Framework.Elements.Patterns.ElementPatterns;

namespace UIA.Framework.Elements
{
    public class CheckBox : Element, ICheckBox
    {
        public ToggleState ToggleState => ((TogglePattern)RawElement.GetCurrentPattern(TogglePattern.Pattern)).Current.ToggleState;

        public CheckBox(AutomationElement element) : base(element)
        {
            
        }

        public void Toggle()
        {
            ActionHandler.Perform(() => ((TogglePattern)RawElement.GetCurrentPattern(TogglePattern.Pattern)).Toggle());
        }
    }
}