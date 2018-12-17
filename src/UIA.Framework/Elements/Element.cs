namespace UIA.Framework.Elements
{
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Devices;
    using UIA.Framework.Elements.Patterns.ElementPatterns;
    using UIA.Framework.Viewers;

    /// <summary>
    /// Basic UI element with search functions. Wrapper for <see cref="AutomationElement"/>.
    /// </summary>
    public class Element : IElement, IFinder
    {
        private AutomationElement rawElement;

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="element">Wrapped <see cref="AutomationElement"/>.</param>
        public Element(AutomationElement element)
        {
            this.rawElement = element;
        }

        /// <summary>
        /// Gets or sets get wrapped <see cref="AutomationElement"/>.
        /// </summary>
        public AutomationElement RawElement
        {
            get => this.rawElement;

            set
            {
                if (this.RawType.Equals(value.Current.ControlType))
                {
                    this.rawElement = value;
                }
                else
                {
                    throw new InvalidCastException($"Cannot set AutomationElement with {value.Current.ControlType.ProgrammaticName} to element with {this.RawElement.Current.ControlType.ProgrammaticName}");
                }
            }
        }

        /// <inheritdoc/>
        public ControlType RawType => RawElement.Current.ControlType;

        /// <inheritdoc/>
        public virtual string Name => RawElement.Current.Name;

        /// <inheritdoc/>
        public virtual string Id => RawElement.Current.AutomationId;

        /// <inheritdoc/>
        public virtual int WindowHandle => RawElement.Current.NativeWindowHandle;

        /// <inheritdoc/>
        public virtual string AcceleratorKey => RawElement.Current.AcceleratorKey;

        /// <inheritdoc/>
        public virtual string AccessKey => RawElement.Current.AccessKey;

        /// <inheritdoc/>
        public virtual Rect BoundingRectangle => RawElement.Current.BoundingRectangle;

        /// <inheritdoc/>
        public virtual string ClassName => RawElement.Current.ClassName;

        /// <inheritdoc/>
        public virtual string FrameworkId => RawElement.Current.FrameworkId;

        /// <inheritdoc/>
        public virtual bool HasKeyboardFocus => RawElement.Current.HasKeyboardFocus;

        /// <inheritdoc/>
        public virtual string HelpText => RawElement.Current.HelpText;

        /// <inheritdoc/>
        public virtual bool IsContentElement => RawElement.Current.IsContentElement;

        /// <inheritdoc/>
        public virtual bool IsControlElement => RawElement.Current.IsControlElement;

        /// <inheritdoc/>
        public virtual bool IsEnabled => RawElement.Current.IsEnabled;

        /// <inheritdoc/>
        public virtual bool IsKeyboardFocusable => RawElement.Current.IsKeyboardFocusable;

        /// <inheritdoc/>
        public virtual bool IsOffscreen => RawElement.Current.IsOffscreen;

        /// <inheritdoc/>
        public virtual bool IsPassword => RawElement.Current.IsPassword;

        /// <inheritdoc/>
        public virtual bool IsRequiredForForm => RawElement.Current.IsRequiredForForm;

        /// <inheritdoc/>
        public virtual string ItemStatus => RawElement.Current.ItemStatus;

        /// <inheritdoc/>
        public virtual string ItemType => RawElement.Current.ItemType;

        /// <inheritdoc/>
        public virtual AutomationElement LabeledBy => RawElement.Current.LabeledBy;

        /// <inheritdoc/>
        public string LocalizedControlType => RawElement.Current.LocalizedControlType;

        /// <inheritdoc/>
        public virtual OrientationType Orientation => RawElement.Current.Orientation;

        /// <inheritdoc/>
        public int ProcessId => RawElement.Current.ProcessId;

        /// <inheritdoc/>
        public T Find<T>() => ActionHandler.Perform(() => new TreeViewer(this.RawElement).Find<T>());

        /// <inheritdoc/>
        public T FindById<T>(string id) => ActionHandler.Perform(() => new TreeViewer(this.RawElement).FindById<T>(id));

        /// <inheritdoc/>
        public T FindByName<T>(string name) => ActionHandler.Perform(() => new TreeViewer(this.RawElement).FindByName<T>(name));

        /// <inheritdoc/>
        public List<T> FindAll<T>() => ActionHandler.Perform(() => new TreeViewer(this.RawElement).FindAll<T>());

        /// <inheritdoc/>
        public T FindByWindowHandle<T>(int handle) => ActionHandler.Perform(() => new TreeViewer(this.RawElement).FindByWindowHandle<T>(handle));

        /// <summary>
        /// Gets clickable point for wrapper <see cref="AutomationElement"/> and clicks using WindowsAPI mouse click.
        /// </summary>
        public void Click()
        {
            var point = this.GetClickablePoint();
            ActionHandler.Perform(() => Mouse.Click((int)point.X, (int)point.Y));
        }

        /// <inheritdoc/>
        public Point GetClickablePoint() => ActionHandler.Perform(() => this.RawElement.GetClickablePoint());

        /// <inheritdoc/>
        public void SetFocus() => ActionHandler.Perform(() => this.RawElement.SetFocus());

        /// <inheritdoc/>
        public List<AutomationPattern> GetSupportedPatterns() => ActionHandler.Perform(() => new List<AutomationPattern>(this.RawElement.GetSupportedPatterns()));

        /// <inheritdoc/>
        public List<AutomationProperty> GetSupportedProperties() => ActionHandler.Perform(() => new List<AutomationProperty>(this.RawElement.GetSupportedProperties()));

        /// <inheritdoc/>
        public object GetCurrentPattern(AutomationPattern pattern) => ActionHandler.Perform(() => this.RawElement.GetCurrentPattern(pattern));

        /// <inheritdoc/>
        public object GetCurrentPropertyValue(AutomationProperty property) => ActionHandler.Perform(() => this.RawElement.GetCurrentPropertyValue(property));

        /// <inheritdoc/>
        public object GetCurrentPropertyValue(AutomationProperty property, bool ignoreDefaultValue) => ActionHandler.Perform(() => this.RawElement.GetCurrentPropertyValue(property, ignoreDefaultValue));
    }
}
