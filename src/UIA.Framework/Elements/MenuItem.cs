using System.Windows.Automation;
using UIA.Framework.Configuration;
using UIA.Framework.Elements.Patterns.ElementPatterns;

namespace UIA.Framework.Elements
{
    internal class MenuItem : Element, IMenuItem
    {
        public ExpandCollapseState ExpandCollapseState => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Current.ExpandCollapseState;

        public ToggleState ToggleState => ((TogglePattern)RawElement.GetCurrentPattern(TogglePattern.Pattern)).Current.ToggleState;

        public bool IsSelected => ((SelectionItemPattern)RawElement.GetCurrentPattern(SelectionItemPattern.Pattern)).Current.IsSelected;

        public AutomationElement SelectionContainer => ((SelectionItemPattern)RawElement.GetCurrentPattern(SelectionItemPattern.Pattern)).Current.SelectionContainer;

        public MenuItem(AutomationElement element) : base(element)
        {
            
        }

        public void Collapse()
        {
            ActionHandler.Perform(() => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Collapse());
        }

        public void Expand()
        {
            ActionHandler.Perform(() => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Expand());
        }

        public void Invoke()
        {
            ActionHandler.Perform(() => ((InvokePattern)RawElement.GetCurrentPattern(InvokePattern.Pattern)).Invoke());
        }

        public void Toggle()
        {
            ActionHandler.Perform(() => ((TogglePattern)RawElement.GetCurrentPattern(TogglePattern.Pattern)).Toggle());
        }

        public void AddToSelection()
        {
            ActionHandler.Perform(() => ((SelectionItemPattern)RawElement.GetCurrentPattern(SelectionItemPattern.Pattern)).AddToSelection());
        }

        public void RemoveFromSelection()
        {
            ActionHandler.Perform(() => ((SelectionItemPattern)RawElement.GetCurrentPattern(SelectionItemPattern.Pattern)).RemoveFromSelection());
        }

        public void Select()
        {
            ActionHandler.Perform(() => ((SelectionItemPattern)RawElement.GetCurrentPattern(SelectionItemPattern.Pattern)).Select());
        }
    }
}