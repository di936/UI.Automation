using System.Diagnostics;
using System.Threading;
using System.Windows.Automation;

namespace UIA.TestRunner
{
    public class TestRunner
    {
        public static void Main(string[] args)
        {
            var total = @"c:\Program Files\Total Commander\TOTALCMD64.EXE";
            var notepad = @"";

            var processInfo = new ProcessStartInfo(notepad);
            var process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            Thread.Sleep(1000);

            var element = new TreeViewer(AutomationElement.FromHandle(process.MainWindowHandle)).Find<MenuBar>().Find<MenuItem>();
        }
    }
}
