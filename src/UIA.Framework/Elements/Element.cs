using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Automation;
using UIA.Framework.Elements.Mappings;
using UIA.Framework.Viewers;

namespace UIA.Framework.Elements
{
    ///<summary>
    /// Basic UI element. Wrapper for <see cref="AutomationElement"/>
    ///</summary>
    public class Element : TreeViewer, IElement
    {
        public ControlType RawType => RawElement.Current.ControlType;
        public Element(AutomationElement element) : base(element)
        {

        }
    }
}
