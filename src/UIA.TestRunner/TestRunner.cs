using System.Diagnostics;
using System.Threading;
using System.Windows.Automation;
using UIA.Framework.Application;
using UIA.Framework.Devices;
using UIA.Framework.Elements;
using UIA.Framework.Viewers;

namespace UIA.TestRunner
{
    public class TestRunner
    {
        public static void Main(string[] args)
        {
            var notepad = @"D:\TM\bug.txt";

            var processInfo = new ProcessStartInfo(notepad);
            var process = new Process
            {
                StartInfo = processInfo
            };

            process.Start();
            Thread.Sleep(1000);

            var app = new BaseApplication(process);

            new TreeViewer(AutomationElement.FromHandle(process.MainWindowHandle)).FindByName<Button>("Close").Invoke();
        }
    }
}
