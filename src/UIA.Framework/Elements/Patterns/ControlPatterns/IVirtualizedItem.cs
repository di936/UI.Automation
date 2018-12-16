namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IVirtualizedItemProvider"/>.
    /// </summary>
    public interface IVirtualizedItem
    {
        /// <summary>
        /// Makes the virtual item fully accessible as a UI Automation element.
        /// </summary>
        void Realize();
    }
}
