using System.Windows.Automation.Provider;
using System.Windows.Automation.Text;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface ITextRange
    {
        void AddToSelection();
        ITextRangeProvider Clone();
        bool Compare(ITextRangeProvider range);
        int CompareEndpoints(TextPatternRangeEndpoint endpoint, ITextRangeProvider targetRange, TextPatternRangeEndpoint targetEndpoint);
        void ExpandToEnclosingUnit(TextUnit unit);
        ITextRangeProvider FindAttribute(int attribute, object value, bool backward);
        ITextRangeProvider FindText(string text, bool backward, bool ignoreCase);
        object GetAttributeValue(int attribute);
        double[] GetBoundingRectangles();
        IRawElementProviderSimple[] GetChildren();
        IRawElementProviderSimple GetEnclosingElement();
        string GetText(int maxLength);
        int Move(TextUnit unit, int count);
        void MoveEndpointByRange(TextPatternRangeEndpoint endpoint, ITextRangeProvider targetRange, TextPatternRangeEndpoint targetEndpoint);
        int MoveEndpointByUnit(TextPatternRangeEndpoint endpoint, TextUnit unit, int count);
        void RemoveFromSelection();
        void ScrollIntoView(bool alignToTop);
        void Select();
    }
}
