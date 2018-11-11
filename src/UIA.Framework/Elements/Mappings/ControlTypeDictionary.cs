using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;

namespace UIA.Framework.Elements.Mappings
{
    internal static class ControlTypeDictionary
    {
        private static readonly Dictionary<Type, ControlType> _types = new Dictionary<Type, ControlType>()
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
            {typeof(Window), ControlType.Window}
        };

        public static ControlType GetControlType<T>()
        {
            return _types.First(pair => pair.Key.IsEquivalentTo(typeof(T))).Value;
        }
        public static Type GetType(ControlType controlType)
        {
            return _types.First(pair => pair.Value.Equals(controlType)).Key;
        }
    }
}
