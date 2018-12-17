namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// ToolBar should implement <see cref="IElement"/>, <see cref="IExpandCollapse"/>, <see cref="IDock"/>, <see cref="ITransform"/>.
    /// </summary>
    public interface IToolBar : IElement, IExpandCollapse, IDock, ITransform
    {
    }
}