namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation;
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IExpandCollapseProvider"/>.
    /// </summary>
    public interface IExpandCollapse
    {
        /// <summary>
        /// Gets the state, expanded or collapsed, of the control.
        /// </summary>
        ExpandCollapseState ExpandCollapseState { get; }

        /// <summary>
        /// Hides all nodes, controls, or content that are descendants of the control.
        /// </summary>
        void Expand();

        /// <summary>
        /// Displays all child nodes, controls, or content of the control.
        /// </summary>
        void Collapse();
    }
}