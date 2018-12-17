namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    using System.Windows.Automation.Provider;
    using System.Windows.Automation.Text;

    /// <summary>
    /// To implement <see cref="ITextRangeProvider"/>.
    /// </summary>
    public interface ITextRange
    {
        /// <summary>
        /// Adds to the collection of highlighted text in a text container that supports multiple, disjoint selections.
        /// </summary>
        void AddToSelection();

        /// <summary>
        /// Returns a new <see cref="ITextRangeProvider"/> identical to the original <see cref="ITextRangeProvider"/> and inheriting all properties of the original.
        /// </summary>
        /// <returns>The new text range.</returns>
        ITextRangeProvider Clone();

        /// <summary>
        /// Returns a value that indicates whether the span (the Start endpoint to the End endpoint) of a text range is the same as another text range.
        /// </summary>
        /// <param name="range">A text range to compare</param>
        /// <returns>True if the span of both text ranges is identical; otherwise False.</returns>
        bool Compare(ITextRangeProvider range);

        /// <summary>
        /// Returns a value that specifies whether two text ranges have identical endpoints.
        /// </summary>
        /// <param name="endpoint">The Start or End endpoint of the caller.</param>
        /// <param name="targetRange">The target range for comparison.</param>
        /// <param name="targetEndpoint">The Start or End endpoint of the target.</param>
        /// <returns>
        /// Returns a negative value if the caller's endpoint occurs earlier in the text than the target endpoint.
        /// Returns zero if the caller's endpoint is at the same location as the target endpoint.
        /// Returns a positive value if the caller's endpoint occurs later in the text than the target endpoint.
        /// </returns>
        int CompareEndpoints(TextPatternRangeEndpoint endpoint, ITextRangeProvider targetRange, TextPatternRangeEndpoint targetEndpoint);

        /// <summary>
        /// Expands the text range to the specified text unit.
        /// </summary>
        /// <param name="unit">The textual unit.</param>
        void ExpandToEnclosingUnit(TextUnit unit);

        /// <summary>
        /// Returns a text range subset that has the specified attribute value.
        /// </summary>
        /// <param name="attribute">The attribute to search for.</param>
        /// <param name="value">The attribute value to search for. This value must match the type specified for the attribute.</param>
        /// <param name="backward">True if the last occurring text range should be returned instead of the first; otherwise False.</param>
        /// <returns>A text range having a matching attribute and attribute value; otherwise null (Nothing in Visual Basic).</returns>
        ITextRangeProvider FindAttribute(int attribute, object value, bool backward);

        /// <summary>
        /// Returns a text range subset that contains the specified text.
        /// </summary>
        /// <param name="text">The text string to search for.</param>
        /// <param name="backward">True if the last occurring text range should be returned instead of the first; otherwise False.</param>
        /// <param name="ignoreCase">True if case should be ignored; otherwise False.</param>
        /// <returns>A text range matching the specified text; otherwise null (Nothing in Visual Basic).</returns>
        ITextRangeProvider FindText(string text, bool backward, bool ignoreCase);

        /// <summary>
        /// Retrieves the value of the specified attribute across the text range.
        /// </summary>
        /// <param name="attribute">The text attribute.</param>
        /// <returns>Retrieves an object representing the value of the specified attribute.</returns>
        object GetAttributeValue(int attribute);

        /// <summary>
        /// Retrieves a collection of bounding rectangles for each fully or partially visible line of text in a text range.
        /// </summary>
        /// <returns>
        /// An array of bounding rectangles for each full or partial line of text in a text range. 
        /// An empty array for a degenerate range.
        /// An empty array for a text range that has screen coordinates placing it completely off-screen, scrolled out of view, or obscured by an overlapping window.
        /// </returns>
        double[] GetBoundingRectangles();

        /// <summary>
        /// Retrieves a collection of all embedded objects that fall within the text range.
        /// </summary>
        /// <returns>A collection of child objects that fall within the range.</returns>
        IRawElementProviderSimple[] GetChildren();

        /// <summary>
        /// Returns the innermost control that encloses the text range.
        /// </summary>
        /// <returns>The enclosing control, typically the text provider that supplies the text range.</returns>
        IRawElementProviderSimple GetEnclosingElement();

        /// <summary>
        /// Retrieves the plain text of the range.
        /// </summary>
        /// <param name="maxLength">The maximum length of the string to return. Use -1 if no limit is required.</param>
        /// <returns>The plain text of the text range, possibly truncated at the specified <see cref="maxLength"/>.</returns>
        string GetText(int maxLength);

        /// <summary>
        /// Moves the text range the specified number of text units.
        /// </summary>
        /// <param name="unit">The text unit boundary.</param>
        /// <param name="count">The number of text units to move. A positive value moves the text range forward, a negative value moves the text range backward, and 0 has no effect.</param>
        /// <returns>The number of units actually moved.</returns>
        int Move(TextUnit unit, int count);

        /// <summary>
        /// Moves one endpoint of a text range to the specified endpoint of a second text range.
        /// </summary>
        /// <param name="endpoint">The endpoint to move.</param>
        /// <param name="targetRange">Another range from the same text provider.</param>
        /// <param name="targetEndpoint">An endpoint on the other range.</param>
        void MoveEndpointByRange(TextPatternRangeEndpoint endpoint, ITextRangeProvider targetRange, TextPatternRangeEndpoint targetEndpoint);

        /// <summary>
        /// Moves one endpoint of the text range the specified number of text units within the document range.
        /// </summary>
        /// <param name="endpoint">The endpoint to move.</param>
        /// <param name="unit">The textual unit for moving.</param>
        /// <param name="count">The number of units to move. A positive value moves the endpoint forward. A negative value moves backward. A value of 0 has no effect.</param>
        /// <returns>The number of units actually moved, which can be less than the number requested if moving the endpoint runs into the beginning or end of the document.</returns>
        int MoveEndpointByUnit(TextPatternRangeEndpoint endpoint, TextUnit unit, int count);

        /// <summary>
        /// Removes a highlighted section of text, corresponding to the caller's Start and End endpoints, from the collection of highlighted text in a text container that supports multiple, disjoint selections.
        /// </summary>
        void RemoveFromSelection();

        /// <summary>
        /// Causes the text control to scroll vertically until the text range is visible in the viewport.
        /// </summary>
        /// <param name="alignToTop">True if the text control should be scrolled so the text range is flush with the top of the viewport; False if it should be flush with the bottom of the viewport.</param>
        void ScrollIntoView(bool alignToTop);

        /// <summary>
        /// Highlights text in the text control corresponding to the text range Start and End endpoints.
        /// </summary>
        void Select();
    }
}