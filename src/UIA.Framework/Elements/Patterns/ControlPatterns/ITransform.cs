namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="ITransformProvider"/>.
    /// </summary>
    public interface ITransform
    {
        /// <summary>
        /// Gets a value indicating whether a value that specifies whether the control can be moved.
        /// </summary>
        bool CanMove { get; }

        /// <summary>
        /// Gets a value indicating whether a value that specifies whether the UI Automation element can be resized.
        /// </summary>
        bool CanResize { get; }

        /// <summary>
        /// Gets a value indicating whether a value that specifies whether the control can be rotated.
        /// </summary>
        bool CanRotate { get; }

        /// <summary>
        /// Moves the control.
        /// </summary>
        /// <param name="x">Absolute screen coordinates of the left side of the control.</param>
        /// <param name="y">Absolute screen coordinates of the top of the control.</param>
        void Move(double x, double y);

        /// <summary>
        /// Resizes the control.
        /// </summary>
        /// <param name="width">The new width of the window, in pixels.</param>
        /// <param name="height">The new height of the window, in pixels.</param>
        void Resize(double width, double height);

        /// <summary>
        /// Rotates the control.
        /// </summary>
        /// <param name="degrees">The number of degrees to rotate the control. A positive number rotates clockwise; a negative number rotates counterclockwise.</param>
        void Rotate(double degrees);
    }
}