namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.TreeItem"/>.
    /// </summary>
    public class TreeItem : Element, ITreeItem
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeItem"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.TreeItem"/>.</param>
        public TreeItem(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public ExpandCollapseState ExpandCollapseState => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Current.ExpandCollapseState;

        /// <inheritdoc/>
        public bool IsSelected => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).Current.IsSelected;

        /// <inheritdoc/>
        public AutomationElement SelectionContainer => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).Current.SelectionContainer;

        /// <inheritdoc/>
        public ToggleState ToggleState => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Current.ToggleState;

        /// <inheritdoc/>
        public void AddToSelection() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).AddToSelection());

        /// <inheritdoc/>
        public void Invoke() => ActionHandler.Perform(() => ((InvokePattern)this.GetCurrentPattern(InvokePattern.Pattern)).Invoke());

        /// <inheritdoc/>
        public void Expand() => ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Expand());

        /// <inheritdoc/>
        public void Collapse() => ActionHandler.Perform(() => ((ExpandCollapsePattern)this.GetCurrentPattern(ExpandCollapsePattern.Pattern)).Collapse());

        /// <inheritdoc/>
        public void RemoveFromSelection() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).RemoveFromSelection());

        /// <inheritdoc/>
        public void ScrollIntoView() => ActionHandler.Perform(() => ((ScrollItemPattern)this.GetCurrentPattern(ScrollItemPattern.Pattern)).ScrollIntoView());

        /// <inheritdoc/>
        public void Select() => ActionHandler.Perform(() => ((SelectionItemPattern)this.GetCurrentPattern(SelectionItemPattern.Pattern)).Select());

        /// <inheritdoc/>
        public void Toggle() => ActionHandler.Perform(() => ((TogglePattern)this.GetCurrentPattern(TogglePattern.Pattern)).Toggle());
    }
}