using System.Windows.Automation;
using UIA.Framework.Configuration;
using UIA.Framework.Elements.Patterns.ElementPatterns;
using UIA.Framework.Viewers;

namespace UIA.Framework.Elements
{
    public class MenuBar : Element, IMenuBar
    {
        public MenuBar(AutomationElement element) : base(element)
        {

        }

        public ExpandCollapseState ExpandCollapseState => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Current.ExpandCollapseState;

        public DockPosition DockPosition => ((DockPattern)RawElement.GetCurrentPattern(DockPattern.Pattern)).Current.DockPosition;

        public bool CanMove => ((TransformPattern)RawElement.GetCurrentPattern(TransformPattern.Pattern)).Current.CanMove;

        public bool CanResize => ((TransformPattern)RawElement.GetCurrentPattern(TransformPattern.Pattern)).Current.CanResize;

        public bool CanRotate => ((TransformPattern)RawElement.GetCurrentPattern(TransformPattern.Pattern)).Current.CanRotate;

        public void InvokeByPath(string[] path)
        {
            var element = new TreeViewer(RawElement).FindByName<MenuItem>(path[0]);
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

        public void Collapse()
        {
            ActionHandler.Perform(() => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Collapse());
        }

        public void Expand()
        {
            ActionHandler.Perform(() => ((ExpandCollapsePattern)RawElement.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Expand());
        }

        public void Move(double x, double y)
        {
            ActionHandler.Perform(() => ((TransformPattern)RawElement.GetCurrentPattern(TransformPattern.Pattern)).Move(x,y));
        }

        public void Resize(double width, double height)
        {
            ActionHandler.Perform(() => ((TransformPattern)RawElement.GetCurrentPattern(TransformPattern.Pattern)).Resize(width, height));
        }

        public void Rotate(double degrees)
        {
            ActionHandler.Perform(() => ((TransformPattern)RawElement.GetCurrentPattern(TransformPattern.Pattern)).Rotate(degrees));
        }

        public void SetDockPosition(DockPosition dockPosition)
        {
            ActionHandler.Perform(() => ((DockPattern)RawElement.GetCurrentPattern(DockPattern.Pattern)).SetDockPosition(dockPosition));
        }
    }
}
