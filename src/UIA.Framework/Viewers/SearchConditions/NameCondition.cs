using System.Windows.Automation;

namespace UIA.Framework.Viewers.SearchConditions
{
    /// <summary>
    /// <see cref="PropertyCondition"/> for <see cref="AutomationElement"/> Name property
    /// </summary>
    internal class NameCondition : PropertyCondition
    {
        /// <param name="value">Automation element Name property</param>
        public NameCondition(string value) : base(AutomationElement.NameProperty, value)
        {
            
        }
    }
}