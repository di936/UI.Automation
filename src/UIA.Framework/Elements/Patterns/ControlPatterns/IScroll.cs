using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    interface IScroll
    {
        bool HorizontallyScrollable { get; }
        double HorizontalScrollPercent { get; }
        double HorizontalViewSize { get; }
        bool VerticallyScrollable { get; }
        double VerticalScrollPercent { get; }
        double VerticalViewSize { get; }
        void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount);
        void SetScrollPercent(double horizontalPercent, double verticalPercent);
    }
}
