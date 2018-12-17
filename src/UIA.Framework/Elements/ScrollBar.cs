namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.ScrollBar"/>.
    /// </summary>
    public class ScrollBar : Element, IScrollBar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollBar"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.ScrollBar"/>.</param>
        public ScrollBar(AutomationElement element)
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
        public void Scroll(ScrollAmount horizontalAmount = 0, ScrollAmount verticalAmount = 0) => ActionHandler.Perform(() => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Scroll(horizontalAmount, verticalAmount));

        /// <inheritdoc/>
        public void SetScrollPercent(double horizontalPercent, double verticalPercent) => ActionHandler.Perform(() => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).SetScrollPercent(horizontalPercent, verticalPercent));

        /// <inheritdoc/>
        public void SetRangeValue(double value) => ActionHandler.Perform(() => ((RangeValuePattern)this.GetCurrentPattern(RangeValuePattern.Pattern)).SetValue(value));
    }
}