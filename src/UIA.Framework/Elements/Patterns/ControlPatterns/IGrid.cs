namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation;
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IGridProvider"/>.
    /// </summary>
    public interface IGrid
    {
        /// <summary>
        /// Gets the total number of columns in a grid.
        /// </summary>
        int ColumnCount { get; }

        /// <summary>
        /// Gets the total number of rows in a grid.
        /// </summary>
        int RowCount { get; }

        /// <summary>
        /// Retrieves the UI Automation provider for the specified cell.
        /// </summary>
        /// <param name="row">The ordinal number of the row of interest.</param>
        /// <param name="column">The ordinal number of the column of interest.</param>
        /// <returns>The UI Automation provider for the specified cell.</returns>
        AutomationElement GetItem(int row, int column);
    }
}