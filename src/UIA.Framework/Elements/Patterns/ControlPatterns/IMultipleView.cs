namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IMultipleViewProvider"/>.
    /// </summary>
    public interface IMultipleView
    {
        /// <summary>
        /// Gets the current control-specific view.
        /// </summary>
        int CurrentView { get; }

        /// <summary>
        /// Retrieves a collection of control-specific view identifiers.
        /// </summary>
        /// <returns>A collection of values that identifies the views available for a UI Automation element.</returns>
        int[] GetSupportedViews();

        /// <summary>
        /// Retrieves the name of a control-specific view.
        /// </summary>
        /// <param name="viewId">The view identifier.</param>
        /// <returns>A localized name for the view.</returns>
        string GetViewName(int viewId);

        /// <summary>
        /// Sets the current control-specific view.
        /// </summary>
        /// <param name="viewId">A view identifier.</param>
        void SetCurrentView(int viewId);
    }
}