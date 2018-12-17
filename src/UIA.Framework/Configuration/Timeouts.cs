namespace UIA.Framework.Configuration
{
    /// <summary>
    /// Global framework timeouts.
    /// </summary>
    public class Timeouts
    {
        /// <summary>
        /// Delay of any action that was invocated using <see cref="ActionHandler"/>.
        /// </summary>
        public const int Action = 100;

        /// <summary>
        /// Delay between <see cref="Devices.Mouse"/> and <see cref="Devices.Keyboard"/> actions.
        /// </summary>
        public const int Device = 100;

        /// <summary>
        /// Maximum on any searching <see cref="Viewers.IFinder"/> action.
        /// </summary>
        public const int Search = 100;
    }
}
