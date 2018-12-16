namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    using UIA.Framework.Elements.Patterns.ControlPatterns;

    /// <summary>
    /// Menubar should implement <see cref="IElement"/>, <see cref="IExpandCollapse"/>, <see cref="IDock"/>, <see cref="ITransform"/> and menu items invocation.
    /// </summary>
    public interface IMenuBar : IElement, IExpandCollapse, IDock, ITransform
    {
        /// <summary>
        /// Invoke <see cref="IMenuItem"/> from <see cref="IMenuBar"/>.
        /// </summary>
        /// <param name="path">Invoke <see cref="IMenuItem"/> in <see cref="IMenuBar"/>.</param>
        void InvokeByPath(string[] path);
    }
}