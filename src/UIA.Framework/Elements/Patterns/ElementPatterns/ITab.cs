namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// TabControl should implement <see cref="IElement"/>, <see cref="ISelection"/>, <see cref="IScroll"/>.
    /// </summary>
    public interface ITab : IElement, ISelection, IScroll
    {
    }
}