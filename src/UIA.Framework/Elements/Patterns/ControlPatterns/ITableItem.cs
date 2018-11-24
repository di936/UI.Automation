using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    interface ITableItem
    {
        AutomationElement[] GetColumnHeaderItems();
        AutomationElement[] GetRowHeaderItems();
    }
}
