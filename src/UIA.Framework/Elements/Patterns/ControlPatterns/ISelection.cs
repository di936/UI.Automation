using System.Windows.Automation;
using System.Windows.Automation.Provider;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    interface ISelection
    {
        bool CanSelectMultiple { get; }
        bool IsSelectionRequired { get; }
        AutomationElement[] GetSelection();
    }
}
