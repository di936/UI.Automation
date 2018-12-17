namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation;

    /// <summary>
    /// To implement <see cref="ITableProvider"/>.
    /// </summary>
    public interface ITable
    {
        /// <summary>
        /// Gets the primary direction of traversal for the table.
        /// </summary>
        RowOrColumnMajor RowOrColumnMajor { get; }

        /// <summary>
        /// Gets a collection of UI Automation providers that represents all the column headers in a table.
        /// </summary>
        /// <returns>A collection of UI Automation providers.</returns>
        AutomationElement[] GetColumnHeaders();

        /// <summary>
        /// Retrieves a collection of UI Automation providers that represents all row headers in the table.
        /// </summary>
        /// <returns>A collection of UI Automation providers.</returns>
        AutomationElement[] GetRowHeaders();
    }
}