namespace UIA.Framework.Viewers
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Automation;
    using UIA.Framework.Configuration;
    using UIA.Framework.Elements;
    using UIA.Framework.Elements.Mappings;
    using UIA.Framework.Helpers;

    /// <summary>
    /// Tree Viewer for application elements tree. Wrapper for <see cref="TreeWalker"/>.
    /// </summary>
    public class TreeViewer : IFinder
    {
        /// <summary>
        /// Gets scope within <see cref="TreeViewer"/> searchs <see cref="AutomationElement"/>s.
        /// </summary>
        public AutomationElement RootElement { get; }

        /// <summary>
        /// <see cref="TreeWalker"/> mode.
        /// </summary>
        public ViewerMode Mode;

        /// <summary>
        /// <see cref="TreeScope"/> shows what elements should be searched.
        /// </summary>
        public TreeScope SearchScope = TreeScope.Element | TreeScope.Children | TreeScope.Descendants;

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeViewer"/> class.
        /// </summary>
        /// <param name="element"><see cref="AutomationElement"/> where elements are searched.</param>
        /// <param name="mode"><see cref="TreeWalker"/> mode.</param>
        public TreeViewer(AutomationElement element, ViewerMode mode = ViewerMode.RawView)
        {
            this.RootElement = element;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeViewer"/> class.
        /// </summary>
        /// <param name="handle">Handle of the object within which objects will be searched.</param>
        /// <param name="mode"><see cref="TreeWalker"/> mode.</param>
        public TreeViewer(IntPtr handle, ViewerMode mode = ViewerMode.RawView)
        {
            this.RootElement = AutomationElement.FromHandle(handle);
            this.Mode = mode;
        }

        /// <summary>
        /// Gets <see cref="TreeWalker"/> instance depending on which <see cref="Mode"/> used./>.
        /// </summary>
        public TreeWalker Walker
        {
            get
            {
                switch (this.Mode)
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

        /// <inheritdoc/>
        public T Find<T>()
        {
            Wait.Milliseconds(Timeouts.Search);
            var condition = new PropertyCondition(AutomationElement.ControlTypeProperty, ControlTypeDictionary.GetControlType<T>());
            var element = this.RootElement.FindFirst(this.SearchScope, condition);
            return element != null ? (T)Activator.CreateInstance(typeof(T), element) : throw new ElementNotFoundException($"\"{typeof(T).Name}\" not found");
        }

        /// <inheritdoc/>
        public T FindById<T>(string id)
        {
            Wait.Milliseconds(Timeouts.Search);
            var condition = new AndCondition(
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlTypeDictionary.GetControlType<T>()),
                new PropertyCondition(AutomationElement.AutomationIdProperty, id)
            );

            var element = this.RootElement.FindFirst(this.SearchScope, condition);
            return element != null ? (T)Activator.CreateInstance(typeof(T), element) : throw new ElementNotFoundException($"\"{typeof(T).Name}\" with id: \"{id}\" not found");
        }

        /// <inheritdoc/>
        public T FindByName<T>(string name)
        {
            Wait.Milliseconds(Timeouts.Search);
            AutomationElement automationElement = this.RootElement;
            var result = this.FindFirstDescendant(
                automationElement,
                element => element.Current.ControlType.Equals(ControlTypeDictionary.GetControlType<T>()) && element.Current.Name.Contains(name));
            return result != null ? (T)Activator.CreateInstance(typeof(T), result) : throw new ElementNotFoundException($"\"{typeof(T).Name}\" with name: \"{name}\" not found");
        }

        /// <inheritdoc/>
        public List<T> FindAll<T>()
        {
            Wait.Milliseconds(Timeouts.Search);
            var condition = new PropertyCondition(AutomationElement.ControlTypeProperty, ControlTypeDictionary.GetControlType<T>());
            var collection = this.RootElement.FindAll(this.SearchScope, condition);
            List<T> elements = new List<T>();
            foreach (var element in collection)
            {
                elements.Add((T)Activator.CreateInstance(typeof(T), element));
            }

            return elements.Count != 0 ? elements : throw new ElementNotFoundException($"\"{typeof(T).Name}\" not found");
        }

        /// <inheritdoc/>
        public T FindByWindowHandle<T>(int handle)
        {
            Wait.Milliseconds(Timeouts.Search);
            var condition = new AndCondition(
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlTypeDictionary.GetControlType<T>()),
                new PropertyCondition(AutomationElement.NativeWindowHandleProperty, handle)
            );

            var element = this.RootElement.FindFirst(this.SearchScope, condition);
            return element != null ? (T)Activator.CreateInstance(typeof(T), element) : throw new ElementNotFoundException($"\"{typeof(T).Name}\" not found");
        }

        /// <summary>
        /// Find first <see cref="AutomationElement"/> within <see cref="RootElement"/> depending on <paramref name="condition"/>.
        /// </summary>
        /// <param name="element"><see cref="RootElement"/> or any <see cref="AutomationElement"/> where elements are searched.</param>
        /// <param name="condition">Elements searching condition(s).</param>
        /// <returns><see cref="AutomationElement"/> if found, else null.</returns>
        private AutomationElement FindFirstDescendant(AutomationElement element, Func<AutomationElement, bool> condition)
        {
            element = this.Walker.GetFirstChild(element);
            while (element != null)
            {
                if (condition(element))
                {
                    return element;
                }

                var subElement = this.FindFirstDescendant(element, condition);
                if (subElement != null)
                {
                    return subElement;
                }

                element = this.Walker.GetNextSibling(element);
            }

            return null;
        }
    }
}