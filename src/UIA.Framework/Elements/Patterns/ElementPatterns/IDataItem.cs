namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// DataItem should implement <see cref="IElement"/>, <see cref="IExpandCollapse"/>, <see cref="IGridItem"/>, <see cref="IScrollItem"/>, <see cref="ISelectionItem"/>, <see cref="ITableItem"/>, <see cref="IToggle"/>, <see cref="IValue"/>.
    /// </summary>
    public interface IDataItem : IElement, IExpandCollapse, IGridItem, IScrollItem, ISelectionItem, ITableItem, IToggle, IValue
    {
    }
}