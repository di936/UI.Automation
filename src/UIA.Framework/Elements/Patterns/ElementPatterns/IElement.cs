using System.Windows.Automation;
using UIA.Framework.Viewers;

namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    interface IElement
    {
        string Name { get; }
        string Id { get; }
        ControlType RawType { get; }
        int WindowHandle { get; }
    }
}