namespace UIA.Framework.Elements.Patterns.ControlPatterns
{
    public interface ITransform
    {
        bool CanMove { get; }
        bool CanResize { get; }
        bool CanRotate { get; }
        void Move(double x, double y);
        void Resize(double width, double height);
        void Rotate(double degrees);
    }
}
