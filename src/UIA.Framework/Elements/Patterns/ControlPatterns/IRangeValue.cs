namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IRangeValueProvider"/>.
    /// </summary>
    public interface IRangeValue
    {
        /// <summary>
        /// Gets a value indicating whether the value of a control is read-only.
        /// </summary>
        bool RangeIsReadOnly { get; }

        /// <summary>
        /// Gets the value that is added to or subtracted from the <see cref="RangeValue"/> property when a large change is made, such as with the PAGE DOWN key.
        /// </summary>
        double LargeChange { get; }

        /// <summary>
        /// Gets the maximum range value supported by the control.
        /// </summary>
        double Maximum { get; }

        /// <summary>
        /// Gets the minimum range value supported by the control.
        /// </summary>
        double Minimum { get; }

        /// <summary>
        /// Gets the value that is added to or subtracted from the <see cref="RangeValue"/> property when a small change is made, such as with an arrow key.
        /// </summary>
        double SmallChange { get; }

        /// <summary>
        /// Gets the value of the control.
        /// </summary>
        double RangeValue { get; }

        /// <summary>
        /// Sets the value of the control.
        /// </summary>
        /// <param name="value">The value to set.</param>
        void SetRangeValue(double value);
    }
}