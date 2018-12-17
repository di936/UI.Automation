namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.StatusBar"/>.
    /// </summary>
    public class StatusBar : Element, IStatusBar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusBar"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.StatusBar"/>.</param>
        public StatusBar(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public int ColumnCount => ((GridPattern)this.GetCurrentPattern(GridPattern.Pattern)).Current.ColumnCount;

        /// <inheritdoc/>
        public int RowCount => ((GridPattern)this.GetCurrentPattern(GridPattern.Pattern)).Current.RowCount;

        /// <inheritdoc/>
        public AutomationElement GetItem(int row, int column) => ActionHandler.Perform(() => ((GridPattern)this.GetCurrentPattern(GridPattern.Pattern)).GetItem(row, column));
    }
}