namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows;
    using System.Windows.Automation;
    using System.Windows.Automation.Text;

    /// <summary>
    /// To implement <see cref="ITextProvider"/>.
    /// </summary>
    public interface IText
    {
        /// <summary>
        /// Gets a text range that encloses the main text of a document.
        /// </summary>
        TextPatternRange DocumentRange { get; }

        /// <summary>
        /// Gets a value that specifies whether a text provider supports selection and, if so, the type of selection supported.
        /// </summary>
        SupportedTextSelection SupportedTextSelection { get; }

        /// <summary>
        /// Retrieves a collection of disjoint text ranges associated with the current text selection or selections.
        /// </summary>
        /// <returns>A collection of disjoint text ranges.</returns>
        TextPatternRange[] GetSelection();

        /// <summary>
        /// Retrieves an array of disjoint text ranges from a text container where each text range begins with the first partially visible line through to the end of the last partially visible line.
        /// </summary>
        /// <returns>The collection of visible text ranges within the container or an empty array.</returns>
        TextPatternRange[] GetVisibleRanges();

        /// <summary>
        /// Retrieves a text range enclosing a child element such as an image, hyperlink, or other embedded object.
        /// </summary>
        /// <param name="childElement">The enclosed object.</param>
        /// <returns>A range that spans the child element.</returns>
        TextPatternRange RangeFromChild(AutomationElement childElement);

        /// <summary>
        /// Returns the degenerate (empty) text range nearest to the specified screen coordinates.
        /// </summary>
        /// <param name="screenLocation">The location in screen coordinates.</param>
        /// <returns>A degenerate range nearest the specified location.</returns>
        TextPatternRange RangeFromPoint(Point screenLocation);
    }
}