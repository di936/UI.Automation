namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// TreeItem should implement <see cref="IElement"/>, <see cref="IExpandCollapse"/>, <see cref="IInvoke"/>, <see cref="IScrollItem"/>, <see cref="ISelectionItem"/>, <see cref="IToggle"/>.
    /// </summary>
    public interface ITreeItem : IElement, IExpandCollapse, IInvoke, IScrollItem, ISelectionItem, IToggle
    {
    }
}