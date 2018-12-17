namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.ProgressBar"/>.
    /// </summary>
    public class ProgressBar : Element, IProgressBar
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBar"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.ProgressBar"/>.</param>
        public ProgressBar(AutomationElement element)
            : base(element)
        {
        }

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
        public void SetRangeValue(double value) => ActionHandler.Perform(() => ((RangeValuePattern)this.GetCurrentPattern(RangeValuePattern.Pattern)).SetValue(value));

        /// <inheritdoc/>
        public void SetValue(string value) => ActionHandler.Perform(() => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).SetValue(value));
    }
}