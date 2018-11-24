using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Automation;
using UIA.Framework.Elements;
using UIA.Framework.Viewers;

namespace UIA.Framework.Application
{
    public class Application : IFinder
    {
        protected TreeViewer Viewer;
        public Application(string name)
        {
            var window = new TreeViewer(AutomationElement.RootElement).FindByName<Window>(name);
            Viewer = new TreeViewer(AutomationElement.FromHandle((IntPtr)window.WindowHandle));
        }

        public Application(Process process)
        {
            Viewer = new TreeViewer(AutomationElement.FromHandle(process.MainWindowHandle));
        }

        public Application(Process process, ViewerMode mode)
        {
            Viewer = new TreeViewer(AutomationElement.FromHandle(process.MainWindowHandle), mode);
        }

        public T Find<T>() => Viewer.Find<T>();
        public List<T> FindAll<T>() => Viewer.FindAll<T>();
        public T FindByName<T>(string name) => Viewer.FindByName<T>(name);
        public T FindById<T>(string id) => Viewer.FindById<T>(id);
        public T FindByWindowHandle<T>(int handle) => Viewer.FindByWindowHandle<T>(handle);

    }
}