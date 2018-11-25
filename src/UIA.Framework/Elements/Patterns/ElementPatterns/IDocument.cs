using UIA.Framework.Elements.Patterns.ControlPatterns;

namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    public interface IDocument : IElement, IScroll, ControlPatterns.IText, IValue
    {
    }
}
