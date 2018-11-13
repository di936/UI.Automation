using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Automation;
using UIA.Framework.Viewers;

namespace UIA.Framework.Application
{
    public class BaseApplication
    {
        protected TreeViewer Viewer;
        public BaseApplication(Process process)
        {
            Viewer = new TreeViewer(AutomationElement.FromHandle(process.MainWindowHandle));
        }

        public BaseApplication(Process process, ViewerMode mode)
        {
            Viewer = new TreeViewer(AutomationElement.FromHandle(process.MainWindowHandle), mode);
        }

        public T Find<T>() => Viewer.Find<T>();
        public List<T> FindAll<T>() => Viewer.FindAll<T>();
        public T FindByName<T>(string name) => Viewer.FindByName<T>(name);
        public T FindById<T>(string id) => Viewer.FindById<T>(id);

    }
}