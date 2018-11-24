using System.Windows.Automation;
using UIA.Framework.Viewers;

namespace UIA.Framework.Elements
{
    interface IElement : IFinder
    {
        string Name { get; }
        string Id { get; }
        ControlType RawType { get; }
        int WindowHandle { get; }
    }
}