namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Document should implement <see cref="IElement"/>, <see cref="IScroll"/>, <see cref="ControlPatterns.IText"/>, <see cref="IValue"/>.
    /// </summary>
    public interface IDocument : IElement, IScroll, ControlPatterns.IText, IValue
    {
    }
}
