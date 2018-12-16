namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Calendar"/>.
    /// </summary>
    public class CheckBox : Element, ICheckBox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBox"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Calendar"/></param>
        public CheckBox(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public ToggleState ToggleState => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Current.ToggleState;

        /// <inheritdoc/>
        public void Toggle() => ActionHandler.Perform(() => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Toggle());
    }
}