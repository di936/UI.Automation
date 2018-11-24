using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UIA.Framework.Devices.Commands;

namespace UIA.Framework.Devices
{
    public static class Mouse
    {
        private static Point screen = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        [StructLayout(LayoutKind.Sequential)]
        public struct CursorInfo
        {
            public uint size;
            public uint flags;
            public IntPtr handle;
            public Point point;

            public static CursorInfo New()
            {
                return new CursorInfo { size = (uint)Marshal.SizeOf(typeof(CursorInfo)) };
            }
        }

        enum SystemMetric
        {
            SM_CXSCREEN = 0,
            SM_CYSCREEN = 1,
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorInfo(ref CursorInfo cursorInfo);

        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        static extern void MouseEvent(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref System.Drawing.Point cursorInfo);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int GetLastError();

        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(SystemMetric smIndex);

        static int CalculateAbsoluteCoordinateX(int x)
        {
            return (x * 65536) / GetSystemMetrics(SystemMetric.SM_CXSCREEN);
        }

        static int CalculateAbsoluteCoordinateY(int y)
        {
            return (y * 65536) / GetSystemMetrics(SystemMetric.SM_CYSCREEN);
        }

        public static void Click(double x, double y)
        {
            var action = (int)MouseCommands.Absolute | (int)MouseCommands.Move | (int)MouseCommands.LeftDown | (int)MouseCommands.LeftUp;
            MouseEvent(action, CalculateAbsoluteCoordinateX((int)x), CalculateAbsoluteCoordinateY((int)y), 0, 0);
        }
    }
}