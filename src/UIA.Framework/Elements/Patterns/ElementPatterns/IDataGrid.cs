namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// DataGrid should implement <see cref="IElement"/>, <see cref="IGrid"/>, <see cref="IScroll"/>, <see cref="ISelection"/>, <see cref="ControlPatterns.ITable"/>.
    /// </summary>
    public interface IDataGrid : IElement, IGrid, IScroll, ISelection, ControlPatterns.ITable
    {
    }
}
