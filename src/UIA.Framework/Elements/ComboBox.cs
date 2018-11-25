using System;
using System.Windows.Automation;
using UIA.Framework.Configuration;
using UIA.Framework.Elements.Patterns.ElementPatterns;

namespace UIA.Framework.Elements
{
    public class ComboBox : Element, IComboBox
    {
        public ExpandCollapseState ExpandCollapseState => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Current.ExpandCollapseState;

        public bool CanSelectMultiple => ((SelectionPattern)RawElement.GetCurrentPattern(SelectionPattern.Pattern)).Current.CanSelectMultiple;

        public bool IsSelectionRequired => ((SelectionPattern)RawElement.GetCurrentPattern(SelectionPattern.Pattern)).Current.IsSelectionRequired;

        public bool IsReadOnly => ((ValuePattern)RawElement.GetCurrentPattern(ValuePattern.Pattern)).Current.IsReadOnly;

        public string Value => ((ValuePattern)RawElement.GetCurrentPattern(ValuePattern.Pattern)).Current.Value;

        public bool HorizontallyScrollable => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontallyScrollable;

        public double HorizontalScrollPercent => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalScrollPercent;

        public double HorizontalViewSize => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalViewSize;

        public bool VerticallyScrollable => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticallyScrollable;

        public double VerticalScrollPercent => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalScrollPercent;

        public double VerticalViewSize => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalViewSize;

        public ComboBox(AutomationElement element) : base(element)
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

        public void SetValue(string value)
        {
            ActionHandler.Perform(() => ((ValuePattern)RawElement.GetCurrentPattern(ValuePattern.Pattern)).SetValue(value));
        }
    }
}
