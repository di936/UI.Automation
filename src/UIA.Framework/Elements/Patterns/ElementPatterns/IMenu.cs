namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    /// <summary>
    /// Menu should implement <see cref="IElement"/> and menu items invocation.
    /// </summary>
    public interface IMenu : IElement
    {
        /// <summary>
        /// Invoke <see cref="IMenuItem"/> from <see cref="IMenu"/>.
        /// </summary>
        /// <param name="path">Invoke <see cref="IMenuItem"/> in <see cref="IMenu"/>.</param>
        void InvokeByPath(string[] path);
    }
}