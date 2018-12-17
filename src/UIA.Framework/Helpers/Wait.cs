namespace UIA.Framework.Helpers
{
    using System.Threading;

    /// <summary>
    /// Static waiter that could be used from anywhere in project
    /// </summary>
    internal static class Wait
    {
        /// <summary>
        /// Wait milliseconds.
        /// </summary>
        /// <param name="ms">Milliseconds</param>
        public static void Milliseconds(int ms) => Thread.Sleep(ms);

        /// <summary>
        /// Wait seconds.
        /// </summary>
        /// <param name="seconds">Milliseconds * <paramref name="seconds"/>.</param>
        public static void Seconds(int seconds) => Milliseconds(seconds * 1000);

        /// <summary>
        /// Wait minutes.
        /// </summary>
        /// <param name="minutes">Milliseconds * Seconds * <paramref name="minutes"/>.</param>
        public static void Minutes(int minutes) => Seconds(minutes * 60);
    }
}