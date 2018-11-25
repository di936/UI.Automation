using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface IGrid
    {
        int ColumnCount { get; }
        int RowCount { get; }
        AutomationElement GetItem(int row, int column);
    }
}
