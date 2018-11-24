namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    interface IMultipleView
    {
        int CurrentView { get; }
        int[] GetSupportedViews();
        string GetViewName(int viewId);
        void SetCurrentView(int viewId);
    }
}
