namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IInvokeProvider"/>.
    /// </summary>
    public interface IInvoke
    {
        /// <summary>
        /// Sends a request to activate a control and initiate its single, unambiguous action.
        /// </summary>
        void Invoke();
    }
}