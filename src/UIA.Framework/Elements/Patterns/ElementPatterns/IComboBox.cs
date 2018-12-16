namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Checkbox should implement <see cref="IElement"/>, <see cref="IExpandCollapse"/>, <see cref="ISelection"/>, <see cref="IValue"/>, <see cref="IScroll"/>.
    /// </summary>
    public interface IComboBox : IElement, IExpandCollapse, ISelection, IValue, IScroll
    {
    }
}
