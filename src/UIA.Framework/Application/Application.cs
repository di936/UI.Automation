namespace UIA.Framework.Application
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements;
    using UIA.Framework.Viewers;

    /// <summary>
    /// Class that represents an application instance with corresponding methods (finders, windows,...).
    /// </summary>
    public class Application : IApplication
    {
        /// <summary>
        /// <see cref="TreeViewer"/> instance for searching <see cref="Element"/> objects using implemented <see cref="IFinder"/> methods.
        /// </summary>
        protected TreeViewer Viewer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Application"/> class.
        /// </summary>
        /// <param name="name">Basically it's application title.</param>
        /// <param name="mode">Enum ViewerMode for seaching mode switching.</param>
        public Application(string name, ViewerMode mode = ViewerMode.RawView)
        {
            this.CurrentWindow = new TreeViewer(AutomationElement.RootElement).FindByName<Window>(name);
            this.DefaultWindow = this.CurrentWindow;
            this.Viewer = new TreeViewer(AutomationElement.FromHandle((IntPtr)this.CurrentWindow.WindowHandle), mode);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Application"/> class.
        /// </summary>
        /// <param name="process">Process instance of your application.</param>
        /// <param name="mode">Enum ViewerMode for seaching mode switching.</param>
        public Application(Process process, ViewerMode mode = ViewerMode.RawView)
        {
            this.CurrentWindow = new Window(AutomationElement.FromHandle(process.MainWindowHandle));
            this.DefaultWindow = this.CurrentWindow;
            this.Viewer = new TreeViewer(AutomationElement.FromHandle(process.MainWindowHandle), mode);
        }

        /// <summary>
        /// Gets or sets current <see cref="Window"/> instance where objects are searched.
        /// </summary>
        public Window CurrentWindow { get; set; }

        /// <summary>
        /// Gets or sets default <see cref="Window"/> for <see cref="Application"/>.
        /// </summary>
        public Window DefaultWindow { get; set; }

        /// <summary>
        /// Gets <see cref="{T}"/> element in current window.
        /// </summary>
        /// <typeparam name="T"><see cref="UIA.Framework.Elements"/> objects.</typeparam>
        /// <returns>Returns first <typeparamref name="T"/> object in current window.</returns>
        public T Find<T>() => this.CurrentWindow.Find<T>();

        /// <summary>
        /// Gets <see cref="List{T}"/> element in current window.
        /// </summary>
        /// <typeparam name="T"><see cref="UIA.Framework.Elements"/> objects.</typeparam>
        /// <returns>Returns all <typeparamref name="T"/> objects in current window.</returns>
        public List<T> FindAll<T>() => this.CurrentWindow.FindAll<T>();

        /// <summary>
        /// Gets <see cref="{T}"/> element with <paramref name="name"></paramref> in current window.
        /// </summary>
        /// <typeparam name="T"><see cref="UIA.Framework.Elements"/> objects.</typeparam>
        /// <param name="name">Name of <see cref="{T}"/> element.</param>
        /// <returns>Returns first <typeparamref name="T"/> object with <paramref name="name"></paramref> in current window.</returns>
        public T FindByName<T>(string name) => this.CurrentWindow.FindByName<T>(name);

        /// <summary>
        /// Gets <see cref="{T}"/> element with <paramref name="id"></paramref> in current window.
        /// </summary>
        /// <typeparam name="T"><see cref="UIA.Framework.Elements"/> objects.</typeparam>
        /// <param name="id">AutomationID of <see cref="{T}"/> element.</param>
        /// <returns>Returns first <typeparamref name="T"/> object with <paramref name="id"></paramref> in current window.</returns>
        public T FindById<T>(string id) => this.CurrentWindow.FindById<T>(id);

        /// <summary>
        /// Gets <see cref="{T}"/> element with <paramref name="handle"></paramref> in current window.
        /// </summary>
        /// <typeparam name="T"><see cref="UIA.Framework.Elements"/> objects.</typeparam>
        /// <param name="handle">NativeWindowHandle of <see cref="{T}"/> element.</param>
        /// <returns>Returns first <typeparamref name="T"/> object with <paramref name="handle"></paramref> in current window.</returns>
        public T FindByWindowHandle<T>(int handle) => this.CurrentWindow.FindByWindowHandle<T>(handle);

        /// <summary>
        /// Sets current window.
        /// </summary>
        /// <param name="windowName">Window name.</param>
        public void SetCurrentWindow(string windowName) => this.CurrentWindow = ActionHandler.Perform(() => this.Viewer.FindByName<Window>(windowName), Timeouts.Find);

        /// <summary>
        /// Sets default window.
        /// </summary>
        /// <param name="windowName">Window name.</param>
        public void SetDefaultWindow(string windowName)
        {
            this.DefaultWindow = ActionHandler.Perform(() => new Window(new TreeViewer(AutomationElement.RootElement).FindByName<Window>(windowName).RawElement), Timeouts.Find);
            this.Viewer.RootElement = this.DefaultWindow.RawElement;
        }
    }
}