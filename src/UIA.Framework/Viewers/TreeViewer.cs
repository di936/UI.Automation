using System;
using System.Collections.Generic;
using System.Windows.Automation;
using UIA.Framework.Elements;
using UIA.Framework.Elements.Mappings;

namespace UIA.Framework.Viewers
{
    ///<summary>
    /// Tree Viewer for application elements tree. Wrapper for <see cref="TreeWalker"/>
    ///</summary>
    public class TreeViewer : IFinder
    {
        public readonly AutomationElement RootElement;

        public TreeWalker Walker
        {
            get
            {
                switch (Mode)
                {
                    case ViewerMode.RawView:
                        return TreeWalker.RawViewWalker;
                    case ViewerMode.ContentView:
                        return TreeWalker.ContentViewWalker;
                    case ViewerMode.ControlView:
                        return TreeWalker.ControlViewWalker;
                }

                return null;
            }
        }

        public ViewerMode Mode;

        public TreeScope SearchScope = TreeScope.Element | TreeScope.Children | TreeScope.Descendants;

        private AutomationElement FindFirstDescendant(AutomationElement element, Func<AutomationElement, bool> condition)
        {
            element = Walker.GetFirstChild(element);
            while (element != null)
            {
                if (condition(element)) return element;
                var subElement = FindFirstDescendant(element, condition);
                if (subElement != null) return subElement;
                element = Walker.GetNextSibling(element);
            }

            return null;
        }

        public TreeViewer(AutomationElement element, ViewerMode mode = ViewerMode.RawView)
        {
            RootElement = element;
            Mode = mode;
        }

        ///<summary>
        /// Find first element
        ///</summary>
        public T Find<T>()
        {
            var condition = new PropertyCondition(AutomationElement.ControlTypeProperty, ControlTypeDictionary.GetControlType<T>());
            var element = RootElement.FindFirst(SearchScope, condition);
            return element != null ? (T)Activator.CreateInstance(typeof(T), element) : throw new ElementNotFoundException($"\"{typeof(T).Name}\" not found");
        }

        ///<summary>
        /// Find first element by id
        ///</summary>
        public T FindById<T>(string id)
        {
            var condition = new AndCondition(
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlTypeDictionary.GetControlType<T>()),
                new PropertyCondition(AutomationElement.AutomationIdProperty, id)
            );

            var element =  RootElement.FindFirst(SearchScope, condition);
            return element != null ? (T)Activator.CreateInstance(typeof(T), element) : throw new ElementNotFoundException($"\"{typeof(T).Name}\" with id: \"{id}\" not found");
        }

        ///<summary>
        /// Find first element by name that contains string
        ///</summary>
        public T FindByName<T>(string name)
        {
            AutomationElement automationElement = RootElement;
            var result = FindFirstDescendant(automationElement, 
                element => element.Current.ControlType.Equals(ControlTypeDictionary.GetControlType<T>()) && element.Current.Name.Contains(name));
            return result != null ? (T)Activator.CreateInstance(typeof(T), result) : throw new ElementNotFoundException($"\"{typeof(T).Name}\" with name: \"{name}\" not found");
        }

        ///<summary>
        /// Find all elements
        ///</summary>
        public List<T> FindAll<T>()
        {
            var condition = new PropertyCondition(AutomationElement.ControlTypeProperty, ControlTypeDictionary.GetControlType<T>());
            var collection = RootElement.FindAll(SearchScope, condition);
            List<T> elements = new List<T>();
            foreach (var element in collection)
            {
                elements.Add((T)Activator.CreateInstance(typeof(T), element));
            }

            return elements.Count != 0 ? elements : throw new ElementNotFoundException($"\"{typeof(T).Name}\" not found");
        }

        public T FindByWindowHandle<T>(int handle)
        {
            var condition = new AndCondition(
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlTypeDictionary.GetControlType<T>()),
                new PropertyCondition(AutomationElement.NativeWindowHandleProperty, handle)
            );

            var element = RootElement.FindFirst(SearchScope, condition);
            return element != null ? (T)Activator.CreateInstance(typeof(T), element) : throw new ElementNotFoundException($"\"{typeof(T).Name}\" not found");
        }
    }
}