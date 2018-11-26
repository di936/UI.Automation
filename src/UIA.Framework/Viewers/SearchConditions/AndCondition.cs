using System.Windows.Automation;

namespace UIA.Framework.Viewers.SearchConditions
{
    public class AndCondition : PropertyCondition
    {
        public AndCondition(string value) : base(AutomationElement.ControlTypeProperty, value)
        {

        }
    }
}
