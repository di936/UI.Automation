namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Text should implement <see cref="IElement"/>, <see cref="IValue"/>, <see cref="ControlPatterns.IText"/>, <see cref="ITableItem"/>, <see cref="IRangeValue"/>.
    /// </summary>
    public interface IText : IElement, IValue, ControlPatterns.IText, ITableItem, IRangeValue
    {
    }
}