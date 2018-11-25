using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Text;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface IText
    {
        TextPatternRange DocumentRange { get; }
        SupportedTextSelection SupportedTextSelection { get; }

        TextPatternRange[] GetSelection();
        TextPatternRange[] GetVisibleRanges();
        TextPatternRange RangeFromChild(AutomationElement childElement);
        TextPatternRange RangeFromPoint(Point screenLocation);
    }
}
