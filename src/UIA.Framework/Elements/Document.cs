using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Text;
using UIA.Framework.Configuration;
using UIA.Framework.Elements.Patterns.ElementPatterns;

namespace UIA.Framework.Elements
{
    public class Document : Element, IDocument
    {
        public Document(AutomationElement element) : base(element)
        {

        }

        public bool HorizontallyScrollable => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontallyScrollable;

        public double HorizontalScrollPercent => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalScrollPercent;

        public double HorizontalViewSize => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalViewSize;

        public bool VerticallyScrollable => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticallyScrollable;

        public double VerticalScrollPercent => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalScrollPercent;

        public double VerticalViewSize => ((ScrollPattern)RawElement.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalViewSize;

        public bool IsReadOnly => ((ValuePattern)RawElement.GetCurrentPattern(ValuePattern.Pattern)).Current.IsReadOnly;

        public string Value => ((ValuePattern)RawElement.GetCurrentPattern(ValuePattern.Pattern)).Current.Value;

        public TextPatternRange DocumentRange => ((TextPattern)RawElement.GetCurrentPattern(TextPattern.Pattern)).DocumentRange;

        public SupportedTextSelection SupportedTextSelection => ((TextPattern)RawElement.GetCurrentPattern(TextPattern.Pattern)).SupportedTextSelection;

        public TextPatternRange[] GetSelection()
        {
            return ActionHandler.Perform(() => ((TextPattern)RawElement.GetCurrentPattern(TextPattern.Pattern)).GetSelection());
        }

        public TextPatternRange[] GetVisibleRanges()
        {
            return ActionHandler.Perform(() => ((TextPattern)RawElement.GetCurrentPattern(TextPattern.Pattern)).GetVisibleRanges());
        }

        public TextPatternRange RangeFromChild(AutomationElement childElement)
        {
            return ActionHandler.Perform(() => ((TextPattern)RawElement.GetCurrentPattern(TextPattern.Pattern)).RangeFromChild(childElement));
        }

        public TextPatternRange RangeFromPoint(Point screenLocation)
        {
            return ActionHandler.Perform(() => ((TextPattern)RawElement.GetCurrentPattern(TextPattern.Pattern)).RangeFromPoint(screenLocation));
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