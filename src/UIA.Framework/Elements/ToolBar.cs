namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.ToolBar"/>.
    /// </summary>
    public class ToolBar : Element, IToolBar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolBar"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.ToolBar"/>.</param>
        public ToolBar(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public ExpandCollapseState ExpandCollapseState => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Current.ExpandCollapseState;

        /// <inheritdoc/>
        public DockPosition DockPosition => ((DockPattern)this.GetCurrentPattern(DockPattern.Pattern)).Current.DockPosition;

        /// <inheritdoc/>
        public bool CanMove => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanMove;

        /// <inheritdoc/>
        public bool CanResize => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanResize;

        /// <inheritdoc/>
        public bool CanRotate => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanRotate;

        /// <inheritdoc/>
        public void Expand() => ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Expand());

        /// <inheritdoc/>
        public void Collapse() => ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Collapse());

        /// <inheritdoc/>
        public void Move(double x, double y) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Move(x, y));

        /// <inheritdoc/>
        public void Resize(double width, double height) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Resize(width, height));

        /// <inheritdoc/>
        public void Rotate(double degrees) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Rotate(degrees));

        /// <inheritdoc/>
        public void SetDockPosition(DockPosition dockPosition) => ActionHandler.Perform(() => ((DockPattern)this.GetCurrentPattern(DockPattern.Pattern)).SetDockPosition(dockPosition));
    }
}