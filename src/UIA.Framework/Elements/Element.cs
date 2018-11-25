using System;
using System.Collections.Generic;
using System.Windows.Automation;
using UIA.Framework.Configuration;
using UIA.Framework.Devices;
using UIA.Framework.Elements.Patterns.ElementPatterns;
using UIA.Framework.Viewers;

namespace UIA.Framework.Elements
{
    ///<summary>
    /// Basic UI element with search functions. Wrapper for <see cref="AutomationElement"/>
    ///</summary>
    public class Element : IElement, IFinder
    {
        private AutomationElement _rawElement;

        public AutomationElement RawElement
        {
            get => _rawElement;
            set
            {
                if (RawType.Equals(value.Current.ControlType)) _rawElement = value;
                else throw new InvalidCastException($"Cannot set AutomationElement with {value.Current.ControlType.ProgrammaticName} to element with {RawElement.Current.ControlType.ProgrammaticName}");
            }
        }

        public ControlType RawType => RawElement.Current.ControlType;

        public System.Windows.Point ClickablePoint => ActionHandler.Perform(() => RawElement.GetClickablePoint());

        public string Name => RawElement.Current.Name;

        public string Id => RawElement.Current.AutomationId;

        public int WindowHandle => RawElement.Current.NativeWindowHandle;

        public void SetFocus() => ActionHandler.Perform(() => RawElement.SetFocus());

        public Element(AutomationElement element)
        {
            _rawElement = element;
        }

        public void Click()
        {
            var point = ClickablePoint;
            Mouse.Click((int)point.X, (int)point.Y);
        }

        public T Find<T>() => ActionHandler.Perform(() => new TreeViewer(RawElement).Find<T>());

        public T FindById<T>(string id) => ActionHandler.Perform(() => new TreeViewer(RawElement).FindById<T>(id));

        public T FindByName<T>(string name) => ActionHandler.Perform(() => new TreeViewer(RawElement).FindByName<T>(name));

        public List<T> FindAll<T>() => ActionHandler.Perform(() => new TreeViewer(RawElement).FindAll<T>());

        public T FindByWindowHandle<T>(int handle) => ActionHandler.Perform(() => new TreeViewer(RawElement).FindByWindowHandle<T>(handle));
    }
}
