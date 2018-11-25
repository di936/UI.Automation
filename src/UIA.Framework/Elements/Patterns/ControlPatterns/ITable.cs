using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface ITable
    {
        RowOrColumnMajor RowOrColumnMajor { get; }
        AutomationElement[] GetColumnHeaders();
        AutomationElement[] GetRowHeaders();
    }
}
