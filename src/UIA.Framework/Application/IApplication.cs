namespace UIA.Framework.Application
{
    using UIA.Framework.Elements;
    using UIA.Framework.Viewers;

    public interface IApplication : IFinder
    {
        /// <summary>
        /// Gets or sets current <see cref="Window"/> instance where objects are searched.
        /// </summary>
        Window CurrentWindow { get; set; }

        /// <summary>
        /// Sets current window.
        /// </summary>
        /// <param name="windowName">Window name.</param>
        void SetCurrentWindow(string windowName);
    }
}