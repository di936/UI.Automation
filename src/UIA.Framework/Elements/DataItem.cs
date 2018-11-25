using System.Windows.Automation;
using UIA.Framework.Configuration;
using UIA.Framework.Elements.Patterns.ElementPatterns;

namespace UIA.Framework.Elements
{
    public class DataItem : Element, IDataItem
    {
        public DataItem(AutomationElement element) : base(element)
        {

        }

        public ExpandCollapseState ExpandCollapseState => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Current.ExpandCollapseState;

        public int Column => ((GridItemPattern)RawElement.GetCurrentPattern(GridItemPattern.Pattern)).Current.Column;

        public int ColumnSpan => ((GridItemPattern)RawElement.GetCurrentPattern(GridItemPattern.Pattern)).Current.ColumnSpan;

        public AutomationElement ContainingGrid => ((GridItemPattern)RawElement.GetCurrentPattern(GridItemPattern.Pattern)).Current.ContainingGrid;

        public int Row => ((GridItemPattern)RawElement.GetCurrentPattern(GridItemPattern.Pattern)).Current.Row;

        public int RowSpan => ((GridItemPattern)RawElement.GetCurrentPattern(GridItemPattern.Pattern)).Current.RowSpan;

        public bool IsSelected => ((SelectionItemPattern)RawElement.GetCurrentPattern(SelectionItemPattern.Pattern)).Current.IsSelected;

        public AutomationElement SelectionContainer => ((SelectionItemPattern)RawElement.GetCurrentPattern(SelectionItemPattern.Pattern)).Current.SelectionContainer;

        public ToggleState ToggleState => ((TogglePattern)RawElement.GetCurrentPattern(TogglePattern.Pattern)).Current.ToggleState;

        public bool IsReadOnly => ((ValuePattern)RawElement.GetCurrentPattern(ValuePattern.Pattern)).Current.IsReadOnly;

        public string Value => ((ValuePattern)RawElement.GetCurrentPattern(ValuePattern.Pattern)).Current.Value;

        public void AddToSelection()
        {
            ActionHandler.Perform(() => ((SelectionItemPattern)RawElement.GetCurrentPattern(SelectionItemPattern.Pattern)).AddToSelection());
        }

        public void Collapse()
        {
            ActionHandler.Perform(() => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Collapse());
        }

        public void Expand()
        {
            ActionHandler.Perform(() => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Expand());
        }

        public AutomationElement[] GetColumnHeaderItems()
        {
            return ActionHandler.Perform(() => ((TableItemPattern)RawElement.GetCurrentPattern(TableItemPattern.Pattern)).Current.GetColumnHeaderItems());
        }

        public AutomationElement[] GetRowHeaderItems()
        {
            return ActionHandler.Perform(() => ((TableItemPattern)RawElement.GetCurrentPattern(TableItemPattern.Pattern)).Current.GetRowHeaderItems());
        }

        public void RemoveFromSelection()
        {
            ActionHandler.Perform(() => ((SelectionItemPattern)RawElement.GetCurrentPattern(SelectionItemPattern.Pattern)).RemoveFromSelection());
        }

        public void ScrollIntoView()
        {
            ActionHandler.Perform(() => ((ScrollItemPattern)RawElement.GetCurrentPattern(ScrollItemPattern.Pattern)).ScrollIntoView());
        }

        public void Select()
        {
            ActionHandler.Perform(() => ((SelectionItemPattern)RawElement.GetCurrentPattern(SelectionItemPattern.Pattern)).Select());
        }

        public void SetValue(string value)
        {
            ActionHandler.Perform(() => ((ValuePattern)RawElement.GetCurrentPattern(ValuePattern.Pattern)).SetValue(value));
        }

        public void Toggle()
        {
            ActionHandler.Perform(() => ((TogglePattern)RawElement.GetCurrentPattern(TogglePattern.Pattern)).Toggle());
        }
    }
}