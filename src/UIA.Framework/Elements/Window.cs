using System.Windows.Automation;
using UIA.Framework.Configuration;
using UIA.Framework.Elements.Patterns.ElementPatterns;

namespace UIA.Framework.Elements
{
    public class Window : Element, IWindow
    {
        public Window(AutomationElement element) : base(element)
        {
            
        }

        public DockPosition DockPosition => ((DockPattern)RawElement.GetCurrentPattern(DockPattern.Pattern)).Current.DockPosition;

        public bool CanMove => ((TransformPattern)RawElement.GetCurrentPattern(TransformPattern.Pattern)).Current.CanMove;

        public bool CanResize => ((TransformPattern)RawElement.GetCurrentPattern(TransformPattern.Pattern)).Current.CanResize;

        public bool CanRotate => ((TransformPattern)RawElement.GetCurrentPattern(TransformPattern.Pattern)).Current.CanRotate;

        public WindowInteractionState InteractionState => ((WindowPattern)RawElement.GetCurrentPattern(WindowPattern.Pattern)).Current.WindowInteractionState;

        public bool IsModal => ((WindowPattern)RawElement.GetCurrentPattern(WindowPattern.Pattern)).Current.IsModal;

        public bool IsTopmost => ((WindowPattern)RawElement.GetCurrentPattern(WindowPattern.Pattern)).Current.IsTopmost;

        public bool Maximizable => ((WindowPattern)RawElement.GetCurrentPattern(WindowPattern.Pattern)).Current.CanMaximize;

        public bool Minimizable => ((WindowPattern)RawElement.GetCurrentPattern(WindowPattern.Pattern)).Current.CanMinimize;

        public WindowVisualState VisualState => ((WindowPattern)RawElement.GetCurrentPattern(WindowPattern.Pattern)).Current.WindowVisualState;

        public void Close()
        {
            ActionHandler.Perform(() => ((WindowPattern)RawElement.GetCurrentPattern(WindowPattern.Pattern)).Close());
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

        public void SetVisualState(WindowVisualState state)
        {
            ActionHandler.Perform(() => ((WindowPattern)RawElement.GetCurrentPattern(WindowPattern.Pattern)).SetWindowVisualState(state));
        }

        public bool WaitForInputIdle(int milliseconds)
        {
            return ActionHandler.Perform(() => ((WindowPattern)RawElement.GetCurrentPattern(WindowPattern.Pattern)).WaitForInputIdle(milliseconds));
        }
    }
}
