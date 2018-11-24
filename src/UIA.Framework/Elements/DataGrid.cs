using System;
using System.Windows.Automation;
using UIA.Framework.Configuration;
using UIA.Framework.Elements.Patterns.ElementPatterns;

namespace UIA.Framework.Elements
{
    public class DataGrid : Element, IDataGrid
    {
        public DataGrid(AutomationElement element) : base(element)
        {

        }

        public int ColumnCount => ((GridPattern)RawElement.GetCurrentPattern(GridPattern.Pattern)).Current.ColumnCount;

        public int RowCount => ((GridPattern)RawElement.GetCurrentPattern(GridPattern.Pattern)).Current.RowCount;

        public bool HorizontallyScrollable => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontallyScrollable;

        public double HorizontalScrollPercent => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalScrollPercent;

        public double HorizontalViewSize => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalViewSize;

        public bool VerticallyScrollable => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticallyScrollable;

        public double VerticalScrollPercent => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalScrollPercent;

        public double VerticalViewSize => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalViewSize;

        public bool CanSelectMultiple => ((SelectionPattern)RawElement.GetCurrentPattern(SelectionPattern.Pattern)).Current.CanSelectMultiple;

        public bool IsSelectionRequired => ((SelectionPattern)RawElement.GetCurrentPattern(SelectionPattern.Pattern)).Current.IsSelectionRequired;

        public RowOrColumnMajor RowOrColumnMajor => ((TablePattern)RawElement.GetCurrentPattern(TablePattern.Pattern)).Current.RowOrColumnMajor;

        public AutomationElement[] GetColumnHeaders()
        {
            return ActionHandler.Perform(() => ((TablePattern)RawElement.GetCurrentPattern(TablePattern.Pattern)).Current.GetColumnHeaders());
        }

        public AutomationElement GetItem(int row, int column)
        {
            return ActionHandler.Perform(() => ((GridPattern)RawElement.GetCurrentPattern(GridPattern.Pattern)).GetItem(row, column));
        }

        public AutomationElement[] GetRowHeaders()
        {
            return ActionHandler.Perform(() => ((TablePattern)RawElement.GetCurrentPattern(TablePattern.Pattern)).Current.GetRowHeaders());
        }

        public AutomationElement[] GetSelection()
        {
            return ActionHandler.Perform(() => ((SelectionPattern)RawElement.GetCurrentPattern(SelectionPattern.Pattern)).Current.GetSelection());
        }

        public void Scroll(ScrollAmount horizontalAmount = 0, ScrollAmount verticalAmount = 0)
        {
            ActionHandler.Perform(() => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Scroll(horizontalAmount, verticalAmount));
        }

        public void SetScrollPercent(double horizontalPercent, double verticalPercent)
        {
            ActionHandler.Perform(() => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).SetScrollPercent(horizontalPercent, verticalPercent));
        }
    }
}