namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Table"/>.
    /// </summary>
    public class Table : Element, ITable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Table"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Table"/>.</param>
        public Table(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public int ColumnCount => ((GridPattern)this.GetCurrentPattern(GridPattern.Pattern)).Current.ColumnCount;

        /// <inheritdoc/>
        public int RowCount => ((GridPattern)this.GetCurrentPattern(GridPattern.Pattern)).Current.RowCount;

        /// <inheritdoc/>
        public int Column => ((GridItemPattern)this.GetCurrentPattern(GridItemPattern.Pattern)).Current.Column;

        /// <inheritdoc/>
        public int ColumnSpan => ((GridItemPattern)this.GetCurrentPattern(GridItemPattern.Pattern)).Current.ColumnSpan;

        /// <inheritdoc/>
        public AutomationElement ContainingGrid => ((GridItemPattern)this.GetCurrentPattern(GridItemPattern.Pattern)).Current.ContainingGrid;

        /// <inheritdoc/>
        public int Row => ((GridItemPattern)this.GetCurrentPattern(GridItemPattern.Pattern)).Current.Row;

        /// <inheritdoc/>
        public int RowSpan => ((GridItemPattern)this.GetCurrentPattern(GridItemPattern.Pattern)).Current.RowSpan;

        /// <inheritdoc/>
        public RowOrColumnMajor RowOrColumnMajor => ((TablePattern)this.GetCurrentPattern(TablePattern.Pattern)).Current.RowOrColumnMajor;

        /// <inheritdoc/>
        public AutomationElement[] GetColumnHeaderItems() => ActionHandler.Perform(() => ((TableItemPattern)this.GetCurrentPattern(TableItemPattern.Pattern)).Current.GetColumnHeaderItems());

        /// <inheritdoc/>
        public AutomationElement[] GetColumnHeaders() => ActionHandler.Perform(() => ((TablePattern)this.GetCurrentPattern(TablePattern.Pattern)).Current.GetColumnHeaders());

        /// <inheritdoc/>
        public AutomationElement GetItem(int row, int column) => ActionHandler.Perform(() => ((GridPattern)this.GetCurrentPattern(GridPattern.Pattern)).GetItem(row, column));

        /// <inheritdoc/>
        public AutomationElement[] GetRowHeaderItems() => ActionHandler.Perform(() => ((TableItemPattern)this.GetCurrentPattern(TableItemPattern.Pattern)).Current.GetRowHeaderItems());

        /// <inheritdoc/>
        public AutomationElement[] GetRowHeaders() => ActionHandler.Perform(() => ((TablePattern)this.GetCurrentPattern(TablePattern.Pattern)).Current.GetRowHeaders());
    }
}