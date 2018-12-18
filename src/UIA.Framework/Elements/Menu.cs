namespace UIA.Framework.Elements
{
    using System.Windows.Automation;
    using UIA.Framework.Elements.Patterns.ElementPatterns;
    using UIA.Framework.Viewers;

    /// <summary>
    /// Wrapper for <see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Menu"/>.
    /// </summary>
    public class Menu : Element, IMenu
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Menu"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> with <see cref="ControlType"/> <see cref="ControlType.Menu"/>.</param>
        public Menu(AutomationElement element)
            : base(element)
        {
        }

        /// <inheritdoc/>
        public void InvokeByPath(string[] path)
        {
            var element = new TreeViewer(this.RawElement).FindByName<MenuItem>(path[0]);
            if (path.Length > 1)
            {
                element.Expand();
                for (var i = 1; i <= path.Length - 1; i++)
                {
                    element = new TreeViewer(element.RawElement).FindByName<MenuItem>(path[i]);
                    if (i == path.Length - 1)
                    {
                        element.Invoke();
                    }
                    else
                    {
                        element.Expand();
                    }
                }
            }
            else
            {
                element.Invoke();
            }
        }
    }
}