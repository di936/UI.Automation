namespace UIA.Framework.Elements
{
    using System;

    /// <summary>
    /// Indicates that automation element or object was not found.
    /// </summary>
    internal class ElementNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementNotFoundException"/> class.
        /// </summary>
        /// <param name="message">Message with error and element information.</param>
        public ElementNotFoundException(string message)
            : base(message)
        {
        }
    }
}