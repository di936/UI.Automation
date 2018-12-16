namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation;
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="ITableItemProvider"/>.
    /// </summary>
    public interface ITableItem
    {
        /// <summary>
        /// Retrieves a collection of UI Automation providers representing all the column headers associated with a table item or cell.
        /// </summary>
        /// <returns>A collection of UI Automation providers.</returns>
        AutomationElement[] GetColumnHeaderItems();

        /// <summary>
        /// Retrieves a collection of UI Automation providers representing all the row headers associated with a table item or cell.
        /// </summary>
        /// <returns>A collection of UI Automation providers.</returns>
        AutomationElement[] GetRowHeaderItems();
    }
}