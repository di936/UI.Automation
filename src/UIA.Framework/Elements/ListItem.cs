namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.ListItem"/>.
    /// </summary>
    public class ListItem : Element, IListItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.ListItem"/>.</param>
        public ListItem(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public bool CanSelectMultiple => ((SelectionPattern)this.GetCurrentPattern(SelectionPattern.Pattern)).Current.CanSelectMultiple;

        /// <inheritdoc/>
        public bool IsSelectionRequired => ((SelectionPattern)this.GetCurrentPattern(SelectionPattern.Pattern)).Current.IsSelectionRequired;

        /// <inheritdoc/>
        public bool HorizontallyScrollable => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontallyScrollable;

        /// <inheritdoc/>
        public double HorizontalScrollPercent => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalScrollPercent;

        /// <inheritdoc/>
        public double HorizontalViewSize => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.HorizontalViewSize;

        /// <inheritdoc/>
        public bool VerticallyScrollable => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticallyScrollable;

        /// <inheritdoc/>
        public double VerticalScrollPercent => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalScrollPercent;

        /// <inheritdoc/>
        public double VerticalViewSize => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Current.VerticalViewSize;

        /// <inheritdoc/>
        public ToggleState ToggleState => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Current.ToggleState;

        /// <inheritdoc/>
        public ExpandCollapseState ExpandCollapseState => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Current.ExpandCollapseState;

        /// <inheritdoc/>
        public bool IsReadOnly => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).Current.IsReadOnly;

        /// <inheritdoc/>
        public string Value => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).Current.Value;

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
        public void Collapse() => ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Collapse());

        /// <inheritdoc/>
        public void Expand() => ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Expand());

        /// <inheritdoc/>
        public AutomationElement[] GetSelection() => ActionHandler.Perform(() => ((SelectionPattern)this.GetCurrentPattern(SelectionPattern.Pattern)).Current.GetSelection());

        /// <inheritdoc/>
        public void Invoke() => ActionHandler.Perform(() => ((InvokePattern)this.GetCurrentPattern(InvokePattern.Pattern)).Invoke());

        /// <inheritdoc/>
        public void Scroll(ScrollAmount horizontalAmount = 0, ScrollAmount verticalAmount = 0) => ActionHandler.Perform(() => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).Scroll(horizontalAmount, verticalAmount));

        /// <inheritdoc/>
        public void SetScrollPercent(double horizontalPercent, double verticalPercent) => ActionHandler.Perform(() => ((ScrollPattern)this.GetCurrentPattern(ScrollPattern.Pattern)).SetScrollPercent(horizontalPercent, verticalPercent));

        /// <inheritdoc/>
        public void SetValue(string value) => ActionHandler.Perform(() => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).SetValue(value));

        /// <inheritdoc/>
        public void Toggle() => ActionHandler.Perform(() => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Toggle());
    }
}