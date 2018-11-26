using System.Windows.Automation;

namespace UIA.Framework.Viewers.SearchConditions
{
    public class ControlTypeCondition : PropertyCondition
    {
        public ControlTypeCondition(string value) : base(AutomationElement.ControlTypeProperty, value)
        {

        }
    }
}
