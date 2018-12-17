namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Slider should implement <see cref="IElement"/>, <see cref="ISelection"/>, <see cref="IRangeValue"/>, <see cref="IValue"/>.
    /// </summary>
    public interface ISlider : IElement, ISelection, IRangeValue, IValue
    {
    }
}