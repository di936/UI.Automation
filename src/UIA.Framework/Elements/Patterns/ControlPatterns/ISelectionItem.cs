using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface ISelectionItem
    {
        bool IsSelected { get; }
        AutomationElement SelectionContainer { get; }
        void AddToSelection();
        void RemoveFromSelection();
        void Select();
    }
}
