namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation.Provider;

    /// <summary>
    /// To implement <see cref="IValueProvider"/>.
    /// </summary>
    public interface IValue
    {
        /// <summary>
        /// Gets a value indicating whether a value that specifies whether the value of a control is read-only.
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Gets the value of the control.
        /// </summary>
        string Value { get; }

        /// <summary>
        /// Sets the value of a control.
        /// </summary>
        /// <param name="value">The value to set. The provider is responsible for converting the value to the appropriate data type.</param>
        void SetValue(string value);
    }
}