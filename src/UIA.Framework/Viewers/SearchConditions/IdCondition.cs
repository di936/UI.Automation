using System.Windows.Automation;

namespace UIA.Framework.Viewers.SearchConditions
{
    /// <summary>
    /// <see cref="PropertyCondition"/> for <see cref="AutomationElement"/> ID property
    /// </summary>
    public class IdCondition : PropertyCondition
    {
        /// <param name="value">Automation element ID property</param>
        public IdCondition(string value) : base(AutomationElement.AutomationIdProperty, value)
        {

        }
    }
}