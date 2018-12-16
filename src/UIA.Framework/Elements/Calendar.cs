namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Calendar"/>.
    /// </summary>
    public class Calendar : Element, ICalendar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Calendar"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Calendar"/>.</param>
        public Calendar(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public int ColumnCount => ((GridPattern)this.GetCurrentPattern(GridPattern.Pattern)).Current.ColumnCount;

        /// <inheritdoc/>
        public int RowCount => ((GridPattern)this.GetCurrentPattern(GridPattern.Pattern)).Current.RowCount;

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
        public bool CanSelectMultiple => ((SelectionPattern)this.GetCurrentPattern(SelectionPattern.Pattern)).Current.CanSelectMultiple;

        /// <inheritdoc/>
        public bool IsSelectionRequired => ((SelectionPattern)this.GetCurrentPattern(SelectionPattern.Pattern)).Current.IsSelectionRequired;

        /// <inheritdoc/>
        public RowOrColumnMajor RowOrColumnMajor => ((TablePattern)this.GetCurrentPattern(TablePattern.Pattern)).Current.RowOrColumnMajor;

        /// <inheritdoc/>
        public bool IsReadOnly => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).Current.IsReadOnly;

        /// <inheritdoc/>
        public string Value => ((ValuePattern)this.GetCurrentPattern(ValuePattern.Pattern)).Current.Value;

        /// <inheritdoc/>
        public AutomationElement GetItem(int row, int column) => ActionHandler.Perform(() => ((GridPattern)RawElement.this.GetCurrentPattern(GridPattern.Pattern)).GetItem(row, column));

        /// <inheritdoc/>
        public void Scroll(ScrollAmount horizontalAmount = 0, ScrollAmount verticalAmount = 0) => ActionHandler.Perform(() => ((ScrollPattern)RawElement.this.GetCurrentPattern(ScrollPattern.Pattern)).Scroll(horizontalAmount, verticalAmount));

        /// <inheritdoc/>
        public void SetScrollPercent(double horizontalPercent, double verticalPercent) => ActionHandler.Perform(() => ((ScrollPattern)RawElement.this.GetCurrentPattern(ScrollPattern.Pattern)).SetScrollPercent(horizontalPercent, verticalPercent));

        /// <inheritdoc/>
        public AutomationElement[] GetSelection() => ActionHandler.Perform(() => ((SelectionPattern)RawElement.this.GetCurrentPattern(SelectionPattern.Pattern)).Current.GetSelection());

        /// <inheritdoc/>
        public AutomationElement[] GetColumnHeaders() => ActionHandler.Perform(() => ((TablePattern)RawElement.this.GetCurrentPattern(TablePattern.Pattern)).Current.GetColumnHeaders());

        /// <inheritdoc/>
        public AutomationElement[] GetRowHeaders() => ActionHandler.Perform(() => ((TablePattern)RawElement.this.GetCurrentPattern(TablePattern.Pattern)).Current.GetRowHeaders());

        /// <inheritdoc/>
        public void SetValue(string value) => ActionHandler.Perform(() => ((ValuePattern)RawElement.this.GetCurrentPattern(ValuePattern.Pattern)).SetValue(value));
    }
}
