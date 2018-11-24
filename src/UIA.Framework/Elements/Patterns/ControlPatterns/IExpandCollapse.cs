using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    interface IExpandCollapse
    {
        ExpandCollapseState ExpandCollapseState { get; }
        void Expand();
        void Collapse();
    }
}
