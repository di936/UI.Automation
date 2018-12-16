namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Calendar should implement <see cref="IElement"/>, <see cref="IGrid"/>, <see cref="IScroll"/>, <see cref="ISelection"/>, <see cref="ControlPatterns.ITable"/>, <see cref="IValue"/>.
    /// </summary>
    public interface ICalendar : IElement, IGrid, IScroll, ISelection, ControlPatterns.ITable, IValue
    {
    }
}
