namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    interface IValue
    {
        bool IsReadOnly { get; }
        string Value { get; }
        void SetValue(string value);
    }
}
