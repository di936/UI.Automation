namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.RadioButton"/>.
    /// </summary>
    public class RadioButton : Element, IRadioButton
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButton"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.RadioButton"/>.</param>
        public RadioButton(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public bool IsSelected => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).Current.IsSelected;

        /// <inheritdoc/>
        public AutomationElement SelectionContainer => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).Current.SelectionContainer;

        /// <inheritdoc/>
        public ToggleState ToggleState => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Current.ToggleState;

        /// <inheritdoc/>
        public void AddToSelection() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).AddToSelection());

        /// <inheritdoc/>
        public void RemoveFromSelection() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).RemoveFromSelection());

        /// <inheritdoc/>
        public void Select() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).Select());

        /// <inheritdoc/>
        public void Toggle() => ActionHandler.Perform(() => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Toggle());
    }
}