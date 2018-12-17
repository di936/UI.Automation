namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Custom"/>.
    /// </summary>
    public class Custom : Element, ICustom
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Custom"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Custom"/></param>
        public Custom(AutomationElement element)
            : base(element)
        {
        }
    }
}