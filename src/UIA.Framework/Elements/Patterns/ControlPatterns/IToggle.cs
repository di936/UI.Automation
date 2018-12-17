namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation;
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IToggleProvider"/>.
    /// </summary>
    public interface IToggle
    {
        /// <summary>
        /// Gets the toggle state of the control.
        /// </summary>
        ToggleState ToggleState { get; }

        /// <summary>
        /// Cycles through the toggle states of a control.
        /// </summary>
        void Toggle();
    }
}