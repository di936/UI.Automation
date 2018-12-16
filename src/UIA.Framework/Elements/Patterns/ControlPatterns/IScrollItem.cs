namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IScrollItemProvider"/>.
    /// </summary>
    public interface IScrollItem
    {
        /// <summary>
        /// Scrolls the content area of a container object in order to display the control within the visible region (viewport) of the container.
        /// </summary>
        void ScrollIntoView();
    }
}