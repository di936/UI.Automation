namespace UIA.Framework.Devices
{
    using UIA.Framework.Configuration;
    using UIA.Framework.Helpers;

    /// <summary>
    /// Interaction with mouse using WindowsAPI.
    /// </summary>
    public static class Mouse
    {
        /// <summary>
        /// Click on point with coordinates <paramref name="x"/> and <paramref name="y"/>.
        /// </summary>
        /// <param name="x">X coordinate of clickable point.</param>
        /// <param name="y">Y coordinate of clickable point.</param>
        public static void Click(int x, int y)
        {
            // Get absolute coordinates on current screen
            var absX = WindowsAPI.CalculateAbsoluteCoordinateX(x);
            var absY = WindowsAPI.CalculateAbsoluteCoordinateY(y);

            // Move mouse to (absX,absY) coordinates
            WindowsAPI.MouseEvent((int)MouseCommands.Absolute | (int)MouseCommands.Move, absX, absY, 0, 0);

            // Necessary wait before click
            Wait.Milliseconds(Timeouts.Device);

            // Press and uUnpress LMB
            WindowsAPI.MouseEvent((int)MouseCommands.LeftDown | (int)MouseCommands.LeftUp, 0, 0, 0, 0);
        }
    }
}