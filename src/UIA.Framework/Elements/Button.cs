using System.Windows.Automation;
using UIA.Framework.Configuration;
using UIA.Framework.Elements.Patterns.ElementPatterns;

namespace UIA.Framework.Elements
{
    public class Button : Element, IButton
    {
        public ToggleState ToggleState => ((TogglePattern)RawElement.GetCurrentPattern(TogglePattern.Pattern)).Current.ToggleState;

        public ExpandCollapseState ExpandCollapseState => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Current.ExpandCollapseState;

        public Button(AutomationElement element) : base(element)
        {

        }

        public void Invoke()
        {
            ActionHandler.Perform(() => ((InvokePattern)RawElement.GetCurrentPattern(InvokePattern.Pattern)).Invoke());
        }

        public void Toggle()
        {
            ActionHandler.Perform(() => ((TogglePattern)RawElement.GetCurrentPattern(TogglePattern.Pattern)).Toggle());
        }

        public void Expand()
        {
            ActionHandler.Perform(() => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Expand());
        }

        public void Collapse()
        {
            ActionHandler.Perform(() => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Collapse());
        }
    }
}
