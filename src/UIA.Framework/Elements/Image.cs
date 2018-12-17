namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Image"/>.
    /// </summary>
    public class Image : Element, IImage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Image"/>.</param>
        public Image(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public int Column => ((GridItemPattern)this.GetCurrentPattern(GridItemPattern.Pattern)).Current.Column;

        /// <inheritdoc/>
        public int ColumnSpan => ((GridItemPattern)this.GetCurrentPattern(GridItemPattern.Pattern)).Current.ColumnSpan;

        /// <inheritdoc/>
        public AutomationElement ContainingGrid => ((GridItemPattern)this.GetCurrentPattern(GridItemPattern.Pattern)).Current.ContainingGrid;

        /// <inheritdoc/>
        public int Row => ((GridItemPattern)this.GetCurrentPattern(GridItemPattern.Pattern)).Current.Row;

        /// <inheritdoc/>
        public int RowSpan => ((GridItemPattern)this.GetCurrentPattern(GridItemPattern.Pattern)).Current.RowSpan;

        /// <inheritdoc/>
        public bool IsSelected => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).Current.IsSelected;

        /// <inheritdoc/>
        public AutomationElement SelectionContainer => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).Current.SelectionContainer;

        /// <inheritdoc/>
        public void AddToSelection() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).AddToSelection());

        /// <inheritdoc/>
        public AutomationElement[] GetColumnHeaderItems() => ActionHandler.Perform(() => ((TableItemPattern)this.GetCurrentPattern(TableItemPattern.Pattern)).Current.GetColumnHeaderItems());

        /// <inheritdoc/>
        public AutomationElement[] GetRowHeaderItems() => ActionHandler.Perform(() => ((TableItemPattern)this.GetCurrentPattern(TableItemPattern.Pattern)).Current.GetRowHeaderItems());

        /// <inheritdoc/>
        public void RemoveFromSelection() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).RemoveFromSelection());

        /// <inheritdoc/>
        public void Invoke() => ActionHandler.Perform(() => ((InvokePattern)this.GetCurrentPattern(InvokePattern.Pattern)).Invoke());

        /// <inheritdoc/>
        public void Select() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).Select());
    }
}