namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// ListControl should implement <see cref="IElement"/>, <see cref="ISelection"/>, <see cref="IScroll"/>, <see cref="IGrid"/>, <see cref="IMultipleView"/>, <see cref="ControlPatterns.ITable"/>.
    /// </summary>
    public interface IListControl : IElement, ISelection, IScroll, IGrid, IMultipleView, ControlPatterns.ITable
    {
    }
}