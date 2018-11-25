using UIA.Framework.Elements;
using UIA.Framework.Viewers;

namespace UIA.Framework.Application
{
    public interface IApplication : IFinder
    {
        Window CurrentWindow { get; set; }
        void SetCurrentWindow(string windowName);
    }
}
