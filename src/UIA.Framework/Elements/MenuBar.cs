namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;
    using UIA.Framework.Viewers;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.MenuBar"/>.
    /// </summary>
    public class MenuBar : Element, IMenuBar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuBar"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.MenuBar"/>.</param>
        public MenuBar(AutomationElement element)
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
        public void InvokeByPath(string[] path)
        {
            var element = new TreeViewer(this.RawElement).FindByName<MenuItem>(path[0]);
            if (path.Length > 1)
            {
                element.Expand();
                for (var i = 1; i < path.Length; i++)
                {
                    element = new TreeViewer(element.RawElement).FindByName<Menu>(path[i - 1]).FindByName<MenuItem>(path[i]);
                    if (i == path.Length - 1)
                    {
                        element.Invoke();
                    }
                    else
                    {
                        element.Expand();
                    }
                }
            }
            else
            {
                element.Invoke();
            }
        }

        /// <inheritdoc/>
        public void Collapse() => ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Collapse());

        /// <inheritdoc/>
        public void Expand() => ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Expand());

        /// <inheritdoc/>
        public void Move(double x, double y) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Move(x,y));

        /// <inheritdoc/>
        public void Resize(double width, double height) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Resize(width, height));

        /// <inheritdoc/>
        public void Rotate(double degrees) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Rotate(degrees));

        /// <inheritdoc/>
        public void SetDockPosition(DockPosition dockPosition) =>  ActionHandler.Perform(() => ((DockPattern)this.GetCurrentPattern(DockPattern.Pattern)).SetDockPosition(dockPosition));
    }
}