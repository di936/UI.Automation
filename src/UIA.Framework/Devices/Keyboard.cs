namespace UIA.Framework.Devices
{
    using UIA.Framework.Configuration;
    using UIA.Framework.Helpers;

    /// <summary>
    /// Interaction with keyboard using WindowsAPI.
    /// </summary>
    internal static class Keyboard
    {
        /// <summary>
        /// Interaction with keyboard using WindowsAPI.
        /// </summary>
        /// <param name="key">Keyboard key that should be pressed and unpressed.</param>
        public static void PressKey(VirtualKeys key)
        {
            // Press key
            WindowsAPI.KeyboardEvent((int)key, 0, (int)KeyboardCommands.ExtendedKey, 0);

            // Necessary wait
            Wait.Milliseconds(Timeouts.Device);

            // Unpress key
            WindowsAPI.KeyboardEvent((int)key, 0, (int)KeyboardCommands.KeyUp, 0);
        }
    }
}
