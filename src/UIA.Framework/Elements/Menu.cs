using System.Windows.Automation;
using UIA.Framework.Viewers;

namespace UIA.Framework.Elements
{
    public class Menu : Element
    {
        public Menu(AutomationElement element) : base(element)
        {
            
        }

        public void InvokeByPath(string[] path)
        {
            var element = new TreeViewer(RawElement).FindByName<MenuItem>(path[0]);
            if (path.Length > 1)
            {
                element.Expand();
                for (var i = 1; i < path.Length; i++)
                {
                    element = new TreeViewer(element.RawElement).FindByName<Menu>(path[i - 1]).FindByName<MenuItem>(path[i]);
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