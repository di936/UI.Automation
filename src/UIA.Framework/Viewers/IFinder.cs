namespace UIA.Framework.Viewers
{
    using System.Collections.Generic;
    using UIA.Framework.Elements;

    /// <summary>
    /// Should implement following methods to find elements
    /// </summary>
    public interface IFinder
    {
        /// <summary>
        /// Find first element.
        /// </summary>
        /// <typeparam name="T"><see cref="Element"/> and childs.</typeparam>
        /// <returns>Returns <see cref="Element"/> if found, else null.</returns>
        T Find<T>();

        /// <summary>
        /// Find first element by id.
        /// </summary>
        /// <param name="id"><see cref="Element"/> ID property.</param>
        /// <typeparam name="T"><see cref="Element"/> and childs.</typeparam>
        /// <returns>Returns <see cref="Element"/> if found, else null.</returns>
        T FindById<T>(string id);

        /// <summary>
        /// Find first element by name that contains string.
        /// </summary>
        /// <param name="name"><see cref="Element"/> name property.</param>
        /// <typeparam name="T"><see cref="Element"/> and childs.</typeparam>
        /// <returns>Returns <see cref="Element"/> if found, else null.</returns>
        T FindByName<T>(string name);

        /// <summary>
        /// Find element by window handle.
        /// </summary>
        /// <param name="handle">Window handle.</param>
        /// <typeparam name="T"><see cref="Element"/> and childs.</typeparam>
        /// <returns>Returns <see cref="Element"/> if found, else null.</returns>
        T FindByWindowHandle<T>(int handle);

        /// <summary>
        /// Find all elements.
        /// </summary>
        /// <typeparam name="T"><see cref="Element"/> and childs.</typeparam>
        /// <returns>Returns <see cref="Element"/> if found, else null.</returns>;
        List<T> FindAll<T>();
    }
}