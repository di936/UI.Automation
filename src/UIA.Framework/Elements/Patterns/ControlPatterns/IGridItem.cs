namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation;
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IGridItemProvider"/>.
    /// </summary>
    public interface IGridItem
    {
        /// <summary>
        /// Gets the ordinal number of the column that contains the cell or item.
        /// </summary>
        int Column { get; }

        /// <summary>
        /// Gets the number of columns spanned by a cell or item.
        /// </summary>
        int ColumnSpan { get; }

        /// <summary>
        /// Gets a UI Automation provider that implements <see cref="IGridProvider"/> and represents the container of the cell or item.
        /// </summary>
        AutomationElement ContainingGrid { get; }

        /// <summary>
        /// Gets the ordinal number of the row that contains the cell or item.
        /// </summary>
        int Row { get; }

        /// <summary>
        /// Gets the number of rows spanned by a cell or item.
        /// </summary>
        int RowSpan { get; }
    }
}