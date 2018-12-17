namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Pane"/>.
    /// </summary>
    public class Pane : Element, IPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pane"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Pane"/>.</param>
        public Pane(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public bool CanMove => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanMove;

        /// <inheritdoc/>
        public bool CanResize => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanResize;

        /// <inheritdoc/>
        public bool CanRotate => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanRotate;

        /// <inheritdoc/>
        public WindowInteractionState InteractionState => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.WindowInteractionState;

        /// <inheritdoc/>
        public bool IsModal => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.IsModal;

        /// <inheritdoc/>
        public bool IsTopmost => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.IsTopmost;

        /// <inheritdoc/>
        public bool Maximizable => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.CanMaximize;

        /// <inheritdoc/>
        public bool Minimizable => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.CanMinimize;

        /// <inheritdoc/>
        public WindowVisualState VisualState => ((WindowPattern)GetCurrentPattern(WindowPattern.Pattern)).Current.WindowVisualState;

        /// <inheritdoc/>
        public DockPosition DockPosition => ((DockPattern)GetCurrentPattern(DockPattern.Pattern)).Current.DockPosition;

        /// <inheritdoc/>
        public bool HorizontallyScrollable => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontallyScrollable;

        /// <inheritdoc/>
        public double HorizontalScrollPercent => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalScrollPercent;

        /// <inheritdoc/>
        public double HorizontalViewSize => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalViewSize;

        /// <inheritdoc/>
        public bool VerticallyScrollable => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticallyScrollable;

        /// <inheritdoc/>
        public double VerticalScrollPercent => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalScrollPercent;

        /// <inheritdoc/>
        public double VerticalViewSize => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalViewSize;

        /// <inheritdoc/>
        public void Close() => ActionHandler.Perform(() => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).Close());

        /// <inheritdoc/>
        public void Move(double x, double y) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Move(x, y));

        /// <inheritdoc/>
        public void Resize(double width, double height) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Resize(width, height));

        /// <inheritdoc/>
        public void Rotate(double degrees) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Rotate(degrees));

        /// <inheritdoc/>
        public void Scroll(ScrollAmount horizontalAmount = 0, ScrollAmount verticalAmount = 0) => ActionHandler.Perform(() => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Scroll(horizontalAmount, verticalAmount));

        /// <inheritdoc/>
        public void SetScrollPercent(double horizontalPercent, double verticalPercent) => ActionHandler.Perform(() => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).SetScrollPercent(horizontalPercent, verticalPercent));

        /// <inheritdoc/>
        public void SetDockPosition(DockPosition dockPosition) => ActionHandler.Perform(() => ((DockPattern)this.GetCurrentPattern(DockPattern.Pattern)).SetDockPosition(dockPosition));

        /// <inheritdoc/>
        public void SetVisualState(WindowVisualState state) => ActionHandler.Perform(() => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).SetWindowVisualState(state));

        /// <inheritdoc/>
        public bool WaitForInputIdle(int milliseconds) => ActionHandler.Perform(() => ((WindowPattern)this.GetCurrentPattern(WindowPattern.Pattern)).WaitForInputIdle(milliseconds));
    }
}