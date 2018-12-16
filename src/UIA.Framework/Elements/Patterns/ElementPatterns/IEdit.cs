namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Edit should implement <see cref="IElement"/>, <see cref="IText"/>, <see cref="IValue"/>, <see cref="IRangeValue"/>.
    /// </summary>
    public interface IEdit : IElement, IText, IValue, IRangeValue
    {

    }
}
