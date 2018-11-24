using System.Windows.Automation;

namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    interface IToggle
    {
        ToggleState ToggleState { get; }
        void Toggle();
    }
}
