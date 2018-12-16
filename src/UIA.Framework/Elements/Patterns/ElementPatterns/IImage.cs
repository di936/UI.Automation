namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Image should implement <see cref="IElement"/>, <see cref="IGridItem"/>, <see cref="ITableItem"/>, <see cref="IInvoke"/>, <see cref="ISelectionItem"/>.
    /// </summary>
    public interface IImage : IElement, IGridItem, ITableItem, IInvoke, ISelectionItem
    {
    }
}