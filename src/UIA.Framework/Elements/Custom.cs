using System.Windows.Automation;
using UIA.Framework.Elements.Patterns.ElementPatterns;

namespace UIA.Framework.Elements
{
    public class Custom : Element, ICustom
    {
        public Custom(AutomationElement element) : base(element)
        {

        }
    }
}