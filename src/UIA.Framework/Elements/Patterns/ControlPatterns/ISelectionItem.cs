namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation;
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="ISelectionProvider"/>.
    /// </summary>
    public interface ISelectionItem
    {
        /// <summary>
        /// Gets a value indicating whether an item is selected.
        /// </summary>
        bool IsSelected { get; }

        /// <summary>
        /// Gets the UI Automation provider that implements <see cref="ISelectionProvider"/> and acts as the container for the calling object.
        /// </summary>
        AutomationElement SelectionContainer { get; }

        /// <summary>
        /// Adds the current element to the collection of selected items.
        /// </summary>
        void AddToSelection();

        /// <summary>
        /// Removes the current element from the collection of selected items.
        /// </summary>
        void RemoveFromSelection();

        /// <summary>
        /// Deselects any selected items and then selects the current element.
        /// </summary>
        void Select();
    }
}