namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Button"/>.
    /// </summary>
    public class Button : Element, IButton
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Button"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Button"/>.</param>
        public Button(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public ToggleState ToggleState => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Current.ToggleState;

        /// <inheritdoc/>
        public ExpandCollapseState ExpandCollapseState => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Current.ExpandCollapseState;

        /// <inheritdoc/>
        public void Invoke() => ActionHandler.Perform(() => ((InvokePattern)this.GetCurrentPattern(InvokePattern.Pattern)).Invoke());

        /// <inheritdoc/>
        public void Expand() => ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Expand());

        /// <inheritdoc/>
        public void Collapse() => ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Collapse());

        /// <inheritdoc/>
        public void Toggle() => ActionHandler.Perform(() => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Toggle());
    }
}