using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Automation;
using UIA.Framework.Configuration;
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

        public T Find<T>() => ActionHandler.Perform(() => Viewer.Find<T>());
        public List<T> FindAll<T>() => ActionHandler.Perform(() => Viewer.FindAll<T>());
        public T FindByName<T>(string name) => ActionHandler.Perform(() => Viewer.FindByName<T>(name));
        public T FindById<T>(string id) => ActionHandler.Perform(() => Viewer.FindById<T>(id));
        public T FindByWindowHandle<T>(int handle) => ActionHandler.Perform(() => Viewer.FindByWindowHandle<T>(handle));

    }
}