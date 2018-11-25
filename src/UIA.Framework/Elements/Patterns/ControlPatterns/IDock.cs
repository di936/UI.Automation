using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface IDock
    {
        DockPosition DockPosition { get; }
        void SetDockPosition(DockPosition dockPosition);
    }
}
