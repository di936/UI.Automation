namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Tree should implement <see cref="IElement"/>, <see cref="ISelection"/>, <see cref="IScroll"/>.
    /// </summary>
    public interface ITree : IElement, ISelection, IScroll
    {
    }
}