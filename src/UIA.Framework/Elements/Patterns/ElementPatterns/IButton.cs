namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Button should implement <see cref="IElement"/>, <see cref="IInvoke"/>, <see cref="IToggle"/>, <see cref="IExpandCollapse"/>.
    /// </summary>
    public interface IButton : IElement, IInvoke, IToggle, IExpandCollapse
    {
    }
}
