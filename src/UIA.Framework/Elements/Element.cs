using System;
using System.Collections.Generic;
using System.Windows;
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
        #region Fields

        private AutomationElement rawElement;

        #endregion

        #region Properties

        public AutomationElement RawElement
        {
            get => rawElement;

            set
            {
                if (RawType.Equals(value.Current.ControlType)) rawElement = value;
                else throw new InvalidCastException($"Cannot set AutomationElement with {value.Current.ControlType.ProgrammaticName} to element with {RawElement.Current.ControlType.ProgrammaticName}");
            }
        }

        public ControlType RawType => RawElement.Current.ControlType;

        public virtual string Name => RawElement.Current.Name;

        public virtual string Id => RawElement.Current.AutomationId;

        public virtual int WindowHandle => RawElement.Current.NativeWindowHandle;

        public virtual string AcceleratorKey => RawElement.Current.AcceleratorKey;

        public virtual string AccessKey => RawElement.Current.AccessKey;

        public virtual Rect BoundingRectangle => RawElement.Current.BoundingRectangle;

        public virtual string ClassName => RawElement.Current.ClassName;

        public virtual string FrameworkId => RawElement.Current.FrameworkId;

        public virtual bool HasKeyboardFocus => RawElement.Current.HasKeyboardFocus;

        public virtual string HelpText => RawElement.Current.HelpText;

        public virtual bool IsContentElement => RawElement.Current.IsContentElement;

        public virtual bool IsControlElement => RawElement.Current.IsControlElement;

        public virtual bool IsEnabled => RawElement.Current.IsEnabled;

        public virtual bool IsKeyboardFocusable => RawElement.Current.IsKeyboardFocusable;

        public virtual bool IsOffscreen => RawElement.Current.IsOffscreen;

        public virtual bool IsPassword => RawElement.Current.IsPassword;

        public virtual bool IsRequiredForForm => RawElement.Current.IsRequiredForForm;

        public virtual string ItemStatus => RawElement.Current.ItemStatus;

        public virtual string ItemType => RawElement.Current.ItemType;

        public virtual AutomationElement LabeledBy => RawElement.Current.LabeledBy;

        public string LocalizedControlType => RawElement.Current.LocalizedControlType;

        public virtual OrientationType Orientation => RawElement.Current.Orientation;

        public int ProcessId => RawElement.Current.ProcessId;

        #endregion

        #region Constructors

        public Element(AutomationElement element) => this.rawElement = element;

        #endregion Constructors

        #region Methods

        #region Find Methods

        public T Find<T>() => ActionHandler.Perform(() => new TreeViewer(RawElement).Find<T>());

        public T FindById<T>(string id) => ActionHandler.Perform(() => new TreeViewer(RawElement).FindById<T>(id));

        public T FindByName<T>(string name) => ActionHandler.Perform(() => new TreeViewer(RawElement).FindByName<T>(name));

        public List<T> FindAll<T>() => ActionHandler.Perform(() => new TreeViewer(RawElement).FindAll<T>());

        public T FindByWindowHandle<T>(int handle) => ActionHandler.Perform(() => new TreeViewer(RawElement).FindByWindowHandle<T>(handle));

        #endregion

        public void Click()
        {
            var point = GetClickablePoint();
            Mouse.Click((int)point.X, (int)point.Y);
        }
    
        public Point GetClickablePoint() => ActionHandler.Perform(() => RawElement.GetClickablePoint());

        public void SetFocus() => ActionHandler.Perform(() => RawElement.SetFocus());

        public List<AutomationPattern> GetSupportedPatterns() => ActionHandler.Perform(() => new List<AutomationPattern>(RawElement.GetSupportedPatterns()));

        public List<AutomationProperty> GetSupportedProperties() => ActionHandler.Perform(() => new List<AutomationProperty>(RawElement.GetSupportedProperties()));

        public object GetCurrentPattern(AutomationPattern pattern) => ActionHandler.Perform(() => RawElement.GetCurrentPattern(pattern));

        public object GetCurrentPropertyValue(AutomationProperty property) => ActionHandler.Perform(() => RawElement.GetCurrentPropertyValue(property));

        public object GetCurrentPropertyValue(AutomationProperty property, bool ignoreDefaultValue) => ActionHandler.Perform(() => RawElement.GetCurrentPropertyValue(property, ignoreDefaultValue));

        #endregion
    }
}
