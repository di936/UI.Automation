using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface ITableItem
    {
        AutomationElement[] GetColumnHeaderItems();
        AutomationElement[] GetRowHeaderItems();
    }
}
