namespace UIA.Framework.Elements.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Automation;

    /// <summary>
    /// Dictionary that maps UIAutomation <see cref="ControlType"/>s with this framework's <see cref="Element"/> objects.
    /// </summary>
    internal static class ControlTypeDictionary
    {
        /// <summary>
        /// Dictionary with mappings: <see cref="Element"/> objects to <see cref="ControlType"/> objects.
        /// </summary>
        private static readonly Dictionary<Type, ControlType> Types = new Dictionary<Type, ControlType>()
        {
            {typeof(Button), ControlType.Button},
            {typeof(Calendar), ControlType.Calendar},
            {typeof(CheckBox), ControlType.CheckBox},
            {typeof(ComboBox), ControlType.ComboBox},
            {typeof(Custom), ControlType.Custom},
            {typeof(DataGrid), ControlType.DataGrid},
            {typeof(DataItem), ControlType.DataItem},
            {typeof(Document), ControlType.Document},
            {typeof(Group), ControlType.Group},
            {typeof(Edit), ControlType.Edit},
            {typeof(Header), ControlType.Header},
            {typeof(HeaderItem), ControlType.HeaderItem},
            {typeof(HyperLink), ControlType.Hyperlink},
            {typeof(Image), ControlType.Image},
            {typeof(List), ControlType.List},
            {typeof(ListItem), ControlType.ListItem},
            {typeof(Menu), ControlType.Menu},
            {typeof(MenuBar), ControlType.MenuBar},
            {typeof(MenuItem), ControlType.MenuItem},
            {typeof(Pane), ControlType.Pane},
            {typeof(ProgressBar), ControlType.ProgressBar},
            {typeof(RadioButton), ControlType.RadioButton},
            {typeof(ScrollBar), ControlType.ScrollBar},
            {typeof(Separator), ControlType.Separator},
            {typeof(Slider), ControlType.Slider},
            {typeof(Spinner), ControlType.Spinner},
            {typeof(SplitButton), ControlType.SplitButton},
            {typeof(StatusBar), ControlType.StatusBar},
            {typeof(Tab), ControlType.Tab},
            {typeof(TabItem), ControlType.TabItem},
            {typeof(Table), ControlType.Table},
            {typeof(Text), ControlType.Text},
            {typeof(Thumb), ControlType.Thumb},
            {typeof(TitleBar), ControlType.TitleBar},
            {typeof(ToolBar), ControlType.ToolBar},
            {typeof(ToolTip), ControlType.ToolTip},
            {typeof(Tree), ControlType.Tree},
            {typeof(TreeItem), ControlType.TreeItem},
            {typeof(Window), ControlType.Window},
        };

        /// <summary>
        /// Maps <typeparamref name="T"/> to <see cref="ControlType"/>.
        /// </summary>
        /// <typeparam name="T"><see cref="Element"/> object that should be mapped.</typeparam>
        /// <returns><see cref="ControlType"/> that is mapping to <typeparamref name="T"/>.</returns>
        public static ControlType GetControlType<T>()
        {
            return Types.First(pair => pair.Key.IsEquivalentTo(typeof(T))).Value;
        }

        /// <summary>
        /// Maps <see cref="ControlType"/> to <see cref="Element"/>.
        /// </summary>
        /// <param name="controlType"><see cref="ControlType"/> object that should be mapped.</param>
        /// <returns><see cref="Element"/> that is mapping to <paramref name="controlType"/>.</returns>
        public static Type GetType(ControlType controlType)
        {
            return Types.First(pair => pair.Value.Equals(controlType)).Key;
        }
    }
}
