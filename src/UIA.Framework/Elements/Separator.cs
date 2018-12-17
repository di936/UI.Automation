namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Separator"/>.
    /// </summary>
    public class Separator : Element, ISeparator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Separator"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Separator"/>.</param>
        public Separator(AutomationElement element)
            : base(element)
        {
        }
    }
}