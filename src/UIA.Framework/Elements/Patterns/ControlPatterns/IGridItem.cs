using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface IGridItem
    {
        int Column { get; }
        int ColumnSpan { get; }
        AutomationElement ContainingGrid { get; }
        int Row { get; }
        int RowSpan { get; }
    }
}
