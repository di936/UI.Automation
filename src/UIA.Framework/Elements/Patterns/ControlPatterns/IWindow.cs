namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation;
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IWindowProvider"/>.
    /// </summary>
    public interface IWindow
    {
        /// <summary>
        /// Gets the interaction state of the window.
        /// </summary>
        WindowInteractionState InteractionState { get; }

        /// <summary>
        /// Gets a value indicating whether a value that specifies whether the window is modal.
        /// </summary>
        bool IsModal { get; }

        /// <summary>
        /// Gets a value indicating whether the window is the topmost element in the z-order.
        /// </summary>
        bool IsTopmost { get; }

        /// <summary>
        /// Gets a value indicating whether the window can be maximized.
        /// </summary>
        bool Maximizable { get; }

        /// <summary>
        /// Gets a value indicating whether the window can be minimized.
        /// </summary>
        bool Minimizable { get; }

        /// <summary>
        /// Gets the visual state of the window.
        /// </summary>
        WindowVisualState VisualState { get; }

        /// <summary>
        /// Attempts to close the window.
        /// </summary>
        void Close();

        /// <summary>
        /// Changes the visual state of the window. For example, minimizes or maximizes it.
        /// </summary>
        /// <param name="state">The requested visual state of the window.</param>
        void SetVisualState(WindowVisualState state);

        /// <summary>
        /// Causes the calling code to block for the specified time or until the associated process enters an idle state, whichever completes first.
        /// </summary>
        /// <param name="milliseconds">The amount of time, in milliseconds, to wait for the associated process to become idle.</param>
        /// <returns>True if the window has entered the idle state; False if the timeout occurred.</returns>
        bool WaitForInputIdle(int milliseconds);
    }
}
