namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface IValue
    {
        bool IsReadOnly { get; }
        string Value { get; }
        void SetValue(string value);
    }
}
