using System.Diagnostics;
using System.Windows.Automation;
using UIA.Framework.Viewers;

namespace UIA.Framework.Application
{
    public class BaseApplication
    {
        public bool Active => Viewer.

        protected TreeViewer Viewer;
        public BaseApplication(Process process)
        {
            Viewer = new TreeViewer(AutomationElement.FromHandle(process.MainWindowHandle));
        }

        public BaseApplication(Process process, ViewerMode mode)
        {
            Viewer = new TreeViewer(AutomationElement.FromHandle(process.MainWindowHandle), mode);
        }


    }
}