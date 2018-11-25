namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface IRangeValue
    {
        bool RangeIsReadOnly { get; }
        double LargeChange { get; }
        double Maximum { get; }
        double Minimum { get; }
        double SmallChange { get; }
        double RangeValue { get; }
        void SetRangeValue(double value);
    }
}
