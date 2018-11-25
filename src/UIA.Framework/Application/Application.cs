using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Automation;
using UIA.Framework.Configuration;
using UIA.Framework.Elements;
using UIA.Framework.Viewers;

namespace UIA.Framework.Application
{
    public class Application : IApplication
    {
        protected TreeViewer Viewer;

        public Window CurrentWindow { get; set; } 

        public Application(string name, ViewerMode mode = ViewerMode.RawView)
        {
            CurrentWindow = new TreeViewer(AutomationElement.RootElement).FindByName<Window>(name);
            Viewer = new TreeViewer(AutomationElement.FromHandle((IntPtr)CurrentWindow.WindowHandle), mode);
        }

        public Application(Process process, ViewerMode mode = ViewerMode.RawView)
        {
            CurrentWindow = new Window(AutomationElement.FromHandle(process.MainWindowHandle));
            Viewer = new TreeViewer(AutomationElement.FromHandle(process.MainWindowHandle), mode);
        }

        public T Find<T>() => CurrentWindow.Find<T>();
        public List<T> FindAll<T>() => CurrentWindow.FindAll<T>();
        public T FindByName<T>(string name) => CurrentWindow.FindByName<T>(name);
        public T FindById<T>(string id) => CurrentWindow.FindById<T>(id);
        public T FindByWindowHandle<T>(int handle) => CurrentWindow.FindByWindowHandle<T>(handle);
        public void SetCurrentWindow(string windowName) => CurrentWindow = ActionHandler.Perform(() => Viewer.FindByName<Window>(windowName));
        public void SetDefaultWindow() => CurrentWindow = ActionHandler.Perform(() => new Window(AutomationElement.FromHandle((IntPtr)Viewer.RootElement.Current.NativeWindowHandle)));
    }
}