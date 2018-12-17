namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Window"/>.
    /// </summary>
    public class Window : Element, IWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Window"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Window"/>.</param>
        public Window(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public DockPosition DockPosition => ((DockPattern)this.GetCurrentPattern(DockPattern.Pattern)).Current.DockPosition;

        /// <inheritdoc/>
        public bool CanMove => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanMove;

        /// <inheritdoc/>
        public bool CanResize => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanResize;

        /// <inheritdoc/>
        public bool CanRotate => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanRotate;

        /// <inheritdoc/>
        public WindowInteractionState InteractionState => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).Current.WindowInteractionState;

        /// <inheritdoc/>
        public bool IsModal => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).Current.IsModal;

        /// <inheritdoc/>
        public bool IsTopmost => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).Current.IsTopmost;

        /// <inheritdoc/>
        public bool Maximizable => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).Current.CanMaximize;

        /// <inheritdoc/>
        public bool Minimizable => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).Current.CanMinimize;

        /// <inheritdoc/>
        public WindowVisualState VisualState => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).Current.WindowVisualState;

        /// <inheritdoc/>
        public void Close() => ActionHandler.Perform(() => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).Close());

        /// <inheritdoc/>
        public void Move(double x, double y) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Move(x,y));

        /// <inheritdoc/>
        public void Resize(double width, double height) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Resize(width, height));

        /// <inheritdoc/>
        public void Rotate(double degrees) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Rotate(degrees));

        /// <inheritdoc/>
        public void SetDockPosition(DockPosition dockPosition) => ActionHandler.Perform(() => ((DockPattern)this.GetCurrentPattern(DockPattern.Pattern)).SetDockPosition(dockPosition));

        /// <inheritdoc/>
        public void SetVisualState(WindowVisualState state) => ActionHandler.Perform(() => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).SetWindowVisualState(state));

        /// <inheritdoc/>
        public bool WaitForInputIdle(int milliseconds) => ActionHandler.Perform(() => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).WaitForInputIdle(milliseconds));
    }
}