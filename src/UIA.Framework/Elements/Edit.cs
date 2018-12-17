using UIA.Framework.Configuration;

namespace UIA.Framework.Elements
{
    using System.Windows;
    using System.Windows.Automation;
    using System.Windows.Automation.Text;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Edit"/>.
    /// </summary>
    public class Edit : Element, IEdit
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Edit"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Edit"/>.</param>
        public Edit(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public TextPatternRange DocumentRange => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).DocumentRange;

        /// <inheritdoc/>
        public SupportedTextSelection SupportedTextSelection => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).SupportedTextSelection;

        /// <inheritdoc/>
        public bool IsReadOnly => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).Current.IsReadOnly;

        /// <inheritdoc/>
        public string Value => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).Current.Value;

        /// <inheritdoc/>
        public bool RangeIsReadOnly => ((RangeValuePattern)this.GetCurrentPattern(RangeValuePattern.Pattern)).Current.IsReadOnly;

        /// <inheritdoc/>
        public double LargeChange => ((RangeValuePattern)this.GetCurrentPattern(RangeValuePattern.Pattern)).Current.LargeChange;

        /// <inheritdoc/>
        public double Maximum => ((RangeValuePattern)this.GetCurrentPattern(RangeValuePattern.Pattern)).Current.Maximum;

        /// <inheritdoc/>
        public double Minimum => ((RangeValuePattern)this.GetCurrentPattern(RangeValuePattern.Pattern)).Current.Minimum;

        /// <inheritdoc/>
        public double SmallChange => ((RangeValuePattern)this.GetCurrentPattern(RangeValuePattern.Pattern)).Current.SmallChange;

        /// <inheritdoc/>
        public double RangeValue => ((RangeValuePattern)this.GetCurrentPattern(RangeValuePattern.Pattern)).Current.Value;

        /// <inheritdoc/>
        public TextPatternRange[] GetSelection() => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).GetSelection());

        /// <inheritdoc/>
        public TextPatternRange[] GetVisibleRanges() => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).GetVisibleRanges());

        /// <inheritdoc/>
        public TextPatternRange RangeFromChild(AutomationElement childElement) => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).RangeFromChild(childElement));

        /// <inheritdoc/>
        public TextPatternRange RangeFromPoint(Point screenLocation) => ActionHandler.Perform(() => ((TextPattern)this.GetCurrentPattern(TextPattern.Pattern)).RangeFromPoint(screenLocation));

        /// <inheritdoc/>
        public void SetRangeValue(double value) => ActionHandler.Perform(() => ((RangeValuePattern)this.GetCurrentPattern(RangeValuePattern.Pattern)).SetValue(value));

        /// <inheritdoc/>
        public void SetValue(string value) => ActionHandler.Perform(() => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).SetValue(value));
    }
}