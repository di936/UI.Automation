using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface IToggle
    {
        ToggleState ToggleState { get; }
        void Toggle();
    }
}
