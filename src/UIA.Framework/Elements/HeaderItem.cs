namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements.Patterns.ElementPatterns;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.HeaderItem"/>.
    /// </summary>
    public class HeaderItem : Element, IHeaderItem
    {
        public HeaderItem(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public bool CanMove => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanMove;

        /// <inheritdoc/>
        public bool CanResize => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanResize;

        /// <inheritdoc/>
        public bool CanRotate => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Current.CanRotate;

        /// <inheritdoc/>
        public void Invoke() => ActionHandler.Perform(() => ((InvokePattern)this.GetCurrentPattern(InvokePattern.Pattern)).Invoke());

        /// <inheritdoc/>
        public void Move(double x, double y) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Move(x, y));

        /// <inheritdoc/>
        public void Resize(double width, double height) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Resize(width, height));

        /// <inheritdoc/>
        public void Rotate(double degrees) => ActionHandler.Perform(() => ((TransformPattern)this.GetCurrentPattern(TransformPattern.Pattern)).Rotate(degrees));
    }
}