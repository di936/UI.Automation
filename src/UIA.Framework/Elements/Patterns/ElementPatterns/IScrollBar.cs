namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// ScrollBar should implement <see cref="IElement"/>, <see cref="IScroll"/>, <see cref="IRangeValue"/>.
    /// </summary>
    public interface IScrollBar : IElement, IScroll, IRangeValue
    {
    }
}