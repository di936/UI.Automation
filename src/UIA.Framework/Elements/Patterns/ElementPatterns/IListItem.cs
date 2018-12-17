namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// ListItem should implement <see cref="IElement"/>, <see cref="ISelection"/>, <see cref="IScroll"/>, <see cref="IToggle"/>, <see cref="IExpandCollapse"/>, <see cref="IValue"/>, <see cref="IGridItem"/>, <see cref="IInvoke"/>.
    /// </summary>
    public interface IListItem : IElement, ISelection, IScroll, IToggle, IExpandCollapse, IValue, IGridItem, IInvoke
    {
    }
}