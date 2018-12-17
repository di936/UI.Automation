namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.DataItem"/>.
    /// </summary>
    public class DataItem : Element, IDataItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataItem"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.DataItem"/>.</param>
        public DataItem(AutomationElement element) : base(element)
        {
        }

        /// <inheritdoc/>
        public ExpandCollapseState ExpandCollapseState => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Current.ExpandCollapseState;

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
        public ToggleState ToggleState => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Current.ToggleState;

        /// <inheritdoc/>
        public bool IsReadOnly => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).Current.IsReadOnly;

        /// <inheritdoc/>
        public string Value => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).Current.Value;

        /// <inheritdoc/>
        public void AddToSelection() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).AddToSelection());

        /// <inheritdoc/>
        public void Collapse() =>  ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Collapse());

        /// <inheritdoc/>
        public void Expand() => ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Expand());

        /// <inheritdoc/>
        public AutomationElement[] GetColumnHeaderItems() => ActionHandler.Perform(() => ((TableItemPattern)this.GetCurrentPattern(TableItemPattern.Pattern)).Current.GetColumnHeaderItems());

        /// <inheritdoc/>
        public AutomationElement[] GetRowHeaderItems() => ActionHandler.Perform(() => ((TableItemPattern)this.GetCurrentPattern(TableItemPattern.Pattern)).Current.GetRowHeaderItems());

        /// <inheritdoc/>
        public void RemoveFromSelection() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).RemoveFromSelection());

        /// <inheritdoc/>
        public void ScrollIntoView() => ActionHandler.Perform(() => ((ScrollItemPattern)this.GetCurrentPattern(ScrollItemPattern.Pattern)).ScrollIntoView());

        /// <inheritdoc/>
        public void Select() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).Select());

        /// <inheritdoc/>
        public void SetValue(string value) => ActionHandler.Perform(() => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).SetValue(value));

        /// <inheritdoc/>
        public void Toggle() => ActionHandler.Perform(() => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Toggle());
    }
}