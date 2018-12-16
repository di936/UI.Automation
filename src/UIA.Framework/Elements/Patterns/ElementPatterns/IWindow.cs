namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Window should implement <see cref="IElement"/>, <see cref="IDock"/>, <see cref="ITransform"/>, <see cref="ControlPatterns.IWindow"/>.
    /// </summary>
    public interface IWindow : IElement, IDock, ITransform, ControlPatterns.IWindow
    {
    }
}