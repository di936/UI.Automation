namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.TitleBar"/>.
    /// </summary>
    public class TitleBar : Element, ITitleBar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TitleBar"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.TitleBar"/>.</param>
        public TitleBar(AutomationElement element)
            : base(element)
        {
        }
    }
}