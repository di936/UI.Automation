using UIA.Framework.Elements.Patterns.ControlPatterns;

namespace UIA.Framework.Elements.Patterns.ElementPatterns
{
    public interface IMenuBar : IElement, IExpandCollapse, IDock, ITransform
    {
        void InvokeByPath(string[] path);
    }
}