namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// MenuItem should implement <see cref="IElement"/>, <see cref="IExpandCollapse"/>, <see cref="IInvoke"/>, <see cref="IToggle"/>, <see cref="ISelectionItem"/> and menu items invocation.
    /// </summary>
    public interface IMenuItem : IElement, IExpandCollapse, IInvoke, IToggle, ISelectionItem
    {
        // void InvokeByPath(string[] path);
    }
}