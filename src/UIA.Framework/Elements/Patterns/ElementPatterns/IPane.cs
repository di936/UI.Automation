namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Pane should implement <see cref="IElement"/>, <see cref="ITransform"/>, <see cref="ControlPatterns.IWindow"/>, <see cref="IDock"/>, <see cref="IScroll"/>.
    /// </summary>
    public interface IPane : IElement, ITransform, ControlPatterns.IWindow, IDock, IScroll
    {
    }
}