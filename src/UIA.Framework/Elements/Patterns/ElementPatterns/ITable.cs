namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Table should implement <see cref="IElement"/>, <see cref="IGrid"/>, <see cref="IGridItem"/>, <see cref="ControlPatterns.ITable"/>, <see cref="ITableItem"/>.
    /// </summary>
    public interface ITable : IElement, IGrid, IGridItem, ControlPatterns.ITable, ITableItem
    {
    }
}