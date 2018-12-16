namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation;
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IScrollProvider"/>.
    /// </summary>
    public interface IScroll
    {
        /// <summary>
        /// Gets a value indicating whether the control can scroll horizontally.
        /// </summary>
        bool HorizontallyScrollable { get; }

        /// <summary>
        /// Gets the current horizontal scroll position.
        /// </summary>
        double HorizontalScrollPercent { get; }

        /// <summary>
        /// Gets the current horizontal scroll position.
        /// </summary>
        double HorizontalViewSize { get; }

        /// <summary>
        /// Gets a value indicating whether the control can scroll vertically.
        /// </summary>
        bool VerticallyScrollable { get; }

        /// <summary>
        /// Gets the current vertical scroll position.
        /// </summary>
        double VerticalScrollPercent { get; }

        /// <summary>
        /// Gets the vertical view size.
        /// </summary>
        double VerticalViewSize { get; }

        /// <summary>
        /// Scrolls the visible region of the content area horizontally and vertically.
        /// </summary>
        /// <param name="horizontalAmount">The horizontal increment specific to the control.</param>
        /// <param name="verticalAmount">The vertical increment specific to the control.</param>
        void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount);

        /// <summary>
        /// Sets the horizontal and vertical scroll position as a percentage of the total content area within the control.
        /// </summary>
        /// <param name="horizontalPercent">The horizontal position as a percentage of the content area's total range.</param>
        /// <param name="verticalPercent">The vertical position as a percentage of the content area's total range.</param>
        void SetScrollPercent(double horizontalPercent, double verticalPercent);
    }
}