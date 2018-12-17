namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation;
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="ISelectionProvider"/>.
    /// </summary>
    public interface ISelection
    {
        /// <summary>
        /// Gets a value indicating whether the UI Automation provider allows more than one child element to be selected concurrently.
        /// </summary>
        bool CanSelectMultiple { get; }

        /// <summary>
        /// Gets a value indicating whether the UI Automation provider requires at least one child element to be selected.
        /// </summary>
        bool IsSelectionRequired { get; }

        /// <summary>
        /// Retrieves a UI Automation provider for each child element that is selected.
        /// </summary>
        /// <returns>A collection of UI Automation providers.</returns>
        AutomationElement[] GetSelection();
    }
}