namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface IMultipleView
    {
        int CurrentView { get; }
        int[] GetSupportedViews();
        string GetViewName(int viewId);
        void SetCurrentView(int viewId);
    }
}
