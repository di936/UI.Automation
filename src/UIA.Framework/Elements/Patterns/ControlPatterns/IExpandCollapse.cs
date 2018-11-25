using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface IExpandCollapse
    {
        ExpandCollapseState ExpandCollapseState { get; }
        void Expand();
        void Collapse();
    }
}
