using UIA.Framework.Elements.Patterns.ControlPatterns;

namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    interface IDocument : IElement, IScroll, ControlPatterns.IText, IValue
    {
    }
}
