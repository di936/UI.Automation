namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation;
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IDockProvider"/>.
    /// </summary>
    public interface IDock
    {
        /// <summary>
        /// Gets the current <see cref="System.Windows.Automation.DockPosition"/> of the control within a docking container.
        /// </summary>
        DockPosition DockPosition { get; }

        /// <summary>
        /// Docks the control within a docking container.
        /// </summary>
        /// <param name="dockPosition">The dock position, relative to the boundaries of the docking container and other elements within the container.</param>
        void SetDockPosition(DockPosition dockPosition);
    }
}