namespace UIA.Framework.Elements
{
    using System.Windows;
    using System.Windows.Automation;
    using System.Windows.Automation.Text;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.ToolTip"/>.
    /// </summary>
    public class ToolTip : Element, IToolTip
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.ToolTip"/>.</param>
        public ToolTip(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public WindowInteractionState InteractionState => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.WindowInteractionState;

        /// <inheritdoc/>
        public bool IsModal => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.IsModal;

        /// <inheritdoc/>
        public bool IsTopmost => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.IsTopmost;

        /// <inheritdoc/>
        public bool Maximizable => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.CanMaximize;

        /// <inheritdoc/>
        public bool Minimizable => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.CanMinimize;

        /// <inheritdoc/>
        public WindowVisualState VisualState => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.WindowVisualState;

        /// <inheritdoc/>
        public TextPatternRange DocumentRange => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).DocumentRange;

        /// <inheritdoc/>
        public SupportedTextSelection SupportedTextSelection => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).SupportedTextSelection;

        /// <inheritdoc/>
        public void Close() => ActionHandler.Perform(() => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).Close());

        /// <inheritdoc/>
        public TextPatternRange[] GetSelection() => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).GetSelection());

        /// <inheritdoc/>
        public TextPatternRange[] GetVisibleRanges() => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).GetVisibleRanges());

        /// <inheritdoc/>
        public TextPatternRange RangeFromChild(AutomationElement childElement) => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).RangeFromChild(childElement));

        /// <inheritdoc/>
        public TextPatternRange RangeFromPoint(Point screenLocation) => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).RangeFromPoint(screenLocation));

        /// <inheritdoc/>
        public void SetVisualState(WindowVisualState state) => ActionHandler.Perform(() => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).SetWindowVisualState(state));

        /// <inheritdoc/>
        public bool WaitForInputIdle(int milliseconds) => ActionHandler.Perform(() => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).WaitForInputIdle(milliseconds));
    }
}