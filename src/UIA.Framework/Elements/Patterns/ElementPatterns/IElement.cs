using System.Windows.Automation;
using UIA.Framework.Viewers;

namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    public interface IElement
    {
        string Name { get; }
        string Id { get; }
        ControlType RawType { get; }
        int WindowHandle { get; }
        void SetFocus();
    }
}