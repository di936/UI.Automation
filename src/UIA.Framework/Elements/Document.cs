namespace UIA.Framework.Elements
{
    using System.Windows;
    using System.Windows.Automation;
    using System.Windows.Automation.Text;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Document"/>.
    /// </summary>
    public class Document : Element, IDocument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Document"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Document"/>.</param>
        public Document(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public bool HorizontallyScrollable => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontallyScrollable;

        /// <inheritdoc/>
        public double HorizontalScrollPercent => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalScrollPercent;

        /// <inheritdoc/>
        public double HorizontalViewSize => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalViewSize;

        /// <inheritdoc/>
        public bool VerticallyScrollable => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticallyScrollable;

        /// <inheritdoc/>
        public double VerticalScrollPercent => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalScrollPercent;

        /// <inheritdoc/>
        public double VerticalViewSize => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalViewSize;

        /// <inheritdoc/>
        public bool IsReadOnly => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).Current.IsReadOnly;

        /// <inheritdoc/>
        public string Value => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).Current.Value;

        /// <inheritdoc/>
        public TextPatternRange DocumentRange => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).DocumentRange;

        /// <inheritdoc/>
        public SupportedTextSelection SupportedTextSelection => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).SupportedTextSelection;

        /// <inheritdoc/>
        public TextPatternRange[] GetSelection() => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).GetSelection());

        /// <inheritdoc/>
        public TextPatternRange[] GetVisibleRanges() => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).GetVisibleRanges());

        /// <inheritdoc/>
        public TextPatternRange RangeFromChild(AutomationElement childElement) => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).RangeFromChild(childElement));

        /// <inheritdoc/>
        public TextPatternRange RangeFromPoint(Point screenLocation) => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).RangeFromPoint(screenLocation));

        /// <inheritdoc/>
        public void Scroll(ScrollAmount horizontalAmount = 0, ScrollAmount verticalAmount = 0) => ActionHandler.Perform(() => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Scroll(horizontalAmount, verticalAmount));

        /// <inheritdoc/>
        public void SetScrollPercent(double horizontalPercent, double verticalPercent) => ActionHandler.Perform(() => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).SetScrollPercent(horizontalPercent, verticalPercent));

        /// <inheritdoc/>
        public void SetValue(string value) => ActionHandler.Perform(() => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).SetValue(value));
    }
}