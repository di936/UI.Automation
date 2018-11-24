using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Automation;
using UIA.Framework.Devices;
using UIA.Framework.Elements.Mappings;
using UIA.Framework.Viewers;

namespace UIA.Framework.Elements
{
    ///<summary>
    /// Basic UI element. Wrapper for <see cref="AutomationElement"/>
    ///</summary>
    public class Element : IElement
    {
        protected AutomationElement RawElement;

        public ControlType RawType => RawElement.Current.ControlType;

        public System.Windows.Point ClickablePoint => RawElement.GetClickablePoint();

        public string Name => RawElement.Current.Name;

        public string Id => RawElement.Current.AutomationId;

        public int WindowHandle => RawElement.Current.NativeWindowHandle;

        public Element(AutomationElement element)
        {
            RawElement = element;
        }

        public void Click()
        {
            var point = ClickablePoint;
            Mouse.Click((int)point.X, (int)point.Y);
        }

        public T Find<T>() => new TreeViewer(RawElement).Find<T>();

        public T FindById<T>(string id) => new TreeViewer(RawElement).FindById<T>(id);

        public T FindByName<T>(string name) => new TreeViewer(RawElement).FindByName<T>(name);

        public List<T> FindAll<T>() => new TreeViewer(RawElement).FindAll<T>();

        public T FindByWindowHandle<T>(int handle) => new TreeViewer(RawElement).FindByWindowHandle<T>(handle);
    }
}
