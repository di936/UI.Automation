using System.Threading;

namespace UIA.Framework.Helpers
{
    public static class Wait
    {
        public static void Milliseconds(int ms)
        {
            Thread.Sleep(ms);
        }

        public static void Seconds(int seconds)
        {
            Milliseconds(seconds * 1000);
        }

        public static void Minutes(int minutes)
        {
            Seconds(minutes * 60);
        }
    }
}
